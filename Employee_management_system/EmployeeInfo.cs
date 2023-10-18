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

namespace Employee_management_system
{
    public partial class EmployeeInfo : Form
    {
        public EmployeeInfo()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-RJLLT5B\\SQLEXPRESS03;Initial Catalog=employee;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                SqlCommand cnn = new SqlCommand("Select * from emptab", con);

                SqlDataAdapter da = new SqlDataAdapter(cnn);

                DataTable table = new DataTable();

                da.Fill(table);

                dataGridView1.DataSource = table;
            

        }
    }
}
