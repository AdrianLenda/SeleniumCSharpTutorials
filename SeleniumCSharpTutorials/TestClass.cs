using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCSharpTutorials.BaseClass;
using System;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace SeleniumCSharpTutorials
{
    [TestFixture]
    public class TestClass : BaseTest
    {
        [Test,Category("Smoke Testing")]
        public void TestMethod1()
        {
        
            IWebElement emailTextField = driver.FindElement(By.XPath("//*[@id='email']"));

            emailTextField.SendKeys("Selenium c#");
            Thread.Sleep(3000);
            IWebElement cookies = driver.FindElement(By.XPath("//*[text()='Zezwól na wszystkie pliki cookie']"));
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].click();", cookies);
            Thread.Sleep(3000);
            IWebElement register = driver.FindElement(By.XPath("//*[text()='Utwórz nowe konto']"));

            register.Click();
            Thread.Sleep(3000);
            IWebElement monthDropdownList = driver.FindElement(By.XPath("//*[@id='month']"));
            SelectElement element = new SelectElement(monthDropdownList);
            element.SelectByIndex(1);
           // element.SelectByText("mar");
            element.SelectByValue("6");

        }
        [Test, Category("Smoke Testing")]
        public void TestMethod2()
        {

            IWebElement emailTextField = driver.FindElement(By.XPath("//*[@id='email']"));

            emailTextField.SendKeys("Selenium c#");
        }
        [Test, Category("Regression Testing")]
        public void TestMethod3()
        {

            IWebElement emailTextField = driver.FindElement(By.XPath("//*[@id='email']"));

            emailTextField.SendKeys("Selenium c#");
        }

    }
}
