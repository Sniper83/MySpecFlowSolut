using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MySpecFlowProj.Support
{
    public static class Driver
    {
        public static IWebDriver Browser = StartDriver();
        
        public static IWebDriver StartDriver()
        {
            return new ChromeDriver();
        }
    }
}
