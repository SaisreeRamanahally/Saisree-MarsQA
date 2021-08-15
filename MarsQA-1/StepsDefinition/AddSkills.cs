using MarsQA_1.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepsDefinition
{

    [Binding]
        public class AddSkillsSteps
    {
        ProfileSkillsPage ProfileSkillsPageobj = new ProfileSkillsPage();

        [Given(@"seller enter skill as ""(.*)""")]
        public void GivenSellerEnterSkillAs(string skill)
        {
            ProfileSkillsPageobj.Skill = skill;
        }

        [Given(@"select skill level as ""(.*)""")]
        public void GivenSelectSkillLevelAs(string Level)
        {
            ProfileSkillsPageobj.Level = Level;
        }

        [When(@"clicks on Add button on Addskill page")]
        public void WhenClicksOnAddButtonOnAddskillPage()
        {
            ProfileSkillsPageobj.AddSkills();
        }


        [Then(@"Skill should be added to the  profile\. The alert message, ""(.*)"" will be displayed on top right of the application\.")]
        public void ThenSkillShouldBeAddedToTheProfile_TheAlertMessageWillBeDisplayedOnTopRightOfTheApplication_(string expectedvalue)
        {
            Assert.AreEqual(expectedvalue, ProfileSkillsPageobj.SkillMessage);
        }


        [Given(@"seller Updates skill as ""(.*)""")]
        public void GivenSellerUpdatesSkillAs(string skill)
        {
            ProfileSkillsPageobj.Skill = skill;
        }

        [Given(@"updates skill level as ""(.*)""")]
        public void GivenUpdatesSkillLevelAs(string level)
        {
            ProfileSkillsPageobj.Level = level;
        }

        [When(@"clicks on Update button on Updateskill page")]
        public void WhenClicksOnUpdateButtonOnUpdateskillPage()
        {
            ProfileSkillsPageobj.UpdateSkill();
        }
        [Then(@"Skill should be updated\. The alert message, ""(.*)"" will be displayed on top right of the application\.")]
        public void ThenSkillShouldBeUpdated_TheAlertMessageWillBeDisplayedOnTopRightOfTheApplication_(string expectedresult)
        {
            Assert.AreEqual(expectedresult, ProfileSkillsPageobj.SkillMessage);
        }

        [When(@"Seller select to delete Skill ""(.*)""")]
        public void WhenSellerSelectToDeleteSkill(string skill)
        {
            ProfileSkillsPageobj.Skill = skill;
            ProfileSkillsPageobj.DeleteSkill();

        }

        [Then(@"Skill should be deleted\. The alert message,""(.*)"" will be displayed on top right of the application\.")]
        public void ThenSkillShouldBeDeleted_TheAlertMessageWillBeDisplayedOnTopRightOfTheApplication_(string ExpectedResult)
        {
            Assert.AreEqual(ExpectedResult, ProfileSkillsPageobj.SkillMessage);
        }

    }


}
