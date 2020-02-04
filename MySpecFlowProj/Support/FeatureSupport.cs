using System.Collections.Generic;
using OpenQA.Selenium;

namespace MySpecFlowProj.Support
{
    public class FeatureSupport
    {
        public BingMainPage BingMainPage;

        public SearchResultPage SearchResultPage;

        public BingMainPage GoToBingMainPage()
        {
            Driver.Browser.Navigate().GoToUrl(Consts.BingMainPageURL);

            BingMainPage = new BingMainPage();

            return BingMainPage;
        }

        public SearchResultPage GoToSearchResultPage(string searchText)
        {
            GoToBingMainPage();

            BingMainPage.SearchTextField.Click();
            BingMainPage.SearchTextField.SendKeys(searchText);
            BingMainPage.SearchTextField.SendKeys(Keys.Enter);

            SearchResultPage = new SearchResultPage();

            return SearchResultPage;
        }
    }
}
