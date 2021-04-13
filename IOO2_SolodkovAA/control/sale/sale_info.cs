using System;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace IOO2_SolodkovAA
{
	public partial class sale_info : UserControl
	{
        string id_coming = "";
        public sale_info(string id)
		{
            id_coming = id;
            InitializeComponent();
		}

		private void sale_info_Load(object sender, EventArgs e)
		{
            using (SqlConnection con = new SqlConnection(@"Data source=.\SQLEXPRESS;Initial Catalog=I002_Solodkov;User ID=user;Password=Passw0rd;"))
            {
                try
                {

                    table.Rows.Clear();
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();

                    //заполнение данных
                    cmd.CommandText = "select [psale].id,[product].name,[psale].price,[psale].count from [psale] JOIN[product] ON[product].id =[psale].id_product Where [psale].id_sale=" + id_coming;

                    SqlDataReader reader = cmd.ExecuteReader();
                    int j = 0;
                    while (reader.Read())
                    {
                        table.Rows.Add();
                        table.Rows[j].Cells[0].Value = Convert.ToString(String.Format("{0}", reader[0]));
                        table.Rows[j].Cells[1].Value = Convert.ToString(String.Format("{0}", reader[1]));
                        table.Rows[j].Cells[2].Value = Convert.ToString(String.Format("{0}", reader[2]));
                        table.Rows[j].Cells[3].Value = Convert.ToString(String.Format("{0}", reader[3]));
                        j++;
                    }
                    reader.Close();


                    for (int i = 0; i < table.RowCount; i++)
                    {

                        cmd = con.CreateCommand();
                        cmd.CommandText = "select [psale].price,[psale].count from [psale] JOIN[product] ON[product].id =[psale].id_product Where [product].name='" + Convert.ToString(table.Rows[i].Cells[1].Value) + "'";
                        reader = cmd.ExecuteReader();
                        int k = 0;
                        int pris = 0;
                        while (reader.Read())
                        {
                            pris += Convert.ToInt32(String.Format("{0}", reader[0])) * Convert.ToInt32(String.Format("{0}", reader[1]));
                            k += Convert.ToInt32(String.Format("{0}", reader[1]));
                        }
                        reader.Close();
                        if (k > 0)
                        {
                            pris /= k;
                            table.Rows[i].Cells[2].Value = Convert.ToString(pris * 1.05);
                        }
                    }




                    cmd.CommandText = "select [kontragent].name from [sale] JOIN[kontragent] ON[kontragent].id =[sale].id_kontragent Where [sale].id=" + id_coming;

                    reader = cmd.ExecuteReader();
                    j = 0;
                    while (reader.Read())
                    {
                        textBox2.Text = Convert.ToString(String.Format("{0}", reader[0]));
                    }
                    reader.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                }
                finally
                {
                    con.Close();
                }
            }
        }

		private void button2_Click(object sender, EventArgs e)
		{
            sale_full uc = new sale_full();
            uc.Location = new Point(0, 30);
            uc.Size = Size;
            this.Parent.Controls.Add(uc);
            this.Parent.Controls.RemoveAt(1);
        }

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				//формирование pdf
				iTextSharp.text.Document doc = new iTextSharp.text.Document();

				
				PdfWriter.GetInstance(doc, new FileStream(@""+Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)+@"\order" + id_coming + ".pdf", FileMode.Create));
				doc.Open();

				BaseFont baseFont = BaseFont.CreateFont(@"C:\Windows\Fonts\arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
				iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);





				PdfPTable table2 = new PdfPTable(3);

				PdfPCell cell = new PdfPCell(new Phrase("Продажа #" + id_coming, font));

				cell.Colspan = 3;
				cell.HorizontalAlignment = 1;

				cell.Border = 0;
				table2.AddCell(cell);

				//заголовки таблицы
				cell = new PdfPCell(new Phrase("Товар", font));
				table2.AddCell(cell);

				cell = new PdfPCell(new Phrase("Цена", font));
				table2.AddCell(cell);

				cell = new PdfPCell(new Phrase("Количество", font));
				table2.AddCell(cell);


				for (int i = 0; i < table.Rows.Count; i++)
				{

					table2.AddCell(new PdfPCell(new Phrase(Convert.ToString(table.Rows[i].Cells[1].Value), font)));
					table2.AddCell(new PdfPCell(new Phrase(Convert.ToString(table.Rows[i].Cells[2].Value) + " Руб.", font)));
					table2.AddCell(new PdfPCell(new Phrase(Convert.ToString(table.Rows[i].Cells[3].Value) + " Шт.", font)));
				}


				doc.Add(table2);

				string names = "";
				string adress = "";
				string email = "";
				string dates = "";
				string phones = "";

				using (SqlConnection con = new SqlConnection(@"Data source=.\SQLEXPRESS;Initial Catalog=I002_Solodkov;User ID=user;Password=Passw0rd;"))
				{
					try
					{

						con.Open();
						SqlCommand cmd = con.CreateCommand();
						cmd.CommandText = "select [kontragent].name,[kontragent].adress,[kontragent].email,[sale].date,[kontragent].phone from [sale] JOIN[kontragent] ON[kontragent].id =[sale].id_kontragent Where [sale].id=" + id_coming;

						SqlDataReader reader = cmd.ExecuteReader();
						int j = 0;
						while (reader.Read())
						{
							names = Convert.ToString(String.Format("{0}", reader[0]));
							adress = Convert.ToString(String.Format("{0}", reader[1]));
							email = Convert.ToString(String.Format("{0}", reader[2]));
							dates = Convert.ToString(String.Format("{0}", reader[3]));
							phones = Convert.ToString(String.Format("{0}", reader[4]));
						}
						reader.Close();



					}
					catch
					{

					}
				}



				Paragraph para = new Paragraph("__________________________________________________________");
				doc.Add(para);


				Paragraph para2 = new Paragraph("Информация", font);
				doc.Add(para2);

				para2 = new Paragraph("Поставщик: " + names, font);
				doc.Add(para2);

				para2 = new Paragraph("Адресс: " + adress, font);
				doc.Add(para2);

				para2 = new Paragraph("Почта: " + email, font);
				doc.Add(para2);

				para2 = new Paragraph("Телефон: " + phones, font);
				doc.Add(para2);

				para2 = new Paragraph("Дата заказа: " + dates, font);
				doc.Add(para2);

				para2 = new Paragraph("__________________________________________________________");
				doc.Add(para2);

				doc.Close();

				MessageBox.Show("Файл сохранён на рабочий стол как order"+id_coming+".pdf");
			}
			catch
			{
				MessageBox.Show("Произошла ошибка!");
			}
		}
	}
}
