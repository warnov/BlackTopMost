using System;
using System.Windows.Forms;

namespace BlackTopMost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle == FormBorderStyle.SizableToolWindow ?
                FormBorderStyle.None :
                FormBorderStyle.SizableToolWindow;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TopMost = !TopMost;
        }
    }
}
