using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Threading;

namespace MarsQA_1.SpecflowPages.Pages
{
    public static class ProfileEducationPage
    {
        public static void AddEducationFromExcelSheet()
        {
            // Find Xpath for Education tab

            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]")).Click();

            ExcelLibHelper.PopulateInCollection(@"C:\Saisree\Testing\Code\MarsQACode\MarsQA-1\SpecflowTests\Data\Education.xlsx", "Education");

            for (int i = 2; i <= 2; i++)
            {
                // Find xpath for AddNew action button
                Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div")).Click();

                // read the data from excel sheet
                var Countryexceldata = ExcelLibHelper.ReadData(i, "Country");
                var Universityexceldata = ExcelLibHelper.ReadData(i, "University");
                var Titleexceldata = ExcelLibHelper.ReadData(i, "Title");
                var Degreeexceldata = ExcelLibHelper.ReadData(i, "Degree");
                var GraduationYearexceldata = ExcelLibHelper.ReadData(i, "GraduationYear");

                // find xpath for universityfield and assign input parameter university
                Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input")).SendKeys(Universityexceldata);

                // find xpath for country and assign input parameter country
                // select the drop down list

                var country = Driver.driver.FindElement(By.Name("country"));

                //create select element object 
                var countryselectElement = new SelectElement(country);

                // select by text
                countryselectElement.SelectByText(Countryexceldata);

                // find xpath for title and assign input parameter title
                // select the drop down list

                var titleVar = Driver.driver.FindElement(By.Name("title"));

                //create select element object 
                var titleselectElement = new SelectElement(titleVar);

                // select by text
                titleselectElement.SelectByText(Titleexceldata);

                // find xpath for degreefield and assign input parameter degree
                Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input")).SendKeys(Degreeexceldata);

                // find xpath for graduationyear and assign input parameter graduationyear
                // select the drop down list

                var graduationyear = Driver.driver.FindElement(By.Name("yearOfGraduation"));

                //create select element object 
                var graduationyearselectElement = new SelectElement(graduationyear);

                // select by text
                graduationyearselectElement.SelectByText(GraduationYearexceldata);

                // find xpath for Add action button and click
                Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]")).Click();

                // IWebElement element = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(5)).Until(ExpectedConditions.ElementExists(By.XPath("//div[@class='ns-box-inner']")));
                Thread.Sleep(2000);

                //find xpath for sucess or failure message
                var alerttext = Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;

                // assert expected result = actual result
                Assert.AreEqual("Education has been added", alerttext);

                // xpath of html table
                var elemTable = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table"));

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

                        string CountryText = lstTdElem[0].Text;
                        string UniversityText = lstTdElem[1].Text;
                        string TitleText = lstTdElem[2].Text;
                        string DegreeText = lstTdElem[3].Text;
                        string GraduationYearText = lstTdElem[4].Text;
                        Assert.AreEqual(Countryexceldata, CountryText);
                        Assert.AreEqual(Universityexceldata, UniversityText);
                        Assert.AreEqual(Titleexceldata, TitleText);
                        Assert.AreEqual(Degreeexceldata, DegreeText);
                        Assert.AreEqual(GraduationYearexceldata, GraduationYearText);
                        Thread.Sleep(5000);
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

        public static void UpdateEducation()
        {
            // Find Xpath for Education tab

            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]")).Click();

            // Find xpath for update pen mark symbol 
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[1]/i")).Click();


            // find xpath for country and assign input parameter country

            IWebElement CountryElement = Driver.driver.FindElement(By.Name("country"));
            //create select element object
            var selectElement = new SelectElement(CountryElement);
            // select by text
            selectElement.SelectByText("India");



            //find xpath for universityfield and assign input parameter university
            var university = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[1]/div[1]/input"));
            university.Clear();
            university.SendKeys("JNTU");


            // find xpath for title and assign input parameter title
            // select the drop down list

            var title = Driver.driver.FindElement(By.Name("title"));

            //create select element object 
            var titleselectElement = new SelectElement(title);

            // select by text
            titleselectElement.SelectByText("B.Tech");

            // find xpath for degreefield and assign input parameter degree
            IWebElement DegreeElement = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[2]/input"));
            DegreeElement.Clear();
            DegreeElement.SendKeys("4Years");


            // find xpath for graduationyear and assign input parameter graduationyear
            // select the drop down list

            var graduationyear = Driver.driver.FindElement(By.Name("yearOfGraduation"));

            //create select element object 
            var graduationyearselectElement = new SelectElement(graduationyear);

            // select by text
            graduationyearselectElement.SelectByText("2021");


            //Xpath for update action buton
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[3]/input[1]")).Click();


            //Assertion

            Thread.Sleep(2000);

            //find xpath for sucess or failure message
            var alerttext = Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;

            // assert expected result = actual result
            Assert.AreEqual("Education as been updated", alerttext);

            // xpath of html table
            var elemTable = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table"));

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

                    string CountryText = lstTdElem[0].Text;
                    string UniversityText = lstTdElem[1].Text;
                    string TitleText = lstTdElem[2].Text;
                    string DegreeText = lstTdElem[3].Text;
                    string GraduationyearText = lstTdElem[4].Text;
                    Assert.AreEqual("India", CountryText);
                    Assert.AreEqual("JNTU", UniversityText);
                    Assert.AreEqual("B.Tech", TitleText);
                    Assert.AreEqual("4Years", DegreeText);
                    Assert.AreEqual("2021", GraduationyearText);
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

        public static void DeleteEducation()

        {
            // Find Xpath for Education tab

            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]")).Click();

            // Find xpath for delete/(cross) mark symbol 
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[2]/i")).Click();

            //Assertion

            Thread.Sleep(2000);

            //find xpath for sucess or failure message
            var alerttext = Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;

            // assert expected result = actual result
            Assert.AreEqual("Education entry successfully removed", alerttext);

        }








    }
}
