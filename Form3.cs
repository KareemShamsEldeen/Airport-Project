using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airport
{
    public partial class Form3 : Form
    {
        string c_textboxvalue;
        string c1_textboxvalue;
        public Form3()
        {
            InitializeComponent();
            textBox2.UseSystemPasswordChar = true;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-KEJ0LLV;Initial Catalog=Airport;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            string sqlquery = "SELECT FNAME FROM CUSTOMER WHERE USERNAME = '" + textBox1.Text + "'AND PASS = '" + textBox2.Text + "'";
            SqlCommand command = new SqlCommand(sqlquery, sqlConnection);
            SqlDataReader sReader;

            SqlDataReader sqlDataReader = command.ExecuteReader();
            sReader = sqlDataReader;

            if (sReader.Read())
            {
                c_textboxvalue = sReader["FNAME"].ToString();
                
                MessageBox.Show("Welcome Customer: " + c_textboxvalue);

                c1_textboxvalue = textBox1.Text;
                Form8 f8 = new Form8(c1_textboxvalue);
                f8.Show();
                this.Hide();                


            }
            else
            {
                MessageBox.Show("Invalid Username or Password");

            }
            sReader.Close();

 
            /* Form8 f8 = new Form8();
             f8.Show();
             this.Hide();*/

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show(); // Shows Form2
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show(); // Shows Form2
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }
    }
}
