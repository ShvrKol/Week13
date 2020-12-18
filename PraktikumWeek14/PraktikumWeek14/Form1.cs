using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraktikumWeek14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonrev_Click(object sender, EventArgs e)
        {
            if (textBoxinput.Text == "") MessageBox.Show("Isi text box terlebih dahulu!");
            else
            {
                string label, reverse;
                reverse = "";
                label = textBoxinput.Text;
                for (int i = label.Length - 1; i > -1; i--)
                {
                    reverse = reverse + label[i];
                }
                labelout.Text = reverse;
                textBoxinput.Text = "";
            }       
        }

        private void buttonurut_Click(object sender, EventArgs e)
        {
            if (textBoxinput.Text == "") MessageBox.Show("Isi text box terlebih dahulu!");
            else
            {
                char tex;
                string str = textBoxinput.Text;
                char[] index = str.ToCharArray();
                for (int i = 1; i < index.Length; i++)
                {
                    for (int j = 0; j < index.Length - 1; j++)
                    {
                        if (index[j] > index[j + 1])
                        {
                            tex = index[j];
                            index[j] = index[j + 1];
                            index[j + 1] = tex;
                        }
                    }
                }
                string text = new string(index);
                labelout.Text = text;
                textBoxinput.Text = "";
            }         
        }
    }
}
