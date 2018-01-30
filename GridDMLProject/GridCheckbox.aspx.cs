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
    public partial class GridCheckbox : System.Web.UI.Page
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            CheckBox CC;
            string s = "";

            for (byte i = 0; i < gvDetails.Rows.Count; i++)
            {

                CC = (CheckBox)gvDetails.Rows[i].FindControl("C1");
                if (CC.Checked)
                {
                    s = s + gvDetails.Rows[i].Cells[1].Text + ":" + gvDetails.Rows[i].Cells[2].Text + ":" + gvDetails.Rows[i].Cells[3].Text+"<br>";


                }
            }
            Label1.ForeColor = System.Drawing.Color.Green;
            Label1.Text = "selected Products :<br>"+s;
            //Response.Write(s);
        }


    }
}