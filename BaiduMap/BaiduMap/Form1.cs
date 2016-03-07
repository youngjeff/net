using System;
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
using System.Data.SqlClient;
namespace BaiduMap
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
            //webBrowser1.Document.InvokeScript("drawPoint", new object[] { "116.406605", "39.912345" });
            //webBrowser1.Document.InvokeScript("drawPoint", new object[] { "116.406605", "39.921988" });
            foreach (DataRow myRow in mysql.myTable.Rows)
            {
                webBrowser1.Document.InvokeScript("drawPoint", new object[] {myRow["Lng"],myRow["Lat"] });
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //webBrowser1.Document.InvokeScript("setLocation", new object[] { 121.504, 39.212 });
            try
            {
                webBrowser1.Url = new Uri(Path.Combine(Application.StartupPath, "demo.html"));
                webBrowser1.ObjectForScripting = this; //具体公开的对象   js代码访问的对象是this
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
            mysql.showBaiduTable();
            //dataGridView1.DataSource = mysql.myDataSet;
            //dataGridView1.DataMember = "Baidu";
            //dataGridView1.AllowUserToAddRows = false;


            foreach (DataRow myRow in mysql.myTable.Rows)
            {
                comboBox1.Items.Add(myRow["Position"]);
            }
        }
        public void richBoxShow(string pointLng,string pointLat)
        {
            DataRow[] pointRow = mysql.myTable.Select(string.Format(@"Lng = {0} and Lat = {1}", pointLng, pointLat));
            string showMsg = null;
            foreach (DataRow myPoint in pointRow)
            {
                showMsg = "地点:" + myPoint["Position"] + "\n" + "电话:" + myPoint["Phone"] + "\n" + "pm2.5: " + myPoint["PM"];

                richTextBox1.Text = showMsg;
                Console.Write(showMsg);
            }
          

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //string selectCity = comboBox1.SelectedItem.ToString();
            int selectCity = comboBox1.SelectedIndex + 1 ;
            DataRow[] pointRow = mysql.myTable.Select(string.Format(@"index = {0}", selectCity));
            string showMsg = null;
            foreach (DataRow myPoint in pointRow)
            {

                webBrowser1.Document.InvokeScript("drawPoint", new object[] { myPoint["Lng"], myPoint["Lat"] });

                showMsg = "地点:" + myPoint["Position"] + "\n" + "电话:" + myPoint["Phone"] + "\n" + "pm2.5: " + myPoint["PM"];

                richTextBox1.Text = showMsg;
                Console.Write(showMsg);
            }
        }
    }
}
