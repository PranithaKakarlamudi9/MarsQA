using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SkillSwap.Helpers;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;



namespace SkillSwap.Pages
{
    //<summary>
    //Represents user profile
    //User can create,edit and delete his profile details 
    //</summary>
    class ProfilePage
    {
        //<summary>
        //creates education record
        //This method validates if user in profile page
        //</summary>
        public void ValidateUserInProfilePage(IWebDriver driver)
        {   
            //validating by profile page url
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(100));
            wait.Until(ExpectedConditions.UrlToBe("http://192.168.99.100:5000/Account/Profile"));
            String actualTitle = driver.Url;
            String expectedTitle = "http://192.168.99.100:5000/Account/Profile";
            Assert.AreEqual(actualTitle, expectedTitle);
        }


        //<summary>
        //this method is used to add all education details in profile page
        //</summary>
        public void AddEducation(IWebDriver driver)
        {
            //clicks on education tab
            driver.FindElement(By.XPath("//a[@class='item'][contains(text(),'Education')]")).Click();

            //clicks on AddNew button
            driver.FindElement(By.XPath("//div[@id='account-profile-section']/descendant::section[2]/child::div/descendant::div[2]/child::div[3]/form/child::div[4]/descendant::div[6]/table/thead/tr/th[6]/div")).Click();

            //enter University name
            driver.FindElement(By.XPath("//input[@name ='instituteName']")).SendKeys("UNSW");

            //selects country of university from Country of colleage/University dropdown
            IWebElement countryElement = driver.FindElement(By.XPath("//select[@name='country']"));
            SelectElement country = new SelectElement(countryElement);
            country.SelectByValue("Australia");

            //selects "Title".
            IWebElement titleElement = driver.FindElement(By.XPath("//select[@name='title']"));
            SelectElement title = new SelectElement(titleElement);
            title.SelectByValue("B.Sc");

            //enters degree in "Degree" textbox
            driver.FindElement(By.XPath("//input[@name='degree']")).SendKeys("Information Technology");

            //slects graduation year from "Year of Graduation" dropdown
            IWebElement yearElement = driver.FindElement(By.XPath("//select[@name='yearOfGraduation']"));
            SelectElement year = new SelectElement(yearElement);
            year.SelectByValue("2016");

            //clicks on add to create education record with above details
            driver.FindElement(By.XPath("//input[@class='ui teal button ']")).Click();

        }


        //<summary>
        //Vlidating if Education details got added in the user profile
        //</summary>
        public void ValidateAdd(IWebDriver driver)
        {
            // //validating Add by getting confirmation message

            Thread.Sleep(1000);
            String addMessage = driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']/div")).Text;
            String expectedAddMessage = "Education has been added";
            Assert.AreEqual(addMessage, expectedAddMessage);
        }


        //<summary>
        //User updates education details
        //</summary>
        public void ClickOnEducationTab(IWebDriver driver)
        {
            //validating user is in profile page
            ValidateUserInProfilePage(driver);

            //clicks on education tab
            driver.FindElement(By.XPath("//a[@class='item'][contains(text(),'Education')]")).Click();
        }


        //</summary>
        //this method edits education details
        //</summary>
        public void EditEducationDetails(IWebDriver driver)
        {
            Thread.Sleep(5000);
            //cheking for above added record and user can view it
            String actualData = driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']/descendant::div[@class='twelve wide column scrollTable']/div/table/tbody[1]/tr/td[3]")).Text;

            if ((actualData != null) && (actualData == "B.Sc"))
            {
                driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']/descendant::div[@class='twelve wide column scrollTable']/div/table/tbody[1]/tr/td[6]/span[1]")).Click();
            }

            //edit graduation year from "Year of Graduation" dropdown
            IWebElement yearElement = driver.FindElement(By.XPath("//select[@name='yearOfGraduation']"));
            SelectElement year = new SelectElement(yearElement);
            year.SelectByValue("2018");

            //clicks on update button to save changes
            driver.FindElement(By.XPath("//input[@value='Update']")).Click();
        }



        //<summary>
        //verifying if education detailed edited successfully
        //</summary>
        public void ValidateEditSuccess(IWebDriver driver)
        {
            //validating edit by getting confirmation message
            Thread.Sleep(1000);
            String editMessage = driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']/div")).Text;
            String expectedEditMessage = "Education as been updated";
            Assert.AreEqual(editMessage, expectedEditMessage);
        }


        //<summary>
        //user delets record
        //</summary>
        public void DeleteEducation(IWebDriver driver)
        {
            Thread.Sleep(5000);
            //cheking for above added record and user can view it
            String actual = driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']/descendant::div[@class='twelve wide column scrollTable']/div/table/tbody[1]/tr/td[3]")).Text;
            if ((actual != null) && (actual == "B.Sc"))
            {
                driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']/descendant::div[@class='twelve wide column scrollTable']/div/table/tbody[1]/tr/td[6]/span[2]")).Click();
            }
        }


        //<summary>
        // validate succesfull delete
        //</summary>
        public void ValidateDeleteSuccess(IWebDriver driver)
        {
            //validating delete by getting confirmation message
            Thread.Sleep(1000);
            String deleteMessage = driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']/div")).Text;
            String expectedDeleteMessage = "Education entry Successfully removed";
            Assert.AreEqual(deleteMessage, expectedDeleteMessage);


        }

    }
}
