using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using NUnit;
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
         // public static IWebDriver driver = ChromeDriver();


        public static void GetRowData()
        {
          //Get table data on screen load
          // IWebElement tableElement = Login.driver.FindElement(By.XPath("//*[@id='transactionsTable']"));
          // IList<IWebElement> tableRow = tableElement.FindElements(By.TagName("tr"));
          // IList<IWebElement> rowTD;
          // List<String> NewList = new List<String>();
         
          //  //Click Amount header
          //IWebElement amount= Login.driver.FindElement(By.XPath("//*[@id=\"transactionsTable\"]/table/thead/tr/th[5]"));

        
          //  foreach (var item in tableRow)
          //   {
          //  NewList.Add(item.Text);
          //  }
          //  //Get Table after click
          //  IWebElement tableElementAfterClick = Login.driver.FindElement(By.XPath("//*[@id='transactionsTable']"));
          //  IList<IWebElement> tableRowAfterClick = tableElement.FindElements(By.TagName("tr"));


            IWebElement elemTable = Login.driver.FindElement(By.XPath("//*[@id='transactionsTable']"));
            List<IWebElement> lstTrElem = new List<IWebElement>(elemTable.FindElements(By.TagName("tr")));
            IWebElement row = lstTrElem.Where(item => item.Text.Contains("AMOUNT")).FirstOrDefault();
           // string rowid = row.GetAttribute("data-uid");
            //IList<IWebElement> cells = row.FindElements(By.TagName("td"));
            //for (int i = 0; i < cells.Count; i++)
            //{
            //    IWebElement cell = cells[i];
            //}
            //row.FindElement(By.ClassName("cell-popover")).Click();

        }

        public static void ValidateAscendingOrder()
        {
            Login.driver.FindElement(By.Id("amount")).Clear();
        }

        public static void ClickCompareExpenses()
        {
            Login.driver.FindElement(By.Id("showExpensesChart")).Click();
        }
    }
}