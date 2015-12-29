using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Security.Permissions;
namespace WindowsFormsApplication10
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [ComVisible(true)]
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.InvokeScript("Run", new object[] { "CShareFuncition" });
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.ObjectForScripting = this; //具体公开的对象   js代码访问的对象是this
            webBrowser1.Navigate(Application.StartupPath + "/dom.html");//加载html资源


        }
        public void ShowMsg(string msg)//js代码调用函数
        {
            MessageBox.Show(msg);
        }
    }
}
