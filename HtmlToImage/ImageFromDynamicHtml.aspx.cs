using NReco.ImageGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HtmlToImage
{
    public partial class ImageFromDynamicHtml : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            Uri uri = new Uri(Request.Url.ToString());
            string url = uri.Scheme + Uri.SchemeDelimiter + uri.Host + ":" + uri.Port + "/DynamicHtml.aspx";
            //string url = Request.Url.AbsoluteUri.ToString() + "://DynamicHtml.aspx";
            string downloadString = client.DownloadString(url);
            var htmlToImageConv = new NReco.ImageGenerator.HtmlToImageConverter();            
            htmlToImageConv.ToolPath = Server.MapPath("~/executable/");
            htmlToImageConv.WkHtmlToImageExeName = "wkhtmltoimage.exe";
            htmlToImageConv.Width = 100; // any width can be specified                  
            byte[] bytes = htmlToImageConv.GenerateImage(downloadString, ImageFormat.Jpeg);

            Response.Clear();
            Response.ContentType = "image/png";
            Response.BinaryWrite(bytes);
        }
    }
}