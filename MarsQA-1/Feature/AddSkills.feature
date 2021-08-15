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

@ignore @web
 Scenario: 04 Test error message when level is not entered
		Given seller enter skill as C#
		And   do not select level from dropdown box
		When  seller clicks on 'Add' action button 
		Then  Alert message, "Please enter skill and experience level" is displayed on top right of the application. skill shouldnot be added.

@ignore @web
 Scenario: 05 Test error message when skill is not entered
		Given seller do not  enter value in skill text box
		And   select level as Expert from dropdown box
		When  clicks on 'Add' action button 
		Then  The alert message "Please enter skill and experience level" is displayed on top right of the application and skill shouldnot be added.

@ignore @web
 Scenario: 06 Test error message when the same skill is entered 
		Given seller enters allready existing skill (i.e. Java)
		And   select level as Expert from dropdown box
		When  seller clicks on 'Add' action button 
		Then  Alert message "Duplicate Data" is displayed on top right of the application.Skill shouldnot be added.

@ignore @web
 Scenario: 07 Test error message when the same skill with different level is selected
		Given seller enters already existing skill (i.e.C#)
		And   seller select level as intermediate from dropdown box
		When  seller clicks on 'Add' action button 
		Then  Alert message "Duplicate Data" is displayed on top right of the application.skill shouldnot be added.

@ignore @web
 Scenario: 08 Test error message when the same skill and same level is entered
		Given seller enters already existing skill (i.e.Java)
		And   seller enters already existing level (i.e.Beginner) from dropdown box
		When  seller clicks on 'Add' action button 
		Then  Alert message "This skill is already exist in your skill list" is displayed on top right of the application.skill shouldnot be added.


@ignore @web
 Scenario: 09 Test listing skills		
		When  the seller clicks on skill tab 
		Then  skills page should display the list of skills that were created

@ignore @web
 Scenario: 10 Test error message when skill and level is not entered
		Given seller do not  enter value in skill text box
		And   do not select level from dropdown box
		When  seller clicks on 'Add' action button 
		Then  Alert message, "Please enter skill and experience level" is displayed on top right of the application. skill shouldnot be added.
