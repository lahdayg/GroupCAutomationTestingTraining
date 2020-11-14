Feature: DataDrivenWithExample
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario Outline: Data Driven With Examples
	Given I navigate to "https://angularjs.realworld.io/#/register"
	And I enter username text "<Username>"
	And I enter Email text "<Email>"
	And I enter Password text "<Password>"
	#When I click on sign up
	#Then I should be registered


	Examples:
	| Username | Email           | Password         |
	| Demo3    | Demo4@demo.com  | PasswordSecure@  |
	| Demo2    | Demo6@demo.com  | PasswordSecure2  |
	| Demo88   | Demo23@demo.com | PasswordSecure22 |


	