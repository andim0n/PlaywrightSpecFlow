Feature: Books page

As a user I should be able to find the book by the name

Background: Opening books page
	Given The Books page is open

@findBook
Scenario: User is finding the book by the name and validating book content
	Given Text 'Speaking JavaScript' is applied as a search filter
	When I select first found result
	Then The title should contain text 'Speaking JavaScript'
