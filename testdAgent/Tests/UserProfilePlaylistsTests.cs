using NUnit.Framework;
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

    public class UserProfilePlaylistsTests {
        IApp madrid;
        Utilities utils;
        Platform platform;

        public UserProfilePlaylistsTests(Platform platform)
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
            //utils.Login_data(Strings.LOGIN_USERNAME_NOTLINKED, Strings.LOGIN_PASSWORD_NOTLINKED);
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
				madrid.ScrollDown(view, ScrollStrategy.Gesture, 0.20, 500, true);
		   }
		}
        private void deleteAllList()
        {
            while (utils.existsElement(ProfileVars.playlist_more_options_but))
            {
                madrid.Tap(ProfileVars.playlist_more_options_but);
                utils.Sleep(3);
                madrid.Tap(ProfileVars.playlist_edit_popup_delete_but);
                utils.Sleep(3);
                madrid.Tap(ProfileVars.playlist_delete_popup_save_but);
                utils.Sleep(3);
            }
        }


        [Test]
		// Create a new non-existing playlist from "PlayLists" screen
        public void Test_35479()
        {
			if (utils._device == "Tablet")
			{
				//Step 2:Go to PlayLists
				utils.Sleep(9);
				madrid.Tap(NavigationBarVars.navbar_Profile_but);
				//madrid.ScrollDownTo(ProfileVars.my_channel_but);
				//Go_To_Slow(ProfileVars.my_channel_but, ProfileVars.personal_area_view);
				madrid.Tap(ProfileVars.my_channel_but);
				madrid.WaitForElement(ProfileVars.my_channel_page_title);
				Assert.True(utils.existsElement(ProfileVars.my_channel_page_title), "No se ve el titulo de la pagina de mi canal");
				Assert.True(utils.existsElement(ProfileVars.my_channel_playlist_tab), "No se ve la pestaña de playlist de la pagina de mi canal");
				madrid.Tap(ProfileVars.my_channel_playlist_tab);
				//Step 3:Click on "+ Nueva Lista" button
				this.deleteAllList();
				utils.Sleep(3);
				madrid.WaitForElement(ProfileVars.playlist_new_but);
				Assert.True(utils.existsElement(ProfileVars.playlist_new_but), "No se ve el boton de nueva playlist de la pagina de mi canal");
				madrid.Tap(ProfileVars.playlist_new_but);
				madrid.WaitForElement(ProfileVars.playlist_new_popup);
				Assert.True(utils.existsElement(ProfileVars.playlist_new_popup), "No se ve el popup de nueva playlist");
				Assert.True(utils.existsElement(ProfileVars.playlist_new_popup_title), "No se ve el titulo en el popup de nueva playlist");
				Assert.True(utils.existsElement(ProfileVars.playlist_new_popup_combo_title), "No se ve el titulo en el combo del popup de nueva playlist");
				Assert.True(utils.existsElement(ProfileVars.playlist_new_popup_combo), "No se ve el imput en el combo del popup de nueva playlist");
				Assert.True(utils.existsElement(ProfileVars.playlist_new_popup_advice), "No se ve el primer mensaje en el popup de nueva playlist");
				Assert.True(utils.existsElement(ProfileVars.playlist_new_popup_save_finder_but), "No se ve el boton guardar e ir al buscador en el popup de nueva playlist");
				Assert.True(utils.existsElement(ProfileVars.playlist_new_popup_advice2), "No se ve el segndo mensaje en el popup de nueva playlist");
				Assert.True(utils.existsElement(ProfileVars.playlist_new_popup_save_but), "No se ve el boton guardar en el popup de nueva playlist");
				Assert.True(utils.existsElement(ProfileVars.playlist_new_popup_cancel_but), "No se ve el boton cancelar en el popup de nueva playlist");
				//Step 4: Fill the "Titulo" field and press on save button
				string newlist = "PL " + DateTime.Now.ToString();
				madrid.ClearText(ProfileVars.playlist_new_popup_combo);
				madrid.EnterText(ProfileVars.playlist_new_popup_combo, newlist);
				madrid.DismissKeyboard();
				madrid.Tap(ProfileVars.playlist_new_popup_save_but);
				Assert.True(utils.existsElement(ProfileVars.my_channel_page_title), "No se ve el titulo de la pagina de mi canal");
				//Assert.True(utils.existsElement(a => a.Id("tv_playlist_title").Text(newlist));
				Assert.True(utils.existsElement(a => a.Marked(newlist)));
				//utils.Go_To(a => a.Id("tv_playlist_title").Text(newlist), ProfileVars.playlist_view, 5, "No se encuentra la lista creada");
			}
			else
			{ 
				//Step 2:Go to PlayLists
				madrid.Tap(NavigationBarVars.navbar_Profile_but);
				utils.Sleep(3);
				madrid.ScrollDown();
				//Go_To_Slow(ProfileVars.my_channel_but, ProfileVars.personal_area_view);
				madrid.Tap(ProfileVars.my_channel_but);
				madrid.WaitForElement(ProfileVars.my_channel_page_title);
				Assert.True(utils.existsElement(ProfileVars.my_channel_page_title), "No se ve el titulo de la pagina de mi canal");
				Assert.True(utils.existsElement(ProfileVars.my_channel_playlist_tab), "No se ve la pestaña de playlist de la pagina de mi canal");
				madrid.Tap(ProfileVars.my_channel_playlist_tab);
				//Step 3:Click on "+ Nueva Lista" button
				this.deleteAllList();
				utils.Sleep(3);
				madrid.WaitForElement(ProfileVars.playlist_new_but);
				Assert.True(utils.existsElement(ProfileVars.playlist_new_but), "No se ve el boton de nueva playlist de la pagina de mi canal");
				madrid.Tap(ProfileVars.playlist_new_but);
				madrid.WaitForElement(ProfileVars.playlist_new_popup);
				Assert.True(utils.existsElement(ProfileVars.playlist_new_popup), "No se ve el popup de nueva playlist");
				Assert.True(utils.existsElement(ProfileVars.playlist_new_popup_title), "No se ve el titulo en el popup de nueva playlist");
				Assert.True(utils.existsElement(ProfileVars.playlist_new_popup_combo_title), "No se ve el titulo en el combo del popup de nueva playlist");
				Assert.True(utils.existsElement(ProfileVars.playlist_new_popup_combo), "No se ve el imput en el combo del popup de nueva playlist");
				Assert.True(utils.existsElement(ProfileVars.playlist_new_popup_advice), "No se ve el primer mensaje en el popup de nueva playlist");
				Assert.True(utils.existsElement(ProfileVars.playlist_new_popup_save_finder_but), "No se ve el boton guardar e ir al buscador en el popup de nueva playlist");
				Assert.True(utils.existsElement(ProfileVars.playlist_new_popup_advice2), "No se ve el segndo mensaje en el popup de nueva playlist");
				Assert.True(utils.existsElement(ProfileVars.playlist_new_popup_save_but), "No se ve el boton guardar en el popup de nueva playlist");
				Assert.True(utils.existsElement(ProfileVars.playlist_new_popup_cancel_but), "No se ve el boton cancelar en el popup de nueva playlist");
				//Step 4: Fill the "Titulo" field and press on save button
				string newlist = "PL " + DateTime.Now.ToString();
				madrid.ClearText(ProfileVars.playlist_new_popup_combo);
				madrid.EnterText(ProfileVars.playlist_new_popup_combo, newlist);
				madrid.DismissKeyboard();
				madrid.Tap(ProfileVars.playlist_new_popup_save_but);
				Assert.True(utils.existsElement(ProfileVars.my_channel_page_title), "No se ve el titulo de la pagina de mi canal");
				//Assert.True(utils.existsElement(a => a.Id("tv_playlist_title").Text(newlist));
				Assert.True(utils.existsElement(a => a.Marked(newlist)));
			}
        }

        [Test]
        public void Test_35480()
        {
            //Step 2:Go to PlayLists
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
			utils.Sleep(3);
            madrid.ScrollDown();
			//utils.Go_To(ProfileVars.my_channel_but, ProfileVars.personal_area_view, 5, "No esta el boton de mi canal");
            madrid.Tap(ProfileVars.my_channel_but);
			madrid.WaitForElement(ProfileVars.my_channel_page_title);	
            Assert.True(utils.existsElement(ProfileVars.my_channel_page_title), "No se ve el titulo de la pagina de mi canal");
            Assert.True(utils.existsElement(ProfileVars.my_channel_playlist_tab), "No se ve la pestaña de playlist de la pagina de mi canal");
            madrid.Tap(ProfileVars.my_channel_playlist_tab);
            //Step 3:Click on "+ Nueva Lista" button
            this.deleteAllList();
            Assert.True(utils.existsElement(ProfileVars.playlist_new_but), "No se ve el boton de nueva playlist de la pagina de mi canal");
            madrid.Tap(ProfileVars.playlist_new_but);
            //Step 3:Fill the "Titulo" field with an existing name playlist and press on save button
            string newlist = "PL " + DateTime.Now.ToString();
            madrid.ClearText(ProfileVars.playlist_new_popup_combo);
            madrid.EnterText(ProfileVars.playlist_new_popup_combo, newlist);
            madrid.DismissKeyboard();
            madrid.Tap(ProfileVars.playlist_new_popup_save_but);
            utils.Sleep(5);
            Assert.True(utils.existsElement(ProfileVars.playlist_new_but), "No se ve el boton de nueva playlist de la pagina de mi canal despues de crear una lista nueva");
            madrid.Tap(ProfileVars.playlist_new_but);
            madrid.ClearText(ProfileVars.playlist_new_popup_combo);
            madrid.EnterText(ProfileVars.playlist_new_popup_combo, newlist);
            madrid.DismissKeyboard();
            madrid.Tap(ProfileVars.playlist_new_popup_save_but);
            utils.Sleep(2);
            Assert.True(utils.existsElement(ProfileVars.playlist_repited_popup_msg), "No se ve el mensaje de playlist repetida en el popup");
            Assert.True(utils.existsElement(ProfileVars.playlist_repited_popup_save_but), "No se ve el boton ok en el popup de playlist repetida");

        }

        [Test]
        public void Test_35481()
        {
            // Step 2: Go to Finder
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.main_title);
            // Step 3:Search any video (Be sure you are using a free video or a purchased one).
            //            madrid.ClearText(ProfileVars.playlist_new_popup_combo);
            utils.Sleep(2);
			madrid.EnterText(ProfileVars.search_input_bar, "\"" + Strings.PLAYLIST_SUBSCRIPTION_QA_TEST1_I + "\"");
            utils.Sleep(2);
			madrid.DismissKeyboard();
            /*if (platform == Platform.Android)
            {
                Xamarin.UITest.Android.AndroidApp app = (Xamarin.UITest.Android.AndroidApp)madrid;
                app.PressUserAction();
            }*/
            utils.Sleep(5);
			madrid.Tap(ProfileVars.finder_Videos_destacados);
			madrid.WaitForElement(ProfileVars.finder_add_video_but);
            Assert.True(utils.existsElement(ProfileVars.finder_add_video_but), "No se ve el boton de añadir a playlist en un video en finder");
            //Step 4: Click on the "+" button in the video.
            //madrid.Tap(ProfileVars.finder_Videos_destacados); //Perder el foco
            madrid.Tap(ProfileVars.finder_add_video_but);

            utils.Sleep(5);
            Assert.True(utils.existsElement(ProfileVars.playlist_select_popup_title), "No se ve el titulo en el popup de seleccionar playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_select_popup_subtitle), "No se ve el subtitulo en el combo del popup de seleccionar playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_select_popup_imput), "No se ve el imput en el popup de seleccionar playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_select_popup_save_but), "No se ve el boton guardar en el popup de seleccionar playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_select_popup_cancel_but), "No se ve el boton cancelar en el popup de seleccionar playlist");
            //Step 5: Fill the "Nueva lista de reproducción" field and press on "Añadir" button.
            string newlist = "PL " + DateTime.Now.ToString();
            madrid.ClearText(ProfileVars.playlist_select_popup_imput);
            madrid.EnterText(ProfileVars.playlist_select_popup_imput, newlist);
            madrid.DismissKeyboard();
            utils.Sleep(3);
            madrid.Tap(ProfileVars.playlist_select_popup_save_but);
            utils.Sleep(2);
            Assert.True(utils.existsElement(FinderVars.main_title), "No se ve la ventana de finder");
            //Step 6:Go to PlayLists
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
            madrid.ScrollDown();
			//utils.Go_To(ProfileVars.my_channel_but, ProfileVars.personal_area_view, 5, "No esta el boton de mi canal");
            madrid.Tap(ProfileVars.my_channel_but);
			madrid.WaitForElement(ProfileVars.my_channel_page_title);
            Assert.True(utils.existsElement(ProfileVars.my_channel_page_title), "No se ve el titulo de la pagina de mi canal");
            Assert.True(utils.existsElement(ProfileVars.my_channel_playlist_tab), "No se ve la pestaña de playlist de la pagina de mi canal");
            madrid.Tap(ProfileVars.my_channel_playlist_tab);
            //Step 7:Check the playlist is created.
			utils.Sleep(3);
            //Assert.True(utils.existsElement(a=> a.Marked(newlist)));
			Assert.True(utils.existsElement(ProfileVars.my_channel_page_title), "No se ve el titulo de la pagina de mi canal");
			Assert.True(utils.existsElement(a=> a.Text("nueva1")));
			//utils.Go_To(a => a.Id("tv_playlist_title").Text(newlist), ProfileVars.playlist_view, 5, "No se encuentra la lista creada");
            madrid.Tap(a => a.Marked(newlist));
			//madrid.Tap(a => a.Id("tv_playlist_title").Text(newlist));
            utils.Sleep(4);
            Assert.True(utils.existsElement(ProfileVars.playlist_video_subscription_I), "No se ha añadido el vieo a la playist");
        }

        [Test]
        public void Test_35482()
        {
            //Prerequisitos: Crear una lista 
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
			utils.Sleep(3);
            madrid.ScrollDown();
			//utils.Go_To(ProfileVars.my_channel_but, ProfileVars.personal_area_view, 5, "No esta el boton de mi canal");
            madrid.Tap(ProfileVars.my_channel_but);
            madrid.Tap(ProfileVars.my_channel_playlist_tab);
            this.deleteAllList();
            madrid.Tap(ProfileVars.playlist_new_but);
            string newlist = "PL " + DateTime.Now.ToString();
            madrid.ClearText(ProfileVars.playlist_new_popup_combo);
            madrid.EnterText(ProfileVars.playlist_new_popup_combo, newlist);
            madrid.DismissKeyboard();
            madrid.Tap(ProfileVars.playlist_new_popup_save_but);
            utils.Sleep(3);
			madrid.Tap(ProfileVars.MyChannel_page_GoBack);
			utils.Sleep(3);
			madrid.Tap(NavigationBarVars.navbar_Home_but);
            //madrid.Tap(ProfileVars.personal_area_menu_but);
            // Step 2: Go to Finder
			utils.Sleep(3);
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.main_title);
            // Step 3:Search any video (Be sure you are using a free video or a purchased one).
            //            madrid.ClearText(ProfileVars.playlist_new_popup_combo);
            madrid.EnterText(ProfileVars.search_input_bar, "\"" + Strings.PLAYLIST_SUBSCRIPTION_QA_TEST1_I + "\"");
            madrid.DismissKeyboard();
            /*if (platform == Platform.Android)
            {
                Xamarin.UITest.Android.AndroidApp app = (Xamarin.UITest.Android.AndroidApp)madrid;
                app.PressUserAction();
            }*/	
			utils.Sleep(5);
			madrid.Tap(ProfileVars.finder_Videos_destacados);
			madrid.WaitForElement(ProfileVars.finder_add_video_but);
            Assert.True(utils.existsElement(ProfileVars.finder_add_video_but), "No se ve el boton de añadir a playlist en un video en finder");
            //Step 4: Click on the "+" button in the video.
            //madrid.Tap(ProfileVars.finder_Videos_destacados); //Perder el foco
            madrid.Tap(ProfileVars.finder_add_video_but);

            utils.Sleep(5);
            Assert.True(utils.existsElement(ProfileVars.playlist_select_popup_title), "No se ve el titulo en el popup de seleccionar playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_select_popup_subtitle), "No se ve el subtitulo en el combo del popup de seleccionar playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_select_popup_imput), "No se ve el imput en el popup de seleccionar playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_select_popup_save_but), "No se ve el boton guardar en el popup de seleccionar playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_select_popup_cancel_but), "No se ve el boton cancelar en el popup de seleccionar playlist");
            //Step 5: Fill the "Nueva lista de reproducción" field with a existing name playlist and press on "Añadir" button.
            madrid.ClearText(ProfileVars.playlist_select_popup_imput);
            madrid.EnterText(ProfileVars.playlist_select_popup_imput, newlist);
            madrid.DismissKeyboard();
            utils.Sleep(3);
            madrid.Tap(ProfileVars.playlist_select_popup_save_but);
            utils.Sleep(3);
            Assert.True(utils.existsElement(ProfileVars.playlist_repited_popup_msg), "No se ve el mensaje de playlist repetida en el popup");
            Assert.True(utils.existsElement(ProfileVars.playlist_repited_popup_save_but), "No se ve el boton ok en el popup de playlist repetida");
            utils.Sleep(2);
            madrid.Tap(ProfileVars.playlist_repited_popup_save_but);
            utils.Sleep(2);
            madrid.Tap(ProfileVars.playlist_select_popup_cancel_but);
            //Step 6:Go to PlayLists
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
            madrid.ScrollDown();
			//utils.Go_To(ProfileVars.my_channel_but, ProfileVars.personal_area_view, 5, "No esta el boton de mi canal");
            madrid.Tap(ProfileVars.my_channel_but);
            Assert.True(utils.existsElement(ProfileVars.my_channel_page_title), "No se ve el titulo de la pagina de mi canal");
            Assert.True(utils.existsElement(ProfileVars.my_channel_playlist_tab), "No se ve la pestaña de playlist de la pagina de mi canal");
            madrid.Tap(ProfileVars.my_channel_playlist_tab);
            //Step 7:Check the video is no added to the existed playlist.
            Assert.True(utils.existsElement(a=> a.Marked(newlist)));
			//utils.Go_To(a => a.Id("tv_playlist_title").Text(newlist), ProfileVars.playlist_view, 5, "No se encuentra la lista");
            //madrid.Tap(a => a.Id("tv_playlist_title").Text(newlist));
			madrid.Tap(a=> a.Marked(newlist));
			utils.Sleep(4);
            Assert.False(utils.existsElement(ProfileVars.playlist_video_subscription_I), "Se ha añadido el vieo a la playist");

        }

        [Test]
        public void Test_35483()
        {
            // Step 2: Go to Finder
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.main_title);
            // Step 3:Search any video (Be sure you are using a free video or a purchased one).
            //            madrid.ClearText(ProfileVars.playlist_new_popup_combo);
            madrid.EnterText(ProfileVars.search_input_bar, "\"" + Strings.PLAYLIST_SUBSCRIPTION_QA_TEST1_I + "\"");
            madrid.DismissKeyboard();
            if (platform == Platform.Android)
            {
                Xamarin.UITest.Android.AndroidApp app = (Xamarin.UITest.Android.AndroidApp)madrid;
                app.PressUserAction();
            }
            utils.Sleep(3);
            Assert.True(utils.existsElement(ProfileVars.finder_add_video_but), "No se ve el boton de añadir a playlist en un video en finder");
            //Step 4: Click on any searched video.
            madrid.Tap(ProfileVars.finder_Videos_destacados); //Perder el foco
            madrid.Tap(ProfileVars.video_title_test1);
            utils.Sleep(2);
            //Step 5:Click on "+ Añadir video a la lista de reproduccion" button.
            madrid.Tap(ProfileVars.finder_add_video_details_but);
            utils.Sleep(5);
            Assert.True(utils.existsElement(ProfileVars.playlist_select_popup_title), "No se ve el titulo en el popup de seleccionar playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_select_popup_subtitle), "No se ve el subtitulo en el combo del popup de seleccionar playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_select_popup_imput), "No se ve el imput en el popup de seleccionar playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_select_popup_save_but), "No se ve el boton guardar en el popup de seleccionar playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_select_popup_cancel_but), "No se ve el boton cancelar en el popup de seleccionar playlist");
            //Step 6: Fill the "Nueva lista de reproducción" field and press on "Añadir" button.
            string newlist = "PL " + DateTime.Now.ToString();
            madrid.ClearText(ProfileVars.playlist_select_popup_imput);
            madrid.EnterText(ProfileVars.playlist_select_popup_imput, newlist);
            madrid.DismissKeyboard();
            utils.Sleep(3);
            madrid.Tap(ProfileVars.playlist_select_popup_save_but);
            utils.Sleep(2);
            //Step 7:Go to PlayLists
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
            utils.Go_To(ProfileVars.my_channel_but, ProfileVars.personal_area_view, 5, "No esta el boton de mi canal");
            madrid.Tap(ProfileVars.my_channel_but);
            Assert.True(utils.existsElement(ProfileVars.my_channel_page_title), "No se ve el titulo de la pagina de mi canal");
            Assert.True(utils.existsElement(ProfileVars.my_channel_playlist_tab), "No se ve la pestaña de playlist de la pagina de mi canal");
            madrid.Tap(ProfileVars.my_channel_playlist_tab);
            //Step 8:Check the playlist is created.
            utils.Go_To(a => a.Id("tv_playlist_title").Text(newlist), ProfileVars.playlist_view, 5, "No se encuentra la lista creada");
            madrid.Tap(a => a.Id("tv_playlist_title").Text(newlist));
            utils.Sleep(4);
            Assert.True(utils.existsElement(ProfileVars.playlist_video_subscription_I), "No se ha añadido el vieo a la playist");
        }

        [Test]
        public void Test_35484()
        {
            //Prerequisitos: Crear una lista 
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
			utils.Sleep(3);
            utils.Go_To(ProfileVars.my_channel_but, ProfileVars.personal_area_view, 5, "No esta el boton de mi canal");
            madrid.Tap(ProfileVars.my_channel_but);
            madrid.Tap(ProfileVars.my_channel_playlist_tab);
            this.deleteAllList();
            madrid.Tap(ProfileVars.playlist_new_but);
            string newlist = "PL " + DateTime.Now.ToString();
            madrid.ClearText(ProfileVars.playlist_new_popup_combo);
            madrid.EnterText(ProfileVars.playlist_new_popup_combo, newlist);
            madrid.DismissKeyboard();
            madrid.Tap(ProfileVars.playlist_new_popup_save_but);
            utils.Sleep(3);
            madrid.Tap(MainMenuVars.menu_Main_but);
            // Step 2: Go to Finder
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.main_title);
            // Step 3:Search any video (Be sure you are using a free video or a purchased one).
            //            madrid.ClearText(ProfileVars.playlist_new_popup_combo);
            madrid.EnterText(ProfileVars.search_input_bar, "\"" + Strings.PLAYLIST_SUBSCRIPTION_QA_TEST1_I + "\"");
            madrid.DismissKeyboard();
            if (platform == Platform.Android)
            {
                Xamarin.UITest.Android.AndroidApp app = (Xamarin.UITest.Android.AndroidApp)madrid;
                app.PressUserAction();
            }
            utils.Sleep(3);
            //Step 4: Click on any searched video.
            madrid.Tap(ProfileVars.finder_Videos_destacados); //Perder el foco
            madrid.Tap(ProfileVars.video_title_test1);
            utils.Sleep(2);
            //Step 5:Click on "+ Añadir video a la lista de reproduccion" button.
            madrid.Tap(ProfileVars.finder_add_video_details_but);
            utils.Sleep(5);
            Assert.True(utils.existsElement(ProfileVars.playlist_select_popup_title), "No se ve el titulo en el popup de seleccionar playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_select_popup_subtitle), "No se ve el subtitulo en el combo del popup de seleccionar playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_select_popup_imput), "No se ve el imput en el popup de seleccionar playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_select_popup_save_but), "No se ve el boton guardar en el popup de seleccionar playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_select_popup_cancel_but), "No se ve el boton cancelar en el popup de seleccionar playlist");
            //Step 6: Fill the "Nueva lista de reproducción" field with a existing name playlist and press on "Añadir" button.
            madrid.ClearText(ProfileVars.playlist_select_popup_imput);
            madrid.EnterText(ProfileVars.playlist_select_popup_imput, newlist);
            madrid.DismissKeyboard();
            utils.Sleep(3);
            madrid.Tap(ProfileVars.playlist_select_popup_save_but);
            utils.Sleep(3);
            Assert.True(utils.existsElement(ProfileVars.playlist_repited_popup_msg), "No se ve el mensaje de playlist repetida en el popup");
            Assert.True(utils.existsElement(ProfileVars.playlist_repited_popup_save_but), "No se ve el boton ok en el popup de playlist repetida");
            utils.Sleep(2);
            madrid.Tap(ProfileVars.playlist_repited_popup_save_but);
            utils.Sleep(2);
            madrid.Tap(ProfileVars.playlist_select_popup_cancel_but);
            //Step 7:Go to PlayLists
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
            utils.Go_To(ProfileVars.my_channel_but, ProfileVars.personal_area_view, 5, "No esta el boton de mi canal");
            madrid.Tap(ProfileVars.my_channel_but);
            Assert.True(utils.existsElement(ProfileVars.my_channel_page_title), "No se ve el titulo de la pagina de mi canal");
            Assert.True(utils.existsElement(ProfileVars.my_channel_playlist_tab), "No se ve la pestaña de playlist de la pagina de mi canal");
            madrid.Tap(ProfileVars.my_channel_playlist_tab);
            //Step 8:Check the video is no added to the existed playlist.
            utils.Go_To(a => a.Id("tv_playlist_title").Text(newlist), ProfileVars.playlist_view, 5, "No se encuentra la lista");
            madrid.Tap(a => a.Id("tv_playlist_title").Text(newlist));
            utils.Sleep(4);
            Assert.False(utils.existsElement(ProfileVars.playlist_video_subscription_I), "Se ha añadido el vieo a la playist");

        }






        [Test]
        public void Test_35485()
        {
            //Step 2:Go to PlayLists
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
			utils.Sleep(3);
            utils.Go_To(ProfileVars.my_channel_but, ProfileVars.personal_area_view, 5, "No esta el boton de mi canal");
            madrid.Tap(ProfileVars.my_channel_but);
            Assert.True(utils.existsElement(ProfileVars.my_channel_page_title), "No se ve el titulo de la pagina de mi canal");
            Assert.True(utils.existsElement(ProfileVars.my_channel_playlist_tab), "No se ve la pestaña de playlist de la pagina de mi canal");
            madrid.Tap(ProfileVars.my_channel_playlist_tab);
            //Step 3:Click on the "..." button in the playlist you want to modify.
            if (!utils.existsElement(ProfileVars.playlist_more_options_but))
            {
                string playList = "PL " + DateTime.Now.ToString();
                Assert.True(utils.existsElement(ProfileVars.playlist_new_but), "No se ve el boton de nueva playlist de la pagina de mi canal");
                madrid.Tap(ProfileVars.playlist_new_but);
                madrid.ClearText(ProfileVars.playlist_new_popup_combo);
                madrid.EnterText(ProfileVars.playlist_new_popup_combo, playList);
                madrid.DismissKeyboard();
                madrid.Tap(ProfileVars.playlist_new_popup_save_but);
                utils.Sleep(5);
            }
            madrid.Tap(ProfileVars.playlist_more_options_but);
            Assert.True(utils.existsElement(ProfileVars.playlist_edit_popup_title), "No se ve el titulo en el popup de editar playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_edit_popup_subtitle), "No se ve el subtitulo en el popup de editar playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_edit_popup_combo), "No se ve el imput en el combo del popup de editar playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_edit_popup_delete_but), "No se ve el boton borrar en el popup de editar playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_edit_popup_save_but), "No se ve el boton guardar en el popup de editar playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_edit_popup_cancel_but), "No se ve el boton cancelar en el popup de editar playlist");

            //Step 4:Change the name of the playlist.
            string newName = "PL " + DateTime.Now.ToString();
            madrid.ClearText(ProfileVars.playlist_edit_popup_combo);
            madrid.EnterText(ProfileVars.playlist_edit_popup_combo, newName);
            madrid.DismissKeyboard();
            madrid.Tap(ProfileVars.playlist_edit_popup_save_but);
            utils.Sleep(3);

            Assert.True(utils.existsElement(a => a.Id("tv_playlist_title").Text(newName)), "No se encuentra la lista con el nuevo nombre");


        }


        [Test]
        public void Test_35486()
        {
            //Step 2:Go to PlayLists
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
			utils.Sleep(3);
            utils.Go_To(ProfileVars.my_channel_but, ProfileVars.personal_area_view, 5, "No esta el boton de mi canal");
            madrid.Tap(ProfileVars.my_channel_but);
            Assert.True(utils.existsElement(ProfileVars.my_channel_page_title), "No se ve el titulo de la pagina de mi canal");
            Assert.True(utils.existsElement(ProfileVars.my_channel_playlist_tab), "No se ve la pestaña de playlist de la pagina de mi canal");
            madrid.Tap(ProfileVars.my_channel_playlist_tab);
            //Step 3:Click on the "..." button in the playlist you want to modify.
            if (!utils.existsElement(ProfileVars.playlist_more_options_but))
            {
                string playList = "PL " + DateTime.Now.ToString();
                Assert.True(utils.existsElement(ProfileVars.playlist_new_but), "No se ve el boton de nueva playlist de la pagina de mi canal");
                madrid.Tap(ProfileVars.playlist_new_but);
                madrid.ClearText(ProfileVars.playlist_new_popup_combo);
                madrid.EnterText(ProfileVars.playlist_new_popup_combo, playList);
                madrid.DismissKeyboard();
                madrid.Tap(ProfileVars.playlist_new_popup_save_but);
                utils.Sleep(5);
            }
            madrid.Tap(ProfileVars.playlist_more_options_but);
            utils.Sleep(3);
            Assert.True(utils.existsElement(ProfileVars.playlist_edit_popup_title), "No se ve el titulo en el popup de editar playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_edit_popup_subtitle), "No se ve el subtitulo en el popup de editar playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_edit_popup_combo), "No se ve el imput en el combo del popup de editar playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_edit_popup_delete_but), "No se ve el boton borrar en el popup de editar playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_edit_popup_save_but), "No se ve el boton guardar en el popup de editar playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_edit_popup_cancel_but), "No se ve el boton cancelar en el popup de editar playlist");

            //Step 4:Click on Borrar lista de reproducción
            String name = madrid.Query(ProfileVars.playlist_edit_popup_combo)[0].Text;
            madrid.Tap(ProfileVars.playlist_edit_popup_delete_but);
            utils.Sleep(3);
            Assert.True(utils.existsElement(ProfileVars.playlist_delete_popup_msg), "No se ve el titulo en el popup de borrar playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_delete_popup_save_but), "No se ve el boton de guardar en el popup de borrar playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_delete_popup_cancel_but), "No se ve el boton de cancelar en el popup de borrar playlist");
            //Step 5:Click on "Borrar"
            madrid.Tap(ProfileVars.playlist_delete_popup_save_but);
            utils.Sleep(5);
            Assert.False(utils.existsElement(a => a.Id("tv_playlist_title").Text(name)), "No se ha borrado la lista");
        }

        [Test]
        public void Test_35487()
        {
            //Prerequisitos: Crear una lista 
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
			utils.Sleep(3);
            utils.Go_To(ProfileVars.my_channel_but, ProfileVars.personal_area_view, 5, "No esta el boton de mi canal");
            madrid.Tap(ProfileVars.my_channel_but);
            madrid.Tap(ProfileVars.my_channel_playlist_tab);
            this.deleteAllList();
            madrid.Tap(ProfileVars.playlist_new_but);
            string newlist = "PL " + DateTime.Now.ToString();
            madrid.ClearText(ProfileVars.playlist_new_popup_combo);
            madrid.EnterText(ProfileVars.playlist_new_popup_combo, newlist);
            madrid.DismissKeyboard();
            madrid.Tap(ProfileVars.playlist_new_popup_save_but);
            utils.Sleep(3);
            madrid.Tap(MainMenuVars.menu_Main_but);
            // Step 2: Go to Finder
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.main_title);
            // Step 3:Search a free or a purchased video
            //            madrid.ClearText(ProfileVars.playlist_new_popup_combo);
            madrid.EnterText(ProfileVars.search_input_bar, "\"" + Strings.PLAYLIST_SUBSCRIPTION_QA_TEST1_I + "\"");
            madrid.DismissKeyboard();
            if (platform == Platform.Android)
            {
                Xamarin.UITest.Android.AndroidApp app = (Xamarin.UITest.Android.AndroidApp)madrid;
                app.PressUserAction();
            }
            utils.Sleep(3);
            //Step 4: Click on the "+" button in the video
            madrid.Tap(ProfileVars.finder_Videos_destacados); //Perder el foco
            madrid.Tap(ProfileVars.finder_add_video_but);

            utils.Sleep(5);
            Assert.True(utils.existsElement(ProfileVars.playlist_select_popup_title), "No se ve el titulo en el popup de seleccionar playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_select_popup_subtitle), "No se ve el subtitulo en el combo del popup de seleccionar playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_select_popup_imput), "No se ve el imput en el popup de seleccionar playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_select_popup_save_but), "No se ve el boton guardar en el popup de seleccionar playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_select_popup_cancel_but), "No se ve el boton cancelar en el popup de seleccionar playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_select_popup_cancel_but), "No se ve el boton cancelar en el popup de seleccionar playlist");

            //Step 5:Select an existing name playlist and press on "Añadir" button 
            madrid.Tap(a => a.Id("tv_playlist_title").Text(newlist));
            utils.Sleep(3);
            madrid.Tap(ProfileVars.playlist_select_popup_save_but);
            utils.Sleep(3);
            Assert.True(utils.existsElement(FinderVars.main_title), "No se ve la ventana de finder");
            //Step 6:Go to PlayLists
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
            utils.Go_To(ProfileVars.my_channel_but, ProfileVars.personal_area_view, 5, "No esta el boton de mi canal");
            madrid.Tap(ProfileVars.my_channel_but);
            Assert.True(utils.existsElement(ProfileVars.my_channel_page_title), "No se ve el titulo de la pagina de mi canal");
            Assert.True(utils.existsElement(ProfileVars.my_channel_playlist_tab), "No se ve la pestaña de playlist de la pagina de mi canal");
            madrid.Tap(ProfileVars.my_channel_playlist_tab);
            //Step 7:Open the selected playlist
            utils.Go_To(a => a.Id("tv_playlist_title").Text(newlist), ProfileVars.playlist_view, 5, "No se encuentra la lista creada");
            madrid.Tap(a => a.Id("tv_playlist_title").Text(newlist));
            utils.Sleep(4);
            Assert.True(utils.existsElement(ProfileVars.playlist_video_subscription_I), "No se ha añadido el vieo a la playist");
        }

        [Test]
        public void Test_35488()
        {
            //Prerequisitos: Crear una lista 
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
			utils.Sleep(3);
            utils.Go_To(ProfileVars.my_channel_but, ProfileVars.personal_area_view, 5, "No esta el boton de mi canal");
            madrid.Tap(ProfileVars.my_channel_but);
            madrid.Tap(ProfileVars.my_channel_playlist_tab);
            this.deleteAllList();
            madrid.Tap(ProfileVars.playlist_new_but);
            string newlist = "PL " + DateTime.Now.ToString();
            madrid.ClearText(ProfileVars.playlist_new_popup_combo);
            madrid.EnterText(ProfileVars.playlist_new_popup_combo, newlist);
            madrid.DismissKeyboard();
            madrid.Tap(ProfileVars.playlist_new_popup_save_but);
            utils.Sleep(3);
            madrid.Tap(MainMenuVars.menu_Main_but);
            // Step 2: Go to Finder
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.main_title);
            // Step 3:Search a free or a purchased video
            //            madrid.ClearText(ProfileVars.playlist_new_popup_combo);
            madrid.EnterText(ProfileVars.search_input_bar, "\"" + Strings.PLAYLIST_SUBSCRIPTION_QA_TEST1_I + "\"");
            madrid.DismissKeyboard();
            if (platform == Platform.Android)
            {
                Xamarin.UITest.Android.AndroidApp app = (Xamarin.UITest.Android.AndroidApp)madrid;
                app.PressUserAction();
            }
            utils.Sleep(3);

            //Step 4:Click on a Video
            madrid.Tap(ProfileVars.finder_Videos_destacados); //Perder el foco
            madrid.Tap(ProfileVars.video_title_test1);
            utils.Sleep(2);
            //Step 5:Click on "+ Añadir video a la lista de reproduccion" button.
            madrid.Tap(ProfileVars.finder_add_video_details_but);
            utils.Sleep(5);
            Assert.True(utils.existsElement(ProfileVars.playlist_select_popup_title), "No se ve el titulo en el popup de seleccionar playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_select_popup_subtitle), "No se ve el subtitulo en el combo del popup de seleccionar playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_select_popup_imput), "No se ve el imput en el popup de seleccionar playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_select_popup_save_but), "No se ve el boton guardar en el popup de seleccionar playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_select_popup_cancel_but), "No se ve el boton cancelar en el popup de seleccionar playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_select_popup_cancel_but), "No se ve el boton cancelar en el popup de seleccionar playlist");

            //Step 6:Select an existing name playlist and press on "Añadir" button 
            madrid.Tap(a => a.Id("tv_playlist_title").Text(newlist));
            utils.Sleep(3);
            madrid.Tap(ProfileVars.playlist_select_popup_save_but);
            utils.Sleep(3);
            //Step 7:Go to PlayLists
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
            utils.Go_To(ProfileVars.my_channel_but, ProfileVars.personal_area_view, 5, "No esta el boton de mi canal");
            madrid.Tap(ProfileVars.my_channel_but);
            Assert.True(utils.existsElement(ProfileVars.my_channel_page_title), "No se ve el titulo de la pagina de mi canal");
            Assert.True(utils.existsElement(ProfileVars.my_channel_playlist_tab), "No se ve la pestaña de playlist de la pagina de mi canal");
            madrid.Tap(ProfileVars.my_channel_playlist_tab);
            //Step 8:Open the selected playlist
            utils.Go_To(a => a.Id("tv_playlist_title").Text(newlist), ProfileVars.playlist_view, 5, "No se encuentra la lista creada");
            madrid.Tap(a => a.Id("tv_playlist_title").Text(newlist));
            utils.Sleep(4);
            Assert.True(utils.existsElement(ProfileVars.playlist_video_subscription_I), "No se ha añadido el vieo a la playist");
        }

        [Test]
        public void Test_35489()
        {
            //Prerequisitos: Crear una lista con un video
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.main_title);
            madrid.EnterText(ProfileVars.search_input_bar, "\"" + Strings.PLAYLIST_SUBSCRIPTION_QA_TEST1_I + "\"");
            madrid.DismissKeyboard();
            if (platform == Platform.Android)
            {
                Xamarin.UITest.Android.AndroidApp app = (Xamarin.UITest.Android.AndroidApp)madrid;
                app.PressUserAction();
            }
            utils.Sleep(3);
            madrid.Tap(ProfileVars.finder_Videos_destacados); //Perder el foco
            madrid.Tap(ProfileVars.finder_add_video_but);
            utils.Sleep(5);
            string newlist = "PL " + DateTime.Now.ToString();
            madrid.ClearText(ProfileVars.playlist_select_popup_imput);
            madrid.EnterText(ProfileVars.playlist_select_popup_imput, newlist);
            madrid.DismissKeyboard();
            utils.Sleep(3);
            madrid.Tap(ProfileVars.playlist_select_popup_save_but);
            utils.Sleep(2);
            //Step 2:Go to PlayLists
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
            utils.Go_To(ProfileVars.my_channel_but, ProfileVars.personal_area_view, 5, "No esta el boton de mi canal");
            madrid.Tap(ProfileVars.my_channel_but);
            Assert.True(utils.existsElement(ProfileVars.my_channel_page_title), "No se ve el titulo de la pagina de mi canal");
            Assert.True(utils.existsElement(ProfileVars.my_channel_playlist_tab), "No se ve la pestaña de playlist de la pagina de mi canal");
            madrid.Tap(ProfileVars.my_channel_playlist_tab);
            //Step 3:Open user playlists with videos
            utils.Go_To(a => a.Id("tv_playlist_title").Text(newlist), ProfileVars.playlist_view, 5, "No se encuentra la lista");
            madrid.Tap(a => a.Id("tv_playlist_title").Text(newlist));
            utils.Sleep(4);
            Assert.True(utils.existsElement(ProfileVars.playlist_video_subscription_I), "No se ha añadido el vieo a la playist");
            Assert.True(utils.existsElement(ProfileVars.playlist_video_subscription_more_but), "No se ve el boton de more option en una subscripcion");
            //Step 4:Click "..." in a video
            madrid.Tap(ProfileVars.playlist_video_subscription_more_but);
            Assert.True(utils.existsElement(ProfileVars.playlist_subscription_more_popup_play), "No se ve el boton de reproducir en el popup de subscripciones");
            Assert.True(utils.existsElement(ProfileVars.playlist_subscription_more_popup_delete), "No se ve el boton de borrar en el popup de subscripciones");
            Assert.True(utils.existsElement(ProfileVars.playlist_subscription_more_popup_ok), "No se ve el boton de OK en el popup de subscripciones");
            //Step 5: Click on "Borrar de la lista de reproucción"
            madrid.Tap(ProfileVars.playlist_subscription_more_popup_delete);
            Assert.True(utils.existsElement(ProfileVars.playlist_delete_video_popup_msg), "No se ve el mensaje en el popup de borrar video");
            Assert.True(utils.existsElement(ProfileVars.playlist_delete_video_popup_save_but), "No se ve el boton borrar en el popup de borrar video");
            Assert.True(utils.existsElement(ProfileVars.playlist_delete_video_popup_cancel_but), "No se ve el boton cancelar en el popup de borrar video");
            //Step 6: Click on "Borrar"
            madrid.Tap(ProfileVars.playlist_delete_video_popup_save_but);
            utils.Sleep(3);
            Assert.False(utils.existsElement(ProfileVars.playlist_video_subscription_I), "No se ha borrado el vieo de la playist");

        }

        [Test]
        public void Test_35490()
        {
            //Prerequisitos: Crear una lista con dos video
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
			utils.Sleep(3);
            utils.Go_To(ProfileVars.my_channel_but, ProfileVars.personal_area_view, 5, "No esta el boton de mi canal");
            madrid.Tap(ProfileVars.my_channel_but);
            madrid.Tap(ProfileVars.my_channel_playlist_tab);
            this.deleteAllList();
            madrid.Tap(MainMenuVars.menu_Main_but);
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.main_title);
            madrid.EnterText(ProfileVars.search_input_bar, "\"" + Strings.PLAYLIST_SUBSCRIPTION_QA_TEST1_I + "\"");
            madrid.DismissKeyboard();
            if (platform == Platform.Android)
            {
                Xamarin.UITest.Android.AndroidApp app = (Xamarin.UITest.Android.AndroidApp)madrid;
                app.PressUserAction();
            }
            utils.Sleep(3);
            madrid.Tap(ProfileVars.finder_Videos_destacados); //Perder el foco
            madrid.Tap(ProfileVars.finder_add_video_but);
            utils.Sleep(5);
            string newlist = "PL " + DateTime.Now.ToString();
            madrid.ClearText(ProfileVars.playlist_select_popup_imput);
            madrid.EnterText(ProfileVars.playlist_select_popup_imput, newlist);
            madrid.DismissKeyboard();
            utils.Sleep(3);
            madrid.Tap(ProfileVars.playlist_select_popup_save_but);
            utils.Sleep(2);
            madrid.ClearText(ProfileVars.search_input_bar);
            madrid.EnterText(ProfileVars.search_input_bar, "\"" + Strings.PLAYLIST_SUBSCRIPTION_QA_TEST1_II + "\"");
            madrid.DismissKeyboard();
            if (platform == Platform.Android)
            {
                Xamarin.UITest.Android.AndroidApp app = (Xamarin.UITest.Android.AndroidApp)madrid;
                app.PressUserAction();
            }
            utils.Sleep(3);
            madrid.Tap(ProfileVars.finder_Videos_destacados); //Perder el foco
            madrid.Tap(ProfileVars.finder_add_video_but);
            utils.Sleep(5);
            madrid.Tap(a => a.Id("tv_playlist_title").Text(newlist));
            utils.Sleep(3);
            madrid.Tap(ProfileVars.playlist_select_popup_save_but);
            utils.Sleep(3);
            //Step 2:Go to PlayLists
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
            utils.Go_To(ProfileVars.my_channel_but, ProfileVars.personal_area_view, 5, "No esta el boton de mi canal");
            madrid.Tap(ProfileVars.my_channel_but);
            Assert.True(utils.existsElement(ProfileVars.my_channel_page_title), "No se ve el titulo de la pagina de mi canal");
            Assert.True(utils.existsElement(ProfileVars.my_channel_playlist_tab), "No se ve la pestaña de playlist de la pagina de mi canal");
            madrid.Tap(ProfileVars.my_channel_playlist_tab);
            //Step 3:Open user playlists with videos
            utils.Go_To(a => a.Id("tv_playlist_title").Text(newlist), ProfileVars.playlist_view, 5, "No se encuentra la lista");
            madrid.Tap(a => a.Id("tv_playlist_title").Text(newlist));
            utils.Sleep(4);
            Assert.True(utils.existsElement(ProfileVars.playlist_video_subscription_I), "No se ha añadido el vieo a la playist");
            Assert.True(utils.existsElement(ProfileVars.playlist_video_subscription_II), "No se ha añadido el vieo a la playist");
            //Step 4:Click in a @list mode to order
            madrid.Tap(ProfileVars.playlist_video_order_list_but);
            Assert.True(utils.existsElement(ProfileVars.playlist_video_list_play_but), "No se ha ordenado la playist");
            //Step 4:Click in a @square mode to order
            madrid.Tap(ProfileVars.playlist_video_order_grid_but);
            Assert.True(utils.existsElement(ProfileVars.playlist_video_grid_image), "No se ha ordenado la playist");
            //Step 4:Click on "REPRODUCIR TODO"
            Assert.True(utils.existsElement(ProfileVars.playlist_video_play_all_but), "No se ha muestra el boton de reproducir todo");
            madrid.Tap(ProfileVars.playlist_video_play_all_but);
            utils.Sleep(2);
            //Assert.True(utils.existsElement(ProfileVars.playlist_video_player_all), "No se reproduce la playist");
        }




        [Test]
        public void Test_35500()
        {
            //Prerequisitos: Crear una lista con un video
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.main_title);
            madrid.EnterText(ProfileVars.search_input_bar, "\"" + Strings.PLAYLIST_SUBSCRIPTION_QA_TEST1_I + "\"");
            madrid.DismissKeyboard();
            if (platform == Platform.Android)
            {
                Xamarin.UITest.Android.AndroidApp app = (Xamarin.UITest.Android.AndroidApp)madrid;
                app.PressUserAction();
            }
            utils.Sleep(3);
            madrid.Tap(ProfileVars.finder_Videos_destacados); //Perder el foco
            madrid.Tap(ProfileVars.finder_add_video_but);
            utils.Sleep(5);
            string newlist = "PL " + DateTime.Now.ToString();
            madrid.ClearText(ProfileVars.playlist_select_popup_imput);
            madrid.EnterText(ProfileVars.playlist_select_popup_imput, newlist);
            madrid.DismissKeyboard();
            utils.Sleep(3);
            madrid.Tap(ProfileVars.playlist_select_popup_save_but);
            utils.Sleep(2);
            //Step 2:Go to PlayLists
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
            utils.Go_To(ProfileVars.my_channel_but, ProfileVars.personal_area_view, 5, "No esta el boton de mi canal");
            madrid.Tap(ProfileVars.my_channel_but);
            Assert.True(utils.existsElement(ProfileVars.my_channel_page_title), "No se ve el titulo de la pagina de mi canal");
            Assert.True(utils.existsElement(ProfileVars.my_channel_playlist_tab), "No se ve la pestaña de playlist de la pagina de mi canal");
            madrid.Tap(ProfileVars.my_channel_playlist_tab);
            //Step 3:Open user playlists with videos
            utils.Go_To(a => a.Id("tv_playlist_title").Text(newlist), ProfileVars.playlist_view, 5, "No se encuentra la lista");
            madrid.Tap(a => a.Id("tv_playlist_title").Text(newlist));
            utils.Sleep(4);
            Assert.True(utils.existsElement(a => a.Id("header_title").Text(newlist)), "No se ve el titulo de la playist");
            Assert.True(utils.existsElement(ProfileVars.playlist_video_subscription_more_but), "No se ve el boton de more option en una subscripcion");
            Assert.True(utils.existsElement(ProfileVars.playlist_elements_number), "No se ve el numero de videos en una subscripcion");
            Assert.True(utils.existsElement(ProfileVars.playlist_video_order_grid_but), "No se ve el boton de ordenar videos en cuadros una subscripcion");
            Assert.True(utils.existsElement(ProfileVars.playlist_video_order_list_but), "No se ve el boton de ordenar videos en lista una subscripcion");
            Assert.True(utils.existsElement(ProfileVars.playlist_video_subscription_I), "No se ha añadido el vieo a la playist");
            Assert.True(utils.existsElement(ProfileVars.playlist_video_play_all_but), "No se ve el boton de reproducir todo en la playist");

        }

        [Test]
        public void Test_35507()
        {
            //Prerequisitos: Crear una lista con un video
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.main_title);
            madrid.EnterText(ProfileVars.search_input_bar, "\"" + Strings.PLAYLIST_SUBSCRIPTION_QA_TEST1_I + "\"");
            madrid.DismissKeyboard();
            if (platform == Platform.Android)
            {
                Xamarin.UITest.Android.AndroidApp app = (Xamarin.UITest.Android.AndroidApp)madrid;
                app.PressUserAction();
            }
            utils.Sleep(3);
            madrid.Tap(ProfileVars.finder_Videos_destacados); //Perder el foco
            madrid.Tap(ProfileVars.finder_add_video_but);
            utils.Sleep(5);
            string newlist = "PL " + DateTime.Now.ToString();
            madrid.ClearText(ProfileVars.playlist_select_popup_imput);
            madrid.EnterText(ProfileVars.playlist_select_popup_imput, newlist);
            madrid.DismissKeyboard();
            utils.Sleep(3);
            madrid.Tap(ProfileVars.playlist_select_popup_save_but);
            utils.Sleep(2);
            //Step 2:Go to PlayLists
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
            utils.Go_To(ProfileVars.my_channel_but, ProfileVars.personal_area_view, 5, "No esta el boton de mi canal");
            madrid.Tap(ProfileVars.my_channel_but);
            Assert.True(utils.existsElement(ProfileVars.my_channel_page_title), "No se ve el titulo de la pagina de mi canal");
            Assert.True(utils.existsElement(ProfileVars.my_channel_playlist_tab), "No se ve la pestaña de playlist de la pagina de mi canal");
            madrid.Tap(ProfileVars.my_channel_playlist_tab);
            //Step 3:Click on a playlist.
            utils.Go_To(a => a.Id("tv_playlist_title").Text(newlist), ProfileVars.playlist_view, 5, "No se encuentra la lista");
            madrid.Tap(a => a.Id("tv_playlist_title").Text(newlist));
            utils.Sleep(4);
            Assert.True(utils.existsElement(ProfileVars.playlist_video_subscription_I), "No se ha añadido el vieo a la playist");
            Assert.True(utils.existsElement(ProfileVars.playlist_video_subscription_more_but), "No se ve el boton de more option en una subscripcion");
            //Step 4:Click "..." in a video
            madrid.Tap(ProfileVars.playlist_video_subscription_more_but);
            Assert.True(utils.existsElement(ProfileVars.playlist_subscription_more_popup_play), "No se ve el boton de reproducir en el popup de subscripciones");
            Assert.True(utils.existsElement(ProfileVars.playlist_subscription_more_popup_delete), "No se ve el boton de borrar en el popup de subscripciones");
            Assert.True(utils.existsElement(ProfileVars.playlist_subscription_more_popup_ok), "No se ve el boton de OK en el popup de subscripciones");
            //Step 5: Click on "Reproducir".
            madrid.Tap(ProfileVars.playlist_subscription_more_popup_play);
            utils.Sleep(2);
            //Assert.True(utils.existsElement(ProfileVars.playlist_video_player_one), "No se reproduce el video");


        }






        [Test]
        public void Test_35509()
        {
            //Prerequisitos: Crear dos listas
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
			utils.Sleep(3);
            utils.Go_To(ProfileVars.my_channel_but, ProfileVars.personal_area_view, 5, "No esta el boton de mi canal");
            madrid.Tap(ProfileVars.my_channel_but);
            madrid.Tap(ProfileVars.my_channel_playlist_tab);
            this.deleteAllList();
            madrid.Tap(ProfileVars.playlist_new_but);
            string newlist1 = "PL " + DateTime.Now.ToString();
            madrid.ClearText(ProfileVars.playlist_new_popup_combo);
            madrid.EnterText(ProfileVars.playlist_new_popup_combo, newlist1);
            madrid.DismissKeyboard();
            madrid.Tap(ProfileVars.playlist_new_popup_save_but);
            utils.Sleep(3);
            madrid.Tap(ProfileVars.playlist_new_but);
            string newlist2 = "PL " + DateTime.Now.ToString();
            madrid.ClearText(ProfileVars.playlist_new_popup_combo);
            madrid.EnterText(ProfileVars.playlist_new_popup_combo, newlist2);
            madrid.DismissKeyboard();
            madrid.Tap(ProfileVars.playlist_new_popup_save_but);
            utils.Sleep(3);
            madrid.Tap(MainMenuVars.menu_Main_but);
            // Step 2: Go to Finder
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.main_title);
            // Step 3:Search a free or a purchased video
            //            madrid.ClearText(ProfileVars.playlist_new_popup_combo);
            madrid.EnterText(ProfileVars.search_input_bar, "\"" + Strings.PLAYLIST_SUBSCRIPTION_QA_TEST1_I + "\"");
            madrid.DismissKeyboard();
            if (platform == Platform.Android)
            {
                Xamarin.UITest.Android.AndroidApp app = (Xamarin.UITest.Android.AndroidApp)madrid;
                app.PressUserAction();
            }
            utils.Sleep(3);

            //Step 4:Click on a Video
            madrid.Tap(ProfileVars.finder_Videos_destacados); //Perder el foco
            madrid.Tap(ProfileVars.video_title_test1);
            utils.Sleep(2);
            //Step 5:Click on "+ Añadir video a la lista de reproduccion" button.
            madrid.Tap(ProfileVars.finder_add_video_details_but);
            utils.Sleep(5);
            Assert.True(utils.existsElement(ProfileVars.playlist_select_popup_title), "No se ve el titulo en el popup de seleccionar playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_select_popup_subtitle), "No se ve el subtitulo en el combo del popup de seleccionar playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_select_popup_imput), "No se ve el imput en el popup de seleccionar playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_select_popup_save_but), "No se ve el boton guardar en el popup de seleccionar playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_select_popup_cancel_but), "No se ve el boton cancelar en el popup de seleccionar playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_select_popup_cancel_but), "No se ve el boton cancelar en el popup de seleccionar playlist");

            //Step 6:Select an existing playlist "PlaylistA"and press on "Añadir" button 
            madrid.Tap(a => a.Id("tv_playlist_title").Text(newlist1));
            utils.Sleep(3);
            madrid.Tap(ProfileVars.playlist_select_popup_save_but);
            utils.Sleep(3);
            //Step 7:Go to PlayLists
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
            utils.Go_To(ProfileVars.my_channel_but, ProfileVars.personal_area_view, 5, "No esta el boton de mi canal");
            madrid.Tap(ProfileVars.my_channel_but);
            Assert.True(utils.existsElement(ProfileVars.my_channel_page_title), "No se ve el titulo de la pagina de mi canal");
            Assert.True(utils.existsElement(ProfileVars.my_channel_playlist_tab), "No se ve la pestaña de playlist de la pagina de mi canal");
            madrid.Tap(ProfileVars.my_channel_playlist_tab);
            //Step 8:Open the selected "PlaylistA"
            utils.Go_To(a => a.Id("tv_playlist_title").Text(newlist1), ProfileVars.playlist_view, 5, "No se encuentra la lista creada");
            madrid.Tap(a => a.Id("tv_playlist_title").Text(newlist1));
            utils.Sleep(4);
            Assert.True(utils.existsElement(ProfileVars.playlist_video_subscription_I), "No se ha añadido el vieo a la playist");
            // Step 9: Go to Finder
            madrid.Tap(MainMenuVars.menu_Main_but);
            madrid.Tap(MainMenuVars.menu_Main_but);

            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.main_title);
            // Step 10:Search the same video added to "PlaylistA"
            madrid.EnterText(ProfileVars.search_input_bar, "\"" + Strings.PLAYLIST_SUBSCRIPTION_QA_TEST1_I + "\"");
            madrid.DismissKeyboard();
            if (platform == Platform.Android)
            {
                Xamarin.UITest.Android.AndroidApp app = (Xamarin.UITest.Android.AndroidApp)madrid;
                app.PressUserAction();
            }
            utils.Sleep(3);

            //Step 11:Click on a Video
            madrid.Tap(ProfileVars.finder_Videos_destacados); //Perder el foco
            madrid.Tap(ProfileVars.video_title_test1);
            utils.Sleep(2);
            //Step 12:Click on "+ Añadir video a la lista de reproduccion" button.
            madrid.Tap(ProfileVars.finder_add_video_details_but);
            utils.Sleep(5);
            Assert.True(utils.existsElement(ProfileVars.playlist_select_popup_title), "No se ve el titulo en el popup de seleccionar playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_select_popup_subtitle), "No se ve el subtitulo en el combo del popup de seleccionar playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_select_popup_imput), "No se ve el imput en el popup de seleccionar playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_select_popup_save_but), "No se ve el boton guardar en el popup de seleccionar playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_select_popup_cancel_but), "No se ve el boton cancelar en el popup de seleccionar playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_select_popup_cancel_but), "No se ve el boton cancelar en el popup de seleccionar playlist");

            //Step 13:Select an existing playlist "PlaylistB"and press on "Añadir" button 
            madrid.Tap(a => a.Id("tv_playlist_title").Text(newlist2));
            utils.Sleep(3);
            madrid.Tap(ProfileVars.playlist_select_popup_save_but);
            utils.Sleep(3);
            //Step 14:Go to PlayLists
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
            utils.Go_To(ProfileVars.my_channel_but, ProfileVars.personal_area_view, 5, "No esta el boton de mi canal");
            madrid.Tap(ProfileVars.my_channel_but);
            Assert.True(utils.existsElement(ProfileVars.my_channel_page_title), "No se ve el titulo de la pagina de mi canal");
            Assert.True(utils.existsElement(ProfileVars.my_channel_playlist_tab), "No se ve la pestaña de playlist de la pagina de mi canal");
            madrid.Tap(ProfileVars.my_channel_playlist_tab);
            //Step 15:Open the selected "PlaylistB"
            utils.Go_To(a => a.Id("tv_playlist_title").Text(newlist2), ProfileVars.playlist_view, 5, "No se encuentra la lista creada");
            madrid.Tap(a => a.Id("tv_playlist_title").Text(newlist2));
            utils.Sleep(4);
            Assert.True(utils.existsElement(ProfileVars.playlist_video_subscription_I), "No se ha añadido el vieo a la playist");
            //Step 16: Go Back
            madrid.Tap(MainMenuVars.menu_Main_but);
            //Step 17:Open "PlaylistA"
            utils.Go_To(a => a.Id("tv_playlist_title").Text(newlist1), ProfileVars.playlist_view, 5, "No se encuentra la lista creada");
            madrid.Tap(a => a.Id("tv_playlist_title").Text(newlist1));
            utils.Sleep(4);
            Assert.True(utils.existsElement(ProfileVars.playlist_video_subscription_I), "No se ha añadido el vieo a la playist");
        }

        [Test]
        public void Test_35531()
        {
            //Step 2:Go to PlayLists
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
			utils.Sleep(3);
            utils.Go_To(ProfileVars.my_channel_but, ProfileVars.personal_area_view, 5, "No esta el boton de mi canal");
            madrid.Tap(ProfileVars.my_channel_but);
            Assert.True(utils.existsElement(ProfileVars.my_channel_page_title), "No se ve el titulo de la pagina de mi canal");
            Assert.True(utils.existsElement(ProfileVars.my_channel_playlist_tab), "No se ve la pestaña de playlist de la pagina de mi canal");
            madrid.Tap(ProfileVars.my_channel_playlist_tab);
            //Step 3:Click on "+ Nueva Lista" button
            this.deleteAllList();
            Assert.True(utils.existsElement(ProfileVars.playlist_new_but), "No se ve el boton de nueva playlist de la pagina de mi canal");
            madrid.Tap(ProfileVars.playlist_new_but);
            Assert.True(utils.existsElement(ProfileVars.playlist_new_popup), "No se ve el popup de nueva playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_new_popup_title), "No se ve el titulo en el popup de nueva playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_new_popup_combo_title), "No se ve el titulo en el combo del popup de nueva playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_new_popup_combo), "No se ve el imput en el combo del popup de nueva playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_new_popup_advice), "No se ve el primer mensaje en el popup de nueva playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_new_popup_save_finder_but), "No se ve el boton guardar e ir al buscador en el popup de nueva playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_new_popup_advice2), "No se ve el segndo mensaje en el popup de nueva playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_new_popup_save_but), "No se ve el boton guardar en el popup de nueva playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_new_popup_cancel_but), "No se ve el boton cancelar en el popup de nueva playlist");
            //Step 4: Fill the "Titulo" field and press on "Guardar e ir al buscador" button
            string newlist = "PL " + DateTime.Now.ToString();
            madrid.ClearText(ProfileVars.playlist_new_popup_combo);
            madrid.EnterText(ProfileVars.playlist_new_popup_combo, newlist);
            madrid.DismissKeyboard();
            madrid.Tap(ProfileVars.playlist_new_popup_save_finder_but);
            Assert.True(utils.existsElement(FinderVars.main_title), "No se ve la pagina de finder");
            //Step 5:Go to PlayLists
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
            utils.Go_To(ProfileVars.my_channel_but, ProfileVars.personal_area_view, 5, "No esta el boton de mi canal");
            madrid.Tap(ProfileVars.my_channel_but);
            Assert.True(utils.existsElement(ProfileVars.my_channel_page_title), "No se ve el titulo de la pagina de mi canal");
            Assert.True(utils.existsElement(ProfileVars.my_channel_playlist_tab), "No se ve la pestaña de playlist de la pagina de mi canal");
            madrid.Tap(ProfileVars.my_channel_playlist_tab);
            //Step 6: Check the playlist is created.
            Assert.True(utils.existsElement(ProfileVars.my_channel_page_title), "No se ve el titulo de la pagina de mi canal");
            utils.Go_To(a => a.Id("tv_playlist_title").Text(newlist), ProfileVars.playlist_view, 5, "No se encuentra la lista creada");

        }




        [Test]
		// Try add a not purchased video to a playlist from detail video
        public void Test_35880()
        {

            // Step 2: Go to Finder
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
			utils.Sleep(8);
            madrid.WaitForElement(FinderVars.main_title);
            // Step 3:Search a video not purchased
            madrid.EnterText(ProfileVars.search_input_bar, "\"" + Strings.PLAYLIST_NON_SUBSCRIPTION_GOL_LUCAS_VAZQUEZ + "\"");
			madrid.PressEnter();
            /*if (platform == Platform.Android)
            {
                Xamarin.UITest.Android.AndroidApp app = (Xamarin.UITest.Android.AndroidApp)madrid;
                app.PressUserAction();
            }*/
            utils.Sleep(3);
            //madrid.Tap(ProfileVars.finder_Videos_destacados); //Perder el foco
            madrid.Tap(ProfileVars.video_title_gol_lucas_vazquez);
            utils.Sleep(2);
            //Step 5:Click on "+ Añadir video a la lista de reproduccion" button.
            madrid.Tap(ProfileVars.finder_add_video_details_but);
            utils.Sleep(5);
            Assert.True(utils.existsElement(ProfileVars.playlist_purchase_popup_title), "No se ve el titulo del popup de comprar video");
            Assert.True(utils.existsElement(ProfileVars.playlist_purchase_popup_subtitle), "No se ve el subtitulo del popup de comprar videol");
            Assert.True(utils.existsElement(ProfileVars.playlist_purchase_popup_save_but), "No se ve el boton del popup de comprar video");
            //Step 5: Click on "OK" button
            madrid.Tap(ProfileVars.playlist_purchase_popup_save_but);
            utils.Sleep(2);
            Assert.True(utils.existsElement(ProfileVars.finder_Videos_details_title), "No se ve la pagina de detalles de video");
            Assert.True(utils.existsElement(ProfileVars.video_title_details_gol_lucas_vazquez), "No se ve el video buscado");
        }

        [Test]
        public void Test_35884()
        {

            // Step 2: Go to Finder
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
            madrid.WaitForElement(FinderVars.main_title);
            // Step 3:Search a video not purchased
            madrid.EnterText(ProfileVars.search_input_bar, "\"" + Strings.PLAYLIST_NON_SUBSCRIPTION_GOL_LUCAS_VAZQUEZ + "\"");
			utils.Sleep(3);
			madrid.PressEnter();
			//madrid.DismissKeyboard();
            /*if (platform == Platform.Android)
            {
                Xamarin.UITest.Android.AndroidApp app = (Xamarin.UITest.Android.AndroidApp)madrid;
                app.PressUserAction();
            }*/
            utils.Sleep(3);
            //Step 4: Click on the "+" button in the video
            //madrid.Tap(ProfileVars.finder_Videos_destacados); //Perder el foco
            madrid.Tap(ProfileVars.finder_add_video_but);

            utils.Sleep(5);
            Assert.True(utils.existsElement(ProfileVars.playlist_purchase_popup_title), "No se ve el titulo del popup de comprar video");
            Assert.True(utils.existsElement(ProfileVars.playlist_purchase_popup_subtitle), "No se ve el subtitulo del popup de comprar videol");
            Assert.True(utils.existsElement(ProfileVars.playlist_purchase_popup_save_but), "No se ve el boton del popup de comprar video");
            //Step 5: Click on "OK" button
            madrid.Tap(ProfileVars.playlist_purchase_popup_save_but);
            utils.Sleep(2);
            Assert.True(utils.existsElement(FinderVars.main_title), "No se ve la pagina de finder");
            Assert.True(utils.existsElement(ProfileVars.video_title_gol_lucas_vazquez), "No se ve el video buscado");
        }

        [Test]
        public void Test_36331()
        {
            //Step 2:Go to PlayLists
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
			utils.Sleep(3);
            utils.Go_To(ProfileVars.my_channel_but, ProfileVars.personal_area_view, 5, "No esta el boton de mi canal");
            madrid.Tap(ProfileVars.my_channel_but);
            Assert.True(utils.existsElement(ProfileVars.my_channel_page_title), "No se ve el titulo de la pagina de mi canal");
            Assert.True(utils.existsElement(ProfileVars.my_channel_playlist_tab), "No se ve la pestaña de playlist de la pagina de mi canal");
            madrid.Tap(ProfileVars.my_channel_playlist_tab);
            //Step 3:Click on any Playlist
            if (!utils.existsElement(ProfileVars.playlist_more_options_but))
            {
                string playList = "PL " + DateTime.Now.ToString();
                Assert.True(utils.existsElement(ProfileVars.playlist_new_but), "No se ve el boton de nueva playlist de la pagina de mi canal");
                madrid.Tap(ProfileVars.playlist_new_but);
                madrid.ClearText(ProfileVars.playlist_new_popup_combo);
                madrid.EnterText(ProfileVars.playlist_new_popup_combo, playList);
                madrid.DismissKeyboard();
                madrid.Tap(ProfileVars.playlist_new_popup_save_but);
                utils.Sleep(5);
            }
            madrid.Tap(ProfileVars.playlist_title_random);
            utils.Sleep(3);
            //Step 4:Click on "Editar lista de reproducción" link  
            madrid.Tap(ProfileVars.playlist_details_edit);
            utils.Sleep(3);
            Assert.True(utils.existsElement(ProfileVars.playlist_edit_popup_title), "No se ve el titulo en el popup de editar playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_edit_popup_subtitle), "No se ve el subtitulo en el popup de editar playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_edit_popup_combo), "No se ve el imput en el combo del popup de editar playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_edit_popup_delete_but), "No se ve el boton borrar en el popup de editar playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_edit_popup_save_but), "No se ve el boton guardar en el popup de editar playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_edit_popup_cancel_but), "No se ve el boton cancelar en el popup de editar playlist");
            //Step 5:Click on Borrar lista de reproducción
            String name = madrid.Query(ProfileVars.playlist_edit_popup_combo)[0].Text;
            madrid.Tap(ProfileVars.playlist_edit_popup_delete_but);
            utils.Sleep(3);
            Assert.True(utils.existsElement(ProfileVars.playlist_delete_popup_msg), "No se ve el titulo en el popup de borrar playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_delete_popup_save_but), "No se ve el boton de guardar en el popup de borrar playlist");
            Assert.True(utils.existsElement(ProfileVars.playlist_delete_popup_cancel_but), "No se ve el boton de cancelar en el popup de borrar playlist");
            //Step 6:Click on "Borrar"
            madrid.Tap(ProfileVars.playlist_delete_popup_save_but);
            utils.Sleep(5);
            Assert.False(utils.existsElement(a => a.Id("tv_playlist_title").Text(name)), "No se ha borrado la lista");

        }
     }
}
