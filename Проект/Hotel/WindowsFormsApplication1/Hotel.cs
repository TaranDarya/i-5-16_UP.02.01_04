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
    public partial class Hotel : Form
    {
        public Hotel()
        {
            InitializeComponent();
        }

        private void Hotel_Load(object sender, EventArgs e)
        {
            try
            {
                AUD.sql.Open();
                SqlCommand command = new SqlCommand("SELECT id_hotel, name_hotel as 'Название отеля', mesto_hotel as 'Место отеля', stars_hotel as 'Звезды отеля' FROM Hotel", AUD.sql);
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
    }
    
}
