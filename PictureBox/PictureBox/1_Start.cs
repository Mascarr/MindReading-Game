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
    public partial class _1_Start : Form
    {
        public _1_Start()
        {
            InitializeComponent();
        }

        private void _1_Start_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new _1_Second().ShowDialog();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new _2_Start().ShowDialog();
        }
    }
}
