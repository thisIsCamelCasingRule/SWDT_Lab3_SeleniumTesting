Feature: Pressed on button
	As a user
	I want to see the apropriate page after presing the button

@mytag
Scenario: Services button pressed
	Given the user is on home page
	When the services button is pressed
	Then the page services appears

Scenario: About button is pressed
	Given the user is on home page
	When the about button is pressed
	Then the page about appears

Scenario: Our work button is pressed
	Given the user is on home page
	When the our work button is pressed
	Then the page our work appears

Scenario: Insights button is pressed
	Given the user is on home page
	When the insights button is pressed
	Then the page insights appears

Scenario: Engineer button is pressed
	Given the user on services page
	When the engineer button is pressed
	Then the page engineer appears

Scenario: Consult button is pressed
	Given the user on services page
	When the consult button is pressed
	Then the page consult appears

Scenario: Design button is pressed
	Given the user on services page
	When the design button is pressed
	Then the page design appears

Scenario: Operate button is pressed
	Given the user on services page
	When the operate button is pressed
	Then the page operate appears