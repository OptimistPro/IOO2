namespace IOO2_SolodkovAA
{
	partial class coming_product
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

		#region Код, автоматически созданный конструктором компонентов

		/// <summary> 
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.table = new System.Windows.Forms.DataGridView();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.artucul = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label3 = new System.Windows.Forms.Label();
			this.errol = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(3, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(188, 25);
			this.label1.TabIndex = 12;
			this.label1.Text = "Выберите товар";
			// 
			// textBox2
			// 
			this.textBox2.Enabled = false;
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox2.Location = new System.Drawing.Point(8, 53);
			this.textBox2.MaxLength = 50;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(279, 29);
			this.textBox2.TabIndex = 13;
			// 
			// table
			// 
			this.table.AllowUserToAddRows = false;
			this.table.AllowUserToDeleteRows = false;
			this.table.AllowUserToResizeColumns = false;
			this.table.AllowUserToResizeRows = false;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Info;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Info;
			this.table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
			this.table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.table.BackgroundColor = System.Drawing.SystemColors.Window;
			this.table.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlLight;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.artucul});
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.table.DefaultCellStyle = dataGridViewCellStyle6;
			this.table.EnableHeadersVisualStyles = false;
			this.table.GridColor = System.Drawing.SystemColors.Window;
			this.table.Location = new System.Drawing.Point(8, 190);
			this.table.MultiSelect = false;
			this.table.Name = "table";
			this.table.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.table.Size = new System.Drawing.Size(943, 239);
			this.table.TabIndex = 18;
			this.table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellClick);
			// 
			// id
			// 
			this.id.HeaderText = "id";
			this.id.Name = "id";
			this.id.Visible = false;
			// 
			// name
			// 
			this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.name.HeaderText = "Название";
			this.name.Name = "name";
			// 
			// artucul
			// 
			this.artucul.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.artucul.HeaderText = "Артикул";
			this.artucul.Name = "artucul";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(5, 34);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 16);
			this.label3.TabIndex = 14;
			this.label3.Text = "Товар";
			// 
			// errol
			// 
			this.errol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.errol.AutoSize = true;
			this.errol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.errol.ForeColor = System.Drawing.Color.Firebrick;
			this.errol.Location = new System.Drawing.Point(639, 454);
			this.errol.Name = "errol";
			this.errol.Size = new System.Drawing.Size(45, 16);
			this.errol.TabIndex = 17;
			this.errol.Text = "label4";
			this.errol.Visible = false;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button1.BackColor = System.Drawing.SystemColors.Info;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(8, 435);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(105, 35);
			this.button1.TabIndex = 15;
			this.button1.Text = "добавить";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button2.BackColor = System.Drawing.SystemColors.Info;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.Location = new System.Drawing.Point(119, 435);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(105, 35);
			this.button2.TabIndex = 16;
			this.button2.Text = "отмена";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(5, 85);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 16);
			this.label2.TabIndex = 20;
			this.label2.Text = "Количество";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(5, 136);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 16);
			this.label4.TabIndex = 22;
			this.label4.Text = "Цена";
			// 
			// textBox3
			// 
			this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox3.Location = new System.Drawing.Point(8, 155);
			this.textBox3.MaxLength = 50;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(279, 29);
			this.textBox3.TabIndex = 21;
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox1.Location = new System.Drawing.Point(8, 104);
			this.textBox1.MaxLength = 50;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(279, 29);
			this.textBox1.TabIndex = 19;
			// 
			// coming_product
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.table);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.errol);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button2);
			this.Name = "coming_product";
			this.Size = new System.Drawing.Size(960, 510);
			this.Load += new System.EventHandler(this.coming_product_Load);
			((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.DataGridView table;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label errol;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn name;
		private System.Windows.Forms.DataGridViewTextBoxColumn artucul;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox1;
	}
}
