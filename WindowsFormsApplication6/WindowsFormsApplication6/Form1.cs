using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void DrawsLine_Paint(object sender,PaintEventArgs e)
        {
            Graphics graLine = e.Graphics;
            Pen myPen = new Pen(Color.Red);
            graLine.DrawLine(myPen, 50, 50, 250, 250);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics myGraphics = this.CreateGraphics();
            myGraphics.DrawLine(new Pen(Color.Red), 250, 50, 500, 250);
            myGraphics.DrawLine(new Pen(Color.Red), 250, 250, 500, 50);
        }
    }
}
