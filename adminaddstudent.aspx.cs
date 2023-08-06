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
    public partial class adminaddstudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminaddqus.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminviewqus.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminviewstudent.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            int i = 0;
            String query = "select * from student where id = '" + TextBox1.Text + "'";
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
                TextBox7.Text = ds.Tables[0].Rows[i][6].ToString();
                TextBox8.Text = ds.Tables[0].Rows[i][7].ToString();
                TextBox9.Text = ds.Tables[0].Rows[i][8].ToString();
                TextBox10.Text = ds.Tables[0].Rows[i][9].ToString();
                TextBox11.Text = ds.Tables[0].Rows[i][10].ToString();
                TextBox12.Text = ds.Tables[0].Rows[i][11].ToString();


            }
            Label13.Text = "View Record Successfully";
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            SqlConnection india = new SqlConnection("Initial catalog='04 India jii'; integrated security=true;server=INDIAJII");
            india.Open();


            SqlCommand cmd1 = new SqlCommand("update student set password = '" + TextBox3.Text + "' ," +
                " fname = '" + TextBox4.Text + "'," +
                " lname = '" + TextBox5.Text + "'," +
                " fathername = '" + TextBox6.Text + "'," +
                " class = '" + TextBox7.Text + "'," +
                " age = '" + TextBox8.Text + "'," +
                " DOB = '" + TextBox9.Text + "'," +
                " address = '" + TextBox10.Text + "'," +
                " phone = '" + TextBox11.Text + "'," +
                " email = '" + TextBox12.Text + "' where id = '" + TextBox1.Text + "' ", india);
            //  Label14.Text = cmd.CommandText;
            int i = cmd1.ExecuteNonQuery();
            //   Label14.Text = "Record inserted successfully " + i;
            Label13.Text = "Record updated successfully ";
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            SqlConnection india = new SqlConnection("Initial catalog='04 India jii'; integrated security=true;server=INDIAJII");
            india.Open();
            SqlCommand cmd = new SqlCommand("insert into student values('" + TextBox1.Text + "','" + TextBox2.Text
                + "','" + TextBox3.Text + "','" + TextBox4.Text + "', '" + TextBox5.Text + "', '" + TextBox6.Text
                + "','" + TextBox7.Text + "','" + TextBox8.Text + "', '" + TextBox9.Text + "', '" + TextBox10.Text
                + "','" + TextBox11.Text + "','" + TextBox12.Text + "','" + "" + "' )", india);
            //  Label14.Text = cmd.CommandText;
            int i = cmd.ExecuteNonQuery();
            //   Label14.Text = "Record inserted successfully " + i;
            Label13.Text = "Record inserted successfully ";
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";
            TextBox10.Text = "";
            TextBox11.Text = "";
            TextBox12.Text = "";

        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }
    }
}