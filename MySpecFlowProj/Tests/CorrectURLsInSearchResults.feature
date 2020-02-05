Feature: CorrectURLsInSearchResults
	To be shure that searched content is correct
	When I make searching
	I want to see correct URLs in every search result

Background: 
	Given I search meaningful text and see results

@mytag2
Scenario: The assertion that URLs are correct
	Given I get a list of URLs in search results
	Then I test that every URL in search result contains in the list of expected URLs
