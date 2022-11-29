using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airport
{
    public partial class Form2 : Form
    {
        string ID;
        int A_ID;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(int x)
        {
            InitializeComponent();
            A_ID = x;
            ID = x.ToString();
            label3.Text ="Your Admin ID:" +ID;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Admin")
            {
                Form4 f4 = new Form4(A_ID);
                f4.Show();
                this.Hide();
            }
            else if (comboBox1.Text == "Customer")
            {
                Form5 f5 = new Form5(A_ID);
                f5.Show();
                this.Hide();
            }
            else if (comboBox1.Text == "Pilot")
            {
                Form9 f9 = new Form9(A_ID);
                f9.Show();
                this.Hide();
            }
            else if (comboBox1.Text == "Flight")
             {
                 Form7 f7 = new Form7(A_ID);
                 f7.Show();
                 this.Hide();
             }
            else if (comboBox1.Text == "Aircraft")
            {
                Form11 f11 = new Form11(A_ID);
                f11.Show();
                this.Hide();
            }
            else
             {
                 MessageBox.Show("Please select a who to modify");
             }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show(); // Shows Form1
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10(A_ID);
            form10.Show(); // Shows Form1
            this.Hide();
        }
    }
}
