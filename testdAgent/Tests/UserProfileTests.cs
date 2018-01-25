using NUnit.Framework;
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

    public class UserProfileTests {
        IApp madrid;
        Utilities utils;
        Platform platform;



        public UserProfileTests(Platform platform)
        {
            this.platform = platform;
        }



        [TestFixtureSetUp]
        public void BeforeAllTest()
        {

        }



        [SetUp]
        public void BeforeEachTest()
        {
            madrid = AppInitializer.StartApp(platform);
            utils = new Utilities(madrid);
            utils.Login();
            //utils.Login_data(Strings.LOGIN_USERNAME_NOTLINKED, Strings.LOGIN_PASSWORD_NOTLINKED);
        }


        [TearDown]
        public void AfterEachTest()
        {
            //            utils.Enter_Home();
            //            utils.Sign_Off();
        }

		private void Go_To_Slow(Func<AppQuery, AppQuery> view, Func<AppQuery, AppQuery> element)
		{
			while (madrid.Query(element).Length == 0)
			{
				madrid.ScrollDown(view, ScrollStrategy.Gesture, 0.30, 500, true);
			}
		}
		/*
        [Test]
        public void Test_34353()
        {
            // Step 2:Go to Account placeholder.
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
            // Step 3:Tap in "Edit profile" link next to user profile picture
            utils.Sleep(3);
            madrid.Tap(ProfileVars.profile_edit_but);
            Assert.True(utils.existsElement(ProfileVars.profile_Container), "No se muestra la pagina de edicion de perfil");
            // Step 4:Swipe to Preferences tab
            madrid.Tap(ProfileVars.preferences_but);
            utils.Sleep(3);
            Assert.True(utils.existsElement(ProfileVars.prefs_football_but), "No se muestra el boton de football");
            Assert.True(utils.existsElement(ProfileVars.prefs_basket_but), "No se muestra el boton de basket");
            Assert.True(utils.existsElement(ProfileVars.prefs_football_share_but), "No se muestra el boton de compratir football");
            Assert.True(utils.existsElement(ProfileVars.prefs_basket_share_but), "No se muestra el boton de compratir basket");
            // Step 5:Tap in Football button
            bool lista = utils.existsElement(ProfileVars.prefs_football_tus_preferidos);
            madrid.Tap(ProfileVars.prefs_football_but);
            utils.Sleep(3);

            Assert.True(utils.existsElement(ProfileVars.prefs_done_football_but), "No existe el boton OK en jugadores preferidos");
            Assert.True(utils.existsElement(ProfileVars.prefs_skip_football_but), "No existe el boton ATRAS en jugadores preferidos");
            Assert.True(utils.existsElement(ProfileVars.prefs_football_forwards_but), "No existe la lista de delanteros");
            Assert.True(utils.existsElement(ProfileVars.prefs_football_mid_offensive_but), "No existe la lista de meios ofensivos");
            Assert.True(utils.existsElement(ProfileVars.prefs_football_mid_defensive_but), "No existe la lista de medios defensivos");
            Assert.True(utils.existsElement(ProfileVars.prefs_football_defenses_but), "No existe la lista de defensas");
            Assert.True(utils.existsElement(ProfileVars.prefs_football_goalkeepers_but), "No existe la lista de porteros");
            // Step 6:Select 5 different pictures and tap in DONE button

            if (lista)
            {
                madrid.Tap(ProfileVars.prefs_player_1);
                madrid.Tap(ProfileVars.prefs_player_2);
                madrid.Tap(ProfileVars.prefs_player_3);
                madrid.Tap(ProfileVars.prefs_player_4);
                madrid.Tap(ProfileVars.prefs_player_5);
                madrid.Tap(ProfileVars.prefs_player_6);
                madrid.Tap(ProfileVars.prefs_player_7);
                madrid.Tap(ProfileVars.prefs_player_8);
                madrid.Tap(ProfileVars.prefs_player_9);
                madrid.Tap(ProfileVars.prefs_player_11);
                madrid.Tap(ProfileVars.prefs_player_1);
                madrid.Tap(ProfileVars.prefs_player_2);
                madrid.Tap(ProfileVars.prefs_player_3);
                madrid.Tap(ProfileVars.prefs_player_4);
                madrid.Tap(ProfileVars.prefs_player_5);
            } else
            {
                madrid.Tap(ProfileVars.prefs_player_1);
                madrid.Tap(ProfileVars.prefs_player_2);
                madrid.Tap(ProfileVars.prefs_player_3);
                madrid.Tap(ProfileVars.prefs_player_4);
                madrid.Tap(ProfileVars.prefs_player_5);
            }
            madrid.Tap(ProfileVars.prefs_done_football_but);
            madrid.Tap(ProfileVars.ok_but);

            Assert.True(utils.existsElement(ProfileVars.prefs_football_tus_preferidos), "No existe la lista de preferidos");
        }
		*/
		/*
        [Test]
        public void Test_34356()
        {
            // Step 2:Go to Account placeholder.
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
            // Step 3:Tap in "Edit profile" link next to user profile picture
            utils.Sleep(3);
            madrid.Tap(ProfileVars.profile_edit_but);
            Assert.True(utils.existsElement(ProfileVars.profile_Container), "No se muestra la pagina de edicion de perfil");
            // Step 4:Swipe to Preferences tab
            madrid.Tap(ProfileVars.preferences_but);
            utils.Sleep(3);
            Assert.True(utils.existsElement(ProfileVars.prefs_football_but), "No se muestra el boton de football");
            Assert.True(utils.existsElement(ProfileVars.prefs_basket_but), "No se muestra el boton de basket");
            Assert.True(utils.existsElement(ProfileVars.prefs_football_share_but), "No se muestra el boton de compratir football");
            Assert.True(utils.existsElement(ProfileVars.prefs_basket_share_but), "No se muestra el boton de compratir basket");
            // Step 5:Tap in Basket button
            bool lista = utils.existsElement(ProfileVars.prefs_basket_tus_preferidos);
            madrid.Tap(ProfileVars.prefs_basket_but);
            utils.Sleep(3);

            Assert.True(utils.existsElement(ProfileVars.prefs_done_basket_but), "No existe el boton OK en jugadores preferidos");
            Assert.True(utils.existsElement(ProfileVars.prefs_skip_basket_but), "No existe el boton ATRAS en jugadores preferidos");
            Assert.True(utils.existsElement(ProfileVars.prefs_basket_fourth), "No existe la lista de basket fourth");
            Assert.True(utils.existsElement(ProfileVars.prefs_basket_third), "No existe la lista de basket third");
            Assert.True(utils.existsElement(ProfileVars.prefs_basket_second), "No existe la lista de basket second");
            Assert.True(utils.existsElement(ProfileVars.prefs_basket_first), "No existe la lista de basket first");

            // Step 6:Select 5 different pictures and tap in DONE button
            if (lista)
            {
                madrid.Tap(ProfileVars.prefs_player_6);
                madrid.Tap(ProfileVars.prefs_player_8);
                madrid.Tap(ProfileVars.prefs_player_9);
                madrid.Tap(ProfileVars.prefs_player_13);

                madrid.Tap(ProfileVars.prefs_player_14);
                madrid.Tap(ProfileVars.prefs_player_20);
                madrid.Tap(ProfileVars.prefs_player_23);
                madrid.Tap(ProfileVars.prefs_player_50);

                madrid.Tap(ProfileVars.prefs_player_6);
                madrid.Tap(ProfileVars.prefs_player_8);
                madrid.Tap(ProfileVars.prefs_player_9);
                madrid.Tap(ProfileVars.prefs_player_13);
            }
            else
            {
                madrid.Tap(ProfileVars.prefs_player_5);
                madrid.Tap(ProfileVars.prefs_player_6);
                madrid.Tap(ProfileVars.prefs_player_8);
                madrid.Tap(ProfileVars.prefs_player_9);
                madrid.Tap(ProfileVars.prefs_player_13);
            }
            madrid.Tap(ProfileVars.prefs_done_basket_but);
            madrid.Tap(ProfileVars.ok_but);

            Assert.True(utils.existsElement(ProfileVars.prefs_basket_tus_preferidos), "No existe la lista de preferidos");
        }
        */
		/*
        [Test]
        public void Test_34359()
        {
            // Step 2:Go to Account placeholder.
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
            // Step 3:Tap in "Edit profile" link next to user profile picture
            utils.Sleep(3);
            madrid.Tap(ProfileVars.profile_edit_but);
            Assert.True(utils.existsElement(ProfileVars.profile_Container), "No se muestra la pagina de edicion de perfil");
            // Step 4:Swipe to Preferences tab
            madrid.Tap(ProfileVars.preferences_but);
            utils.Sleep(3);
            Assert.True(utils.existsElement(ProfileVars.prefs_football_but), "No se muestra el boton de football");
            Assert.True(utils.existsElement(ProfileVars.prefs_basket_but), "No se muestra el boton de basket");
            Assert.True(utils.existsElement(ProfileVars.prefs_football_share_but), "No se muestra el boton de compratir football");
            Assert.True(utils.existsElement(ProfileVars.prefs_basket_share_but), "No se muestra el boton de compratir basket");
            // Step 5:Tap in Basket button
            bool lista = utils.existsElement(ProfileVars.prefs_basket_tus_preferidos);
            madrid.Tap(ProfileVars.prefs_basket_but);
            utils.Sleep(3);

            Assert.True(utils.existsElement(ProfileVars.prefs_done_basket_but), "No existe el boton OK en jugadores preferidos");
            Assert.True(utils.existsElement(ProfileVars.prefs_skip_basket_but), "No existe el boton ATRAS en jugadores preferidos");
            Assert.True(utils.existsElement(ProfileVars.prefs_basket_fourth), "No existe la lista de basket fourth");
            Assert.True(utils.existsElement(ProfileVars.prefs_basket_third), "No existe la lista de basket third");
            Assert.True(utils.existsElement(ProfileVars.prefs_basket_second), "No existe la lista de basket second");
            Assert.True(utils.existsElement(ProfileVars.prefs_basket_first), "No existe la lista de basket first");

            // Step 6:Make a different selection and tap in BACK button
            if (!lista)
            {
                madrid.Tap(ProfileVars.prefs_player_5);
                madrid.Tap(ProfileVars.prefs_player_6);
                madrid.Tap(ProfileVars.prefs_player_8);
                madrid.Tap(ProfileVars.prefs_player_9);
                madrid.Tap(ProfileVars.prefs_player_13);
            }
            madrid.Tap(ProfileVars.prefs_player_6);
            madrid.Tap(ProfileVars.prefs_player_8);
            madrid.Tap(ProfileVars.prefs_player_9);
            madrid.Tap(ProfileVars.prefs_player_13);

            madrid.Tap(ProfileVars.prefs_player_14);
            madrid.Tap(ProfileVars.prefs_player_20);
            madrid.Tap(ProfileVars.prefs_player_23);
            madrid.Tap(ProfileVars.prefs_player_50);

            madrid.Tap(ProfileVars.prefs_player_6);
            madrid.Tap(ProfileVars.prefs_player_8);
            madrid.Tap(ProfileVars.prefs_player_9);
            madrid.Tap(ProfileVars.prefs_player_13);

            madrid.Tap(ProfileVars.prefs_skip_basket_but);
            Assert.False(utils.existsElement(ProfileVars.jugadores_actualizados_msg), "Se han actualizado los jugadores");
        }
		
        private void go_to_moreinfo(Func<AppQuery, AppQuery> lambda)
        {
            utils.Go_To(lambda, ProfileVars.more_info_view, 5, "No se encuentra la opcion en el more info");
        }
		
        private void fill_moreInfo(Func<AppQuery, AppQuery> lambda, string data)
        {
            go_to_moreinfo(lambda);
            madrid.ClearText(lambda);
            madrid.EnterText(lambda, data);
            madrid.DismissKeyboard();
        }

        private void selec_State_in_spinner(Func<AppQuery, AppQuery> lambda)
        {
            go_to_moreinfo(ProfileVars.moreinfo_state_spinner);
            madrid.Tap(ProfileVars.moreinfo_state_spinner);
            int max = 0;
            while (!utils.existsElement(lambda) && max < 10)
            {
                madrid.ScrollDown(ProfileVars.moreinfo_state_view, ScrollStrategy.Gesture, 0.80, 2000, true);
                max++;
            }
            if (max == 5)
            {
                Assert.True(false, "No se encuentra la ciudad en el desplegable");
            }
            madrid.Tap(lambda);
        }

        private void fill_state_zamora()
        {
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
                selec_State_in_spinner(ProfileVars.moreinfo_state_zamora);
            }
            else if (utils.existsElement(ProfileVars.moreinfo_city))
            {
                fill_moreInfo(ProfileVars.moreinfo_city, Strings.PROFILE_CITY_ZAMORA);
            }

        }
		*/



		/*
        [Test]
        public void Test_34361()
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
            fill_moreInfo(ProfileVars.moreinfo_name, Strings.PROFILE_RANDOM);
            fill_moreInfo(ProfileVars.moreinfo_surname, Strings.PROFILE_RANDOM);
            fill_moreInfo(ProfileVars.moreinfo_secondname, Strings.PROFILE_RANDOM);
            fill_moreInfo(ProfileVars.moreinfo_doc_number, Strings.PROFILE_RANDOM);
            fill_moreInfo(ProfileVars.moreinfo_mobile_number, Strings.PROFILE_RANDOM);
            fill_moreInfo(ProfileVars.moreinfo_home_number, Strings.PROFILE_RANDOM);
            fill_moreInfo(ProfileVars.moreinfo_address, Strings.PROFILE_RANDOM);
            fill_moreInfo(ProfileVars.moreinfo_zip, Strings.PROFILE_ZIP_ZAMORA);
            fill_moreInfo(ProfileVars.moreinfo_city, Strings.PROFILE_RANDOM);
            fill_state_zamora();
            //selec_State_in_spinner(ProfileVars.moreinfo_state_zamora);


            go_to_moreinfo(ProfileVars.moreinfo_sendtostore);
            madrid.Tap(ProfileVars.moreinfo_sendtostore);
            go_to_moreinfo(ProfileVars.moreinfo_nocommunicationstorm);
            madrid.Tap(ProfileVars.moreinfo_nocommunicationstorm);
            go_to_moreinfo(ProfileVars.moreinfo_noinfotothirds);
            madrid.Tap(ProfileVars.moreinfo_noinfotothirds);

            go_to_moreinfo(ProfileVars.moreinfo_save);
            madrid.Tap(ProfileVars.moreinfo_save);
            utils.Sleep(3);
            Assert.True(utils.existsElement(ProfileVars.datos_actualizados_msg), "No se muestra el mensaje de datos actualizados");
            Assert.True(utils.existsElement(ProfileVars.datos_actualizados_OK_but), "No se muestra el boton OK de datos actualizados");
            madrid.Tap(ProfileVars.datos_actualizados_OK_but);
            madrid.Back();

            madrid.Tap(ProfileVars.profile_edit_but);
            madrid.Tap(ProfileVars.moreInfo_but);
            go_to_moreinfo(ProfileVars.moreinfo_doc_type_spinner);
            madrid.Tap(ProfileVars.moreinfo_doc_type_spinner);
            madrid.Tap(ProfileVars.moreinfo_doc_type_Nif);
            go_to_moreinfo(ProfileVars.moreinfo_gender_spinner);
            madrid.Tap(ProfileVars.moreinfo_gender_spinner);
            madrid.Tap(ProfileVars.moreinfo_gender_Male);
            go_to_moreinfo(ProfileVars.moreinfo_country);
            madrid.Tap(ProfileVars.moreinfo_country);
            madrid.ScrollUp(ProfileVars.moreinfo_country_view, ScrollStrategy.Gesture, 0.50, 2000, true);
            madrid.Tap(ProfileVars.moreinfo_country_random);
            go_to_moreinfo(ProfileVars.moreinfo_persontitle_spinner);
            madrid.Tap(ProfileVars.moreinfo_persontitle_spinner);
            madrid.Tap(ProfileVars.moreinfo_persontitle_Sr);
            go_to_moreinfo(ProfileVars.moreinfo_sport_spinner);
            madrid.Tap(ProfileVars.moreinfo_sport_spinner);
            madrid.Tap(ProfileVars.moreinfo_sport_Futbol);

            go_to_moreinfo(ProfileVars.moreinfo_save);
            madrid.Tap(ProfileVars.moreinfo_save);
            utils.Sleep(3);
            Assert.True(utils.existsElement(ProfileVars.datos_actualizados_msg), "No se muestra el mensaje de datos actualizados");
            Assert.True(utils.existsElement(ProfileVars.datos_actualizados_OK_but), "No se muestra el boton OK de datos actualizados");
            madrid.Tap(ProfileVars.datos_actualizados_OK_but);
            madrid.Back();

            madrid.Tap(ProfileVars.profile_edit_but);
            madrid.Tap(ProfileVars.moreInfo_but);
            go_to_moreinfo(ProfileVars.moreinfo_doc_type_spinner);
            madrid.Tap(ProfileVars.moreinfo_doc_type_spinner);
            madrid.Tap(ProfileVars.moreinfo_doc_type_Passport);
            go_to_moreinfo(ProfileVars.moreinfo_gender_spinner);
            madrid.Tap(ProfileVars.moreinfo_gender_spinner);
            madrid.Tap(ProfileVars.moreinfo_gender_Female);
            go_to_moreinfo(ProfileVars.moreinfo_persontitle_spinner);
            madrid.Tap(ProfileVars.moreinfo_persontitle_spinner);
            madrid.Tap(ProfileVars.moreinfo_persontitle_Sra);
            go_to_moreinfo(ProfileVars.moreinfo_sport_spinner);
            madrid.Tap(ProfileVars.moreinfo_sport_spinner);
            madrid.Tap(ProfileVars.moreinfo_sport_Both);

            go_to_moreinfo(ProfileVars.moreinfo_save);
            madrid.Tap(ProfileVars.moreinfo_save);
            utils.Sleep(3);
            Assert.True(utils.existsElement(ProfileVars.datos_actualizados_msg), "No se muestra el mensaje de datos actualizados");
            Assert.True(utils.existsElement(ProfileVars.datos_actualizados_OK_but), "No se muestra el boton OK de datos actualizados");
            madrid.Tap(ProfileVars.datos_actualizados_OK_but);
        }

		*/


		[Test]
		public void Test_34382()
		{
			if (utils._device == "Tablet")
			{
				// Step 2:Go to Account placeholder.
				utils.Sleep(5);
				madrid.Tap(NavigationBarVars.navbar_Profile_but);
				// Step 3:Go to virtual goods
				//madrid.ScrollDownTo(ProfileVars.virtual_goods_but);
				madrid.Tap(ProfileVars.virtual_goods_but);
				// Step 3:Tap in Virtual Store button.
				madrid.WaitForElement(ProfileVars.virtual_store_but);
				madrid.Tap(ProfileVars.virtual_store_but);

				Assert.True(utils.existsElement(MainMenuVars.virtual_store_title), "No se muestra la pagina de Tienda Virtual dese la pagina de bienes virtuales");
				madrid.WaitForElement(ProfileVars.content_virtual_goods_title);
				Assert.True(utils.existsElement(ProfileVars.content_virtual_goods_title), "No se muestra la pestaña de bienes virtuales desde la pagina de tienda virtual");
			}
			else
			{ 
				// Step 2:Go to Account placeholder.
				utils.Sleep(5);
				madrid.Tap(NavigationBarVars.navbar_Profile_but);
				// Step 3:Go to virtual goods
				madrid.ScrollDownTo(ProfileVars.virtual_goods_but);
				madrid.Tap(ProfileVars.virtual_goods_but);
				// Step 3:Tap in Virtual Store button.
				madrid.WaitForElement(ProfileVars.virtual_store_but);
				madrid.Tap(ProfileVars.virtual_store_but);

				Assert.True(utils.existsElement(MainMenuVars.virtual_store_title), "No se muestra la pagina de Tienda Virtual dese la pagina de bienes virtuales");
				madrid.WaitForElement(ProfileVars.content_virtual_goods_title);
				Assert.True(utils.existsElement(ProfileVars.content_virtual_goods_title), "No se muestra la pestaña de bienes virtuales desde la pagina de tienda virtual");
			}
		}
		/*
        [Test]
        public void Test_34405()
        {
            // Step 2:Go to Account placeholder.
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
            // Step 3:Check information is accurate.
            utils.Sleep(3);
            Assert.True(utils.existsElement(ProfileVars.profile_account_avatar_but), "No se muestra el avatar en el account placeholder");
            Assert.True(utils.existsElement(ProfileVars.profile_account_name), "No se muestra el nombre en el account placeholder");
            //madrid.Repl();
            Assert.True(utils.existsElement(ProfileVars.link_social_but), "No se muestra el boton de links en el account placeholder");
            Assert.True(utils.existsElement(ProfileVars.link_madridista_but), "No se muestra el carne de socio en el account placeholder");
            madrid.Tap(ProfileVars.link_social_but);
            Assert.True(utils.existsElement(ProfileVars.link_facebook_but), "No se muestra el link de facebook en el account placeholder");
            Assert.True(utils.existsElement(ProfileVars.link_twitter_but), "No se muestra el link de twitter en el account placeholder");
            Assert.True(utils.existsElement(ProfileVars.link_google_but), "No se muestra el link de google en el account placeholder");
            Assert.True(utils.existsElement(ProfileVars.link_microsoft_but), "No se muestra el link de microsoft en el account placeholder");
        }
*/
        /*
		[Test]
        public void Test_34483()
        {
            // Step 2:Go to Account placeholder.
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
            // Step 3:Tap in "Edit profile" link next to user profile picture
            utils.Sleep(3);
            madrid.Tap(ProfileVars.profile_edit_but);
            Assert.True(utils.existsElement(ProfileVars.profile_Container), "No se muestra la pagina de edicion de perfil");
            // Step 2:Tap in LOGOUT button.
            madrid.ScrollDown(ProfileVars.profile_Container, ScrollStrategy.Gesture, 0.50, 2000, true);
            utils.Go_To(ProfileVars.profile_LogOut_but, ProfileVars.profile_Container, 5, "No se encuentra el boton de logOut");
            madrid.Tap(ProfileVars.profile_LogOut_but);
            madrid.Tap(ProfileVars.profile_Ok_but);
            utils.Sleep(10);
            Assert.True(utils.existsElement(LoginVars.login_User_Input));
        }
		*/
        private void GoToBadgesCategories(Func<AppQuery, AppQuery> lambda)
        {
            madrid.Tap(ProfileVars.badges_spinner);
            utils.Sleep(1);
            utils.Go_To(lambda, ProfileVars.badges_spinner_view, 5, "No se encuentra la opcion en el badges spinner");
            madrid.Tap(lambda);
            utils.Sleep(2);
        }


        [Test]
		// Badges goes nowhere
        public void Test_34395()
        {
            // Step 2:Go to Badges placeholder.
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
			madrid.ScrollDownTo(ProfileVars.badges_placeholder_title);

			// Step 3:Tap in a badge.
			madrid.ScrollDownTo(ProfileVars.badges_placeholder_random_badge);
            //utils.Go_To(ProfileVars.badges_placeholder_random_badge, ProfileVars.badge_scroll_view, 5, "No se encuentra la medalla de reto 100");
            Go_To_Slow(ProfileVars.badges_placeholder_random_badge, ProfileVars.badge_scroll_view);
			madrid.Tap(ProfileVars.badges_placeholder_random_badge);
            Assert.True(utils.existsElement(ProfileVars.badges_placeholder_random_badge), "No esta la medalla de reto 100 despues de pulsarla");

            // Step 4: -Tap in VIEW ALL button.
            utils.Go_To_Up(ProfileVars.badges_placeholder_view_all_but, ProfileVars.badge_scroll_view, 5, "No se encuentra el boton de ver todo");
            madrid.Tap(ProfileVars.badges_placeholder_view_all_but);

            // Step 5: Scroll down if needed and tap in a badge.
            Go_To_Slow(ProfileVars.badge_invite_title, ProfileVars.badge_scroll_view);
			madrid.WaitForElement(ProfileVars.badge_invite_title);
			Assert.True(utils.existsElement(ProfileVars.badge_invite_title), "No esta la medalla de invitar amigo");
            madrid.Tap(ProfileVars.badge_invite_title);
			madrid.WaitForElement(ProfileVars.badge_invite_title);
            Assert.True(utils.existsElement(ProfileVars.badge_invite_title), "No esta la medalla de invitar amigo despues de pulsarla");
        }

        [Test]
		// See badges by category
        public void Test_34396()
        {
			// Step 2:Go to Badges placeholder.
			utils.Sleep(4);
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
			madrid.ScrollDownTo(ProfileVars.badges_placeholder_view_all_but);

            // Step 3: Tap in VIEW ALL button.           
            madrid.Tap(ProfileVars.badges_placeholder_view_all_but);
            //El paso 4 y 5 van juntos en el paso 5
            // Step 4: Tap in the combobox.                       
            // Step 5:  Tap in all categories.
            GoToBadgesCategories(ProfileVars.badges_spinner_todos);
            Assert.True(utils.existsElement(ProfileVars.badges_section_challenges), "No esta la seccion de challenges al pulsar en TODOS");
            GoToBadgesCategories(ProfileVars.badges_spinner_challenges);
            Assert.True(utils.existsElement(ProfileVars.badges_section_challenges), "No esta la seccion de challenges al pulsar en CHALLENGES");
            GoToBadgesCategories(ProfileVars.badges_spinner_checkin);
            Assert.True(utils.existsElement(ProfileVars.badges_section_checkin), "No esta la seccion de challenges al pulsar en CHEKIN");
            GoToBadgesCategories(ProfileVars.badges_spinner_fan);
            Assert.True(utils.existsElement(ProfileVars.badges_section_fan), "No esta la seccion de challenges al pulsar en FAN");
            GoToBadgesCategories(ProfileVars.badges_spinner_social);
            Assert.True(utils.existsElement(ProfileVars.badges_section_social), "No esta la seccion de challenges al pulsar en SOCIAL");
        }


        [Test]
		// See Groups placeholder
        public void Test_34484()
        {
			// Step 2:Go to Groups placeholder.
			utils.Sleep(4);
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
			madrid.ScrollDownTo(ProfileVars.grupos_title);
            Assert.True(utils.existsElement(ProfileVars.groups_soon_text), "No esta la texto de PRONTO en la seccion de grupos");
        }

        [Test]
		// See Play With Us placeholder
        public void Test_34404()
        {
			// Step 2:Go to Go to Play With Us placeholder placeholder.
			utils.Sleep(4);
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
            //utils.Go_To(ProfileVars.shout_title, ProfileVars.personal_area_view, 10, "No se encuentra el plaeholder Juega con Nosotros");
			madrid.ScrollDownTo(ProfileVars.shout_title);
            // Step 3:Tap in Shout.
            madrid.Tap(ProfileVars.shout_title);
            //Assert.True(utils.existsElement(ProfileVars.shout_spinner), "No esta la ventana de carga de shout");
        }             

        [Test]
		// News Tab Favorites page
        public void Test_35720()
        {
			// Step 2:Go to profile
			utils.Sleep(5);
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
			// Step 3:Scroll down to status and click on "Mis me gusta" icon.
			madrid.ScrollDownTo(ProfileVars.me_gusta_but);
            madrid.Tap(ProfileVars.me_gusta_but);
            utils.Sleep(2);
            Assert.True(utils.existsElement(ProfileVars.my_like_page_title), "No se muestra el titulo de mis me gusta");
            Assert.True(utils.existsElement(ProfileVars.my_like_noticias_tab), "No se muestra la pestaña de noticias");
            Assert.True(utils.existsElement(ProfileVars.my_like_videos_tab), "No se muestra la pestaña de videos");
            Assert.True(utils.existsElement(ProfileVars.my_like_match_tab), "No se muestra la pestaña de partidos");
			Assert.True(utils.existsElement(ProfileVars.my_like_noticias_page), "No se muestra la ventana de noticias");
            Assert.True(utils.existsElement(ProfileVars.my_like_news_image), "No se muestra la imagen de la noticia");
            Assert.True(utils.existsElement(ProfileVars.my_like_news_title), "No se muestra el texto de la noticia");
            Assert.True(utils.existsElement(ProfileVars.my_like_news_time), "No se muestra la hora de la noticia");
            Assert.True(utils.existsElement(ProfileVars.my_like_news_like), "No se muestra el corazon de la noticia");
			madrid.SwipeRightToLeft();
			madrid.SwipeRightToLeft();
			madrid.SwipeRightToLeft();
			Assert.True(utils.existsElement(ProfileVars.my_like_subscripciones_tab), "No se muestra la pestaña de suscripciones");
            
        }

        [Test]
		// Videos Tab in Favorites page
        public void Test_35721()
        {
			// Step 2:Go to profile
			utils.Sleep(5);
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
			// Step 3:Scroll down to status and click on "Mis me gusta" icon.
			madrid.ScrollDownTo(ProfileVars.me_gusta_but);
            madrid.Tap(ProfileVars.me_gusta_but);
            // Step 4:Tap on "Videos" tab.
            madrid.Tap(ProfileVars.my_like_videos_tab);
            utils.Sleep(2);
            Assert.True(utils.existsElement(ProfileVars.my_like_videos_page), "No se muestra la ventana de videos");
            Assert.True(utils.existsElement(ProfileVars.my_like_videos_image), "No se muestra la imagen de los videos");
            Assert.True(utils.existsElement(ProfileVars.my_like_videos_play), "No se muestra el play de los videos");
            Assert.True(utils.existsElement(ProfileVars.my_like_videos_title), "No se muestra el texto del videos");
            Assert.True(utils.existsElement(ProfileVars.my_like_videos_time), "No se muestra la hora de los videos");
            Assert.True(utils.existsElement(ProfileVars.my_like_videos_like), "No se muestra el corazon de los videos");
        }

        [Test]
        public void Test_35722()
        {
			// Step 2:Go to profile
			utils.Sleep(5);
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
			// Step 3:Scroll down to status and click on "Mis me gusta" icon.
			madrid.ScrollDownTo(ProfileVars.me_gusta_but);
            madrid.Tap(ProfileVars.me_gusta_but);
			// Step 4:Tap on "Subscripciones" tab.
			madrid.SwipeRightToLeft();
			madrid.SwipeRightToLeft();
			madrid.SwipeRightToLeft();
            madrid.Tap(ProfileVars.my_like_subscripciones_tab);
            utils.Sleep(2);
            Assert.True(utils.existsElement(ProfileVars.my_like_subs_page), "No se muestra la ventana de subscripciones");
            Assert.True(utils.existsElement(ProfileVars.my_like_subs_image), "No se muestra la imagen de las subscripciones");
            Assert.True(utils.existsElement(ProfileVars.my_like_subs_videos), "No se muestra el numero de videos de las subscripciones");
            Assert.True(utils.existsElement(ProfileVars.my_like_subs_title), "No se muestra el texto de las subscripciones");
            Assert.True(utils.existsElement(ProfileVars.my_like_subs_time), "No se muestra la hora de las subscripciones");
            Assert.True(utils.existsElement(ProfileVars.my_like_subs_like), "No se muestra el corazon de las subscripciones");
        }

        [Test]
        public void Test_35724()
        {
			// Step 2:Go to profile
			utils.Sleep(5);
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
			// Step 3:Scroll down to status and click on "Mis me gusta" icon.
			madrid.ScrollDownTo(ProfileVars.me_gusta_but);
            madrid.Tap(ProfileVars.me_gusta_but);
            // Step 4:Tap on "Partidos" tab.
            madrid.Tap(ProfileVars.my_like_match_tab);
            utils.Sleep(2);
            Assert.True(utils.existsElement(ProfileVars.my_like_match_page), "No se muestra la ventana de partidos");
            Assert.True(utils.existsElement(ProfileVars.my_like_match_info), "No se muestra la info de partidos");
            Assert.True(utils.existsElement(ProfileVars.my_like_match_home_icon), "No se muestra el icono local de partidos");
            Assert.True(utils.existsElement(ProfileVars.my_like_match_away_icon), "No se muestra el icono visitante de partidos");
            Assert.True(utils.existsElement(ProfileVars.my_like_match_home_score), "No se muestra el resultado local de partidos");
            Assert.True(utils.existsElement(ProfileVars.my_like_match_away_score), "No se muestra el resultado visitante de partidos");
            Assert.True(utils.existsElement(ProfileVars.my_like_match_home_name), "No se muestra el nombre local de partidos");
            Assert.True(utils.existsElement(ProfileVars.my_like_match_away_name), "No se muestra el nombre visitante de partidos");
            Assert.True(utils.existsElement(ProfileVars.my_like_match_button), "No se muestra el boton de area de partido en la pestaña partidos");
            Assert.True(utils.existsElement(ProfileVars.my_like_match_time), "No se muestra la hora de los partidos");
            //Assert.True(utils.existsElement(ProfileVars.my_like_match_like), "No se muestra el corazon de los partidos");
        }


      
    }
}
