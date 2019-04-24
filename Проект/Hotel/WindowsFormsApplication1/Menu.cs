using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Menu : Form
    {
        object[] textcomboboxes = new object[9];
        Label[] labels = new Label[9];

        public Menu()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel1.Enabled = false;
            panel2.Visible = true;
            panel2.Enabled = true;

        }

        private void DataGridLoaded(string query) // Вывод таблицы в DataGrid
        {
            try
            {
                AUD.sql.Open();
                SqlCommand command = new SqlCommand(query, AUD.sql);
                DataTable datatbl = new DataTable();
                datatbl.Load(command.ExecuteReader());
                dataGridView1.DataSource = datatbl.DefaultView;
                dataGridView1.Columns[0].Visible = false;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                AUD.sql.Close();
            }
        }


        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void ClearPanel()
        {
            dataGridView1.DataSource = "";
            for (int i = 0; i < 7; i++)
            {
                panel2.Controls.Remove(labels[i]);
                //if ((textcomboboxes[i] as MaskedTextBox) != null)
                panel2.Controls.Remove(textcomboboxes[i] as MaskedTextBox);
                //if ((textcomboboxes[i] as ComboBox) != null)
                    panel2.Controls.Remove(textcomboboxes[i] as ComboBox);
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) // Выбор таблицы для отображения
        {
            ClearPanel();
            switch (comboBox1.SelectedItem)
            {
                case "Отель":
                    DataGridLoaded(AUD.qrHotel);
                    for (int i = 0; i < 3; i++)
                    {
                        Label label = new Label();
                        label.Location = new Point(500, 38 + 40 * i);
                        label.Text = dataGridView1.Columns[i + 1].HeaderText;
                        label.Visible = true;
                        labels[i] = label;
                        panel2.Controls.Add(label);

                        MaskedTextBox textbox = new MaskedTextBox();
                        textbox.Location = new Point(500 + label.Width + 20, 38 + 40 * i);
                        textbox.Mask = "";
                        textbox.Visible = true;
                        panel2.Controls.Add(textbox);
                        textcomboboxes[i] = textbox;
                    }
                    break;

                case "Бронирование":
                    DataGridLoaded(AUD.qrBron);
                    for (int i = 0; i < 4; i++)
                    {
                        Label label = new Label();
                        label.Location = new Point(500, 38 + 40 * i);
                        label.Text = dataGridView1.Columns[i + 1].HeaderText;
                        label.Visible = true;
                        labels[i] = label;
                        panel2.Controls.Add(label);

                        if (i == 0 || i == 1)
                        {
                            MaskedTextBox textbox = new MaskedTextBox();
                            textbox.Location = new Point(500 + label.Width + 20, 38 + 40 * i);
                            textbox.Mask = "";
                            textbox.Visible = true;
                            panel2.Controls.Add(textbox);
                            textcomboboxes[i] = textbox;
                        }
                        else
                        {
                            ComboBox comBox = new ComboBox();
                            comBox.Location = new Point(500 + label.Width + 20, 38 + 40 * i);
                            comBox.Visible = true;
                            comBox.DropDownStyle = ComboBoxStyle.DropDownList;
                            panel2.Controls.Add(comBox);
                            textcomboboxes[i] = comBox;

                        }
                    }

                    break;
                case "Постоялец":
                    DataGridLoaded(AUD.qrPost);
                    for (int i = 0; i < 6; i++)
                    {
                        Label label = new Label();
                        label.Location = new Point(500, 38 + 40 * i);
                        label.Text = dataGridView1.Columns[i + 1].HeaderText;
                        label.Visible = true;
                        labels[i] = label;
                        panel2.Controls.Add(label);

                        MaskedTextBox textbox = new MaskedTextBox();
                        textbox.Location = new Point(500 + label.Width + 20, 38 + 40 * i);
                        textbox.Mask = "";
                        textbox.Visible = true;
                        panel2.Controls.Add(textbox);
                        textcomboboxes[i] = textbox;
                    }

                    break;
                case "Сотрудник":
                    DataGridLoaded(AUD.qrSotr);
                    for (int i = 0; i < 7; i++)
                    {
                        Label label = new Label();
                        label.Location = new Point(500, 38 + 40 * i);
                        label.Text = dataGridView1.Columns[i + 1].HeaderText;
                        label.Visible = true;
                        labels[i] = label;
                        panel2.Controls.Add(label);

                        if (i == 0 || i == 1 || i == 2 || i == 3 || i == 4 || i == 5)
                        {
                            MaskedTextBox textbox = new MaskedTextBox();
                            textbox.Location = new Point(500 + label.Width + 20, 38 + 40 * i);
                            textbox.Mask = "";
                            textbox.Visible = true;
                            panel2.Controls.Add(textbox);
                            textcomboboxes[i] = textbox;
                        }
                        else
                        {
                            ComboBox comBox = new ComboBox();
                            comBox.Location = new Point(500 + label.Width + 20, 38 + 40 * i);
                            comBox.Visible = true;
                            comBox.DropDownStyle = ComboBoxStyle.DropDownList;
                            panel2.Controls.Add(comBox);
                            textcomboboxes[i] = comBox;

                        }
                    }

                    break;
                case "Соискатель":
                    DataGridLoaded(AUD.qrSoisk);
                    for (int i = 0; i < 6; i++)
                    {
                        Label label = new Label();
                        label.Location = new Point(500, 38 + 40 * i);
                        label.Text = dataGridView1.Columns[i + 1].HeaderText;
                        label.Visible = true;
                        labels[i] = label;
                        panel2.Controls.Add(label);

                        if (i == 0 || i == 1 || i == 2 || i == 3 || i == 4)
                        {
                            MaskedTextBox textbox = new MaskedTextBox();
                            textbox.Location = new Point(500 + label.Width + 20, 38 + 40 * i);
                            textbox.Mask = "";
                            textbox.Visible = true;
                            panel2.Controls.Add(textbox);
                            textcomboboxes[i] = textbox;
                        }
                        else
                        {
                            ComboBox comBox = new ComboBox();
                            comBox.Location = new Point(500 + label.Width + 20, 38 + 40 * i);
                            comBox.Visible = true;
                            comBox.DropDownStyle = ComboBoxStyle.DropDownList;
                            panel2.Controls.Add(comBox);
                            textcomboboxes[i] = comBox;

                        }
                    }

                    break;
                //case "Комната":
                    //DataGridLoaded(AUD.qrRoom);

                   // break;

                case "Уборка":
                    DataGridLoaded(AUD.qrUborka);
                    for (int i = 0; i < 3; i++)
                    {
                        Label label = new Label();
                        label.Location = new Point(500, 38 + 40 * i);
                        label.Text = dataGridView1.Columns[i + 1].HeaderText;
                        label.Visible = true;
                        labels[i] = label;
                        panel2.Controls.Add(label);

                        if (i == 0)
                        {
                            MaskedTextBox textbox = new MaskedTextBox();
                            textbox.Location = new Point(500 + label.Width + 20, 38 + 40 * i);
                            textbox.Mask = "";
                            textbox.Visible = true;
                            panel2.Controls.Add(textbox);
                            textcomboboxes[i] = textbox;
                        }
                        else
                        {
                            ComboBox Combox = new ComboBox();
                            Combox.Location = new Point(500 + label.Width + 20, 38 + 40 * i);
                            Combox.Visible = true;
                            Combox.DropDownStyle = ComboBoxStyle.DropDownList;
                            panel2.Controls.Add(Combox);
                            textcomboboxes[i] = Combox;
                        }
                    }
                    break;
                case "Роли":
                    DataGridLoaded(AUD.qrRole);
                    for (int i = 0; i < 9; i++)
                    {
                        Label label = new Label();
                        label.Location = new Point(500, 38 + 40 * i);
                        label.Text = dataGridView1.Columns[i + 1].HeaderText;
                        label.Visible = true;
                        labels[i] = label;
                        panel2.Controls.Add(label);

                        ComboBox Combox = new ComboBox();
                        Combox.Location = new Point(500 + label.Width + 20, 38 + 40 * i);
                        Combox.Visible = true;
                        Combox.DropDownStyle = ComboBoxStyle.DropDownList;
                        panel2.Controls.Add(Combox);
                        textcomboboxes[i] = Combox;
                    }
                    break;
                case "Профессии":
                    DataGridLoaded(AUD.qrProfession);
                    for (int i = 0; i < 2; i++)
                    {
                        Label label = new Label();
                        label.Location = new Point(500, 38 + 40 * i);
                        label.Text = dataGridView1.Columns[i + 1].HeaderText;
                        label.Visible = true;
                        labels[i] = label;
                        panel2.Controls.Add(label);



                        MaskedTextBox textbox = new MaskedTextBox();
                        textbox.Location = new Point(500 + label.Width + 20, 38 + 40 * i);
                        textbox.Mask = "";
                        textbox.Visible = true;
                        panel2.Controls.Add(textbox);
                        textcomboboxes[i] = textbox;
                    }
                    break;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Enabled = true;
            panel2.Visible = false;
            panel2.Enabled = false;
            ClearPanel();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bron_room br_room = new Bron_room();
            br_room.Show();

        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
