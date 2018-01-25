using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealMadrid_UITest.Tests
{
    class RecycleBin
    {
        /*

                [Test]
        //Search and apply any filter
        public void Test_35873() {
            //Step 2: Change the sport to basketball
            utils.Change_Sport();

            //Step 3: Go to Finder
            //FINDER doesn't exist in Basketball
            //Steps 4, 5, 6, 7, 8, 9 and 10 can't be made 
            try {
                utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            }
            catch (Exception exception) {
                Console.WriteLine("Error al buscar Finder");
				Console.Write("Exception: " + exception);
            } finally {
                madrid.SwipeRightToLeft();
                utils.Change_Sport();
            }
        }


        
		[Test]
		public void Test_35874(){
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

			// Step 6, 7, 8, 9, 10, 11, 12, 13 and 14: No existe Finder, identificadores desconocidos por ahora.

			// Va a fallar, pues en la parte de baloncesto no existe Finder aún
		}


        		[Test]
		public void Test_35973() {
			// Step 2: Go to Finder
			utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
			madrid.WaitForElement(FinderVars.main_title);

			// Sería el mismo test que el anterior (35972), pero en la parte de baloncesto, y ahí el Finder aún
			// no está disponible para automatizarlo.

			// No se puede automatizar por el momento
		}


        	[Test]
		public void Test_35975() {
			// Idéntico al anterior, pero con un video, aun que los pasos en test manager son idénticos. Espeficicar.
			// Además, en test manager se indica que se hará con un video, no con un partido.

			
			// Step 2: Go to Finder
			utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
			madrid.WaitForElement(FinderVars.main_title);

			// Auxiliar: Select a match as favourite
			utils.Go_To(FinderVars.finder_content, FinderVars.finder_like_button);
			madrid.WaitForElement(FinderVars.finder_like_button);
			madrid.Tap(FinderVars.finder_like_button);
			madrid.Back();

			// Step 3: Search a match mark as a favourite
			madrid.Tap(a => a.Id("img").Index(4));
			utils.Go_To(FinderVars.finder_content, ProfileVars.profile_favourites_but);
			madrid.WaitForElement(ProfileVars.profile_favourites_but);
			madrid.Tap(ProfileVars.profile_favourites_but);
			madrid.WaitForElement(ProfileVars.profile_favourites_matches);
			madrid.Tap(ProfileVars.profile_favourites_matches);
			madrid.WaitForElement(ProfileVars.profile_fav_matches_content);

			// Step 4: Click on the "favourite" button
			madrid.Tap(FinderVars.finder_like_button);

			// Step 5: Go to profile
			madrid.Back();

			// Step 6: Scroll down to status placeholder
			// Ya deberíamos estar en la página "profile", en el "status placeholder"

			// Step 7: Click on the favourites button
			madrid.Tap(ProfileVars.profile_favourites_but);
			madrid.WaitForElement(ProfileVars.profile_favourites_matches);

			// Step 8: Check the match does not appear in the favourite page
			madrid.Tap(ProfileVars.profile_favourites_matches);
			madrid.WaitForElement(ProfileVars.profile_fav_matches_content);

			Assert.True(!utils.existsElement(FinderVars.finder_last_matches_view));
			
    }


        
        [Test]
		public void Test_36951() {
			// Step 2: Change sport basketball
			utils.Change_Sport();

			// Step 3, 4 and 5: No existe Finder, identificadores desconocidos por ahora.

			// Va a fallar, pues en la parte de baloncesto no existe Finder aún
			Assert.Fail();
		}


        		[Test]
		public void Test_35643() {
			// Por ahora no es factible implementarlo
		}



        		[Test]
		public void Test_34439() {
			madrid.Repl();
			// Step 2: Go to Games


			// Step 3: Click each game


			// Step 4: Go back to games list


			// Por ahora no puede hacerse, identificadores desconocidos.
			// No aparece una sección de Juegos como tal en la apk Android Real Madrid App QA
		}



                [Test]
        public void Test_34378()
        {
            // Step 2:Go to Account placeholder.
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
            // Step 3:Tap in "Edit profile" link next to user profile picture
            utils.Sleep(3);
            madrid.Tap(ProfileVars.profile_edit_but);
            Assert.True(utils.existsElement(ProfileVars.profile_Container), "No se muestra la pagina de edicion de perfil");
            // Step 4:Swipe to MORE INFO tab
            madrid.Tap(ProfileVars.moreInfo_but);
            // Step 5:Fill inputs
            fill_moreInfo(ProfileVars.moreinfo_zip, Strings.PROFILE_ZIP_MADRID);
            int count = 0;
            while (!utils.existsElement(ProfileVars.moreinfo_state_spinner) && !utils.existsElement(ProfileVars.moreinfo_city) && count < 5)
            {
                madrid.ScrollDown(ProfileVars.more_info_view, ScrollStrategy.Gesture, 0.50, 2000, true);
                count++;
            }
            if (count == 5)
            {
                Assert.True(false, "No se encuentra el campo de ciudad");
            }
            if (utils.existsElement(ProfileVars.moreinfo_state_spinner))
            {
                selec_State(ProfileVars.moreinfo_state_zamora);
            }
            else if (utils.existsElement(ProfileVars.moreinfo_city))
            {
                fill_moreInfo(ProfileVars.moreinfo_city, Strings.PROFILE_CITY_ZAMORA);
            }
            go_to_moreinfo(ProfileVars.moreinfo_save);   
            madrid.Tap(ProfileVars.moreinfo_save);
            utils.Sleep(2);
            Assert.True(utils.existsElement(ProfileVars.codigo_postal_incrrecto_msg), "No se muestra el mensaje de datos incorrectos");   
        }



















    */
    }
}
