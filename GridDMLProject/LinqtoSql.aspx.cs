using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GridDMLProject
{
    public partial class LinqtoSql : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext obj = new DataClasses1DataContext();
            var res = from v in obj.Products orderby v.Price descending select v;

            GridView1.DataSource = res;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext obj = new GridDMLProject.DataClasses1DataContext();
            obj.Addproduct(int.Parse (TextBox1.Text), TextBox2.Text, int.Parse(TextBox3.Text));
            Response.Write("Details are saved");

        }
    }
}