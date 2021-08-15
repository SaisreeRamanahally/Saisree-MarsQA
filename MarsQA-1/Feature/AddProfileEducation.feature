Feature: AddProfileEducation
	As a Seller
I want the feature to add a education for my Profile Details
So that
The people seeking for  education can look into my details.
Acceptance Criteria
Seller is able to add the education.

mytag
 Scenario: 01 Test Add Education sucessfully
	Given Seller enter UniversityName as "Otago"
	And   Select CountryOfUniversity as "Australia"
	And   Select Title as "B.Tech"
	And   Enter Degree as "4Years"
	And   Select YearOfGreaduation as "1999"                      
	When  Clicks on Add button on AddEducation page
	Then  Education should be added to the  profile. The Alert message "Education has been added" is displayed on top right of the application.

	
@mytag
 Scenario: 02 Test Update Education sucessfully
		Given seller updates education as "Victoria"
		And   updates CountryOfUniversity as "China"
		And   updates Title as "M.Tech"
		And   updates Degree as "2Years"
		And   updates YearOfGreaduation as "2020" 
		When  clicks on Update button on Updateeducation page
		Then  Education should be updated. The alert message, "Education as been updated" will be displayed on top right of the application.
@mytag		
 Scenario: 03 Test Delete Education sucessfully
		When  Seller select to delete Educaion "Victoria" 
		Then  Education should be deleted. The alert message, "Education entry successfully removed" will be displayed on top right of the application.



@ignore @web
 Scenario: 04 Test Add Education sucessfully
	Given The seller enters the following education data 
			| Country     | University | Title | Degree  | Graduation Year |
			| New Zealand | Victoria   | M.B.A | 2 years | 2000            |                   
	When  clicks on 'Add' action button 
	Then  Alert message "Education has been added" is displayed on top right of the application.

@ignore @web
 Scenario: 05 Test error message when Country is not entered
		Given The seller enters the following education data 
			| Country | University | Title | Degree | Graduation Year |
			|          | Victoria   | M.B.A   | 2 years | 2000            |                              
       When  clicks on 'Add' action button 
       Then  Alert message "Please enter all the fields" is displayed on top right of the application.


@ignore @web
 Scenario: 06 Test error message when University is not entered
		Given The seller enters the following education data 
				| Country    | University | Title | Degree  | Graduation Year |
				| New Zeland |            | M.B.A | 2 years | 2000            |                             
		When  clicks on 'Add' action button 
		Then  Alert message "Please enter all the fields" is displayed on top right of the application.



@ignore @web
 Scenario: 07 Test error message when Title is not entered
		Given The seller enters the following education data 
				| Country  | University | Title | Degree  | Graduation Year |
				| New Zela | Victiria   |       | 2 years | 2000            |                            
		When  clicks on 'Add' action button 
		Then  Alert message "Please enter all the fields" is displayed on top right of the application.


@ignore @web
 Scenario: 08 Test error message when Degree is not entered
		Given The seller enters the following education data 
				| Country    | University | Title | Degree | Graduation Year |
				| New Zeland | Victiria   | M.B.A |        | 2000            |                             
		When  clicks on 'Add' action button 
		Then  Alert message "Please enter all the fields" is displayed on top right of the application.



@ignore @web
 Scenario: 09 Test error message when Graduation Year is not entered
		Given The seller enters the following education data 
	        | Country    | University | Title | Degree | Graduation Year |
	        | New Zeland | Victiria   | M.B.A | 2Years |                 |               
       When  clicks on 'Add' action button 
       Then  Alert message "Please enter all the fields" is displayed on top right of the application.



@ignore @web
 Scenario: 10 Test error message when the same Country,University,Title,Degree and Graduation Year  is entered
		Given The seller enters the following education data 
	        | Country     | University | Title | Degree  | Graduation Year |
	        | New Zealand | Victoria   | M.B.A | 2 years | 2000            |                             
        When  clicks on 'Add' action button 
       Then  Alert message "Please enter all the fields" is displayed on top right of the application.


	   
@ignore @web
 Scenario: 11 Test listing Education
		
		When  the seller clicks on education tab 
		Then  education page should display the list of educations that were created


@ignore @web
 Scenario: 12 Test error message when Country, University,Title,Degree and Graduation year is not entered
		Given The seller do not enters the following education data 
			| Country | University | Title | Degree | Graduation Year |
			|         |            |       |        |                 |                              
       When  clicks on 'Add' action button 
       Then  Alert message "Please enter all the fields" is displayed on top right of the application.




















