using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest;
using Xamarin.UITest.Queries;



namespace RealMadrid_UITest {
    //[TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]


    public class FinderTests {
        IApp madrid;
        Utilities utils;
        Platform platform;



        public FinderTests(Platform platform) {
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
            //utils.Enter_Home();
            //utils.Sign_Off();
        }

		// Auxiliary methods
		private void Go_To_Slow(Func<AppQuery, AppQuery> view, Func<AppQuery, AppQuery> element)
		{
			while (madrid.Query(element).Length == 0)
			{
				madrid.ScrollDown(view, ScrollStrategy.Gesture, 0.10, 350, true);
			}
		}

        /******************************************** FINDER / Matches ************************************************/

        /*[Test]
        public void MiTest() {
            madrid.Repl();
        }*/



        [Test]
        //Search by Match
        public void Test_35548() {
            // Step 2: Go to Finder
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.main_title);

            // Step 3: Click on Type of Content and select "Matches" option (Matches page ir displayed)
            madrid.WaitForElement(FinderVars.filters_bars);
            Assert.True(utils.existsElement(FinderVars.finder_filt_content_type) && utils.existsElement(FinderVars.finder_filt_content_competition));

            madrid.Tap(FinderVars.finder_filt_content_type);
            madrid.Tap(FinderVars.finder_filter_title_matches);

            madrid.WaitForElement(FinderVars.finder_tv_results);
            Assert.True(utils.existsElement(FinderVars.finder_tv_results));
        }



        [Test]
        //Apply competition filter
        public void Test_35675() {
			// Step 2: Go to Finder
			utils.Sleep(5);
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.main_title);

            // Step 3: Click on Content Type Match filter (Appear two options: "Videos" and "Matches")
            madrid.Tap(FinderVars.finder_filt_content_type);
            madrid.WaitForElement(FinderVars.finder_filter_title_matches);
            Assert.True(utils.existsElement(FinderVars.finder_filter_title_matches) && utils.existsElement(FinderVars.finder_filter_title_videos));

            // Step 4: Select the Match option (The las matches are displayed)
            madrid.Tap(FinderVars.finder_filter_title_matches);
            madrid.WaitForElement(FinderVars.finder_filter_matches_results);
            Assert.True(utils.existsElement(FinderVars.finder_filter_matches_results));

            // Step 5: Incompleto
            madrid.Tap(FinderVars.finder_filt_content_competition);
            madrid.WaitForElement(FinderVars.filters_submenu);

            // Step 6: Click on a @competition
            madrid.Tap(FinderVars.finder_filter_title_sup_cop_esp);
            madrid.WaitForElement(FinderVars.finder_tv_results);
            Assert.True(utils.existsElement(FinderVars.finder_tv_results));

            // Step 7: Unselect the previous @competition
			madrid.Tap(FinderVars.finder_filt_content_competition);
			madrid.WaitForElement(FinderVars.filters_submenu);
            madrid.Tap(FinderVars.finder_filter_title_sup_cop_esp);

            // Step 8: Click on other @competition
            madrid.Tap(FinderVars.finder_filt_content_competition);
            madrid.Tap(FinderVars.finder_filter_title_sup_cop_eur);
            //madrid.Repl();
            madrid.WaitForElement(FinderVars.finder_tv_results);
            Assert.True(utils.existsElement(FinderVars.finder_tv_results));
        }



        [Test]
        //Apply season filter
        public void Test_35676() {
            // Step 2: Go to Finder
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.main_title);

            // Step 3: Click on Content Type Match filter
            madrid.Tap(FinderVars.finder_filt_content_type);
            madrid.WaitForElement(FinderVars.finder_filter_title_matches);

            // Step 4: Select the Match option
            madrid.Tap(FinderVars.finder_filter_title_matches);
            madrid.WaitForElement(FinderVars.finder_filter_matches_results);

            // Step 5: Click on Season filter
            madrid.SwipeRightToLeft(FinderVars.filters_bars, 0.10, 2000, true);
            madrid.Tap(FinderVars.finder_filt_content_seasson);
            madrid.WaitForElement(FinderVars.filters_submenu);

            // Step 6: Click on a @season
            madrid.Tap(FinderVars.finder_filter_single_container_0);
            madrid.WaitForElement(FinderVars.finder_tv_results);
            Assert.True(utils.existsElement(FinderVars.finder_tv_results));

            // Step 7: Unselect the previous @season
            madrid.Tap(FinderVars.finder_filt_content_seasson);
            madrid.Tap(FinderVars.finder_filter_single_container_0);
            madrid.WaitForElement(FinderVars.finder_last_matches_view);
            Assert.True(utils.existsElement(FinderVars.finder_last_matches_view));

            // Step 8: Click on other @season
            madrid.Tap(FinderVars.finder_filt_content_seasson);
            madrid.Tap(FinderVars.finder_filter_single_container_1);
            madrid.WaitForElement(FinderVars.finder_tv_results);
            Assert.True(utils.existsElement(FinderVars.finder_tv_results));

            // Step 9: Click on players and categories, select any player and category
            // Este test comprueba si el filtro JUGADORES del finder está activo. Es este punto no lo está,
            // pero en vez de cambiar el atributo "enabled" del test, se superpone una layout llamada
            // img_disabled_display en cada filtro inactivo, lo cual hace muy complicado comprobar qué filtro
            // se encuentra inactivo
        }



        [Test]
        //Apply the competition and season filter
        public void Test_35678() {
			// Step 2: Go to Finder
			utils.Sleep(5);
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.main_title);

            // Step 3: Click on Content Type Match filter
            madrid.Tap(FinderVars.finder_filt_content_type);
            madrid.WaitForElement(FinderVars.finder_filter_title_matches);

            // Step 4: Select the Match option
            madrid.Tap(FinderVars.finder_filter_title_matches);
            madrid.WaitForElement(FinderVars.finder_filter_matches_results);

            // Step 5: Click on Competition filter
            madrid.Tap(FinderVars.finder_filt_content_competition);
            madrid.WaitForElement(FinderVars.filters_submenu);

            // Step 6: Click on a @competition
            madrid.Tap(FinderVars.finder_filter_title_sup_cop_eur);
            madrid.WaitForElement(FinderVars.finder_tv_results);
            Assert.True(utils.existsElement(FinderVars.finder_tv_results));

            // Step 7: Click on Season filter
            madrid.SwipeRightToLeft(FinderVars.filters_bars, 0.10, 2000, true);
            madrid.Tap(FinderVars.finder_filt_content_seasson);
            madrid.WaitForElement(FinderVars.filters_submenu);

            // Step 8: Click on a @season
            madrid.Tap(FinderVars.finder_filter_single_container_1);
            madrid.WaitForElement(FinderVars.finder_tv_results);
            Assert.True(utils.existsElement(FinderVars.finder_tv_results));

            // Step 9: Unselect the previous @season
            madrid.Tap(FinderVars.finder_filt_content_seasson);
            madrid.Tap(FinderVars.finder_filter_single_container_1);
            madrid.WaitForElement(FinderVars.finder_last_matches_view);
            Assert.True(utils.existsElement(FinderVars.finder_last_matches_view));

            // Step 10: Unselect the previous @competition
            madrid.Tap(FinderVars.finder_filt_content_competition);
            madrid.WaitForElement(FinderVars.filters_submenu);
            madrid.Tap(FinderVars.finder_filter_title_sup_cop_eur);

            // Step 11: Click on other @competition
            madrid.Tap(FinderVars.finder_filt_content_competition);
            madrid.Tap(FinderVars.finder_filter_title_sup_cop_esp);
            madrid.WaitForElement(FinderVars.finder_tv_results);
            Assert.True(utils.existsElement(FinderVars.finder_tv_results));

            // Step 12: Click on other @season
            madrid.Tap(FinderVars.finder_filt_content_seasson);
            madrid.WaitForElement(FinderVars.filters_submenu);
            madrid.Tap(FinderVars.finder_filter_single_container_0);
            madrid.WaitForElement(FinderVars.finder_tv_results);
            Assert.True(utils.existsElement(FinderVars.finder_tv_results));
        }


        [Test]
        //Search a match by the name of the team
        public void Test_35687() {
            // Step 2: Go to Finder
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.main_title);

            // Step 3: Fill the text box "¿Qué quieres ver?" with the @team of the match you want to search
            madrid.WaitForElement(FinderVars.search_input_bar);
			utils.Sleep(3);
			madrid.EnterText(FinderVars.search_input_bar, "Real Betis");
			madrid.WaitForElement(FinderVars.main_title);
			madrid.DoubleTap(FinderVars.main_title);
			madrid.Tap(FinderVars.main_title);

            // Step 4: Check the list of the matches
            madrid.ScrollDown(FinderVars.filters_results, ScrollStrategy.Gesture, 0.20, 2000);
            Assert.True(utils.existsElement(FinderVars.finder_last_matches_view));
        }



        [Test]
        //Search and apply any filter
        public void Test_35726() {
			// Step 2: Go to Finder
			utils.Sleep(5);
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.main_title);

            // Step 3: Click on Content Type Match filter
            madrid.Tap(FinderVars.finder_filt_content_type);
            madrid.WaitForElement(FinderVars.finder_filter_title_matches);

            // Step 4: Select the Match option
            madrid.Tap(FinderVars.finder_filter_title_matches);
            madrid.WaitForElement(FinderVars.finder_filter_matches_results);
			utils.Sleep(3);
            // Step 5: Fill the text box "¿Qué quieres ver?" with the @team of the match you want to search
            madrid.EnterText(FinderVars.search_input_bar, "Real Betis");
			//madrid.Tap(FinderVars.search_input_bar);
			utils.Sleep(2);
			madrid.WaitForElement(FinderVars.main_title);
			madrid.DoubleTap(FinderVars.main_title);
			madrid.Tap(FinderVars.main_title);

            // Step 6: Click on Competition filter (Incompleto, falta método de comprobación lista horizontal)
            madrid.Tap(FinderVars.finder_filt_content_competition);
            madrid.WaitForElement(FinderVars.filters_submenu);

            // Step 7: Click on a @competition
            madrid.Tap(FinderVars.finder_filter_title_sup_cop_eur);
            madrid.WaitForElement(FinderVars.finder_tv_results);
            Assert.True(utils.existsElement(FinderVars.finder_tv_results));

            // Step 8: Click on Season filter
            madrid.SwipeRightToLeft(FinderVars.filters_bars, 0.10, 2000, true);
            madrid.Tap(FinderVars.finder_filt_content_seasson);
            madrid.WaitForElement(FinderVars.filters_submenu);

            // Step 9: Click on a @season
            madrid.Tap(FinderVars.finder_filter_single_container_1);
            madrid.WaitForElement(FinderVars.finder_tv_results);
            Assert.True(utils.existsElement(FinderVars.finder_tv_results));

            // Step 10: Unselect the previous @season
            madrid.Tap(FinderVars.finder_filt_content_seasson);
            madrid.Tap(FinderVars.finder_filter_single_container_1);

            // Step 11: Unselect the previous @competition
            madrid.Tap(FinderVars.finder_filt_content_competition);
            madrid.WaitForElement(FinderVars.filters_submenu);
            madrid.Tap(FinderVars.finder_filter_title_sup_cop_eur);

            // Step 12: Delete the @team
			madrid.WaitForElement(FinderVars.search_input_bar);
            madrid.ClearText(FinderVars.search_input_bar);

            // Step 13: Fill the text box "¿Qué quieres ver?" with the @team of the match you want to search
            madrid.EnterText(FinderVars.search_input_bar, "Barcelona");
            madrid.Tap(FinderVars.search_team_name);

            // Step 14: Repeat the steps 6, 7, 8 and 9
            madrid.Tap(FinderVars.finder_filt_content_competition);
            madrid.WaitForElement(FinderVars.filters_submenu);

            madrid.Tap(FinderVars.finder_filter_title_sup_cop_eur);
            madrid.WaitForElement(FinderVars.finder_tv_results);
            Assert.True(utils.existsElement(FinderVars.finder_tv_results));

            madrid.SwipeRightToLeft(FinderVars.filters_bars, 0.10, 2000, true);
            madrid.Tap(FinderVars.finder_filt_content_seasson);
            madrid.WaitForElement(FinderVars.filters_submenu);

            madrid.Tap(FinderVars.finder_filter_single_container_1);
            madrid.WaitForElement(FinderVars.finder_tv_results);
            Assert.True(utils.existsElement(FinderVars.finder_tv_results));
        }


        /*
        [Test]
        public void Test_35864() {
            // Step 2: Change sport basketball
            utils.Change_Sport();

            // Step 3: Go to Finder
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.main_title);

            // Step 4: Click on Type of Content and select "Matches" option
            madrid.Tap(FinderVars.finder_filt_content_type);
            madrid.WaitForElement(FinderVars.finder_filter_title_matches);

            madrid.Tap(FinderVars.finder_filter_title_matches);
            madrid.WaitForElement(FinderVars.finder_filter_matches_results);

            // Va a fallar, pues en la parte de baloncesto no existe Finder aún
        }
        */

        /*
        [Test]
        public void Test_35865() {
            // Step 2: Change sport basketball
            utils.Change_Sport();

            // Step 3: Go to Finder
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.main_title);

            // Step 4: Click on Content Type Match filter
            madrid.Tap(FinderVars.finder_filt_content_type);
            madrid.WaitForElement(FinderVars.finder_filter_title_matches);

            // Step 5: Select the Match option
            madrid.Tap(FinderVars.finder_filter_title_matches);
            madrid.WaitForElement(FinderVars.finder_filter_matches_results);

            // Step 6: Click on "Match area" button of a match

            // Va a fallar, pues en la parte de baloncesto no existe Finder aún
        }
        */

        /*
        [Test]
        public void Test_35866() {
            // Step 2: Change sport basketball
            utils.Change_Sport();

            // Step 3: Go to Finder
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.main_title);

            // Step 4: Click on Content Type Match filter
            madrid.Tap(FinderVars.finder_filt_content_type);
            madrid.WaitForElement(FinderVars.finder_filter_title_matches);

            // Step 5: Select the Match option
            madrid.Tap(FinderVars.finder_filter_title_matches);
            madrid.WaitForElement(FinderVars.finder_filter_matches_results);

            // Step 6: Click on "Buy Ticket" button of a match

            // Va a fallar, pues en la parte de baloncesto no existe Finder aún
        }
        */

        /*
        [Test]
        public void Test_35868() {
            // Step 2: Change sport basketball
            utils.Change_Sport();

            // Step 3: Go to Finder
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.main_title);

            // Step 4: Click on Content Type Match filter
            madrid.Tap(FinderVars.finder_filt_content_type);
            madrid.WaitForElement(FinderVars.finder_filter_title_matches);

            // Step 5: Select the Match option
            madrid.Tap(FinderVars.finder_filter_title_matches);
            madrid.WaitForElement(FinderVars.finder_filter_matches_results);

            // Step 6, 7, 8, 9 and 10: No existe Finder, identificadores desconocidos por ahora.

            // Va a fallar, pues en la parte de baloncesto no existe Finder aún
        }
        */

        /*
        [Test]
        public void Test_35869() {
            // Step 2: Change sport basketball
            utils.Change_Sport();

            // Step 3: Go to Finder
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.main_title);

            // Step 4: Click on Content Type Match filter
            madrid.Tap(FinderVars.finder_filt_content_type);
            madrid.WaitForElement(FinderVars.finder_filter_title_matches);

            // Step 5: Select the Match option
            madrid.Tap(FinderVars.finder_filter_title_matches);
            madrid.WaitForElement(FinderVars.finder_filter_matches_results);

            // Step 6, 7, 8 and 9: No existe Finder, identificadores desconocidos por ahora.

            // Va a fallar, pues en la parte de baloncesto no existe Finder aún
        }
        */

        /*
        [Test]
        public void Test_35870() {
            // Step 2: Change sport basketball
            utils.Change_Sport();

            // Step 3: Go to Finder
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.main_title);

            // Step 4: Click on Content Type Match filter
            madrid.Tap(FinderVars.finder_filt_content_type);
            madrid.WaitForElement(FinderVars.finder_filter_title_matches);

            // Step 5: Select the Match option
            madrid.Tap(FinderVars.finder_filter_title_matches);
            madrid.WaitForElement(FinderVars.finder_filter_matches_results);

            // Step 6, 7, 8, 9, 10, 11, 12 and 13: No existe Finder, identificadores desconocidos por ahora.

            // Va a fallar, pues en la parte de baloncesto no existe Finder aún
        }
        */

        /*
        [Test]
        public void Test_35872() {
            // Step 2: Change sport basketball
            utils.Change_Sport();

            // Step 3: Go to Finder
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.main_title);

            // Step 4 and 5: No existe Finder, identificadores desconocidos por ahora.

            // Va a fallar, pues en la parte de baloncesto no existe Finder aún
        }
        */


        [Test]
        //Mark a match as a favourite
        public void Test_35972() {
			// Step 2: Go to Finder
			utils.Sleep(5);
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.main_title);

            // Step 3: Search a played match
            utils.Go_To(FinderVars.content, FinderVars.finder_like_button);
            madrid.WaitForElement(FinderVars.finder_like_button);
            Assert.True(utils.existsElement(FinderVars.finder_like_button));

            // Step 4: Click on the "favourites" button
            madrid.Tap(FinderVars.finder_like_button);
            AppResult[] results = madrid.Query(FinderVars.finder_match_date);
            String matchDate = results[0].Text;

            // Step 5: Go to profile
            //madrid.Back();
            madrid.Tap(NavigationBarVars.navbar_Profile_but);

            // Step 6: Scroll down to status placeholder
			madrid.ScrollDownTo(ProfileVars.profile_favourites_but);
            madrid.WaitForElement(ProfileVars.profile_favourites_but);
            Assert.True(utils.existsElement(ProfileVars.profile_favourites_but));

            // Step 7: Click on the favourites button
            madrid.Tap(ProfileVars.profile_favourites_but);
            madrid.WaitForElement(ProfileVars.profile_favourites_Partidos_text);
            Assert.True(utils.existsElement(ProfileVars.profile_favourites_Partidos_text));

            // step 8: Check the selected match as a favorite
            madrid.Tap(ProfileVars.profile_favourites_Partidos_text);
            madrid.WaitForElement(ProfileVars.profile_fav_matches_content);
            Assert.True(utils.existsElement(ProfileVars.profile_fav_matches_content));

            //results = madrid.Query(FinderVars.finder_match_date);
            //Assert.True(results[0].Text.Equals(matchDate));
			Assert.True(utils.existsElement(b=> b.Marked(matchDate)));
            //madrid.Tap(FinderVars.finder_like_button);
			madrid.Tap(ProfileVars.my_like_match_button);
        }


        [Test]
        //Unmark a videoas a favourite
        public void Test_35974() {
			// Step 2: Go to Finder
			utils.Sleep(5);
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.main_title);

            // Auxiliar: Select a match as favourite
            utils.Go_To(FinderVars.content, FinderVars.finder_like_button);
            madrid.WaitForElement(FinderVars.finder_like_button);
            madrid.Tap(FinderVars.finder_like_button);
            utils.Sleep(1);
			madrid.Tap(NavigationBarVars.navbar_Home_but);
            //madrid.Back();

            // Step 3: Search a match mark as a favourite
            //madrid.Tap(a => a.Id("img").Index(4));
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.main_title);
            utils.Sleep(2);
            utils.Go_To(FinderVars.content, FinderVars.finder_like_button);

            // Step 4: Click on the "favourite" button
            madrid.Tap(FinderVars.finder_like_button);
            utils.Sleep(3);
            //madrid.Back();

            // Step 5: Go to profile
            madrid.Tap(NavigationBarVars.navbar_Profile_but);

            // Step 6: Scroll down to status placeholder
            madrid.ScrollDownTo(ProfileVars.profile_favourites_but);

            // Step 7: Click on the favourites button
            madrid.ScrollDownTo(ProfileVars.profile_favourites_but);
            madrid.WaitForElement(ProfileVars.profile_favourites_but);
			madrid.Tap(ProfileVars.profile_favourites_but);
            madrid.WaitForElement(ProfileVars.profile_favourites_Partidos_text);

            // Step 8: Check the match does not appear in the favourite page
            madrid.Tap(ProfileVars.profile_favourites_Partidos_text);
            madrid.WaitForElement(ProfileVars.profile_fav_matches_content);
            utils.Sleep(3);
            Assert.True(!utils.existsElement(FinderVars.finder_last_matches_view));
        }


        [Test]
        //Go to on old Match Area through a match of the finder
        public void Test_36107() {
			utils.Sleep(5);
            // Step 2: Go to Finder
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.main_title);

            // Step 3: Click on Content Type Match filter
            madrid.Tap(FinderVars.finder_filt_content_type);
            madrid.WaitForElement(FinderVars.finder_filter_title_matches);

            // Step 4: Select the Match option
            madrid.Tap(FinderVars.finder_filter_title_matches);
            madrid.WaitForElement(FinderVars.finder_filter_matches_results);

            // Step 5: Click on Competition filter (Incompleto, falta método de comprobación lista horizontal)
            madrid.Tap(FinderVars.finder_filt_content_competition);
            madrid.WaitForElement(FinderVars.filters_submenu);

            // Step 6: Select "La Liga"
            madrid.SwipeRightToLeft(FinderVars.filters_submenu, 0.80, 3000, true);
            madrid.WaitForElement(FinderVars.finder_filter_title_the_league);
            madrid.Tap(FinderVars.finder_filter_title_the_league);

            // Step 7: Scroll to the bottom
            // && 
            // Step 8: Click on 07 - 01 - 2012 Real Madrid 5 - 1 Granada CF.
            String matchDate = "07 ene. 2017 - Finalizado";
			Go_To_Slow(HomeVars.home_content, a => a.Text(matchDate));
			//madrid.ScrollDownTo(a => a.Text(matchDate));
			Assert.True(utils.existsElement(FinderVars.finder_last_matches_view));
            //madrid.Back();
        }


        /******************************************** FINDER / Videos ************************************************/

        [Test]
        //Search by video
        public void Test_35547() {
			utils.Sleep(5);
            // Step 2: Go to Finder
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.main_title);

            // Step 3: Click on Type of Content ad select "Videos" option
            madrid.Tap(FinderVars.finder_filt_content_type);
            madrid.WaitForElement(FinderVars.finder_filter_title_videos);
			madrid.Tap(FinderVars.finder_filter_title_videos);
			utils.Sleep(1);
            //Go_To_Slow(FinderVars.content, FinderVars.Video_Section_viewed);
            Go_To_Slow(FinderVars.content, FinderVars.Video_Section_Highlighted);
            Go_To_Slow(FinderVars.content, FinderVars.Video_Section_Recomended);
            Go_To_Slow(FinderVars.content, FinderVars.Video_Section_viewed);
            Go_To_Slow(FinderVars.content, FinderVars.Video_Section_Searched);
			Go_To_Slow(FinderVars.content, FinderVars.Video_Section_Valuable);
			/*
            List<String> list = new List<String>();
            list.Add("Destacados");
            list.Add("Recomendados");
            list.Add("Más visualizados");
            list.Add("Más buscados");
            list.Add("Más valorados");
            Assert.True(utils.existsElementList(FinderVars.content, FinderVars.section_title, list));
            //madrid.Back();*/
        }


        /********************************** FINDER / Videos / Highlighted videos *************************************/

        [Test]
        //Visualize highlighted videos
        public void Test_35640() {
            // Step 2: Go to Finder
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.main_title);

            // Step 3: Check the Highlighted videos
            AppResult[] results = madrid.Query(FinderVars.section_title);
			Assert.True(utils.existsElement(FinderVars.finder_highlighted_videos));
            // Step 3: Click on Content Type Video filter
            madrid.Tap(FinderVars.finder_filt_content_type);
            madrid.WaitForElement(FinderVars.finder_filter_title_videos);

            // Step 5: Select the video option
            madrid.Tap(FinderVars.finder_filter_title_videos);

            // Step 6: Check the Highlighted videos appear
            results = madrid.Query(FinderVars.section_title);
			madrid.WaitForElement(FinderVars.Video_Section_Highlighted);
			Assert.True(utils.existsElement(FinderVars.Video_Section_Highlighted));
        }


        [Test]
        //Check highlighted videos are the same for different users
        public void Test_35642() {
            // Step 2: Go to Finder
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.main_title);

            // Step 3: Check the Highlighted videos
            AppResult[] results = madrid.Query(FinderVars.section_title);
            //Assert.True(results[0].Text.Equals("Vídeos destacados"));
			Assert.True(utils.existsElement(FinderVars.finder_highlighted_videos));

            // Step 4: Logout
            utils.Sign_Off();
			utils.Sleep(4);
            // Step 5: Login with a diferent user
            utils.Login_parameters(Strings.LOGIN_USERNAME1, Strings.LOGIN_PASSWORD1);

            // Step 6: go to Finder
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.main_title);

            // Step 7: Check the Highlighted videos
            results = madrid.Query(FinderVars.section_title);
            //Assert.True(results[0].Text.Equals("Vídeos destacados"));
			Assert.True(utils.existsElement(FinderVars.finder_highlighted_videos));

        }


        /********************************** FINDER / Videos / Most searched videos ************************************/
       //NO ESTA EN EL TEST PLAN
        /*
        [Test]
        public void Test_35460() {
            // Step 2: Go to Finder
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.main_title);

            // Step 3: Click on Type of Content ad select "Videos" option
            madrid.Tap(FinderVars.finder_filt_content_type);
            madrid.WaitForElement(FinderVars.finder_filter_title_videos);
            madrid.Tap(FinderVars.finder_filter_title_videos);

            // Step 4: Scroll down and check there is a "Más buscados" videos section
            madrid.WaitForElement(FinderVars.filters_results);
            utils.Go_To(FinderVars.content, a => a.Id("section_title").Text("Más buscados"));
            Assert.True(utils.existsElement(a => a.Id("section_title").Text("Más buscados")));

            // Step 5: Check the displayed videos
            madrid.WaitForElement(FinderVars.section_content);
            madrid.Back();

            // Step 6: Logout
            utils.Enter_Home();
            utils.Sign_Off();

            // Step 7: Login the app with different user
            utils.Login_parameters(Strings.LOGIN_USERNAME1, Strings.LOGIN_PASSWORD1);

            // Step 8: Go to Finder
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.main_title);

            // Step 9: Click on Type of Content ad select "Videos" option
            madrid.Tap(FinderVars.finder_filt_content_type);
            madrid.WaitForElement(FinderVars.finder_filter_title_videos);
            madrid.Tap(FinderVars.finder_filter_title_videos);

            // Step 10: Scroll down and check there is a "Más buscados" videos section
            madrid.WaitForElement(FinderVars.filters_results);
            utils.Go_To(FinderVars.content, a => a.Id("section_title").Text("Más buscados"));
            Assert.True(utils.existsElement(a => a.Id("section_title").Text("Más buscados")));

            // Step 11: Check the displayed videos
            madrid.WaitForElement(FinderVars.section_content);
            madrid.Back();
        }
        */

        /********************************** FINDER / Videos / Most watched videos *************************************/

        /*
        [Test]
        public void Test_35464() {
            // Step 2: Go to Finder
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.main_title);

            // Step 3: Click on Type of Content ad select "Videos" option
            madrid.Tap(FinderVars.finder_filt_content_type);
            madrid.WaitForElement(FinderVars.finder_filter_title_videos);
            madrid.Tap(FinderVars.finder_filter_title_videos);

            // Step 4: Scroll down and check there is a "Más buscados" videos section
            madrid.WaitForElement(FinderVars.filters_results);
            utils.Go_To(FinderVars.content, a => a.Id("section_title").Text("Más visualizados"));
            Assert.True(utils.existsElement(a => a.Id("section_title").Text("Más visualizados")));

            // Step 5: Check the displayed videos
            madrid.WaitForElement(FinderVars.section_content);
            madrid.Back();

            // Step 6: Logout
            utils.Enter_Home();
            utils.Sign_Off();

            // Step 7: Login the app with different user
            utils.Login_parameters(Strings.LOGIN_USERNAME1, Strings.LOGIN_PASSWORD1);

            // Step 8: Go to Finder
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.main_title);

            // Step 9: Click on Type of Content ad select "Videos" option
            madrid.Tap(FinderVars.finder_filt_content_type);
            madrid.WaitForElement(FinderVars.finder_filter_title_videos);
            madrid.Tap(FinderVars.finder_filter_title_videos);

            // Step 10: Scroll down and check there is a "Más buscados" videos section
            madrid.WaitForElement(FinderVars.filters_results);
            utils.Go_To(FinderVars.content, a => a.Id("section_title").Text("Más visualizados"));
            Assert.True(utils.existsElement(a => a.Id("section_title").Text("Más visualizados")));

            // Step 11: Check the displayed videos
            madrid.WaitForElement(FinderVars.section_content);
            madrid.Back();
        }
        */

        /*********************************** FINDER / Videos / Ratings videos *****************************************/

        [Test]
        //Visualize the user ratings
        public void Test_35608()
        {
            //Step 2: Go to Finder
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.main_title);
            utils.Sleep(3);

            //Step 3: Search a video you want to see the rating
            //AppResult[] result_list_videos = madrid.Query(FinderVars.video_title);
            //Assert.True(result_list_videos.Length > 1, "A list of videos isn't displayed");

            //Step 4: Click on the video
            madrid.Tap(FinderVars.video_image);
            madrid.WaitForElement(FinderVars.videos_title);
            utils.Sleep(3);

			//Step 5: Click on the stars of the video
			madrid.ScrollDownTo(FinderVars.video_ratting);
            madrid.Tap(FinderVars.video_ratting);
            utils.Sleep(3);

            Assert.True(utils.existsElement(FinderVars.video_rating_popup_title), "Title popup doesn't exist");
            Assert.True(utils.existsElement(FinderVars.video_ratting_popup), "Ratting doesn't exist");
            Assert.True(utils.existsElement(FinderVars.video_ok_not_purchased), "OK button doesn't exist");
            Assert.True(utils.existsElement(FinderVars.video_cancel_but), "Cancel button doesn't exist");

        }

        [Test]
        //Visualize video rating average
        public void Test_35609() {
            // Step 2: Go to Finder
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.main_title);

            // Step 3: Search a video you want to rate
            madrid.WaitForElement(FinderVars.section_video);

            // Step 4: Click on the video
            madrid.Tap(FinderVars.section_video);

			// Step 5 See the video ratting average
			madrid.ScrollDownTo(FinderVars.video_ratting);
            madrid.WaitForElement(FinderVars.video_ratting);
            Assert.True(utils.existsElement(FinderVars.video_ratting));
        }

        [Test]
        //User can not rate a video that does not own
        public void Test_35713() {
            // Step 2: Go to Finder
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.main_title);

            // Step 3: Search a video you want to rate
            madrid.WaitForElement(FinderVars.section_video);

            // Step 4: Click on the video
            madrid.Tap(FinderVars.section_video);
            madrid.WaitForElement(FinderVars.video_ratting);

            // Step 5: Click on the stars of the video
            madrid.Tap(FinderVars.video_ratting);
            Assert.True(!utils.existsElement(FinderVars.video_rating_popup));
        }


        /********************************** FINDER / Videos / Most rated videos ***************************************/

        [Test]
        //Visualize most rated videos
        public void Test_35553() {
            // Step 2: Go to Finder
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.main_title);

            // Step 3: Click on Type of Content ad select "Videos" option
            madrid.Tap(FinderVars.finder_filt_content_type);
            madrid.WaitForElement(FinderVars.finder_filter_title_videos);
            madrid.Tap(FinderVars.finder_filter_title_videos);

            // Step 4: Scroll down and check there is a "Más buscados" videos section
            madrid.WaitForElement(FinderVars.filters_results);
            utils.Go_To(FinderVars.content, FinderVars.matches_section_most_rated);
            Assert.True(utils.existsElement(FinderVars.matches_section_most_rated));

            // Step 5: Check the displayed videos
            madrid.WaitForElement(FinderVars.section_content);
            //madrid.Back();

            // Step 6: Logout
            utils.Enter_Home();
            utils.Sign_Off();
			utils.Sleep(4);

            // Step 7: Login the app with different user
            utils.Login_parameters(Strings.LOGIN_USERNAME1, Strings.LOGIN_PASSWORD1);

            // Step 8: Go to Finder
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.main_title);

            // Step 9: Click on Type of Content ad select "Videos" option
            madrid.Tap(FinderVars.finder_filt_content_type);
            madrid.WaitForElement(FinderVars.finder_filter_title_videos);
            madrid.Tap(FinderVars.finder_filter_title_videos);

            // Step 10: Scroll down and check there is a "Más buscados" videos section
            madrid.WaitForElement(FinderVars.filters_results);
            utils.Go_To(FinderVars.content, FinderVars.matches_section_most_rated);
            Assert.True(utils.existsElement(FinderVars.matches_section_most_rated));

            // Step 11: Check the displayed videos
            madrid.WaitForElement(FinderVars.section_content);
            //madrid.Back();
        }


        /********************************** FINDER / Videos / Recommended videos **************************************/

        [Test]
        //Check that a user has recommended videos by default
        public void Test_35585() {
            // Step 2: Go to Finder
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.main_title);

            // Step 3: Click on Content Type filter
            madrid.Tap(FinderVars.finder_filt_content_type);
            madrid.WaitForElement(FinderVars.finder_filter_title_videos);

            // Step 4: Click on Videos
            madrid.Tap(FinderVars.finder_filter_title_videos);
            madrid.WaitForElement(FinderVars.filters_results);

            // Step 5: Scroll down to search recommended videos
            Go_To_Slow(FinderVars.content, FinderVars.matches_section_recommended);
            Assert.True(utils.existsElement(FinderVars.matches_section_recommended));
        }

        [Test]
        //Check recommended videos are different for different users
        public void Test_35591() {
            // Step 2: Go to Finder
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.main_title);

            // Step 3: Click on Content Type filter
            madrid.Tap(FinderVars.finder_filt_content_type);
            madrid.WaitForElement(FinderVars.finder_filter_title_videos);

            // Step 4: Click on Videos
            madrid.Tap(FinderVars.finder_filter_title_videos);
            madrid.WaitForElement(FinderVars.filters_results);

            // Step 5: Scroll down to search recommended videos
			Go_To_Slow(FinderVars.content, FinderVars.matches_section_recommended);

            // Step 6: Logout
            //madrid.Back();
            utils.Enter_Home();
            utils.Sign_Off();

			// Sept 7: Login with different user
			utils.Sleep(5);
            utils.Login_parameters(Strings.LOGIN_USERNAME1, Strings.LOGIN_PASSWORD1);

            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.main_title);

            // Step 8: Click on Content Type filter
            madrid.Tap(FinderVars.finder_filt_content_type);
            madrid.WaitForElement(FinderVars.finder_filter_title_videos);

            // Step 9: Click on Videos
            madrid.Tap(FinderVars.finder_filter_title_videos);
            madrid.WaitForElement(FinderVars.filters_results);

            // Step 10: Scroll down to search recommended videos
            Go_To_Slow(FinderVars.content, FinderVars.matches_section_recommended);
        }


        /************************************ FINDER / Videos / Video Details ****************************************/

        [Test]
        //Visualize video detail
        public void Test_35613() {
			// Step 2: Change sport Football
			// Step 3: Go to Finder
			utils.Sleep(5);
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.main_title);

            // Step 4: Search a @video
            madrid.WaitForElement(FinderVars.section_video);

            // Step 5: Click on @video
            madrid.Tap(FinderVars.section_video);
            madrid.WaitForElement(FinderVars.videos_title);
            Assert.True(utils.existsElement(FinderVars.video_detail_title));
            Assert.True(utils.existsElement(FinderVars.video_description));
            Assert.True(utils.existsElement(FinderVars.video_ratting));
            Assert.True(utils.existsElement(FinderVars.video_detail_image));
        }



        [Test]
        //Visualize related videos
        public void Test_35631() {
			// Step 2: Change sport Football
			// Step 3: Go to Finder
			utils.Sleep(5);
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.main_title);

            // Step 4: Search a @video
            madrid.WaitForElement(FinderVars.section_video);

            // Step 5: Click on the video
            madrid.Tap(FinderVars.section_video);
            madrid.WaitForElement(FinderVars.videos_title);

            utils.Go_To(FinderVars.content, FinderVars.video_detail_related);
            Assert.True(utils.existsElement(FinderVars.video_detail_related));
        }



        [Test]
        //Visualize Associated subscriptions or packs
        public void Test_35635() {
			// Step 2: Change sport Football
			// Step 3: Go to Finder
			utils.Sleep(5);
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);

            // Step 4: Search a @video (this video should have a associated suscription)
            madrid.WaitForElement(FinderVars.main_title);

            // Step 5: Click on the @video
            madrid.Tap(FinderVars.section_video_1);
            madrid.WaitForElement(FinderVars.videos_title);

            utils.Go_To(FinderVars.content, FinderVars.section_title);
			madrid.ScrollDownTo(FinderVars.video_detail_related);
            //AppResult[] results = madrid.Query(FinderVars.section_title);
            //Assert.True(!results[0].Text.Equals("Vídeos relacionados"));
        }



        [Test]
        //Play video with a purchased subscription
        public void Test_35637() {
			// Step 2: Go to Finder
			utils.Sleep(5);
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.main_title);

            // Step 3: Search a @video
            madrid.WaitForElement(FinderVars.section_video);
			utils.Sleep(5);

            // Step 4: Click on the @video
            madrid.Tap(FinderVars.section_video_1);
            madrid.WaitForElement(FinderVars.videos_title);
			utils.Sleep(5);

            // Step 5: Play Video
            //madrid.DoubleTap(FinderVars.video_play_button);
			madrid.Tap(FinderVars.video_play_button);
            utils.Sleep(5);
            madrid.WaitForElement(FinderVars.videos_title, "Play timeout reached", TimeSpan.FromSeconds(20));
            Assert.True(utils.existsElement(FinderVars.videos_title));
        }



        [Test]
        //User can not reproduced a video that does not own
        public void Test_35638() {
			// Step 2: Go to Finder
			utils.Sleep(2);
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
			utils.Sleep(4);
            madrid.WaitForElement(FinderVars.main_title);
			madrid.WaitForElement(FinderVars.section_video);
			utils.Sleep(5);

            // Step 3: Search a purchasable video that the user has not purchased
            utils.Sleep(9);
			utils.Swipe_To_Right(FinderVars.filters_results, FinderVars.filter_videos_purchase_example);

            // Step 4: Click on the @video
            madrid.DoubleTap(FinderVars.filter_videos_purchase_example);
            madrid.WaitForElement(FinderVars.videos_title);

            // Step 5: Play video
            madrid.Tap(FinderVars.video_play_button);
            madrid.WaitForElement(FinderVars.video_not_purchased_text);
            Assert.True(utils.existsElement(FinderVars.video_not_purchased_text));
            madrid.Tap(FinderVars.video_ok_not_purchased);
        }



        [Test]
        //Visualize video without purchased subcriptions
        public void Test_35641() {
            // Step 2: Go to Finder
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.main_title);

            // Step 3: Search a purchasable video that the user has not purchased
            utils.Swipe_To_Right(FinderVars.filters_results, FinderVars.filter_videos_purchase_example);

            // Step 4: Click on the @video
            madrid.Tap(FinderVars.filter_videos_purchase_example);
            madrid.WaitForElement(FinderVars.videos_title);

            // Step 5: Click on the padlock
            madrid.Tap(FinderVars.video_play_button);
            madrid.WaitForElement(FinderVars.video_not_purchased_text);
            Assert.True(utils.existsElement(FinderVars.video_not_purchased_text));
            madrid.Tap(FinderVars.video_ok_not_purchased);
        }



        [Test]
        //Check that our video is within associated subscriptions
        public void Test_35645() {
            // Step 2: Go to Finder
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.main_title);

            // Step 3: Search a @video
            madrid.WaitForElement(FinderVars.section_video);

            // Step 4: Click on the @video
            madrid.Tap(FinderVars.section_video_1);
            madrid.WaitForElement(FinderVars.videos_title);

            // Step 5: Click on associated @subscription
            AppResult[] results = madrid.Query(FinderVars.video_detail_title);
            String video = results[0].Text;
            utils.Go_To(FinderVars.content, FinderVars.video_subscription_pack);

            madrid.Tap(FinderVars.video_subscription_pack);
            utils.Go_To(FinderVars.content, a => a.Class("RMContainerTableViewCell").Child("UITableViewCellContentView").Child("UIView").Child("UILabel").Marked(video));
            Assert.True(utils.existsElement(a => a.Class("RMContainerTableViewCell").Child("UITableViewCellContentView").Child("UIView").Child("UILabel").Marked(video)));
        }



        [Test]
        //Not show associated subscriptions when video doesn't have associated subscription
        public void Test_35781() {
            // Step 2: Go to Finder
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.main_title);

            // Step 3: Search a @video(video without associated subscriptions)
            madrid.WaitForElement(FinderVars.section_video);

            // Step 4: Click on the @video
            madrid.Tap(FinderVars.section_video);
            madrid.WaitForElement(FinderVars.videos_title);

            utils.Go_To(FinderVars.content, FinderVars.section_title);
            AppResult[] results = madrid.Query(FinderVars.section_title);
            Assert.False(results[0].Text.Contains("Vídeos relacionados"), "Associated subscriptions is shown");
        }


        [Test]
        //Play video without associated subscriptions
        public void Test_35807()
        {
            //Step 2: Go to Finder
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
			utils.Sleep(4);
            madrid.WaitForElement(FinderVars.main_title);
			utils.Sleep(4);
            //Step 3: Search a video
			madrid.WaitForElement(FinderVars.search_input_bar);
            madrid.EnterText(FinderVars.search_input_bar, "TEST GEO-TIME BLOCKING - Highlights Champions Real Madrid-Sporting Lisbon");
			utils.Sleep(4);
			madrid.PressEnter();
			utils.Sleep(4);
            //madrid.Tap(FinderVars.search_team_name);
            utils.Sleep(4);

            //Step 4: Click on a video
            madrid.Tap(FinderVars.video_image);
            if (!utils.existsElement(FinderVars.videos_title))
                madrid.Tap(FinderVars.video_image);
            madrid.WaitForElement(FinderVars.videos_title);

            //Step 5: Play video
			utils.Sleep(3);
            madrid.Tap(FinderVars.video_play_button);
            utils.Sleep(3);
            Assert.False(utils.existsElement(FinderVars.video_alert_popup_title), "The video doesn't play");

        }


        /************************************ FINDER / Videos / Search videos by feature ****************************************/
        /*
        [Test]
        // Search by text which some words contained in name and some in the description
        public void Test_35465() {
            // Step 2: Go to Finder
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);

            // Step 3: Fill the text box "¿Qué quieres ver?" with the @words of the video you want to see
            madrid.WaitForElement(FinderVars.search_bar_layout);
            madrid.Tap(FinderVars.search_input_bar);
            madrid.EnterText("Real Betis");

            madrid.WaitForElement(FinderVars.search_team_name);
            madrid.Tap(FinderVars.search_team_name);

            madrid.WaitForElement(FinderVars.section_video);
            madrid.Tap(FinderVars.section_video);
            madrid.Tap(FinderVars.section_video);

            madrid.WaitForElement(FinderVars.videos_title);
            utils.Sleep(3);

            Assert.True(utils.existsElement(FinderVars.option_title), "The title video doesn't exist");
            Assert.True(utils.existsElement(FinderVars.video_description), "The description video doesn't exist");

        }
        */


        [Test]
        // Search by name
        public void Test_35565() {
            // Step 2: Go to Finder
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
			utils.Sleep(4);

            String name = "Vídeo Subscription QA test1 (I)";

            // Step 3: Fill the text box "¿Qué quieres ver?" with the @name of the video you want to see
            utils.Sleep(4);
			madrid.WaitForElement(FinderVars.search_bar_layout);
            madrid.EnterText(FinderVars.search_input_bar, name);
			madrid.PressEnter();
			utils.Sleep(3);

			/*if (platform == Platform.Android) {
                Xamarin.UITest.Android.AndroidApp app = (Xamarin.UITest.Android.AndroidApp)madrid;
                app.PressUserAction();
            }*/

			// Step 4: Click in the first video
			//madrid.Tap(FinderVars.section_video);
			madrid.WaitForElement(FinderVars.section_video);
            madrid.Tap(FinderVars.section_video);
            madrid.WaitForElement(FinderVars.videos_title);

            AppResult[] results = madrid.Query(FinderVars.option_title);
			Assert.True(results[0].Text.Contains(name));
        }



        [Test]
        // Search by description
        public void Test_35567() {
            // Step 2: Go to Finder
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);

            String description = "Vídeo Subscription QA test1 (I) description";
			utils.Sleep(9);

            // Step 3: Fill the text box "¿Qué quieres ver?" with the @name of the video you want to see
            madrid.WaitForElement(FinderVars.search_bar_layout);
            madrid.EnterText(FinderVars.search_input_bar, description);
			madrid.PressEnter();

            /*if (platform == Platform.Android) {
                Xamarin.UITest.Android.AndroidApp app = (Xamarin.UITest.Android.AndroidApp)madrid;
                app.PressUserAction();
            }*/

            // Step 4: Click in the first video
            madrid.Tap(FinderVars.section_video);
            //madrid.Tap(FinderVars.section_video);
            madrid.WaitForElement(FinderVars.videos_title);

            AppResult[] results = madrid.Query(FinderVars.video_description);
			Assert.True(results[0].Text.Contains(description));
        }

        [Test]
        // Search by metadata
        public void Test_35568() {
            // Step 2: Go to Finder
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);

            String description = "Pie Izquierdo";

            // Step 3: Fill the text box "¿Qué quieres ver?" with the @metadata of the video you want to see
            madrid.WaitForElement(FinderVars.search_bar_layout);
            madrid.EnterText(FinderVars.search_input_bar, description);
			madrid.PressEnter();

            /*if (platform == Platform.Android)
            {
                Xamarin.UITest.Android.AndroidApp app = (Xamarin.UITest.Android.AndroidApp)madrid;
                app.PressUserAction();
            }*/

            // Step 4: Click in the first video
            madrid.Tap(FinderVars.section_video);
            //madrid.Tap(FinderVars.section_video);
            madrid.WaitForElement(FinderVars.videos_title);
            utils.Sleep(3);
            //madrid.Repl();
            AppResult[] results = madrid.Query(FinderVars.video_description);
            Assert.True(results[0].Text.Contains(description), "The videos doesn't contains de @metadata");
        }


        [Test]
        // Apply competition filter
        public void Test_35570() {
            // Step 2: Go to Finder
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
			utils.Sleep(12);
            madrid.WaitForElement(FinderVars.filters_bars);

            // Step 3: Click on Content Type Video filter
            madrid.Tap(FinderVars.finder_filt_content_type);
            madrid.WaitForElement(FinderVars.filters_submenu_options);

            // Step 4: Select the Videos option
            madrid.Tap(FinderVars.finder_filter_title_videos);

            // Step 5: Click on Competition filter
            madrid.Tap(FinderVars.finder_filt_content_competition);
            madrid.WaitForElement(FinderVars.filters_submenu_options);

            // Step 6: Click on a @competition
            madrid.Tap(FinderVars.finder_filter_title_sup_cop_eur);

            // Step 7: Unselect the previous @competition
			madrid.Tap(FinderVars.finder_filt_content_competition);
            madrid.WaitForElement(FinderVars.filters_submenu_options);
			madrid.Tap(FinderVars.finder_filter_title_sup_cop_eur);
            //madrid.Tap(a => a.Class("RMFinderFilterCollectionViewCell").Child("UIView").Child("UIButton").Index(1));

            // Step 8: Click on other @competition
			madrid.Tap(FinderVars.finder_filt_content_competition);
            madrid.WaitForElement(FinderVars.filters_submenu_options);
            madrid.Tap(FinderVars.finder_filter_title_sup_cop_esp);
        }

        [Test]
        //Apply season filter
        public void Test_35571()
        {

            //Step 2: Go to finder
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            utils.Sleep(12);
			madrid.WaitForElement(FinderVars.filters_bars);


            //Step 3: Click on Content Type videos filter
            madrid.Tap(FinderVars.finder_filt_content_type);
            madrid.WaitForElement(FinderVars.filters_submenu_options);

            Assert.True(utils.existsElement(FinderVars.finder_filter_title_videos), "Videos option doesn't exist");
            Assert.True(utils.existsElement(FinderVars.finder_filter_title_matches), "Matches option doesn't exist");

            //Step 4: Select the videos option
            madrid.Tap(FinderVars.finder_filter_title_videos);

            // Step 5: Click on Season filter
            utils.Swipe_To_Right(FinderVars.filters_submenu_options, FinderVars.finder_filt_content_seasson);
            madrid.Tap(FinderVars.finder_filt_content_seasson);
            utils.Sleep(5);

            Assert.True(utils.existsElement(FinderVars.filter_seasson_1415), "Season 2014-2015 doesn't exist");
            Assert.True(utils.existsElement(FinderVars.filter_seasson_1516), "Season 2015-2016 doesn't exist");
            Assert.True(utils.existsElement(FinderVars.filter_seasson_1617), "Season 2016-2017 doesn't exist");

            // Step 6: Click on a @season
            madrid.Tap(FinderVars.filter_seasson_1415);
			madrid.PressEnter();
            utils.Sleep(5);

            AppResult[] result_filter_season_videos1 = madrid.Query(FinderVars.video_title);

            // Step 7: Unselect the previous season
            //madrid.Tap(FinderVars.search_input_icon);
			madrid.Tap(FinderVars.finder_filt_content_seasson);
            utils.Sleep(5);
			madrid.Tap(FinderVars.filter_seasson_1415);


            // Step 8: Click on other @season
           	madrid.Tap(FinderVars.finder_filt_content_seasson);
            madrid.Tap(FinderVars.filter_seasson_1516);
            utils.Sleep(5);

            AppResult[] result_filter_season_videos2 = madrid.Query(FinderVars.video_title);
            Assert.AreNotEqual(result_filter_season_videos1[0].Text, result_filter_season_videos2[0].Text, "Season videos are similar");

        }


        [Test]
        //Apply player filter
        public void Test_35572(){

            //Step 2: Go to finder
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
			utils.Sleep(12);
            madrid.WaitForElement(FinderVars.filters_bars);

            //Step 3: Click on Content Type videos filter
            madrid.Tap(FinderVars.finder_filt_content_type);
            madrid.WaitForElement(FinderVars.filters_submenu_options);

            Assert.True(utils.existsElement(FinderVars.finder_filter_title_videos), "Videos option doesn't exist");
            Assert.True(utils.existsElement(FinderVars.finder_filter_title_matches), "Matches option doesn't exist");

            //Step 4: Select the videos option
            madrid.Tap(FinderVars.finder_filter_title_videos);

            // Step 5: Click on Player filter
            utils.Swipe_To_Right(FinderVars.filters_banner, FinderVars.finder_filt_content_players);
			utils.Sleep(2);
            madrid.Tap(FinderVars.finder_filt_content_players);
            utils.Sleep(5);

            Assert.True(utils.existsElement(FinderVars.filter_player_keylor), "Keylor Navas doesn't exist");
            Assert.True(utils.existsElement(FinderVars.filter_player_raphael), "Raphael Varane doesn't exist");
            

            // Step 6: Click on a @player
            madrid.Tap(FinderVars.filter_player_keylor);
            madrid.Tap(FinderVars.finder_filt_content_players);
            utils.Sleep(5);

            AppResult[] result_filter_season_videos1 = madrid.Query(FinderVars.video_title);

            // Step 7: Unselect the previous player
			madrid.Tap(FinderVars.finder_filt_content_players);
			madrid.Tap(FinderVars.filter_player_keylor);
			//madrid.Tap(FinderVars.finder_filt_content_players);
            //utils.Swipe_To_Right(FinderVars.filters_submenu_options, FinderVars.search_input_icon);
            //madrid.Tap(FinderVars.search_input_icon);

            // Step 8: Click on other @player
            //madrid.Tap(FinderVars.finder_filt_content_players);
            madrid.Tap(FinderVars.filter_player_raphael);
            madrid.Tap(FinderVars.finder_filt_content_players);
            utils.Sleep(7);

            AppResult[] result_filter_season_videos2 = madrid.Query(FinderVars.video_title);
            Assert.AreNotEqual(result_filter_season_videos1[0].Text, result_filter_season_videos2[0].Text, "Players videos are similar");
        }

        [Test]
        //Apply categories filter
        public void Test_35573(){
            //Step 2: Go to finder
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
			utils.Sleep(12);
            madrid.WaitForElement(FinderVars.filters_bars);

            //Step 3: Click on Content Type videos filter
            madrid.Tap(FinderVars.finder_filt_content_type);
            madrid.WaitForElement(FinderVars.filters_submenu_options);

            Assert.True(utils.existsElement(FinderVars.finder_filter_title_videos), "Videos option doesn't exist");
            Assert.True(utils.existsElement(FinderVars.finder_filter_title_matches), "Matches option doesn't exist");

            //Step 4: Select the videos option
            madrid.Tap(FinderVars.finder_filter_title_videos);

            // Step 5: Click on Category
            utils.Swipe_To_Right(FinderVars.filters_banner, FinderVars.finder_filt_content_category);
            madrid.Tap(FinderVars.finder_filt_content_category);
            utils.Sleep(5);

            Assert.True(utils.existsElement(FinderVars.filter_category_regate), "'Regate' category doesn't exist");
            Assert.True(utils.existsElement(FinderVars.filter_category_penalti), "'Penalti' category doesn't exist");

            // Step 6: Click on a @category
            madrid.Tap(FinderVars.filter_category_regate);
            madrid.Tap(FinderVars.finder_filt_content_category);
            utils.Sleep(5);

            AppResult[] result_filter_season_videos1 = madrid.Query(FinderVars.video_title);

            // Step 7: Unselect the previous player
			madrid.Tap(FinderVars.finder_filt_content_category);
			madrid.Tap(FinderVars.filter_category_regate);
            //utils.Swipe_To_Right(FinderVars.filters_submenu_options, FinderVars.search_input_icon);
            //madrid.Tap(FinderVars.search_input_icon);

            // Step 8: Click on other @category
            //madrid.Tap(FinderVars.finder_filt_content_category);
            madrid.Tap(FinderVars.filter_category_penalti);
            madrid.Tap(FinderVars.finder_filt_content_category);
            utils.Sleep(7);

            AppResult[] result_filter_season_videos2 = madrid.Query(FinderVars.video_title);
            Assert.AreNotEqual(result_filter_season_videos1[0].Text, result_filter_season_videos2[0].Text, "Players videos are similar");
        }

        [Test]
        //Search and apply all filters
        public void Text_35806()
        {
            //Step 2: Go to Finder
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.filters_bars);

            //Step 3: Click on Content Type Videos Filter
            madrid.Tap(FinderVars.finder_filt_content_type);
            madrid.WaitForElement(FinderVars.filters_submenu_options);

            Assert.True(utils.existsElement(FinderVars.finder_filter_title_videos), "Videos option doesn't exist");
            Assert.True(utils.existsElement(FinderVars.finder_filter_title_matches), "Matches option doesn't exist");

            //Step 4: Select the videos option
            madrid.Tap(FinderVars.finder_filter_title_videos);

            //Step 5: Fill the text box "¿Que quieres ver?" with "Gol" 
            madrid.EnterText(FinderVars.search_input_bar, "Gol");
            utils.Sleep(5);

            AppResult[] result_search = madrid.Query(FinderVars.search_team_name);
            Assert.True(result_search[0].Text.Contains("Gol"), "The word 'Gol' doesn't appear");

            //madrid.Back();
            madrid.PressEnter();
            //madrid.DismissKeyboard();

            //Step 6: Click on Competition filter
            madrid.Tap(FinderVars.finder_filt_content_competition);
            if (!utils.existsElement(FinderVars.finder_filter_title_sup_cop_esp))
                madrid.Tap(FinderVars.finder_filt_content_competition);
            utils.Sleep(3);

            Assert.True(utils.existsElement(FinderVars.finder_filter_title_sup_cop_esp), "'Supercopa de España' doesn't exist");
            Assert.True(utils.existsElement(FinderVars.finder_filter_title_sup_cop_eur), "'Supercopa de Europa' doesn't exist");
            utils.Swipe_To_Right(FinderVars.filters_submenu_options, FinderVars.finder_filter_title_cop_rey);
            Assert.True(utils.existsElement(FinderVars.finder_filter_title_cop_rey), "'Copa del rey' doesn't exist");
            utils.Swipe_To_Right(FinderVars.filters_submenu_options, FinderVars.finder_filter_title_the_league);
            Assert.True(utils.existsElement(FinderVars.finder_filter_title_the_league), "'La liga' doesn't exist");
            utils.Swipe_To_Right(FinderVars.filters_submenu_options, FinderVars.finder_filter_title_champions);
            Assert.True(utils.existsElement(FinderVars.finder_filter_title_champions), "'Champions' doesn't exist");

            //Step 7: Click on a @competition
            madrid.Tap(FinderVars.finder_filter_title_champions);
            utils.Sleep(5);

            //Step 8: Click on a Season filter
            utils.Swipe_To_Right(FinderVars.filters_submenu_options, FinderVars.finder_filt_content_seasson);
            madrid.Tap(FinderVars.finder_filt_content_seasson);
            utils.Sleep(3);

            Assert.True(utils.existsElement(FinderVars.filter_seasson_1415), "Season 2014-2015 doesn't exist");
            Assert.True(utils.existsElement(FinderVars.filter_seasson_1516), "Season 2015-2016 doesn't exist");
            Assert.True(utils.existsElement(FinderVars.filter_seasson_1617), "Season 2016-2017 doesn't exist");

            //Step 9: Click on a season
            madrid.Tap(FinderVars.filter_seasson_1516);

            //Step 10: Click on a Player filter
            utils.Swipe_To_Right(FinderVars.filters_submenu_options, FinderVars.finder_filt_content_players);
            madrid.Tap(FinderVars.finder_filt_content_players);

            //Step 11: Click on a player
            utils.Swipe_To_Right(FinderVars.filters_submenu, FinderVars.filter_player_benzema);
            madrid.Tap(FinderVars.filter_player_benzema);
            madrid.Tap(FinderVars.finder_filt_content_players);

            //Step 12: Click on a category filter
            utils.Swipe_To_Right(FinderVars.filters_submenu_options, FinderVars.finder_filt_content_category);
            madrid.Tap(FinderVars.finder_filt_content_category);

            //Step 13: Click on a category
            utils.Swipe_To_Right(FinderVars.filters_submenu, FinderVars.filter_category_gol);
            madrid.Tap(FinderVars.filter_category_gol);
            madrid.Tap(FinderVars.finder_filt_content_category);

            AppResult[] result_video_filter = madrid.Query(FinderVars.video_title);
            Assert.True(result_video_filter[0].Text.Contains("QA Test Fútbol Gol Comp: Champions, Season: 2015/16, Player: Benzema, Category: Pie Izquierdo")
                , "The video doesn't found");

        }

        /*
        [Test]
        //Apply competition filter
        public void Test_36007() {

            //Step 3: Click on Content Type video filter
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.filters_bars);
            madrid.Tap(FinderVars.finder_filt_content_type);
            madrid.WaitForElement(FinderVars.filters_submenu_options);

            Assert.True(utils.existsElement(FinderVars.finder_filter_title_videos), "Videos option doesn't exist");
            Assert.True(utils.existsElement(FinderVars.finder_filter_title_matches), "Matches option doesn't exist");

            //Step 4: Select the videos option
            madrid.Tap(FinderVars.finder_filter_title_videos);
            utils.Sleep(3);

            //Step 5: Click on Competition filter
            madrid.Tap(FinderVars.finder_filt_content_competition);
            utils.Sleep(3);

            Assert.True(utils.existsElement(FinderVars.finder_filter_title_sup_cop_esp), "'Supercopa de España' doesn't exist");
            Assert.True(utils.existsElement(FinderVars.finder_filter_title_sup_cop_eur), "'Supercopa de Europa' doesn't exist");
            utils.Swipe_To_Right(FinderVars.filters_submenu_options, FinderVars.finder_filter_title_cop_rey);
            Assert.True(utils.existsElement(FinderVars.finder_filter_title_cop_rey), "'Copa del rey' doesn't exist");
            utils.Swipe_To_Right(FinderVars.filters_submenu_options, FinderVars.finder_filter_title_the_league);
            Assert.True(utils.existsElement(FinderVars.finder_filter_title_the_league), "'La liga' doesn't exist");
            utils.Swipe_To_Right(FinderVars.filters_submenu_options, FinderVars.finder_filter_title_champions);
            Assert.True(utils.existsElement(FinderVars.finder_filter_title_champions), "'Champions' doesn't exist");

            //Step 6: Click on a competition
            madrid.Tap(FinderVars.finder_filter_title_the_league);

            //Step 7: unselect the previous competition
            madrid.Tap(FinderVars.finder_filt_content_competition);
            madrid.Tap(FinderVars.finder_filter_title_the_league);
            utils.Sleep(3);

            AppResult[] result_league = madrid.Query(FinderVars.video_title);

            //Step 8: Click on other competition
            madrid.Tap(FinderVars.finder_filt_content_competition);
            utils.Sleep(3);
            while (!utils.existsElement(FinderVars.finder_filter_title_cop_rey))
                madrid.SwipeLeftToRight(FinderVars.filters_submenu, 0.8, 1000, true);
            madrid.Tap(FinderVars.finder_filter_title_cop_rey);
            utils.Sleep(3);

            AppResult[] result_cop_rey = madrid.Query(FinderVars.video_title);
            Assert.AreNotEqual(result_league[0].Text, result_cop_rey[0].Text, "The videos are the same");

        }
        */

        /*
        [Test]
        //Apply season filter
        public void Test_36008()
        {
            //Step 2: Go to Finder
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.filters_bars);

            //Step 3: Click on Content Type Videos Filter
            madrid.Tap(FinderVars.finder_filt_content_type);
            madrid.WaitForElement(FinderVars.filters_submenu_options);

            Assert.True(utils.existsElement(FinderVars.finder_filter_title_videos), "Videos option doesn't exist");
            Assert.True(utils.existsElement(FinderVars.finder_filter_title_matches), "Matches option doesn't exist");

            //Step 4: Select the videos option
            madrid.Tap(FinderVars.finder_filter_title_videos);
            utils.Sleep(3);

            //Step 5: Click on season filter
            utils.Swipe_To_Right(FinderVars.filters_submenu_options, FinderVars.finder_filt_content_seasson);
            madrid.Tap(FinderVars.finder_filt_content_seasson);
            utils.Sleep(3);

            //Step 6: Click on a season
            madrid.Tap(FinderVars.filter_seasson_1415);
            utils.Sleep(3);

            AppResult[] result_1415 = madrid.Query(FinderVars.video_title);

            //Step 7: Unselect the previous season
            madrid.Tap(FinderVars.finder_filt_content_seasson);
            utils.Sleep(3);
            madrid.Tap(FinderVars.filter_seasson_1516);
            utils.Sleep(3);

            AppResult[] result_1516 = madrid.Query(FinderVars.video_title);
            Assert.AreNotEqual(result_1415[0].Text, result_1516[0].Text, "The videos of the different seasson are the same");

        }
        */

        /*
         [Test]
         //Apply player filter
         public void Test_36009()
        {
            //Step 2: Go to Finder
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.filters_bars);

            //Step 3: Click on Content Type video filter
            madrid.Tap(FinderVars.finder_filt_content_type);
            madrid.WaitForElement(FinderVars.filters_submenu_options);

            Assert.True(utils.existsElement(FinderVars.finder_filter_title_videos), "Videos option doesn't exist");
            Assert.True(utils.existsElement(FinderVars.finder_filter_title_matches), "Matches option doesn't exist");

            //Step 4: Select the videos option
            madrid.Tap(FinderVars.finder_filter_title_videos);
            utils.Sleep(3);

            //Step 5: Click on Player filter
            utils.Swipe_To_Right(FinderVars.filters_submenu_options, FinderVars.finder_filt_content_players);
            madrid.Tap(FinderVars.finder_filt_content_players);
            utils.Sleep(3);

            //Step 6: Click on a player
            madrid.Tap(FinderVars.filter_player_keylor);
            madrid.Tap(FinderVars.finder_filt_content_players);
            utils.Sleep(3);

            AppResult[] result_keylor = madrid.Query(FinderVars.video_title);

            //Step 7: unselect the previous players
            madrid.Tap(FinderVars.finder_filt_content_players);
            madrid.Tap(FinderVars.filter_player_keylor);
            madrid.Tap(FinderVars.finder_filt_content_players);
            utils.Sleep(3);

            //Step 8: Click on other player
            madrid.Tap(FinderVars.finder_filt_content_players);
            madrid.Tap(FinderVars.filter_player_raphael);
            madrid.Tap(FinderVars.finder_filt_content_players);
            utils.Sleep(3);

            AppResult[] result_raphael = madrid.Query(FinderVars.video_title);
            Assert.AreEqual(result_keylor[0].Text, result_raphael[0].Text, "The videos aren't the same");
        }
        */

        /*
        [Test]
        //Apply categories filter
        public void Test_36010()
        {
            //Step 2: Go to Finder
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.filters_bars);

            //Step 3: Click on Content Type video filter
            madrid.Tap(FinderVars.finder_filt_content_type);
            madrid.WaitForElement(FinderVars.filters_submenu_options);

            Assert.True(utils.existsElement(FinderVars.finder_filter_title_videos), "Videos option doesn't exist");
            Assert.True(utils.existsElement(FinderVars.finder_filter_title_matches), "Matches option doesn't exist");

            //Step 4: Select the videos option
            madrid.Tap(FinderVars.finder_filter_title_videos);
            utils.Sleep(3);

            //Step 5: Click on category filter
            utils.Swipe_To_Right(FinderVars.filters_submenu_options, FinderVars.finder_filt_content_category);
            madrid.Tap(FinderVars.finder_filt_content_category);
            utils.Sleep(3);

            //Step 6: Click on a category
            madrid.Tap(FinderVars.filter_category_regate);
            madrid.Tap(FinderVars.finder_filt_content_category);
            utils.Sleep(3);

            AppResult[] result_regate = madrid.Query(FinderVars.video_title);

            //Step 7: unselect previous category
            madrid.Tap(FinderVars.finder_filt_content_category);
            madrid.Tap(FinderVars.filter_category_regate);
            madrid.Tap(FinderVars.finder_filt_content_category);
            utils.Sleep(3);

            //Step 8: Click on other category
            madrid.Tap(FinderVars.finder_filt_content_category);
            madrid.Tap(FinderVars.filter_category_penalti);
            madrid.Tap(FinderVars.finder_filt_content_category);
            utils.Sleep(3);

            AppResult[] result_penalti = madrid.Query(FinderVars.video_title);
            Assert.AreEqual(result_regate[0].Text, result_penalti[0].Text, "The videos aren't the same");

        }
        */

        [Test]
        //Search by operators
        public void Test_36213()
        {
            //Step 2: Go to Finder
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.filters_bars);

            //Step 3: Fill the text box "¿Qué quieres ver?" with the @operator
            //madrid.Repl();
            madrid.EnterText(FinderVars.search_input_bar, "GOL Cristiano Ronaldo 1-2 (minuto 88) - multi idioma (si) ubicacion (GB)");
            utils.Sleep(3);
			madrid.PressEnter();

            AppResult[] result_search = madrid.Query(FinderVars.search_team_name);
            Assert.True(result_search.Length > 0, "There isn't results");
        }

    }
}