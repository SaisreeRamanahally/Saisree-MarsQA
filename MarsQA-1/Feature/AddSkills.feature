Feature: Add Skills
	As a Seller
I want the feature to add a skills for my Profile Details
So that
The people seeking for some skills can look into my details.
Acceptance Criteria
Seller is able to add the skills.

@mytag
 Scenario: 01 Test Add Skills sucessfully
		Given seller enter skill as "Java"
		And   select skill level as "Beginner" 
		When  clicks on Add button on Addskill page
		Then  Skill should be added to the  profile. The alert message, "Java has been added to your skills" will be displayed on top right of the application.

@mytag
 Scenario: 02 Test Update Skills sucessfully
		Given seller Updates skill as "Quality Analyst"
		And   updates skill level as "Expert" 
		When  clicks on Update button on Updateskill page
		Then  Skill should be updated. The alert message, "Quality Analyst has been updated to your skills" will be displayed on top right of the application.

@mytag		
 Scenario: 03 Test Delete Skill sucessfully
		When  Seller select to delete Skill "Quality Analyst" 
		Then  Skill should be deleted. The alert message,"Quality Analyst has been deleted" will be displayed on top right of the application.

