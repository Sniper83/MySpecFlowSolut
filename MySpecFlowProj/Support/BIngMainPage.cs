using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace MySpecFlowProj.Support
{
    public class BingMainPage
    {
        private static IWebDriver Browser = Driver.Browser;

        public IWebElement SearchTextField = Browser.FindElement(By.Id("sb_form_q"));

        public IWebElement Images = Browser.FindElement(By.ClassName("scopebar_link"));

        public IWebElement SignIn = Browser.FindElement(By.Id("id_s"));
    }
}
