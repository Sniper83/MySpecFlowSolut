Feature: CorrectTextInElements
	To be shure that some of bing main page elements have correct text
	I will get this elements with Selenium methods
	And will test text attribute of them

Background:
	Given go to Bing main page

@mytag3
Scenario Outline: Get some element
	Given I get some <Element>
	Then I test that text of this element contains in list of texts

Examples: 
| Element |
| Images  |
| SignIn  |
