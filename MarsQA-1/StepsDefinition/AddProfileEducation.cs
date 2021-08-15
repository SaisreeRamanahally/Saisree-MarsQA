using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepsDefinition
{
    [Binding]
    public class AddProfileEducationSteps
    {
        

        ProfileEducationPage profileEducationPageobj = new ProfileEducationPage();


        [Given(@"Seller enter UniversityName as ""(.*)""")]
        public void GivenSellerEnterUniversityNameAs(string universityname)
        {
            profileEducationPageobj.UniversityName = universityname;
        }

        [Given(@"Select CountryOfUniversity as ""(.*)""")]
        public void GivenSelectCountryOfUniversityAs(string country )
        {
                profileEducationPageobj.Country = country;

        }

        [Given(@"Select Title as ""(.*)""")]
        public void GivenSelectTitleAs(string title)
        {
                profileEducationPageobj.Title = title;
        }

        [Given(@"Enter Degree as ""(.*)""")]
        public void GivenEnterDegreeAs(string degree)
        {
                profileEducationPageobj.Degree = degree;
        }

        [Given(@"Select YearOfGreaduation as ""(.*)""")]
        public void GivenSelectYearOfGreaduationAs(int p0)
        {
            profileEducationPageobj.YearOfGraduation = p0;
        }

        [When(@"Clicks on Add button on AddEducation page")]
        public void WhenClicksOnAddButtonOnAddEducationPage()
        {
                profileEducationPageobj.AddEducation();
        }

        [Then(@"Education should be added to the  profile\. The Alert message ""(.*)"" is displayed on top right of the application\.")]
        public void ThenEducationShouldBeAddedToTheProfile_TheAlertMessageIsDisplayedOnTopRightOfTheApplication_(string popupboxmessage)
        {
                Assert.AreEqual(popupboxmessage, profileEducationPageobj.EducationMessage);
        }
        [Given(@"seller updates education as ""(.*)""")]
        public void GivenSellerUpdatesEducationAs(string education)
        {
            profileEducationPageobj.UniversityName = education;
        }
        [Given(@"updates CountryOfUniversity as ""(.*)""")]
        public void GivenUpdatesCountryOfUniversityAs(string country)
        {
            profileEducationPageobj.Country = country;
        }
        [Given(@"updates Title as ""(.*)""")]
        public void GivenUpdatesTitleAs(string title)
        {
            profileEducationPageobj.Title = title;
        }
        [Given(@"updates Degree as ""(.*)""")]
        public void GivenUpdatesDegreeAs(string degree)
        {
            profileEducationPageobj.Degree = degree;
        }
        [Given(@"updates YearOfGreaduation as ""(.*)""")]
        public void GivenUpdatesYearOfGreaduationAs(int year)
        {
            profileEducationPageobj.YearOfGraduation = year;
        }
        [When(@"clicks on Update button on Updateeducation page")]
        public void WhenClicksOnUpdateButtonOnUpdateeducationPage()
        {
            profileEducationPageobj.UpdateEducation();
        }
        [Then(@"Education should be updated\. The alert message, ""(.*)"" will be displayed on top right of the application\.")]
        public void ThenEducationShouldBeUpdated_TheAlertMessageWillBeDisplayedOnTopRightOfTheApplication_(string popupboxmessage)
        {
            Assert.AreEqual(popupboxmessage, profileEducationPageobj.EducationMessage);
        }


        [When(@"Seller select to delete Educaion ""(.*)""")]
        public void WhenSellerSelectToDeleteEducaion(string p0)
        {
            profileEducationPageobj.DeleteEducation();
        }

        [Then(@"Education should be deleted\. The alert message, ""(.*)"" will be displayed on top right of the application\.")]
        public void ThenEducationShouldBeDeleted_TheAlertMessageWillBeDisplayedOnTopRightOfTheApplication_(string popupboxmessage)
        {
            Assert.AreEqual(popupboxmessage, profileEducationPageobj.EducationMessage);
        }

    }


}

