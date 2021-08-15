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





@ignore @web
 Scenario: 04 Test Add Certification sucessfully
	Given The seller enters the following Certification data	
	| Certificate     | From  | Year |
	| Quality Analyst | ISTQB | 2021 |	                                
	When  clicks on 'Add' action button 
	Then  Alert message "Quality Analyst has been added to your certification" is displayed on top right of the application.

@ignore @web
 Scenario:  05 Test error message when the same Certificate,From,and Year  is entered
	Given The seller enters the following Certification data	
	| Certificate     | From  | Year |
	| Quality Analyst | ISTQB | 2021 |	                                
	When  clicks on 'Add' action button 
	Then  Alert message "This information is already exists" is displayed on top right of the application.

@ignore @web
 Scenario: 06 Test error message when Certificate  is not entered
	Given The seller enters the following Certification data 
	
				| Certificate | From  | Year |
				|             | ISTQB | 2021 |                               
	When  clicks on 'Add' action button 
	Then  Alert message "Please enter Certification Name,Certification from and Certification Year" is displayed on top right of the application.

@ignore @web
 Scenario: 07 Test error message when From  is not entered
	Given The seller enters the following Certification data 
	
				| Certificate     | From | Year |
				| Quality Analyst |      | 2021 |	                                
	When  clicks on 'Add' action button 
	Then  Alert message "Please enter Certification Name,Certification from and Certification Year" is displayed on top right of the application.

@ignore @web
 Scenario: 08 Test error message when Year  is not entered
	Given The seller enters the following Certification data 
	
				| Certificate     | From  | Year |
				| Quality Analyst | ISTQB |      |                           
	When  clicks on 'Add' action button 
	Then  Alert message "Please enter Certification Name,Certification from and Certification Year" is displayed on top right of the application.


@ignore @web
 Scenario: 09 Test listing certification
		
		When  the seller clicks on certification tab 
		Then  certification page should display the list of certifications  that were created


		
@ignore @web
 Scenario: 10 Test error message when Certificate, From and yesr  is not entered
	Given The seller enters the following Certification data 
	
				| Certificate | From  | Year |
				|             |       |      |                               
	When  clicks on 'Add' action button 
	Then  Alert message "Please enter Certification Name,Certification from and Certification Year" is displayed on top right of the application.
















