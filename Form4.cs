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

namespace Airport
{
    public partial class Form4 : Form
    {
        int A_ID;
        public Form4()
        {
            InitializeComponent();
        }
        public Form4(int x)
        {
            InitializeComponent();
            A_ID = x;
            label12.Text ="Your admin ID is" +A_ID.ToString();
            textBox9.UseSystemPasswordChar = true;
        }

        private void Form4_Load(object sender, EventArgs e)
        {


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection CN = new SqlConnection("Data Source=DESKTOP-KEJ0LLV;Initial Catalog=Airport;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = CN;
            CN.Open();
            sqlCommand.CommandText = "INSERT INTO Admin ([ADMINID],[A_NATIONALID],[FNAME],[LNAME],[GENDER],[ADMIN_ADD],[PHONENO],[EMAIL],[USERNAME],[PASS]) VALUES('" + textBox1.Text + "' , '" + textBox2.Text + "' , '" + textBox3.Text + "' , '" + textBox4.Text + "' , '" + comboBox1.Text + "' , '" + textBox5.Text + "' , '" + textBox6.Text + "' , '" + textBox7.Text + "' , '" + textBox8.Text + "' , '" + textBox9.Text + "')";
            sqlCommand.ExecuteNonQuery();
            CN.Close();
            MessageBox.Show("Data Inserted Successfully");
            this.aDMINTableAdapter.Fill(this.airportDataSet.ADMIN);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airportDataSet.ADMIN' table. You can move, or remove it, as needed.
            this.aDMINTableAdapter.Fill(this.airportDataSet.ADMIN);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection CN = new SqlConnection("Data Source=DESKTOP-KEJ0LLV;Initial Catalog=Airport;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = CN;
            CN.Open();
            sqlCommand.CommandText = "Update Admin SET [FNAME] = '" + textBox3.Text + "' , [LNAME] = '" + textBox4.Text + "' , [ADMIN_ADD] = '" + textBox5.Text + "',[PHONENO]= '" + textBox6.Text + "',[EMAIL]= '" + textBox7.Text + "',[USERNAME]= '" + textBox8.Text + "',[PASS]= '" + textBox9.Text + "',[Gender]= '" + comboBox1.Text + "'where ADMINID = '" + textBox1.Text + "'";
            sqlCommand.ExecuteNonQuery();
            CN.Close();
            MessageBox.Show("Data Updated Successfully");
            this.aDMINTableAdapter.Fill(this.airportDataSet.ADMIN);            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection CN = new SqlConnection("Data Source=DESKTOP-KEJ0LLV;Initial Catalog=Airport;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = CN;
            CN.Open();
            sqlCommand.CommandText = "Delete FROM REGISTERATION where ADMINID = '" + textBox1.Text + "'";
            sqlCommand.ExecuteNonQuery();
            sqlCommand.CommandText = "Delete FROM Admin where ADMINID = '" + textBox1.Text + "'";
            sqlCommand.ExecuteNonQuery();
            CN.Close();
            MessageBox.Show("Data Deleted Successfully");
            this.aDMINTableAdapter.Fill(this.airportDataSet.ADMIN);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(A_ID);
            f2.Show();
            this.Hide();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {




        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox9.UseSystemPasswordChar = false;
            }
            else
            {
                textBox9.UseSystemPasswordChar = true;
            }
        }
    }
}
