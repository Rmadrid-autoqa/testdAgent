using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealMadrid_UITest.Tests
{
    class OutOfScope
    {
        /*

                [Test]
                //Finder design page
                public void Test_35458(){
                    //Step 2: Go to Finder through Main Menu
                    utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);

                    //Step 3: Check Finder Page
                    Assert.True(utils.existsElement(FinderVars.main_title), "Title page doesn't exist");
                    Assert.True(utils.existsElement(FinderVars.finder_et_search_input), "TextBox doesn't exist");

                    utils.Swipe_To_Right(FinderVars.filters_bars, FinderVars.finder_filt_content_type);
                    Assert.True(utils.existsElement(FinderVars.finder_filt_content_type), "Content Type doesn't exist");

                    utils.Swipe_To_Right(FinderVars.filters_bars, FinderVars.finder_filt_content_competition);
                    Assert.True(utils.existsElement(FinderVars.finder_filt_content_competition), "Competition doesn't exist");

                    utils.Swipe_To_Right(FinderVars.filters_bars, FinderVars.finder_filt_content_seasson);
                    Assert.True(utils.existsElement(FinderVars.finder_filt_content_seasson), "Seasson doesn't exist");

                    utils.Swipe_To_Right(FinderVars.filters_bars, FinderVars.finder_filt_content_players);
                    Assert.True(utils.existsElement(FinderVars.finder_filt_content_players), "Players doesn't exist");

                    utils.Swipe_To_Right(FinderVars.filters_bars, FinderVars.finder_filt_content_category);
                    Assert.True(utils.existsElement(FinderVars.finder_filt_content_category), "Category doesn't exist");

                    Assert.True(utils.existsElement(FinderVars.finder_hightlighted_videos));
                    Assert.True(utils.existsElement(FinderVars.finder_highlighted_matches));
                }


        
		[Test]
		public void Test_35463() {
			// Step 2: Go to Finder
			madrid.Repl();

			utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
			madrid.WaitForElement(FinderVars.main_title);

			// Step 3: Click on Content Type Match filter
			madrid.Tap(FinderVars.finder_filt_content_type);
			madrid.WaitForElement(FinderVars.finder_filter_title_matches);
			Assert.True(utils.existsElement(FinderVars.finder_filter_title_matches) && utils.existsElement(FinderVars.finder_filter_title_videos));

			// Step 4: Select the Match option (The last matches are displayed)
			madrid.Tap(FinderVars.finder_filter_title_matches);
			madrid.WaitForElement(FinderVars.finder_filter_matches_results);
			Assert.True(utils.existsElement(FinderVars.finder_filter_matches_results));

			// Step 5: Click on "Match area" button of a match (The match area page is displayed)
			madrid.Tap(FinderVars.finder_filter_match_area);
			madrid.WaitForElement(MatchAreaVars.match_area_identifier);
			Assert.True(utils.seeingMatchArea());

			// Step 6: Click on the "back" button
			madrid.Tap(MainMenuVars.menu_Main_but);
			madrid.WaitForElement(FinderVars.finder_filter_matches_results);
			Assert.True(utils.existsElement(FinderVars.finder_filter_matches_results));
		}


        
		[Test]
		public void Test_35466() {
			// Step 2: Go to Finder
			utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
			madrid.WaitForElement(FinderVars.main_title);

			// Step 3: Click on Content Type Match filter (Appear "Videos" and "Matches")
			madrid.Tap(FinderVars.finder_filt_content_type);
			madrid.WaitForElement(FinderVars.finder_filter_title_matches);
			Assert.True(utils.existsElement(FinderVars.finder_filter_title_matches) && utils.existsElement(FinderVars.finder_filter_title_videos));

			// Step 4: Select the Match option (The last matches are displayed)
			madrid.Tap(FinderVars.finder_filter_title_matches);
			madrid.WaitForElement(FinderVars.finder_filter_matches_results);
			Assert.True(utils.existsElement(FinderVars.finder_filter_matches_results));

			// Step 5: Search future match (Future match is displayed)
			// ¿Dónde se ubican los Future Matches?

			// Step 6:
			// Click on "Buy Ticket" button of a match
		}


        

        
        [Test]
        //Finder in main menu
        public void Test_36950() {

            //Step 2: Switch to @sport
            utils.Change_Sport();

            //Step 3: Open main menu
			madrid.TouchAndHold(MainMenuVars.menu_Main_but);
            madrid.ScrollDown(withinMarked: Strings.MAIN_MENU_VIEW);

            //Finder is not visible in basketball
            Assert.False(utils.existsElement(MainMenuVars.menu_Finder_but), "Finder exist");
            
            //Change to Football
            madrid.SwipeRightToLeft();
            utils.Change_Sport();
            
            //Finder is visible in football
            madrid.TouchAndHold(MainMenuVars.menu_Main_but);
            madrid.ScrollDownTo(Strings.MAIN_MENU_FINDER, withinMarked:Strings.MAIN_MENU_VIEW);
            Assert.True(utils.existsElement(MainMenuVars.menu_Finder_but));
        }

        
        
        [Test]
		public void Test_37259() {
            //Step 2: Switch to @sport
            utils.Change_Sport();
			madrid.WaitForElement(HomeVars.home_Change_Sport_but, "Cant find Home page before timeout", TimeSpan.FromSeconds(5));
			utils.Change_Sport();

            //Step 3:Open main menu and click in Finder
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.filters_bars, "Cant find FilterBar on Finder page before TimeOut");
			Assert.True(utils.existsElement(FinderVars.filters_arrow));
            madrid.WaitForElement(FinderVars.filters_bars, "Cant find FilterBar on Finder page before TimeOut");
			Assert.True(utils.existsElement(FinderVars.filters_arrow), "Arrow doesn't exist");
		}



                [Test]
        public void Test_35045() {

            //Step 2: Scroll and Click on "Play with us" placeholder.
            utils.Change_Sport();
            utils.Sleep(10);
            utils.Go_To(HomeVars.home_content, MatchDayVars.matchDay_home_playwithus_but);
            madrid.Tap(MatchDayVars.matchDay_home_playwithus_but);
            madrid.WaitForElement(MatchDayVars.matchDay_location_title);
            
            Assert.True(utils.existsElement(MatchDayVars.matchDay_location_title), "Location popup doesn't display");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_location_tv_but), "TV icon doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_location_app_but), "App icon doesn't exist");

            //Step 3: Click on "Only in the app" icon.
            madrid.Tap(MatchDayVars.matchDay_location_app_but);
            madrid.WaitForElement(NavigationBarVars.match_area_Title);

            Assert.True(utils.existsElement(MatchDayVars.matchDay_matchArea_video), "Video tab doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_matchArea_feeds), "Feeds tab doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_matchArea_stats), "Stats tab doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_matchArea_play), "Play tab doesn't exist");

            madrid.SetOrientationLandscape();
            madrid.WaitForElement(MatchDayVars.matchDay_horizontally_home_img);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_horizontally_home_img), "Home team icon doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_horizontally_home_name), "Home team name doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_horizontally_away_img), "Away team icon doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_horizontally_away_name), "Away team name doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_horizontally_home_score), "Home team score doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_horizontally_away_score), "Away team score doesn't exist");

            madrid.SetOrientationPortrait();
            madrid.WaitForElement(MatchDayVars.matchDay_matchArea_home_img);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_matchArea_home_img), "Home team icon doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_matchArea_home_name), "Home team name doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_matchArea_away_img), "Away team icon doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_matchArea_away_name), "Away team name doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_matchArea_home_score), "Home team score doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_matchArea_away_score), "Away team score doesn't exist");


        }




                [Test]
        public void Test_35051()
        {

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
            Assert.True(utils.existsElement(MatchDayVars.matchDay_matchArea_play), "Play tab doesn't exist");

            madrid.SetOrientationLandscape();
            madrid.WaitForElement(MatchDayVars.matchDay_horizontally_home_img);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_horizontally_home_img), "Home team icon doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_horizontally_home_name), "Home team name doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_horizontally_away_img), "Away team icon doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_horizontally_away_name), "Away team name doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_horizontally_home_score), "Home team score doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_horizontally_away_score), "Away team score doesn't exist");

            madrid.SetOrientationPortrait();
            madrid.WaitForElement(MatchDayVars.matchDay_matchArea_home_img);
            Assert.True(utils.existsElement(MatchDayVars.matchDay_matchArea_home_img), "Home team icon doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_matchArea_home_name), "Home team name doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_matchArea_away_img), "Away team icon doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_matchArea_away_name), "Away team name doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_matchArea_home_score), "Home team score doesn't exist");
            Assert.True(utils.existsElement(MatchDayVars.matchDay_matchArea_away_score), "Away team score doesn't exist");

        }








            */
    }
}
