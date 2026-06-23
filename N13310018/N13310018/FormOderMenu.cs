using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.LinkLabel;

namespace N13310018
{
    public partial class FormOderMenu : Form
    {
        public FormOderMenu()
        {
            InitializeComponent();
            if (!File.Exists("OrderData.csv"))
                File.WriteAllText("OrderData.csv", "時間,主食,配菜,飲品,甜點\n",Encoding.UTF8);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnsendoder_Click(object sender, EventArgs e)
        {
            DateTime currentDataTime = DateTime.Now;
            string formattedDateTime = currentDataTime.ToString("yyyy/MM/dd HH:mm:ss");

            string food = "", sidFood = "", drink = "", dessert = "";

            foreach (Control c in panel2.Controls)
            {
                if(c is CheckBox) 
                {
                    CheckBox temp = (CheckBox)c;
                    if (temp.Checked ==true )
                    {
                        //MessageBox.Show(temp.Text);
                        food+=" "+temp.Text;
                    }
                
                
                
                }

            }

            foreach (Control c in panel1.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox temp = (CheckBox)c;
                    if (temp.Checked ==true)
                    {
                        //MessageBox.Show(temp.Text);
                        sidFood+=" "+temp.Text;
                    }



                }

            }
            foreach (Control c in panel3.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox temp = (CheckBox)c;
                    if (temp.Checked ==true)
                    {
                        //MessageBox.Show(temp.Text);
                        drink+=" "+temp.Text;
                    }



                }

            }
            foreach (Control c in panel4.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox temp = (CheckBox)c;
                    if (temp.Checked ==true)
                    {
                        //MessageBox.Show(temp.Text);
                        dessert+=" "+temp.Text;
                    }



                }
            }
            File.AppendAllText("OrderData.csv", formattedDateTime+","+food+","+sidFood+","+drink+","+dessert+"\n");
            MessageBox.Show("點餐完成!製作中請燒等!");


        }
      
        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    
}
