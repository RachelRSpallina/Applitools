using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Text;
using System.Threading.Tasks;

namespace TraditionalTests
{


    public static class Login
    {
        public static IWebDriver driver = new ChromeDriver();
        public static Random random = new Random();
        // private static IWebDriver driver;

        public static IWebDriver Driver { get => driver; set => driver = value; }

        public static void BaselUrl()
        {
            driver.Navigate().GoToUrl("https://demo.applitools.com/hackathon.html");
        }

        public static string RandomString(int length = 50)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static void EnterUserName(string userName)
        {
            driver.FindElement(By.Id("username")).SendKeys(userName);
        }
        public static void EnterPassword(string passWord)
        {
            driver.FindElement(By.Id("password")).SendKeys(passWord);
        }
        public static void ClickLogIn()
        {
            driver.FindElement(By.Id("log-in")).Click();
        }
        public static void AssertUserAndPasswordNeeded()
        {
            Assert.Equal("Both Username and Password must be present", driver.FindElement(By.ClassName("alert-warning")).Text);
        }

        public static void AssertUserNameNoPassword()
        {
            Assert.Equal("Password must be present", driver.FindElement(By.ClassName("alert-warning")).Text);
        }

        public static void AssertPasswordNoUser()
        {
            Assert.Equal("Username must be present", driver.FindElement(By.ClassName("alert-warning")).Text);
        }

        public static void ClearTextUserName()
        {
            driver.FindElement(By.Id("username")).Clear();
        }

        public static void ClickAmountsHeader()
        {
            driver.FindElement(By.Id("amount")).Clear();
        }

        public static void ValidateAscendingOrder()
        {
            driver.FindElement(By.Id("amount")).Clear();
        }

        public static void ClickCompareExpenses()
        {
            driver.FindElement(By.Id("showExpensesChart")).Click();
        }

    }
}