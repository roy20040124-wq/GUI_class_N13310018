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
    public partial class FormOderMenu : Form
    {
        public FormOderMenu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnsendoder_Click(object sender, EventArgs e)
        {
            
            foreach (Control c in panel12.Controls)
            {
                if(c is CheckBox) 
                {
                    CheckBox temp = (CheckBox)c;
                    if (temp.Checked ==true )
                    {
                        MessageBox.Show(temp.Text);
                    }
                
                
                
                }

            }

        }
    }
}
