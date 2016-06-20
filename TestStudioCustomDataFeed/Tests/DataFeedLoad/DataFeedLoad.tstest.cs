using Telerik.WebAii.Controls.Xaml;
using Telerik.WebAii.Controls.Html;
using Telerik.TestingFramework.Controls.KendoUI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts;
using ArtOfTest.WebAii.Design;
using ArtOfTest.WebAii.Design.Execution;
using ArtOfTest.WebAii.ObjectModel;
using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.Silverlight.UI;
using Newtonsoft.Json.Linq;

namespace TestStudioCustomDataFeed.Tests.DataFeedLoad
{

    public class DataFeedLoad : BaseWebAiiTest
    {
        #region [ Dynamic Pages Reference ]

        private Pages _pages;

        /// <summary>
        /// Gets the Pages object that has references
        /// to all the elements, frames or regions
        /// in this project.
        /// </summary>
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

        List<User> userFeed = new List<User>();

        [CodedStep(@"Get feed data.")]
        public void GetFeedData()
        {
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

        [CodedStep(@"Log feed data.")]
        public void LogFeedData()
        {
            foreach (var user in userFeed)
            {
                Manager.Log.WriteLine(user.FirstName + " " + user.LastName);
            }
        }

        #endregion

        // Add your test methods here...
    }
}
