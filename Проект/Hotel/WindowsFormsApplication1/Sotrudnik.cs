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
    public partial class Sotrudnik : Form
    {
        public Sotrudnik()
        {
            InitializeComponent();
        }

        private void Sotrudnik_Load(object sender, EventArgs e)
        {
            try
            {
                AUD.sql.Open();
                SqlCommand command = new SqlCommand("SELECT id_sotr, Name_sotr as 'Имя сотрудника', Surname_sotr as 'Фамилия сотрудника', Otch_sotr as 'Отчество сотрудника'," +
                "Tel_sotr as 'Телефон', Seria_pasp_sotr as 'Серия паспорта', hotel_id as 'Код отеля',prof_id as 'Код профессии' FROM Sotr", AUD.sql);
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
