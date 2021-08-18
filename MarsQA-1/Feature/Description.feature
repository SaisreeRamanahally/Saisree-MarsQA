Feature: Description
	As a Seller
I want the feature to add a description for my Profile Details
So that
The people seeking for  description can look into my details.
Acceptance Criteria
Seller is able to add the description.


@mytag
Scenario: 01 Add description 
Given the Description as "Saisree is a passionte Test Analyst"
When seller click on Save button
Then the description is saved and the message "Description has been saved successfully" will be displayed on top right of the application.

