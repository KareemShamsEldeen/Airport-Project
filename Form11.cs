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
    public partial class Form11 : Form
    {
        int A_ID;
        string ID;        
        public Form11()
        {
            InitializeComponent();
        }
        public Form11(int x)
        {
            
            InitializeComponent();
            A_ID = x;
            ID = x.ToString();
            label12.Text = "Welcome Admin: " + ID;
            textBox1.Text = ID;
            label13.Visible = false;
            textBox8.Visible = false;
            label14.Visible = false;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //insert
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-KEJ0LLV;Initial Catalog=Airport;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();

            sqlCommand.CommandText = "INSERT INTO MODEL([MODELID] ,[ENGINE] , [WINGS_TYPE] , [DESIGN] ) VALUES('" + textBox2.Text + "', '" + comboBox2.Text + "','" + comboBox3.Text + "', '" + textBox7.Text + "')";
            sqlCommand.ExecuteNonQuery();

            sqlCommand.CommandText = "INSERT INTO AIRCRAFT ([ADMINID] , [MODELID] , [AIRCRAFTID] , [WEIGHT] , [MAX_NO_OF_SEATS] , [MODEL_CODE] , [TYPE] ) VALUES('" + textBox1.Text + "' , '" + textBox2.Text + "' , '" + textBox3.Text + "' , '" + textBox4.Text + "' , '" + textBox5.Text + "' , '" + textBox6.Text + "' , '" + comboBox1.Text + "')";
            sqlCommand.ExecuteNonQuery();

            if (comboBox1.Text == "Public")
            {
                label13.Visible = true;
                textBox8.Visible = true;
                label14.Visible = false;
                sqlCommand.CommandText = "Insert Into [PUBLIC] ([ADMINID] ,[MODELID] , [AIRCRAFTID] , [WEIGHT], [MAX_NO_OF_SEATS], [MODEL_CODE], [TYPE] , [COMPANY_NAME]) Values('" + textBox1.Text + "' , '" + textBox2.Text + "' , '" + textBox3.Text + "' , '" + textBox4.Text + "' , '" + textBox5.Text + "' , '" + textBox6.Text + "' , '" + comboBox1.Text + "' , '" + textBox8.Text + "')";
                sqlCommand.ExecuteNonQuery();


            }
            else if(comboBox1.Text == "Special")
            {
                label14.Visible = true;
                textBox8.Visible = true;
                label13.Visible = false;
                sqlCommand.CommandText = "Insert Into [SPECIAL] ( [ADMINID] ,[MODELID] , [AIRCRAFTID] , [WEIGHT], [MAX_NO_OF_SEATS], [MODEL_CODE], [TYPE], [OWNER_NAME]) Values('" + textBox1.Text + "' , '" + textBox2.Text + "' , '" + textBox3.Text + "' , '" + textBox4.Text + "' , '" + textBox5.Text + "' , '" + textBox6.Text + "' , '" + comboBox1.Text + "' , '" + textBox8.Text + "')";
                sqlCommand.ExecuteNonQuery();


            }

            sqlConnection.Close();
            MessageBox.Show("AIRCRAFT Inserted Successfully");
            
            this.mODELTableAdapter.Fill(this.airportDataSet.MODEL);
            this.aIRCRAFTTableAdapter.Fill(this.airportDataSet.AIRCRAFT);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //update
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-KEJ0LLV;Initial Catalog=Airport;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();

            sqlCommand.CommandText = "Update MODEL SET [ENGINE] = '" + comboBox2.Text + "' , [WINGS_TYPE] = '" + comboBox3.Text + "' , [DESIGN] = '" + textBox7.Text + "' where MODELID = '" + textBox2.Text + "'";
            sqlCommand.ExecuteNonQuery();

            sqlCommand.CommandText = "Update AIRCRAFT SET  [WEIGHT] = '" + textBox4.Text + "' , [MAX_NO_OF_SEATS] = '" + textBox5.Text + "' , [MODEL_CODE] = '" + textBox6.Text + "' where AIRCRAFTID = '" + textBox3.Text + "'";
            sqlCommand.ExecuteNonQuery();

            sqlCommand.CommandText = "Insert into UPDATE_AN ([ADMINID] , [AIRCRAFTID]) VALUES ('" + textBox1.Text + "' , '" + textBox3.Text + "')";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("AIRCRAFT Updated Successfully");
            
            this.mODELTableAdapter.Fill(this.airportDataSet.MODEL);
            this.aIRCRAFTTableAdapter.Fill(this.airportDataSet.AIRCRAFT);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // delete
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-KEJ0LLV;Initial Catalog=Airport;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();

            
            sqlCommand.CommandText = "Delete FROM DRIVED_BY where AIRCRAFTID = '" + textBox3.Text + "'";
            sqlCommand.ExecuteNonQuery();
            sqlCommand.CommandText = "Delete FROM FLIGHT where AIRCRAFTID = '" + textBox3.Text + "'";
            sqlCommand.ExecuteNonQuery();
            sqlCommand.CommandText = "Delete FROM [PUBLIC] where AIRCRAFTID = '" + textBox3.Text + "'";
            sqlCommand.ExecuteNonQuery();
            sqlCommand.CommandText = "Delete FROM [SPECIAL] where AIRCRAFTID = '" + textBox3.Text + "'";
            sqlCommand.ExecuteNonQuery();
            sqlCommand.CommandText = "Delete FROM UPDATE_AN where AIRCRAFTID = '" + textBox3.Text + "'";
            sqlCommand.ExecuteNonQuery();
            sqlCommand.CommandText = "Delete FROM AIRCRAFT where AIRCRAFTID = '" + textBox3.Text + "'";
            sqlCommand.ExecuteNonQuery();
            sqlCommand.CommandText = "Delete FROM MODEL where MODELID = '" + textBox2.Text + "'";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("AIRCRAFT Deleted Successfully");
            
            this.mODELTableAdapter.Fill(this.airportDataSet.MODEL);
            this.aIRCRAFTTableAdapter.Fill(this.airportDataSet.AIRCRAFT);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(A_ID);
            f2.Show(); // Shows Form2
            this.Hide();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airportDataSet.MODEL' table. You can move, or remove it, as needed.
            this.mODELTableAdapter.Fill(this.airportDataSet.MODEL);
            // TODO: This line of code loads data into the 'airportDataSet.AIRCRAFT' table. You can move, or remove it, as needed.
            this.aIRCRAFTTableAdapter.Fill(this.airportDataSet.AIRCRAFT);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Public")
            {
                label13.Visible = true;
                textBox8.Visible = true;
                label14.Visible = false;


            }
            else if (comboBox1.Text == "Special")
            {
                label14.Visible = true;
                textBox8.Visible = true;
                label13.Visible = false;


            }

        }
    }
}
