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
