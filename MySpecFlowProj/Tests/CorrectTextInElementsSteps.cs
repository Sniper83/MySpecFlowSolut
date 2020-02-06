using System;
using System.Collections.Generic;
using System.Linq;
using MySpecFlowProj.Support;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace MySpecFlowProj.Tests
{
    [Binding]
    public class CorrectTextInElementsSteps
    {
        private BingMainPage BingMainPage { get; set; }

        private string ActualWebElementText { get; set; }

        private string ExpectedWebElementText { get; set; }

        [Given(@"I go to the main page of Bing site")]
        public void GivenIGoToTheMainPageOfBingSite()
        {
            BingMainPage = new FeatureSupport().GoToBingMainPage();
        }

        [Given(@"I get some (.*)")]
        public void GivenIGetSome(string iWebElementName)
        {
            Dictionary<string, IWebElement> AllElements = new Dictionary<string, IWebElement>
            {
                {"Images", BingMainPage.Images},
                {"SignIn", BingMainPage.SignIn}
            };

            ActualWebElementText = AllElements[iWebElementName].Text;

            ExpectedWebElementText = Consts.TextsInElements[iWebElementName];
        }

        [Then(@"I test that text of this element contains in the list of texts")]
        public void ThenITestThatTextOfThisElementContainsInTheListOfTexts()
        {
            Assert.AreEqual(ActualWebElementText, ExpectedWebElementText);
        }
    }
}
