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
    public partial class Bron_room : Form
    {
        public Bron_room()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu mn = new Menu();
            mn.Show();
        }

        private void Bron_room_Load(object sender, EventArgs e)
        {
            try
            {
                AUD.sql.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Hotel", AUD.sql);
                DataTable datatbl = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(datatbl);
                id_hotel.DisplayMember = "name_hotel";// столбец для отображения
                id_hotel.ValueMember = "id_hotel";//столбец с id
                id_hotel.SelectedIndex = -1;
                id_hotel.DataSource = datatbl;
                
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

        private void Bron_room_FormClosing(object sender, FormClosingEventArgs e)
        {
            Menu mn = new Menu();
            mn.Show();
        }

        private void id_hotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows[0].Cells[0].Value = id_hotel.Text;
        }
    }
}
