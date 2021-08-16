using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    public class DescriptionPages
    {
        public string Description { get; set; }
        public string SuccessOrFailureMessage { get; set; }

        private static IWebElement DescriptionEditPen => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));
        private static IWebElement DescriptionTextArea => Driver.driver.FindElement(By.Name("value"));

        private static string SucessOrFailureXpath = "//div[@class='ns-box-inner']";

        private static IWebElement PopUpMessage => Driver.driver.FindElement(By.XPath(SucessOrFailureXpath));

        public void AddDescription()
        {

            // Find Xpath for Description
            DescriptionEditPen.Click();

            // Find Xpath for Description text area

            DescriptionTextArea.SendKeys(Description);


            // Find Xpath for save action button

            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button")).Click();

            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementExists(By.XPath(SucessOrFailureXpath)));

            SuccessOrFailureMessage = PopUpMessage.Text;

        }



    }
}
