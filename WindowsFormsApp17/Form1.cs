using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s = 1;
            int n = int.Parse(textBox1.Text);
            while (n >= 1)
            {
                s *= n;
                n -= 1;
            }
            listBox1.Items.Add("factorial(" + textBox1.Text + ")=" + s.ToString());
            textBox1.Text = "";
            textBox1.Focus();

        }
    }
}
