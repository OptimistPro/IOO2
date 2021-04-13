using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IOO2_SolodkovAA
{
	public partial class product_new : UserControl
	{
		public product_new()
		{
			InitializeComponent();
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
                        cmd.CommandText = "INSERT product (name, articul) VALUES ('" + namess + "','" + artikyl + "')";
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
