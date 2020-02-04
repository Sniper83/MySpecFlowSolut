Feature: CorrectURLsInSearchResults
	To be shure that searched content is correct
	When I make searching
	I want to see correct URLs in every search result

Background: 
	Given I search meaningful text and see results

@mytag2
Scenario: Assertion that URLs are correct
	Given I get list of URLs in search results
	Then I test that every URL in search result contains in list of expected URLs
