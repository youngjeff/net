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
    public partial class register : System.Web.UI.Page
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
            string xh = XH.Text;
            string xm = XM.Text;
            string xb = XB.Text;
            string cssj = CSSJ.Text;
            string zy = ZY.Text;
            string zxf = ZXF.Text;
            string jxj = JXJ.Text;
 //           "insert into xs_kc(XH,XM,XB,CSSJ,ZY,ZXF,JXJ) values('001106','1006',98)"
            string sql = "insert into XS(XH,XM,XB,CSSJ,ZY,ZXF,JXJ) values('";
            sql += xh + "','" + xm + "','" + xb + "','" + cssj + "','" + zy + "','" + zxf + "','" + jxj + "')";
            SqlCommand Comm = new SqlCommand(sql, Conn);
            Comm.ExecuteNonQuery();
            Conn.Close();
            Page.RegisterClientScriptBlock("loginno", strno);
        }
    }
}