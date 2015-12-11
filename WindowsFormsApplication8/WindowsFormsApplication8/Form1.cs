using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Color myColor = this.BackColor;
            Point[] pt = new Point[6];
            pt[0] = new Point(50, 30);
            pt[1] = new Point(100, 100);
            pt[2] = new Point(150, 30);
            pt[3] = new Point(200, 100);
            pt[4] = new Point(250, 30);
            pt[5] = new Point(300, 100);

            Pen myPenr = new Pen(Color.Red);
            Pen myPenb = new Pen(Color.Yellow, 5);
            Pen myPend = new Pen(Color.Black, 5);

            Graphics myGraphics = this.CreateGraphics();
            myGraphics.Clear(myColor);

            float f = float.Parse(textBox1.Text);
            myGraphics.DrawCurve(myPenb, pt, f);

            for(float i = -1 * f;i <= f;i++)
            {
                myGraphics.DrawCurve(myPenr, pt, i);
            }
            myGraphics.DrawRectangle(myPend, 50, 30, 2, 2);
            myGraphics.DrawRectangle(myPend, 100, 100, 2,2);
            myGraphics.DrawRectangle(myPend, 150, 30, 2, 2);
            myGraphics.DrawRectangle(myPend, 200, 100, 2, 2);
            myGraphics.DrawRectangle(myPend, 250, 30, 2, 2);
            myGraphics.DrawRectangle(myPend, 300, 100, 2, 2);
        }

    }
}
