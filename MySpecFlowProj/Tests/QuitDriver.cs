using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySpecFlowProj.Support;
using TechTalk.SpecFlow;

namespace MySpecFlowProj.Tests
{
    [Binding]
    class QuitDriver
    {
        [AfterTestRun]
        public static void AfterTestRun()
        {
            Driver.Browser.Quit();
        }
    }
}
