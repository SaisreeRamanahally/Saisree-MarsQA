using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class AddLanguageSteps
    {

        [Given(@"I able to add language to the profile")]
        public void GivenIAbleToAddLanguageToTheProfile()
        {
            // MarsQA_1.Pages.ProfileLanguage.AddLanguage();
            // Do nothig
        }

        [Given(@"the language data in excel sheet create language")]
        public void GivenTheLanguageDataInExcelSheetCreateLanguage()
        {
            MarsQA_1.Pages.ProfileLanguage.AddLanguageFromExcelSheet();
}
        [Given(@"I able to update language details")]
        public void GivenIAbleToUpdateLanguageDetails()
        {
            MarsQA_1.Pages.ProfileLanguage.UpdateLanguage();
        }


        
        [Given(@"I able to delete language details")]
        public void GivenIAbleToDeleteLanguageDetails()
        {
            MarsQA_1.Pages.ProfileLanguage.DeleteLanguage();
        }




    }
}
