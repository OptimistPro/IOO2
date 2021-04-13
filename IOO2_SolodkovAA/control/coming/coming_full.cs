﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IOO2_SolodkovAA
{
	public partial class coming_full : UserControl
	{
		public coming_full()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			using (SqlConnection con = new SqlConnection(@"Data source=.\SQLEXPRESS;Initial Catalog=I002_Solodkov;User ID=user;Password=Passw0rd;"))
			{
				try
				{
					con.Open();
					SqlCommand cmd = con.CreateCommand();
					SqlDataReader reader;
					cmd.CommandText = "INSERT coming (date) VALUES ('" + Convert.ToString(DateTime.Now)+"')";
					cmd.ExecuteScalar();

					cmd.CommandText = "SELECT * FROM [coming] ORDER BY id DESC";
					string id_coming = "";
					reader = cmd.ExecuteReader();
					while (reader.Read())
					{
						id_coming = Convert.ToString(String.Format("{0}", reader[0]));
						break;
					}
					reader.Close();

					coming_new uc = new coming_new(id_coming);
					uc.Location = new Point(0, 30);
					uc.Size = Size;
					this.Parent.Controls.Add(uc);
					this.Parent.Controls.RemoveAt(1);
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

		private void coming_full_Load(object sender, EventArgs e)
		{
			using (SqlConnection con = new SqlConnection(@"Data source=.\SQLEXPRESS;Initial Catalog=I002_Solodkov;User ID=user;Password=Passw0rd;"))
			{
				try
				{

					table.Rows.Clear();
					con.Open();
					SqlCommand cmd = con.CreateCommand();

					//заполнение данных
					cmd.CommandText = "select [coming].id,[coming].id,[coming].date,[kontragent].name from [coming] JOIN[kontragent] ON[kontragent].id =[coming].id_kontragent";

					SqlDataReader reader = cmd.ExecuteReader();
					int j = 0;
					while (reader.Read())
					{
						table.Rows.Add();
						table.Rows[j].Cells[1].Value = "№"+Convert.ToString(String.Format("{0}", reader[0]));
						table.Rows[j].Cells[0].Value = Convert.ToString(String.Format("{0}", reader[1]));
						table.Rows[j].Cells[2].Value = Convert.ToString(String.Format("{0}", reader[2]));
						table.Rows[j].Cells[3].Value = Convert.ToString(String.Format("{0}", reader[3]));
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
				if (e.ColumnIndex == 1 || e.ColumnIndex == 2 || e.ColumnIndex == 3)
				{
					String id = Convert.ToString(table.Rows[Convert.ToInt32(e.RowIndex.ToString())].Cells[0].Value);

					coming_info uc = new coming_info(id);
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
