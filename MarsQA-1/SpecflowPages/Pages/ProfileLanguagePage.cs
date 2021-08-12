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
    public static class ProfileLanguage
    {
        public static object LangText { get; private set; }

        //public static object Wait { get; private set; }
        //public static object SeleniumExtras { get; private set; }

        public static void AddLanguage()
        {
            // Find xpath for language tab
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]")).Click();


            // Find xpath for AddNew action button
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div")).Click();

            // find xpath for add language and assign input parameter language            
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input")).SendKeys("English");


            // find xpath for level and assign input parameter level
            // select the drop down list
            var level = Driver.driver.FindElement(By.Name("level"));
            //create select element object 
            var selectElement = new SelectElement(level);


            // select by text
            selectElement.SelectByText("Basic");

            // find xpath for Add action button and click
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]")).Click();

            Thread.Sleep(2000);

            //Assertion

            //find xpath for sucess or failure message
            var alerttext = Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;

            // assert expected result = actual result
            Assert.AreEqual("English has been added to your languages", alerttext);

            // xpath of html table
            var elemTable = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table"));

            // Fetch all Row of the table
            List<IWebElement> lstTrElem = new List<IWebElement>(elemTable.FindElements(By.TagName("tr")));
            String strRowData = "";

            // Traverse each row
            foreach (var elemTr in lstTrElem)
            {
                // Fetch the columns from a particuler row
                List<IWebElement> lstTdElem = new List<IWebElement>(elemTr.FindElements(By.TagName("td")));
                if (lstTdElem.Count > 0)
                {
                    // Traverse each column
                    foreach (var elemTd in lstTdElem)
                    {
                        // "\t\t" is used for Tab Space between two Text
                        strRowData = strRowData + elemTd.Text + "\t\t";
                        Console.WriteLine(elemTd.Text);
                    }

                    string LangText = lstTdElem[0].Text;
                    string LevelText = lstTdElem[1].Text;
                    Assert.AreEqual("English", LangText);
                    Assert.AreEqual("Basic", LevelText);
                }
                else
                {
                    // To print the data into the console
                    Console.WriteLine("This is Header Row");
                    Console.WriteLine(lstTrElem[0].Text.Replace(" ", "\t\t"));
                }
                Console.WriteLine(strRowData);
                strRowData = String.Empty;
            }


        }

        public static void AddLanguageFromExcelSheet()
        {

            ExcelLibHelper.PopulateInCollection(@"C:\Saisree\Testing\Code\MarsQACode\MarsQA-1\SpecflowTests\Data\Data.xlsx", "Language");


            for (int i = 2; i <= 2; i++)
            {
                // Find xpath for AddNew action button
                Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div")).Click();

                // read the data from excel sheet
                var languageexceldata = ExcelLibHelper.ReadData(i, "Language");
                var Levelexceldata = ExcelLibHelper.ReadData(i, "Level");

                // xpath for Addlanguage
                Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input")).SendKeys(languageexceldata);

                // find xpath for level and assign input parameter level
                // select the drop down list
                var level = Driver.driver.FindElement(By.Name("level"));
                //create select element object 
                var selectElement = new SelectElement(level);


                // select by text
                selectElement.SelectByText(Levelexceldata);



                // find xpath for Add action button and click
                Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]")).Click();

                Thread.Sleep(2000);

                //Assertion or validate or validation or assert
                //find xpath for sucess or failure message
                var alerttext = Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;

                // assert expected result = actual result
                Assert.AreEqual("French has been added to your languages", alerttext);

                // xpath of html table
                var elemTable = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table"));

                // Fetch all Row of the table
                List<IWebElement> lstTrElem = new List<IWebElement>(elemTable.FindElements(By.TagName("tr")));
                String strRowData = "";

                // Traverse each row
                foreach (var elemTr in lstTrElem)
                {
                    // Fetch the columns from a particuler row
                    List<IWebElement> lstTdElem = new List<IWebElement>(elemTr.FindElements(By.TagName("td")));
                    if (lstTdElem.Count > 0)
                    {
                        // Traverse each column
                        foreach (var elemTd in lstTdElem)
                        {
                            // "\t\t" is used for Tab Space between two Text
                            strRowData = strRowData + elemTd.Text + "\t\t";
                            Console.WriteLine(elemTd.Text);
                        }

                        string LangText = lstTdElem[0].Text;
                        string LevelText = lstTdElem[1].Text;
                        Assert.AreEqual(languageexceldata, LangText);
                        Assert.AreEqual(Levelexceldata, LevelText);
                    }
                    else
                    {
                        // To print the data into the console
                        Console.WriteLine("This is Header Row");
                        Console.WriteLine(lstTrElem[0].Text.Replace(" ", "\t\t"));
                    }
                    Console.WriteLine(strRowData);
                    strRowData = String.Empty;



                }
            }
        }

        //Update

        public static void UpdateLanguage()
        {
            // Find xpath for update pen mark symbol 
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i")).Click();

            //Xpath for Add Language text field
            IWebElement languageElement = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
            languageElement.Clear();
            languageElement.SendKeys("Maori");



            // Xpath for level
            var level = Driver.driver.FindElement(By.Name("level"));
            //create select element object 
            var selectElement = new SelectElement(level);


            // select by text
            selectElement.SelectByText("Fluent");


            // find xpath for update action button and click
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]")).Click();

            //Assertion

            Thread.Sleep(2000);

            //find xpath for sucess or failure message
            var alerttext = Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;

            // assert expected result = actual result
            Assert.AreEqual("Maori has been updated to your languages", alerttext);

            // xpath of html table
            var elemTable = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody"));

            // Fetch all Row of the table
            List<IWebElement> lstTrElem = new List<IWebElement>(elemTable.FindElements(By.TagName("tr")));
            String strRowData = "";

            // Traverse each row
            foreach (var elemTr in lstTrElem)
            {
                // Fetch the columns from a particuler row
                List<IWebElement> lstTdElem = new List<IWebElement>(elemTr.FindElements(By.TagName("td")));
                if (lstTdElem.Count > 0)
                {
                    // Traverse each column
                    foreach (var elemTd in lstTdElem)
                    {
                        // "\t\t" is used for Tab Space between two Text
                        strRowData = strRowData + elemTd.Text + "\t\t";
                        Console.WriteLine(elemTd.Text);
                    }

                    string LangText = lstTdElem[0].Text;
                    string LevelText = lstTdElem[1].Text;
                    Assert.AreEqual("Maori", LangText);
                    Assert.AreEqual("Fluent", LevelText);
                }
                else
                {
                    // To print the data into the console
                    Console.WriteLine("This is Header Row");
                    Console.WriteLine(lstTrElem[0].Text.Replace(" ", "\t\t"));
                }
                    Console.WriteLine(strRowData);
                    strRowData = String.Empty;



            }


        }

        // Deleate a updated record

        public static void DeleteLanguage()

        {
            // Find xpath for delete/(cross) mark symbol 
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i")).Click();

            //Assertion

            Thread.Sleep(2000);

            //find xpath for sucess or failure message
            var alerttext = Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;

            // assert expected result = actual result
            Assert.AreEqual("Maori has been deleted from your languages", alerttext);

        }
    } 
}
                        