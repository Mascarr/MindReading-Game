using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBox
{
    public partial class _2_Start : Form
    {
        public _2_Start()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            new _1_Start().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new _2_Second().ShowDialog();
        }
    }
}
