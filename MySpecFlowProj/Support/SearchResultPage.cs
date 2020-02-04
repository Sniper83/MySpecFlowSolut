using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace MySpecFlowProj.Support
{
    public class SearchResultPage
    {
        private static IWebDriver Browser = Driver.Browser;

        public IList<IWebElement> SearchResults = Browser.FindElements(By.ClassName("b_algo"));

        public IWebElement BingLogo = Browser.FindElement(By.ClassName("b_logo"));

        public IWebElement SearchTextField = Browser.FindElement(By.Id("sb_form_q"));

        public List<string> SearchResultsURLs = new List<string>();

        public SearchResultPage()
        {
            foreach (var item in SearchResults)
            {
                SearchResultsURLs.Add(item.FindElement(By.CssSelector("h2 > a")).GetAttribute("href"));
            }
        }
    }
}
