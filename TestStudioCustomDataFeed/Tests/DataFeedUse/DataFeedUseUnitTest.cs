using System;
using System.Linq;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.TestTemplates;
using NUnit.Framework;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using ArtOfTest.WebAii.Controls.HtmlControls;

namespace TestStudioCustomDataFeed
{
    /// <summary>
    /// Summary description for DataFeedUseUnitTest
    /// </summary>
    [TestFixture]
    public class DataFeedUseUnitTest : BaseTest
    {
        List<User> userFeed;
        #region [Setup / TearDown]

        /// <summary>
        /// Initialization for each test.
        /// </summary>
        [SetUp]
        public void MyTestInitialize()
        {
            #region WebAii Initialization

            Settings settings = GetSettings();

            // Set preferred browser to FireFox:
            settings.Web.DefaultBrowser = BrowserType.FireFox;

            // Now call Initialize again with your updated settings object
            Initialize(settings, new TestContextWriteLine(Console.Out.WriteLine));

            #endregion
            //Load data feed
            userFeed = new List<User>();
            JArray feedArray = Utility.GetJSONArrayFromFile(@"Tests\DataFeedUse\DataFeed.json");
            for (int i = 0; i < feedArray.Count; i++)
            {
                JObject feedObject = feedArray.GetJObject(i);
                User user = new User
                {
                    FirstName = feedObject.GetString("FirstName"),
                    LastName = feedObject.GetString("LastName"),
                    Username = feedObject.GetString("Username"),
                    Password = feedObject.GetString("Password"),
                    IsAdmin = feedObject.GetBoolean("IsAdmin").Value
                };
                userFeed.Add(user);
            }
        }

        /// <summary>
        /// Clean up after each test.
        /// </summary>
        [TearDown]
        public void MyTestCleanUp()
        {
            //
            // Place any additional cleanup here
            //

            #region WebAii CleanUp

            // Shuts down WebAii manager and closes all browsers currently running
            this.CleanUp();

            #endregion
        }

        /// <summary>
        /// Called after all tests in this class are executed.
        /// </summary>
        [OneTimeTearDown]
        public void FixtureCleanup()
        {
            // This will shut down all browsers if
            // recycleBrowser is turned on. Else
            // will do nothing.
            ShutDown();
        }

        #endregion

        private Pages _pages;

        public Pages Pages
        {
            get
            {
                if (_pages == null)
                {
                    _pages = new Pages(Manager.Current);
                }
                return _pages;
            }
        }

        [Test()]
        public void DataFeedList()
        {
            foreach (var user in userFeed)
            {
                Manager.Log.WriteLine(user.FirstName + " " + user.LastName);
            }
        }

        [Test()]
        public void DataFeedUse()
        {
            User admin = userFeed.ElementAt(0);
            User newUser = userFeed.ElementAt(1);
            // Launch an instance of the browser
            Manager.LaunchNewBrowser();

            // Navigate to : 'http://localhost:3000'
            ActiveBrowser.NavigateTo("http://localhost:3000", true);

            // Click 'LogInButton'
            Pages.HttpLocalhost3000Projects.LogInButton.Click(false);

            // Coded Step From Test
            Pages.HttpLocalhost3000Projects.LogInDialogEmailTextbox.SetInputText(admin.Username);

            // Coded Step From Test
            Pages.HttpLocalhost3000Projects.LogInDialogPasswordTextbox.SetInputText(admin.Password);

            // Click 'LogInDialogSignInButton'
            Pages.HttpLocalhost3000Projects.LogInDialogSignInButton.Click(false);

            // Wait for element 'LogOutButton' 'is' visible.
            Pages.HttpLocalhost3000Projects.LogOutButton.Wait.ForCondition((a_0, a_1) => (((HtmlButton)(a_0)).IsVisible() == true), false, null, 30000);

            // Click 'AdminMenuLink'
            Pages.HttpLocalhost3000Projects.AdminMenuLink.Click(false);

            // Click 'ManageUsersLink'
            Pages.HttpLocalhost3000Projects.ManageUsersLink.Click(false);

            // Click 'NewUserButton'
            Pages.HttpLocalhost3000AdminUs.NewUserButton.Click(false);

            // Coded Step From Test
            Pages.HttpLocalhost3000AdminUs0.EmailTextbox.SetInputText(newUser.Username);

            // Coded Step From Test
            Pages.HttpLocalhost3000AdminUs0.LastNameTextbox.SetInputText(newUser.LastName);

            // Coded Step From Test
            Pages.HttpLocalhost3000AdminUs0.FirstNameTextbox.SetInputText(newUser.FirstName);

            // Coded Step From Test
            Pages.HttpLocalhost3000AdminUs0.PasswordTextbox.SetInputText(newUser.Password);

            // Coded Step From Test
            Pages.HttpLocalhost3000AdminUs0.RepeatPasswordTextbox.SetInputText(newUser.Password);

            // Check 'IsAdminCheckBox' to be 'True'
            Pages.HttpLocalhost3000AdminUs0.IsAdminCheckBox.Check(true, false, false);

            // Click 'SaveButton'
            Pages.HttpLocalhost3000AdminUs0.SaveButton.Click(false);

            // Wait for element 'UserCreationSuccessfulDiv' 'is' visible.
            Pages.HttpLocalhost3000AdminUs.UserCreationSuccessfulDiv.Wait.ForCondition((a_0, a_1) => (((HtmlDiv)(a_0)).IsVisible() == true), false, null, 30000);

            // Click 'LogOutButton'
            Pages.HttpLocalhost3000AdminUs.LogOutButton.Click(false);



        }
    }
}
