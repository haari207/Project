﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace OnlineShop
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            Application["s"] = 0;

        }

        protected void Application_End(object sender, EventArgs e)
        {
        }
        protected void Session_Start(object sender, EventArgs e)
        {
            Session["c"]=0;
        }
        protected void Session_End(object sender, EventArgs e)
        {
        }
        protected void Application_Error(object sender, EventArgs e)
        {
             var res=Server.GetLastError();
            Response.Write(res.Message);                            
        }
    }
}