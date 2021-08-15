Feature: Add Language
	As a Seller
I want the feature to add a language to the Profile
So that
The people seeking for specific languages can look into my details.
Acceptance Criteria
Seller is able to add the language.

@mytag
 Scenario: 01 Test Add Language sucessfully
		Given seller enter language as "English" 
		And   select level as "Basic"
		When  clicks on Add action button 
		Then  Language should be added to your profile. The alert message, "English has been added to your languages" will be displayed on top right of the application.

@mytag
 Scenario: 02 Test Update Language sucessfully
		Given seller updates language as "Maori" 
		And   updates level as "Fluent"
		When  clicks on Update button 
		Then  Language should be updated. The alert message, "Maori has been updated to your languages" will be displayed on top right of the application.

@mytag
 Scenario: 03 Test Delete Language sucessfully
		When  Seller select to delete language "Maori" 
		Then  Language should be deleted. The alert message, "Maori has been deleted from your languages" will be displayed on top right of the application.

@ignore @web
 Scenario: 04 Test error message when level is not entered
		Given seller enter language as "Maori"
		And   do not select level from dropdown box
		When  seller clicks on 'Add' action button 
		Then  Alert message, "Please enter language and level" is displayed on top right of the application. Language shouldnot be added.

@ignore @web
	Scenario: 05 Test error message when language is not entered
		Given seller do not  enter value in language text box
		And   select level as Fluent from dropdown box
		When  clicks on 'Add' action button 
		Then  The alert message "Please enter language and level" is displayed on top right of the application and Language shouldnot be added.

@ignore @web
 Scenario: 06 Test error message when the same language is entered
		Given seller enters allready existing language (i.e.Maori)
		And   select level as Fluent from dropdown box
		When  seller clicks on 'Add' action button 
		Then  Alert message "Duplicate Data" is displayed on top right of the application.Language shouldnot be added.


@ignore @web
 Scenario: 07 Test error message when the same language with different level is selected
		Given seller enters already existing language (i.e.Maori)
		And   seller select level as Basic from dropdown box
		When  seller clicks on 'Add' action button 
		Then  Alert message "Duplicate Data" is displayed on top right of the application.Language shouldnot be added.


@ignore @web
 Scenario: 08 Test AddNew action button is hidden when the seller add fourth language record sucessfully
           Pre-Condition Three records already exists.
		Given seller adds fourth language record sucessfully
		Then  The Add action button is hidden.


@ignore @web
 Scenario: 09 Test error message when the same language and same level is entered
		Given seller enters already existing language (i.e.English)
		And   seller enters already existing level (i.e.Basic) from dropdown box
		When  seller clicks on 'Add' action button 
		Then  Alert message "This language is already exist in your language list" is displayed on top right of the application.language shouldnot be added.

@ignore @web
 Scenario: 10 Test listing languages
		
		When  the seller clicks on languages tab 
		Then  languages page should display the list of languages that were created

@ignore @web
 Scenario: 11 Test error message when language and level is not entered
		Given seller do not  enter value in language text box
		And   do not select level from dropdown box
		When  seller clicks on 'Add' action button 
		Then  Alert message, "Please enter language and level" is displayed on top right of the application. Language shouldnot be added.






