Feature: LogoOnSearchResultsPageDisplayedCorrect
	To be sure that the Bing logo is visible on the search results page
	As a user of bing.com
	I want to test it visibility
Background: 
	Given I go to Bing main page

@mytag4
Scenario: Get the Bing logo on the search results page
	Given I click on the search text field
	And I type 'wave-particle duality' text
	When I press Enter
	Then the logo will be displayed
