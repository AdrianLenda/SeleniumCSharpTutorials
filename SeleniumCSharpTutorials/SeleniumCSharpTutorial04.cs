using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCSharpTutorials
{
    [TestFixture]
    public class SeleniumCSharpTutorial04
    {
        [Test]
        [Author("Adrian Lenda","13959")]
        [Description("facebook login Verify")]
        [TestCaseSource("DataDriverTesting")]
        public  void test1(String urlName)
        {
            IWebDriver driver = null;

            try
            {
                 driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                //driver.Url = "https://www.facebook.com/";
                driver.Url = urlName;
               // IWebElement emailTextField = driver.FindElement(By.XPath("//*[@id='email']"));
                IWebElement emailTextField = driver.FindElement(By.XPath("//*[@id='abcd']"));

                emailTextField.SendKeys("Selenium c#");
                driver.Quit();
            }
            catch (Exception e)
            {
                ITakesScreenshot ts = driver as ITakesScreenshot;
                Screenshot screenshot = ts.GetScreenshot();

               //Wlasna sciezka
                screenshot.SaveAsFile("C:\\Users\\k\\Desktop\\AdrianLenda-13959-Lab7-testy-oprogramowania\\SeleniumCSharpTutorials\\SeleniumCSharpTutorials\\Screenshotsss\\screenshot1.png", ScreenshotImageFormat.Png);

                throw;
            }
            finally
            {
                if (driver != null)
                {
                    driver.Quit();
                }

            }
           
        }
        static IList DataDriverTesting()
        {
            ArrayList list = new ArrayList();
            list.Add("https://www.facebook.com/");
            //list.Add("https://www.youtube.com/");
            //list.Add("https://www.gmail.com/");
            return list;
        }
        //[Test]
        //[Author("Adrian Lenda", "13959")]
        //[Description("facebook login Verify")]
        //public void test2()
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Manage().Window.Maximize();
        //    driver.Url = "https://www.facebook.com/";
        //    IWebElement emailTextField = driver.FindElement(By.XPath("//*[@id='email']"));

        //    emailTextField.SendKeys("Selenium c#");
        //    driver.Quit();
        //}
    }
}
