Feature: Register user in the application

@mytag
Scenario: Register the user in the app
	Given I sign in to the app homepage
	When I created account using emailId 'email'
	Then  I register the user 
