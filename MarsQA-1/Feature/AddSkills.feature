Feature: Add Skills
	As a Seller
I want the feature to add a skills for my Profile Details
So that
The people seeking for some skills can look into my details.
Acceptance Criteria
Seller is able to add the skills.

@mytag
Scenario: 01 Add skills
		Given I will be add some skills for the profile
	
@mytag
Scenario: 02 Add Skill from excel sheet
		Given the Skill data in excel sheet create skill


@mytag
Scenario: 03 Update Skills 
      Given I able to update skill details
       
      
@mytag
Scenario: 04 Delete Skills
      Given I able to delete skill details



@ignore @web
 Scenario: 05 Test Add Skills sucessfully
		Given seller enter skill as Java 
		And   select level as Beginner from dropdown box
		When  clicks on 'Add' action button 
		Then  Skills should be added to your profile. The alert message, "Java has been added to your skills" will be displayed on top right of the application.


@ignore @web
 Scenario: 06 Test error message when level is not entered
		Given seller enter skill as C#
		And   do not select level from dropdown box
		When  seller clicks on 'Add' action button 
		Then  Alert message, "Please enter skill and experience level" is displayed on top right of the application. skill shouldnot be added.

@ignore @web
 Scenario: 07 Test error message when skill is not entered
		Given seller do not  enter value in skill text box
		And   select level as Expert from dropdown box
		When  clicks on 'Add' action button 
		Then  The alert message "Please enter skill and experience level" is displayed on top right of the application and skill shouldnot be added.

@ignore @web
 Scenario: 08 Test error message when the same skill is entered 
		Given seller enters allready existing skill (i.e. Java)
		And   select level as Expert from dropdown box
		When  seller clicks on 'Add' action button 
		Then  Alert message "Duplicate Data" is displayed on top right of the application.Skill shouldnot be added.

@ignore @web
 Scenario: 09 Test error message when the same skill with different level is selected
		Given seller enters already existing skill (i.e.C#)
		And   seller select level as intermediate from dropdown box
		When  seller clicks on 'Add' action button 
		Then  Alert message "Duplicate Data" is displayed on top right of the application.skill shouldnot be added.



@ignore @web
 Scenario: 10 Test error message when the same skill and same level is entered
		Given seller enters already existing skill (i.e.Java)
		And   seller enters already existing level (i.e.Beginner) from dropdown box
		When  seller clicks on 'Add' action button 
		Then  Alert message "This skill is already exist in your skill list" is displayed on top right of the application.skill shouldnot be added.


@ignore @web
 Scenario: 11 Test listing skills
		
		When  the seller clicks on skill tab 
		Then  skills page should display the list of skills that were created

@ignore @web
 Scenario: 12 Test error message when skill and level is not entered
		Given seller do not  enter value in skill text box
		And   do not select level from dropdown box
		When  seller clicks on 'Add' action button 
		Then  Alert message, "Please enter skill and experience level" is displayed on top right of the application. skill shouldnot be added.






