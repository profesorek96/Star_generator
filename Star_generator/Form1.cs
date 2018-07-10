using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Star_generator
{
    public partial class Form1 : Form
    {
        ColorDialog line;
        ColorDialog fill_shape;
        public Form1()
        {
            InitializeComponent();
            Bt_Color_fill.Enabled = false;
            //Bt_Color_line.BackColor(Color.Black);
            //Bt_Color_fill.BackColor();

        }

        private void Bt_Color_line_Click(object sender, EventArgs e)
        {

        }

        private void Bt_Color_fill_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(CB_fill.Checked)Bt_Color_fill.Enabled = true;
            else Bt_Color_fill.Enabled = false;
        }
    }
}
