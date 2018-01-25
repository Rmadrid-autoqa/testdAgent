using NUnit.Framework;
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

    public class MatchDayFootballTests
    {
        IApp madrid;
        Utilities utils;
        Platform platform;



        public MatchDayFootballTests(Platform platform)
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

		private void Go_To_slow(Func<AppQuery, AppQuery> view, Func<AppQuery, AppQuery> element)
		{
			while (madrid.Query(element).Length == 0)
			{
				madrid.ScrollDown(view, ScrollStrategy.Gesture, 0.20, 500, true);
		   }
		}
        /***************** CLASSIFICATION AND FIXTURES PLACEHOLDER > FIXTURES *****************/
        [Test]
        //Go to Area Match through fixtures placeholder
        public void Test_30936() {
           
            //Step 2: Scroll to Classification placeholder and swipe to Fixtures tab
            Go_To_slow(HomeVars.home_content, MatchDayVars.matchDay_home_clasification);
            madrid.Tap(MatchDayVars.matchDay_home_match);
			madrid.WaitForElement(MatchDayVars.matchDay_home_calendar);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_home_calendar), "Calendar doesn't exist");

            //Step 3: Click on Real Madrid match during/pre/post match
            if (!utils.existsElement(MatchDayVars.matchDay_calendar_day))
                madrid.Tap(MatchDayVars.matchDay_calendar_next_but);

            madrid.Tap(MatchDayVars.matchDay_calendar_day);
			madrid.WaitForElement(MatchDayVars.matchDay_popup_match);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_popup_match), "Popup doesn't display");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_competition), "Competition name doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_week), "Week doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_date), "Date doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_hour), "Hour match doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_homeTeam_icon), "Home team icon doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_awayTeam_icon), "Away team icon doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_homeTeam_name), "Home team name doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_awayTeam_name), "Away team name doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_matchArea_but), "Match Area button doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_OK_but), "OK button doesn't exist");
        }

        /***************** MATCH AREA > EVS *****************/
        /*
        [Test]
        //Different angles of a event
        public void Test_10589(){

            //Step 2: Click on "Match area" icon or "Play with us" placeholder
            utils.Go_To(HomeVars.home_content, MatchDayVars.matchDay_home_playwithus_but);
            madrid.Tap(MatchDayVars.matchDay_home_playwithus_but);
            madrid.WaitForElement(MatchDayVars.matchDay_location_title);

            Assert.True(utils.existsElement(MatchDayVars.matchDay_location_title), "Location page doesn't display");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_location_stadium_but), "Stadium button doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_location_app_but), "App button doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_location_tv_but), "TV button doesn't exist");

            //Step 3: Click on "In the Stadium" icon
            madrid.Tap(MatchDayVars.matchDay_location_stadium_but);
            if (utils.existsElement(MatchDayVars.matchDay_wifi_cancel_but))
                madrid.Tap(MatchDayVars.matchDay_wifi_cancel_but);

            madrid.WaitForElement(NavigationBarVars.match_area_Title);
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_liveTV);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_cameras), "Bernabeu Cameras button doesn't exits");
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_liveTV);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_liveTV), "Live TV button doesn't exits");
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_RealMadridTV);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_RealMadridTV), "Real Madrid TV button doesn't exits");
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_lineUp);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_lineUp), "Line Up button doesn't exits");
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_interviews);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_interviews), "Interviews button doesn't exits");
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_fanArea);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_fanArea), "Fan Area button doesn't exits");
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_summary);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_summary), "Summary button doesn't exits");
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_goals);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_goals), "Goals button doesn't exits");
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_full);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_full), "Full match button doesn't exits");

            //Step 4: Click on "Bernabeu cameras" icon
                //Camera page is loaded and event list ordered by match minute
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_cameras);
            madrid.Tap(MatchDayVars.matchDay_video_cameras);
            //"Camaras del Bernabeu" button doesn't work
            Console.WriteLine("Cameras button is not available");

            //Step 5: Click on event -> A image of stadium is displayed
            //Step 6: Click on each of the cameras -> video is played in the right angle
            //Step 7: Repeat the steps 5,6 with all the events

        }

        [Test]
        //Bernabeu Cameras with Bernabeu wifi connected
        public void Test_13221() {
            //Step 2: Click on "Match Area" icon or "Play with us" placeholder
            utils.Sleep(5);
            utils.Go_To(HomeVars.home_content, MatchDayVars.matchDay_home_playwithus_but);
            madrid.Tap(MatchDayVars.matchDay_home_playwithus_but);
            madrid.WaitForElement(MatchDayVars.matchDay_location_title);

            Assert.True(utils.existsElement(MatchDayVars.matchDay_location_title), "Location page doesn't display");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_location_stadium_but), "Stadium button doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_location_app_but), "App button doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_location_tv_but), "TV button doesn't exist");

            //Step 3: Click on "In the stadium" icon (Bernabeu wifi connected)
            madrid.Tap(MatchDayVars.matchDay_location_stadium_but);
            //No tenemos conexion a Bernabeu wifi
            if (utils.existsElement(MatchDayVars.matchDay_wifi_cancel_but))
                madrid.Tap(MatchDayVars.matchDay_wifi_cancel_but);

            madrid.WaitForElement(NavigationBarVars.match_area_Title);
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_liveTV);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_cameras), "Bernabeu Cameras button doesn't exits");
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_liveTV);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_liveTV), "Live TV button doesn't exits");
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_RealMadridTV);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_RealMadridTV), "Real Madrid TV button doesn't exits");
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_lineUp);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_lineUp), "Line Up button doesn't exits");
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_interviews);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_interviews), "Interviews button doesn't exits");
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_fanArea);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_fanArea), "Fan Area button doesn't exits");
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_summary);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_summary), "Summary button doesn't exits");
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_goals);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_goals), "Goals button doesn't exits");
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_full);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_full), "Full match button doesn't exits");

            //Step 4: Click on "Bernabeu cameras" icon -> Two streaming channels and several videos of repetitions.
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_cameras);
            madrid.Tap(MatchDayVars.matchDay_video_cameras);
            //"Camaras del Bernabeu" button doesn't work
            Console.WriteLine("Cameras button is not available");


        }

        [Test]
        //Events are right ordered
        public void Test_13669() {
            //Step 2: Click on "Match Area" icon or "Play with us" placeholder
            utils.Sleep(5);
            utils.Go_To(HomeVars.home_content, MatchDayVars.matchDay_home_playwithus_but);
            madrid.Tap(MatchDayVars.matchDay_home_playwithus_but);
            madrid.WaitForElement(MatchDayVars.matchDay_location_title);

            Assert.True(utils.existsElement(MatchDayVars.matchDay_location_title), "Location page doesn't display");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_location_stadium_but), "Stadium button doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_location_app_but), "App button doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_location_tv_but), "TV button doesn't exist");

            //Step 3: Click on "In the stadium" icon (Bernabeu wifi connected)
            madrid.Tap(MatchDayVars.matchDay_location_stadium_but);
            //No tenemos conexion a Bernabeu wifi
            if (utils.existsElement(MatchDayVars.matchDay_wifi_cancel_but))
                madrid.Tap(MatchDayVars.matchDay_wifi_cancel_but);

            madrid.WaitForElement(NavigationBarVars.match_area_Title);
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_liveTV);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_cameras), "Bernabeu Cameras button doesn't exits");
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_liveTV);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_liveTV), "Live TV button doesn't exits");
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_RealMadridTV);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_RealMadridTV), "Real Madrid TV button doesn't exits");
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_lineUp);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_lineUp), "Line Up button doesn't exits");
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_interviews);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_interviews), "Interviews button doesn't exits");
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_fanArea);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_fanArea), "Fan Area button doesn't exits");
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_summary);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_summary), "Summary button doesn't exits");
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_goals);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_goals), "Goals button doesn't exits");
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_full);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_full), "Full match button doesn't exits");

            //Step 4: Click on "Bernabeu cameras" icon -> List of events should be ordered in the time
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_cameras);
            madrid.Tap(MatchDayVars.matchDay_video_cameras);
            //"Camaras del Bernabeu" button doesn't work
            Console.WriteLine("Cameras button is not available");
        }

        [Test]
        //Access to Virtual Ticket by In the Stadium with Bernabeu wifi not connected
        public void Test_34284(){
            //Step 2: Click on "Match Area" icon or "Play with us" placeholder
            utils.Sleep(5);
            utils.Go_To(HomeVars.home_content, MatchDayVars.matchDay_home_playwithus_but);
            madrid.Tap(MatchDayVars.matchDay_home_playwithus_but);
            madrid.WaitForElement(MatchDayVars.matchDay_location_title);

            Assert.True(utils.existsElement(MatchDayVars.matchDay_location_title), "Location page doesn't display");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_location_stadium_but), "Stadium button doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_location_app_but), "App button doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_location_tv_but), "TV button doesn't exist");

            //Step 3: Click on "In the Stadium" icon
            madrid.Tap(MatchDayVars.matchDay_location_stadium_but);
            madrid.WaitForElement(MatchDayVars.matchDay_wifi_title);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_wifi_img), "Bernabeu image doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_wifi_title), "Wifi title doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_wifi_OK_but), "Settings button doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_wifi_cancel_but), "Cancel button doesn't exist");

            //Step 4: Click on "No thanks" or "Ok" button
            madrid.Tap(MatchDayVars.matchDay_wifi_cancel_but);
            madrid.WaitForElement(NavigationBarVars.match_area_Title);
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_liveTV);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_cameras), "Bernabeu Cameras button doesn't exits");
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_liveTV);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_liveTV), "Live TV button doesn't exits");
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_RealMadridTV);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_RealMadridTV), "Real Madrid TV button doesn't exits");
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_lineUp);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_lineUp), "Line Up button doesn't exits");
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_interviews);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_interviews), "Interviews button doesn't exits");
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_fanArea);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_fanArea), "Fan Area button doesn't exits");
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_summary);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_summary), "Summary button doesn't exits");
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_goals);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_goals), "Goals button doesn't exits");
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_full);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_full), "Full match button doesn't exits");

        }

        [Test]
        //Access to Virtual Ticket by In the Stadium through Match Day placeholder with finished match without wifi connected
        public void Test_34942() {
            //Step 2: Click on "Match Area" icon or "Play with us" placeholder
            utils.Sleep(5);
            utils.Go_To(HomeVars.home_content, MatchDayVars.matchDay_home_playwithus_but);
            madrid.Tap(MatchDayVars.matchDay_home_playwithus_but);
            madrid.WaitForElement(MatchDayVars.matchDay_location_title);

            Assert.True(utils.existsElement(MatchDayVars.matchDay_location_title), "Location page doesn't display");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_location_stadium_but), "Stadium button doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_location_app_but), "App button doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_location_tv_but), "TV button doesn't exist");

            //Step 3: Click on Bernabeu Stadium
            madrid.Tap(MatchDayVars.matchDay_location_stadium_but);
            madrid.WaitForElement(MatchDayVars.matchDay_wifi_title);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_wifi_img), "Bernabeu image doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_wifi_title), "Wifi title doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_wifi_OK_but), "Settings button doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_wifi_cancel_but), "Cancel button doesn't exist");

            //Step 4: Click on "No thanks" or "Ok" button
            madrid.Tap(MatchDayVars.matchDay_wifi_cancel_but);
            madrid.WaitForElement(NavigationBarVars.match_area_Title);
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_liveTV);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_cameras), "Bernabeu Cameras button doesn't exits");
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_liveTV);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_liveTV), "Live TV button doesn't exits");
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_RealMadridTV);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_RealMadridTV), "Real Madrid TV button doesn't exits");
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_lineUp);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_lineUp), "Line Up button doesn't exits");
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_interviews);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_interviews), "Interviews button doesn't exits");
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_fanArea);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_fanArea), "Fan Area button doesn't exits");
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_summary);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_summary), "Summary button doesn't exits");
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_goals);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_goals), "Goals button doesn't exits");
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_full);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_full), "Full match button doesn't exits");

        }

        [Test]
        //Access to Virtual Ticket by in the Stadium through Match Day placeholder during the match without wifi connected
        public void Test_38339() {
            //Step 2: Click on "Match Area" icon or "Play with us" placeholder
            utils.Sleep(5);
            utils.Go_To(HomeVars.home_content, MatchDayVars.matchDay_home_playwithus_but);
            madrid.Tap(MatchDayVars.matchDay_home_playwithus_but);
            madrid.WaitForElement(MatchDayVars.matchDay_location_title);

            Assert.True(utils.existsElement(MatchDayVars.matchDay_location_title), "Location page doesn't display");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_location_stadium_but), "Stadium button doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_location_app_but), "App button doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_location_tv_but), "TV button doesn't exist");

            //Step 3: Click on Bernabeu Stadium
            madrid.Tap(MatchDayVars.matchDay_location_stadium_but);
            madrid.WaitForElement(MatchDayVars.matchDay_wifi_title);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_wifi_img), "Bernabeu image doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_wifi_title), "Wifi title doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_wifi_OK_but), "Settings button doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_wifi_cancel_but), "Cancel button doesn't exist");

            //Step 4: Click on "No thanks" or "Ok" button
            madrid.Tap(MatchDayVars.matchDay_wifi_cancel_but);
            madrid.WaitForElement(NavigationBarVars.match_area_Title);
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_liveTV);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_cameras), "Bernabeu Cameras button doesn't exits");
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_liveTV);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_liveTV), "Live TV button doesn't exits");
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_RealMadridTV);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_RealMadridTV), "Real Madrid TV button doesn't exits");
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_lineUp);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_lineUp), "Line Up button doesn't exits");
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_interviews);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_interviews), "Interviews button doesn't exits");
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_fanArea);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_fanArea), "Fan Area button doesn't exits");
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_summary);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_summary), "Summary button doesn't exits");
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_goals);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_goals), "Goals button doesn't exits");
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_full);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_full), "Full match button doesn't exits");

        }

        [Test]
        //Event with only a camera
        public void Test_38340(){
            //Step 2: Click on "Match Area" icon or "Play with us" placeholder
            utils.Sleep(5);
            utils.Go_To(HomeVars.home_content, MatchDayVars.matchDay_home_playwithus_but);
            madrid.Tap(MatchDayVars.matchDay_home_playwithus_but);
            madrid.WaitForElement(MatchDayVars.matchDay_location_title);

            Assert.True(utils.existsElement(MatchDayVars.matchDay_location_title), "Location page doesn't display");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_location_stadium_but), "Stadium button doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_location_app_but), "App button doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_location_tv_but), "TV button doesn't exist");

            //Step 3: Click on "In the stadium" icon (Bernabeu wifi connected)
            madrid.Tap(MatchDayVars.matchDay_location_stadium_but);
            //No tenemos conexion a Bernabeu wifi
            if (utils.existsElement(MatchDayVars.matchDay_wifi_cancel_but))
                madrid.Tap(MatchDayVars.matchDay_wifi_cancel_but);

            madrid.WaitForElement(NavigationBarVars.match_area_Title);
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_liveTV);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_cameras), "Bernabeu Cameras button doesn't exits");
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_liveTV);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_liveTV), "Live TV button doesn't exits");
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_RealMadridTV);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_RealMadridTV), "Real Madrid TV button doesn't exits");
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_lineUp);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_lineUp), "Line Up button doesn't exits");
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_interviews);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_interviews), "Interviews button doesn't exits");
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_fanArea);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_fanArea), "Fan Area button doesn't exits");
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_summary);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_summary), "Summary button doesn't exits");
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_goals);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_goals), "Goals button doesn't exits");
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_full);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_full), "Full match button doesn't exits");

            //Step 4: Click on "Bernabeu cameras" icon -> Appear 2 streaming channels and list of events
            utils.Swipe_To_Right(MatchDayVars.matchDay_video_content, MatchDayVars.matchDay_video_cameras);
            madrid.Tap(MatchDayVars.matchDay_video_cameras);
            //"Camaras del Bernabeu" button doesn't work
            Console.WriteLine("Cameras button is not available");

            //Step 5: Click on an event with only a camera -> The video is displayed directly
        }

        */

        /***************** MATCH AREA > V.T POST MATCH > STATS *****************/
        [Test]
        public void Test_30934(){
            //Step 2: Click on "Match Area" through navbar
            madrid.Tap(NavigationBarVars.navbar_Match_area_but);

            //Step 3: Click on "Only in the App"
            utils.Sleep(5);
            if (utils.existsElement(MatchDayVars.matchDay_location_app_but))
                madrid.Tap(MatchDayVars.matchDay_location_app_but);
            madrid.WaitForElement(NavigationBarVars.match_area_Title);

            //Step 4: Click on "Stats" tab
            madrid.Tap(MatchDayVars.matchDay_matchArea_stats);

            //Team information
			madrid.WaitForElement(MatchDayVars.matchDay_stats_home_img);
			madrid.WaitForElement(MatchDayVars.matchDay_stats_away_img);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_stats_home_img), "Home team logo doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_stats_away_img), "Away team logo doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_stats_home_name), "Home team name doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_stats_away_name), "Away team name doesn't exist");
            madrid.Tap(MatchDayVars.matchDay_stats_home_but);
			madrid.WaitForElement(MatchDayVars.matchDay_stats_players_list);
			utils.Sleep(3);
            AppResult[] players_home = madrid.Query(MatchDayVars.matchDay_stats_players_list);
            Assert.True(players_home.Length > 2, "Home team players doesn't exist");
            madrid.Tap(MatchDayVars.matchDay_stats_home_but);
            madrid.Tap(MatchDayVars.matchDay_stats_away_but);
			madrid.WaitForElement(MatchDayVars.matchDay_stats_players_list);
            utils.Sleep(3);
			AppResult[] players_away = madrid.Query(MatchDayVars.matchDay_stats_players_list);
            Assert.True(players_home.Length > 2, "Away team players doesn't exist");
            madrid.Tap(MatchDayVars.matchDay_stats_away_but);

            AppResult[] result_home_graphic = madrid.Query(MatchDayVars.matchDay_stats_home_graphics);
            String result_home_text = result_home_graphic[0].Text;
            
            //Summary stats
            this.Assert_stats(MatchDayVars.matchDay_stats_general, MatchDayVars.matchDay_stats_totalAssists);
            this.Assert_stats(MatchDayVars.matchDay_stats_possession, MatchDayVars.matchDay_stats_totalAssists);
            this.Assert_stats(MatchDayVars.matchDay_stats_shots, MatchDayVars.matchDay_stats_totalAssists);
            this.Assert_stats(MatchDayVars.matchDay_stats_corners, MatchDayVars.matchDay_stats_totalAssists);
            this.Assert_stats(MatchDayVars.matchDay_stats_offsides, MatchDayVars.matchDay_stats_totalAssists);
            this.Assert_stats(MatchDayVars.matchDay_stats_defense, MatchDayVars.matchDay_stats_totalAssists);
            this.Assert_stats(MatchDayVars.matchDay_stats_interceptions, MatchDayVars.matchDay_stats_totalAssists);
            this.Assert_stats(MatchDayVars.matchDay_stats_clearances, MatchDayVars.matchDay_stats_totalAssists);
            this.Assert_stats(MatchDayVars.matchDay_stats_tackles, MatchDayVars.matchDay_stats_totalAssists);
            this.Assert_stats(MatchDayVars.matchDay_stats_duels, MatchDayVars.matchDay_stats_totalAssists);
            this.Assert_stats(MatchDayVars.matchDay_stats_recoveries, MatchDayVars.matchDay_stats_totalAssists);
            this.Assert_stats(MatchDayVars.matchDay_stats_passing, MatchDayVars.matchDay_stats_totalAssists);
            this.Assert_stats(MatchDayVars.matchDay_stats_total, MatchDayVars.matchDay_stats_totalAssists);
            this.Assert_stats(MatchDayVars.matchDay_stats_completion, MatchDayVars.matchDay_stats_totalAssists);
            this.Assert_stats(MatchDayVars.matchDay_stats_opposition, MatchDayVars.matchDay_stats_totalAssists);
            this.Assert_stats(MatchDayVars.matchDay_stats_final, MatchDayVars.matchDay_stats_totalAssists);
            this.Assert_stats(MatchDayVars.matchDay_stats_crosses, MatchDayVars.matchDay_stats_totalAssists);
            this.Assert_stats(MatchDayVars.matchDay_stats_offense, MatchDayVars.matchDay_stats_totalAssists);
            this.Assert_stats(MatchDayVars.matchDay_stats_precShots, MatchDayVars.matchDay_stats_totalAssists);
            this.Assert_stats(MatchDayVars.matchDay_stats_shotsGoals, MatchDayVars.matchDay_stats_totalAssists);
            this.Assert_stats(MatchDayVars.matchDay_stats_goalsVSshots, MatchDayVars.matchDay_stats_totalAssists);
            this.Assert_stats(MatchDayVars.matchDay_stats_chances, MatchDayVars.matchDay_stats_totalAssists);
            this.Assert_stats(MatchDayVars.matchDay_stats_totalAssists, MatchDayVars.matchDay_stats_totalAssists);
            
            //Step 5: Click a right player and click a left player
            madrid.Tap(MatchDayVars.matchDay_stats_home_but);
            utils.Sleep(3);
            madrid.Tap(MatchDayVars.matchDay_stats_home_player);

            AppResult[] result_player_graphic = madrid.Query(MatchDayVars.matchDay_stats_home_graphics);
            String result_player_text = result_player_graphic[0].Text;
            Assert.AreNotEqual(result_home_text, result_player_text);
        }

        /***************** MATCH AREA > V.T POST MATCH > TOP MATCH INFO PANEL *****************/
        [Test]
        //Top information post match
        public void Test_30938(){
            //Step 2: Click on "Match Area" through navbar
            madrid.Tap(NavigationBarVars.navbar_Match_area_but);

            //Step 3: Click on "Only in the App"
            utils.Sleep(5);
            if (utils.existsElement(MatchDayVars.matchDay_location_app_but))
                madrid.Tap(MatchDayVars.matchDay_location_app_but);
            madrid.WaitForElement(NavigationBarVars.match_area_Title);

            Assert.True(utils.existsElement(MatchDayVars.matchDay_matchArea_feeds), "Feeds tab doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_matchArea_video), "Video tab doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_matchArea_stats), "Stats tab doesn't exist");
            //Assert.True(utils.existsElement(MatchDayVars.matchDay_matchArea_play), "Play tab doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_matchArea_timeline_finish), "Timeline doesn't exist");
            //AppResult[] result_list = madrid.Query(MatchDayVars.matchDay_matchArea_timeline_finish);
            //Assert.True(result_list[0].Text.Contains("Finalizado"));


            madrid.SetOrientationLandscape();
            utils.Sleep(5);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_horizontally_home_img), "Home team icon doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_horizontally_away_img), "Away team icon doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_horizontally_home_score), "Home team score doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_horizontally_away_score), "Away team score doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_horizontally_timeline_finish), "Timeline doesn't exist");
            madrid.SetOrientationPortrait();

        }

        /***************** NEXT GAMES PLACEHOLDER *****************/
        
        [Test]
        //Swipe on Next games placeholder to Pre Match Day
        public void Test_35030()
        {

            //Step 2: Swipe on Next games placeholder
            utils.Sleep(5);

            int cont = 0;
            while ((!utils.existsElement(HomeVars.home_match_area_but)) && (cont < 5))
            {
				madrid.SwipeRightToLeft(HomeVars.home_Pager_Games_View, 0.8, 2000, true);
                if (utils.existsElement(HomeVars.home_buy_ticket_but))
                    cont += 1;
            }

            Assert.True(utils.existsElement(HomeVars.home_game_home_icon), "Home team icon doesn't exist");
            Assert.True(utils.existsElement(HomeVars.home_game_away_icon), "Away team icon doesn't exist");
            Assert.True(utils.existsElement(HomeVars.home_Game_Week), "Competition and week doesn't exist");
            Assert.True(utils.existsElement(HomeVars.home_game_home_name), "Home team name doesn't exist");
            Assert.True(utils.existsElement(HomeVars.home_game_away_name), "Away team name doesn't exist");
            Assert.True(utils.existsElement(HomeVars.home_home_score), "Home team score doesn't exist");
            Assert.True(utils.existsElement(HomeVars.home_away_score), "Away team score doesn't exist");
            Assert.True(utils.existsElement(HomeVars.home_home_score), "Home team score doesn't exist");
			Assert.True(utils.existsElement(HomeVars.home_game_time), "Time game doesn't exist");

        }

        //Auxiliary methods
        private void Assert_stats(Func<AppQuery, AppQuery> stat, Func<AppQuery, AppQuery> final_stat)
        {
            while (!utils.existsElement(stat) && !utils.existsElement(final_stat))
                madrid.ScrollDown(MatchDayVars.matchDay_stats_list, ScrollStrategy.Gesture, 0.30, 2000, true);

            Assert.True(utils.existsElement(stat), stat.ToString() + " doesn't exist");
        }
    }
}
