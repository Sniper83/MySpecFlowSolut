using System;
using MySpecFlowProj.Support;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace MySpecFlowProj.Tests
{
    [Binding]
    public class CorrectNumberOfSearchResultsSteps
    {
        private BingMainPage BingMainPage { get; set; }

        private SearchResultPage SearchResultPage { get; set; }

        [Given(@"I go to main page of Bing")]
        public void GivenIGoToMainPageOfBing()
        {
            BingMainPage = new FeatureSupport().GoToBingMainPage();
        }
        
        [Given(@"I click on search field")]
        public void GivenIClickOnSearchField()
        {
            BingMainPage.SearchTextField.Click();
        }

        [Given(@"I type '(.*)' in search field")]
        public void GivenITypeInSearchField(string searchText)
        {
            BingMainPage.SearchTextField.SendKeys(searchText);
        }

        [When(@"I press Enter key")]
        public void WhenIPressEnterKey()
        {
            BingMainPage.SearchTextField.SendKeys(Keys.Enter);
        }
        
        [Then(@"number of search results will be (.*)")]
        public void ThenNumberOfSearchResultsWillBe(int expNumOfResults)
        {
            SearchResultPage = new SearchResultPage();
            var actualNumOfResults = SearchResultPage.SearchResults.Count;

            Assert.AreEqual(actualNumOfResults, expNumOfResults);
        }
    }
}
