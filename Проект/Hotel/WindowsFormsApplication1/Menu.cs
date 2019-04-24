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
        object[] textcomboboxes = new object[7];

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



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) // Выбор таблицы для отображения
        {
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
                    for (int i = 0; i < ; i++)
                    {
                        Label label = new Label();
                        label.Location = new Point(500, 38 + 40 * i);
                        label.Text = dataGridView1.Columns[i + 1].HeaderText;
                        label.Visible = true;
                        panel2.Controls.Add(label);

                        MaskedTextBox textbox = new MaskedTextBox();
                        textbox.Location = new Point(500 + label.Width + 20, 38 + 40 * i);
                        textbox.Mask = "";
                        textbox.Visible = true;
                        panel2.Controls.Add(textbox);
                        textcomboboxes[i] = textbox;
                    }

                    break;
                case "Постоялец":
                    DataGridLoaded(AUD.qrPost);

                    break;
                case "Сотрудник":
                    DataGridLoaded(AUD.qrSotr);

                    break;
                case "Соискатель":
                    DataGridLoaded(AUD.qrSoisk);

                    break;
                case "Комната":
                    DataGridLoaded(AUD.qrRoom);

                    break;
                case "Уборка":
                    DataGridLoaded(AUD.qrUborka);

                    break;
                case "Роли":
                    DataGridLoaded(AUD.qrRole);

                    break;
                case "Профессия":
                    DataGridLoaded(AUD.qrProfession);

                    break;
            }
        }
    }
}
