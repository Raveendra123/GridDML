using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace GridDMLProject
{
    public partial class LinqToXML : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var doc = XElement.Load(Server.MapPath(".") + "\\News.xml");
           

            Response.Write(doc.Element("news/general").Value);
            Label1.Text = doc.Element("general").Value + "<br>" + doc.Element("Sports").Value;
            Response.Write(doc.Element("general").Value);
        }
    }
}