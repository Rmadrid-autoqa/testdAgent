using NUnit.Framework;
using RealMadrid_UITest.Variables;
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


    public class MatchDayBasketballTests {
        IApp madrid;
        Utilities utils;
        Platform platform;


        public MatchDayBasketballTests(Platform platform) {
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

        /***************** CLASSIFICATION AND FIXTURES PLACEHOLDER / FIXTURES *****************/

        [Test]
        //Go to Basketball Area Match through fixtures placeholder
        public void Test_35041() {
            //Step 2: Scroll to Classification placeholder and swipe to Fixtures tab
            utils.Change_Sport();
            Go_To_Slow(HomeVars.home_content, MatchDayVars.matchDay_home_clasification);
            madrid.Tap(MatchDayVars.matchDay_home_match);
			madrid.WaitForElement(MatchDayVars.matchDay_home_calendar);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_home_calendar), "Calendar doesn't exist");

            //Step 3: Click on Real Madrid match, during/pre/post match
            utils.Sleep(5);
            if (!utils.existsElement(MatchDayVars.matchDay_calendar_day))
                madrid.Tap(MatchDayVars.matchDay_calendar_next_but);

            madrid.Tap(MatchDayVars.matchDay_calendar_day);

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

        /***************** MATCH AREA / VIRTUAL TICKET DURING MATCH / FEEDS *****************/
        /*    
        [Test]
        public void Test_35043()
        {

            //Step 2: Click on "Match Area" through navbar 
            utils.Change_Sport();
            madrid.Tap(NavigationBarVars.navbar_Match_area_but);

            //Step 3:on "On Tv" icon.
            madrid.Tap(MatchDayVars.matchDay_location_tv_but);
            madrid.Tap(MatchDayVars.matchDay_feeds_lineup);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_feeds_team_name), "Team name doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_feeds_playerHome_number), "Players number don't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_feeds_playerHome_name), "Players name don't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_feeds_playerAway_number), "Players number don't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_feeds_playerAway_name), "Players name don't exist");

            madrid.Tap(MatchDayVars.matchDay_feeds_feeds);
            madrid.Tap(MatchDayVars.matchDay_feeds_summary);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_feeds_summary_list), "Summary doesn't exist");

            madrid.SetOrientationLandscape();
            utils.Sleep(5);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_horizontally_feeds_timeline), "Timeline doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_horizontally_feeds_summary), "Summary doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_feeds_team_name), "Team doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_feeds_playerHome_number), "Players number don't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_feeds_playerHome_name), "Players name don't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_feeds_playerAway_number), "Players number don't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_feeds_playerAway_name), "Players name don't exist");
            //Score doesn't exist
            madrid.SetOrientationPortrait();

        }
        */

        /************* MATCH AREA > VIRTUAL TICKET DURING MATCH > STATS *************/
        /*
        [Test]
        public void Test_35044()
        {
            //Step 2: Basketball Match stats During match
            utils.Change_Sport();
            madrid.Tap(NavigationBarVars.navbar_Match_area_but);

            //Step 3: Click on "Only in the App" icon -> virtual tickect is displayed
            madrid.Tap(MatchDayVars.matchDay_location_app_but);
            madrid.tForElemeWaint(NavigationBarVars.match_area_Title);
            Assert.True(utils.existsElement(NavigationBarVars.match_area_Title));
      
            //Step 4: Click on "Stats" tap
            madrid.WaitForElement(MatchDayVars.matchDay_matchArea_stats);
            madrid.Tap(MatchDayVars.matchDay_matchArea_stats);

            Assert.True(utils.existsElement(MatchDayVars.matchDay_stats_home_img), "Home team icon doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_stats_home_name), "Home team name doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_stats_away_img), "Away team icon doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_stats_away_name), "Away team name doesn't exist");

            madrid.Tap(MatchDayVars.matchDay_stats_home_but);
            AppResult[] players_home = madrid.Query(MatchDayVars.matchDay_stats_players_list);
            Assert.True(players_home.Length > 2, "Home team players doesn't exist");
            madrid.Back();
            madrid.Tap(MatchDayVars.matchDay_stats_away_but);
            AppResult[] players_away = madrid.Query(MatchDayVars.matchDay_stats_players_list);
            Assert.True(players_home.Length > 2, "Away team players doesn't exist");
            madrid.Back();

            //Teams stats
            this.Assert_stats(MatchDayVars.matchDay_stats_points);
            this.Assert_stats(MatchDayVars.matchDay_stats_free_shots);
            this.Assert_stats(MatchDayVars.matchDay_stats_free_scored);
            this.Assert_stats(MatchDayVars.matchDay_stats_two_points);
            this.Assert_stats(MatchDayVars.matchDay_stats_two_scored);
            this.Assert_stats(MatchDayVars.matchDay_stats_three_points);
            this.Assert_stats(MatchDayVars.matchDay_stats_three_scored);
            this.Assert_stats(MatchDayVars.matchDay_stats_offensive_rebound);
            this.Assert_stats(MatchDayVars.matchDay_stats_defensive_rebound);
            this.Assert_stats(MatchDayVars.matchDay_stats_total_rebound);
            this.Assert_stats(MatchDayVars.matchDay_stats_assists);
            this.Assert_stats(MatchDayVars.matchDay_stats_turnovers);
            this.Assert_stats(MatchDayVars.matchDay_stats_steals);
            this.Assert_stats(MatchDayVars.matchDay_stats_bloks);
            this.Assert_stats(MatchDayVars.matchDay_stats_received_fouls);
            this.Assert_stats(MatchDayVars.matchDay_stats_fouls);

            //Step 5: Click a right player and click a left player
            madrid.Tap(MatchDayVars.matchDay_stats_home_but);
            madrid.Tap(MatchDayVars.matchDay_stats_home_player);

            //Player stats
            this.Assert_stats(MatchDayVars.matchDay_stats_points);
            this.Assert_stats(MatchDayVars.matchDay_stats_minutes);
            this.Assert_stats(MatchDayVars.matchDay_stats_evaluation);
            this.Assert_stats(MatchDayVars.matchDay_stats_free_shots);
            this.Assert_stats(MatchDayVars.matchDay_stats_free_scored);
            this.Assert_stats(MatchDayVars.matchDay_stats_two_points);
            this.Assert_stats(MatchDayVars.matchDay_stats_two_scored);
            this.Assert_stats(MatchDayVars.matchDay_stats_three_points);
            this.Assert_stats(MatchDayVars.matchDay_stats_three_scored);
            this.Assert_stats(MatchDayVars.matchDay_stats_offensive_rebound);
            this.Assert_stats(MatchDayVars.matchDay_stats_defensive_rebound);
            this.Assert_stats(MatchDayVars.matchDay_stats_total_rebound);
            this.Assert_stats(MatchDayVars.matchDay_stats_assists);
            this.Assert_stats(MatchDayVars.matchDay_stats_turnovers);
            this.Assert_stats(MatchDayVars.matchDay_stats_steals);
            this.Assert_stats(MatchDayVars.matchDay_stats_bloks);
            this.Assert_stats(MatchDayVars.matchDay_stats_received_fouls);
            this.Assert_stats(MatchDayVars.matchDay_stats_fouls);
            
        }
        */



        /***************** MATCH AREA > VISTUAL TICKET POST MATCH > STATS *****************/

        [Test]
        //Basketball Match stats Post Match
        public void Test_35047() {
            //Step 2: Click on "Match Area" through navbar
            utils.Change_Sport();
            madrid.Tap(NavigationBarVars.navbar_Match_area_Basket_but);

            //Step 3: Click on "Only in the App" icon
            utils.Sleep(5);
            if (utils.existsElement(MatchDayVars.matchDay_location_app_but))
                madrid.Tap(MatchDayVars.matchDay_location_app_but);

            //Step 4: Click on "Stats" tab
            madrid.Tap(MatchDayVars.matchDay_matchArea_stats);

            Assert.True(utils.existsElement(MatchDayVars.matchDay_stats_home_img), "Home team icon doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_stats_home_name), "Home team name doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_stats_away_img), "Away team icon doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_stats_away_name), "Away team name doesn't exist");

            madrid.Tap(MatchDayVars.matchDay_stats_home_but);
			madrid.WaitForElement(MatchDayVars.matchDay_stats_players_list);
            utils.Sleep(3);
			AppResult[] players_home = madrid.Query(MatchDayVars.matchDay_stats_players_list);
            Assert.True(players_home.Length > 2, "Home team players doesn't exist");

			madrid.Tap(MatchAreaVars.match_area_identifier);

			madrid.Tap(MatchDayVars.matchDay_stats_away_but);
			madrid.WaitForElement(MatchDayVars.matchDay_stats_players_list);
			utils.Sleep(3);
			AppResult[] players_away = madrid.Query(MatchDayVars.matchDay_stats_players_list);
            Assert.True(players_home.Length > 2, "Away team players doesn't exist");

			madrid.Tap(MatchAreaVars.match_area_identifier);

            //Team stats         
            this.Assert_stats(MatchDayVars.matchDay_stats_points);
            this.Assert_stats(MatchDayVars.matchDay_stats_free_shots);
            this.Assert_stats(MatchDayVars.matchDay_stats_free_scored);
            this.Assert_stats(MatchDayVars.matchDay_stats_two_points);
            this.Assert_stats(MatchDayVars.matchDay_stats_two_scored);
            this.Assert_stats(MatchDayVars.matchDay_stats_three_points);

			Go_To_Slow(MatchDayVars.matchDay_stats_list,MatchDayVars.matchDay_stats_assists); 

            this.Assert_stats(MatchDayVars.matchDay_stats_three_scored);
            this.Assert_stats(MatchDayVars.matchDay_stats_offensive_rebound);
            this.Assert_stats(MatchDayVars.matchDay_stats_defensive_rebound);
            this.Assert_stats(MatchDayVars.matchDay_stats_total_rebound);
            this.Assert_stats(MatchDayVars.matchDay_stats_assists);

            Go_To_Slow(MatchDayVars.matchDay_stats_list, MatchDayVars.matchDay_stats_fouls); 
            this.Assert_stats(MatchDayVars.matchDay_stats_turnovers);
            this.Assert_stats(MatchDayVars.matchDay_stats_steals);
            this.Assert_stats(MatchDayVars.matchDay_stats_bloks);
            this.Assert_stats(MatchDayVars.matchDay_stats_received_fouls);
            this.Assert_stats(MatchDayVars.matchDay_stats_fouls);
            
            //Step 5: Click a right player and click a left player
            madrid.Tap(MatchDayVars.matchDay_stats_home_but);
            madrid.Tap(MatchDayVars.matchDay_stats_home_player);

            //Player stats
            this.Assert_stats(MatchDayVars.matchDay_stats_points);
            this.Assert_stats(MatchDayVars.matchDay_stats_minutes);
            this.Assert_stats(MatchDayVars.matchDay_stats_evaluation);
            this.Assert_stats(MatchDayVars.matchDay_stats_free_shots);
            this.Assert_stats(MatchDayVars.matchDay_stats_free_scored);
            this.Assert_stats(MatchDayVars.matchDay_stats_two_points);
            this.Assert_stats(MatchDayVars.matchDay_stats_two_scored);
            this.Assert_stats(MatchDayVars.matchDay_stats_three_points);
            this.Assert_stats(MatchDayVars.matchDay_stats_three_scored);
            this.Assert_stats(MatchDayVars.matchDay_stats_offensive_rebound);
            this.Assert_stats(MatchDayVars.matchDay_stats_defensive_rebound);
            this.Assert_stats(MatchDayVars.matchDay_stats_total_rebound);
            this.Assert_stats(MatchDayVars.matchDay_stats_assists);
            this.Assert_stats(MatchDayVars.matchDay_stats_turnovers);
            this.Assert_stats(MatchDayVars.matchDay_stats_steals);
            this.Assert_stats(MatchDayVars.matchDay_stats_bloks);
            this.Assert_stats(MatchDayVars.matchDay_stats_received_fouls);
            this.Assert_stats(MatchDayVars.matchDay_stats_fouls);

        }

        /************* MATCH AREA > VISTUAL TICKET POST MATCH > TOP MATCH INFO PANEL *************/
        [Test]
        //Basketball Top information Post match
        public void Test_35048(){

            //Step 2: Scroll and Click on "Play with us" placeholder.
            utils.Change_Sport();
            utils.Sleep(10);
            utils.Go_To(HomeVars.home_content, MatchDayVars.matchDay_home_playwithus_but);
            madrid.Tap(MatchDayVars.matchDay_home_playwithus_but);
            madrid.WaitForElement(MatchDayVars.matchDay_location_title);

            //Step 3: Click on "Only in the app" icon.
            madrid.Tap(MatchDayVars.matchDay_location_app_but);
            madrid.WaitForElement(NavigationBarVars.match_area_Title);

            Assert.True(utils.existsElement(MatchDayVars.matchDay_matchArea_video), "Video tab doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_matchArea_feeds), "Feeds tab doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_matchArea_stats), "Stats tab doesn't exist");
            //Assert.True(utils.existsElement(MatchDayVars.matchDay_matchArea_play), "Play tab doesn't exist");

            madrid.SetOrientationLandscape();
            madrid.WaitForElement(MatchDayVars.matchDay_horizontally_home_img);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_horizontally_home_img), "Home team icon doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_horizontally_home_name), "Home team name doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_horizontally_away_img), "Away team icon doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_horizontally_away_name), "Away team name doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_horizontally_home_score), "Home team score doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_horizontally_away_score), "Away team score doesn't exist");
            AppResult[] result_list = madrid.Query(MatchDayVars.matchDay_matchArea_timeline_finish);
            //Assert.True(result_list[0].Text.Contains("Finalizado"));

            madrid.SetOrientationPortrait();
            madrid.WaitForElement(MatchDayVars.matchDay_matchArea_home_img_basket);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_matchArea_home_img_basket), "Home team icon doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_matchArea_home_name_basket), "Home team name doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_matchArea_away_img_basket), "Away team icon doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_matchArea_away_name_basket), "Away team name doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_matchArea_home_score_basket), "Home team score doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_matchArea_away_score_basket), "Away team score doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_matchArea_timeline_finish_basket),"Timeline doesn't exist");

        }

        /***************** MATCH AREA > VISTUAL TICKET PRE MATCH > FEEDS *****************/
        /*
        [Test]
        public void Test_35049()
        {

            //Step 2: Click on "Match Area" through navbar 
            utils.Change_Sport();
            madrid.Tap(NavigationBarVars.navbar_Match_area_but);

            //Step 3:on "On Tv" icon.
            madrid.Tap(MatchDayVars.matchDay_location_tv_but);
            madrid.SetOrientationLandscape();
            AppResult[] result_error = madrid.Query(MatchDayVars.matchDay_matchArea_error);
            Assert.True( result_error.Length > 1, "Error message doesn't exist");

   
        }
        */




        /************* NEXT GAMES PLACEHOLDER *************/

        [Test]
        //Swipe on Nezt games placeholder to Basketball pre match Day
        public void Test_35053()
        {
            //Step 2: Swipe on Next games placeholder
            utils.Change_Sport();
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
            Assert.True(utils.existsElement(HomeVars.home_home_score), "Home team score doesn't exist");
            Assert.True(utils.existsElement(HomeVars.home_away_score), "Away team score doesn't exist");
            Assert.True(utils.existsElement(HomeVars.home_home_score), "Home team score doesn't exist");
            Assert.True(utils.existsElement(HomeVars.home_game_time), "Time game doesn't exist");
            //Assert.True(utils.existsElement(HomeVars.home_match_area_but), "Match Area button doesn't exist");
			utils.Change_Sport();
        }




        //Auxiliary methods
        private void Assert_stats(Func<AppQuery, AppQuery> stat){
            while (!utils.existsElement(stat) && !utils.existsElement(MatchDayVars.matchDay_stats_received_fouls))
                madrid.ScrollDown(MatchDayVars.matchDay_stats_list, ScrollStrategy.Gesture, 0.30, 2000, true);
            Assert.True(utils.existsElement(stat), stat.ToString() + " doesn't exist");
        }

    }
}
