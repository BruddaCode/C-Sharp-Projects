using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            string sGetal1 = tbGetal1.Text;
            double dGetal1 = double.Parse(sGetal1); // Parse is omzetten van ene datatype naar ander datatype
            string sGetal2 = tbGetal2.Text;
            double dGetal2 = double.Parse(sGetal2);
            double dResultaat = dGetal1 + dGetal2;
            tbResultaat.Text = dResultaat.ToString(); 
            
        }
    }
}
