using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineShop.Models;
namespace OnlineShop
{
    public partial class Login : System.Web.UI.Page
    {
        OnlineshopEntities1 db = new OnlineshopEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            Master.changelabel = "Welcome to Login Page";
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            var res=(from t in db.Registers
                    where t.uname == Login1.UserName && t.password == Login1.Password
                    select t).Count();
            if (res > 0)
            {

                Session["u"]=Login1.UserName; //store username in session variable
                //redirect to products page
                Response.Redirect("Products.aspx");

            }
            else
            {
                //show error message
                Login1.FailureText = "Invalid username or password";
            }
        }
    }
}