namespace WindowsFormsApplication1
{
    partial class Bron_room
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.id_hotel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.id_room = new System.Windows.Forms.ComboBox();
            this.date_zaezda = new System.Windows.Forms.DateTimePicker();
            this.date_otezda = new System.Windows.Forms.DateTimePicker();
            this.Zabron = new System.Windows.Forms.Button();
            this.Отель = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_zaezda_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_otezda_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Отель,
            this.date_zaezda_col,
            this.data_otezda_col});
            this.dataGridView1.Location = new System.Drawing.Point(41, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(435, 241);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(264, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Бронирование номера";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(698, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(512, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Дата заезда";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(512, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Дата отъезда";
            // 
            // id_hotel
            // 
            this.id_hotel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.id_hotel.FormattingEnabled = true;
            this.id_hotel.Location = new System.Drawing.Point(515, 106);
            this.id_hotel.Name = "id_hotel";
            this.id_hotel.Size = new System.Drawing.Size(199, 24);
            this.id_hotel.TabIndex = 7;
            this.id_hotel.SelectedIndexChanged += new System.EventHandler(this.id_hotel_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(514, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Комната";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(516, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Отель";
            // 
            // id_room
            // 
            this.id_room.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.id_room.FormattingEnabled = true;
            this.id_room.Location = new System.Drawing.Point(515, 165);
            this.id_room.Name = "id_room";
            this.id_room.Size = new System.Drawing.Size(119, 24);
            this.id_room.TabIndex = 10;
            // 
            // date_zaezda
            // 
            this.date_zaezda.Location = new System.Drawing.Point(513, 244);
            this.date_zaezda.Name = "date_zaezda";
            this.date_zaezda.Size = new System.Drawing.Size(174, 22);
            this.date_zaezda.TabIndex = 13;
            // 
            // date_otezda
            // 
            this.date_otezda.Location = new System.Drawing.Point(515, 307);
            this.date_otezda.Name = "date_otezda";
            this.date_otezda.Size = new System.Drawing.Size(174, 22);
            this.date_otezda.TabIndex = 14;
            // 
            // Zabron
            // 
            this.Zabron.Location = new System.Drawing.Point(515, 363);
            this.Zabron.Name = "Zabron";
            this.Zabron.Size = new System.Drawing.Size(172, 45);
            this.Zabron.TabIndex = 15;
            this.Zabron.Text = "Забронировать";
            this.Zabron.UseVisualStyleBackColor = true;
            // 
            // Отель
            // 
            this.Отель.HeaderText = "Отель";
            this.Отель.Name = "Отель";
            // 
            // date_zaezda_col
            // 
            this.date_zaezda_col.HeaderText = "Дата заезда";
            this.date_zaezda_col.Name = "date_zaezda_col";
            // 
            // data_otezda_col
            // 
            this.data_otezda_col.HeaderText = "Дата отъезда";
            this.data_otezda_col.Name = "data_otezda_col";
            // 
            // Bron_room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.Zabron);
            this.Controls.Add(this.date_otezda);
            this.Controls.Add(this.date_zaezda);
            this.Controls.Add(this.id_room);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.id_hotel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Bron_room";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bron_room";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bron_room_FormClosing);
            this.Load += new System.EventHandler(this.Bron_room_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox id_hotel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox id_room;
        private System.Windows.Forms.DateTimePicker date_zaezda;
        private System.Windows.Forms.DateTimePicker date_otezda;
        private System.Windows.Forms.Button Zabron;
        private System.Windows.Forms.DataGridViewTextBoxColumn Отель;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_zaezda_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_otezda_col;
    }
}