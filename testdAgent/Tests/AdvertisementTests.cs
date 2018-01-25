using NUnit.Framework;
using RealMadrid_UITest.Tools;
using RealMadrid_UITest.Variables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace RealMadrid_UITest.Tests
{
    //[TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]

    public class AdvertisementTests
    {
        IApp madrid;
        Utilities utils;
        Platform platform;



        public AdvertisementTests(Platform platform)
        {
            this.platform = platform;
        }



        [SetUp]
        public void BeforeEachTest()
        {
            madrid = AppInitializer.StartApp(platform);
            utils = new Utilities(madrid);
            utils.Login();           
        }



        [TearDown]
        public void AfterEachTest()
        {
            //            utils.Enter_Home();
            //            utils.Sign_Off();
        }

		// Auxiliary methods
		private void Go_To_Slow(Func<AppQuery, AppQuery> view, Func<AppQuery, AppQuery> element)
		{
			while (madrid.Query(element).Length == 0)
			{
				madrid.ScrollDown(view, ScrollStrategy.Gesture, 0.10, 50, true);
			}
		}

        [Test]
        //Ad left and right bottom Virtual Ticket. Horizontal and Vetical view.
        public void Test_34261()
        {
            //Step 3:Click on sport
            //Step 4: Click on Match area icon and select in TV or Only App
            madrid.Tap(NavigationBarVars.navbar_Match_area_but);
            if (utils.existsElement(MatchDayVars.matchDay_location_app_but))
                madrid.Tap(MatchDayVars.matchDay_location_app_but);
            madrid.WaitForElement(NavigationBarVars.match_area_Title);

            //Anuncios en la posicion vertical no existen
            madrid.SetOrientationLandscape();
            utils.Sleep(3);
            Assert.True((utils.existsElement(AdvertisementVars.matchArea_horizontal_ad_left))
                && (utils.existsElement(AdvertisementVars.matchArea_horizontal_ad_right)),
                "Ads at bottom and left doesn't exits");

            madrid.SetOrientationPortrait();
        }

        [Test]
        //Ad at center in Videos
        public void Test_34263() {

            //Step 2: Scroll down to "Videos" placeholder
            Go_To_Slow(HomeVars.home_content, AdvertisementVars.adver_all_videos_but);

            Assert.True(utils.existsElement(AdvertisementVars.adver_all_videos_but), "View All button doesn't exist" );

            Go_To_Slow(HomeVars.home_content, AdvertisementVars.adver_pager_videos_carrusel);

            Assert.True(utils.existsElement(AdvertisementVars.adver_pager_videos_carrusel), "Videos List doesn't exist");
            Assert.AreEqual((madrid.Query(AdvertisementVars.adver_video_left).Length) + (madrid.Query(AdvertisementVars.adver_video_middle).Length), 2);

            //Step 3: Click on "View All" button
            madrid.ScrollUp();
            Go_To_Slow(HomeVars.home_content, AdvertisementVars.adver_all_videos_but);
            madrid.Tap(AdvertisementVars.adver_all_videos_but);
            madrid.WaitForElement(AdvertisementVars.videos_ad_banner_bottom);

            Assert.True(utils.existsElement(AdvertisementVars.videos_ad_banner_bottom), "Ad isn't displayed" );

        }

        [Test]
        //Ad at top in Videos
        public void Test_34264() {

			//Step 2: Scroll down to "Videos" placeholder
			utils.Sleep(5);
			utils.Go_To(HomeVars.home_content, PlaceholderVars.Videos_ph_viewAll_but);

            Assert.True(utils.existsElement(PlaceholderVars.Videos_ph_viewAll_but), "View All button doesn't exist");

            utils.Go_To(HomeVars.home_content, AdvertisementVars.adver_pager_videos_carrusel);

            Assert.True(utils.existsElement(AdvertisementVars.adver_pager_videos_carrusel), "Videos List doesn't exist");
            Assert.AreEqual((madrid.Query(AdvertisementVars.adver_video_left).Length) + (madrid.Query(AdvertisementVars.adver_video_middle).Length), 2);

            //Step 3: Click on "View All" button
            madrid.ScrollUp();
            utils.Go_To(HomeVars.home_content, PlaceholderVars.Videos_ph_viewAll_but);
            madrid.Tap(PlaceholderVars.Videos_ph_viewAll_but);
            madrid.WaitForElement(AdvertisementVars.videos_ad_banner_top);

            Assert.True(utils.existsElement(AdvertisementVars.videos_ad_banner_top), "Ad isn't displayed");
        }
		/*
        [Test]
        //Ad in all places at Home Main activated
        public void Test_34267() {

            //Step 2: Scroll Down
            Boolean exist_ad = false;
            
            //ScrollDown until we find the last item in Home Main
            while (!utils.existsElement(HomeVars.home_main_end)){
                madrid.ScrollDown();
                
                 // If we find an ad in Home Main, we change "exist_ad" true
                 // If we don't find any ad, the var exist_ad'll be still false
                if (utils.existsElement(AdvertisementVars.adver_home_main)){
                    exist_ad = true;
                    break;
                }
                
            }

            Assert.True(exist_ad, "Ad doesn't displayed");
        }*/

        [Test]
        //Open each Advertisement
        //Suponemos que se refiere al anuncion de home page
        public void Test_34530() {

            //Step 2: Click on each Ad
			Go_To_Slow(HomeVars.home_content, AdvertisementVars.adver_home_main);
            madrid.Tap(AdvertisementVars.adver_home_main);
            Assert.True(utils.existsElement(AdvertisementVars.adver_view), "Ad doesn't displayed");

			//Step 3: Go back
			madrid.Tap(HomeVars.navigation_icon_back);
            Assert.True(utils.seeingHome(), "Home page doesn't displayed");

        }

		[Test]
		//Ad in a player card
		public void Test_35057()
		{
			if (utils._device == "Tablet")
			{
				//Step 3: Go to Menu
				//Step 4: Go to player card
				utils.Sleep(5);
				utils.Access_Tab_Main_Menu(MainMenuVars.menu_Ficha_Jugador_but);
				madrid.WaitForElement(MainMenuVars.ficha_Jugador_Title);

				//Step 5: Tap on a player card (Keylor Navas)
				//madrid.Tap(PlayerCardVars.ficha_jugador_Keylor_Navas);
				madrid.Tap(PlayerCardVars.ficha_jugador_Keylor_Navas_Tablet);
				utils.Sleep(3);
				if (!utils.existsElement(PlayerCardVars.jugador_title_keylor))
					madrid.Tap(PlayerCardVars.ficha_jugador_img_but);
				madrid.WaitForElement(PlayerCardVars.jugador_title_keylor);
				utils.Sleep(3);

				Assert.True(utils.existsElement(PlayerCardVars.jugador_ad_shirt), "The ad doesn't exist");

				//Step 6: Tap on the advertisement

				madrid.Tap(PlayerCardVars.jugador_ad_shirt);
				utils.Sleep(3);
				Assert.True(utils.existsElement(AdvertisementVars.webview_ad_shirt), "The shop webview isn't displayed");

			}
			else
			{
				//Step 3: Go to Menu
				//Step 4: Go to player card
				utils.Sleep(5);
				utils.Access_Tab_Main_Menu(MainMenuVars.menu_Ficha_Jugador_but);
				madrid.WaitForElement(MainMenuVars.ficha_Jugador_Title);

				//Step 5: Tap on a player card (Keylor Navas)
				madrid.Tap(PlayerCardVars.ficha_jugador_Keylor_Navas);
				utils.Sleep(3);
				if (!utils.existsElement(PlayerCardVars.jugador_title_keylor))
					madrid.Tap(PlayerCardVars.ficha_jugador_img_but);
				madrid.WaitForElement(PlayerCardVars.jugador_title_keylor);
				utils.Sleep(3);

				Assert.True(utils.existsElement(PlayerCardVars.jugador_ad_shirt), "The ad doesn't exist");

				//Step 6: Tap on the advertisement

				madrid.Tap(PlayerCardVars.jugador_ad_shirt);
				utils.Sleep(3);
				Assert.True(utils.existsElement(AdvertisementVars.webview_ad_shirt), "The shop webview isn't displayed");

			}
		}
		/*
        [Test]
        //Check news advertisement
        public void Test_35146()
        {
            //Step 1 - 10: Configuration add

            //Step 11: Open Application and login
            //Step 12: Go to News placelholder
            utils.Go_To(HomeVars.home_content, NewsVars.home_new_view_all);

            //Step 13: Click on View All
            madrid.Tap(NewsVars.home_new_view_all);

            //Step 14: Search news and click on the selected news (Presentacion del acuerdo de patrocinio entre el RM y Telefonica)
            utils.Go_To(HomeVars.home_content, NewsVars.news_new_example_ad);
            madrid.Tap(NewsVars.news_new_example_ad);

            madrid.WaitForElement(NewsVars.new_example_title);
            Assert.True(utils.existsElement(NewsVars.new_example_title), "New page isn't displayed");
            
            //Step 15: Click on the ad (Camiseta Varane)
            //NO EXISTE EL ANUNCIO
            utils.Go_To(HomeVars.home_content, NewsVars.new_example_ad);
            madrid.Tap(NewsVars.new_example_shirt_but);

            Assert.True(utils.existsElement(AdvertisementVars.webview_ad_shirt), "Ad page isn't displayed");


        }*/

        

    }
}
