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
    public partial class Form9 : Form
    {
        string ID;
        int A_ID;
        public Form9()
        {
            InitializeComponent();
        }

        public Form9(int x)
        {
            InitializeComponent();
            A_ID = x;
            ID = x.ToString();
            label12.Text = "Welcome Admin: " + ID;
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection CN = new SqlConnection("Data Source=DESKTOP-KEJ0LLV;Initial Catalog=Airport;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = CN;
            CN.Open();
            sqlCommand.CommandText = "INSERT INTO PILOT ([PILOTID],[FNAME],[LNAME],[EXPERIANCE],[GENDER]) VALUES('" + textBox1.Text + "' , '" + textBox2.Text + "' , '" + textBox3.Text + "' , '" + textBox4.Text + "' , '" + comboBox1.Text + "' )";
            sqlCommand.ExecuteNonQuery();
            CN.Close();
            MessageBox.Show("Data Inserted Successfully");

            this.pILOTTableAdapter.Fill(this.airportDataSet.PILOT);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection CN = new SqlConnection("Data Source=DESKTOP-KEJ0LLV;Initial Catalog=Airport;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = CN;
            CN.Open();
            sqlCommand.CommandText = "Update PILOT SET [FNAME] = '" + textBox2.Text + "' , [LNAME] = '" + textBox3.Text + "' , [EXPERIANCE] = '" + textBox4.Text + "',[Gender]= '" + comboBox1.Text + "'where PILOTID = '" + textBox1.Text + "'";
            sqlCommand.ExecuteNonQuery();
            CN.Close();
            MessageBox.Show("Data Updated Successfully");

            this.pILOTTableAdapter.Fill(this.airportDataSet.PILOT);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection CN = new SqlConnection("Data Source=DESKTOP-KEJ0LLV;Initial Catalog=Airport;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = CN;
            CN.Open();
            sqlCommand.CommandText = "Delete FROM DRIVED_BY where PILOTID = '" + textBox1.Text + "'";
            sqlCommand.ExecuteNonQuery();
            sqlCommand.CommandText = "Delete FROM PILOT where PILOTID = '" + textBox1.Text + "'";
            sqlCommand.ExecuteNonQuery();
            CN.Close();
            MessageBox.Show("Data Deleted Successfully");

            this.pILOTTableAdapter.Fill(this.airportDataSet.PILOT);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airportDataSet.PILOT' table. You can move, or remove it, as needed.
            this.pILOTTableAdapter.Fill(this.airportDataSet.PILOT);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(A_ID);
            f2.Show();
            this.Hide();
        }
    }
}
