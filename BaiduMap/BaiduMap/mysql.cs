using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace BaiduMap
{
    class mysql
    {
        public static SqlConnection conn = null;
        public static SqlDataAdapter myDataAdapter = null;
        public static SqlCommand cmd = null;
        public static DataSet myDataSet = null;
        public static DataTable myTable = null;

        public static void showBaiduTable()
        {
            conn = new SqlConnection("server = .;uid = sa;pwd = sa;database = baidu");
            string sqlld = "select * from Baidu";
            //Console.WriteLine("ServerVersion: {0}", conn.ServerVersion);
            //Console.WriteLine("State: {0}", conn.State);
            conn.Open();
            cmd = new SqlCommand(sqlld, conn);
            myDataAdapter = new SqlDataAdapter(cmd);
            myDataSet = new DataSet();
            myDataAdapter.Fill(myDataSet, "Baidu");
            myTable = myDataSet.Tables["Baidu"];
        }
       
    }
}