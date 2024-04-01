using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = "http://compendiumdev.co.uk/selenium/basic_html_form.html";
            IWebDriver driver = new ChromeDriver();


            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);

            //Thread.Sleep(6000);

            IWebElement element = driver.FindElement(By.Name("username"));
            var dropdownMenu = "#HTMLFormElements > table > tbody > tr:nth-child(8) > td > select > option:nth-child(1)";
            var multipleSelect = "#HTMLFormElements > table > tbody > tr:nth-child(7) > td > select > option:nth-child(4)";
            


            if (element.Displayed)
            {
                Console.WriteLine("Yes exists!");
                element.SendKeys("akimura");
            }

            element = driver.FindElement(By.Name("password"));

            if (element.Displayed)
            {
                Console.WriteLine("Yes exists!");
                element.SendKeys("1234");
            }

            element = driver.FindElement(By.XPath(" //*[@id='HTMLFormElements']/table/tbody/tr[3]/td/textarea"));

            if (element.Displayed)
            {
                Console.WriteLine("Yes exists!");
                element.Clear();
                element.SendKeys("Nothing to say!");
            }

            element = driver.FindElement(By.Name("filename"));

            if (element.Displayed)
            {
                Console.WriteLine("Yes exists!");
                element.Click();
                element.SendKeys(@"C:\Users\Usuario\Pictures\índice.jpg");
            } 

            element = driver.FindElement(By.XPath("//input[@value='cb1']"));

            if (element.Selected)
            {
                Console.WriteLine("Already checked!");
            }

            else if (element.Displayed)
            {
                Console.WriteLine("Yes exists!");
                element.Click();
            }

            element = driver.FindElement(By.XPath("//input[@value='rd1']"));

            if (element.Displayed)
            {
                Console.WriteLine("Yes exists!");
                element.Click();

            }

            element = driver.FindElement(By.CssSelector(dropdownMenu));

            if (element.Displayed)
            {
                Console.WriteLine("Yes exists!");
                element.Click();

            }


            element = driver.FindElement(By.CssSelector(multipleSelect));

           

            if (element.Displayed)
            {
                Console.WriteLine("Yes exists!");
                element.Click();

            }

            element = driver.FindElement(By.Name("submitbutton"));

            if (element.Displayed)
            {
                Console.WriteLine("Yes exists!");
                element.Click();

            }

            driver.Close();
            driver.Quit();
        }
    }
}
