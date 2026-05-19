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
    public partial class FormTimer2 : Form
    {
        public FormTimer2()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int counter= Int32.Parse(labelCounter.Text.Replace("秒",""));
            counter+=1;
            labelCounter.Text=counter.ToString()+"秒";

        }
    }
}
