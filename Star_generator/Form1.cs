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
            
            Bt_Color_line.BackColor=Color.Black;
            Bt_Color_fill.BackColor=Color.Silver;
            Bt_Color_fill.Enabled = false;
            line = new ColorDialog();
            fill_shape = new ColorDialog();

        }

        private void Bt_Color_line_Click(object sender, EventArgs e)
        {
            line.ShowDialog();
            Bt_Color_line.BackColor = line.Color;
        }

        private void Bt_Color_fill_Click(object sender, EventArgs e)
        {
            fill_shape.ShowDialog();
            Bt_Color_fill.BackColor = fill_shape.Color;
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_fill.Checked)
            {
                Bt_Color_fill.Enabled = true;
            }
            else
            {
                Bt_Color_fill.Enabled = false;
            }
        }
        private void draw_star()
        {

        }
    }
}
