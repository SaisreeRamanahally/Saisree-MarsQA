using MarsQA_1.Helpers;
using OpenQA.Selenium;
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
        private static IWebElement PopUpMessage => Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));

        public void AddDescription()
        {

            // Find Xpath for Description
            DescriptionEditPen.Click();

            // Find Xpath for Description text area

            DescriptionTextArea.SendKeys(Description);


            // Find Xpath for save action button

            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button")).Click();

            //Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            Thread.Sleep(2000);

            SuccessOrFailureMessage = PopUpMessage.Text;

        }



    }
}
