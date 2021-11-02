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
        [TestMethod]
        public void TestMethod3()
        {

            IWebDriver driver = new ChromeDriver();
            //driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://www.calculator.net");
            // c - x+ y 
            //find button 1 element then click 
            driver.FindElement(By.XPath("//*[@id=\"sciout\"]/tbody/tr[2]/td[2]/div/div[3]/span[1]")).Click();
            System.Threading.Thread.Sleep(10);
            // find button + element then click 
            driver.FindElement(By.XPath("//*[@id=\"sciout\"]/tbody/tr[2]/td[2]/div/div[1]/span[4]")).Click();
            System.Threading.Thread.Sleep(10);
            // 1
            driver.FindElement(By.XPath("//*[@id=\"sciout\"]/tbody/tr[2]/td[2]/div/div[3]/span[1]")).Click();
            System.Threading.Thread.Sleep(10);
            // =
            driver.FindElement(By.XPath("//*[@id=\"sciout\"]/tbody/tr[2]/td[2]/div/div[5]/span[4]")).Click();
            System.Threading.Thread.Sleep(10);
            //get result
            String result3 = driver.FindElement(By.XPath("//*[@id=\"sciOutPut\"]")).Text;
            Console.WriteLine(result3);
            //Determine equality
            Assert.AreEqual("2", result3.Substring(1, result3.Length - 1));

             
            driver.Navigate().Refresh();
            System.Threading.Thread.Sleep(5);
        }
        [TestMethod]
        public void TestMethod4()
        {
            IWebDriver driver = new ChromeDriver();
            //driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://www.calculator.net");

            // d - n!
            //find button 6 element then click 
            driver.FindElement(By.XPath("//*[@id=\"sciout\"]/tbody/tr[2]/td[2]/div/div[2]/span[3]")).Click();
            System.Threading.Thread.Sleep(10);
            // find button n! element then click 
            driver.FindElement(By.XPath("//*[@id=\"sciout\"]/tbody/tr[2]/td[1]/div/div[5]/span[5]")).Click();
            System.Threading.Thread.Sleep(10);
            //get result
            String result4 = driver.FindElement(By.XPath("//*[@id=\"sciOutPut\"]")).Text;
            Console.WriteLine(result4);
            //Determine equality
            Assert.AreEqual("720", result4.Substring(1, result4.Length - 1));

            driver.Quit();
        }


        [TestMethod]
        public void Item2()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Url = "http://automationpractice.com";

            //Get all the code on the page
            String html = driver.PageSource;
            Match m;

            //Regular expression gets links
            Regex r = new Regex("href\\s*=\\s*(?:\"(?<1>[^\"]*)\"|(?<1>\\S+))",
            RegexOptions.IgnoreCase);//match case ignored By default case sensitive   
            //not sure- RegexOptions.Compiled
            for (m = r.Match(html); m.Success; m = m.NextMatch())
            {
                //Console.WriteLine("Found href " + m.Groups[1] + " at " + m.Groups[1].Index);
                
                //string matching
                String href = m.Groups[1].Value;
                if (href.Contains("http://"))
                {
                    //Output all website links
                    Console.WriteLine(href);


                }


            }

            driver.Quit();

        }

        [TestMethod]
        public void Item3()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Url = "http://automationpractice.com";

            //Get the first commodity price
            String priceOne = driver.FindElement(By.XPath("//*[@id=\"homefeatured\"]/li[1]/div/div[2]/div[1]/span")).Text;
            Console.WriteLine("The price of first item:" + priceOne);

            Actions action = new Actions(driver);
             
            action.MoveToElement(driver.FindElement(By.XPath("//*[@id=\"homefeatured\"]/li[1]/div/div[2]/div[1]/span"))).Perform();
            System.Threading.Thread.Sleep(5000);

            //Add to cart
            driver.FindElement(By.LinkText("Add to cart")).Click();
            System.Threading.Thread.Sleep(5000);


            //Click Continue shopping
            driver.FindElement(By.XPath("/html/body/div/div[1]/header/div[3]/div/div/div[4]/div[1]/div[2]/div[4]/span/span")).Click();

            System.Threading.Thread.Sleep(5000);


            IWebElement element = driver.FindElement(By.XPath("//*[@id=\"homefeatured\"]/li[2]/div/div[1]/div/a[1]/img"));
            
            //Some elements are in the invisible area of the page.To avoid missing elements,Move to the "bottom" of the element Element object, aligned with the "bottom" of the current window
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);

            //Get the second commodity price
            String priceTwo = driver.FindElement(By.XPath("//*[@id=\"homefeatured\"]/li[2]/div/div[2]/div[1]/span")).Text;
            Console.WriteLine("The price of second item:" + priceTwo);

            System.Threading.Thread.Sleep(5000);

             
            action.MoveToElement(driver.FindElement(By.XPath("//*[@id=\"homefeatured\"]/li[2]/div/div[2]/div[1]/span"))).Perform();
            System.Threading.Thread.Sleep(5000);

            //add to cart
            driver.FindElement(By.LinkText("Add to cart")).Click();
            System.Threading.Thread.Sleep(5000);

            //Click Continue shopping
            driver.FindElement(By.XPath("/html/body/div/div[1]/header/div[3]/div/div/div[4]/div[1]/div[2]/div[4]/span/span")).Click();



            //get the third item price
            String priceThree = driver.FindElement(By.XPath("//*[@id=\"homefeatured\"]/li[3]/div/div[2]/div[1]/span")).Text;
            Console.WriteLine("The price of third item:" + priceThree);

            System.Threading.Thread.Sleep(5000);
            
            //use scroll bar to avoid missing elements
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);


             
            action.MoveToElement(driver.FindElement(By.XPath("//*[@id=\"homefeatured\"]/li[3]/div/div[2]/div[1]/span"))).Perform();
            System.Threading.Thread.Sleep(5000);

            //add to cart
            driver.FindElement(By.LinkText("Add to cart")).Click();
            System.Threading.Thread.Sleep(5000);
            //refresh pages
            //driver.Navigate().Refresh();

            System.Threading.Thread.Sleep(5000);


            //get the amount price 

            driver.Url = "http://automationpractice.com/index.php?controller=order&ipa=3";
            String stringAmount = driver.FindElement(By.XPath("//*[@id=\"total_product\"]")).Text;
            Double Amount = double.Parse(stringAmount.Substring(1, priceOne.Length - 1));

            //Comparison price and total 
            double price1 = double.Parse(priceOne.Substring(1, priceOne.Length - 1));
            double price2 = double.Parse(priceTwo.Substring(1, priceOne.Length - 1));
            double price3 = double.Parse(priceThree.Substring(1, priceOne.Length - 1));

            double total = price1 + price2 + price3;

            //Determine equality
            Assert.AreEqual(Amount, total);

            if (Amount.Equals(total))
            {
                Console.WriteLine("Total shopping cart price:" + Amount + " Actual total price：" + total + "equal?：" + "YES");
            }
            else
            {
                Console.WriteLine("Total shopping cart price:" + Amount + " Actual total price：" + price1 + "equal?：" + "NO");
            }


        }
    

        [TestMethod]
        public void Item4()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Url = "http://automationpractice.com";

            //Get the first commodity price
            String priceOne = driver.FindElement(By.XPath("//*[@id=\"homefeatured\"]/li[1]/div/div[2]/div[1]/span")).Text;
            Console.WriteLine("The first item price:" + priceOne);

            Actions action = new Actions(driver);
             
            action.MoveToElement(driver.FindElement(By.XPath("//*[@id=\"homefeatured\"]/li[1]/div/div[2]/div[1]/span"))).Perform();
            System.Threading.Thread.Sleep(5000);

            //add to cart
            driver.FindElement(By.LinkText("Add to cart")).Click();
            System.Threading.Thread.Sleep(5000);


            //Click Continue shopping
            driver.FindElement(By.XPath("/html/body/div/div[1]/header/div[3]/div/div/div[4]/div[1]/div[2]/div[4]/span/span")).Click();

            System.Threading.Thread.Sleep(5000);


            IWebElement element = driver.FindElement(By.XPath("//*[@id=\"homefeatured\"]/li[2]/div/div[1]/div/a[1]/img"));

            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);

            //Get second item price
            String priceTwo = driver.FindElement(By.XPath("//*[@id=\"homefeatured\"]/li[2]/div/div[2]/div[1]/span")).Text;
            Console.WriteLine("The second item price:" + priceTwo);

            System.Threading.Thread.Sleep(5000);

             
            action.MoveToElement(driver.FindElement(By.XPath("//*[@id=\"homefeatured\"]/li[2]/div/div[2]/div[1]/span"))).Perform();
            System.Threading.Thread.Sleep(5000);

            //Add to cart
            driver.FindElement(By.LinkText("Add to cart")).Click();
            System.Threading.Thread.Sleep(5000);

            //Click Continue shopping
            driver.FindElement(By.XPath("/html/body/div/div[1]/header/div[3]/div/div/div[4]/div[1]/div[2]/div[4]/span/span")).Click();
            
             


            //Get third item price
            String priceThree = driver.FindElement(By.XPath("//*[@id=\"homefeatured\"]/li[3]/div/div[2]/div[1]/span")).Text;
            Console.WriteLine("The third item price:" + priceThree);

            System.Threading.Thread.Sleep(5000);

            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);


             
            action.MoveToElement(driver.FindElement(By.XPath("//*[@id=\"homefeatured\"]/li[3]/div/div[2]/div[1]/span"))).Perform();
            System.Threading.Thread.Sleep(5000);

            //add to cart
            driver.FindElement(By.LinkText("Add to cart")).Click();
            System.Threading.Thread.Sleep(5000);




            //Comparison price
            double price2 = double.Parse(priceTwo.Substring(1, priceTwo.Length - 1));



            

            driver.Url = "http://automationpractice.com/index.php?controller=order&ipa=3";
            System.Threading.Thread.Sleep(5000);


            //Delete the third item in the cart
            driver.FindElement(By.XPath("//*[@id=\"3_13_0_0\"]/i")).Click();

            System.Threading.Thread.Sleep(5000);

            //Delete the second item in the cart
            driver.FindElement(By.XPath("//*[@id=\"1_1_0_0\"]/i")).Click();


            System.Threading.Thread.Sleep(5000);
            //get the amount price 
            String stringAmount = driver.FindElement(By.XPath("//*[@id=\"total_product\"]")).Text;
            Double Amount = double.Parse(stringAmount.Substring(1, priceOne.Length - 1));

            //Determine equality
            Assert.AreEqual(Amount, price2);

            
            if (Amount.Equals(price2))
            {
                Console.WriteLine("Total shopping cart price:" + Amount + " Actual total price：" + price2 + "equal?：" + "Yes");
            }
            else
            {
                Console.WriteLine("Total shopping cart price:" + Amount + " Actual total price：" + price2 + "equal?：" + "No");
            }
        }

    }
}
