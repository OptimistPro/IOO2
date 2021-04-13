namespace IOO2_SolodkovAA
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.продуктыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.контрагентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.поставкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.продажиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.Info;
			this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.продуктыToolStripMenuItem,
            this.контрагентToolStripMenuItem,
            this.поставкаToolStripMenuItem,
            this.продажиToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(960, 29);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// продуктыToolStripMenuItem
			// 
			this.продуктыToolStripMenuItem.Name = "продуктыToolStripMenuItem";
			this.продуктыToolStripMenuItem.Size = new System.Drawing.Size(94, 25);
			this.продуктыToolStripMenuItem.Text = "Продукты";
			this.продуктыToolStripMenuItem.Click += new System.EventHandler(this.продуктыToolStripMenuItem_Click);
			// 
			// контрагентToolStripMenuItem
			// 
			this.контрагентToolStripMenuItem.Name = "контрагентToolStripMenuItem";
			this.контрагентToolStripMenuItem.Size = new System.Drawing.Size(103, 25);
			this.контрагентToolStripMenuItem.Text = "Контрагент";
			this.контрагентToolStripMenuItem.Click += new System.EventHandler(this.контрагентToolStripMenuItem_Click);
			// 
			// поставкаToolStripMenuItem
			// 
			this.поставкаToolStripMenuItem.Name = "поставкаToolStripMenuItem";
			this.поставкаToolStripMenuItem.Size = new System.Drawing.Size(88, 25);
			this.поставкаToolStripMenuItem.Text = "Поставка";
			this.поставкаToolStripMenuItem.Click += new System.EventHandler(this.поставкаToolStripMenuItem_Click);
			// 
			// продажиToolStripMenuItem
			// 
			this.продажиToolStripMenuItem.Name = "продажиToolStripMenuItem";
			this.продажиToolStripMenuItem.Size = new System.Drawing.Size(89, 25);
			this.продажиToolStripMenuItem.Text = "Продажи";
			this.продажиToolStripMenuItem.Click += new System.EventHandler(this.продажиToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(960, 540);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Склад";
			this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem продуктыToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem контрагентToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem поставкаToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem продажиToolStripMenuItem;
	}
}

