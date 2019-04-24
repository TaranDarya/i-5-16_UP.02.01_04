namespace WindowsFormsApplication1
{
    partial class Post
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name_post = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname_post = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Otch_post = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_rojd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seria_pasporta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num_pasport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grajadanstvo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Введите данные сотрудника";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(269, 22);
            this.textBox1.TabIndex = 17;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(202, 401);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 37);
            this.button3.TabIndex = 16;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(110, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 37);
            this.button2.TabIndex = 15;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 37);
            this.button1.TabIndex = 14;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name_post,
            this.Surname_post,
            this.Otch_post,
            this.Data_rojd,
            this.Seria_pasporta,
            this.Num_pasport,
            this.Grajadanstvo});
            this.dataGridView1.Location = new System.Drawing.Point(22, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(743, 254);
            this.dataGridView1.TabIndex = 19;
            // 
            // Name_post
            // 
            this.Name_post.HeaderText = "Имя постояльца";
            this.Name_post.Name = "Name_post";
            // 
            // Surname_post
            // 
            this.Surname_post.HeaderText = "Фамилия постояльца";
            this.Surname_post.Name = "Surname_post";
            // 
            // Otch_post
            // 
            this.Otch_post.HeaderText = "Отчество постояльца";
            this.Otch_post.Name = "Otch_post";
            // 
            // Data_rojd
            // 
            this.Data_rojd.HeaderText = "Дата рождения";
            this.Data_rojd.Name = "Data_rojd";
            // 
            // Seria_pasporta
            // 
            this.Seria_pasporta.HeaderText = "Серия паспорта";
            this.Seria_pasporta.Name = "Seria_pasporta";
            // 
            // Num_pasport
            // 
            this.Num_pasport.HeaderText = "Номер паспорта";
            this.Num_pasport.Name = "Num_pasport";
            // 
            // Grajadanstvo
            // 
            this.Grajadanstvo.HeaderText = "Гражданство";
            this.Grajadanstvo.Name = "Grajadanstvo";
            // 
            // Post
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(837, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Post";
            this.Text = "Post";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_post;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname_post;
        private System.Windows.Forms.DataGridViewTextBoxColumn Otch_post;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_rojd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seria_pasporta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num_pasport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grajadanstvo;
    }
}