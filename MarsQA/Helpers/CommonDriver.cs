using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SkillSwap.Helpers
{
    class CommonDriver
    {
        //<summary>
        // CommonDriver class is used to define and initialise driver 
        // intialising driver as a global variable
        //<summary>

        public static IWebDriver driver { get; set; }

        //In this method intialising driver object with chrome driver.

        public void Intialise()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }
        //<summary>
        //This method closes driver after test runs
        //</summary>
        public void Close()
        {
            driver.Quit();
        }

        public void Wait()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }






    }
}
