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
    public partial class Form10 : Form
    {

        int A_ID;
        public Form10()
        {
            InitializeComponent();
        }
        public Form10(int x)
        {
            InitializeComponent();
            A_ID = x;
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airportDataSet.REGISTERATION' table. You can move, or remove it, as needed.
            this.rEGISTERATIONTableAdapter.Fill(this.airportDataSet.REGISTERATION);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(A_ID);
            f2.Show();
            this.Hide();
        }
    }
}
