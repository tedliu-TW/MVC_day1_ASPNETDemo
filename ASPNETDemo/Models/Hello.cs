using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNETDemo.Models
{
    public class Hello
    {

        //商業級 ASP.NET MVC 樣式X 架構實務
        private string _name="";
        public Hello(string name)
        {
            _name = name;
        }

        public string HelloName 
        {
            get { return _name;}
        
        }

        public string HelloMessage()
        {
            var message="";
            if(HelloName.Length >0)
                message =  "Hello,"+HelloName;
            else
                message="Hello";
           return message;
        }




    }
}