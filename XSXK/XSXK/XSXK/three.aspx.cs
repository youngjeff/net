using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XSXK
{
    public partial class selectCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void tianJia_Click(object sender, EventArgs e)
        {
            Response.Redirect("CourseInfo.aspx");
        }

        protected void sele_Click(object sender, EventArgs e)
        {
            Response.Redirect("SelCourse.aspx");
        }

        protected void weiHu_Click(object sender, EventArgs e)
        {
            Response.Redirect("StuSel.aspx");
        }
    }
}