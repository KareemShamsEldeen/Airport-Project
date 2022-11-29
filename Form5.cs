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
    public partial class Form5 : Form
    {
        int A_ID;
        string ID;
        public Form5()
        {
            InitializeComponent();
            label1.Visible = false;
            textBox1.Visible = false;
            button6.Visible = false;
            textBox9.UseSystemPasswordChar = true;
        }
        public Form5(int x)
        {
            InitializeComponent();
            label1.Visible = false;
            textBox1.Visible = false;
            button6.Visible = false;
            A_ID = x;
            ID = x.ToString();
            textBox1.Text = ID;
            textBox9.UseSystemPasswordChar = true;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airportDataSet.CUSTOMER' table. You can move, or remove it, as needed.
            this.cUSTOMERTableAdapter.Fill(this.airportDataSet.CUSTOMER);

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection CN = new SqlConnection("Data Source=DESKTOP-KEJ0LLV;Initial Catalog=Airport;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = CN;
            CN.Open();
            sqlCommand.CommandText = "Update CUSTOMER SET [FNAME] = '" + textBox3.Text + "' , [LNAME] = '" + textBox4.Text + "' , [CUST_ADD] = '" + textBox5.Text + "',[PHONENO]= '" + textBox6.Text + "',[EMAIL]= '" + textBox7.Text + "',[USERNAME]= '" + textBox8.Text + "',[PASS]= '" + textBox9.Text + "',[Gender]= '" + comboBox1.Text + "'where SSN = '" + textBox2.Text + "'";
            sqlCommand.ExecuteNonQuery();
            CN.Close();
            MessageBox.Show("Data Updated Successfully");
            
            this.cUSTOMERTableAdapter.Fill(this.airportDataSet.CUSTOMER);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection CN = new SqlConnection("Data Source=DESKTOP-KEJ0LLV;Initial Catalog=Airport;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = CN;
            CN.Open();
            sqlCommand.CommandText = "Delete FROM REGISTERATION where SSN = '" + int.Parse(textBox2.Text) + "'";
            sqlCommand.ExecuteNonQuery();
            sqlCommand.CommandText = "Update CUSTOMER SET [TICKETID] = NULL where SSN = '" + textBox2.Text + "'";
            sqlCommand.ExecuteNonQuery();
            sqlCommand.CommandText = "Delete FROM TICKET where SSN = '" + textBox2.Text + "'";
            sqlCommand.ExecuteNonQuery();
            sqlCommand.CommandText = "Delete FROM CUSTOMER where SSN = '" + textBox2.Text + "'";
            sqlCommand.ExecuteNonQuery();
            CN.Close();
            MessageBox.Show("Data Deleted Successfully");
            
            this.cUSTOMERTableAdapter.Fill(this.airportDataSet.CUSTOMER);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.cUSTOMERTableAdapter.Fill(this.airportDataSet.CUSTOMER);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection CN = new SqlConnection("Data Source=DESKTOP-KEJ0LLV;Initial Catalog=Airport;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = CN;
            CN.Open();
            if (comboBox2.Text == "Admin")
            {
                sqlCommand.CommandText = "INSERT INTO CUSTOMER([SSN], [FNAME], [LNAME], [GENDER], [CUST_ADD], [PHONENO], [EMAIL], [USERNAME], [PASS]) VALUES('" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + comboBox1.Text + "', '" + textBox6.Text + "', '" + textBox7.Text + "', '" + textBox8.Text + "', '" + textBox9.Text + "')";
                sqlCommand.ExecuteNonQuery();
                sqlCommand.CommandText = "INSERT INTO REGISTERATION([SSN],[ADMINID],[DATE]) VALUES('" + textBox2.Text + "','" + textBox1.Text + "','" + DateTime.Now+ "')";
                sqlCommand.ExecuteNonQuery();
            }
            else if (comboBox2.Text == "Customer")
            {
                
                sqlCommand.CommandText = "INSERT INTO CUSTOMER([SSN], [FNAME], [LNAME], [GENDER], [CUST_ADD], [PHONENO], [EMAIL], [USERNAME], [PASS]) VALUES('" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + comboBox1.Text + "', '" + textBox6.Text + "', '" + textBox7.Text + "', '" + textBox8.Text + "', '" + textBox9.Text + "')";
                sqlCommand.ExecuteNonQuery();
                sqlCommand.CommandText = "INSERT INTO REGISTERATION([SSN],[ADMINID],[DATE]) VALUES('" + textBox2.Text + "','0','" + DateTime.Now + "')";
                sqlCommand.ExecuteNonQuery();
            }
            /*sqlCommand.CommandText = "INSERT INTO CUSTOMER([SSN], [FNAME], [LNAME], [GENDER], [CUST_ADD], [PHONENO], [EMAIL], [USERNAME], [PASS]) VALUES('" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + comboBox1.Text + "', '" + textBox6.Text + "', '" + textBox7.Text + "', '" + textBox8.Text + "', '" + textBox9.Text + "')";
            sqlCommand.CommandText = "INSERT INTO REGISTERATION([SSN],[ADMINID],[DATE]) VALUES('" + textBox2.Text + "','" + textBox1.Text + "','"+ dateTimePicker1 + "')";
            */

            CN.Close();
            MessageBox.Show("Data Inserted Successfully");
            
            this.cUSTOMERTableAdapter.Fill(this.airportDataSet.CUSTOMER);

        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Admin")
            {
                label1.Visible = true;
                textBox1.Visible = true;
                button6.Visible = true;

            }
            else if (comboBox2.Text == "Customer")
            {
                label1.Visible = false;
                textBox1.Visible = false;
                button6.Visible = false;
            }
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

        private void button7_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
            this.Hide();
        }
    }
}
