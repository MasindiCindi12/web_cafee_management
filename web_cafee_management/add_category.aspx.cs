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
    public partial class add_category : System.Web.UI.Page
    {
        Function fn = new Function();
        string query;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadData();
            }
        }
        public void loadData()
        {
            string query = "select Name from Category";
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-6V7655K9\\SQLEXPRESS;Initial Catalog=cafe;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();

            try
            {
                da.Fill(ds);
                GridView1.DataSource = ds;
                GridView1.DataBind();

            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }
            finally
            {
                da.Dispose();
                da.Dispose();
                con.Dispose();
            }
        }
        protected void btnCategory_Click(object sender, EventArgs e)
        {
            Response.Redirect("add_category.aspx");
        }

        protected void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            Response.Redirect("place_order.aspx");
        }

        protected void btnAddItems_Click(object sender, EventArgs e)
        {
            Response.Redirect("add_items.aspx");
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Response.Redirect("update_item.aspx");
        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {
            Response.Redirect("remove_items.aspx");
        }

        protected void btnCat_Click(object sender, EventArgs e)
        {
            try
            {
                query = "INSERT INTO Category(Name) VALUES('" + txtCategory.Text + "')";
                fn.setData(query);
                loadData();
                txtCategory.Text = "";
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
    }
}