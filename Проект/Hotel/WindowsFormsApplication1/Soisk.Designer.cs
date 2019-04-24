namespace WindowsFormsApplication1
{
    partial class Soisk
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Name_soisk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname_soisk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Otch_soisk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opt_rab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel_soisk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prof_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 37);
            this.button1.TabIndex = 14;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(111, 403);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 37);
            this.button2.TabIndex = 15;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(203, 403);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 37);
            this.button3.TabIndex = 16;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(269, 22);
            this.textBox1.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name_soisk,
            this.Surname_soisk,
            this.Otch_soisk,
            this.Opt_rab,
            this.Tel_soisk,
            this.prof_id});
            this.dataGridView1.Location = new System.Drawing.Point(13, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(648, 261);
            this.dataGridView1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Введите данные сотрудника";
            // 
            // Name_soisk
            // 
            this.Name_soisk.HeaderText = "Имя соискателя";
            this.Name_soisk.Name = "Name_soisk";
            // 
            // Surname_soisk
            // 
            this.Surname_soisk.HeaderText = "Фамилия соискателя";
            this.Surname_soisk.Name = "Surname_soisk";
            // 
            // Otch_soisk
            // 
            this.Otch_soisk.HeaderText = "Отчество соискателя";
            this.Otch_soisk.Name = "Otch_soisk";
            // 
            // Opt_rab
            // 
            this.Opt_rab.HeaderText = "Опыт работы";
            this.Opt_rab.Name = "Opt_rab";
            // 
            // Tel_soisk
            // 
            this.Tel_soisk.HeaderText = "Телефон";
            this.Tel_soisk.Name = "Tel_soisk";
            // 
            // prof_id
            // 
            this.prof_id.HeaderText = "Код профессии";
            this.prof_id.Name = "prof_id";
            // 
            // Soisk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Soisk";
            this.Text = "Soisk";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_soisk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname_soisk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Otch_soisk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opt_rab;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel_soisk;
        private System.Windows.Forms.DataGridViewTextBoxColumn prof_id;
    }
}