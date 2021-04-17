using ASPNETDemo.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNETDemo
{
    public partial class Hellolndex : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void HelloButton_Click(object sender, EventArgs e)
        {
            var name= xname.Text;
            if (name.Length > 0)
            {
                Hello hello = new Hello(name);
                LabelMessage.Text = hello.HelloMessage();
            }
            else
                LabelMessage.Text="Hello";
               

        }
    }
}