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

    public class HomeTests
    {
        IApp madrid;
        Utilities utils;
        Platform platform;



        public HomeTests(Platform platform)
        {
            this.platform = platform;
        }



        [SetUp]
        public void BeforeEachTest()
        {
            madrid = AppInitializer.StartApp(platform);
            //madrid.Repl();
            utils = new Utilities(madrid);
            utils.Login();
        }



        [TearDown]
        public void AfterEachTest()
        {
            //            utils.Enter_Home();
            //            utils.Sign_Off();
        }



        [Test]
        // Update content
        public void Test_34305()
        {
            madrid.SwipeRightToLeft(HomeVars.home_Pager_Games_View);
            AppResult[] result;
            result = madrid.Query(HomeVars.home_Game_Week);
            String week = result[0].Text;
            //madrid.ScrollUp();
            madrid.ScrollUp(HomeVars.home_Pager_Games_View, ScrollStrategy.Gesture, 0.99, 4000, true);
            result = madrid.Query(HomeVars.home_Game_Week);
            String newWeek = result[0].Text;
            Assert.False(week.Equals(newWeek), "No se actualiza el contenido al hacer scroll");
        }



        public bool isFootbal()
        {
            AppResult[] result;
            result = madrid.Query(PlaceholderVars.Next_Games_ph_competition);
            String competition = result[0].Text;
            if (competition == Strings.LIGA_BBVA || competition == Strings.CHAMPIONS || competition == Strings.INTERNATIONALCC)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [Test]
        public void Test_34414()
        {
            bool sport = isFootbal();
            madrid.Tap(NavigationBarVars.navbar_Match_area_but);
            utils.Sleep(2);
            if (madrid.Query(MatchDayVars.matchDay_location_app_but).Length > 0)
            {
                madrid.Tap(MatchDayVars.matchDay_location_app_but);
            }
            bool isMatchFootball = utils.existsElement(MatchDayVars.matchDay_video_cameras);
            Assert.True(sport == isMatchFootball, "No corresponde el deporte con el area de partido");
            madrid.Tap(MatchAreaVars.match_area_goBack);


            madrid.Tap(HomeVars.home_Change_Sport_but);
            utils.Sleep(2);
            bool newSport = isFootbal();
            Assert.False(sport == newSport, "No ha cabiado el deporte");
            madrid.Tap(NavigationBarVars.navbar_Match_area_Basket_but);
            utils.Sleep(2);
            if (madrid.Query(MatchDayVars.matchDay_location_app_but).Length > 0)
            {
                madrid.Tap(MatchDayVars.matchDay_location_app_but);
            }
            isMatchFootball = utils.existsElement(MatchDayVars.matchDay_video_cameras);
            Assert.True(newSport == isMatchFootball, "No corresponde el deporte con el area de partido");
            madrid.Tap(MatchAreaVars.match_area_goBack);
            madrid.Tap(HomeVars.home_Change_Sport_but);





        }
    }
}
