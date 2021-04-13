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
	public partial class product_update : UserControl
	{
		string id = "";
		public product_update(string ids)
		{
			id = ids;
			InitializeComponent();
		}

		private void product_update_Load(object sender, EventArgs e)
		{
            using (SqlConnection con = new SqlConnection(@"Data source=.\SQLEXPRESS;Initial Catalog=I002_Solodkov;User ID=user;Password=Passw0rd;"))
            {
                try
                {

                    con.Open();
                    SqlCommand cmd = con.CreateCommand();

                    //заполнение данных
                    cmd.CommandText = "select * from product Where id=" + id;

                    SqlDataReader reader = cmd.ExecuteReader();
                    int j = 0;
                    while (reader.Read())
                    {
                        textBox1.Text = Convert.ToString(String.Format("{0}", reader[1]));
                        textBox2.Text = Convert.ToString(String.Format("{0}", reader[2]));
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
            product_full uc = new product_full();
            uc.Location = new Point(0, 30);
            uc.Size = Size;
            this.Parent.Controls.Add(uc);
            this.Parent.Controls.RemoveAt(1);
        }

		private void button1_Click(object sender, EventArgs e)
		{
            string namess = textBox1.Text;
            string artikyl = textBox2.Text;

            if (namess != "" && artikyl != "")
            {
                using (SqlConnection con = new SqlConnection(@"Data source=.\SQLEXPRESS;Initial Catalog=I002_Solodkov;User ID=user;Password=Passw0rd;"))
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        //заполнение данных
                        cmd.CommandText = "UPDATE [product] SET name='" + namess + "', articul='" + artikyl + "' Where [product].id=" + id;
                        cmd.ExecuteScalar();


                        product_full uc = new product_full();
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
                errol.Text = "Не все поля заполнены";
                errol.Visible = true;
            }
        }
	}
}
