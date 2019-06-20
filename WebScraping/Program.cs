using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;

namespace WebScraping
{
    class Program
    {
        private static string _DriverDirectory = Path.Combine(Path.GetFullPath(Directory.GetCurrentDirectory()), "Driver");
        static void Main(string[] args)
        {
            Navigate Test = new Navigate();
            Test.TestingDriver();
        }
    }
}
