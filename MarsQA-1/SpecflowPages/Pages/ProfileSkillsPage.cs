using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.Pages
{
    public  class ProfileSkillsPage
    {
        public string Skill { get; set; }
        public string Level { get; set; }
        public string SkillMessage { get; set; }

        private static IWebElement SkillTab => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
        private static IWebElement AddNewButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
        private static IWebElement SkillTextBox => Driver.driver.FindElement(By.Name("name"));
        private static IWebElement LevelSelectElement => Driver.driver.FindElement(By.Name("level"));
        private static IWebElement AddButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
        private static IWebElement SucessOrFailure => Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));

        public void AddSkills()
        {
         
            SkillTab.Click();
                       
            AddNewButton.Click();
                       
            SkillTextBox.SendKeys(Skill);

            //create select element object 
            var selectElement = new SelectElement(LevelSelectElement);

            // select by text
            selectElement.SelectByText(Level);                      

            AddButton.Click();

            //Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            Thread.Sleep(2000);

            SkillMessage = SucessOrFailure.Text;    

        }


        //update

        public void UpdateSkill()
        {
            SkillTab.Click();
            // Find xpath for update (pen) mark symbol 
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i")).Click();

            SkillTextBox.Clear();
            SkillTextBox.SendKeys(Skill);
                       
            //create select element object 
            var selectElement = new SelectElement(LevelSelectElement);

            // select by text
            selectElement.SelectByText(Level);

                        // find xpath for update action button and click
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]")).Click();

            //Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            Thread.Sleep(2000);

            //Assertion
            SkillMessage = SucessOrFailure.Text;

          
        }
        // Deleate a updated record

        public  void DeleteSkill()

        {


            SkillTab.Click();

            // Find xpath for delete/(cross) mark symbol 
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i")).Click();

            //Assertion

            //Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            Thread.Sleep(2000);
            SkillMessage = SucessOrFailure.Text;



        }

    }
}