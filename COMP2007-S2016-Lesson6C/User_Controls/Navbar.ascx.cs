using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//Required for Identity and OWN
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;

/**
 * @author: Robert Reynolds
 * @author: June 2nd, 2016
 * @version: 0.0.2 - updated SetActivePage Method to include new links
 */

namespace COMP2007_S2016_Lesson6C
{
    public partial class Navbar : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                //Check if a user is logged in
                if(HttpContext.Current.User.Identity.IsAuthenticated)
                {
                    //Show the Contoso content area
                    ContosoPlaceHolder.Visible = true;
                    PublicPlaceholder.Visible = false;
                }
                else
                {
                    //Only show login and register
                    ContosoPlaceHolder.Visible = false;
                    PublicPlaceholder.Visible = true;
                }
                SetActivePage();
            }
            
        }

        /**
         * This method adds a CSS class of "active" to list items related to
         * navigation links of each page
         * 
         * @method SetActivePage
         * @return {void}
         */
        private void SetActivePage()
        {
            switch (Page.Title)
            {
                case "Home Page":
                    home.Attributes.Add("class", "active");
                    break;
                case "Students":
                    students.Attributes.Add("class", "active");
                    break;
                case "Courses":
                    courses.Attributes.Add("class", "active");
                    break;
                case "Departments":
                    departments.Attributes.Add("class", "active");
                    break;
                case "Contact":
                    contact.Attributes.Add("class", "active");
                    break;
                case "Contoso Menu":
                    menu.Attributes.Add("class", "active");
                    break;
                case "Login":
                    login.Attributes.Add("class", "active");
                    break;
                case "Register":
                    register.Attributes.Add("class", "active");
                    break;
            }
        }
    }
}