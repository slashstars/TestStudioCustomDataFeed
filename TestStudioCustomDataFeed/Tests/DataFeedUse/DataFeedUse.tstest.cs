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

namespace TestStudioCustomDataFeed.Tests.DataFeedUse
{

    public class DataFeedUse : BaseWebAiiTest
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

        [CodedStep(@"Enter text 'admin@abc.com' in 'LogInDialogEmailTextbox'")]
        public void EnterLogInEmailTextbox()
        {
            Pages.HttpLocalhost3000Projects.LogInDialogEmailTextbox.SetInputText("admin@abc.com");
        }

        [CodedStep(@"Enter text 'changeme' in 'LogInDialogPasswordTextbox'")]
        public void EnterLogInDialogPasswordTextbox()
        {
            Pages.HttpLocalhost3000Projects.LogInDialogPasswordTextbox.SetInputText("changeme");
        }

        [CodedStep(@"Enter text 'jane.doe@email.com' in 'EmailTextbox'")]
        public void EnterEmailTextbox()
        {
            Pages.HttpLocalhost3000AdminUs0.EmailTextbox.SetInputText("jane.doe@email.com");
        }

        [CodedStep(@"Enter text 'Doe' in 'LastNameTextbox'")]
        public void EnterLastNameTextbox()
        {
            Pages.HttpLocalhost3000AdminUs0.LastNameTextbox.SetInputText("Doe");
        }

        [CodedStep(@"Enter text 'Jane' in 'FirstNameTextbox'")]
        public void EnterFirstNameTextbox()
        {
            Pages.HttpLocalhost3000AdminUs0.FirstNameTextbox.SetInputText("Jane");
        }

        [CodedStep(@"Enter text '1234567890' in 'PasswordTextbox'")]
        public void EnterPasswordTextbox()
        {
            Pages.HttpLocalhost3000AdminUs0.PasswordTextbox.SetInputText("1234567890");
        }

        [CodedStep(@"Enter text '1234567890' in 'RepeatPasswordTextbox'")]
        public void EnterRepeatPasswordTextbox()
        {
            Pages.HttpLocalhost3000AdminUs0.RepeatPasswordTextbox.SetInputText("1234567890");
        }
    

        #endregion

        // Add your test methods here...
    }
}
