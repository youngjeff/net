using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.Name = "Testion";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "测试窗体";
            this.ResumeLayout(false);
        }

       

        private void button1_Click(object sender, EventArgs e)
        {

        }

         private void Form1_KeyDown(object sender, KeyEventArgs e)
         {
             string strModifiers = "";
             string strText = e.KeyCode + ":" + e.Modifiers + ":" + e.KeyData +
                 ":" + "(" + e.KeyValue + ")";
             if (e.Shift == true) strModifiers = "shift 键被按下";
             if (e.Control == true) strModifiers = "Ctrl 键被按下";
             if (e.Alt == true) strModifiers = "Alt 键被按下";
             this.Text = strText + strModifiers;
         }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
