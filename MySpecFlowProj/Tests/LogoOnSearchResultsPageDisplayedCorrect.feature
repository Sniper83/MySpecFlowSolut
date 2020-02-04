Feature: LogoOnSearchResultsPageDisplayedCorrect
	To be shure that Bing logo is visible on search results page
	As user of bing.com
	I want test it visability
Background: 
	Given I go to Bing main page

@mytag4
Scenario: Add two numbers
	Given I click on search text field
	And I type 'wave-particle duality' text
	When I press Enter
	Then the logo will be dispalayed
