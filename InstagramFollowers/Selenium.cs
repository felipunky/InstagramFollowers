using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            var options = new ChromeOptions();
            options.AddArgument( @"--incognito" );

            //Create the reference for our browser
            IWebDriver driver = new ChromeDriver( options );

            string url = "https://www.instagram.com/",
            xPath = "//*[@id='react-root']/section/main/article/div[2]/div[2]/p/a",
            login = "//*[@id='react-root']/section/main/div/article/div/div[1]/div/form/div[2]/div/label/input",
            password = "//*[@id='react-root']/section/main/div/article/div/div[1]/div/form/div[3]/div/label/input",
            user = User,
            pass = Pass,
            enterUser = "//*[@id='react-root']/section/main/div/article/div/div[1]/div/form/div[4]/button",
            notifications = "//html/body/div[3]/div/div/div[3]/button[2]",
            enterFriend = "//*[@id='react-root']/section/nav/div[2]/div/div/div[2]/input",
            friend = Friend,
            enterFoundFriend = "//*[@id='react-root']/section/nav/div[2]/div/div/div[2]/div[2]/div[2]/div/a[1]/div/div[2]/div",
            following = "//*[@id='react-root']/section/main/div/header/section/ul/li[2]/a",
            followers = "//*[@id='react-root']/section/main/div/header/section/ul/li[3]/a",
            friendsConcatenateOne = "//html/body/div[3]/div/div[2]/ul/div/li[",
            friendsConcatenateTwo = "]/div/div[3]/button",
            friends = "";

            string[] splitForLoopMaxiter;

            int sizeOfLoop = 0;

            bool followOrFollowers = FollowOrFollowing;

            int time = Time;

            //Navigate to google page
            driver.Navigate().GoToUrl( url );

            try
            {

                Sleep( time );
                driver.FindElement( By.XPath( xPath ) ).Click();
                Sleep( time );

                driver.FindElement( By.XPath( login ) ).SendKeys( user );
                Sleep( time );

                driver.FindElement( By.XPath( password ) ).SendKeys( pass );
                Sleep( time );

                driver.FindElement( By.XPath( enterUser ) ).Click();
                Sleep( time * 3 );

                var noti = driver.FindElement( By.XPath( notifications ) );
                if( noti != null ) noti.Click();
                Sleep( time * 2 );

                var friendFound = driver.FindElement( By.XPath( enterFriend ) );
                if( friendFound != null )
                { 

                    friendFound.SendKeys( friend );
                    Sleep( time * 3 );

                    driver.FindElement( By.XPath( enterFoundFriend ) ).Click();
                    Sleep( time * 3 );

                    if( followOrFollowers == false )
                    { 

                        following = followers;

                    }

                    var followFollowers = driver.FindElement( By.XPath( following ) );
                    followFollowers.Click();

                    splitForLoopMaxiter = followFollowers.Text.Split( ' ' );
                    sizeOfLoop = Convert.ToInt32( splitForLoopMaxiter[0] );

                    //Debug.WriteLine( sizeOfLoop.ToString() );
                    
                    //Sleep( time * 3 );
                         
                    //for( int i = 1; i <= 20; ++i)
                    //{

                    //    friends = friendsConcatenateOne + i.ToString() + friendsConcatenateTwo;
                    //    driver.FindElement( By.XPath( friends ) ).Click();
                    //    Sleep( time );

                    //}

                }

            }

            catch ( Exception e )
            {

                Console.WriteLine( e );

            }

        }

        private void Sleep( int time )
        {

            System.Threading.Thread.Sleep( time );

        }

    }

}
