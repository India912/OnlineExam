using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Exam
{
    public partial class login : System.Web.UI.Page
    {
        String id = "852852";
        String username = "India Jii";
        String password = "Bharat";
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (RadioButton1.Checked) RadioButton2.Checked = false;
            else RadioButton1.Checked = false;

            if (RadioButton1.Checked)
            {
                if (TextBox1.Text == id && TextBox2.Text == username && TextBox3.Text == password)
                {
                    Response.Redirect("adminaddstudent.aspx");
                }
                else
                {
                    Label5.Visible = true;
                }
            }
            else if (RadioButton2.Checked)
            {
                SqlConnection india = new SqlConnection("Initial catalog='04 India jii'; integrated security=true;server=INDIAJII");
                india.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(1) FROM student WHERE id ='" + TextBox1.Text + "'And uname='" + TextBox2.Text + "'And password='" + TextBox3.Text + "'", india);
                int count;
                count = Convert.ToInt32(cmd.ExecuteScalar());
                Response.Write(count);
                if (count == 1)
                {
                    Response.Redirect("studentprofile.aspx");
                }
                else
                    Label5.Visible = true;
            }

        }
    }
}