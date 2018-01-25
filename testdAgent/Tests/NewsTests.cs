using NUnit.Framework;
using RealMadrid_UITest.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest;
using Xamarin.UITest.Queries;



namespace RealMadrid_UITest.Tests { 
    //[TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]


    public class NewsTests {
        IApp madrid;
        Utilities utils;
        Platform platform;


        public NewsTests(Platform platform) {
            this.platform = platform;
        }



        [SetUp]
        public void BeforeEachTest() {
            madrid = AppInitializer.StartApp(platform);
            utils = new Utilities(madrid);
            utils.Login();
        }



        [TearDown]
        public void AfterEachTest() {
            // utils.Enter_Home();
            // utils.Sign_Off();
        }

		// Auxiliary methods
		private void Go_To_Slow(Func<AppQuery, AppQuery> view, Func<AppQuery, AppQuery> element)
		{
			while (madrid.Query(element).Length == 0)
			{
				madrid.ScrollDown(view, ScrollStrategy.Gesture, 0.20, 500, true);    
				                  }
		        }

		/**************************************************** NEWS ****************************************************/

        [Test]
        //Share native options on principal news
        public void Test_34441() {
            //Step 2: Go to news main menu 
            utils.Access_Tab_Main_Menu(NewsVars.menu_Noticias_but);

            //Step 3: Click on share button 
			madrid.WaitForElement(NewsVars.news_Share_but);
            madrid.Tap(NewsVars.news_Share_but);
			madrid.WaitForElement(NewsVars.news_NativeApps_view);
            Assert.True(utils.existsElement(NewsVars.news_NativeApps_view), "A popup doesn't appear with a list of Native Apps");

            //Step 4: Click out of the flyout 
			madrid.WaitForElement(NewsVars.news_NativeApps_ok_but);
            madrid.Tap(NewsVars.news_NativeApps_ok_but);
            Assert.True(utils.existsElement(MainMenuVars.noticias_Title), "News page isn't displayed");
        }


        
        [Test]
        //Scroll fast in News
        public void Test_34525() {
            //Step 2: Go to news main menu
            utils.Access_Tab_Main_Menu(NewsVars.menu_Noticias_but);

            //Step 3: Check the news page 
            madrid.WaitForElement(NewsVars.news_list_news);
            Assert.True(utils.existsElement(NewsVars.news_main_img), "Main image doesn't exist");
            Assert.True(utils.existsElement(NewsVars.news_main_title), "Title doesn't exist");
            //Assert.True(utils.existsElement(NewsVars.news_main_like_but), "Favouritte button doesn't exist");
            Assert.True(utils.existsElement(NewsVars.news_main_share_but), "Share button doesn't exist");
            //Assert.True(utils.existsElement(NewsVars.news_main_whatsapp_but), "Whatsapp button doesn't exist");
            Assert.True(utils.existsElement(NewsVars.news_main_facebook_but), "Facebook button doesn't exist");
            Assert.True(utils.existsElement(NewsVars.news_main_twitter_but), "Twitter button doesn't exist");
            Assert.True(madrid.Query(NewsVars.news_list_news).Length > 1, "List of news doesn't exist");

            //Step 4: Scroll fast up and down
            madrid.ScrollDown();
            madrid.ScrollUp();
            Assert.True(utils.existsElement(NewsVars.news_list_news), "News page doesn't display");


        }



        [Test]
        //See image carousel at news through main menu
        public void Test_35248() {
            //Step 2: Go to news main menu
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Noticias_but);

            //Step 3: Click on multiple news
			Go_To_Slow(HomeVars.home_content, NewsVars.news_newWithCarousel);
            madrid.Tap(NewsVars.news_newWithCarousel);
            utils.Sleep(6);

            madrid.WaitForElement(NewsVars.news_title);
            Assert.True(utils.existsElement(NewsVars.news_new_img), "Image news doesn't exist");
            Assert.True(utils.existsElement(NewsVars.news_title), "Title doesn't exist");
            Assert.True(utils.existsElement(NewsVars.news_main_like_but), "Favourite button doesn't exist");
            Assert.True(utils.existsElement(NewsVars.home_new_share), "Share button doesn't exist");
            Assert.True(utils.existsElement(NewsVars.home_new_twitter_but), "Twitter button doesn't exist");
            Assert.True(utils.existsElement(NewsVars.home_new_facebook_but), "Facebook button doesn't exist");
            Assert.True(utils.existsElement(NewsVars.home_new_whatsapp_but), "Whatsapp button doesn't exist");
            Assert.True(utils.existsElement(NewsVars.news_description), "News description doesn't exist");
            Assert.True(utils.existsElement(NewsVars.news_carousel), "Carousel doesn't exist");

            //Step 4: Scroll carousel and click on one image.
            Assert.True(utils.existsElement(NewsVars.news_main_img), "Images carousel doesn't exist");
            madrid.SwipeRightToLeft(NewsVars.news_carousel, 0.5, 500, true);
        }


      
        [Test]
        //News List view
        public void Test_35669() {
            //Step 2: Go to news main menu
			Go_To_Slow(HomeVars.home_content, NewsVars.home_new_image);

            //Step 3: Tap on "View All"
            madrid.Tap(HomeVars.home_all_news);
            utils.Sleep(7);
            Assert.True(utils.existsElement(MainMenuVars.noticias_Title), "News title doesn't exist");
            Assert.True(utils.existsElement(NewsVars.news_main_img), "New image doesn't exist");
            Assert.True(utils.existsElement(NewsVars.news_main_title), "Title doesn't exist");
            Assert.True(utils.existsElement(NewsVars.news_main_like_but), "Favourite button doesn't exist");
            Assert.True(utils.existsElement(NewsVars.news_main_share_but), "Share button doesn't exist");
            //Assert.True(utils.existsElement(NewsVars.news_main_whatsapp_but), "Whatsapp button doesn't exist");
            Assert.True(utils.existsElement(NewsVars.news_main_facebook_but), "Facebook button doesn't exist");
            Assert.True(utils.existsElement(NewsVars.news_main_twitter_but), "Twitter button doesn't exist");

            Assert.True(utils.existsElement(NewsVars.news_list_news), "List of news doesn't exist");
            Assert.True(utils.existsElement(NewsVars.news_list_fav_but), "Favourite button of news list doesn't exist");
            Assert.True(utils.existsElement(NewsVars.news_list_share_but), "Share button of news list doesn't exist");
			Assert.True(utils.existsElement(NewsVars.news_list_time), "Time of news list doesn't exist");
        }
    }
}
