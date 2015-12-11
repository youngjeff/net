using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Click(object sender,EventArgs e)
        {
            DialogResult lngMessage = new DialogResult();
            MessageBox.Show("这是一个测试信息！！", "信息窗口");

            lngMessage = MessageBox.Show("这是一个测试信息!!","信息窗口",MessageBoxButtons.AbortRetryIgnore,
                MessageBoxIcon.Hand,MessageBoxDefaultButton.Button3);
            switch (lngMessage)
            {
                case DialogResult.Abort:
                    MessageBox.Show("你已经按下【终止】按钮！！", "结果信息");
                    break;
                case DialogResult.Retry:
                    MessageBox.Show("你已经按下【重试】按钮！！","结果信息");
                    break;
                case DialogResult.Ignore:
                    MessageBox.Show("你已经按下【忽略】按钮！！", "结果信息");
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Text = "按钮T按钮";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            this.Text = "按下箭头按钮";
        }
    }
}
