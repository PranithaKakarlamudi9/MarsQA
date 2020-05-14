using System;
using SkillSwap.Helpers;
using SkillSwap.Pages;
using TechTalk.SpecFlow;

namespace SkillSwap.StepDefiniton
{
    [Binding]
    //<summary>
    // This is Profile step definiton calss 
    //</summary>
    public class ProfileSteps 
    {

        //creating an object of class profilepage to access all profile methods and fields
        ProfilePage ppobj = new ProfilePage();

        //<summary>
        //user is in profile page to add details
        //</summary>
        [Given(@"User is in profile page")]
        public void GivenUserIsInProfilePage()
        {
            ppobj.ValidateUserInProfilePage(CommonDriver.driver);
        }


        //<summary>
        //user creates education record
        //</summary>
        [When(@"user adds education details")]
        public void WhenUserAddsEducationDetails()
        {
            ppobj.AddEducation(CommonDriver.driver);
        }

        //<summary>
        //user successfully creates education record
        //</summary>

        [Then(@"education details successfully added")]
        public void ThenEducationDetailsSuccessfullyAdded()
        {
            ppobj.ValidateAdd(CommonDriver.driver);

        }

        //<summary>
        //user is in profie page and clicks on educationtab to view details
        //</summary>

        [Given(@"user clicks on education tab to view details")]
        public void GivenUserClicksOnEducationTabToViewDetails()
        {
            ppobj.ClickOnEducationTab(CommonDriver.driver);
        }

        //<summary>
        //user updates education record
        //</summary>
        [When(@"user edits education details")]
        public void WhenUserEditsEducationDetails()
        {
            ppobj.EditEducationDetails(CommonDriver.driver);
        }

        //<summary>
        //user sucessfully updates education record
        //</summary>
        [Then(@"education details updated successfully")]
        public void ThenEducationDetailsUpdatedSuccessfully()
        {
            ppobj.ValidateEditSuccess(CommonDriver.driver);
        }

        //<summary>
        //user deletes education record
        //</summary>
        [When(@"user deletes education record")]
        public void WhenUserDeletesEducationRecord()
        {
            ppobj.DeleteEducation(CommonDriver.driver);
        }

        //<summary>
        //user successfully deletes education record
        //</summary>
        [Then(@"education record deleted successfully")]
        public void ThenEducationRecordDeletedSuccessfully()
        {
            ppobj.ValidateDeleteSuccess(CommonDriver.driver);
        }


    }
}
