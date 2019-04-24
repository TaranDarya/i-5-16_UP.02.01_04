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
            this.date_zaezda = new System.Windows.Forms.MaskedTextBox();
            this.date_otezda = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 241);
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
            this.button1.Location = new System.Drawing.Point(553, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(527, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Дата заезда";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(527, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Дата отъезда";
            // 
            // id_hotel
            // 
            this.id_hotel.FormattingEnabled = true;
            this.id_hotel.Location = new System.Drawing.Point(528, 226);
            this.id_hotel.Name = "id_hotel";
            this.id_hotel.Size = new System.Drawing.Size(121, 24);
            this.id_hotel.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(525, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Код комнаты";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(527, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Код отеля";
            // 
            // id_room
            // 
            this.id_room.FormattingEnabled = true;
            this.id_room.Location = new System.Drawing.Point(530, 303);
            this.id_room.Name = "id_room";
            this.id_room.Size = new System.Drawing.Size(119, 24);
            this.id_room.TabIndex = 10;
            // 
            // date_zaezda
            // 
            this.date_zaezda.Location = new System.Drawing.Point(528, 86);
            this.date_zaezda.Mask = "00/00/0000";
            this.date_zaezda.Name = "date_zaezda";
            this.date_zaezda.Size = new System.Drawing.Size(121, 22);
            this.date_zaezda.TabIndex = 11;
            this.date_zaezda.ValidatingType = typeof(System.DateTime);
            // 
            // date_otezda
            // 
            this.date_otezda.Location = new System.Drawing.Point(528, 152);
            this.date_otezda.Mask = "00/00/0000";
            this.date_otezda.Name = "date_otezda";
            this.date_otezda.Size = new System.Drawing.Size(121, 22);
            this.date_otezda.TabIndex = 12;
            this.date_otezda.ValidatingType = typeof(System.DateTime);
            // 
            // Bron_room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Text = "Bron_room";
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
        private System.Windows.Forms.MaskedTextBox date_zaezda;
        private System.Windows.Forms.MaskedTextBox date_otezda;
    }
}