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
	public partial class sale_kontroagent : UserControl
	{
		string ids;
		public sale_kontroagent(string id)
		{
			ids = id;
			InitializeComponent();
		}

		private void sale_kontroagent_Load(object sender, EventArgs e)
		{
            using (SqlConnection con = new SqlConnection(@"Data source=.\SQLEXPRESS;Initial Catalog=I002_Solodkov;User ID=user;Password=Passw0rd;"))
            {
                try
                {

                    table.Rows.Clear();
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();

                    //заполнение данных
                    cmd.CommandText = "select * from kontragent";

                    SqlDataReader reader = cmd.ExecuteReader();
                    int j = 0;
                    while (reader.Read())
                    {
                        table.Rows.Add();
                        table.Rows[j].Cells[0].Value = Convert.ToString(String.Format("{0}", reader[0]));
                        table.Rows[j].Cells[1].Value = Convert.ToString(String.Format("{0}", reader[1]));
                        table.Rows[j].Cells[2].Value = Convert.ToString(String.Format("{0}", reader[2]));
                        table.Rows[j].Cells[3].Value = Convert.ToString(String.Format("{0}", reader[3]));
                        table.Rows[j].Cells[4].Value = Convert.ToString(String.Format("{0}", reader[4]));
                        table.Rows[j].Cells[5].Value = Convert.ToString(String.Format("{0}", reader[5]));
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
                if (e.ColumnIndex == 1 || e.ColumnIndex == 2 || e.ColumnIndex == 3 || e.ColumnIndex == 4 || e.ColumnIndex == 5)
                {
                    String id = Convert.ToString(table.Rows[Convert.ToInt32(e.RowIndex.ToString())].Cells[0].Value);


                    using (SqlConnection con = new SqlConnection(@"Data source=.\SQLEXPRESS;Initial Catalog=I002_Solodkov;User ID=user;Password=Passw0rd;"))
                    {
                        try
                        {
                            con.Open();
                            SqlCommand cmd = con.CreateCommand();
                            //заполнение данных
                            cmd.CommandText = "UPDATE [sale] SET id_kontragent='" + id + "' Where [sale].id=" + ids;
                            cmd.ExecuteScalar();


                            sale_new uc = new sale_new(ids);
                            uc.Location = new Point(0, 30);
                            uc.Size = Size;
                            this.Parent.Controls.Add(uc);
                            this.Parent.Controls.RemoveAt(1);

                        }
                        catch (Exception ex)
                        {
                        }
                        finally
                        {
                            con.Close();
                        }

                    }

                }
            }
            catch { }
        }

		private void button1_Click(object sender, EventArgs e)
		{
            sale_new uc = new sale_new(ids);
            uc.Location = new Point(0, 30);
            uc.Size = Size;
            this.Parent.Controls.Add(uc);
            this.Parent.Controls.RemoveAt(1);
        }
	}
}
