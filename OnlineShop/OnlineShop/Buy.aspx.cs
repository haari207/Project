using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineShop.Models;

namespace OnlineShop
{
    public partial class Buy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["u"] == null)
            {
                //redirect to login page if user is not logged in
                Response.Redirect("Login.aspx");
            }
            else
            {
                Label1.Text = Request.QueryString["a"];
                Label2.Text = Request.QueryString["b"];
                Label3.Text = Request.QueryString["c"];
                Label4.Text = Request.QueryString["d"];
                Image2.ImageUrl = Request.QueryString["e"];
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            //clear the session variable
            if (Session["u"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                userorder ob = new userorder();
                ob.username = Session["u"].ToString();
                ob.pid = Request.QueryString["a"];      
                ob.transdate = DateTime.Now;
                ob.qty = int.Parse(TextBox1.Text);
                using (OnlineshopEntities1 db = new OnlineshopEntities1())
                {
                    db.userorders.Add(ob);
                    db.SaveChanges();
                }
            }

        }
    }
}