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
    public partial class place_order : System.Web.UI.Page
    {
        Function fn = new Function();
        string query;

        DataTable dt = new DataTable();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadDropList();
                if (ViewState["Records"] == null)
                {


                    dt.Columns.Add("Name");
                    dt.Columns.Add("Price");
                    dt.Columns.Add("Quantity");
                    dt.Columns.Add("Total");
                    ViewState["Records"] = dt;
                } 
                }

        }
        public void loadDropList()
        {
            string query = "select * from Category";
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-6V7655K9\\SQLEXPRESS;Initial Catalog=cafe;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();

            try
            {
                da.Fill(ds);
                DropDownList1.DataSource = ds;

                DropDownList1.DataValueField = "Id";
                DropDownList1.DataTextField = "Name";
                DropDownList1.DataBind();

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
            Response.Redirect("remove_items.aspx");
        }

        protected void txtCategor_TextChanged(object sender, EventArgs e)
        {
           
        }

        protected void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select i.name As name, i.id AS id from items i, category c WHERE i.category = c.Id  AND i.name LIKE '" + txtSearch.Text + "%'";
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-6V7655K9\\SQLEXPRESS;Initial Catalog=cafe;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            Label1.Text = DropDownList1.Text;
            try
            {
                da.Fill(ds);
                lstItems.DataSource = ds;
                lstItems.DataTextField = "name";
                lstItems.DataBind();
                Label1.Text = "Displayed";
            }
            catch (Exception ex)
            {
                Label1.Text = "Here:" + ex.ToString();
            }


        }

        [Obsolete]
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select i.name As name, i.id AS id from items i, category c WHERE i.category = c.Id  AND category =" + DropDownList1.Text + "";
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-6V7655K9\\SQLEXPRESS;Initial Catalog=cafe;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            Label1.Text = DropDownList1.Text;
            try
            {
                da.Fill(ds);
                lstItems.DataSource = ds;
                lstItems.DataTextField = "name";
                lstItems.DataBind();
                Label1.Text = "Displayed";
            }
            catch (Exception ex)
            {

                RegisterStartupScript("DisplayError", "<script language=javascript>alert('ERROR');" + ex.ToString() + "</script>");

            }
        }
        int calTotal = 0;
        protected void lstItems_SelectedIndexChanged(object sender, EventArgs e)
        {
           // txtQuantity.Text=string.Empty;
           //

            var a = lstItems.SelectedValue.ToString();
            var b = lstItems.SelectedIndex;

            //lstItems.Items.Add(a);
            txtItemName.Text = a;
            try
            {
                query = "select price, category from items where name='" + txtItemName.Text + "'";
                DataSet ds = fn.getData(query);
                txtItemprice.Text = ds.Tables[0].Rows[0][0].ToString();
                lblHold.Text = ds.Tables[0].Rows[0][1].ToString();

                string query1 = "select Name from category where Id ='" + lblHold.Text + "'";
                DataSet dst = fn.getData(query1);
                txtCategor.Text = dst.Tables[0].Rows[0][0].ToString();

                lblHold.Text = string.Empty;
                txtTotal.Text = Convert.ToString( (Convert.ToInt32(txtItemprice.Text) * Convert.ToInt32(txtQuantity.Text)));
                txtTotal.Enabled = false;

                dt = (DataTable)ViewState["Records"];
                dt.Rows.Add(txtItemName.Text, txtItemprice.Text, txtQuantity.Text, txtTotal.Text);

                GridView1.DataSource = dt;
                GridView1.DataBind();

             
                total = int.Parse(txtTotal.Text);
                calTotal =calTotal + total;
                lblTotal.Text = "R " + total;

                txtCategor.Text = string.Empty;
                txtItemName.Text = string.Empty;
                txtItemprice.Text = string.Empty;
                txtTotal.Text = string.Empty;
                txtQuantity.Text = string.Empty;
            }
            catch (Exception ex)
            {
                Response.Write(@"<script language='javascript'>alert('The following errors have occurred: \n" + ex.ToString() + " .');</script>");
            }
        }

       
        protected int n, total = 0;

        int id;
        protected void btnRemoveItem_Click(object sender, EventArgs e)
        {
            GridViewRow grd = GridView1.SelectedRow;
            id = int.Parse(grd.Cells[1].Text);
            try
            {
             
               
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        protected void btnAddToCart_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTotal.Text != "0" && txtTotal.Text != "")
                {
                    dt = (DataTable)ViewState["Records"];
                    dt.Rows.Add(txtItemName.Text, txtItemprice.Text, txtQuantity.Text, txtTotal.Text);

                    GridView1.DataSource = dt;
                    GridView1.DataBind();

                    total = total + int.Parse(txtTotal.Text);
                    lblTotal.Text = "R " + total;
                    Label1.Text = "Sucess";
                }
                else
                {
                    Label1.Text = "Minimum Quantity needs to be 1";
                }
            }catch(Exception ex)
            {
                Label1.Text = ex.ToString();
            }
        }
    }
}