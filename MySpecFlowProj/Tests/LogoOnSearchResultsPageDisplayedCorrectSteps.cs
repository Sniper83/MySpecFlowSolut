using System;
using MySpecFlowProj.Support;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace MySpecFlowProj.Tests
{
    [Binding]
    public class LogoOnSearchResultsPageDisplayedCorrectSteps
    {
        private BingMainPage BingMainPage { get; set; }

        private SearchResultPage SearchResultPage { get; set; }

        [Given(@"I go to Bing main page")]
        public void GivenIGoToBingMainPage()
        {
            BingMainPage = new FeatureSupport().GoToBingMainPage();
        }
        
        [Given(@"I click on the search text field")]
        public void GivenIClickOnTheSearchTextField()
        {
            BingMainPage.SearchTextField.Click();
        }
        
        [Given(@"I type '(.*)' text")]
        public void GivenITypeText(string p0)
        {
            BingMainPage.SearchTextField.SendKeys("wave-particle duality");
        }
        
        [When(@"I press Enter")]
        public void WhenIPressEnter()
        {
            BingMainPage.SearchTextField.SendKeys(Keys.Enter);
        }
        
        [Then(@"the logo will be displayed")]
        public void ThenTheLogoWillBeDisplayed()
        {
            SearchResultPage = new SearchResultPage();
            Assert.IsTrue(SearchResultPage.BingLogo.Displayed);
        }
    }
}
