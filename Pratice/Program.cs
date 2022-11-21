using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using FakeItEasy;
using OpenQA.Selenium.Support.UI;
using System.Xml.Linq;
using System.Linq;
using OpenQA.Selenium.Interactions;

namespace Pratice
{
    internal class Program
    {
        private static IWebDriver driver = new ChromeDriver();

        private static void Main(string[] args)
        {
            string url = "http://www.qaclickacademy.com/practice.php";
            driver.Navigate().GoToUrl(url);
            praticeone();
            praticetwo();
            praticethree();
            praticefour();
            praticesix();
            praticeseven();
            praticeeight();
            praticenine();
            praticefive();
            praticesix();
        }

        

        //RadioButton
        public static void praticeone()
        {
            IWebElement RB1 = driver.FindElement(By.XPath("//*[@id=\"radio-btn-example\"]/fieldset/label[1]/input"));
            RB1.Click();
            String Value1 = RB1.GetAttribute("Checked");
            if (Value1 == "true")
            {
                Console.WriteLine("Radio button 1 is checked");
            }
            else
            {
                Console.WriteLine("Radio button 1 is unchecked");
            }
            Thread.Sleep(3000);


            IWebElement RB2 = driver.FindElement(By.XPath("//*[@id=\"radio-btn-example\"]/fieldset/label[2]/input"));
            RB2.Click();
            String Value2 = RB2.GetAttribute("Checked");
            if (Value2 == "true")
            {
                Console.WriteLine("Radio button 2 is checked");
            }
            else
            {
                Console.WriteLine("Radio button 2 is unchecked");
            }
            Thread.Sleep(3000);


            IWebElement RB3 = driver.FindElement(By.XPath("//*[@id=\"radio-btn-example\"]/fieldset/label[3]/input"));
            RB3.Click();
            String Value3 = RB3.GetAttribute("Checked");
            if (Value3 == "true")
            {
                Console.WriteLine("Radio button 3 is checked");
            }
            else
            {
                Console.WriteLine("Radio button 3 is unchecked");
            }
            Thread.Sleep(3000);
        }



        //SuggestionBox
        public static void praticetwo()
        {
            IWebElement select = driver.FindElement(By.Id("autocomplete"));
            select.SendKeys("united state");
            IList <IWebElement> sug = driver.FindElements(By.XPath("//*[@id=\"autocomplete\"]"));

            foreach(var selement in sug)
            {
                selement.Click();
            }
        } 
       


        //dropdown
        public static void praticethree()
        {

            IWebElement dropdown = driver.FindElement(By.XPath("//*[@id=\"dropdown-class-example\"]"));
            dropdown.Click();
            SelectElement dd = new SelectElement(dropdown);
            for (int i = 1; i < 4; i++)
            {
                dd.SelectByText("Option" + i + "");
                Thread.Sleep(1000);
            }
        }
         


        //CheckBox
        public static void praticefour()
        {
            IWebElement check1 = driver.FindElement(By.XPath("//*[@id=\"checkBoxOption1\"]"));
            check1.Click();
            Thread.Sleep(1000);
            check1.Click();

            Thread.Sleep(1000);

            Console.WriteLine(check1.GetAttribute("value"));

            IWebElement check2 = driver.FindElement(By.XPath("//*[@id=\"checkBoxOption2\"]"));
            check2.Click();
            Thread.Sleep(1000);
            check2.Click();

            IWebElement check3 = driver.FindElement(By.XPath("//*[@id=\"checkBoxOption3\"]"));
            check3.Click();
            Thread.Sleep(1000);
            check3.Click();

            Thread.Sleep(1000);

            for(int i=1;i<=3; i++)
            {
                IWebElement checkall = driver.FindElement(By.XPath("//*[@id=\"checkBoxOption" +i+"\"]"));
                checkall.Click();
                Thread.Sleep(1000);
            }
            driver.Quit();
        }
        

        //Switch to alert
        public static void praticeseven()
        {
            IWebElement alert = driver.FindElement(By.Id("name"));
            alert.Click();
            alert.SendKeys("Satu");
            Thread.Sleep(1000);
            IWebElement alertbtn = driver.FindElement(By.Id("alertbtn"));
            alertbtn.Click();
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(1000);
        }
        


        //Table
        public static void praticeeight()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(System.String.Format("window.scrollTo({0},{1})",400, 627));
            Thread.Sleep(1000);
        }
       

        //Mouse Hover
        public static void praticenine()
        {
            var ele = driver.FindElement(By.Id("mousehover"));
            Actions act = new Actions(driver);
            act.MoveToElement(ele).Perform();
            Thread.Sleep(1000);
            IWebElement top = driver.FindElement(By.CssSelector("body > div:nth-child(6) > div > fieldset > div > div > a:nth-child(1)"));
            act.MoveToElement(top).Perform();
            top.Click();
            Thread.Sleep(1000);
        }


        //Switch Window
        public static void praticefive()
        {
            IWebElement win = driver.FindElement(By.Id("openwindow"));
            win.Click();
            Thread.Sleep(1000);
            driver.SwitchTo().Window(driver.WindowHandles[0]);
        }


        //Switch Tab
        public static void praticesix()
        {
            IWebElement Tab = driver.FindElement(By.Id("opentab"));
            Tab.Click();
            Thread.Sleep(1000);
            driver.SwitchTo().Window(driver.WindowHandles[0]);
        }




    }
}
