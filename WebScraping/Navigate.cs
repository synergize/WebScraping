using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WebScraping
{
    class Navigate
    {
        private static string _DriverDirectory = Path.Combine(Path.GetFullPath(Directory.GetCurrentDirectory()), "Driver");
        
        public void TestingDriver()
        {
            List<string> NewList = new List<string>();
            var option = new ChromeOptions();
            option.AddArgument("--headless");
            IWebDriver driver = new ChromeDriver(BuildFilePath(), option);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.mtggoldfish.com/movers/paper/modern");
            var Movers = driver.FindElements(By.XPath("//table[contains(@class, 'movers-table')]"));
            foreach (var item in Movers)
            {
                NewList.Add(item.Text);
                Console.WriteLine(item.Text);
            }
            driver.Close();
            driver.Quit();

            int z = 0;

        }
        public string BuildFilePath()
        {
            if (!Directory.Exists(_DriverDirectory))
            {
                Directory.CreateDirectory(_DriverDirectory);
            }
            return Path.Combine(_DriverDirectory);
        }
    }
}
