using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Exam
{
    public partial class adminviewqus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection india = new SqlConnection("Trusted_Connection = Yes; database = '04 India jii'; server = INDIAJII");
            india.Open();
            SqlDataAdapter da = new SqlDataAdapter("select qusno,qus,op1,op2,op3,op4,ans from qus", india);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminaddqus.aspx");
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminaddstudent.aspx");
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminviewstudent.aspx");

        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");

        }
    }
}