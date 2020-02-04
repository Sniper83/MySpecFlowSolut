Feature: CorrectNumberOfSearchResults
	To be shure that Bing's search is working correct
	When I will search some text
	I want to get correct number of search results

Background:
	Given I go to main page of Bing
	And I click on search field

@mytag
Scenario Outline: Add some text in search field
	Given I type <Text> in search field
	When I press Enter key
	Then number of search results will be <Number>

Examples: 
| Text                                         | Number |
| 'wave-particle duality'                      | 10     |
| 'klajhsdkajhsfihuaisujhdkajshdkjahsdiasdihi' | 0      |
