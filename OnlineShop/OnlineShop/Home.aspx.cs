using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineShop.Models;
namespace OnlineShop
{
    public partial class Home : System.Web.UI.Page
    {
        OnlineshopEntities1 ob=new OnlineshopEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            var res=from t in ob.products
                    select t;
            Repeater1.DataSource = res.ToList();
            Repeater1.DataBind();// RECORDS WILL NOT DISPLAY UNTIL DATABIND

        }
    }
}