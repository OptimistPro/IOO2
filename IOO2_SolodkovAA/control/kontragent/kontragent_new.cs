using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IOO2_SolodkovAA
{
	public partial class kontragent_new : UserControl
	{
		public kontragent_new()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			kontragent uc = new kontragent();
			uc.Location = new Point(0, 30);
			uc.Size = Size;
			this.Parent.Controls.Add(uc);
			this.Parent.Controls.RemoveAt(1);
		}

		private void button1_Click(object sender, EventArgs e)
		{
            string namess = textBox1.Text;
            string adress = textBox2.Text;
            string inn = maskedTextBox2.Text;
            string phone = maskedTextBox1.Text;
            string email = textBox5.Text;

            if (namess != "" && adress != "" && inn != "" && phone != "" && email != "")
            {
                using (SqlConnection con = new SqlConnection(@"Data source=.\SQLEXPRESS;Initial Catalog=I002_Solodkov;User ID=user;Password=Passw0rd;"))
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        //заполнение данных
                        cmd.CommandText = "INSERT kontragent (name, adress, inn, phone, email) VALUES ('" + namess + "','" + adress + "','" + inn + "','" + phone + "','" + email + "')";
                        cmd.ExecuteScalar();


                        kontragent uc = new kontragent();
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
