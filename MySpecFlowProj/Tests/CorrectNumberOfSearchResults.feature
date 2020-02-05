Feature: CorrectNumberOfSearchResults
	To be sure that Bing's search is working correctly
	When I will search some text
	I want to get the correct number of search results

Background:
	Given I go to the main page of Bing
	And I click on the search field

@mytag
Scenario Outline: Add some text in the search field
	Given I type <Text> in the search field
	When I press Enter key
	Then the number of search results will be <Number>

Examples: 
| Text                                         | Number |
| 'wave-particle duality'                      | 10   |
| 'klajhsdkajhsfihuaisujhdkajshdkjahsdiasdihi' | 0    |
