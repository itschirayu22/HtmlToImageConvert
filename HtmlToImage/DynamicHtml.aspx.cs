using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HtmlToImage
{
    public partial class DynamicHtml : System.Web.UI.Page
    {
        public string dynamicText;
        public DateTime currentDate;
        protected void Page_Load(object sender, EventArgs e)
        {
            currentDate = DateTime.Now;
            dynamicText = "Chirayu";
        }
    }
}