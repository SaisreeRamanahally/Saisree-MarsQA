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
    public static class ProfileCertificationPage
    {
        public static void AddCertificationFromExcelSheet()
        {
            // Find Xpath for Certification tab

            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]")).Click();

            ExcelLibHelper.PopulateInCollection(@"C:\Saisree\Testing\Code\MarsQACode\MarsQA-1\SpecflowTests\Data\Certification.xlsx", "Certification Sheet");

            for (int i = 2; i <= 2; i++)
            {
                // Find xpath for AddNew action button
                Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div")).Click();

                // read the data from excel sheet
                var Certificateexceldata = ExcelLibHelper.ReadData(i, "Certificate");
                var CertifiedFrom = ExcelLibHelper.ReadData(i, "Certified From");
                var Yearexceldata = ExcelLibHelper.ReadData(i, "Year");

                // find xpath for certificate or award field and assign input parameter university
                Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input")).SendKeys(Certificateexceldata);

                // find xpath for certified from field and assign input parameter university
                Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input")).SendKeys(CertifiedFrom);

                // find xpath for year and assign input parameter year
                // select the drop down list

                var year = Driver.driver.FindElement(By.Name("certificationYear"));

                //create select element object 
                var yearselectElement = new SelectElement(year);

                // select by text
                yearselectElement.SelectByText(Yearexceldata);

                // find xpath for Add action button and click
                Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]")).Click();

                //Assertion

                Thread.Sleep(2000);

                //find xpath for sucess or failure message
                var alerttext = Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;

                // assert expected result = actual result
                Assert.AreEqual("ISTQB has been added to your certification", alerttext);

                // xpath of html table
                var elemTable = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table"));

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

                        string CertificateText = lstTdElem[0].Text;
                        string FromText = lstTdElem[1].Text;
                        string YearText = lstTdElem[2].Text;

                        Assert.AreEqual(Certificateexceldata, CertificateText);
                        Assert.AreEqual(CertifiedFrom, FromText);
                        Assert.AreEqual(Yearexceldata, YearText);

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

        public static void UpdateCertification()
        {

            // Find Xpath for Certification tab

            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]")).Click();

            // Find xpath for update pen mark symbol 
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[1]/i")).Click();

            // find xpath for certificate or award field and assign input parameter university
            IWebElement certificateElement = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[1]/input"));
            certificateElement.Clear();
            certificateElement.SendKeys("TOFEL");

            // find xpath for certified from field and assign input parameter university
            IWebElement certifiedElement = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[2]/input"));
            certifiedElement.Clear();
            certifiedElement.SendKeys("Curam");

            // find xpath for year and assign input parameter year
            // select the drop down list

            var year = Driver.driver.FindElement(By.Name("certificationYear"));

            //create select element object 
            var yearselectElement = new SelectElement(year);

            // select by text
            yearselectElement.SelectByText("2006");

            //Xpath for update action buton
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/span/input[1]")).Click();




            //Assertion

            Thread.Sleep(2000);

            //find xpath for sucess or failure message
            var alerttext = Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;

            // assert expected result = actual result
            Assert.AreEqual("TOFEL has been updated to your certification", alerttext);

            // xpath of html table
            var elemTable = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table"));

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

                    string CertificateText = lstTdElem[0].Text;
                    string FromText = lstTdElem[1].Text;
                    string YearText = lstTdElem[2].Text;

                    Assert.AreEqual("TOFEL", CertificateText);
                    Assert.AreEqual("Curam", FromText);
                    Assert.AreEqual("2006", YearText);

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

        public static void DeleteCertification()

        {

            // Find Xpath for Certification tab

            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]")).Click();

            // Find xpath for delete/(cross) mark symbol 
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[2]/i")).Click();

            //Assertion

            Thread.Sleep(2000);

            //find xpath for sucess or failure message
            var alerttext = Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;

            // assert expected result = actual result
            Assert.AreEqual("TOFEL has been deleted from your certification", alerttext);

        }




    }



}