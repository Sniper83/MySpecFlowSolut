Feature: CorrectTextInElements
	To be sure that some of bing main page elements have the correct text
	I will get these elements with Selenium methods
	And will test text attribute of them

Background:
	Given I go to the main page of Bing site

@mytag3
Scenario Outline: Get some element
	Given I get some <Element>
	Then I test that text of this element contains in the list of texts

Examples: 
| Element |
| Images  |
| SignIn  |
