using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;

namespace CW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void bDraw_Click(object sender, EventArgs e)
        {
            try
            {
                float x = float.Parse(tbX.Text);
                float y = float.Parse(tbY.Text);
                float z = float.Parse(tbZ.Text);
                float sideLength = float.Parse(tbSideLength.Text);

                float stepX = float.Parse(tbStep.Text);
                float stepY = float.Parse(tbStepY.Text);
                float minStepXY = sideLength;
                float count = float.Parse(tbCount.Text);

                float width = float.Parse(tbWidth.Text);
                float height = float.Parse(tbHeight.Text);
                float thickness = float.Parse(tbThickness.Text);
                float depth = float.Parse(tbDepth.Text);
                float rad = sideLength;

                bool running = true;

                SolidWorks sw = new SolidWorks();
                sw.DrawPrism(width / 1000, height / 1000, thickness / 1000);

                while (running == true)
                {
                    if (radioButton2.Checked)
                    {
                        rad = sideLength;
                    }
                    else if (radioButton1.Checked)
                    {
                        rad = (float)(sideLength / 1.005);
                    }
                    else if (radioButton3.Checked)
                    {
                        rad = (float)(sideLength * 2);
                    }
                    else
                    {
                        MessageBox.Show("Невозможно нарисовать. Выберите условие");
                        break;
                    }


                    for (int i = 0; i < count; i++)
                    {
                        
                        bool rightUp = x > width / 2 || y > height / 2;
                        bool rightDown = x > width / 2 || y < -height / 2;
                        bool leftDown = x < -width / 2 || y > height / 2;
                        bool leftUp = x < -width / 2 || y < -height / 2;

                        bool pzrightUp = x + sideLength/2 > width  / 2 || y + sideLength / 2 > height / 2;
                        bool pzrightDown = x + sideLength / 2 > width / 2 || y + sideLength / 2 < -height / 2;
                        bool pzleftDown = x + sideLength / 2 < -width / 2 || y + sideLength / 2 > height / 2;
                        bool pzleftUp = x + sideLength / 2 < -width / 2 || y + sideLength / 2 < -height / 2;

                        if (rightUp || rightDown || leftUp || leftDown)
                        {
                            MessageBox.Show("Невозможно нарисовать остальные. Выходят за пределы призмы.\nБыло нарисовано " + i, "WARNING");
                            break;
                        }

                        if(checkBox2.Checked && (pzrightUp || pzrightDown || pzleftUp || pzleftDown))
                        {
                            MessageBox.Show("Невозможно нарисовать остальные.", "WARNING"); 
                            break;
                        }
                        sw.DrawHexagon(x / 1000, y / 1000, z / 1000, sideLength / 1000, rad / 1000);
                        sw.Cut(depth / 1000, i + 2);

                        float prevX = x;
                        float prevY = y;

                        x += stepX;
                        y += stepY;

                        

                        if(checkBox1.Checked && (Math.Sqrt(stepX * stepX + stepY * stepY) < 2 * sideLength * 1.1))
                        {
                            MessageBox.Show("Невозможно нарисовать. Измените шаг на большее число.", "WARNING");
                            break;
                        }
                    }
                    running = false;
                }
            }
            catch
            {
                MessageBox.Show("Invalid value(s).");
            }
        }

        private void lHeight_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
