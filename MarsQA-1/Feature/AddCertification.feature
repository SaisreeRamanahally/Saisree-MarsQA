Feature: AddCertification
	As a Seller
I want the feature to add a certification for my Profile Details
So that
The people seeking for my certification can look into my details.
Acceptance Criteria
Seller is able to add the certification.


@mytag
 Scenario: Add Certification from excel sheet
   Given the certification data in excel sheet create certification

   @mytag
Scenario: Update Certification 
      Given I able to update Certification details
       
      
@mytag
Scenario: Delete Certification
      Given I able to delete Certification details



@mytag
 Scenario: Test Add Certification sucessfully
	Given The seller enters the following Certification data	
	| Certificate     | From  | Year |
	| Quality Analyst | ISTQB | 2021 |	                                
	When  clicks on 'Add' action button 
	Then  Alert message "Quality Analyst has been added to your certification" is displayed on top right of the application.

@mytag
 Scenario:  Test error message when the same Certificate,From,and Year  is entered
	Given The seller enters the following Certification data	
	| Certificate     | From  | Year |
	| Quality Analyst | ISTQB | 2021 |	                                
	When  clicks on 'Add' action button 
	Then  Alert message "This information is already exists" is displayed on top right of the application.


@mytag
 Scenario: Test error message when Certificate  is not entered
	Given The seller enters the following Certification data 
	
				| Certificate | From  | Year |
				|             | ISTQB | 2021 |                               
	When  clicks on 'Add' action button 
	Then  Alert message "Please enter Certification Name,Certification from and Certification Year" is displayed on top right of the application.


@mytag
 Scenario: Test error message when From  is not entered
	Given The seller enters the following Certification data 
	
				| Certificate     | From | Year |
				| Quality Analyst |      | 2021 |	                                
	When  clicks on 'Add' action button 
	Then  Alert message "Please enter Certification Name,Certification from and Certification Year" is displayed on top right of the application.


@mytag
 Scenario: Test error message when Year  is not entered
	Given The seller enters the following Certification data 
	
				| Certificate     | From  | Year |
				| Quality Analyst | ISTQB |      |                           
	When  clicks on 'Add' action button 
	Then  Alert message "Please enter Certification Name,Certification from and Certification Year" is displayed on top right of the application.


	@mytag
 Scenario: Test listing certification
		
		When  the seller clicks on certification tab 
		Then  certification page should display the list of certifications  that were created


		
@mytag
 Scenario: Test error message when Certificate, From and yesr  is not entered
	Given The seller enters the following Certification data 
	
				| Certificate | From  | Year |
				|             |       |      |                               
	When  clicks on 'Add' action button 
	Then  Alert message "Please enter Certification Name,Certification from and Certification Year" is displayed on top right of the application.
















