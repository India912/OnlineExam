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
    public partial class studenttestaspx : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            int i = 0;
            String query = "select * from qus where qusno = " + TextBox1.Text + "";
            SqlConnection india = new SqlConnection("Initial catalog='04 India jii'; integrated security=true;server=INDIAJII");
            india.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, india);
            DataSet ds = new DataSet();
            da.Fill(ds);
           
            if ((i >= 0) && (i < ds.Tables[0].Rows.Count))
            {

                Label1.Text = ds.Tables[0].Rows[i][1].ToString();
               //0 RadioButtonList1.EnableViewState = false;
                RadioButtonList1.Items[0].Text = ds.Tables[0].Rows[i][2].ToString();
                RadioButtonList1.Items[1].Text = ds.Tables[0].Rows[i][3].ToString();
                RadioButtonList1.Items[2].Text = ds.Tables[0].Rows[i][4].ToString();
                RadioButtonList1.Items[3].Text = ds.Tables[0].Rows[i][5].ToString();
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {

            TextBox2.Text = RadioButtonList1.Text;
            SqlConnection india = new SqlConnection("Initial catalog='04 India jii'; integrated security=true;server=INDIAJII");
            india.Open();


            SqlCommand cmd1 = new SqlCommand("update qus set st_ans = '" + TextBox2.Text + "' where qusno = " + TextBox1.Text + " ", india);
            //  Label14.Text = cmd.CommandText;
            int i = cmd1.ExecuteNonQuery();
            //   Label14.Text = "Record inserted successfully " + i;
            //  Label10.Text = "Record updated successfully ";
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            SqlConnection india = new SqlConnection("Initial catalog='04 India jii'; integrated security=true;server=INDIAJII");
            india.Open();
            SqlCommand cmd1 = new SqlCommand("select count(*) from qus where ans = st_ans ", india);
            var count1 = cmd1.ExecuteScalar().ToString();
            int i = cmd1.ExecuteNonQuery();
           // TextBox4.Text= count1.ToString();
            SqlCommand cmd2 = new SqlCommand("update student set result = '" + count1 + "' where id = '" + TextBox3.Text + "' ", india);
            //  Label14.Text = cmd.CommandText;
            int j = cmd2.ExecuteNonQuery();
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
           
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("studentresult");
        }
    }
}