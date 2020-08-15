using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace InstagramFollowers
{
    class Selenium
    {

        public string User
        {

            get;

            set;

        }

        public string Pass
        {

            get;

            set;

        }

        public string Friend
        {

            get;

            set;

        }

        public int Time
        {

            get;

            set;

        }

        public bool FollowOrFollowing
        {

            get;

            set;

        }

        public void RunScript()
        {

            OpenQA.Selenium.Chrome.ChromeOptions options = new ChromeOptions();
            options.AddArgument( @"--incognito" );

            //Create the reference for our browser
            IWebDriver driver = new ChromeDriver( options );

            string url = "https://www.instagram.com/",
            login = "//*[@id='loginForm']/div/div[1]/div/label/input",
            password = "//*[@id='loginForm']/div/div[2]/div/label/input",
            user = User,
            pass = Pass,
            enterUser = "//*[@id='loginForm']/div/div[3]/button/div",
            //notifications = "//*[@id='react-root']/section/nav/div[2]/div/div/div[2]/input",
            searchBar = "//*[@id='react-root']/section/nav/div[2]/div/div/div[2]/div",
            friend = Friend,
            searchBarSendKeys = "//*[@id='react-root']/section/nav/div[2]/div/div/div[2]/input",
            enterFoundFriend = "//*[@id='react-root']/section/nav/div[2]/div/div/div[2]/div[3]/div[2]/div/a[1]",
            /*following = "//*[@id='react-root']/section/main/div/header/section/ul/li[2]/a",
            followers = "//*[@id='react-root']/section/main/div/header/section/ul/li[2]/a",*/
            numberOfFollowers = "//*[@id='react-root']/section/main/div/header/section/ul/li[2]/a/span";

            bool followOrFollowers = FollowOrFollowing;

            int time = Time;

            //Navigate to the page.
            driver.Navigate().GoToUrl( url );

            Actions actions = new Actions( driver );

            try
            {

                //Sleep( time );
                driver.FindElement( By.XPath( login ), 10 ).SendKeys( user );

                driver.FindElement( By.XPath( password ) ).SendKeys( pass );

                driver.FindElement( By.XPath( enterUser ) ).Click();

                // Find using the search bar.
                driver.FindElement( By.XPath( searchBar ), 10 ).Click();

                // Send keys to the search bar.
                driver.FindElement( By.XPath( searchBarSendKeys ) ).SendKeys( friend );

                // Click on the first friend from the search.
                driver.FindElement( By.XPath( enterFoundFriend ), 10 ).Click();

                // When the checkbox is unchecked the app will go to followers.
                if( true )
                {

                    // Find how many followers exist to be able to loop.
                    var numOfFollowers = driver.FindElement( By.XPath( numberOfFollowers ), 10 );
                    string numberOfFolStr = numOfFollowers.GetAttribute( "title" );
                    int numberOfFollowersInt = toInt( numberOfFolStr );

                    // Click on the followers tab.
                    numOfFollowers.Click();

                    // Now look for the follow button.
                    // /html/body/div[4]/div/div/div[2]/ul/div/li[1]/div/div[3]/button
                    // /html/body/div[4]/div/div/div[2]/ul/div/li[2]/div/div[3]/button
                    // See the pattern?
                    string pathToFollowFirst = "/html/body/div[4]/div/div/div[2]/ul/div/li[";
                    string pathToFollowSecond = "]/div/div[3]";

                    // Iterate. We need the index starting at 0 for the strings so start at 1.
                    IWebElement followFollower = null;
                    IWebElement list = driver.FindElement( By.XPath( "/html/body/div[4]/div/div/div[2]" ), 10 );
                    //int counter = 1;
                    string pathToFollow = "";

                    Random random = new Random();

                    for( int i = 1; i < numberOfFollowersInt + 1; ++i )
                    {

                        try
                        {

                            pathToFollow = pathToFollowFirst + i.ToString() + pathToFollowSecond;
                            followFollower = driver.FindElement( By.XPath( pathToFollow ) );

                        }

                        catch( Exception )
                        {

                            pathToFollow = pathToFollowFirst + i.ToString() + "]/div/div[2]";
                            followFollower = driver.FindElement( By.XPath( pathToFollow ), 1 );

                        }

                        IJavaScriptExecutor js = ( IJavaScriptExecutor ) driver;
                        js.ExecuteScript( "arguments[0].scrollIntoView(false);", followFollower );

                        string followingOrNot = followFollower.Text;

                        if( followingOrNot == "Follow" )
                        {

                            followFollower.Click();
                            Console.WriteLine( followingOrNot );

                        }
                        
                        Sleep( random.Next( 1, time ) );

                    }

                }

                /*var friendFound = driver.FindElement( By.XPath( enterFriend ), 10 );
                if( friendFound != null )
                {

                    friendFound.SendKeys( friend );
                    Sleep( time * 3 );

                    driver.FindElement( By.XPath( enterFoundFriend ) ).Click();
                    Sleep( time * 3 );

                    string friendsConcatenateOne = "//html/body/div[3]/div/div[2]/ul/div/li[",
                           friendsConcatenateTwo = "]/div/div[3]/button"; 


                    if ( followOrFollowers == false )
                    { 

                        following = followers;

                    }

                    var followFollowers = driver.FindElement( By.XPath( following ) );
                    followFollowers.Click();

                    splitForLoopMaxiter = followFollowers.Text.Split( ' ' );
                    string amount = splitForLoopMaxiter[0];

                    char[] chars = amount.ToCharArray(); 

                    int lengthOfAmount = chars.Length - 1;

                    if( chars[lengthOfAmount] == 'k' )
                    {

                        amount = amount.Remove( lengthOfAmount, 1 );

                    }

                    Debug.WriteLine( amount );

                    var c = System.Threading.Thread.CurrentThread.CurrentCulture;

                    decimal number = decimal.Parse( amount, c );
                    sizeOfLoop = Convert.ToInt32( number );
                    Sleep( time * 3 );

                    IWebElement fds = null;

                    int counterMax = 0;

                    for (int i = 1; i <= sizeOfLoop; ++i)
                    {

                        try
                        {

                            friends = friendsConcatenateOne + i.ToString() + friendsConcatenateTwo;
                            fds = driver.FindElement( By.XPath( friends ) );
                            //Sleep( time / 4 );

                        }

                        catch( NoSuchElementException )
                        {

                            friends = friendsConcatenateOne + i.ToString() + "]/div/div[2]/button";
                            fds = driver.FindElement( By.XPath( friends ) );

                        }

                        Debug.WriteLine( fds.Text );

                        if( fds.Text == "Following" || fds.Text == "Requested" )
                        {

                            driver.FindElement( By.XPath( "/html/body/div[3]/div/div[2]/ul" ) ).Click();
                            driver.FindElement( By.TagName( "body" ) ).SendKeys( Keys.ArrowDown );

                        }

                        else
                        {

                            fds.Click();

                            if( counterMax % 2 == 0 )

                                driver.FindElement( By.TagName( "body" ) ).SendKeys( Keys.ArrowDown );

                        }

                        Sleep( time / 2 );

                    }

                }*/

            }

            catch ( Exception e )
            {

                Debug.WriteLine( e );

            }

        }

        public double GetRandomNumberInRange(Random random, double minNumber, double maxNumber)
        {
            return random.NextDouble() * (maxNumber - minNumber) + minNumber;
        }

        public void ScrollTo(IWebElement element, IWebDriver driver, int xPosition = 0, int yPosition = 0 )
        {
            IJavaScriptExecutor js = ( IJavaScriptExecutor ) driver;
            js.ExecuteScript( string.Format( "{0}.scrollTo({1}, {2})", element, xPosition, yPosition ) );
        }

        public IWebElement ScrollToView(IWebDriver driver, By selector)
        {
            var element = driver.FindElement( selector, 10 );
            ScrollToView( driver, element );
            return element;
        }

        public void ScrollToView(IWebDriver driver, IWebElement element)
        {
            if (element.Location.Y > 200)
            {
                ScrollTo( element, driver, 0, element.Location.Y - 100); // Make sure element is in the view but below the top navigation pane
            }

        }

        private void Sleep( int time )
        {

            System.Threading.Thread.Sleep( TimeSpan.FromSeconds( time ) );

        }

        int toInt( string x )
        {
  
            StringBuilder sb = new StringBuilder();
            for( int i = 0; i < x.Length; ++i )
            {
    
                char c = x[i];
      
                if( c != ',' )
                {
      
                    sb.Append(c);
      
                }
    
            }
    
            return Convert.ToInt32( sb.ToString() );
  
        }

    }

    public static class WebDriverExtensions
    {
        public static IWebElement FindElement(this IWebDriver driver, By by, int timeoutInSeconds)
        {
            if (timeoutInSeconds > 0)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                return wait.Until(drv => drv.FindElement(by));
            }
            return driver.FindElement(by);
        }
    }

}
