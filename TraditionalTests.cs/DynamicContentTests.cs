using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.IE;
using System.Threading;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;


namespace TraditionalTests
{
    public static class DynamicContentTest
    {
        // public IWebElement baseTable = driver.FindElement(By.TagName("table"));
        public static IWebDriver driver = new ChromeDriver();
       

        public static void GetRowData()
        {
            // IWebElement tableRow = baseTable.FindElement(By.XPath("//*[@id='amount']/"));
            // IWebElement tableRow = driver.FindElement(By.XPath("//*[@id='transactionsTable']/tbody/tr[1]/td[5]/span"));
            // IWebElement getCellData = tableRow.FindElement(By.XPath("//*[@id="transactionsTable"]/tbody/tr[1]/td[5]/span"));
            // string rowtext = tableRow.getText();
            // IWebElement transactionTable = driver.FindElement(By.XPath("//table[@id='amount']/"));
            IJavaScriptExecutor javascriptDriver = (IJavaScriptExecutor)driver;
            IWebElement table = driver.FindElement(By.XPath("//*[@id='amount']/"));
            List<IWebElement> rows = table.FindElement(By.XPath('tr'));
            for (int i = 0; i < rows.Count(); i++)
            {
                String name = rows.get(i).findElements(By.XPath("tr/td")).get(1).getText();
            }
        }

        public static void ValidateAscendingOrder()
        {
            driver.FindElement(By.Id("amount")).Clear();
        }

        public static void ClickCompareExpenses()
        {
            driver.FindElement(By.Id("showExpensesChart")).Click();