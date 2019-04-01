Feature: IntoProject
	In order to switch the localisation
	I will need to go to the website
	So that i can switch the language

@mytag
Scenario: Localisation Switching
	Given I navigate to https://www.intostudy.com/en-gb
	When I click on the chinese on the banner
	Then the localisation should change from English to chinese
