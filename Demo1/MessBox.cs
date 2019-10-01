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
    public partial class MessBox : Form
    {
        public MessBox()
        {
            InitializeComponent();
        }

        //MessageBox.Show(message, caption,
        //                         MessageBoxButtons.YesNo,
        //                         MessageBoxIcon.Question);

        private void MessBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you want close ??", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            e.Cancel = (res == DialogResult.Yes) ? false : true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xin chao", "title");
        }
    }
}
