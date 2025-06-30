using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineShop
{
    public class MyCustomControl:WebControl
    {
        public string text {  get; set; }
        public override void RenderControl(HtmlTextWriter writer)
        {
            writer.Write($"<div style='background-color:lightblue;padding:10px;'> {text}</div>");
        }
    }
}