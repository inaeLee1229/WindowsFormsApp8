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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           
            if(e.KeyCode == Keys.F1&&e.Shift)
            {
                MessageBox.Show("F1+Shift");
            }
            if (e.KeyCode == Keys.F1 && e.Control)
            {
                MessageBox.Show("F1+Ctrl");
            }
            if (e.KeyCode == Keys.F1 && e.Alt)
            {
                MessageBox.Show("F1+Alt");
            }
            if (e.KeyCode == Keys.F1 )
            {
                MessageBox.Show("F1");
            }
        }
    }
}
