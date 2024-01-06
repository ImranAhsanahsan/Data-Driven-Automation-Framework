using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQA04imranexam
{

    public class LoginPage : BasePage
    {



        public string userrr { get; set; }
        public string passss { get; set; }
       






        By username = By.Name("username");
        By pass = By.Name("password");
        By lbutton = By.CssSelector("div.oxd-form-actions.orangehrm-login-action > button");
        By validate = By.XPath("//span[text()='PIM']");
        public void loginp()
        {

            sendkeyy(username, userrr);
            sendkeyy(pass, passss);
           
            clickk(lbutton,validate);







        }












    }













   
}
