namespace WindowsFormsApplication1
{
    partial class Sotrudnik
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
            this.Name_sotr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname_sotr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Otch_sotr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel_sotr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seria_pasp_sotr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num_pasp_sotr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotel_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prof_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Введите данные сотрудника";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(269, 22);
            this.textBox1.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(192, 401);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 37);
            this.button3.TabIndex = 9;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
   
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(100, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 37);
            this.button2.TabIndex = 8;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
     
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
       
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name_sotr,
            this.Surname_sotr,
            this.Otch_sotr,
            this.Tel_sotr,
            this.Seria_pasp_sotr,
            this.Num_pasp_sotr,
            this.hotel_id,
            this.prof_id});
            this.dataGridView1.Location = new System.Drawing.Point(2, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(839, 261);
            this.dataGridView1.TabIndex = 13;
            // 
            // Name_sotr
            // 
            this.Name_sotr.HeaderText = "Имя сотрудника";
            this.Name_sotr.Name = "Name_sotr";
            // 
            // Surname_sotr
            // 
            this.Surname_sotr.HeaderText = "Фамилия сотрудника";
            this.Surname_sotr.Name = "Surname_sotr";
            // 
            // Otch_sotr
            // 
            this.Otch_sotr.HeaderText = "Отчество сотрудника";
            this.Otch_sotr.Name = "Otch_sotr";
            // 
            // Tel_sotr
            // 
            this.Tel_sotr.HeaderText = "Телефон";
            this.Tel_sotr.Name = "Tel_sotr";
            // 
            // Seria_pasp_sotr
            // 
            this.Seria_pasp_sotr.HeaderText = "Серия паспорта";
            this.Seria_pasp_sotr.Name = "Seria_pasp_sotr";
            // 
            // Num_pasp_sotr
            // 
            this.Num_pasp_sotr.HeaderText = "Номер паспорта";
            this.Num_pasp_sotr.Name = "Num_pasp_sotr";
            // 
            // hotel_id
            // 
            this.hotel_id.HeaderText = "Код отеля";
            this.hotel_id.Name = "hotel_id";
            // 
            // prof_id
            // 
            this.prof_id.HeaderText = "Код профессии";
            this.prof_id.Name = "prof_id";
            // 
            // Sotrudnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Sotrudnik";
            this.Text = "Sotrudnik";
            this.Load += new System.EventHandler(this.Sotrudnik_Load);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_sotr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname_sotr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Otch_sotr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel_sotr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seria_pasp_sotr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num_pasp_sotr;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotel_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn prof_id;
    }
}