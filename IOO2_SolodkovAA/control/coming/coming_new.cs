using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IOO2_SolodkovAA
{
	
	public partial class coming_new : UserControl
	{
		string id_coming = "";
		public coming_new(string id)
		{
			id_coming = id;
			InitializeComponent();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			coming_product uc = new coming_product(id_coming);
			uc.Location = new Point(0, 30);
			uc.Size = Size;
			this.Parent.Controls.Add(uc);
			this.Parent.Controls.RemoveAt(1);
		}

        private void coming_new_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data source=.\SQLEXPRESS;Initial Catalog=I002_Solodkov;User ID=user;Password=Passw0rd;"))
            {
                try
                {

                    table.Rows.Clear();
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();

                    //заполнение данных
                    cmd.CommandText = "select [pcoming].id,[product].name,[pcoming].price,[pcoming].count from [pcoming] JOIN[product] ON[product].id =[pcoming].id_product Where [pcoming].id_coming="+id_coming;

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

                    cmd.CommandText = "select [kontragent].name from [coming] JOIN[kontragent] ON[kontragent].id =[coming].id_kontragent Where [coming].id=" + id_coming;

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

		private void table_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
            try
            {
                if (e.ColumnIndex == 1 || e.ColumnIndex == 2)
                {
                    String idst = Convert.ToString(table.Rows[Convert.ToInt32(e.RowIndex.ToString())].Cells[0].Value);

                    coming_product_update uc = new coming_product_update(id_coming,idst);
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
            coming_add_kontroagent uc = new coming_add_kontroagent(id_coming);
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
                    cmd.CommandText = "DELETE [pcoming] WHERE [pcoming].id_coming=" + id_coming;
                    cmd.ExecuteScalar();

                    cmd.CommandText = "DELETE [coming] WHERE [coming].id=" + id_coming;
                    cmd.ExecuteScalar();

                    coming_full uc = new coming_full();
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
            if (textBox2.Text != ""&&table.Rows.Count>0)
            {
                using (SqlConnection con = new SqlConnection(@"Data source=.\SQLEXPRESS;Initial Catalog=I002_Solodkov;User ID=user;Password=Passw0rd;"))
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        //заполнение данных

                        cmd.CommandText = "UPDATE [coming] SET date='" + Convert.ToString(DateTime.Now) + "' Where [coming].id=" + id_coming;
                        cmd.ExecuteScalar();

                        coming_full uc = new coming_full();
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
