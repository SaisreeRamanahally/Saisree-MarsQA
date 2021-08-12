using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class AddCertificationSteps
    {
        [Given(@"the certification data in excel sheet create certification")]
        public void GivenTheCertificationDataInExcelSheetCreateCertification()
        {
            MarsQA_1.SpecflowPages.Pages.ProfileCertificationPage.AddCertificationFromExcelSheet();
        }

        [Given(@"I able to update Certification details")]
        public void GivenIAbleToUpdateCertificationDetails()
        {
            MarsQA_1.SpecflowPages.Pages.ProfileCertificationPage.UpdateCertification();
        }

        [Given(@"I able to delete Certification details")]
        public void GivenIAbleToDeleteCertificationDetails()
        {
            MarsQA_1.SpecflowPages.Pages.ProfileCertificationPage.DeleteCertification();
        }


    }
}
