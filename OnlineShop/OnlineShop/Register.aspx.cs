using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineShop.Models;
namespace OnlineShop
{
     
    public partial class Register : System.Web.UI.Page
    {

        OnlineshopEntities1 db = new OnlineshopEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            OnlineShop.Models.Register r = new OnlineShop.Models.Register();
            r.uname = TextBox1.Text;
            r.password = TextBox2.Text;
            r.email=TextBox4.Text;
            r.Age = int.Parse(TextBox5.Text);
            r.country= TextBox6.Text;
            if (RadioButton1.Checked)
            {
                r.gender = true;
            }
            else
            {
                r.gender = false;
            }
            db.Registers.Add(r);
            int i=db.SaveChanges();
            if (i > 0)
            {
                Label1.Text = "congrats New user created!";
            }


        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {

        }

        /* protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
         {

         }*/

        //protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        //{
        //    if(args.Value=="India"|| args.Value == "Canada" || args.Value == "Japan")
        //    {
        //        args.IsValid = true;
        //    }
        //    else
        //    {
        //        args.IsValid = false;
        //    }
        //}
    }
}