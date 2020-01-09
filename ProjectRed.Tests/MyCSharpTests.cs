using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ProjectRed.Tests
{
    public class MyCSharpTests
    {
        private ChromeDriver driver; // field

        [OneTimeSetUp] // attribute
        public void InitSetup() // method
        {
            driver = new ChromeDriver(); // initialize of field
        }

        [TearDown]
        public void Down()
        {
            Screenshot img = driver.GetScreenshot(); //initialize of variable
            img.SaveAsFile($"d://img_{DateTime.UtcNow.ToString("yyyy-dd-M--HH-mm-ss")}", ScreenshotImageFormat.Png);
        }


        [OneTimeTearDown]
        public void TearDown()
        {
            driver.Close(); //call the method
        }

        [Test]
        public void TitleTest_Positive()
        {
            INavigation navigation = driver.Navigate();
            navigation.GoToUrl("http://mycsharp.ru/post/7/2013_04_15_peremennye_tipy_dannyx_konstanty_v_si-sharp.html");
            var element = driver.FindElement(By.XPath("//span[@id='ContentPlaceHolder1_LabelHeader']"));
            string elementText = element.Text;
            Assert.AreEqual("Переменные,типы данных, константы в Си-шарп", elementText);
            
        }

        [Test]
        public void TitleTest_Negative()
        {
            INavigation navigation = driver.Navigate();
            navigation.GoToUrl("http://mycsharp.ru/post/7/2013_04_15_peremennye_tipy_dannyx_konstanty_v_si-sharp.html");
            var element = driver.FindElement(By.XPath("//span[@id='ContentPlaceHolder1_LabelHeader']"));
            string elementText = element.Text;
            Assert.AreNotEqual("Hello", elementText);
        }

       
    }
}