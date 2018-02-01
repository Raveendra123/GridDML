using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GridDMLProject
{
    public partial class LinqtoObject : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            int[] n = { 2, 5, 9, 1, 6, 20, 35 };

            var res = from V in n where V > 3 orderby V descending select V;
            //Response.Write(res);
           
            foreach (int r in res )
            {
               Response.Write(+r);
           }

            System.Collections.Generic.List<Products> obj = new List<Products>();
            obj.Add(new Products { prodname = "camera", proddesc = "model99", price = 5000 });
            obj.Add(new Products { prodname = "Nokia", proddesc = "1110", price = 6000 });
            obj.Add(new Products { prodname = "xyz", proddesc = "xyz family", price = 7000 });
            var result = from p in obj where (p.price > 4000) && p.prodname.Equals("camera") orderby p.price descending select new {p.prodname, p.price,p.proddesc };
            
            Grid1.DataSource = result;
            Grid1.DataBind();

               

        }
    }
}