using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N13310018
{
    public partial class FormMidC2F : Form
    {
        public FormMidC2F()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double c = double.Parse(textBox1.Text);
            double f = c*(9/5.0)+32;

            label3.Text = f.ToString();    
        }
    }
}
