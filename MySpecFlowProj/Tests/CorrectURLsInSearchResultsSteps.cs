using System;
using System.Collections.Generic;
using MySpecFlowProj.Support;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace MySpecFlowProj.Tests
{
    [Binding]
    public class CorrectURLsInSearchResultsSteps
    {
        private SearchResultPage SearchResultPage { get; set; }

        private List<string> SearchResultsURLs;

        [Given(@"I search meaningful text and see results")]
        public void GivenISearchMeaningfulTextAndSeeResults()
        {
            SearchResultPage = new FeatureSupport().GoToSearchResultPage(Consts.MeaningfulText);
        }

        [Given(@"I get a list of URLs in search results")]
        public void GivenIGetAListOfURLsInSearchResults()
        {
            SearchResultsURLs = SearchResultPage.SearchResultsURLs;
        }

        [Then(@"I test that every URL in search result contains in the list of expected URLs")]
        public void ThenITestThatEveryURLInSearchResultContainsInTheListOfExpectedURLs()
        {
            var allURLsAreCorrect = false;

            foreach (var item in SearchResultsURLs)
            {
                if (!Consts.SearchResultsURLs.Contains(item))
                {
                    allURLsAreCorrect = false;
                    break;
                }
                else
                {
                    allURLsAreCorrect = true;
                }
            }

            Assert.IsTrue(allURLsAreCorrect);
        }
    }
}
