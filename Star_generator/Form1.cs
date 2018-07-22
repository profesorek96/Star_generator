using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

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
            line.Color = Color.Black;
            fill_shape.Color = Color.Silver;

            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
            | BindingFlags.Instance | BindingFlags.NonPublic, null,
            panel1, new object[] { true });

            panel1.Paint += (sender, e) => draw_star(e.Graphics);


    }

        private void Bt_Color_line_Click(object sender, EventArgs e)
        {
            line.ShowDialog();
            Bt_Color_line.BackColor = line.Color;
            panel1.Invalidate();
        }

        private void Bt_Color_fill_Click(object sender, EventArgs e)
        {
            fill_shape.ShowDialog();
            Bt_Color_fill.BackColor = fill_shape.Color;
            panel1.Invalidate();
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_fill.Checked)
            {
                Bt_Color_fill.Enabled = true;
                Bt_Color_fill.BackColor = fill_shape.Color;
            }
            else
            {
                Bt_Color_fill.Enabled = false;
                Bt_Color_fill.BackColor = Color.Silver; ;
            }
            panel1.Invalidate();
        }
        private void draw_star(Graphics graphics)
        {
            graphics.Clear(Color.White);
            int x_0 = panel1.Width / 2;
            int y_0 = panel1.Height / 2;
            int sides = Convert.ToInt32(numericUpDown1.Value)*2;
            float size_line = (float)nUpD_line_size.Value;
            PointF[] shape = new PointF[sides];
            
            float r = (Math.Min(panel1.Height,panel1.Width)-16)/2;
            float r1 = r * tB_Scale.Value/1000;
            for (int i = 0; i < sides; i++)
            {
                if(i%2==0)
                {
                    shape[i] = new PointF(
                    x_0 + r * (float)Math.Cos(i * 360 / sides * Math.PI / 180f),
                    y_0 + r * (float)Math.Sin(i * 360 / sides * Math.PI / 180f));
                }
                else
                {
                    shape[i] = new PointF(
                    x_0 + r1 * (float)Math.Cos(i * 360 / sides * Math.PI / 180f),
                    y_0 + r1 * (float)Math.Sin(i * 360 / sides * Math.PI / 180f));
                }
                
            }
            if(CB_fill.Checked==true)
            {
                graphics.FillPolygon(new SolidBrush(fill_shape.Color), shape);
            }
            graphics.DrawPolygon(new Pen(line.Color,size_line), shape);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void tB_Scale_Scroll(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void nUpD_line_size_ValueChanged(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }
    }
}
