using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApplication11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private DataSet ds = new DataSet();
        private SqlConnection conn = null;
        private SqlDataAdapter da = null;
        private SqlCommand cmd = null;
        private DataSet dts = null;

        private void btnDb_Click(object sender, EventArgs e)
        {
            /*SqlConnection conn = new SqlConnection("server = .;uid = sa;pwd = sa;database = baidu");
            string sqlld = "select * from Baidu";
            conn.Open();
            //MessageBox.Show("数据库连接成功！", "啊");
            Console.WriteLine("ServerVersion: {0}", conn.ServerVersion);
            Console.WriteLine("State: {0}", conn.State);
            SqlCommand cmd = new SqlCommand(sqlld, conn);//表示要对 SQL Server 数据库执行的一个 Transact-SQL 语句或存储过程。 此类不能被继承
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet(); //
            da.Fill(ds, "Baidu");//在 DataSet 中添加或刷新行以匹配使用 DataSet 和 DataTable 名称的数据源中的行
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Baidu";
            dataGridView1.AllowUserToAddRows = true;//不要最后一行空白
            conn.Close();*/

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            dataGridView1.Rows.Add("row");
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             conn = new SqlConnection("server = .;uid = sa;pwd = sa;database = baidu");
            string sqlld = "select * from Baidu";
            //Console.WriteLine("ServerVersion: {0}", conn.ServerVersion);
            //Console.WriteLine("State: {0}", conn.State);
            conn.Open();          
            cmd = new SqlCommand(sqlld, conn);
            da = new SqlDataAdapter(cmd);
            dts = new DataSet();
            da.Fill(ds, "Baidu");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Baidu";
            dataGridView1.AllowUserToAddRows = true;
        }
    }
}
//C# 连接数据库并用datagridView显示数据