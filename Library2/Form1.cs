using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           Main main = new Main();
            if (textBox1.Text == Properties.Settings.Default.Pass)
            {
                main.Show();
                this.Hide();
            }
            else
            {
                textBox1.Text = " ";
            }

        }
    }
}
