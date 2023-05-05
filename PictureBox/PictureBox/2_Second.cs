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
    public partial class _2_Second : Form
    {
        public _2_Second()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new _2_SecondAnswer().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new _2_Third().ShowDialog();
        }
    }
}
