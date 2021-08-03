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
    public partial class remove_items : System.Web.UI.Page
    { 
        
       string cs= "Data Source=LAPTOP-6V7655K9\\SQLEXPRESS;Initial Catalog=cafe;Integrated Security=True";

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
             string query = "select * from items";
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
            Response.Redirect("remove_itesm.aspx");
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            this.loadData();
        }


       
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select * from items";
            fn.getData(query);
            
        }

        int id;
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            GridViewRow grd = GridView1.SelectedRow;
            id = int.Parse(grd.Cells[1].Text);
            try
            {
                query = "DELETE items where id =" + id + "";
                fn.setData(query);
                loadData();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }



        /*  protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
          {
              List<int[]> _RowColIndex = new List<int[]>();
            if (GridView1.Rows.Count <= 0) return;
                 foreach (var GetRowColIndex in _RowColIndex)
                 {
                  int id =Convert.ToInt32(  GridView1.Rows[Convert.ToInt32(GetRowColIndex[0])].Cells[Convert.ToInt32(GetRowColIndex[1])].ToString());
                 }

             //  grd = GridView1.SelectedRow;
              // int id2 =Convert.ToInt32( grd.Cells[0].Text);
              = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
              try
              {
                  using (SqlConnection con = new SqlConnection(cs))
                  {
                      con.Open();
                      SqlCommand cmd = new SqlCommand("DELETE items where id='" + id + "'");
                      int t = cmd.ExecuteNonQuery();
                      if (t > 0)
                      {
                          Response.Write("<script>alert('Item Deleted')</script>");
                          GridView1.EditIndex = -1;
                          loadData();
                      }
                  }

              }

              // fn.setData(query);
              //Label1.Text = "Deleted";
              //loadData();
              // Label1.Text = "Item Successfully Deleted";

              catch (Exception ex)
              {
                  Label1.Text = ex.Message;
              }
          }

          */
    }
}