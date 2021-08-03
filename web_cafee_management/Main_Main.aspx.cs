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
    public partial class Main_Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadData();
            }
        }
        public void loadData()
        {
            string query = "select i.name AS[Item Name], c.Name AS[Category Name], price AS Price from items i, category c  where c.Id = i.category";
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


        protected void btnRemove_Click(object sender, EventArgs e)
        {
            Response.Redirect("remove_items.aspx");
        }

        protected void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            Response.Redirect("place_order.aspx");
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Response.Redirect("update_item.aspx");
        }

        protected void btnAddItems_Click(object sender, EventArgs e)
        {
            Response.Redirect("add_items.aspx");
        }

        protected void btnCategory_Click(object sender, EventArgs e)
        {
            Response.Redirect("add_category.aspx");
        }

        protected void GridView1_PageIndexChanged(object sender, EventArgs e)
        {
           
        }

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
        
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            this.loadData();
        }
    }
}