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

    
    public partial class Form8 : Form
    {
        string A_textboxvalue;
        private readonly Random _random = new Random();
        

        public string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[_random.Next(s.Length)]).ToArray());
        }
        

        public Form8()
        {
            InitializeComponent();
            textBox5.Visible = false;
            textBox6.Visible = false;
            label10.Visible = false;
            label9.Visible = false;
            label12.Visible = false;
            textBox7.Visible = false;
            button6.Visible = false;
            label13.Visible = false;
            textBox2.UseSystemPasswordChar = true;

        }
        public Form8(String x)
        {
            InitializeComponent();
            textBox5.Visible = false;
            textBox6.Visible = false;
            label10.Visible = false;
            label9.Visible = false;
            label12.Visible = false;
            textBox7.Visible = false;
            button6.Visible = false;
            label13.Visible = false;
            textBox2.UseSystemPasswordChar = true;
            A_textboxvalue = x;
            textBox1.Text = A_textboxvalue;

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'airportDataSet.FLIGHT' table. You can move, or remove it, as needed.
            this.fLIGHTTableAdapter.Fill(this.airportDataSet.FLIGHT);

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string c = RandomString(5);
            string c1 = RandomString(3);
            
            
            SqlConnection CN = new SqlConnection("Data Source=DESKTOP-KEJ0LLV;Initial Catalog=Airport;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = CN;
            CN.Open();
            string sqlquery = "SELECT SSN FROM Customer WHERE USERNAME = '" + textBox1.Text + "'AND PASS = '" + textBox2.Text + "'";
            string sqlquery1 = "SELECT FLIGHTID FROM FLIGHT WHERE FROM_LOCATION = '" + textBox3.Text + "'AND TO_LOCATION = '" + textBox4.Text + "'";
            SqlCommand command = new SqlCommand(sqlquery, CN);
            SqlCommand command1 = new SqlCommand(sqlquery1, CN);
            SqlDataReader sReader;

            SqlDataReader sqlDataReader = command.ExecuteReader();
            sReader = sqlDataReader;

            while (sReader.Read())
            {
                //MessageBox.Show("Welcome " + sReader["FNAME"].ToString());
                textBox6.Text = sReader["SSN"].ToString();
            }
            sReader.Close();

            SqlDataReader sqlDataReader1 = command1.ExecuteReader();
            sReader = sqlDataReader1;

            while (sReader.Read())
            {
                //MessageBox.Show("Welcome " + sReader["FNAME"].ToString());
                textBox5.Text = sReader["FLIGHTID"].ToString();
            }
            sReader.Close();
            sqlCommand.CommandText = "INSERT INTO TICKET ([TICKETID],[SSN],[FLIGHTID],[FROM],[TO],[FLIGHT_DATE],[FLIGHT_TIME],[SEAT_NO],[CLASS],[PRICE]) VALUES( '" + c + "','" + textBox6.Text + "', '" + textBox5.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + dateTimePicker1.Value.ToString() + "', '" + dateTimePicker1.Value.ToString() + "','" + c1 + "' ,'" + comboBox1.Text + "',15000 )";
            sqlCommand.ExecuteNonQuery();
            sqlCommand.CommandText = "Update Customer SET [TICKETID] = '" + c + "'where SSN = '" + textBox6.Text + "'";
            sqlCommand.ExecuteNonQuery();
            CN.Close();
            textBox5.Visible = true;
            textBox6.Visible = true;
            label10.Visible = true;
            label9.Visible = true;
            MessageBox.Show("Data Inserted Successfully");
        }


        private void button4_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airportDataSet.TICKET' table. You can move, or remove it, as needed.
            this.tICKETTableAdapter.Fill(this.airportDataSet.TICKET);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string c2 = RandomString(3);
            SqlConnection CN = new SqlConnection("Data Source=DESKTOP-KEJ0LLV;Initial Catalog=Airport;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = CN;
            CN.Open();
            
            string sqlquery = "SELECT SSN FROM Customer WHERE USERNAME = '" + textBox1.Text + "'AND PASS = '" + textBox2.Text + "'";
            string sqlquery1 = "SELECT FLIGHTID FROM FLIGHT WHERE FROM_LOCATION = '" + textBox3.Text + "'AND TO_LOCATION = '" + textBox4.Text + "'";
            SqlCommand command = new SqlCommand(sqlquery, CN);
            SqlCommand command1 = new SqlCommand(sqlquery1, CN);
            SqlDataReader sReader;

            SqlDataReader sqlDataReader = command.ExecuteReader();
            sReader = sqlDataReader;

            while (sReader.Read())
            {
                textBox6.Text = sReader["SSN"].ToString();
            }
            sReader.Close();

            SqlDataReader sqlDataReader1 = command1.ExecuteReader();
            sReader = sqlDataReader1;
            
            while (sReader.Read())
            {
                textBox5.Text = sReader["FLIGHTID"].ToString();
            }
            sReader.Close();
            sqlCommand.CommandText = "Update TICKET SET [SSN] = '" + textBox6.Text + "' , [FLIGHTID] = '" + textBox5.Text.ToString() + "' , [FROM] = '" + textBox3.Text + "',[TO]= '" + textBox4.Text + "',[FLIGHT_DATE]= '" + dateTimePicker1.Value.ToString() + "',[FLIGHT_TIME]= '" + dateTimePicker1.Value.ToString() + "',[CLASS]= '" + comboBox1.Text + "',[SEAT_NO]= '" + c2 + "'where TICKETID = '" + textBox7.Text + "'";
            sqlCommand.ExecuteNonQuery();
            CN.Close();
            MessageBox.Show("Data Updated Successfully");
            
            this.tICKETTableAdapter.Fill(this.airportDataSet.TICKET);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection CN = new SqlConnection("Data Source=DESKTOP-KEJ0LLV;Initial Catalog=Airport;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = CN;
            CN.Open();
            sqlCommand.CommandText = "Update Customer SET [TICKETID] = NULL where SSN = '" + textBox6.Text + "'";
            sqlCommand.ExecuteNonQuery();
            sqlCommand.CommandText = "Delete FROM TICKET where TICKETID = '" + textBox7.Text + "'";
            sqlCommand.ExecuteNonQuery();
            CN.Close();
            MessageBox.Show("Data Deleted Successfully");

            this.tICKETTableAdapter.Fill(this.airportDataSet.TICKET);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                label13.Visible = true;
                label12.Visible = true;
                textBox7.Visible = true;
                button6.Visible = true;

            }
            else if (checkBox2.Checked == false)
            {
                label13.Visible = false;
                label12.Visible = false;
                textBox7.Visible = false;
                button6.Visible = false;

            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                label13.Visible = true;
                label12.Visible = true;
                textBox7.Visible = true;
                button6.Visible = true;

            }
            else if (checkBox2.Checked == false)
            {
                label13.Visible = false;
                label12.Visible = false;
                textBox7.Visible = false;
                button6.Visible = false;

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Continue
            string c = RandomString(5);
            string c1 = RandomString(3);
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-KEJ0LLV;Initial Catalog=Airport;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();

            string sqlquery = "SELECT CLASS FROM TICKET WHERE TICKETID = '" + textBox7.Text + "'";
            string sqlquery1 = "SELECT [from] FROM TICKET WHERE TICKETID = '" + textBox7.Text + "'";
            string sqlquery2 = "SELECT [to] FROM TICKET WHERE TICKETID = '" + textBox7.Text + "'";
            SqlCommand command = new SqlCommand(sqlquery, sqlConnection);
            SqlCommand command1 = new SqlCommand(sqlquery1, sqlConnection);
            SqlCommand command2 = new SqlCommand(sqlquery2, sqlConnection);
            SqlDataReader sReader;

            SqlDataReader sqlDataReader = command.ExecuteReader();
            sReader = sqlDataReader;

            while (sReader.Read())
            {
                comboBox1.Text = sReader["CLASS"].ToString();
            }
            sReader.Close();

            SqlDataReader sqlDataReader1 = command1.ExecuteReader();
            sReader = sqlDataReader1;

            while (sReader.Read())
            {
                textBox3.Text = sReader["from"].ToString();
            }
            sReader.Close();

            SqlDataReader sqlDataReader2 = command2.ExecuteReader();
            sReader = sqlDataReader2;

            while (sReader.Read())
            {
                textBox4.Text = sReader["to"].ToString();
            }
            sReader.Close();
            //------------------------------------------------Select With Join---------------------------------------------------------------
             string sqlquery3 = "SELECT CUSTOMER.SSN FROM CUSTOMER , TICKET WHERE TICKET.TICKETID = '" + textBox7.Text + "' AND CUSTOMER.TICKETID = TICKET.TICKETID";
            //--------------------------------------------------------------------------------------------------------------------------------
    
            string sqlquery4 = "SELECT FLIGHTID FROM FLIGHT WHERE FROM_LOCATION = '" + textBox3.Text + "'AND TO_LOCATION = '" + textBox4.Text + "'";
            SqlCommand command3 = new SqlCommand(sqlquery3, sqlConnection);
            SqlCommand command4 = new SqlCommand(sqlquery4, sqlConnection);
            SqlDataReader sReader1;

            SqlDataReader sqlDataReader3 = command3.ExecuteReader();
            sReader1 = sqlDataReader3;

            while (sReader1.Read())
            {
                textBox6.Text = sReader1["SSN"].ToString();
            }
            sReader1.Close();

            SqlDataReader sqlDataReader4 = command4.ExecuteReader();
            sReader1 = sqlDataReader4;

            while (sReader1.Read())
            {
                textBox5.Text = sReader1["FLIGHTID"].ToString();
            }
            sReader1.Close();

            this.tICKETTableAdapter.Fill(this.airportDataSet.TICKET);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string select = "SELECT * FROM FLIGHT where [FROM_LOCATION] = '" + textBox3.Text + "' OR [TO_LOCATION] = '" + textBox4.Text + "' OR [DEPARTURE_TIME] = '" + dateTimePicker1.Value.ToString() + "'";
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-KEJ0LLV;Initial Catalog=Airport;Integrated Security=True");
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sqlConnection.Open();
            adapter = new SqlDataAdapter(select, sqlConnection);
            adapter.Fill(ds, "FLIGHT");
            sqlConnection.Close();
            dataGridView1.DataSource = ds.Tables[0];
            

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
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
