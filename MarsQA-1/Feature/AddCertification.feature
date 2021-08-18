Feature: AddCertification
	As a Seller
I want the feature to add a certification for my Profile Details
So that
The people seeking for my certification can look into my details.
Acceptance Criteria
Seller is able to add the certification.


@mytag
 Scenario: 01 Test Add Certification sucessfully
	Given Seller enter Certificate as "ISTQB"
	And   Seller enter CertificateFrom as "Curam"
	And   select Year as "2021"                        
	When  Clicks on Add button on Addcertification page
	Then  Certificate should be added to the  profile. The Alert message "ISTQB has been added to your certification" is displayed on top right of the application.

@mytag		
 Scenario: 02 Test Update Certification sucessfully
		Given seller Updates Certificate as "TOFEL"
		And   updates Certificate From as "IBM"
		And   select Certificate Year as "2020"  
		When  clicks on Update button on UpdateCertification page
		Then  certification should be updated. The alert message, "TOFEL has been updated to your certification" will be displayed on top right of the application.

@mytag		
 Scenario: 03 Test Delete Certification sucessfully
		When  Seller select to delete Certification "TOFEL" 
		Then  Certification should be deleted. The alert message, "TOFEL has been deleted from your certification" will be displayed on top right of the application.

















