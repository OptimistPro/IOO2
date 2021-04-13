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
	public partial class sale_new : UserControl
	{
		string id_coming = "";
		public sale_new(string id)
		{
			id_coming = id;
			InitializeComponent();
		}

		private void sale_new_Load(object sender, EventArgs e)
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
                        cmd.CommandText = "select [psale].price,[psale].count from [psale] JOIN[product] ON[product].id =[psale].id_product Where [product].name='" + Convert.ToString(table.Rows[i].Cells[1].Value)+"'";
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
                            table.Rows[i].Cells[2].Value = Convert.ToString(pris*1.05);
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

		private void button3_Click(object sender, EventArgs e)
		{
			sale_product uc = new sale_product(id_coming);
			uc.Location = new Point(0, 30);
			uc.Size = Size;
			this.Parent.Controls.Add(uc);
			this.Parent.Controls.RemoveAt(1);
		}

		private void table_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
            try
            {
                if (e.ColumnIndex == 1 || e.ColumnIndex == 2)
                {
                    String idst = Convert.ToString(table.Rows[Convert.ToInt32(e.RowIndex.ToString())].Cells[0].Value);

                    sale_product_update uc = new sale_product_update(id_coming, idst);
                    uc.Location = new Point(0, 30);
                    uc.Size = Size;
                    this.Parent.Controls.Add(uc);
                    this.Parent.Controls.RemoveAt(1);
                }
            }
            catch { }
        }

		private void button4_Click(object sender, EventArgs e)
		{
            sale_kontroagent uc = new sale_kontroagent(id_coming);
            uc.Location = new Point(0, 30);
            uc.Size = Size;
            this.Parent.Controls.Add(uc);
            this.Parent.Controls.RemoveAt(1);
        }

		private void button2_Click(object sender, EventArgs e)
		{
            using (SqlConnection con = new SqlConnection(@"Data source=.\SQLEXPRESS;Initial Catalog=I002_Solodkov;User ID=user;Password=Passw0rd;"))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    //заполнение данных
                    cmd.CommandText = "DELETE [psale] WHERE [psale].id_sale=" + id_coming;
                    cmd.ExecuteScalar();

                    cmd.CommandText = "DELETE [sale] WHERE [sale].id=" + id_coming;
                    cmd.ExecuteScalar();

                    sale_full uc = new sale_full();
                    uc.Location = new Point(0, 30);
                    uc.Size = Size;
                    this.Parent.Controls.Add(uc);
                    this.Parent.Controls.RemoveAt(1);

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

		private void button1_Click(object sender, EventArgs e)
		{
            if (textBox2.Text != "" && table.Rows.Count > 0)
            {
                using (SqlConnection con = new SqlConnection(@"Data source=.\SQLEXPRESS;Initial Catalog=I002_Solodkov;User ID=user;Password=Passw0rd;"))
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        //заполнение данных

                        cmd.CommandText = "UPDATE [sale] SET date='" + Convert.ToString(DateTime.Now) + "' Where [sale].id=" + id_coming;
                        cmd.ExecuteScalar();

                        sale_full uc = new sale_full();
                        uc.Location = new Point(0, 30);
                        uc.Size = Size;
                        this.Parent.Controls.Add(uc);
                        this.Parent.Controls.RemoveAt(1);

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
                errol.Text = "Ошибка записи";
                errol.Visible = true;
            }
        }
	}
}
