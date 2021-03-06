//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestStudioCustomDataFeed
{
    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.ObjectModel;
    using ArtOfTest.WebAii.TestAttributes;
    using ArtOfTest.WebAii.TestTemplates;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    
    public class Pages
    {
        private Manager _manager;
        public Pages(Manager manager)
        {
            _manager = manager;
        }
        /// <summary>
        /// Page : http://localhost:3000/projectsinfo 
        /// </summary>
        public HttpLocalhost3000ProjectsPage HttpLocalhost3000Projects
        {
            get
            {
                return new HttpLocalhost3000ProjectsPage("http://localhost:3000/projectsinfo", _manager.ActiveBrowser.Find);
            }
        }
        /// <summary>
        /// Page : http://localhost:3000/admin/users 
        /// </summary>
        public HttpLocalhost3000AdminUsPage HttpLocalhost3000AdminUs
        {
            get
            {
                return new HttpLocalhost3000AdminUsPage("http://localhost:3000/admin/users", _manager.ActiveBrowser.Find);
            }
        }
        /// <summary>
        /// Page : http://localhost:3000/admin/users/new 
        /// </summary>
        public HttpLocalhost3000AdminUs0Page HttpLocalhost3000AdminUs0
        {
            get
            {
                return new HttpLocalhost3000AdminUs0Page("http://localhost:3000/admin/users/new", _manager.ActiveBrowser.Find);
            }
        }
        public class HttpLocalhost3000ProjectsPage : HtmlPage
        {
            public HttpLocalhost3000ProjectsPage(string url, Find find) : 
                    base(url, find)
            {
            }
            /// <summary>
            /// Find expressions for this page
            /// </summary>
            public ExpressionDefinitions Expressions
            {
                get
                {
                    return new ExpressionDefinitions();
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' button] AND [TextContent 'Exact' Log in]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlButton LogInButton
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlButton>("tagname=button", "TextContent=Log in");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' button] AND [TextContent 'Exact' Sign in]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlButton LogInDialogSignInButton
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlButton>("tagname=button", "TextContent=Sign in");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' button] AND [TextContent 'Exact' Log out]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlButton LogOutButton
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlButton>("TextContent=Log out", "tagname=button");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' adminmenu] AND [tagname 'Exact' a]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor AdminMenuLink
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor>("tagname=a", "id=adminmenu");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [href 'Exact' /admin/users] AND [tagname 'Exact' a]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor ManageUsersLink
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor>("tagname=a", "href=/admin/users");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [name 'Exact' login] AND [tagname 'Exact' input]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputEmail LogInDialogEmailTextbox
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputEmail>("tagname=input", "name=login");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [name 'Exact' pass] AND [tagname 'Exact' input]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputPassword LogInDialogPasswordTextbox
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputPassword>("tagname=input", "name=pass");
                }
            }
            public class ExpressionDefinitions
            {
                public ArtOfTest.WebAii.Core.HtmlFindExpression LogInButton = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=button", "TextContent=Log in");
                public ArtOfTest.WebAii.Core.HtmlFindExpression LogInDialogSignInButton = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=button", "TextContent=Sign in");
                public ArtOfTest.WebAii.Core.HtmlFindExpression LogOutButton = new ArtOfTest.WebAii.Core.HtmlFindExpression("TextContent=Log out", "tagname=button");
                public ArtOfTest.WebAii.Core.HtmlFindExpression AdminMenuLink = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=a", "id=adminmenu");
                public ArtOfTest.WebAii.Core.HtmlFindExpression ManageUsersLink = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=a", "href=/admin/users");
                public ArtOfTest.WebAii.Core.HtmlFindExpression LogInDialogEmailTextbox = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=input", "name=login");
                public ArtOfTest.WebAii.Core.HtmlFindExpression LogInDialogPasswordTextbox = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=input", "name=pass");
            }
        }
        public class HttpLocalhost3000AdminUsPage : HtmlPage
        {
            public HttpLocalhost3000AdminUsPage(string url, Find find) : 
                    base(url, find)
            {
            }
            /// <summary>
            /// Find expressions for this page
            /// </summary>
            public ExpressionDefinitions Expressions
            {
                get
                {
                    return new ExpressionDefinitions();
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' button] AND [TextContent 'Exact' New User]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlButton NewUserButton
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlButton>("tagname=button", "TextContent=New User");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' div] AND [TextContent 'StartsWith' A user with id ]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlDiv UserCreationSuccessfulDiv
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlDiv>("TextContent=^A user with id ", "tagname=div");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' button] AND [TextContent 'Exact' Log out]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlButton LogOutButton
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlButton>("tagname=button", "TextContent=Log out");
                }
            }
            public class ExpressionDefinitions
            {
                public ArtOfTest.WebAii.Core.HtmlFindExpression NewUserButton = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=button", "TextContent=New User");
                public ArtOfTest.WebAii.Core.HtmlFindExpression UserCreationSuccessfulDiv = new ArtOfTest.WebAii.Core.HtmlFindExpression("TextContent=^A user with id ", "tagname=div");
                public ArtOfTest.WebAii.Core.HtmlFindExpression LogOutButton = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=button", "TextContent=Log out");
            }
        }
        public class HttpLocalhost3000AdminUs0Page : HtmlPage
        {
            public HttpLocalhost3000AdminUs0Page(string url, Find find) : 
                    base(url, find)
            {
            }
            /// <summary>
            /// Find expressions for this page
            /// </summary>
            public ExpressionDefinitions Expressions
            {
                get
                {
                    return new ExpressionDefinitions();
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [name 'Exact' form][TagIndex 'Exact' input:5]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputCheckBox IsAdminCheckBox
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputCheckBox>("name=form", "|", "TagIndex=input:5");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' button] AND [TextContent 'Exact' Save]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlButton SaveButton
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlButton>("tagname=button", "TextContent=Save");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' email] AND [tagname 'Exact' input]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputEmail EmailTextbox
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputEmail>("tagname=input", "id=email");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' lastName] AND [tagname 'Exact' input]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText LastNameTextbox
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText>("tagname=input", "id=lastName");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' firstName] AND [tagname 'Exact' input]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText FirstNameTextbox
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText>("tagname=input", "id=firstName");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' password] AND [tagname 'Exact' input]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputPassword PasswordTextbox
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputPassword>("tagname=input", "id=password");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' passwordRepeat] AND [tagname 'Exact' input]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputPassword RepeatPasswordTextbox
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputPassword>("tagname=input", "id=passwordRepeat");
                }
            }
            public class ExpressionDefinitions
            {
                public ArtOfTest.WebAii.Core.HtmlFindExpression IsAdminCheckBox = new ArtOfTest.WebAii.Core.HtmlFindExpression("name=form", "|", "TagIndex=input:5");
                public ArtOfTest.WebAii.Core.HtmlFindExpression SaveButton = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=button", "TextContent=Save");
                public ArtOfTest.WebAii.Core.HtmlFindExpression EmailTextbox = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=input", "id=email");
                public ArtOfTest.WebAii.Core.HtmlFindExpression LastNameTextbox = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=input", "id=lastName");
                public ArtOfTest.WebAii.Core.HtmlFindExpression FirstNameTextbox = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=input", "id=firstName");
                public ArtOfTest.WebAii.Core.HtmlFindExpression PasswordTextbox = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=input", "id=password");
                public ArtOfTest.WebAii.Core.HtmlFindExpression RepeatPasswordTextbox = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=input", "id=passwordRepeat");
            }
        }
    }
    public class Applications
    {
        private Manager _manager;
        public Applications(Manager manager)
        {
            _manager = manager;
        }
    }
}
