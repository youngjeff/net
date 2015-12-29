using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Student
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection Conn;
            Conn = new SqlConnection("server=localhost;database=Student;uid=sa;pwd=sqlserverSa");
            Conn.Open();
            //Message.Text=Conn.State.ToString();


            //查询操作
            SqlCommand Comm = new SqlCommand("select * from kc ", Conn);
            SqlDataReader dr = Comm.ExecuteReader();
            GVcourse.DataSource = dr;
            GVcourse.DataBind();
            Conn.Close();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection Conn;
            Conn = new SqlConnection("server=localhost;database=Student;uid=sa;pwd=sqlserverSa");
            Conn.Open();
            //Message.Text=Conn.State.ToString();
            String xh = txtXH.Text;
            String kch = txtKCH.Text;
          
            String sel = "insert into xs_kc(XH,KCH) values('" + xh + "','" + kch + "')";
            //ZJ操作
            SqlCommand Comm = new SqlCommand(sel, Conn);
            Comm.ExecuteNonQuery();

            Conn.Close();
        }

        protected void StuTX_Click(object sender, EventArgs e)
        {
            SqlConnection Conn;
            Conn = new SqlConnection("server=localhost;database=Student;uid=sa;pwd=sqlserverSa");
            Conn.Open();
            //Message.Text=Conn.State.ToString();
            String xh = txtXH.Text;
            String kch = txtKCH.Text;
            
            String sel = "delete from xs_kc where XH='" + xh + "' and KCH='"+kch+"'";
            //tx操作
            SqlCommand Comm = new SqlCommand(sel, Conn);
            Comm.ExecuteNonQuery();

            Conn.Close();
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            SqlConnection Conn;
            Conn = new SqlConnection("server=localhost;database=Student;uid=sa;pwd=sqlserverSa");
            Conn.Open();
            //Message.Text=Conn.State.ToString();


            //查询操作
            SqlCommand Comm = new SqlCommand("select xh,kch from xs_kc", Conn);
            SqlDataReader dr = Comm.ExecuteReader();
            GVcourse.DataSource = dr;
            GVcourse.DataBind();
            Conn.Close();
        }

    }
}