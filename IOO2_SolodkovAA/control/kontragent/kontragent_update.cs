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
	public partial class kontragent_update : UserControl
	{
		string id = "";
		public kontragent_update(string ids)
		{
			id = ids;
			InitializeComponent();
		}

		private void kontragent_update_Load(object sender, EventArgs e)
		{
            using (SqlConnection con = new SqlConnection(@"Data source=.\SQLEXPRESS;Initial Catalog=I002_Solodkov;User ID=user;Password=Passw0rd;"))
            {
                try
                {

                    con.Open();
                    SqlCommand cmd = con.CreateCommand();

                    //заполнение данных
                    cmd.CommandText = "select * from kontragent Where id=" + id;

                    SqlDataReader reader = cmd.ExecuteReader();
                    int j = 0;
                    while (reader.Read())
                    {
                        textBox1.Text = Convert.ToString(String.Format("{0}", reader[1]));
                        textBox2.Text = Convert.ToString(String.Format("{0}", reader[2]));
                        maskedTextBox2.Text = Convert.ToString(String.Format("{0}", reader[3]));
                        maskedTextBox1.Text = Convert.ToString(String.Format("{0}", reader[4]));
                        textBox5.Text = Convert.ToString(String.Format("{0}", reader[5]));
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
                        cmd.CommandText = "UPDATE [kontragent] SET name='" + namess + "', adress='" + adress + "', inn='" + inn + "', phone='" + phone + "', email='" + email + "' Where [kontragent].id=" + id;
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
