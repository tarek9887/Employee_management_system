using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using System.Data.SqlClient;

namespace Employee_management_system
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var connectionString = "Data Source=DESKTOP-RJLLT5B\\SQLEXPRESS03;Initial Catalog=employeedb;Integrated Security=True";

                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                var insertQuery = "insert into emptb values(@Id, @EmployeeName, @Age,@Email,@Salary,@Dob, @Benifits)";

                SqlCommand sqlCommand = new SqlCommand(insertQuery, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@EmployeeName", textBox1.Text);
                sqlCommand.Parameters.AddWithValue("@Id", textBox2.Text);
                sqlCommand.Parameters.AddWithValue("@Age", int.Parse(textBox1.Text));
                sqlCommand.Parameters.AddWithValue("@Email", textBox4.Text);
                sqlCommand.Parameters.AddWithValue("@Salary", textBox5.Text);
                sqlCommand.Parameters.AddWithValue("@Dob", DateTime.Parse(textBox6.Text));
                sqlCommand.Parameters.AddWithValue("@Benifits", textBox7.Text);

                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                MessageBox.Show("Data Inserted Succesfully!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Somthing went wrong");
            }

        }

        void BindData()
        {
            SqlCommand cnn = new SqlCommand("Select * from emptab");

            SqlDataAdapter da = new SqlDataAdapter(cnn);

            DataTable table = new DataTable();

            da.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";

            MessageBox.Show("Data inserted sucessfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var connectionString = "Data Source=DESKTOP-RJLLT5B\\SQLEXPRESS03;Initial Catalog=employeedb;Integrated Security=True";

                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                string deleteCommand = "delete emptb where Id=@Id";
                SqlCommand sqlCommand = new SqlCommand(deleteCommand, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@Id", textBox1.Text);
                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();

                MessageBox.Show("Student's Data Deleted!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BindData();
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }

       
    }
    
}

  
    

