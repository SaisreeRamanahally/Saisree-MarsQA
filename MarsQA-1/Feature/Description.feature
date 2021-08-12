Feature: Description
	As a Seller
I want the feature to add a description for my Profile Details
So that
The people seeking for  description can look into my details.
Acceptance Criteria
Seller is able to add the description.


@mytag
Scenario: Add description 
Given the description data in excel sheet create description


@mytag
Scenario: seller is able to add description text with exactly 600 characters.
Given the seller enters the description text with exactly 600 characters
When seller click on save button
Then seller profile description should be saved succesfully


@mytag
Scenario: seller is not allowed to add description text with more than 600 characters.
Given seller tries to enter the description text with more than 600 characters
Then seller is not allowed to add description text with more than 600 characters.


@mytag
Scenario: seller is able to add description text with lessthan 600 characters.
Given seller enters the description as "I am a passionate test analyst"
When seller click on save button
Then seller profile description should be saved



@mytag
Scenario:Test error message when description is not entered
Given seller do not  enters value in description text box
When seller click on save button
Then Alert message, "Please, a description is required" is displayed on top right of the application. Language shouldnot be added.
