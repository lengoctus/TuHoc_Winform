using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Click(object sender, EventArgs e) => BackColor = Color.FromArgb(192, 255, 255);

        private void Button2_Click(object sender, EventArgs e)
        {
            BackColor = Color.Yellow;
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("ahihihi");
        }
    }
}
