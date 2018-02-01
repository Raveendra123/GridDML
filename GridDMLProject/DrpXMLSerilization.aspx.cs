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
    public partial class DrpXMLSerilization : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source = MININT-8DSL3GL; Initial Catalog = Details; Integrated Security = True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack ==false)
            {

                SqlDataAdapter da = new SqlDataAdapter("select * from Dept", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "Dept");
                DropDownList1.DataSource = ds.Tables["Dept"];
                DropDownList1.DataTextField = "deptno";
                DropDownList1.DataValueField = "deptno";
                DropDownList1.DataBind();
                da.SelectCommand.CommandText = "select * from employee";
                DataSet ds1 = new DataSet();
                da.Fill(ds1, "Employee");
                ds1.Tables["Employee"].WriteXml(Server.MapPath(".") + "\\emp.xml", XmlWriteMode.WriteSchema);




            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataView dv = new DataView();
            ds.ReadXml(Server.MapPath(".") + "\\emp.xml", XmlReadMode.ReadSchema);
            //dv.Table(ds.Tables["emp"]);
            DataView dView = ds.Tables["Employee"].DefaultView;
            // dv = ds.Tables["emp"].DefaultView;
            dView.RowFilter ="deptno="+ DropDownList1.SelectedValue.ToString();
            GridView1.DataSource = dView;
            GridView1.DataBind();




        }
    }
}