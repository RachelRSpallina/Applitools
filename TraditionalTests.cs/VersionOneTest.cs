using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

//Applitools Hackathon version 1 test

namespace TraditionalTests
{
    public class VersionOneTest
    {
        [Fact]
        public void LogInVersionOne()
        {
            var UserName = Login.RandomString().Substring(0, 3);
            var PassWord = Login.RandomString().Substring(0, 3);
            

            //Navigate to applitools demo site
            Login.BaselUrl();
       
            //Find Log in button and click with no user name or password
            Login.ClickLogIn();
           
            //Assert error message
            Login.AssertUserAndPasswordNeeded();
           
            //Enter User Name Only
             Login.EnterUserName(UserName);
             Login.ClickLogIn();
             Login.AssertUserNameNoPassword();
             Login.ClearTextUserName();

            //Enter Password Only
            Login.EnterPassword(PassWord);
            Login.ClickLogIn();
            Login.AssertPasswordNoUser();

            //Enter username and password
            Login.EnterUserName(UserName);
            Login.ClickLogIn();

            //Click Amounts header
            DynamicContentTest.GetRowData();


           // Login.ValidateAscendingOrder();
            
            
       


        }
    }
    }

