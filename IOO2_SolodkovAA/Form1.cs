using System;
using System.Drawing;
using System.Windows.Forms;

namespace IOO2_SolodkovAA
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void продуктыToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (GetChildAtPoint(new Point(0, 30)) != null)
			{
				this.Controls.RemoveAt(1);
			}
			product_full uc = new product_full();
			uc.Location = new Point(0, 30);
			uc.Size = Size - new Size(20, 70);
			this.Controls.Add(uc);

		}

		private void Form1_SizeChanged(object sender, EventArgs e)
		{
			try
			{
				if (GetChildAtPoint(new Point(0, 30)) != null)
				{
					GetChildAtPoint(new Point(0, 30)).Size = Size - new Size(20, 70);
				}
			}
			catch (Exception ex)
			{

			}
		}

		private void контрагентToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (GetChildAtPoint(new Point(0, 30)) != null)
			{
				this.Controls.RemoveAt(1);
			}
			kontragent uc = new kontragent();
			uc.Location = new Point(0, 30);
			uc.Size = Size - new Size(20, 70);
			this.Controls.Add(uc);
		}

		private void поставкаToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (GetChildAtPoint(new Point(0, 30)) != null)
			{
				this.Controls.RemoveAt(1);
			}
			coming_full uc = new coming_full();
			uc.Location = new Point(0, 30);
			uc.Size = Size - new Size(20, 70);
			this.Controls.Add(uc);
		}

		private void продажиToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (GetChildAtPoint(new Point(0, 30)) != null)
			{
				this.Controls.RemoveAt(1);
			}
			sale_full uc = new sale_full();
			uc.Location = new Point(0, 30);
			uc.Size = Size - new Size(20, 70);
			this.Controls.Add(uc);
		}
	}
}
