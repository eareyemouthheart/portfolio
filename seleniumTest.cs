using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Text.RegularExpressions;
using OpenQA.Selenium.Interactions;

namespace SelemiumTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://www.calculator.net");
            // a - cos
            //find buttom cos click 
            driver.FindElement(By.XPath("//*[@id=\"sciout\"]/tbody/tr[2]/td[1]/div/div[1]/span[2]")).Click();
            System.Threading.Thread.Sleep(10);
            //find buttom 6 then click
            driver.FindElement(By.XPath("//*[@id=\"sciout\"]/tbody/tr[2]/td[2]/div/div[2]/span[3]")).Click();
            System.Threading.Thread.Sleep(10);
            //find buttom 0 then click  
            driver.FindElement(By.XPath("//*[@id=\"sciout\"]/tbody/tr[2]/td[2]/div/div[4]/span[1]")).Click();
            //get result and output
            String result1 = driver.FindElement(By.XPath("//*[@id=\"sciOutPut\"]")).Text;
            Console.WriteLine(result1);
            // Determine equality
            Assert.AreEqual("0.5", result1.Substring(1, result1.Length - 1));
            //Refresh page
            driver.Navigate().Refresh();
            System.Threading.Thread.Sleep(5);
        }

        [TestMethod]
        public void TestMethod2()
        {
            IWebDriver driver = new ChromeDriver();
            //driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://www.calculator.net");
            // b - log
            //find buttom log then click
            driver.FindElement(By.XPath("//*[@id=\"sciout\"]/tbody/tr[2]/td[1]/div/div[4]/span[5]")).Click();
            System.Threading.Thread.Sleep(10);
            // find buttom 1 click
            driver.FindElement(By.XPath("//*[@id=\"sciout\"]/tbody/tr[2]/td[2]/div/div[3]/span[1]")).Click();
            System.Threading.Thread.Sleep(10);
            //get result
            String result2 = driver.FindElement(By.XPath("//*[@id=\"sciOutPut\"]")).Text;
            Console.WriteLine(result2);
            // Determine equality
            Assert.AreEqual("0", result2.Substring(1, result2.Length - 1));

            
            driver.Navigate().Refresh();
            System.Threading.Thread.Sleep(5);
        }
     }
}
