using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepsDefinition
{
    [Binding]
    public class DescriptionPages
    {
        MarsQA_1.SpecflowPages.Pages.DescriptionPages DescriptionPagesObj = new MarsQA_1.SpecflowPages.Pages.DescriptionPages();

        [Given(@"the Description as ""(.*)""")]
        public void GivenTheDescriptionAs(string Description)
        {
            DescriptionPagesObj.Description = Description;
        }

        [When(@"seller click on Save button")]
        public void WhenSellerClickOnSaveButton()
        {
            DescriptionPagesObj.AddDescription();
        }

        [Then(@"the description is saved and the message ""(.*)"" will be displayed on top right of the application\.")]
        public void ThenTheDescriptionIsSavedAndTheMessageWillBeDisplayedOnTopRightOfTheApplication_(string expectedResult)
        {
            Assert.AreEqual(expectedResult, DescriptionPagesObj.SuccessOrFailureMessage);
        }

    }


}
