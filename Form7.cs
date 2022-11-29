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
    public partial class Form7 : Form
    {
        string ID;
        int A_ID;
        public Form7()
        {
            InitializeComponent();
        }
        public Form7(int x)
        {
            InitializeComponent();
            A_ID = x;
            ID = x.ToString();
            textBox4.Text =  ID;            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection CN = new SqlConnection("Data Source=DESKTOP-KEJ0LLV;Initial Catalog=Airport;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = CN;
            CN.Open();
            sqlCommand.CommandText = "INSERT INTO FLIGHT ([FLIGHTID],[PILOTID],[AIRCRAFTID],[ADMINID],[FROM_LOCATION],[TO_LOCATION],[DEPARTURE_TIME],[ARRIVAL_TIME],[DURATION],[RESERVED_SEATS]) VALUES('" + textBox1.Text + "' , '" + textBox2.Text + "' , '" + textBox3.Text + "' , '" + textBox4.Text + "' , '" + textBox5.Text + "' , '" + textBox6.Text + "' , '" + dateTimePicker1.Value.ToString() + "', '" + dateTimePicker2.Value.ToString() + "', '" + textBox9.Text + "', '" + textBox10.Text + "' )";
            sqlCommand.ExecuteNonQuery();
            CN.Close();
            MessageBox.Show("Data Inserted Successfully");

            this.fLIGHTTableAdapter.Fill(this.airportDataSet.FLIGHT);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection CN = new SqlConnection("Data Source=DESKTOP-KEJ0LLV;Initial Catalog=Airport;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = CN;
            CN.Open();
            sqlCommand.CommandText = "Update FLIGHT SET [PILOTID] = '" + textBox2.Text + "' ,[AIRCRAFTID] = '" + textBox3.Text + "' ,[ADMINID] = '" + textBox4.Text + "' ,[From_Location] = '" + textBox5.Text + "' , [To_location] = '" + textBox6.Text + "' , [Departure_time] = '" + dateTimePicker1.Value.ToString() + "',[Arrival_Time]= '" + dateTimePicker2.Value.ToString() + "',[Duration]= '" + textBox9.Text + "',[Reserved_seats]= '" + textBox10.Text + "'where FLIGHTID = '" + textBox1.Text + "'";
            sqlCommand.ExecuteNonQuery();
            CN.Close();
            MessageBox.Show("Data Updated Successfully");

            this.fLIGHTTableAdapter.Fill(this.airportDataSet.FLIGHT);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection CN = new SqlConnection("Data Source=DESKTOP-KEJ0LLV;Initial Catalog=Airport;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = CN;
            CN.Open();
            sqlCommand.CommandText = "Delete FROM FLIGHT where FLIGHTID = '" + textBox1.Text + "'";
            sqlCommand.ExecuteNonQuery();
            CN.Close();
            MessageBox.Show("the flight was Deleted Successfully");

            this.fLIGHTTableAdapter.Fill(this.airportDataSet.FLIGHT);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airportDataSet.FLIGHT' table. You can move, or remove it, as needed.
            this.fLIGHTTableAdapter.Fill(this.airportDataSet.FLIGHT);
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airportDataSet.PILOT' table. You can move, or remove it, as needed.
            this.pILOTTableAdapter.Fill(this.airportDataSet.PILOT);
            // TODO: This line of code loads data into the 'airportDataSet.AIRCRAFT' table. You can move, or remove it, as needed.
            this.aIRCRAFTTableAdapter.Fill(this.airportDataSet.AIRCRAFT);
            // TODO: This line of code loads data into the 'airportDataSet.FLIGHT' table. You can move, or remove it, as needed.
            this.fLIGHTTableAdapter.Fill(this.airportDataSet.FLIGHT);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(A_ID);
            f2.Show();
            this.Hide();
        }
    }
}
