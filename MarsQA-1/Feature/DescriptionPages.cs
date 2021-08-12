using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class DescriptionSteps
    {
        [Given(@"the description data in excel sheet create description")]
        public void GivenTheDescriptionDataInExcelSheetCreateDescription()
        {
            MarsQA_1.SpecflowPages.Pages.DescriptionPages.AddDescription();
        }
    }
}
