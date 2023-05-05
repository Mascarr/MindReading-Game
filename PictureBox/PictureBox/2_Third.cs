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
    public partial class _2_Third : Form
    {
        public _2_Third()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new _2_ThirdYesAnswer().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new _2_ThirdNoAnswer().ShowDialog();
        }
    }
}
