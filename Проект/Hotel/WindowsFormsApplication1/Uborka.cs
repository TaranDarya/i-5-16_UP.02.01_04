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
    public partial class Uborka : Form
    {
        public Uborka()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Uborka_Load(object sender, EventArgs e)
        {

            try
            {
                AUD.sql.Open();
                SqlCommand command = new SqlCommand("SELECT id_uborka, time_uborka as 'Время уборки', sotr_id as 'Код сотрудника', room_id as 'Код комнаты' FROM Uborka", AUD.sql);
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
