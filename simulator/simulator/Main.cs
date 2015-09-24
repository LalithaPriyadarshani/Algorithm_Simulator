using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace simulator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertionSort Is = new InsertionSort();
            Is.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Selection ms = new Selection();
            ms.Show();
            
        }
    }
}
