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
    public class ProfileLanguagePage
    {
 
        public string Language { get; set; }
        public string Level { get; set; }
        public string LanguageMessage { get; set; }

        // Add Language Page web elements
        private static IWebElement LanguageTab => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
        private static IWebElement AddNewActionButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
        private static IWebElement LanguageTextField => Driver.driver.FindElement(By.Name("name"));
        private static IWebElement LevelSelectElement => Driver.driver.FindElement(By.Name("level"));
        private static IWebElement AddActionButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));

        private static string SucessOrFailureXpath = "//div[@class='ns-box-inner']";
        // common
        private static IWebElement SucessOrFailure => Driver.driver.FindElement(By.XPath(SucessOrFailureXpath));

        public void AddLanguage()
        {
            // click on language tab
            LanguageTab.Click();


            // click AddNew action button
            AddNewActionButton.Click();

            // assign the input language            
            LanguageTextField.SendKeys(Language);


            // find xpath for level and assign input parameter level
            // select the drop down list
            //create select element object 
            var selectElement = new SelectElement(LevelSelectElement);

            // select by text
            selectElement.SelectByText(Level);

            // click Add action button
            AddActionButton.Click();

            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementExists(By.XPath(SucessOrFailureXpath)));

            

            //read sucess or failure message
            LanguageMessage = SucessOrFailure.Text;

        }

        //Update

        public void UpdateLanguage()
        {

            // click on edit pen
            IWebElement EditButtonPen = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
            EditButtonPen.Click();

            // update button web element
            IWebElement UpdateButton = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));



            // clear and update the data
            LanguageTextField.Clear();
            LanguageTextField.SendKeys(Language);

            //create select element object 
            var selectElement = new SelectElement(LevelSelectElement);

            // select by text
            selectElement.SelectByText(Level);

            // Click the update button
            UpdateButton.Click();

            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementExists(By.XPath(SucessOrFailureXpath)));

            //read sucess or failure message
            LanguageMessage = SucessOrFailure.Text;

        }

        // Deleate a updated record
        public void DeleteLanguage()
        {
            // Find xpath for delete/(cross) mark symbol 
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i")).Click();

            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementExists(By.XPath(SucessOrFailureXpath)));

            //read sucess or failure message
            LanguageMessage = SucessOrFailure.Text;

        }
    } 
}
                        