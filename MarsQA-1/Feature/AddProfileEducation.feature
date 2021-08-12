Feature: AddProfileEducation
	As a Seller
I want the feature to add a education for my Profile Details
So that
The people seeking for  education can look into my details.
Acceptance Criteria
Seller is able to add the education.

@mytag
Scenario: Add Education from excel sheet
Given the education data in excel sheet create education

@mytag
Scenario: Update Education 
      Given I able to update education details
       
      
@mytag
Scenario: Delete Education
      Given I able to delete education details



@mytag
 Scenario: Test Add Education sucessfully
	Given The seller enters the following education data 
			| Country     | University | Title | Degree  | Graduation Year |
			| New Zealand | Victoria   | M.B.A | 2 years | 2000            |                   
	When  clicks on 'Add' action button 
	Then  Alert message "Education has been added" is displayed on top right of the application.


@mytag
 Scenario: Test error message when Country is not entered
		Given The seller enters the following education data 
			| Country | University | Title | Degree | Graduation Year |
			|          | Victoria   | M.B.A   | 2 years | 2000            |                              
       When  clicks on 'Add' action button 
       Then  Alert message "Please enter all the fields" is displayed on top right of the application.


@mytag
 Scenario: Test error message when University is not entered
		Given The seller enters the following education data 
				| Country    | University | Title | Degree  | Graduation Year |
				| New Zeland |            | M.B.A | 2 years | 2000            |                             
		When  clicks on 'Add' action button 
		Then  Alert message "Please enter all the fields" is displayed on top right of the application.



@mytag
 Scenario: Test error message when Title is not entered
		Given The seller enters the following education data 
				| Country  | University | Title | Degree  | Graduation Year |
				| New Zela | Victiria   |       | 2 years | 2000            |                            
		When  clicks on 'Add' action button 
		Then  Alert message "Please enter all the fields" is displayed on top right of the application.


@mytag
 Scenario: Test error message when Degree is not entered
		Given The seller enters the following education data 
				| Country    | University | Title | Degree | Graduation Year |
				| New Zeland | Victiria   | M.B.A |        | 2000            |                             
		When  clicks on 'Add' action button 
		Then  Alert message "Please enter all the fields" is displayed on top right of the application.



@mytag
 Scenario: Test error message when Graduation Year is not entered
		Given The seller enters the following education data 
	        | Country    | University | Title | Degree | Graduation Year |
	        | New Zeland | Victiria   | M.B.A | 2Years |                 |               
       When  clicks on 'Add' action button 
       Then  Alert message "Please enter all the fields" is displayed on top right of the application.



@mytag
 Scenario:Test error message when the same Country,University,Title,Degree and Graduation Year  is entered
		Given The seller enters the following education data 
	        | Country     | University | Title | Degree  | Graduation Year |
	        | New Zealand | Victoria   | M.B.A | 2 years | 2000            |                             
        When  clicks on 'Add' action button 
       Then  Alert message "Please enter all the fields" is displayed on top right of the application.


	   
		@mytag
 Scenario: Test listing Education
		
		When  the seller clicks on education tab 
		Then  education page should display the list of educations that were created


		@mytag
 Scenario: Test error message when Country, University,Title,Degree and Graduation year is not entered
		Given The seller do not enters the following education data 
			| Country | University | Title | Degree | Graduation Year |
			|         |            |       |        |                 |                              
       When  clicks on 'Add' action button 
       Then  Alert message "Please enter all the fields" is displayed on top right of the application.




















