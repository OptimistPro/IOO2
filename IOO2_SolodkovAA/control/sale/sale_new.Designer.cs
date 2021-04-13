namespace IOO2_SolodkovAA
{
	partial class sale_new
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			this.button4 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.table = new System.Windows.Forms.DataGridView();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.artucul = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.prodoves = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label3 = new System.Windows.Forms.Label();
			this.errol = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
			this.SuspendLayout();
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.SystemColors.Info;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button4.Location = new System.Drawing.Point(293, 55);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(27, 29);
			this.button4.TabIndex = 19;
			this.button4.Text = "+";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(3, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(179, 25);
			this.label1.TabIndex = 11;
			this.label1.Text = "Новая продажа";
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.SystemColors.Info;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button3.Location = new System.Drawing.Point(8, 90);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(105, 35);
			this.button3.TabIndex = 18;
			this.button3.Text = "добавить";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// textBox2
			// 
			this.textBox2.Enabled = false;
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox2.Location = new System.Drawing.Point(8, 55);
			this.textBox2.MaxLength = 50;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(279, 29);
			this.textBox2.TabIndex = 12;
			// 
			// table
			// 
			this.table.AllowUserToAddRows = false;
			this.table.AllowUserToDeleteRows = false;
			this.table.AllowUserToResizeColumns = false;
			this.table.AllowUserToResizeRows = false;
			dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Info;
			dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Info;
			this.table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
			this.table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.table.BackgroundColor = System.Drawing.SystemColors.Window;
			this.table.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.ControlLight;
			dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
			dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
			dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
			this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.artucul,
            this.prodoves});
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.Desktop;
			dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.table.DefaultCellStyle = dataGridViewCellStyle12;
			this.table.EnableHeadersVisualStyles = false;
			this.table.GridColor = System.Drawing.SystemColors.Window;
			this.table.Location = new System.Drawing.Point(8, 129);
			this.table.MultiSelect = false;
			this.table.Name = "table";
			this.table.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.table.Size = new System.Drawing.Size(943, 302);
			this.table.TabIndex = 17;
			this.table.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellDoubleClick);
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
			this.artucul.HeaderText = "Цена";
			this.artucul.Name = "artucul";
			// 
			// prodoves
			// 
			this.prodoves.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.prodoves.HeaderText = "Количество";
			this.prodoves.Name = "prodoves";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(5, 36);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(84, 16);
			this.label3.TabIndex = 13;
			this.label3.Text = "Контрагент";
			// 
			// errol
			// 
			this.errol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.errol.AutoSize = true;
			this.errol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.errol.ForeColor = System.Drawing.Color.Firebrick;
			this.errol.Location = new System.Drawing.Point(639, 456);
			this.errol.Name = "errol";
			this.errol.Size = new System.Drawing.Size(45, 16);
			this.errol.TabIndex = 16;
			this.errol.Text = "label4";
			this.errol.Visible = false;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button1.BackColor = System.Drawing.SystemColors.Info;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(8, 437);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(105, 35);
			this.button1.TabIndex = 14;
			this.button1.Text = "провести";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button2.BackColor = System.Drawing.SystemColors.Info;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.Location = new System.Drawing.Point(119, 437);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(105, 35);
			this.button2.TabIndex = 15;
			this.button2.Text = "отмена";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// sale_new
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.Controls.Add(this.button4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.table);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.errol);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button2);
			this.Name = "sale_new";
			this.Size = new System.Drawing.Size(960, 510);
			this.Load += new System.EventHandler(this.sale_new_Load);
			((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.DataGridView table;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn name;
		private System.Windows.Forms.DataGridViewTextBoxColumn artucul;
		private System.Windows.Forms.DataGridViewTextBoxColumn prodoves;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label errol;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}
