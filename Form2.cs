using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = (int.Parse(textBox1.Text) + 1).ToString();  
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            textBox1.Text = (int.Parse(textBox1.Text) * 2).ToString(); 
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "1";  
        }
    }
}
