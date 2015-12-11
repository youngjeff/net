using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_MouseDoubleClick(object sender,MouseEventArgs e)
        {
            string strPositionXY = "X= " + e.X + ", Y = " + e.Y;
            MessageBox.Show("鼠标指针在坐标（" + strPositionXY + ")被按了两下" );

        }
        private void Form1_MouseMove(object sender,MouseEventArgs e)
        {
            string strPositionXY = "目前指针坐标: X= " + e.X + ",Y = " + e.Y;
            this.Text = strPositionXY;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
