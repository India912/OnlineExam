using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Reflection.Emit;

namespace Online_Exam
{
    public partial class adminsetexam : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            String query = "select * from qus where qusno = '" + TextBox1.Text + "'";
            SqlConnection india = new SqlConnection("Initial catalog='04 India jii'; integrated security=true;server=INDIAJII");
            india.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, india);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if ((i >= 0) && (i < ds.Tables[0].Rows.Count))
            {
                TextBox1.Text = ds.Tables[0].Rows[i][0].ToString();
                TextBox2.Text = ds.Tables[0].Rows[i][1].ToString();
                TextBox3.Text = ds.Tables[0].Rows[i][2].ToString();
                TextBox4.Text = ds.Tables[0].Rows[i][3].ToString();
                TextBox5.Text = ds.Tables[0].Rows[i][4].ToString();
                TextBox6.Text = ds.Tables[0].Rows[i][5].ToString();
                TextBox7.Text = ds.Tables[0].Rows[i][5].ToString();
                Label9.Text = " * Question View Successfully";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection india = new SqlConnection("Initial catalog='04 India jii'; integrated security=true;server=INDIAJII");
            india.Open();
            SqlCommand cmd = new SqlCommand("insert into qus values(" + TextBox1.Text + ",'" 
                + TextBox2.Text + "','" 
                + TextBox3.Text + "','" 
                + TextBox4.Text + "','"
                + TextBox5.Text + "','"
                + TextBox6.Text + "','"
                + TextBox7.Text + "','"
                + "" + "' )", india);
            int i = cmd.ExecuteNonQuery();

            Label9.Text = " * Question Added Successfully";

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection india = new SqlConnection("Initial catalog='04 India jii'; integrated security=true;server=INDIAJII");
            india.Open();


            SqlCommand cmd1 = new SqlCommand("update qus set qus = '" + TextBox2.Text + "' ," +
                " op1 = '" + TextBox3.Text + "'," +
                " op2 = '" + TextBox4.Text + "'," +
                " op3 = '" + TextBox5.Text + "'," +
                " op4 = '" + TextBox6.Text + "'," +
    
             
                " ans = '" + TextBox7.Text + "' where qusno = " + TextBox1.Text + " ", india);
            //  Label14.Text = cmd.CommandText;
            int i = cmd1.ExecuteNonQuery();
            //   Label14.Text = "Record inserted successfully " + i;
            Label9.Text = "* Question updated successfully ";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            Label9.Text = "* Cleared ";

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }
        protected void Button10_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminaddqus.aspx");
        }
        protected void Button11_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminviewqus.aspx");
        }
        protected void Button12_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminaddstudent.aspx");
        }
        protected void Button13_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminviewstudent.aspx");
        }
    }
}