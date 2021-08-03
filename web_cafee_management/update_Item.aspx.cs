using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_cafee_management
{
    public partial class update_Item : System.Web.UI.Page
    {

        Function fn = new Function();
        string query;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
               this.loadData();
              // this.SearchItems();
            }
        }

        protected void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            Response.Redirect("place_order.aspx");
        }

        protected void btnCategory_Click(object sender, EventArgs e)
        {
            Response.Redirect("add_category.aspx");
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
       public void SearchItems()
        {
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    string sql = "SELECT * FROM items" + " WHERE name LIKE +'" + txtSearch.Text + " %'";
                    if (!string.IsNullOrEmpty(txtSearch.Text.Trim()))
                    {
                        sql +=" " ; 
                        cmd.Parameters.AddWithValue("@name", txtSearch.Text.Trim());
                    }
                    cmd.CommandText = sql;
                    cmd.Connection = con;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                    }
                }
            }
        }

     /*   public void searchData()
        {
            query = "SELECT * FROM items WHERE name LIKE '" + txtSearch.Text + " %'";
            ;
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
    
        */
        
        public void loadData()
        {
            query = "select i.id, i.name AS[Item Name], c.Name AS[Category Name], price AS Price from items i, category c  where c.Id = i.category";
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



        private void SearchCustomers()
        {
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {

                    //select i.id, i.name AS[Item Name], c.Name AS[Category Name], price AS Price from items i, category c  where c.Id = i.category
                    string sql = "select i.id, i.name AS [Item Name], c.Name AS[Category Name], price AS Price from items i, category c  where c.Id = i.category";
                    if (!string.IsNullOrEmpty(txtSearch.Text.Trim()))
                    {
                        sql += " AND @Name + '%'";
                        cmd.Parameters.AddWithValue("@Name", txtSearch.Text.Trim());
                    }
                    cmd.CommandText = sql;
                    cmd.Connection = con;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                    }
                }
            }
        }
            // int categoryId;

            int id;
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow grd = GridView1.SelectedRow;

            txtName.Text = grd.Cells[2].Text;
            txtCategory.Text = txtCategory.Text = grd.Cells[3].Text;
            txtPrice.Text = grd.Cells[4].Text;


          
            //query = "SELECT * from category where Id = " + categoryId + "";
            //fn.getData(query);
           

        }


        protected void btnUpdateItem_Click(object sender, EventArgs e)
        {
            GridViewRow grd = GridView1.SelectedRow;
            id = int.Parse(txtCategory.Text = grd.Cells[1].Text);
            try
            {
                query = "UPDATE items set name ='" + txtName.Text + "', category='" + txtCategory.Text + "', price=" + txtPrice.Text + " where id =" + id + "";
                fn.setData(query);
                loadData();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
           
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            this.loadData();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
           /* string searchString = txtSearch.Text.ToString();
            if (GridView1.Items.FindByText(searchString) != null)
            {
                Label1.Text = "Item Found: " + searchString;
                GridView1.Items.FindByText(searchString).Selected = true;
            }
            else
            {
                Label1.Text = "Item not Found: " + searchString;
            }*/
        }
    }
}