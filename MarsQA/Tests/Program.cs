using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SkillSwap.Helpers;
using SkillSwap.Pages;
using TechTalk.SpecFlow;

namespace MarsQA
{
    [Binding]
    //<summary>
    //This class has before scenario method which runs before every scenario is tested.
    //This class has after scenario method which runs after every scenario is tested.
    //</summary>
    class Program : CommonDriver
    {
        static void Main(string[] args)
        {

        }
        [BeforeScenario]
        //<summary>
        //this setup method runs before every scenario is run
        //</summary>
        public void SetUp()
        {
            //in this setup driver navigates to website and logs into website before every scenario is tested
            Intialise();
            LoginPage logInObj = new LoginPage();
            logInObj.LogIn(CommonDriver.driver);

        }
        [AfterScenario]
        //<summary>
        //This method closes driver after test execution
        //</summary>
        public void TearDown()
        {
            //close browser after running each scenario
            driver.Close();
        }

    }
}


