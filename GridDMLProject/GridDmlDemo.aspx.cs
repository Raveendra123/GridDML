using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace GridDMLProject
{
    public partial class GridDmlDemo : System.Web.UI.Page
    {
        DataLayer obj = new DataLayer();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)

            {

                BindEmployeeDetails();

            }
        }
        protected void BindEmployeeDetails()

        {

            //DataSet ds = new DataSet();
            DataSet ds = obj.Getdata();

            if (ds.Tables[0].Rows.Count > 0)

            {

                gvDetails.DataSource = ds;

                gvDetails.DataBind();

            }
            else
            {
                //ds.Tables[0].Rows.Add(ds.Tables[0].NewRow());
                //gvDetails.DataSource = ds;
                //gvDetails.DataBind();
                //int columncount = gvDetails.Rows[0].Cells.Count;
                //gvDetails.Rows[0].Cells.Clear();
                //gvDetails.Rows[0].Cells.Add(new TableCell());
                //gvDetails.Rows[0].Cells[0].ColumnSpan = columncount;
                gvDetails.Rows[0].Cells[0].Text = "No Records Found";


            }

        }

        protected void gvDetails_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvDetails.EditIndex = e.NewEditIndex;
            BindEmployeeDetails();
        }

        protected void gvDetails_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvDetails.EditIndex = -1;
            BindEmployeeDetails();
        }

        protected void gvDetails_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string username = gvDetails.DataKeys[e.RowIndex].Values["UserName"].ToString();
            int userid = Convert.ToInt32(gvDetails.DataKeys[e.RowIndex].Value.ToString());
            TextBox txtcity = (TextBox)gvDetails.Rows[e.RowIndex].FindControl("TxtCity");
            TextBox txtdesig = (TextBox)gvDetails.Rows[e.RowIndex].FindControl("TxtDesignation");
            int count = obj.Update(userid, txtcity.Text, txtdesig.Text);

            if (count>0)
            {
                Label1.Text = username+" Details  updated successfully";

                gvDetails.EditIndex = -1;
                BindEmployeeDetails();


            }
            else
            {
                Label1.ForeColor = System.Drawing.Color.Red;
                Label1.Text = "Record not updated";

            }
                    
        }

        protected void gvDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int userid = Convert.ToInt32(gvDetails.DataKeys[e.RowIndex].Value.ToString());
            string username = gvDetails.DataKeys[e.RowIndex].Values["UserName"].ToString();
            int count =obj.Delete(userid);
            if (count > 0)
            {
                BindEmployeeDetails();
                Label1.Text = username + "Details are deleted successfully";
                
               
            }

            else
            {

                Label1.Text = username + "Details are not deleted";
            }


            }

        protected void gvDetails_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName=="AddNew")
            {

                TextBox txtusername = (TextBox)gvDetails.FooterRow.FindControl("TxtFooterusername");
                TextBox txtcity = (TextBox)gvDetails.FooterRow.FindControl("TxtFooterCity");
                TextBox txtdesignation = (TextBox)gvDetails.FooterRow.FindControl("TxtFooterDesignation");

                int n = obj.Insert(txtusername.Text, txtcity.Text, txtdesignation.Text);
                if (n == 1)

                {

                    BindEmployeeDetails();

                   // Label1.ForeColor = Color.Green;

                    Label1.Text = txtusername.Text + " Details inserted successfully";

                }

                else

                {

                    //lblresult.ForeColor = Color.Red;

                    Label1.Text = txtusername.Text + " Details not inserted";

                }
            }
        }
    }
    
}