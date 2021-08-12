using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class AddProfileEducationSteps
    {
        [Given(@"the education data in excel sheet create education")]
        public void GivenTheEducationDataInExcelSheetCreateEducation()
        {
            MarsQA_1.SpecflowPages.Pages.ProfileEducationPage.AddEducationFromExcelSheet();
        }

        [Given(@"I able to update education details")]
        public void GivenIAbleToUpdateEducationDetails()
        {
            MarsQA_1.SpecflowPages.Pages.ProfileEducationPage.UpdateEducation();
        }

        [Given(@"I able to delete education details")]
        public void GivenIAbleToDeleteEducationDetails()
        {
            MarsQA_1.SpecflowPages.Pages.ProfileEducationPage.DeleteEducation();

        }


       


     }       
}
