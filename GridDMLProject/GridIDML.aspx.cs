using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace GridDMLProject
{
    public partial class GridIDML : System.Web.UI.Page
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

                ds.Tables[0].Rows.Add(ds.Tables[0].NewRow());

                gvDetails.DataSource = ds;

                gvDetails.DataBind();

                int columncount = gvDetails.Rows[0].Cells.Count;

                gvDetails.Rows[0].Cells.Clear();

                gvDetails.Rows[0].Cells.Add(new TableCell());

                gvDetails.Rows[0].Cells[0].ColumnSpan = columncount;

                gvDetails.Rows[0].Cells[0].Text = "No Records Found";

            }

        }
        protected void gvDetails_RowEditing(object sender, GridViewEditEventArgs e)

        {

            gvDetails.EditIndex = e.NewEditIndex;

            BindEmployeeDetails();

        }

        protected void gvDetails_RowUpdating(object sender, GridViewUpdateEventArgs e)

        {
            int userid = Convert.ToInt32(gvDetails.DataKeys[e.RowIndex].Value.ToString());
            int count;
            string username = gvDetails.DataKeys[e.RowIndex].Values["UserName"].ToString();

            TextBox txtcity = (TextBox)gvDetails.Rows[e.RowIndex].FindControl("txtcity");

            TextBox txtDesignation = (TextBox)gvDetails.Rows[e.RowIndex].FindControl("txtDesg");
            count =obj.Update(userid,txtcity.Text, txtDesignation.Text);

            if (count > 0)
            {
                lblresult.ForeColor = System.Drawing.Color.Green;
                lblresult.Text = username + " Details Updated successfully";

                gvDetails.EditIndex = -1;

                BindEmployeeDetails();
            }
            else
            {
                lblresult.ForeColor = System.Drawing.Color.Red;
                lblresult.Text = username + " Details Not Updated successfully";
            }
        }
        protected void gvDetails_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)

        {

            gvDetails.EditIndex = -1;

            BindEmployeeDetails();

        }
        protected void gvDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)

        {
            int userid = Convert.ToInt32(gvDetails.DataKeys[e.RowIndex].Value.ToString());
            string username = gvDetails.DataKeys[e.RowIndex].Values["UserName"].ToString();
            int n = obj.Delete(userid);

            if (n>0)
            {
                BindEmployeeDetails();
                lblresult.ForeColor = System.Drawing.Color.Red;
                lblresult.Text = username + " Details Deleted  successfully";

            }
           

        }
        protected void gvDetails_RowCommand(object sender, GridViewCommandEventArgs e)

        {
            if (e.CommandName == "AddNew")
            {
                TextBox username = (TextBox)gvDetails.FooterRow.FindControl("txtftrusrname");
                TextBox City = (TextBox)gvDetails.FooterRow.FindControl("txtftrcity");
                TextBox Designation =(TextBox) gvDetails.FooterRow.FindControl("txtftrDesignation");




                int n = obj.Insert(username.Text, City.Text, Designation.Text);
                if (n == 1)

                {

                    BindEmployeeDetails();

                    lblresult.ForeColor = Color.Green;

                    lblresult.Text = username.Text + " Details inserted successfully";

                }

                else

                {

                    lblresult.ForeColor = Color.Red;

                    lblresult.Text = username.Text + " Details not inserted";

                }

            }
        }

       
    }  }