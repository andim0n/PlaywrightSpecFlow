Feature: WebTables

As a user I should be able to perform CRUD operations in the table

Background: Opening web tables page
	Given The 'WebTables' page is open

@createNewRow
Scenario Outline: Creating new row in the table
	Given Click 'Add' button
	When I insert values '<firstName>', '<lastName>', '<email>', '<age>', '<salary>', '<department>' in the registration form
	And Click 'Submit' button
	Then I should be able to see new row with data '<firstName>', '<lastName>', '<email>', '<age>', '<salary>', '<department>' in the table

Examples:
	| firstName | lastName | email            | age | salary | department |
	| Emilia    | Smith    | example@test.com | 25  | 11500  | Retail     |
	| Elliot    | Alderson | root@kali.net    | 27  | 99999  | Security   |
