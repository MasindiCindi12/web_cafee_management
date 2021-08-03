
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_cafee_management
{
    public partial class GuestPlaceOrder : System.Web.UI.Page
    {
        Function fn = new Function();

        string query;
        protected void Page_Load(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            btnAddItems.Enabled = false;
            btnRemove.Enabled = false;
            btnCategory.Enabled = false;

            if (!IsPostBack)
            {
                loadDropList();
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

       
        protected void btnPrint_Click(object sender, EventArgs e)
        {
       
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lstItems.Items.Clear();
                string category = DropDownList1.Text;
                query = "select name from items where category='" + DropDownList1.Text + "'";
                DataSet ds = fn.getData(query);

                int i;
                for (i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    lstItems.Items.Add(ds.Tables[0].Rows[i][0].ToString());

                }

            }
            catch (Exception ex)
            {
               Label1.Text=(ex.ToString());
            }
        }
    }
}