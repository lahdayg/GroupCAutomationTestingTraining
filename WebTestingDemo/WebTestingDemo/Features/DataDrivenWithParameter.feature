Feature: DataDrivenWithParameter
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Data Driven With Parameters
	Given I navigate to "https://angularjs.realworld.io/#/register"
	And I enter my Username text "Webtesting"
	And I enter my email address text "webtesting"
	And I enter my password "webtesting123"
	When I click on Sign up button
	Then I should be registered