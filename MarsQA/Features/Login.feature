Feature: Login
	In order to create a user profile
	user logs into website

@mytag
Scenario: user has an account in website
	Given user is in home page
	And user enters valid username and password
	When user press login 
	Then successfully logs in


