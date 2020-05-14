using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;

namespace SkillSwap.Pages
{
    //<summary>
    //Represents login class 
    //</summary>
    class LoginPage
    {
        
        //<summary>
        //user navigates to homepage and successfully logs into website 
        //</summary>
        public void LogIn(IWebDriver driver)
        {
            //launching browser and navigating to url
            driver.Navigate().GoToUrl("http://192.168.99.100:5000/Home");

            //user clicks on SignIn button
            driver.FindElement(By.LinkText("Sign In")).Click();

            //user enters valid username
            driver.FindElement(By.Name("email")).SendKeys("pranitha.mvp@gmail.com");

            //user enters valid password
            driver.FindElement(By.Name("password")).SendKeys("May@2020");

            //user clicks on login button
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button")).Click();
        }


    }
}
