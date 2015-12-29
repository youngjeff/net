using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace XSXK
{
    public partial class CourseInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void finBtn_Click(object sender, EventArgs e)
        {
            string strno = "<script>alert('课程已添加！');<" + "/script>";
            SqlConnection Conn;
            Conn = new SqlConnection("server=localhost;database=Student;uid=sa;pwd=sqlserverSa");
            Conn.Open();
            string kch = KCH.Text;
            string kcm = KCM.Text;
            string lb = LB.Text;
            //string cssj = CSSJ.Text;
            string xq = XQ.Text;
            string xs = XS.Text;
            string xf = XF.Text;
            //           "insert into xs_kc(XH,XM,XB,CSSJ,ZY,ZXF,JXJ) values('001106','1006',98)"
            string sql = "insert into KC(KCH,KCM,LB,XQ,XS,XF) values('";
            sql += kch + "','" + kcm + "','" + lb + "','" + xq + "','" + xs + "','" + xf + "')";
            SqlCommand Comm = new SqlCommand(sql, Conn);
            Comm.ExecuteNonQuery();
            Conn.Close();
            Page.RegisterClientScriptBlock("loginno", strno);
        }
    }
}