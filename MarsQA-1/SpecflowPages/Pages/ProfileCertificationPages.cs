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

namespace MarsQA_1.SpecflowPages.Pages
{
    public class ProfileCertificationPage
    {
        public string CertificateOrAward { get; set; }
        public string CertifiedFrom { get; set; }
        public int Year { get; set; }
        public string CertificationMessage { get; set; }

        private static IWebElement CertificationsTab => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
        private static IWebElement AddNewButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
        private static IWebElement CertifiedTextField => Driver.driver.FindElement(By.Name("certificationName"));
        private static IWebElement CertifiedFromTextField => Driver.driver.FindElement(By.Name("certificationFrom"));
        private static IWebElement SelectYear => Driver.driver.FindElement(By.Name("certificationYear"));
        private static IWebElement AddButtonClick => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));

        private static string SucessOrFailureXpath = "//div[@class='ns-box-inner']";

        private static IWebElement PopUpMessage => Driver.driver.FindElement(By.XPath(SucessOrFailureXpath));

        public void AddCertification()
     {
            CertificationsTab.Click();
            AddNewButton.Click();
            CertifiedTextField.SendKeys(CertificateOrAward);
            CertifiedFromTextField.SendKeys(CertifiedFrom);

            //create select element object 
            var yearselectElement = new SelectElement(SelectYear);

            // select by text
            yearselectElement.SelectByText(Year.ToString());

            AddButtonClick.Click();

            // WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(10));
            // wait.Until(ExpectedConditions.ElementExists(By.XPath(SucessOrFailureXpath)));

            Thread.Sleep(2000);

            CertificationMessage = PopUpMessage.Text;
     }
         
        //Update

    public  void UpdateCertification()
    {
        CertificationsTab.Click();

        // Find xpath for update pen mark symbol 
        Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[1]/i")).Click();

        CertifiedTextField.Clear();
        CertifiedTextField.SendKeys(CertificateOrAward);

        CertifiedFromTextField.Clear();
        CertifiedFromTextField.SendKeys(CertifiedFrom);

        //create select element object 
        var yearselectElement = new SelectElement(SelectYear);

        // select by text
        yearselectElement.SelectByText(Year.ToString());

        //Xpath for update action buton
        Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/span/input[1]")).Click();


            //WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(10));
            // wait.Until(ExpectedConditions.ElementExists(By.XPath(SucessOrFailureXpath)));

            Thread.Sleep(2000);

            //Assertion
            CertificationMessage = PopUpMessage.Text;
    }

    // Deleate a updated record
    public void DeleteCertification()

    {

            CertificationsTab.Click();
            // Find xpath for delete/(cross) mark symbol 
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[2]/i")).Click();


            // WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(10));
            // wait.Until(ExpectedConditions.ElementExists(By.XPath(SucessOrFailureXpath)));

            Thread.Sleep(2000);

            //Assertion
            CertificationMessage = PopUpMessage.Text;

        }




    }



}