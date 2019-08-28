using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace InstagramFollowers
{
    class Selenium
    {

        public void RunScript()
        {

            var options = new ChromeOptions();
            options.AddArgument( @"--incognito" );

            //Create the reference for our browser
            IWebDriver driver = new ChromeDriver( options );

            string url = "https://www.instagram.com/",
            xPath = "//*[@id='react-root']/section/main/article/div[2]/div[2]/p/a",
            login = "//*[@id='react-root']/section/main/div/article/div/div[1]/div/form/div[2]/div/label/input",
            password = "//*[@id='react-root']/section/main/div/article/div/div[1]/div/form/div[3]/div/label/input",
            enterUser = "//*[@id='react-root']/section/main/div/article/div/div[1]/div/form/div[4]/button";

            //Navigate to google page
            driver.Navigate().GoToUrl( url );

            //System.Threading.Thread.Sleep( 10000 );

            try
            {

                System.Threading.Thread.Sleep( 1000 );

                driver.FindElement( By.XPath( xPath ) ).Click();

                System.Threading.Thread.Sleep( 1000 );

                driver.FindElement( By.XPath( login ) ).SendKeys( "felipunkerito" );

                System.Threading.Thread.Sleep( 1000 );

                driver.FindElement( By.XPath( password ) ).SendKeys( "gonorrea" );

                System.Threading.Thread.Sleep( 1000 );

                driver.FindElement( By.XPath( enterUser ) ).Click();

            }

            catch( Exception e )
            {

                Console.WriteLine( e );

            }

            //WebDriverWait wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(3));

            //Find the Search text box UI Element
            //IWebElement element = driver.FindElement(By.Name("q"));

            //Perform Ops
            //element.SendKeys("executeautomation");

            //Close the browser
            //driver.Close();

        }
    }

}
