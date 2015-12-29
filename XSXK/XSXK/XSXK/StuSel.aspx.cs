using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Collections;
using System.Data.SqlClient;

namespace Student
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection Conn;
            Conn = new SqlConnection("server=localhost;database=Student;uid=sa;pwd=sqlserverSa");
            Conn.Open();
            //Message.Text=Conn.State.ToString();


            //查询操作
            SqlCommand Comm = new SqlCommand("select * from xs_kc ", Conn);
            SqlDataReader dr = Comm.ExecuteReader();
            GVstu.DataSource = dr;
            GVstu.DataBind();
            Conn.Close();
            //插入操作
            //SqlCommand Comm=new SqlCommand("insert into xs_kc(XH,KCH,CJ) values('001106','1006',98)",Conn);
            // Comm.ExecuteNonQuery();   

            //删除操作
           // SqlCommand Comm = new SqlCommand("delete from xs_kc where XH='001106'", Conn);
         //   Comm.ExecuteNonQuery();

            //修改操作
            //SqlCommand Comm=new SqlCommand("update xs_kc set cj=100 where XH='001106'",Conn);
            //Comm.ExecuteNonQuery();   

        }


        protected void StuSel_Click(object sender, EventArgs e)
        {
            SqlConnection Conn;
            Conn = new SqlConnection("server=localhost;database=Student;uid=sa;pwd=sqlserverSa");
            Conn.Open();
            //Message.Text=Conn.State.ToString();
            String xh = txtXH.Text;
            String kch = txtKCH.Text;

            String sel = "select * from xs_kc where XH='"+xh+"'and KCH='"+kch+"'";
            //查询操作
            SqlCommand Comm = new SqlCommand(sel, Conn);
            SqlDataReader dr = Comm.ExecuteReader();
            GVstu.DataSource = dr;
            GVstu.DataBind();
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
            String cj = txtCJ.Text;

            String xg = "update xs_kc set cj="+cj+" where XH='"+xh+"' and KCH='"+kch+"'";
            //xiugai
            SqlCommand Comm = new SqlCommand(xg, Conn);
            Comm.ExecuteNonQuery();   

            Conn.Close();
            //修改操作
            //SqlCommand Comm=new SqlCommand("update xs_kc set cj=100 where XH='001106'",Conn);
            //Comm.ExecuteNonQuery();   
        }

        protected void StuZJ_Click(object sender, EventArgs e)
        {
            SqlConnection Conn;
            Conn = new SqlConnection("server=localhost;database=Student;uid=sa;pwd=sqlserverSa");
            Conn.Open();
            //Message.Text=Conn.State.ToString();
            String xh = txtXH.Text;
            String kch = txtKCH.Text;
            String cj = txtCJ.Text;
            String sel = "insert into xs_kc(XH,KCH,CJ) values('"+xh+"','"+kch+"',"+cj+")";
            //ZJ操作
            SqlCommand Comm = new SqlCommand(sel, Conn);
            Comm.ExecuteNonQuery();

            Conn.Close();
            //插入操作
            //SqlCommand Comm=new SqlCommand("insert into xs_kc(XH,KCH,CJ) values('001106','1006',98)",Conn);
            // Comm.ExecuteNonQuery();   

        }

        protected void StuSC_Click(object sender, EventArgs e)
        {
            SqlConnection Conn;
            Conn = new SqlConnection("server=localhost;database=Student;uid=sa;pwd=sqlserverSa");
            Conn.Open();
            //Message.Text=Conn.State.ToString();
            String xh = txtXH.Text;
            String kch = txtKCH.Text;
            String cj = txtCJ.Text;
            String sel = "delete from xs_kc where XH='"+xh+"'";
            //SC操作
            SqlCommand Comm = new SqlCommand(sel, Conn);
            Comm.ExecuteNonQuery();

            Conn.Close();
            //删除操作
            // SqlCommand Comm = new SqlCommand("delete from xs_kc where XH='001106'", Conn);
            //   Comm.ExecuteNonQuery();
        }

        protected void StuGX_Click(object sender, EventArgs e)
        {

            SqlConnection Conn;
            Conn = new SqlConnection("server=localhost;database=Student;uid=sa;pwd=sqlserverSa");
            Conn.Open();
            //Message.Text=Conn.State.ToString();


            //GX操作
            SqlCommand Comm = new SqlCommand("select * from xs_kc ", Conn);
            SqlDataReader dr = Comm.ExecuteReader();
            GVstu.DataSource = dr;
            GVstu.DataBind();
            Conn.Close();
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            SqlConnection Conn;
            Conn = new SqlConnection("server=localhost;database=Student;uid=sa;pwd=sqlserverSa");
            Conn.Open();
            //Message.Text=Conn.State.ToString();

            String xh = txtXH.Text;
            //查询操作
            SqlCommand Comm = new SqlCommand("select * from xs_kc where xh='"+xh+"'", Conn);
            SqlDataReader dr = Comm.ExecuteReader();
            GVstu.DataSource = dr;
            GVstu.DataBind();
            Conn.Close();

        }


    }
}