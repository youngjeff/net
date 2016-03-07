using System;
using System.Windows.Forms;
using Microsoft.DirectX.AudioVideoPlayback;
namespace WindowsFormsApplication17
{
    public partial class Form1 : Form
    {
        private Video MyVideo = null;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            if (MyVideo == null)
            {
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            //throw new notimplementedexception();
            if (MyVideo != null)
            {
                MyVideo.Stop();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            if (MyVideo != null)
            {
                MyVideo.Pause();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            if (MyVideo != null)
            {
                MyVideo.Play();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            openFileDialog1.InitialDirectory = Application.StartupPath;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //记录panel组件的大小
                int height = panel1.Height;
                int width = panel1.Width;
                //如果存在打开的Video文件，释放它
                if (MyVideo != null)
                {
                    MyVideo.Dispose();
                }
                //打开一个新的Video文件
                MyVideo = new Video(openFileDialog1.FileName);
                //把Video文件分配给创建的panel组件
                MyVideo.Owner = panel1;
                //以记录的panel组件的大小来重新定义
                panel1.Width = width;
                panel1.Height = height;
                //播放avi的第一帧，主要是为了在panel中显示
                MyVideo.Play();
                MyVideo.Pause();
            }
            //确定窗体中各按钮状态
            if (MyVideo == null)
            {
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
            }
        }
    }
}
