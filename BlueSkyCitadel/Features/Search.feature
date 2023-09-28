Feature: Search

@search
Scenario: Search for a course
	Given I navigate to 'https://www.prepmajor.com'
	When I click on the search field
	And I type 'automation' in the search field
	And I click the search button
	Then the result page is displayed
