using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_cafee_management
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ///lblSession.Text = Session["id"].ToString();
        }

        protected void btnGuest_Click(object sender, EventArgs e)
        {
            Response.Redirect("GuestPlaceOrder.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-6V7655K9\\SQLEXPRESS;Initial Catalog=cafe;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from Users where username=@username and password=@password", con);
            cmd.Parameters.AddWithValue("@username", txtEmail.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (dt.Rows.Count > 0)
            {
                Session["id"] = lblSession.Text;
                Response.Redirect("Main_Main.aspx");
                Session.RemoveAll();
            }
            else
            {
                Response.Write("<script>'Youe username or password is incorrect'</script>");

            }
        }
        }
}