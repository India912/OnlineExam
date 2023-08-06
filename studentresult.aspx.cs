using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Exam
{
    public partial class studentresult : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            SqlConnection india = new SqlConnection("Initial catalog='04 India jii'; integrated security=true;server=INDIAJII");
            india.Open();
            SqlCommand cmd1 = new SqlCommand("select result from student where id = '" + TextBox1.Text + "'", india);
            var count1 = cmd1.ExecuteScalar().ToString();
            int i = cmd1.ExecuteNonQuery();

            SqlCommand cmd2 = new SqlCommand("select count(*) from qus ", india);
            var count2 = cmd2.ExecuteScalar().ToString();
            int j = cmd2.ExecuteNonQuery();

            Label4.Text = count1.ToString();
            Label6.Text = count2.ToString();




            if (count1 == null || count1 == "") Label7.Visible = true;
            else { 
                Label3.Visible = true;
                Label4.Visible = true;
                Label5.Visible = true;
                Label6.Visible = true;

            }
        }
    }
}