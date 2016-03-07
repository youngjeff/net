using System;
using System.Windows.Forms;

namespace WindowsFormsApplication15
{
    partial class Form1
    {
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;

        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private OpenFileDialog openFileDialog1;
        private Panel panel1;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 346);
            this.panel1.TabIndex = 0;
            this.button1.Location = new System.Drawing.Point(62, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "打开";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button2.Location = new System.Drawing.Point(165, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "播放";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button3.Location = new System.Drawing.Point(268, 380);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 38);
            this.button3.TabIndex = 1;
            this.button3.Text = "暂停";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button4.Location = new System.Drawing.Point(371, 380);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 38);
            this.button4.TabIndex = 1;
            this.button4.Text = "停止";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.openFileDialog1.DefaultExt = "avi";
            this.openFileDialog1.Filter = "视频文件";
            this.openFileDialog1.Title = "请选择播放的AVI文件";
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(540, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Visual C#中使用DriectX实现媒体播放";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
        }
        #endregion
    }
}

