using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblTest.Text = "HelloWorld!";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Form2 fom2 = new Form2();
            fom2.Show();
        }
    }
}
