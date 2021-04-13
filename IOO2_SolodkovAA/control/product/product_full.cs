using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IOO2_SolodkovAA
{
	public partial class product_full : UserControl
	{
		public product_full()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			product_new uc = new product_new();
			uc.Location = new Point(0, 30);
			uc.Size = Size;
			this.Parent.Controls.Add(uc);
			this.Parent.Controls.RemoveAt(1);
		}

		private void product_full_Load(object sender, EventArgs e)
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

		private void table_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
            try
            {
                if (e.ColumnIndex == 1 || e.ColumnIndex == 2)
                {
                    String id = Convert.ToString(table.Rows[Convert.ToInt32(e.RowIndex.ToString())].Cells[0].Value);

                    product_update uc = new product_update(id);
                    uc.Location = new Point(0, 30);
                    uc.Size = Size;
                    this.Parent.Controls.Add(uc);
                    this.Parent.Controls.RemoveAt(1);
                }
            }
            catch { }
        }

		private void table_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
