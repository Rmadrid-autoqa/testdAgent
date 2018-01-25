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


namespace RealMadrid_UITest
{
    //[TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]


    public class PlaceholderTest
    {
        IApp madrid;
        Utilities utils;
        Platform platform;



        public PlaceholderTest(Platform platform)
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

        [TestFixtureSetUp]
        public void reopen()
        {
            madrid = AppInitializer.StartApp(platform);
            utils = new Utilities(madrid);
        }



        [TearDown]
        public void AfterEachTest()
        {
            //utils.Enter_Home();
            //				utils.Sign_Off();
        }

        // Auxiliary methods
        private void Go_To_home(Func<AppQuery, AppQuery> view, Func<AppQuery, AppQuery> element)
        {
            while (madrid.Query(element).Length == 0)
            {
                madrid.ScrollDown(view, ScrollStrategy.Gesture, 0.15, 300, true);
            }
        }

        
        private void Assert_stats(Func<AppQuery, AppQuery> stat, Func<AppQuery, AppQuery> final_stat)
        {
            while (!utils.existsElement(stat) && !utils.existsElement(final_stat))
                madrid.ScrollDown(MatchDayVars.matchDay_stats_list, ScrollStrategy.Gesture, 0.30, 2000, true);

            Assert.True(utils.existsElement(stat), stat.ToString() + " doesn't exist");
        }

        /******************************************** PLACEHOLDER / Classification and Fixtures ************************************************/

		/*[Test]
		public void MiTest()
		{
			madrid.Repl();
        }*/

		[Test]
		public void ipad_iphone_Example()
		{
			if (utils._device == "Tablet")
				
			{

				madrid.Tap(NavigationBarVars.navbar_Profile_but);
					
			}

			else 
				
			{
				madrid.Tap(NavigationBarVars.navbar_Match_area_but);

			}
		}



        [Test]
        //See finished match on Season Calendar
        public void Test_34246()
        {
			if (utils._device == "Tablet")
			{
				//Step 3: Scroll and Navigate on season calendar placeholder
             	Go_To_home(HomeVars.home_content_right_column, PlaceholderVars.calendar_fixture_home);
				//Step 4: Click on finished match
				madrid.Tap(PlaceholderVars.calendar_fixture_home);
				//Step 5: Click Match Area
				madrid.WaitForElement(PlaceholderVars.calendar_matcharea_but_Tablet);
				madrid.Tap(PlaceholderVars.calendar_matcharea_but);
				madrid.WaitForElement(MatchAreaVars.match_area_identifier);
				Assert.True(utils.existsElement(MatchAreaVars.match_area_identifier), "Match area title isn't displayed");
				//Step 6: Go back
				utils.Sleep(5);
				madrid.DoubleTap(MatchAreaVars.match_area_goBack_Tablet);
				//madrid.Tap(MatchAreaVars.match_area_goBack_Tablet);
				madrid.WaitForElement(PlaceholderVars.calendar_fixture_home);
				Assert.True(utils.existsElement(PlaceholderVars.calendar_fixture_home), "Classification placeholder isn't displayed");

				//Step 2 : Switch @Sport

				madrid.Tap(HomeVars.home_Change_Sport_but);
				//Step 3: Scroll and Navigate on season calendar placeholder
             	Go_To_home(HomeVars.home_content_right_column, PlaceholderVars.calendar_fixture_home);
				//Step 4: Click on finished match
				//madrid.Tap(PlaceholderVars.calendar_tab_text);
				madrid.Tap(PlaceholderVars.calendar_fixture_home);
				//Step 5: Click Match Area
				madrid.WaitForElement(PlaceholderVars.calendar_matcharea_but_Tablet);
				madrid.Tap(PlaceholderVars.calendar_matcharea_but);
				madrid.WaitForElement(MatchAreaVars.match_area_identifier);
				Assert.True(utils.existsElement(MatchAreaVars.match_area_identifier), "Match area title isn't displayed");
				//Step 6: Go back
				utils.Sleep(3);
				madrid.DoubleTap(MatchAreaVars.match_area_goBack_Tablet);
				madrid.WaitForElement(PlaceholderVars.calendar_fixture_home);
				Assert.True(utils.existsElement(PlaceholderVars.calendar_fixture_home), "Classification placeholder isn't displayed");
				madrid.WaitForElement(HomeVars.home_Change_Sport_but);
				madrid.Tap(HomeVars.home_Change_Sport_but);
			}
			else
			{ 
				//Step 3: Scroll and Navigate on season calendar placeholder
				Go_To_home(HomeVars.home_content, PlaceholderVars.calendar_tab_text);
				//Step 4: Click on finished match
				madrid.Tap(PlaceholderVars.calendar_tab_text);
				madrid.Tap(PlaceholderVars.calendar_fixture_home);
				//Step 5: Click Match Area
				madrid.WaitForElement(PlaceholderVars.calendar_matcharea_but);
				madrid.Tap(PlaceholderVars.calendar_matcharea_but);
				madrid.WaitForElement(MatchAreaVars.match_area_identifier);
				Assert.True(utils.existsElement(MatchAreaVars.match_area_identifier), "Match area title isn't displayed");
				//Step 6: Go back
				madrid.Tap(MatchAreaVars.match_area_goBack);
				madrid.WaitForElement(PlaceholderVars.classification_tab_text);
				Assert.True(utils.existsElement(PlaceholderVars.classification_tab_text), "Classification placeholder isn't displayed");

				//Step 2 : Switch @Sport

				madrid.Tap(HomeVars.home_Change_Sport_but);
				//Step 3: Scroll and Navigate on season calendar placeholder
				Go_To_home(HomeVars.home_content, PlaceholderVars.calendar_tab_text);
				//Step 4: Click on finished match
				madrid.Tap(PlaceholderVars.calendar_tab_text);
				madrid.Tap(PlaceholderVars.calendar_fixture_home);
				//Step 5: Click Match Area
				madrid.WaitForElement(PlaceholderVars.calendar_matcharea_but);
				madrid.Tap(PlaceholderVars.calendar_matcharea_but);
				madrid.WaitForElement(MatchAreaVars.match_area_identifier);
				Assert.True(utils.existsElement(MatchAreaVars.match_area_identifier), "Match area title isn't displayed");
				//Step 6: Go back
				madrid.Tap(MatchAreaVars.match_area_goBack);
				madrid.WaitForElement(PlaceholderVars.classification_tab_text);
				Assert.True(utils.existsElement(PlaceholderVars.classification_tab_text), "Classification placeholder isn't displayed");
				madrid.WaitForElement(HomeVars.home_Change_Sport_but);
				madrid.Tap(HomeVars.home_Change_Sport_but);
			}

        }
        

        [Test]
        //See qualifying (eliminatoria) finished match on Season Calendar
        public void Test_35004()
        {
            //Step 2: Swith @Football
            //Step 3: Scroll and Navigate on season calendar placeholder.
			Go_To_home(HomeVars.home_content, PlaceholderVars.calendar_tab_text);
            //Step 4: Click on a finished match that is a classification round.
            madrid.Tap(PlaceholderVars.calendar_tab_text);         
           
            int counter = 0;
            bool a = false;
            while ((a == false) && (counter < 3))
            {
                if (utils.existsElement(PlaceholderVars.calendar_month))
                {
                    AppResult[] MonthName;
                    MonthName = madrid.Query(PlaceholderVars.calendar_month);
                    string MonthName1 = MonthName[0].Text;
                    
                    if (MonthName1.Equals("FEBRERO 2017"))
                    {
                        a = true;
                    }
                    else
                    {
                        utils.Sleep(4);
                        madrid.WaitForElement(PlaceholderVars.calendar_month);
                        madrid.Tap(PlaceholderVars.calendar_previous_month);
                        counter++;
                    }
                }
            }

            if (counter == 5)
            {
                Assert.True(false, "See qualifying - FAILURE Too much waiting time");
            }

            madrid.Tap(PlaceholderVars.calendar_RM_NAPOLI_3);

            Assert.True(utils.existsElement(PlaceholderVars.Finish_match_CompetitionChampions_popup),"Champions isn't displayed");
            Assert.True(utils.existsElement(PlaceholderVars.Finish_match_roundEighthFinals_popup), "Eighth-finals isn't displayed");
            Assert.True(utils.existsElement(PlaceholderVars.Finish_match_homeicon_popup), "Homeicon isn't displayed");
            Assert.True(utils.existsElement(PlaceholderVars.Finish_match_awayicon_popup), "Awayicon isn't displayed");
            Assert.True(utils.existsElement(PlaceholderVars.Finish_match_homename_popup), "Homename isn't displayed");
            Assert.True(utils.existsElement(PlaceholderVars.Finish_match_awayname_popup), "Awayname isn't displayed");
            Assert.True(utils.existsElement(PlaceholderVars.Finish_match_homescore_popup), "Homescore isn't displayed");
            Assert.True(utils.existsElement(PlaceholderVars.Finish_match_awayscore_popup), "Awayscore isn't displayed");
            Assert.True(utils.existsElement(PlaceholderVars.Finish_match_matchArea_popup_but), "Match Area button isn't displayed");
            Assert.True(utils.existsElement(PlaceholderVars.Finish_match_ok_popup_but), "Ok button isn't displayed");

            madrid.Tap(PlaceholderVars.Finish_match_ok_popup_but);

            //Step 2: Swith @Basketball
            madrid.Tap(HomeVars.home_Change_Sport_but);

            //Step 3: Scroll and Navigate on season calendar placeholder.
			Go_To_home(HomeVars.home_content, PlaceholderVars.calendar_tab_text);
            //Step 4: Click on a finished match that is a classification round.
            madrid.Tap(PlaceholderVars.calendar_tab_text);

            //int counter2 = 0;
            bool b = false;
            while ((b == false) && (counter < 20))
            {
                if (utils.existsElement(PlaceholderVars.calendar_month))
                {
                    AppResult[] MonthName;
                    MonthName = madrid.Query(PlaceholderVars.calendar_month);
                    string MonthName1 = MonthName[0].Text;

                    if (MonthName1.Equals("marzo 2017"))
                    {
                        b = true;
                    }
                    else
                    {
                        utils.Sleep(4);
                        madrid.WaitForElement(PlaceholderVars.calendar_month);
                        madrid.Tap(PlaceholderVars.calendar_previous_month);
                        counter++;
                    }
                }
            }

            if (counter == 20)
            {
                Assert.True(false, "See qualifying - FAILURE Too much waiting time");
            }

            madrid.Tap(PlaceholderVars.calendar_RM_FENERBAHCE_61);

            Assert.True(utils.existsElement(PlaceholderVars.Finish_match_CompetitionEuroleague_popup), "EuroLeague isn't displayed");
            Assert.True(utils.existsElement(PlaceholderVars.Finish_match_roundFirstRound_popup), "First Round isn't displayed");
            Assert.True(utils.existsElement(PlaceholderVars.Finish_match_homeicon_popup), "Homeicon isn't displayed");
            Assert.True(utils.existsElement(PlaceholderVars.Finish_match_awayicon_popup), "Awayicon isn't displayed");
            Assert.True(utils.existsElement(PlaceholderVars.Finish_match_homename_popup), "Homename isn't displayed");
            Assert.True(utils.existsElement(PlaceholderVars.Finish_match_awayname_popup), "Awayname isn't displayed");
            Assert.True(utils.existsElement(PlaceholderVars.Finish_match_homescore_popup), "Homescore isn't displayed");
            Assert.True(utils.existsElement(PlaceholderVars.Finish_match_awayscore_popup), "Awayscore isn't displayed");
            Assert.True(utils.existsElement(PlaceholderVars.Finish_match_matchArea_popup_but), "Match Area button isn't displayed");
            Assert.True(utils.existsElement(PlaceholderVars.Finish_match_ok_popup_but), "Ok button isn't displayed");

            madrid.Tap(PlaceholderVars.Finish_match_ok_popup_but);
            madrid.Tap(HomeVars.home_Change_Sport_but);


        }

        
        [Test]
        //Full Champions League Classification
        public void Test_34435()
        {
			if (utils._device == "Tablet")
			{
				//Step 2: Scroll to Calendar/Classification/Matches placeholder and swipe to Classification
				//Go_To_home(HomeVars.home_content, PlaceholderVars.calendar_tab_text);
				Assert.True(utils.existsElement(PlaceholderVars.classification_ph_title), "La liga title isn't displayed");
				Assert.True(utils.existsElement(PlaceholderVars.classification_view_all_but), "Viall button isn't displayed");
				Assert.True(utils.existsElement(PlaceholderVars.classification_position_1), "Position 1 isn't displayed");
				Assert.True(utils.existsElement(PlaceholderVars.classification_position_2), "Position 2 isn't displayed");
				Assert.True(utils.existsElement(PlaceholderVars.classification_position_3), "Position 3 isn't displayed");
				Assert.True(utils.existsElement(PlaceholderVars.classification_position_4), "Position 4 isn't displayed");
				Assert.True(utils.existsElement(PlaceholderVars.classification_position_5), "Position 5 isn't displayed");
				Assert.True(utils.existsElement(PlaceholderVars.classification_position_6), "Position 6 isn't displayed");
				//Step 3: Click on View all
				madrid.Tap(PlaceholderVars.classification_view_all_but);
				Assert.True(utils.existsElement(PlaceholderVars.classification_tab_text), "La liga tab text isn't displayed");
				Assert.True(utils.existsElement(PlaceholderVars.classification_title), "Classification title isn't displayed");
				//Step 4: Click on Champions League tab
				madrid.Tap(PlaceholderVars.classification_Champions_tab_text);
				Assert.True(utils.existsElement(PlaceholderVars.classification_current_status), " Current status isn't displayed");
				//Step 5: Click on Round comboBox and select a round
				madrid.Tap(PlaceholderVars.classification_combobox);
				madrid.Tap(PlaceholderVars.classification_combobox_champions_EighthFinals);
				Assert.True(utils.existsElement(PlaceholderVars.classification_Napoli), "Napoli team isn't displayed");
			}
			else
			{
				//Step 2: Scroll to Calendar/Classification/Matches placeholder and swipe to Classification
				Go_To_home(HomeVars.home_content, PlaceholderVars.calendar_tab_text);
	            Assert.True(utils.existsElement(PlaceholderVars.classification_ph_title), "La liga title isn't displayed");
	            Assert.True(utils.existsElement(PlaceholderVars.classification_view_all_but), "Viall button isn't displayed");
	            Assert.True(utils.existsElement(PlaceholderVars.classification_position_1), "Position 1 isn't displayed");
	            Assert.True(utils.existsElement(PlaceholderVars.classification_position_2), "Position 2 isn't displayed");
	            Assert.True(utils.existsElement(PlaceholderVars.classification_position_3), "Position 3 isn't displayed");
	            Assert.True(utils.existsElement(PlaceholderVars.classification_position_4), "Position 4 isn't displayed");
	            Assert.True(utils.existsElement(PlaceholderVars.classification_position_5), "Position 5 isn't displayed");
				Assert.True(utils.existsElement(PlaceholderVars.classification_position_6), "Position 6 isn't displayed");
				//Step 3: Click on View all
	            madrid.Tap(PlaceholderVars.classification_view_all_but);
	            Assert.True(utils.existsElement(PlaceholderVars.classification_tab_text), "La liga tab text isn't displayed");
	            Assert.True(utils.existsElement(PlaceholderVars.classification_title), "Classification title isn't displayed");
	            //Step 4: Click on Champions League tab
	            madrid.Tap(PlaceholderVars.classification_Champions_tab_text);
	            Assert.True(utils.existsElement(PlaceholderVars.classification_current_status), " Current status isn't displayed");
	            //Step 5: Click on Round comboBox and select a round
	            madrid.Tap(PlaceholderVars.classification_combobox);
	            madrid.Tap(PlaceholderVars.classification_combobox_champions_EighthFinals);
	            Assert.True(utils.existsElement(PlaceholderVars.classification_Napoli), "Napoli team isn't displayed");
			}
				
        }

        /******************************************** PLACEHOLDER / List Generic Content ************************************************/
        /*
        [Test]
        //Check the List Generic Content
        public void Test_35183()
        {
            //Step 1: If placeholder is not visible
            //Step 2: Open Administration and Login.
            //Step 3: Active a Placeholder
            //Step 4: Open application and login
            //Step 5: Go to List Generic Content Placeholder(Cristiano image)
            //Step 6: Tap on it
            utils.Go_To(HomeVars.home_content, PlaceholderVars.List_generic_content_ph);
            madrid.Tap(PlaceholderVars.List_generic_content_ph);
            madrid.WaitForElement(NewsVars.news_title);
            Assert.True(utils.existsElement(NewsVars.news_title), "News title isn't displayed");

        }

        /******************************************** PLACEHOLDER / Match Day ************************************************/
        [Test]
        //Access to Basketball Virtual Ticket by on Tv
        public void Test_35157()
        {
            utils.Change_Sport();
            //Step 2: Scroll and Click on "Play with us" placeholder
            madrid.Tap(PlaceholderVars.Match_day_ph);
            //Step 3: Click on "On TV" icon
            madrid.Tap(MatchDayVars.matchDay_location_tv_but);
            madrid.WaitForElement(MatchAreaVars.match_area_identifier);
            Assert.True(utils.existsElement(MatchAreaVars.match_area_identifier), "Match area title isn't displayed");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_feeds_feeds), "Feed tab isn't displayed");
			madrid.Tap(MatchAreaVars.match_area_goBack);
        }


		[Test]
		//Access to Football Virtual Ticket by on Tv
		public void Test_34285()
		{
			if (utils._device == "Tablet")
			{

				//Step 2: Scroll and Click on "Play with us" placeholder
				madrid.Tap(PlaceholderVars.Match_day_ph);
				madrid.WaitForElement(MatchDayVars.matchDay_location_title);
				Assert.True(utils.existsElement(MatchDayVars.matchDay_location_title), "Title isn't displayed");
				Assert.True(utils.existsElement(MatchDayVars.matchDay_location_tv_but), "Title isn't displayed");
				Assert.True(utils.existsElement(MatchDayVars.matchDay_location_app_but), "Title isn't displayed");

				//Step 3: Click on "On TV" icon
				madrid.Tap(MatchDayVars.matchDay_location_tv_but);
				madrid.WaitForElement(MatchAreaVars.match_area_identifier);
				Assert.True(utils.existsElement(MatchAreaVars.match_area_identifier), "Match area title isn't displayed");
				Assert.True(utils.existsElement(MatchDayVars.matchDay_feeds_feeds_Tablet), "Feed tab isn't displayed");
				madrid.Tap(MatchAreaVars.match_area_goBack);
			}
			else
			{
				//Step 2: Scroll and Click on "Play with us" placeholder
				Go_To_home(HomeVars.home_content, PlaceholderVars.MissedMatch_ph_title);
				madrid.Tap(PlaceholderVars.Match_day_ph);
				madrid.WaitForElement(MatchDayVars.matchDay_location_title);
				Assert.True(utils.existsElement(MatchDayVars.matchDay_location_title), "Title isn't displayed");
				Assert.True(utils.existsElement(MatchDayVars.matchDay_location_tv_but), "Title isn't displayed");
				Assert.True(utils.existsElement(MatchDayVars.matchDay_location_app_but), "Title isn't displayed");

				//Step 3: Click on "On TV" icon
				madrid.Tap(MatchDayVars.matchDay_location_tv_but);
				madrid.WaitForElement(MatchAreaVars.match_area_identifier);
				Assert.True(utils.existsElement(MatchAreaVars.match_area_identifier), "Match area title isn't displayed");
				Assert.True(utils.existsElement(MatchDayVars.matchDay_feeds_feeds), "Feed tab isn't displayed");

			}
		}


        /******************************************** PLACEHOLDER / Missed Match  ************************************************/
        
        [Test]
        //Line Up
        public void Test_34360()
        {

            // Step 2: Go to missed match Match Area.
			Go_To_home(HomeVars.home_content, PlaceholderVars.MissedMatch_ph_subtitle);
            madrid.Tap(PlaceholderVars.MissedMatch_ph_subtitle);
            // Step3: Check information.
            Assert.True(utils.existsElement(MatchDayVars.matchDay_matchArea_video), "Video tab title isn't displayed");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_matchArea_feeds), "Feed tab isn't displayed");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_matchArea_stats), "Stats tab isn't displayed");
			madrid.SwipeRightToLeft(MatchDayVars.matchDay_matchArea_stats);
			//madrid.Tap(MatchDayVars.matchDay_matchArea_stats);
			Assert.True(utils.existsElement(MatchDayVars.matchDay_matchArea_play), "Play tab isn't displayed");

            Assert.True(utils.existsElement(MatchDayVars.matchDay_matchArea_away_name), "Away name isn't displayed");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_matchArea_home_img), "Home img isn't displayed");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_matchArea_home_name), "Home name isn't displayed");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_matchArea_away_img), "Away img isn't displayed");

            Assert.True(utils.existsElement(MatchDayVars.matchDay_matchArea_away_score), "Away score isn't displayed");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_matchArea_home_score), "Home score isn't displayed");
            AppResult[] result = madrid.Query(MatchDayVars.matchDay_matchArea_timeline_finish);
            Assert.True(result[0].Text.Contains("Finalizado"));          

        }

        [Test]
        //Tok. Tv panel is accesible
        public void Test_34373()
        {

            // Step 2: Go to missed match Match Area.
			Go_To_home(HomeVars.home_content, PlaceholderVars.MissedMatch_ph_subtitle);
            madrid.Tap(PlaceholderVars.MissedMatch_ph_subtitle);
            // Step3: Click on Tok TV icon
            madrid.Tap(MatchDayVars.matchDay_tok_but);
			madrid.WaitForElement(HomeVars.home_tok_RMStore);
            //Assert.True(utils.existsElement(MatchDayVars.matchDay_tokProfile), "Video tab title isn't displayed");
			Assert.True(utils.existsElement(HomeVars.home_tok_RMStore), "Tok isn't displayed");
			madrid.Tap(MatchDayVars.matchDay_tok_but);
			madrid.Tap(MatchAreaVars.match_area_goBack);
        }

        [Test]
        // Feeds tab in Virtual Ticket
        public void Test_34287()
        {

            // Step 2: Go to missed match Match Area.
			Go_To_home(HomeVars.home_content, PlaceholderVars.MissedMatch_ph_subtitle);
            madrid.Tap(PlaceholderVars.MissedMatch_ph_title);
            // Step3: Click on "Feeds" tab
			madrid.WaitForElement(MatchDayVars.matchDay_matchArea_feeds);
            madrid.Tap(MatchDayVars.matchDay_matchArea_feeds);
			madrid.WaitForElement(MatchDayVars.matchDay_matchArea_feeds);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_feeds_lineup), "Lineup subtab isn't displayed");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_feeds_feeds), "Feeds subtab isn't displayed");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_feeds_summary), "Summary subtab isn't displayed");

			madrid.Tap(MatchDayVars.matchDay_feeds_lineup);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_feeds_playerAway_name), "Player away name isn't displayed");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_feeds_playerAway_number), "Player away number isn't displayed");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_feeds_playerHome_name), "Player home name isn't displayed");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_feeds_playerHome_number), "Player home number isn't displayed");

            madrid.Tap(MatchDayVars.matchDay_feeds_feeds);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_feeds_timeline_description), "TimeLine description isn't displayed");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_feeds_timeline_minute), "TimeLine minute isn't displayed");

            madrid.Tap(MatchDayVars.matchDay_feeds_summary);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_feeds_summary_goals), "Goals isn't displayed");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_feeds_summary_cards), "Cards isn't displayed");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_feeds_summary_substitutions), "Substitutions isn't displayed");
            madrid.Tap(MatchAreaVars.match_area_goBack);
        }

        [Test]
        // Feeds tab Basketball
        public void Test_35064()
        {

            // Step 2: Go to missed match Match Area.
            utils.Change_Sport();
            utils.Sleep(4);
            Go_To_home(HomeVars.home_content, PlaceholderVars.MissedMatch_ph_subtitle);
            madrid.Tap(PlaceholderVars.MissedMatch_ph_subtitle);
            // Step3: Click on "Feeds" tab
            madrid.Tap(MatchDayVars.matchDay_matchArea_feeds);
			madrid.WaitForElement(MatchDayVars.matchDay_feeds_lineup);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_feeds_lineup), "Lineup subtab isn't displayed");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_feeds_feeds), "Feeds subtab isn't displayed");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_feeds_summary), "Summary subtab isn't displayed");

			madrid.Tap(MatchDayVars.matchDay_feeds_lineup);
			madrid.WaitForElement(MatchDayVars.matchDay_feeds_playerAway_name);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_feeds_playerAway_name), "Player away name isn't displayed");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_feeds_playerAway_number), "Player away number isn't displayed");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_feeds_playerHome_name), "Player home name isn't displayed");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_feeds_playerHome_number), "Player home number isn't displayed");

            madrid.Tap(MatchDayVars.matchDay_feeds_feeds);
			madrid.WaitForElement(MatchDayVars.matchDay_feeds_timeline_description);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_feeds_timeline_description), "TimeLine description isn't displayed");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_feeds_timeline_minute), "TimeLine minute isn't displayed");

            madrid.Tap(MatchDayVars.matchDay_feeds_summary);
			madrid.WaitForElement(MatchDayVars.matchDay_feeds_summary_quarters);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_feeds_summary_quarters), "Quarters title isn't displayed");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_feeds_summary_quarter1), "Quarter 1 isn't displayed");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_feeds_summary_quarter2), "Quarter 2 isn't displayed");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_feeds_summary_quarter3), "Quarter 3 isn't displayed");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_feeds_summary_quarter4), "Quarter 4 isn't displayed");
			madrid.Tap(MatchAreaVars.match_area_goBack);
            utils.Sleep(4);
            madrid.Tap(HomeVars.home_Change_Sport_but);
            

        }


        [Test]
        //General Videos section Basketball
        public void Test_35062()
        {

            // Step 2: Go to missed match Match Area.
            utils.Change_Sport();
			Go_To_home(HomeVars.home_content, PlaceholderVars.MissedMatch_ph_subtitle);
            madrid.Tap(PlaceholderVars.MissedMatch_ph_subtitle);
            // Step3: Check screen.
            madrid.WaitForElement(MatchDayVars.matchDay_video_RealMadridTV);
			madrid.WaitForElement(MatchDayVars.matchDay_video_RealMadridTV);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_video_RealMadridTV), "RM Tv isn't displayed");
            //Assert.True(utils.existsElement(MatchDayVars.matchDay_video_player_class), "Video player class isn't displayed");
			madrid.Tap(MatchAreaVars.match_area_goBack);
            utils.Sleep(4);
            madrid.Tap(HomeVars.home_Change_Sport_but);

        }

        [Test]
        //Match stats
        public void Test_34289()
        {
            //Step 2: Go to missed match Match Area.
			Go_To_home(HomeVars.home_content, PlaceholderVars.MissedMatch_ph_subtitle);
            madrid.Tap(PlaceholderVars.MissedMatch_ph_subtitle);

            //Step 3: Tap on "Stats" tab.
			madrid.WaitForElement(MatchDayVars.matchDay_matchArea_stats);
            madrid.Tap(MatchDayVars.matchDay_matchArea_stats);

			//Team information
			madrid.WaitForElement(MatchDayVars.matchDay_stats_home_img);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_stats_home_img), "Home team logo doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_stats_away_img), "Away team logo doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_stats_home_name), "Home team name doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_stats_away_name), "Away team name doesn't exist");
			madrid.WaitForElement(MatchDayVars.matchDay_stats_home_but);
			madrid.Tap(MatchDayVars.matchDay_stats_home_but);
			madrid.WaitForElement(MatchDayVars.matchDay_stats_players_list);
            AppResult[] players_home = madrid.Query(MatchDayVars.matchDay_stats_players_list);
            Assert.True(players_home.Length > 2, "Home team players doesn't exist");
			madrid.WaitForElement(MatchDayVars.matchDay_stats_home_but);
            madrid.Tap(MatchDayVars.matchDay_stats_home_but);

			madrid.WaitForElement(MatchDayVars.matchDay_stats_away_but);
            madrid.Tap(MatchDayVars.matchDay_stats_away_but);
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

            //Step 4: Click a right player and click a left player.
            madrid.Tap(MatchDayVars.matchDay_stats_home_but);
            utils.Sleep(3);
            madrid.Tap(MatchDayVars.matchDay_stats_home_player2);

            AppResult[] result_player_graphic = madrid.Query(MatchDayVars.matchDay_stats_home_graphics);
            String result_player_text = result_player_graphic[0].Text;
            Assert.AreNotEqual(result_home_text, result_player_text);
        }

        [Test]
        //Basketball Match stats
        public void Test_35063()
        {
            //Step 2: Go to missed match Match Area.
            utils.Change_Sport();
            utils.Sleep(8);
			Go_To_home(HomeVars.home_content, PlaceholderVars.MissedMatch_ph_subtitle);
            madrid.Tap(PlaceholderVars.MissedMatch_ph_title);

            //Step 3: Click on "Stats" tab.
            madrid.Tap(MatchDayVars.matchDay_matchArea_stats);

			//Team information
			madrid.WaitForElement(MatchDayVars.matchDay_stats_home_img);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_stats_home_img), "Home team logo doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_stats_away_img), "Away team logo doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_stats_home_name), "Home team name doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_stats_away_name), "Away team name doesn't exist");
            madrid.WaitForElement(MatchDayVars.matchDay_stats_home_but);
			madrid.Tap(MatchDayVars.matchDay_stats_home_but);
            AppResult[] players_home = madrid.Query(MatchDayVars.matchDay_stats_players_list);
            Assert.True(players_home.Length > 2, "Home team players doesn't exist");
            madrid.Tap(MatchDayVars.matchDay_stats_home_but);
            madrid.Tap(MatchDayVars.matchDay_stats_away_but);
            AppResult[] players_away = madrid.Query(MatchDayVars.matchDay_stats_players_list);
            Assert.True(players_home.Length > 2, "Away team players doesn't exist");
            madrid.Tap(MatchDayVars.matchDay_stats_home_but);

            AppResult[] result_home_graphic = madrid.Query(MatchDayVars.matchDay_stats_home_graphics);
            String result_home_text = result_home_graphic[0].Text;

            //Summary stats
            this.Assert_stats(MatchDayVars.matchDay_stats_list, MatchDayVars.matchDay_stats_totalAssists);
            this.Assert_stats(MatchDayVars.matchDay_stats_points, MatchDayVars.matchDay_stats_totalAssists);
            this.Assert_stats(MatchDayVars.matchDay_stats_free_shots, MatchDayVars.matchDay_stats_totalAssists);
            this.Assert_stats(MatchDayVars.matchDay_stats_free_scored, MatchDayVars.matchDay_stats_totalAssists);
            this.Assert_stats(MatchDayVars.matchDay_stats_two_points, MatchDayVars.matchDay_stats_totalAssists);
            this.Assert_stats(MatchDayVars.matchDay_stats_two_scored, MatchDayVars.matchDay_stats_totalAssists);
            this.Assert_stats(MatchDayVars.matchDay_stats_three_points, MatchDayVars.matchDay_stats_totalAssists);
            this.Assert_stats(MatchDayVars.matchDay_stats_three_scored, MatchDayVars.matchDay_stats_totalAssists);
            this.Assert_stats(MatchDayVars.matchDay_stats_offensive_rebound, MatchDayVars.matchDay_stats_totalAssists);
            this.Assert_stats(MatchDayVars.matchDay_stats_defensive_rebound, MatchDayVars.matchDay_stats_totalAssists);
            this.Assert_stats(MatchDayVars.matchDay_stats_total_rebound, MatchDayVars.matchDay_stats_totalAssists);
            this.Assert_stats(MatchDayVars.matchDay_stats_assists, MatchDayVars.matchDay_stats_totalAssists);
            this.Assert_stats(MatchDayVars.matchDay_stats_turnovers, MatchDayVars.matchDay_stats_totalAssists);
            this.Assert_stats(MatchDayVars.matchDay_stats_steals, MatchDayVars.matchDay_stats_totalAssists);
            this.Assert_stats(MatchDayVars.matchDay_stats_bloks, MatchDayVars.matchDay_stats_totalAssists);
            this.Assert_stats(MatchDayVars.matchDay_stats_received_fouls, MatchDayVars.matchDay_stats_totalAssists);
            this.Assert_stats(MatchDayVars.matchDay_stats_fouls, MatchDayVars.matchDay_stats_totalAssists);
           
            //Step 4: Click a right player and click a left player.
            madrid.Tap(MatchDayVars.matchDay_stats_home_but);
            utils.Sleep(3);
            madrid.Tap(MatchDayVars.matchDay_stats_home_player2);

            AppResult[] result_player_graphic = madrid.Query(MatchDayVars.matchDay_stats_home_graphics);
            String result_player_text = result_player_graphic[0].Text;
            Assert.AreNotEqual(result_home_text, result_player_text);
            madrid.Tap(MatchAreaVars.match_area_goBack);
            utils.Sleep(2);
            madrid.Tap(HomeVars.home_Change_Sport_but);
        }
        
        /******************************************** PLACEHOLDER / News Multiple  ************************************************/
        
        [Test]
        //News by Shortcut through news placeholder
        public void Test_34425()
        {
            //Step 2: Scroll to News placeholder
			Go_To_home(HomeVars.home_content, PlaceholderVars.news_ph_title);
            //Step 3: Click a News
            Go_To_home(HomeVars.home_content, PlaceholderVars.news_image_ph);
            madrid.Tap(PlaceholderVars.news_image_ph);
            madrid.WaitForElement(NewsVars.news_title);
			madrid.WaitForElement(NewsVars.news_main_share_but);
			madrid.WaitForElement(NewsVars.news_main_like_but);
            Assert.True(utils.existsElement(NewsVars.news_title), "News title isn't displayed");
            Assert.True(utils.existsElement(NewsVars.news_main_share_but), "News share button isn't displayed");
            Assert.True(utils.existsElement(NewsVars.news_main_like_but), "News like button isn't displayed");

            
        }

		[Test]
		//Access to Basketball Virtual Ticket by on Tv
		public void Test_36328()
		{
			//Step 2: Scroll to News placeholder
			Go_To_home(HomeVars.home_content, PlaceholderVars.news_image_ph);
			//Step 3: Click on Share button
			madrid.Tap(PlaceholderVars.news_image_ph);
			madrid.WaitForElement(NewsVars.news_title);
			Assert.True(utils.existsElement(NewsVars.news_title), "News title isn't displayed");
			Assert.True(utils.existsElement(NewsVars.news_main_share_but), "News share button isn't displayed");
			Assert.True(utils.existsElement(NewsVars.news_main_like_but), "News like button isn't displayed");
			// Go back
				
		}
		// Bloqueado por tiempo de ejecución
        /*[Test]
        //See image carousel at news
        public void Test_34420()
        {
            //Step 2: Go to news through placeholder.
            //utils.Go_To(HomeVars.home_content, PlaceholderVars.news_ph_title);
            Go_To_home(HomeVars.home_content, PlaceholderVars.news_ph_title);

            //Step 3: Click on View All
            madrid.Tap(PlaceholderVars.news_ph_viewAll_but);
            //Step 4: Click a Multiple news.
			Go_To_home(HomeVars.home_content, NewsVars.news_newWithCarousel);
            madrid.Tap(NewsVars.news_newWithCarousel);
            utils.Sleep(6);

            madrid.WaitForElement(NewsVars.news_title);
            Assert.True(utils.existsElement(NewsVars.news_new_img), "Image news doesn't exist");
            Assert.True(utils.existsElement(NewsVars.news_title), "Title doesn't exist");
            Assert.True(utils.existsElement(NewsVars.news_main_like_but), "Favourite button doesn't exist");
            Assert.True(utils.existsElement(NewsVars.home_new_share), "Share button doesn't exist");
            Assert.True(utils.existsElement(NewsVars.home_new_twitter_but), "Twitter button doesn't exist");
            Assert.True(utils.existsElement(NewsVars.home_new_facebook_but), "Facebook button doesn't exist");
            Assert.True(utils.existsElement(NewsVars.news_description), "News description doesn't exist");
            Assert.True(utils.existsElement(NewsVars.news_carousel), "Carousel doesn't exist");

            //Step 4: Scroll carousel and click on one image.
            utils.Sleep(4);
            Assert.True(utils.existsElement(NewsVars.news_main_img), "Images carousel doesn't exist");
            madrid.SwipeRightToLeft(NewsVars.news_main_img, 0.90, 5000, true);
            madrid.SwipeLeftToRight(NewsVars.news_main_img, 0.90, 5000, true);
            //madrid.SwipeRightToLeft(NewsVars.news_carousel, 0.5, 500, true);
            //madrid.SwipeRightToLeft(PlaceholderVars.Videos_ph_title, 0.90, 5000, true);
            madrid.Tap(NewsVars.news_main_img);
            Assert.True(utils.existsElement(NewsVars.news_big_carousel_pager), "Pager in big Carousel doesn't exist");
            Assert.True(utils.existsElement(NewsVars.news_big_carousel_close_but), "Close button in big Carousel doesn't exist");
        }*/
        
        /******************************************** PLACEHOLDER / Next Games  ************************************************/
        
        [Test]
        //Swipe on Next games placeholder
        public void Test_34438()
        {
			//Step 2: Swipe on Next games placeholder.
            madrid.SwipeRightToLeft(PlaceholderVars.NextGamer_Ph_RealMadrid);
            //utils.Swipe_To_Right(PlaceholderVars.Next_Games_pager_indicator, PlaceholderVars.Next_Games_ph_AwayTeam);
            Assert.True(utils.existsElement(PlaceholderVars.Next_Games_ph_AwayTeam), "Away team icon isn't displayed");
            Assert.True(utils.existsElement(PlaceholderVars.Next_Games_ph_HomeTeam), "Home team icon isn't displayed");
            Assert.True(utils.existsElement(PlaceholderVars.Next_Games_ph_GameDays), "Day time isn't displayed");
            Assert.True(utils.existsElement(PlaceholderVars.Next_Games_ph_GameHours), "Hours time isn't displayed");
            Assert.True(utils.existsElement(PlaceholderVars.Next_Games_ph_GameMins), "Mins time isn't displayed");
            Assert.True(utils.existsElement(PlaceholderVars.Next_Games_ph_GameTime), "Game time isn't displayed");
            Assert.True(utils.existsElement(PlaceholderVars.Next_Games_ph_competition), "Competition  isn't displayed");

            if (utils.existsElement(PlaceholderVars.Next_Games_ph_HomeName))
            {
                Assert.True(utils.existsElement(PlaceholderVars.Next_Games_ph_Tickets_but), "Buy ticket button isn't displayed");
            }
            else
            {
                Assert.False(utils.existsElement(PlaceholderVars.Next_Games_ph_Tickets_but), "Buy ticket button displayed");
            }
        }

        [Test]
        // Buy ticket for next match on Next Games Placeholder
        public void Test_34936()
        {
            //Step 2: Swipe to next match (Real Madrid local team and play in Bernabeu Stadium).
            if (utils.existsElement(PlaceholderVars.Next_Games_ph_Tickets_but))
            {
                //Step 3: Click buy ticket.
                madrid.Tap(PlaceholderVars.Next_Games_ph_Tickets_but);
                utils.existsElement(PlaceholderVars.Next_Games_ph_webView);
            }
            else
            {
                madrid.SwipeRightToLeft(PlaceholderVars.NextGamer_Ph_RealMadrid);
            }
        }
        
        /******************************************** PLACEHOLDER / Social ************************************************/
        
        [Test]
        //Social by View All through Social placeholder
        public void Test_34275()
        {
            //Step 2: Scroll down to "Social" placeholder
			Go_To_home(HomeVars.home_content, PlaceholderVars.Social_ph_favorite_icon);
            Assert.True(utils.existsElement(PlaceholderVars.Social_ph_favorite_icon), "Favorite icon isn't displayed");
            Assert.True(utils.existsElement(PlaceholderVars.Social_ph_retweet_icon), "retweet icon isn't displayed");
            Assert.True(utils.existsElement(PlaceholderVars.Social_ph_share_icon), "Share icon isn't displayed");
            Assert.True(utils.existsElement(PlaceholderVars.Social_ph_tweet_content), "Twitter content isn't displayed");
            Assert.True(utils.existsElement(PlaceholderVars.Social_ph_tweet_account_img), "Twitter account image  isn't displayed");
            Assert.True(utils.existsElement(PlaceholderVars.Social_ph_pager), "Pager isn't displayed");
            madrid.ScrollUpTo(PlaceholderVars.Social_ph_viewAll_but);
            //Step 3: Click on "View all" button
            madrid.Tap(PlaceholderVars.Social_ph_viewAll_but);
            madrid.WaitForElement(PlaceholderVars.Social_twitter_title);
            Assert.True(utils.existsElement(PlaceholderVars.Social_twitter_title), "Social title isn't displayed");

        }

        [Test]
        //Share Envelope
        public void Test_34278()
        {
            //Step 2: Scroll down to social placeholder and click on "Share" icon
			Go_To_home(HomeVars.home_content, PlaceholderVars.Social_ph_favorite_icon);
            madrid.Tap(PlaceholderVars.Social_ph_share_icon);
            //Step 3: Click on the "Envelope" icon
            madrid.Tap(HomeVars.mail_but);
            //madrid.WaitForElement(HomeVars.Share_NativeApps_view);
            //Assert.True(utils.existsElement(HomeVars.Share_NativeApps_view), "Share native view isn't displayed");

        }

        [Test]
        //Go to Twitter timeline
        public void Test_34335()
        {
            //Step 2: Tap on VIEW ALL button at Social placeholder.
			Go_To_home(HomeVars.home_content, PlaceholderVars.Social_ph_mainContent);
            madrid.ScrollUpTo(PlaceholderVars.Social_ph_viewAll_but);
            madrid.Tap(PlaceholderVars.Social_ph_viewAll_but);
            madrid.WaitForElement(PlaceholderVars.Social_twitter_title);
            Assert.True(utils.existsElement(PlaceholderVars.Social_twitter_title), "Social title isn't displayed");

        }
        
        /******************************************** PLACEHOLDER / Subscription single ************************************************/
        
        [Test]
        //Buy subscription through placeholder
        public void Test_34237()
        {
            //Step 2: Scroll to New Videos placeholder.
            Go_To_home(HomeVars.home_content, PlaceholderVars.Subscription_ph_mainImage);            
            Assert.True(utils.existsElement(PlaceholderVars.Subscription_ph_sectionTitle), "Subscription section title isn't displayed");
            Assert.True(utils.existsElement(PlaceholderVars.Subscription_ph_mainImage), "Subscription image isn't displayed");
            Assert.True(utils.existsElement(PlaceholderVars.Subscription_ph_price), "Price isn't displayed");
            //Step 3: Click on "View all" button.
            madrid.Tap(PlaceholderVars.Subscription_ph_viewAll_but);
            madrid.WaitForElement(VirtualStoreVars.VirtualStore_HeaderTitle);
            Assert.True(utils.existsElement(VirtualStoreVars.VirtualStore_HeaderTitle), "Virtual Store title isn't displayed");
            madrid.WaitForElement(VirtualStoreVars.VirtualStore_HeaderTitle);
			madrid.WaitForElement(VirtualStoreVars.Videos_section_title);
			Assert.True(utils.existsElement(VirtualStoreVars.Videos_section_title), "Videos section isn't displayed");
            
            
        }

        /******************************************** PLACEHOLDER / Video Multiple ************************************************/
        
          [Test]
        //Videos by View All through videos placeholder
        public void Test_34427()
        {
			if (utils._device == "Tablet")
			{
				//Step 2: Go to "Videos" placeholder.
				//utils.Sleep(5);
				madrid.ScrollDown();
                Go_To_home(HomeVars.home_content, PlaceholderVars.Videos_ph_sectionTitle);
				//Step 3: Tap on "View All"
				madrid.Tap(PlaceholderVars.Videos_ph_viewAll_but);
				madrid.WaitForElement(VideoVars.Video_HeaderTitle);
				Assert.True(utils.existsElement(VideoVars.Video_HeaderTitle), "Videos title isn't displayed");
				//Main video
				madrid.WaitForElement(VideoVars.Main_video_title);
				madrid.WaitForElement(HomeVars.share_but);
				Assert.True(utils.existsElement(VideoVars.Main_video_title), "Main Video title isn't displayed");
				Assert.True(utils.existsElement(HomeVars.share_but), "Main Video share button isn't displayed");
				Assert.True(utils.existsElement(HomeVars.like_but), "Main Video like button isn't displayed");
				Assert.True(utils.existsElement(HomeVars.facebook_but), "Main Video facebook isn't displayed");
				Assert.True(utils.existsElement(HomeVars.twitter_but), "Main Video twitter button isn't displayed");
				Go_To_home(HomeVars.home_content, VideoVars.Video_title);
				//Video list
				madrid.WaitForElement(VideoVars.Video_share_but);
				Assert.True(utils.existsElement(VideoVars.Video_share_but), "Video share button isn't displayed");
				Assert.True(utils.existsElement(VideoVars.Video_favorite_but), "Video favorite button isn't displayed");
				Assert.True(utils.existsElement(VideoVars.Video_title), "Video title isn't displayed");
				Assert.True(utils.existsElement(VideoVars.Video_play), "Play video isn't displayed");


			}
			else
			{ 
				//Step 2: Go to "Videos" placeholder.
				//utils.Sleep(5);
				madrid.ScrollDown();
				Go_To_home(HomeVars.home_content, PlaceholderVars.Videos_ph_sectionTitle);
				//Step 3: Tap on "View All"
				madrid.Tap(PlaceholderVars.Videos_ph_viewAll_but);
				madrid.WaitForElement(VideoVars.Video_HeaderTitle);
				Assert.True(utils.existsElement(VideoVars.Video_HeaderTitle), "Videos title isn't displayed");
				//Main video
				madrid.WaitForElement(VideoVars.Main_video_title);
				madrid.WaitForElement(HomeVars.share_but);
				Assert.True(utils.existsElement(VideoVars.Main_video_title), "Main Video title isn't displayed");
				Assert.True(utils.existsElement(HomeVars.share_but), "Main Video share button isn't displayed");
				Assert.True(utils.existsElement(HomeVars.like_but), "Main Video like button isn't displayed");
				Assert.True(utils.existsElement(HomeVars.facebook_but), "Main Video facebook isn't displayed");
				Assert.True(utils.existsElement(HomeVars.twitter_but), "Main Video twitter button isn't displayed");
				Go_To_home(HomeVars.home_content, VideoVars.Video_title);
				//Video list
				madrid.WaitForElement(VideoVars.Video_share_but);
				Assert.True(utils.existsElement(VideoVars.Video_share_but), "Video share button isn't displayed");
				Assert.True(utils.existsElement(VideoVars.Video_favorite_but), "Video favorite button isn't displayed");
				Assert.True(utils.existsElement(VideoVars.Video_title), "Video title isn't displayed");
				Assert.True(utils.existsElement(VideoVars.Video_play), "Play video isn't displayed");
			}
		}

		[Test]
		//Play a video through Videos placeholder
		public void Test_34442()
		{
			if (utils._device == "Tablet")
			{
				//Step 2: Go to "Videos" placeholder.
				//utils.Sleep(5);
				madrid.ScrollDown();
				Go_To_home(HomeVars.home_content, PlaceholderVars.Videos_ph_sectionTitle);
				//Step 3: Tap on "View All"
				madrid.Tap(PlaceholderVars.Videos_ph_viewAll_but);
				madrid.WaitForElement(VideoVars.Video_HeaderTitle);
				Assert.True(utils.existsElement(VideoVars.Video_HeaderTitle), "Videos title isn't displayed");
				//Main video
				madrid.WaitForElement(VideoVars.Main_video_title);
				madrid.WaitForElement(HomeVars.share_but);
				Assert.True(utils.existsElement(VideoVars.Main_video_title), "Main Video title isn't displayed");
				Assert.True(utils.existsElement(HomeVars.share_but), "Main Video share button isn't displayed");
				Assert.True(utils.existsElement(HomeVars.like_but), "Main Video like button isn't displayed");
				Assert.True(utils.existsElement(HomeVars.facebook_but), "Main Video facebook isn't displayed");
				Assert.True(utils.existsElement(HomeVars.twitter_but), "Main Video twitter button isn't displayed");
				Go_To_home(HomeVars.home_content, VideoVars.Video_title);
				//Video list
				madrid.WaitForElement(VideoVars.Video_share_but);
				Assert.True(utils.existsElement(VideoVars.Video_share_but), "Video share button isn't displayed");
				Assert.True(utils.existsElement(VideoVars.Video_favorite_but), "Video favorite button isn't displayed");
				Assert.True(utils.existsElement(VideoVars.Video_title), "Video title isn't displayed");
				Assert.True(utils.existsElement(VideoVars.Video_play), "Play video isn't displayed");
				//Step 4: Scroll down.
				//Step 5: Scroll to the top.
				//Step 6: Click any video.
				madrid.ScrollUp();
				madrid.Tap(VideoVars.Video_play_Tablet);
				madrid.WaitForElement(HomeVars.Video_player);
				Assert.True(utils.existsElement(HomeVars.Video_player), "Video player isn't displayed");
				utils.Sleep(4);
				madrid.Tap(HomeVars.Video_player);
				madrid.Tap(VideoVars.Video_GoBack);
				madrid.WaitForElement(VideoVars.Video_HeaderTitle);
				Assert.True(utils.existsElement(VideoVars.Video_HeaderTitle), "Videos title isn't displayed");

			}
			else
			{ 
				//Step 2: Go to "Videos" placeholder.
				//utils.Sleep(5);
				madrid.ScrollDown();
                Go_To_home(HomeVars.home_content, PlaceholderVars.Videos_ph_sectionTitle);
				//Step 3: Tap on "View All"
				madrid.Tap(PlaceholderVars.Videos_ph_viewAll_but);
				madrid.WaitForElement(VideoVars.Video_HeaderTitle);
				Assert.True(utils.existsElement(VideoVars.Video_HeaderTitle), "Videos title isn't displayed");
				//Main video
				madrid.WaitForElement(VideoVars.Main_video_title);
				madrid.WaitForElement(HomeVars.share_but);
				Assert.True(utils.existsElement(VideoVars.Main_video_title), "Main Video title isn't displayed");
				Assert.True(utils.existsElement(HomeVars.share_but), "Main Video share button isn't displayed");
				Assert.True(utils.existsElement(HomeVars.like_but), "Main Video like button isn't displayed");
				Assert.True(utils.existsElement(HomeVars.facebook_but), "Main Video facebook isn't displayed");
				Assert.True(utils.existsElement(HomeVars.twitter_but), "Main Video twitter button isn't displayed");
				Go_To_home(HomeVars.home_content, VideoVars.Video_title);
				//Video list
				madrid.WaitForElement(VideoVars.Video_share_but);
				Assert.True(utils.existsElement(VideoVars.Video_share_but), "Video share button isn't displayed");
				Assert.True(utils.existsElement(VideoVars.Video_favorite_but), "Video favorite button isn't displayed");
				Assert.True(utils.existsElement(VideoVars.Video_title), "Video title isn't displayed");
				Assert.True(utils.existsElement(VideoVars.Video_play), "Play video isn't displayed");
				//Step 4: Scroll down.
				//Step 5: Scroll to the top.
				//Step 6: Click any video.
				madrid.Tap(VideoVars.Video_play);
				madrid.WaitForElement(HomeVars.Video_player);
				Assert.True(utils.existsElement(HomeVars.Video_player), "Video player isn't displayed");
				madrid.Tap(HomeVars.Video_player);
				madrid.Tap(VideoVars.Video_GoBack);
				madrid.WaitForElement(VideoVars.Video_HeaderTitle);
				Assert.True(utils.existsElement(VideoVars.Video_HeaderTitle), "Videos title isn't displayed");

			}
		}



	        [Test]
	        //Multiple Videos carrousel
	        public void Test_34443()
	        {
	            //Step 2: Scroll to Videos placeholder
	            Go_To_home(HomeVars.home_content, PlaceholderVars.Videos_ph_title);
	            //Step 3: Swipe on Videos placeholder
	            //utils.Swipe_To_Right(HomeVars.home_content, PlaceholderVars.Videos_ph_title);
	            //utils.Swipe_To_Right(HomeVars.home_content, PlaceholderVars.Videos_ph_title);
	            madrid.SwipeRightToLeft(PlaceholderVars.Videos_ph_title, 0.90, 6000, true);
	            madrid.SwipeRightToLeft(PlaceholderVars.Videos_ph_title, 0.90, 6000, true);
	            madrid.SwipeRightToLeft(PlaceholderVars.Videos_ph_title, 0.90, 6000, true);
	            
	        }

        [Test]
        //Share Video Multiple on social networks
        public void Test_36438()
        {
            //Step 2: Scroll down to video multiple placeholder and click on "Share" icon.
            Go_To_home(HomeVars.home_content, PlaceholderVars.Videos_ph_share_left);
            madrid.Tap(PlaceholderVars.Videos_ph_share_left);
			madrid.WaitForElement(HomeVars.Facebook_but_popup);
            Assert.True(utils.existsElement(HomeVars.Facebook_but_popup), "Facebook button isn't displayed");
            Assert.True(utils.existsElement(HomeVars.twitter_but_popup), "Facebook button isn't displayed");
            Assert.True(utils.existsElement(HomeVars.mail_but), "Mail button isn't displayed");
            Assert.True(utils.existsElement(HomeVars.native_but), "Native button isn't displayed");
            Assert.True(utils.existsElement(HomeVars.ok_but), "Ok button isn't displayed");
            
        }
        
        /******************************************** PLACEHOLDER / Video Single ************************************************/
        
        [Test]
        //Play video from Video_Single placeholder
        public void Test_35002()
        {
            //Step 2: Scroll to VIDEO_SINGLE placeholder.
			Go_To_home(HomeVars.home_content, PlaceholderVars.VideoSingle_ph_play);
            Assert.True(utils.existsElement(PlaceholderVars.VideoSingle_ph_Title), "Video single title isn't displayed");
            Assert.True(utils.existsElement(PlaceholderVars.VideoSingle_ph_image), "Video single image isn't displayed");
            Assert.True(utils.existsElement(HomeVars.facebook_but), "Facebook button isn't displayed");
            Assert.True(utils.existsElement(HomeVars.twitter_but), "Twitter button isn't displayed");
            Assert.True(utils.existsElement(HomeVars.share_but), "Share button isn't displayed");
            Assert.True(utils.existsElement(HomeVars.like_but), "Like button isn't displayed");
            //Step 2: Tap on it.
            madrid.Tap(PlaceholderVars.VideoSingle_ph_play);
            madrid.WaitForElement(HomeVars.Video_player);
            Assert.True(utils.existsElement(HomeVars.Video_player), "Video player isn't displayed");
			madrid.Tap(VideoVars.Video_GoBack);

        }

        [Test]
        //Multiple Videos carrousel
        public void Test_35003()
        {
            //Step 3: Video_Single placeholder has no subtitle
            Go_To_home(HomeVars.home_content, PlaceholderVars.VideoSingle_ph_play);
            Assert.True(utils.existsElement(PlaceholderVars.VideoSingle_ph_Title), "Video single title isn't displayed");
            Assert.True(utils.existsElement(PlaceholderVars.VideoSingle_ph_image), "Video single image isn't displayed");
            Assert.True(utils.existsElement(HomeVars.facebook_but), "Facebook button isn't displayed");
            Assert.True(utils.existsElement(HomeVars.twitter_but), "Twitter button isn't displayed");
            Assert.True(utils.existsElement(HomeVars.share_but), "Share button isn't displayed");
            Assert.True(utils.existsElement(HomeVars.like_but), "Like button isn't displayed");
        }
        
        /******************************************** PLACEHOLDER / Subscription Purchasable ************************************************/
        /*
        [Test]
        //Subscription purchasable
        public void Test_34765()
        {
            //Step 3: Scroll down to "SUBSCRIPTION_PURCHASABLE" placeholder.
            Go_To_home(HomeVars.home_content, PlaceholderVars.SubscriptionPurchasable_ph);
            //Step 4: Click on "SUBSCRIPTION_PURCHASABLE" placeholder.
            madrid.Tap(PlaceholderVars.SubscriptionPurchasable_ph);
            // Check if is webview
            madrid.WaitForElement(HomeVars.header_logo);
            Assert.True(utils.existsElement(HomeVars.header_logo), "Header isn't displayed");
            Assert.True(utils.existsElement(HomeVars.navigation_icon_back), "Navigation back button isn't displayed");
            madrid.Tap(HomeVars.navigation_icon_back);



        }*/

        
    }
}