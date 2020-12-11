using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraktikumWeek13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labelpesan_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonproses_Click(object sender, EventArgs e)
        {
            if (labelpesan.Text == "[EMPTY]")
            {
                labelpesan.Text = textname.Text;
                textname.Text = "";
            }
            else
            {
                if (textname.Text == "DELETE")
                {
                    labelpesan.Text = "[EMPTY]";
                    textname.Text = "";
                }
                if (textname.Text == "HIDE")
                {
                    labelpesan.Visible = false;
                    textname.Text = "";
                }
                if (textname.Text == "SHOWN")
                {
                    labelpesan.Visible = true;
                    textname.Text = "";
                }
                if (textname.Text == "BLUE")
                {
                    labelpesan.ForeColor = Color.Blue;
                    textname.Text = "";
                }
                if (textname.Text == "RED")
                {
                    labelpesan.ForeColor = Color.Red;
                    textname.Text = "";
                }
                if (textname.Text == "GREEN")
                {
                    labelpesan.ForeColor = Color.Green;
                    textname.Text = "";
                }
            }
        }
    }
}
