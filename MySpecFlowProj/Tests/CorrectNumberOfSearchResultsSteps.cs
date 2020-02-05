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

        [Given(@"I go to the main page of Bing")]
        public void GivenIGoToTheMainPageOfBing()
        {
            BingMainPage = new FeatureSupport().GoToBingMainPage();
        }
        
        [Given(@"I click on the search field")]
        public void GivenIClickOnTheSearchField()
        {
            BingMainPage.SearchTextField.Click();
        }

        [Given(@"I type '(.*)' in the search field")]
        public void GivenITypeInTheSearchField(string searchText)
        {
            BingMainPage.SearchTextField.SendKeys(searchText);
        }

        [When(@"I press Enter key")]
        public void WhenIPressEnterKey()
        {
            BingMainPage.SearchTextField.SendKeys(Keys.Enter);
        }

        [Then(@"the number of search results will be (.*)")]
        public void ThenTheNumberOfSearchResultsWillBe(int expNumOfResults)
        {
            SearchResultPage = new SearchResultPage();
            var actualNumOfResults = SearchResultPage.SearchResults.Count;

            Assert.AreEqual(actualNumOfResults, expNumOfResults);
        }
    }
}
