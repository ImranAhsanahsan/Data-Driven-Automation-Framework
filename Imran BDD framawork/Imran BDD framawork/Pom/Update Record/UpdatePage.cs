﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SQA04imranexam
{
   

    public class UpdatePage :BasePage
    {


        public string del1 { get; set; }




        By pimpage = By.XPath("//span[text()='PIM']");
        By sear = By.CssSelector("  form > div.oxd-form-row > div > div:nth-child(1) > div > div:nth-child(2) > div > div > input");
        By search = By.CssSelector(".oxd-form-actions button:nth-child(2)");

        By val = By.CssSelector("div > div.oxd-table-body > div > div > div:nth-child(9) > div > button:nth-child(2)");






        public void updatep()
        {

            Thread.Sleep(1000);
            cle(pimpage);
            Thread.Sleep(1000);
            sendkeyy(sear, del1);
            Thread.Sleep(1000);
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript("window.scrollBy(0,document.body.scrollHeight)");
            Thread.Sleep(2000);
            clickk(search, val);




        }





    }
















}
