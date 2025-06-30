using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace OnlineShop
{
    public class Mycustomhandler : IHttpHandler
    {
        public bool IsReusable => true;

        public void ProcessRequest(HttpContext context)
        {
            //logic to be executed when the user gives extension  as king
            //context.Response.Write("<h1>king Executed</h1>");
            context.Response.Write("<h2>JPG is cannot  be open</h2>");
        }

    }
    public class Mycustommodule : IHttpModule
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Init(HttpApplication context)
        {
            context.BeginRequest += Context_BeginRequest;
            context.EndRequest += Context_EndRequest;
        }

        private void Context_EndRequest(object sender, EventArgs e)
        {
            //write caching code here
            HttpContext.Current.Response.Write("end is called");
            HttpContext.Current.Response.Write("page is ended" + DateTime.Now);
        }
        //gets called before the page is rendered in browser 
        private void Context_BeginRequest(object sender, EventArgs e)
        {
            HttpContext.Current.Response.Write("Begin request is called ");
            HttpContext.Current.Response.Write("page is processed at " + DateTime.Now);
            //write authentication code

        }
    }

}