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
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("register.aspx");
        }

        protected void lnBtn_Click(object sender, EventArgs e)
        {
            //string xh = txtAdmin.Text;
            //string xm = txtPassword.Text;
            //SqlConnection Conn;
            //Conn = new SqlConnection("server=localhost;database=Student;uid=sa;pwd=sqlserverSa");
            //Conn.Open();
            //SqlCommand Comm = new SqlCommand("select XH,XM from XS ", Conn);
            //SqlDataReader dr = Comm.ExecuteReader();
            //GV.DataSource = dr;
            //GV.DataBind();
            //GV.si
            //for(int i = 0;i<GV;)
            if (txtAdmin.Text == "admin" && txtPassword.Text == "admin")
            {
                Response.Redirect("three.aspx");
            }
        }
    }
}