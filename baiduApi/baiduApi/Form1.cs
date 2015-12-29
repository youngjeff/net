﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Permissions;//
using System.Runtime.InteropServices;
namespace baiduApi
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [ComVisible(true)]
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser1.Document.InvokeScript("setLocation", new object[] { 121.504, 39.212 });
        }

        private void Form1_Load(object sender, EventArgs e)//当form显示的时候，执行我们的操作
        {
            try
            {
                webBrowser1.Url = new Uri(Path.Combine(Application.StartupPath, "test.html"));
                webBrowser1.ObjectForScripting = this; //具体公开的对象   js代码访问的对象是this
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGetLocation_Click(object sender, EventArgs e)
        {
            if(btnGetLocation.Text == "开启实时坐标")
            {
                timer1.Enabled = true;
                btnGetLocation.Text = "关闭实时坐标";
            }
            else
            {
                btnGetLocation.Text = "开启实时坐标";
                timer1.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                string taglng = webBrowser1.Document.GetElementById("mouselng").InnerText;
                string taglat = webBrowser1.Document.GetElementById("mouselat").InnerText;
                double doulng, doulat;
                if(double.TryParse(taglng, out doulng) && double.TryParse(taglat,out doulat))
                {
                    //statusStrip1.Text = "当前坐标： " + doulng.ToString("F5") + " " + doulat.ToString("F5");
                    latLabel.Text = doulng.ToString();
                    lngLabel.Text = doulat.ToString();
                    
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void btnOpenDistance_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.InvokeScript("openGetDistance");
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.InvokeScript("drawPointAndLine");
        }

        private void btnResult_Click(object sender, EventArgs e)//获取点数
        {
            webBrowser1.Document.InvokeScript("getDrawPoint");
            string pointNumber = webBrowser1.Document.GetElementById("overlaycomplete").InnerText;
            resultLabel.Text = pointNumber;
        }

        private void btnClear_Click(object sender, EventArgs e)//清除点
        {
            webBrowser1.Document.InvokeScript("clearAll");
            resultLabel.Text = " ";
        }

        private void btnNoDraw_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.InvokeScript("drawNoPointAndLine");
        }

        private void btnGetPosition_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.InvokeScript("getMyPositon");
            

        }

        private void btnGetBrower_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.InvokeScript("getMyPositonIP");
            string mylng = webBrowser1.Document.GetElementById("mylng").InnerText;
            string mylat = webBrowser1.Document.GetElementById("mylat").InnerText;
            mylngLabel.Text = mylng;
            mylatLabel.Text = mylat;
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.InvokeScript("setSomePostion");
            
        }
        public void showInfomation()
        {
            richTextBox1.Text = webBrowser1.Document.GetElementById("information").InnerText;
            //richTextBox1.Text = "asdasdasd";
        }
    }
}