using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Paint(object sender,PaintEventArgs e)
        {
            Pen myPen = new Pen(Color.Blue);
            Graphics myGraphics = e.Graphics;
            myGraphics.DrawRectangle(myPen, 10, 10, 200, 100);

            Point[] myP = new Point[6];

            myP[0].X = 20;myP[0].Y = 200;
            myP[1].X = 80; myP[1].Y = 250;
            myP[2].X = 140; myP[2].Y = 250;
            myP[3].X = 200; myP[3].Y = 200;
            myP[4].X = 140; myP[4].Y = 130;
            myP[5].X = 80; myP[5].Y = 130;

            Rectangle myRectangle = new Rectangle(250, 10, 150, 100);
            myGraphics.DrawRectangle(myPen, myRectangle);

            myGraphics.DrawPolygon(myPen, myP);
        }
    }
}
