using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.Xml;
using System.IO;

namespace GridDMLProject
{
    public partial class LinqToXML : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //var doc = XElement.Load(Server.MapPath(".") + "\\News.xml");
            XmlDocument doc = new XmlDocument();
           doc.Load(Server.MapPath(".") + "\\News.xml");
            XmlNodeList obj = doc.GetElementsByTagName("news");
            // Response.Write(doc.Element("news/general").Value);
            //Label1.Text = doc.FirstAttribute.Value;
            // Response.Write(doc.Element("general").Value);
            for(int i= 0;i < obj.Count;i++)
            {
                Response.Write(obj[i].InnerXml+ "</br>");
            }
        }
    }
}