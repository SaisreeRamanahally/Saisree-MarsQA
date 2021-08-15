using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepsDefinition
{
    [Binding]
    public class AddCertificationSteps
    {
        ProfileCertificationPage ProfileCertificationPageobj = new ProfileCertificationPage();

       [Given(@"Seller enter Certificate as ""(.*)""")]
        public void GivenSellerEnterCertificateAs(string Certificate )
           
        {
            ProfileCertificationPageobj.CertificateOrAward = Certificate;
        }

        [Given(@"Seller enter CertificateFrom as ""(.*)""")]
        public void GivenSellerEnterCertificateFromAs(string certifiedfrom)
        {
            ProfileCertificationPageobj.CertifiedFrom = certifiedfrom;
        }

        [Given(@"select Year as ""(.*)""")]
        public void GivenSelectYearAs(int p0)
        {
            ProfileCertificationPageobj.Year = p0;

        }


        [When(@"Clicks on Add button on Addcertification page")]
        public void WhenClicksOnAddButtonOnAddcertificationPage()
        {
            ProfileCertificationPageobj.AddCertification();
        }
        [Then(@"Certificate should be added to the  profile\. The Alert message ""(.*)"" is displayed on top right of the application\.")]
        public void ThenCertificateShouldBeAddedToTheProfile_TheAlertMessageIsDisplayedOnTopRightOfTheApplication_(string sucessorfailuremessage)
        {
            Assert.AreEqual(sucessorfailuremessage, ProfileCertificationPageobj.CertificationMessage);
        }
        [Given(@"seller Updates Certificate as ""(.*)""")]
        public void GivenSellerUpdatesCertificateAs(string certificate)
        {
            ProfileCertificationPageobj.CertificateOrAward = certificate;
        }
        [Given(@"updates Certificate From as ""(.*)""")]
        public void GivenUpdatesCertificateFromAs(string from)
        {
            ProfileCertificationPageobj.CertifiedFrom = from;
        }
        [Given(@"select Certificate Year as ""(.*)""")]
        public void GivenSelectCertificateYearAs(int certificateyear)
        {
            ProfileCertificationPageobj.Year = certificateyear;
        }

        [When(@"clicks on Update button on UpdateCertification page")]
        public void WhenClicksOnUpdateButtonOnUpdateCertificationPage()
        {
            ProfileCertificationPageobj.UpdateCertification();
        }
        [Then(@"certification should be updated\. The alert message, ""(.*)"" will be displayed on top right of the application\.")]
        public void ThenCertificationShouldBeUpdated_TheAlertMessageWillBeDisplayedOnTopRightOfTheApplication_(string sucessorfailuremessage)
        {
            Assert.AreEqual(sucessorfailuremessage, ProfileCertificationPageobj.CertificationMessage);
        }
        [When(@"Seller select to delete Certification ""(.*)""")]
        public void WhenSellerSelectToDeleteCertification(string certification)
        {
            ProfileCertificationPageobj.CertificateOrAward = certification;
            ProfileCertificationPageobj.DeleteCertification();
        }
        [Then(@"Certification should be deleted\. The alert message, ""(.*)"" will be displayed on top right of the application\.")]
        public void ThenCertificationShouldBeDeleted_TheAlertMessageWillBeDisplayedOnTopRightOfTheApplication_(string sucessorfailuremessage)
        {
            Assert.AreEqual(sucessorfailuremessage, ProfileCertificationPageobj.CertificationMessage);
        }

    }
}
