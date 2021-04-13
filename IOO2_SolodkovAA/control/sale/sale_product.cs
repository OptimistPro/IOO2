using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IOO2_SolodkovAA
{
	public partial class sale_product : UserControl
	{
		public String ids = "";
		string id_coming = "";
		public sale_product(string idt)
		{
			id_coming = idt;
			InitializeComponent();
		}

		private void sale_product_Load(object sender, EventArgs e)
		{
            using (SqlConnection con = new SqlConnection(@"Data source=.\SQLEXPRESS;Initial Catalog=I002_Solodkov;User ID=user;Password=Passw0rd;"))
            {
                try
                {

                    table.Rows.Clear();
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();

                    //заполнение данных
                    cmd.CommandText = "select * from product";

                    SqlDataReader reader = cmd.ExecuteReader();
                    int j = 0;
                    while (reader.Read())
                    {
                        table.Rows.Add();
                        table.Rows[j].Cells[0].Value = Convert.ToString(String.Format("{0}", reader[0]));
                        table.Rows[j].Cells[1].Value = Convert.ToString(String.Format("{0}", reader[1]));
                        table.Rows[j].Cells[2].Value = Convert.ToString(String.Format("{0}", reader[2]));
                        j++;
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

		private void table_CellClick(object sender, DataGridViewCellEventArgs e)
		{
            try
            {
                if (e.ColumnIndex == 1 || e.ColumnIndex == 2)
                {
                    ids = Convert.ToString(table.Rows[Convert.ToInt32(e.RowIndex.ToString())].Cells[0].Value);
                    textBox2.Text = Convert.ToString(table.Rows[Convert.ToInt32(e.RowIndex.ToString())].Cells[1].Value);

                }
            }
            catch { }
        }

		private void button2_Click(object sender, EventArgs e)
		{
            sale_new uc = new sale_new(id_coming);
            uc.Location = new Point(0, 30);
            uc.Size = Size;
            this.Parent.Controls.Add(uc);
            this.Parent.Controls.RemoveAt(1);
        }

		private void button1_Click(object sender, EventArgs e)
		{
            string namess = textBox2.Text;
            string kol = textBox1.Text;
            string prices = textBox3.Text;

            if (namess != "" && kol != "" && prices != "")
            {
                using (SqlConnection con = new SqlConnection(@"Data source=.\SQLEXPRESS;Initial Catalog=I002_Solodkov;User ID=user;Password=Passw0rd;"))
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandText = "select * from psale where id_sale=" + id_coming + "AND id_product=" + ids;

                        bool prov = true;
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            prov = false;
                        }
                        reader.Close();


                        if (prov)
                        {
                            //заполнение данных
                            cmd.CommandText = "INSERT psale (id_sale, id_product,price,count) VALUES ('" + id_coming + "','" + ids + "','" + prices + "','" + kol + "')";
                            cmd.ExecuteScalar();


                            sale_new uc = new sale_new(id_coming);
                            uc.Location = new Point(0, 30);
                            uc.Size = Size;
                            this.Parent.Controls.Add(uc);
                            this.Parent.Controls.RemoveAt(1);
                        }
						else
						{
                            errol.Text = "Ошибка записи";
                            errol.Visible = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        errol.Text = "Ошибка записи";
                        errol.Visible = true;

                    }
                    finally
                    {
                        con.Close();
                    }

                }
            }
            else
            {
                errol.Text = "Не все поля заполнены";
                errol.Visible = true;
            }
        }
	}
}
