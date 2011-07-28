namespace HelloWorldSeleniumWebDriver {
    #region Using
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using OpenQA.Selenium;
    using OpenQA.Selenium.IE;

    #endregion Using
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void TestMethod1() {
            // Create a new WebDriver instance
            IWebDriver driver = new InternetExplorerDriver();

            // Go to Bing.com
            driver.Url = "http://www.bing.com";

            // Find the search box and enter a search
            IWebElement searchBox = driver.FindElement(By.Name("q"));
            searchBox.SendKeys("selenium");
            driver.FindElement(By.Name("go")).Click();

            Assert.IsTrue(driver.Title.Contains("Bing"));

            driver.Close();
        }
    }
}
