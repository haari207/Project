using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineShop
{
    public partial class Hello : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["v"] = 0;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var a = int.Parse(TextBox1.Text);

            var b = int.Parse(TextBox2.Text);
           int  c = a + b;

            Label1.Text = c.ToString();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session["c"]=(int)Session["c"] + 1;
            Label2.Text = Session["c"].ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Application["s"] = (int)Application["s"] + 1;
            Label3.Text = Application["s"].ToString();

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            ViewState["v"] = (int)ViewState["v"] + 1;//only for single page access
            Label4.Text = ViewState["v"].ToString();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            HttpCookie c=new HttpCookie("hi");
            c["uname"] = "admin";
            c["pwd"] = "1234";
            Response.Cookies.Add(c); //create cookie in client machine
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            //read from cookie
            HttpCookie ht= Request.Cookies["hi"];
            Label5.Text = ht["uname"] + ":" + ht["pwd"];
        }
    }
}