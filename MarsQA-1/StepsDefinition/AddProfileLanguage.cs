using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepsDefinition
{
    [Binding]
    public class AddLanguageSteps
    {
        private readonly ScenarioContext _scenarioContext;

        MarsQA_1.Pages.ProfileLanguagePage ProfileLanguageObj = new Pages.ProfileLanguagePage();

        public AddLanguageSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

    
        [Given(@"seller enter language as ""(.*)""")]
        public void GivenSellerEnterLanguageAs(string Language)
        {
            ProfileLanguageObj.Language = Language;
        }

        [Given(@"select level as ""(.*)""")]
        public void GivenSelectLevelAs(string Level)
        {
            ProfileLanguageObj.Level = Level;
        }

        [When(@"clicks on Add action button")]
        public void WhenClicksOnAddActionButton()
        {
            ProfileLanguageObj.AddLanguage();
        }

        [Then(@"Language should be added to your profile\. The alert message, ""(.*)"" will be displayed on top right of the application\.")]
        public void ThenLanguageShouldBeAddedToYourProfile_TheAlertMessageWillBeDisplayedOnTopRightOfTheApplication_(string message)
        {
            // assert expected result = actual result
            Assert.AreEqual(message, ProfileLanguageObj.LanguageMessage);
        }

        [Given(@"seller updates language as ""(.*)""")]
        public void GivenSellerUpdatesLanguageAs(string Language)
        {
            ProfileLanguageObj.Language = Language;
        }

        [Given(@"updates level as ""(.*)""")]
        public void GivenUpdatesLevelAs(string Level)
        {
            ProfileLanguageObj.Level = Level;
        }

        [When(@"clicks on Update button")]
        public void WhenClicksOnUpdateButton()
        {
            ProfileLanguageObj.UpdateLanguage();
        }

        [Then(@"Language should be updated\. The alert message, ""(.*)"" will be displayed on top right of the application\.")]
        public void ThenLanguageShouldBeUpdated_TheAlertMessageWillBeDisplayedOnTopRightOfTheApplication_(string Message)
        {
            Assert.AreEqual(Message, ProfileLanguageObj.LanguageMessage);
        }

        [When(@"Seller select to delete language ""(.*)""")]
        public void WhenSellerSelectToDeleteLanguage(string Language)
        {
            ProfileLanguageObj.Language = Language;
            ProfileLanguageObj.DeleteLanguage();
        }

        [Then(@"Language should be deleted\. The alert message, ""(.*)"" will be displayed on top right of the application\.")]
        public void ThenLanguageShouldBeDeleted_TheAlertMessageWillBeDisplayedOnTopRightOfTheApplication_(string Message)
        {
            Assert.AreEqual(Message, ProfileLanguageObj.LanguageMessage);
        }


    }
}
