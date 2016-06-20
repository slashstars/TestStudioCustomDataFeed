using System;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.TestTemplates;

using NUnit.Framework;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace TestStudioCustomDataFeed
{
    /// <summary>
    /// Summary description for DataFeedLoadUnitTest
    /// </summary>
    [TestFixture]
    public class DataFeedLoadUnitTest : BaseTest
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

            // Override the settings you want. For example:
            settings.Web.DefaultBrowser = BrowserType.FireFox;

            // Now call Initialize again with your updated settings object
            Initialize(settings, new TestContextWriteLine(Console.Out.WriteLine));

            #endregion

            //
            // Place any additional initialization here
            //
            userFeed = new List<User>();
            JArray feedArray = Utility.GetJSONArrayFromFile(@"Tests\DataFeedLoad\DataFeed.json");
            for (int i = 0; i < feedArray.Count; i++)
            {
                JObject feedObject = feedArray.GetJObject(i);
                User user = new User
                {
                    FirstName = feedObject.GetString("FirstName"),
                    LastName = feedObject.GetString("LastName"),
                    Username = feedObject.GetString("Username"),
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
        public void DataFeedLoad()
        {
            // Launch an instance of the browser
            Manager.LaunchNewBrowser();


            // Coded Step From Test
            JArray feedArray = Utility.GetJSONArrayFromFile(@"Tests\DataFeedLoad\DataFeed.json");
            for (int i = 0; i < feedArray.Count; i++)
            {
                JObject feedObject = feedArray.GetJObject(i);
                User user = new User
                {
                    FirstName = feedObject.GetString("FirstName"),
                    LastName = feedObject.GetString("LastName"),
                    Username = feedObject.GetString("Username"),
                    IsAdmin = feedObject.GetBoolean("IsAdmin").Value
                };
                userFeed.Add(user);
            }



            // Coded Step From Test
            foreach (var user in userFeed)
            {
                Manager.Log.WriteLine(user.FirstName + " " + user.LastName);
            }
        }
    }
}
