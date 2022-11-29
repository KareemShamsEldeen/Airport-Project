using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Airport
{
    
    public partial class Form1 : Form
    {
        string A_textboxvalue;
        int A_ID;
        public Form1()
        {
            InitializeComponent();
            label4.Visible = false;
            label5.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            checkBox1.Visible = false;
            textBox2.UseSystemPasswordChar = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text=="Admin")
            {
                SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-KEJ0LLV;Initial Catalog=Airport;Integrated Security=True");
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlConnection.Open();
                string sqlquery = "SELECT ADMINID FROM ADMIN WHERE USERNAME = '" + textBox1.Text + "'AND PASS = '" + textBox2.Text + "'";
                SqlCommand command = new SqlCommand(sqlquery, sqlConnection);
                SqlDataReader sReader;

                SqlDataReader sqlDataReader = command.ExecuteReader();
                sReader = sqlDataReader;
                
                if (sReader.Read())
                {
                    A_textboxvalue = sReader["ADMINID"].ToString();
                    A_ID = Convert.ToInt32(A_textboxvalue);
                    MessageBox.Show("Welcome Admin: " + A_ID);
                    Form2 form2 = new Form2(A_ID);
                    form2.Show(); // Shows Form2
                    this.Hide();
                }
                else
                { 
                    MessageBox.Show("Invalid Username or Password");
                    
                }

                sReader.Close();

            }

            else if (comboBox1.Text == "Customer")
            {
                Form3 form3 = new Form3();
                form3.Show(); // Shows Form2
                this.Hide();
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Admin")
            {
                label4.Visible = true;
                label5.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                checkBox1.Visible = true;
            }
            else
            {
                label4.Visible = false;
                label5.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                checkBox1.Visible = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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
