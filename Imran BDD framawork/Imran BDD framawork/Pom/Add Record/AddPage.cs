using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WindowsInput;
using WindowsInput.Native;

namespace SQA04imranexam
{

   public class AddPage :  BasePage
    {



        public string firstnamee { get; set; }
        public string midnamee { get; set; }
        public string lastnamee { get; set; }

        public string nsearchh { get; set; }




        By pimpage = By.XPath("//span[text()='PIM']");
        By addbutton = By.CssSelector(".orangehrm-header-container button");
        By val = By.XPath("//h6[text()='Add Employee']");
        By val2 = By.XPath("//h5[text()='Employee Information']");
        By firstname = By.Name("firstName");
        By midname = By.Name("middleName");
        By lastname = By.Name("lastName");
        By save = By.CssSelector(".oxd-form-actions button:nth-child(3)");
        By again = By.XPath("//span[text()='PIM']");
        By search = By.CssSelector(".oxd-form-actions button:nth-child(2)");

        By nsearch = By.CssSelector("  form > div.oxd-form-row > div > div:nth-child(1) > div > div:nth-child(2) > div");
        By vvv = By.XPath("//div[text()='First (& Middle) Name']");
        


        public void addp()
        {

            Thread.Sleep(1000);
            cle(pimpage);
            Thread.Sleep(1000);
            clickk(addbutton, val);

            sendkeyy(firstname, firstnamee);
            sendkeyy(midname, midnamee);
            sendkeyy(lastname, lastnamee);
            cle(save);
            Thread.Sleep(2000);
            clickk(again,val2);
            Thread.Sleep(3000);
            InputSimulator sim = new InputSimulator();


            sim.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            sim.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            sim.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            sim.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            sim.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            sim.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            sim.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            sim.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            sim.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            sim.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            sim.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            sim.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            sim.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            sim.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            sim.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            sim.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            sim.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            sim.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            sim.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(3000);
            sim.Keyboard.TextEntry("imrann");
            Thread.Sleep(1000);
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript("window.scrollBy(0,document.body.scrollHeight)");

            clickk(search,vvv);






        }


    }




}
