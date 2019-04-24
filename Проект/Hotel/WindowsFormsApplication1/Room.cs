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
    public partial class Room : Form
    {
        public Room()
        {
            InitializeComponent();
        }

        private void Room_Load(object sender, EventArgs e)
        {

            try
            {
                AUD.sql.Open();
                SqlCommand command = new SqlCommand("SELECT id_room, num_room as 'Номер комнаты', price_room as 'Стоимость', hotel_id as 'Код отеля' FROM Room", AUD.sql);
                DataTable datatbl = new DataTable();
                datatbl.Load(command.ExecuteReader());
                dataGridView1.DataSource = datatbl.DefaultView;
                //dataGridView1.Columns[0].Visible = false;
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
