using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace RealMadrid_UITest.Tests{
    //[TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    class UserProfileStatusTests
    {
        IApp madrid;
        Utilities utils;
        Platform platform;



        public UserProfileStatusTests(Platform platform)
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

		[Test]
		// Buy subscription through my channel
		public void Test_34244()
		{
			if (utils._device == "Tablet")
			{
				// Step 2:Go to Status placeholder.
				utils.Sleep(5);
				madrid.Tap(NavigationBarVars.navbar_Profile_but);
				//madrid.ScrollDownTo(ProfileVars.status_title);
				// Step 3: Click on "My Channel" icon
				madrid.WaitForElement(ProfileVars.status_title);
				Assert.True(utils.existsElement(ProfileVars.status_title), "No se ve status en el perfil");
				//madrid.ScrollDown();
				//madrid.ScrollDownTo(ProfileVars.my_channel_but);
				utils.Sleep(5);
				madrid.Tap(ProfileVars.my_channel_but);
				madrid.WaitForElement(ProfileVars.my_channel_page_title);
				Assert.True(utils.existsElement(ProfileVars.my_channel_page_title), "No se ve el titulo de la pagina de mi canal");
				Assert.True(utils.existsElement(ProfileVars.my_channel_packs_tab), "No se ve la pestaña de packs de la pagina de mi canal");
				Assert.True(utils.existsElement(ProfileVars.my_channel_playlist_tab), "No se ve la pestaña de playlist de la pagina de mi canal");
				//Assert.True(utils.existsElement(ProfileVars.my_channel_page_number), "No se ve el numero de packs de la pagina de mi canal");
				Assert.True(utils.existsElement(ProfileVars.my_channel_spinner), "No se ve el spinner de la pagina de mi canal");
				Assert.True(utils.existsElement(ProfileVars.my_channel_store_but), "No se ve el boton de ir a la tienda de la pagina de mi canal");
				// Step 4: Click on "Go to store" icon
				madrid.Tap(ProfileVars.my_channel_store_but);
				madrid.WaitForElement(VirtualStoreVars.VirtualStore_HeaderTitle);
				Assert.True(utils.existsElement(VirtualStoreVars.VirtualStore_HeaderTitle), "No se ve el titulo de la pagina de mi tienda virtual");
				madrid.ScrollDownTo(VirtualStoreVars.Videos_section_title);
				// Step 5: Click on Close button
				madrid.Tap(VirtualStoreVars.VirtualStore_page_GoBack);
				madrid.WaitForElement(ProfileVars.my_channel_page_title);
				Assert.True(utils.existsElement(ProfileVars.my_channel_page_title), "No se ve el titulo de la pagina de mi canal");

			}
			else
			{
				// Step 2:Go to Status placeholder.
				utils.Sleep(5);
				madrid.Tap(NavigationBarVars.navbar_Profile_but);
				madrid.ScrollDownTo(ProfileVars.status_title);
				// Step 3: Click on "My Channel" icon
				madrid.ScrollDown();
				madrid.ScrollDownTo(ProfileVars.my_channel_but);
				utils.Sleep(2);
				madrid.Tap(ProfileVars.my_channel_but);
				madrid.WaitForElement(ProfileVars.my_channel_page_title);
				Assert.True(utils.existsElement(ProfileVars.my_channel_page_title), "No se ve el titulo de la pagina de mi canal");
				Assert.True(utils.existsElement(ProfileVars.my_channel_packs_tab), "No se ve la pestaña de packs de la pagina de mi canal");
				Assert.True(utils.existsElement(ProfileVars.my_channel_playlist_tab), "No se ve la pestaña de playlist de la pagina de mi canal");
				//Assert.True(utils.existsElement(ProfileVars.my_channel_page_number), "No se ve el numero de packs de la pagina de mi canal");
				Assert.True(utils.existsElement(ProfileVars.my_channel_spinner), "No se ve el spinner de la pagina de mi canal");
				Assert.True(utils.existsElement(ProfileVars.my_channel_store_but), "No se ve el boton de ir a la tienda de la pagina de mi canal");
				// Step 4: Click on "Go to store" icon
				madrid.Tap(ProfileVars.my_channel_store_but);
				madrid.WaitForElement(VirtualStoreVars.VirtualStore_HeaderTitle);
				Assert.True(utils.existsElement(VirtualStoreVars.VirtualStore_HeaderTitle), "No se ve el titulo de la pagina de mi tienda virtual");
				madrid.ScrollDownTo(VirtualStoreVars.Videos_section_title);
				// Step 5: Click on Close button
				madrid.Tap(VirtualStoreVars.VirtualStore_page_GoBack);
				madrid.WaitForElement(ProfileVars.my_channel_page_title);
				Assert.True(utils.existsElement(ProfileVars.my_channel_page_title), "No se ve el titulo de la pagina de mi canal");

			}
		}

        [Test]
		// My Channel
        public void Test_34259()
        {
            // Step 2:Go to Status placeholder.
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
			//madrid.ScrollDownTo(ProfileVars.status_title);
		
            // Step 3: Click on "My Channel" icon
            //madrid.ScrollDown();
			//madrid.ScrollDownTo(ProfileVars.my_channel_but);
            madrid.Tap(ProfileVars.my_channel_but);
			madrid.WaitForElement(ProfileVars.my_channel_page_title);
            Assert.True(utils.existsElement(ProfileVars.my_channel_page_title), "No se ve el titulo de la pagina de mi canal");
            Assert.True(utils.existsElement(ProfileVars.my_channel_packs_tab), "No se ve la pestaña de packs de la pagina de mi canal");
            Assert.True(utils.existsElement(ProfileVars.my_channel_playlist_tab), "No se ve la pestaña de playlist de la pagina de mi canal");
            //Assert.True(utils.existsElement(ProfileVars.my_channel_page_number), "No se ve el numero de packs de la pagina de mi canal");
            Assert.True(utils.existsElement(ProfileVars.my_channel_spinner), "No se ve el spinner de la pagina de mi canal");
            Assert.True(utils.existsElement(ProfileVars.my_channel_store_but), "No se ve el boton de ir a la tienda de la pagina de mi canal");
            
			// Step 4:Click on the category filter and select a category
			madrid.WaitForElement(ProfileVars.my_channel_spinner);
            madrid.Tap(ProfileVars.my_channel_spinner);
			//madrid.Tap(VirtualStoreVars.VirtualStore_Videos_AllCategories_ComboBox);
			utils.Sleep(2);
			madrid.Tap(VirtualStoreVars.VirtualStore_Videos_Goals_ComboBox);
            //madrid.Tap(VirtualStoreVars.VirtualStore_Videos_Goals_ComboBox);
			madrid.WaitForElement(VirtualStoreVars.VirtualStore_Videos_OportunidadesCR7);
			Assert.True(utils.existsElement(VirtualStoreVars.VirtualStore_Videos_OportunidadesCR7), "No se ve el nombre del video");
            
			// Step 5: Click on "Go to store" icon
            madrid.Tap(ProfileVars.my_channel_store_but);
			madrid.WaitForElement(VirtualStoreVars.VirtualStore_HeaderTitle);
            Assert.True(utils.existsElement(VirtualStoreVars.VirtualStore_HeaderTitle), "No se ve el titulo de la pagina de mi tienda virtual");
            //utils.Go_To(VirtualStoreVars.Videos_section_title, VirtualStoreVars.VirtualStore_Videos_subscriptions_view, 5, "No esta la sexxion de los goles en la tienda virtual");
			madrid.ScrollDownTo(VirtualStoreVars.Videos_section_title);

			// Step 6: Go back in the Virtual Store
            madrid.Tap(VirtualStoreVars.VirtualStore_page_GoBack);
            madrid.WaitForElement(ProfileVars.my_channel_page_title);
			Assert.True(utils.existsElement(ProfileVars.my_channel_page_title), "No se ve el titulo de la pagina de mi canal");
            
			// Step 7: Click a subscription
            madrid.Tap(VirtualStoreVars.VirtualStore_Videos_OportunidadesCR7);
            madrid.WaitForElement(VirtualStoreVars.VirtualStore_Videos_OportunidadesCR7);
			Assert.True(utils.existsElement(VirtualStoreVars.VirtualStore_Videos_Subscription), "No se ve el titulo de la pagina de la subscripcion");

			// Step 8: Click on favorite icon of a video
			madrid.WaitForElement(VirtualStoreVars.VirtualStore_Videos_Subscription_likes_Off);
            Assert.True(utils.existsElement(VirtualStoreVars.VirtualStore_Videos_Subscription_likes_Off), "No se ve el numero de favoritos de la pagina de la subscripcion");
            AppResult[] result;
            result = madrid.Query(VirtualStoreVars.VirtualStore_Videos_Subscription_likes_Off);
            string value = result[0].Text;
            madrid.Tap(VirtualStoreVars.VirtualStore_Videos_Subscription_like_Off);
           	utils.Sleep(3);
            result = madrid.Query(VirtualStoreVars.VirtualStore_Videos_Subscription_likes);
            string newValue = result[0].Text;
            Assert.False(value.Equals(newValue), "No varia el numero de favoritos");
			madrid.Tap(VirtualStoreVars.VirtualStore_Videos_Subscription_like);

			// Step 9: Click a video
            /*madrid.Tap(ProfileVars.MyChannel_page_GoBack);
            madrid.Tap(VirtualStoreVars.VirtualStore_Videos_AllCategories_ComboBox);
            madrid.Tap(VirtualStoreVars.VirtualStore_Videos_Higth_ComboBox);
            madrid.Tap(VirtualStoreVars.VirtualStore_Videos_QATest1);
            madrid.Tap(VirtualStoreVars.VirtualStore_Videos_Subscription_play);
            utils.Sleep(2);
            Assert.True(utils.existsElement(VirtualStoreVars.VirtualStore_Videos_player), "No se ve el reproductor de videos");
            */


        }
		/*
        [Test]
        public void Test_34253()
        {
            // Step 2:Go to profile
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
            utils.Sleep(3);
            Assert.True(utils.existsElement(ProfileVars.profile_account_avatar_but), "No se muestra el avatar en el account placeholder");
            Assert.True(utils.existsElement(ProfileVars.profile_account_name), "No se muestra el nombre en el account placeholder");
            Assert.True(utils.existsElement(ProfileVars.link_social_but), "No se muestra el boton de links en el account placeholder");
            Assert.True(utils.existsElement(ProfileVars.link_madridista_but), "No se muestra el carne de socio en el account placeholder");
            Assert.True(utils.existsElement(ProfileVars.avatar_img), "No se muestra el avatar en el account placeholder");
            Assert.True(utils.existsElement(ProfileVars.edit_avatar_but), "No se muestra el boton de editar avatar en el account placeholder");
            Assert.True(utils.existsElement(ProfileVars.refresh_avatar_but), "No se muestra el boton de actualizar avatar en el account placeholder");
            madrid.Tap(ProfileVars.link_social_but);
            Assert.True(utils.existsElement(ProfileVars.link_facebook_but), "No se muestra el link de facebook en el account placeholder");
            Assert.True(utils.existsElement(ProfileVars.link_twitter_but), "No se muestra el link de twitter en el account placeholder");
            Assert.True(utils.existsElement(ProfileVars.link_google_but), "No se muestra el link de google en el account placeholder");
            Assert.True(utils.existsElement(ProfileVars.link_microsoft_but), "No se muestra el link de microsoft en el account placeholder");
        }
		*/
        [Test]
		// See Status placeholder
        public void Test_34340()
        {
			if (utils._device == "Tablet")
			{
				// Step 2:Go to profile
				madrid.Tap(NavigationBarVars.navbar_Profile_but);

				// Step 3:Go to Status placeholder.
				//madrid.ScrollDownTo(ProfileVars.status_title);
				utils.Sleep(4);
				madrid.WaitForElement(ProfileVars.status_title);
				Assert.True(utils.existsElement(ProfileVars.status_title));

				// Step 4:Check that information is accurate.
				Assert.True(utils.existsElement(ProfileVars.experiencia_but));
				Assert.True(utils.existsElement(ProfileVars.monedas_but_Tablet));
				Assert.True(utils.existsElement(ProfileVars.my_channel_but));
				Assert.True(utils.existsElement(ProfileVars.virtual_goods_but));
				Assert.True(utils.existsElement(ProfileVars.ranking_but_Tablet));
				Assert.True(utils.existsElement(ProfileVars.checkin_but_Tablet));
				Assert.True(utils.existsElement(ProfileVars.badges_but));
				Assert.True(utils.existsElement(ProfileVars.groups_but_Tablet));
				//Assert.True(utils.existsElement(ProfileVars.retos_but));
				Assert.True(utils.existsElement(ProfileVars.me_gusta_but));
			}
			else 
			{
				// Step 2:Go to profile
				madrid.Tap(NavigationBarVars.navbar_Profile_but);

				// Step 3:Go to Status placeholder.
				madrid.ScrollDownTo(ProfileVars.status_title);

				// Step 4:Check that information is accurate.
				madrid.ScrollDownTo(ProfileVars.experiencia_but);
				madrid.ScrollDownTo(ProfileVars.monedas_but);
				madrid.ScrollDownTo(ProfileVars.my_channel_but);
				madrid.ScrollDownTo(ProfileVars.virtual_goods_but);
				madrid.ScrollDownTo(ProfileVars.ranking_but);
				madrid.ScrollDownTo(ProfileVars.checkin_but);
				madrid.ScrollDownTo(ProfileVars.badges_but);
				madrid.ScrollDownTo(ProfileVars.groups_but);
				madrid.ScrollDownTo(ProfileVars.retos_but);
				//utils.Go_To(ProfileVars.friends_but, ProfileVars.personal_area_view, 5, "No esta el boton de Amigos");
				madrid.ScrollDownTo(ProfileVars.me_gusta_but);
			}
		}

		[Test]
		// Experience
		public void Test_34407()
		{
			if (utils._device == "Tablet")
			{
				// Step 2:Go to profile
				madrid.Tap(NavigationBarVars.navbar_Profile_but);

				// Step 3:Go to Status placeholder.
				//madrid.ScrollDownTo(ProfileVars.status_title);
				Assert.True(utils.existsElement(ProfileVars.status_title), "No se ve status en el perfil");
				// Step 4:Tap in Experience icon.
				//madrid.ScrollDownTo(ProfileVars.experiencia_but);
				madrid.Tap(ProfileVars.experiencia_but);
				madrid.WaitForElement(ProfileVars.experience_page_title);
				Assert.True(utils.existsElement(ProfileVars.experience_page_title), "No se ve el titulo de la pagina de experiencia");
				madrid.WaitForElement(ProfileVars.experience_subtotal);
				Assert.True(utils.existsElement(ProfileVars.experience_subtotal), "No se ve el valor de la experiencia");
				Assert.True(utils.existsElement(ProfileVars.experience_coin), "No se ve la moneda de la experiencia");
				Assert.True(utils.existsElement(ProfileVars.experience_time), "No se ve la fecha de la experiencia");
				madrid.WaitForElement(ProfileVars.experience_value);
				Assert.True(utils.existsElement(ProfileVars.experience_value), "No se ve el texto de la experiencia");
			}
			else
			{ 
				// Step 2:Go to profile
				madrid.Tap(NavigationBarVars.navbar_Profile_but);

				// Step 3:Go to Status placeholder.
				madrid.ScrollDownTo(ProfileVars.status_title);
				// Step 4:Tap in Experience icon.
				madrid.ScrollDownTo(ProfileVars.experiencia_but);
				madrid.Tap(ProfileVars.experiencia_but);
				madrid.WaitForElement(ProfileVars.experience_page_title);
				Assert.True(utils.existsElement(ProfileVars.experience_page_title), "No se ve el titulo de la pagina de experiencia");
				madrid.WaitForElement(ProfileVars.experience_subtotal);
				Assert.True(utils.existsElement(ProfileVars.experience_subtotal), "No se ve el valor de la experiencia");
				Assert.True(utils.existsElement(ProfileVars.experience_coin), "No se ve la moneda de la experiencia");
				Assert.True(utils.existsElement(ProfileVars.experience_time), "No se ve la fecha de la experiencia");
				madrid.WaitForElement(ProfileVars.experience_value);
				Assert.True(utils.existsElement(ProfileVars.experience_value), "No se ve el texto de la experiencia");
			}
		}
        [Test]
		// Share status options
        public void Test_35497()
        {
            // Step 2:Go to profile
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
            // Step 3:Go to Status placeholder.
            //madrid.ScrollDown();
			//madrid.ScrollDown();
            // Step 4:Click on Share icon
			madrid.ScrollDownTo(ProfileVars.share_but);
            madrid.Tap(ProfileVars.share_but);
			madrid.WaitForElement(ProfileVars.share_popup_title);
            Assert.True(utils.existsElement(ProfileVars.share_popup_title), "No se muestra el pop-up de compartir");
            Assert.True(utils.existsElement(ProfileVars.share_fb_but), "No se muestra el boton de facebook");
            Assert.True(utils.existsElement(ProfileVars.share_twitter_but), "No se muestra el boton de twitter");
            Assert.True(utils.existsElement(ProfileVars.share_whatsapp_but), "No se muestra el boton de whatsapp");
            Assert.True(utils.existsElement(ProfileVars.share_google_but), "No se muestra el boton de google");
            Assert.True(utils.existsElement(ProfileVars.share_mail_but), "No se muestra el boton de email");
            Assert.True(utils.existsElement(ProfileVars.share_more_but), "No se muestra el boton de more options");
            Assert.True(utils.existsElement(ProfileVars.share_ok_but), "No se muestra el boton de OK");
            //Step 5: Click on "..." icon
            // No se puede autoamtizar la ventana nativa de apps
        }

        [Test]
		// Favorites design page
        public void Test_35684()
        {
            // Step 2:Go to profile
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
            // Step 3:Scroll down to status placeholder
            madrid.ScrollDownTo(ProfileVars.status_title);
            // Step 4:Tap on favorites icon
            madrid.ScrollDownTo(ProfileVars.me_gusta_but);
            madrid.Tap(ProfileVars.me_gusta_but);
			madrid.WaitForElement(ProfileVars.profile_favourites_noticias_text);
            Assert.True(utils.existsElement(ProfileVars.profile_favourites_noticias_text), "No se muestra la pestaña de noticias");
            Assert.True(utils.existsElement(ProfileVars.profile_favourites_videos_text), "No se muestra la pestaña de videos");
			Assert.True(utils.existsElement(ProfileVars.profile_favourites_Partidos_text), "No se muestra la pestaña de partidos");
            //Assert.True(utils.existsElement(ProfileVars.profile_favourites_noticias_page), "No se muestra la pagina de noticias selecccionada");
            madrid.SwipeRightToLeft();
			madrid.SwipeRightToLeft();
			madrid.SwipeRightToLeft();
			Assert.True(utils.existsElement(ProfileVars.profile_favourites_Subscripciones_text), "No se muestra la pestaña de subscripciones");

			// Step 5:Tap on back button
            madrid.Tap(ProfileVars.my_like_page_GoBack);
			madrid.WaitForElement(ProfileVars.me_gusta_but);
            Assert.True(utils.existsElement(ProfileVars.me_gusta_but), "No se encuentra el boton de mis me gusta");
        }
		/*
        [Test]
		// Gamification - Virtual Goods
        public void Test_35693()
        {
            // Step 2:Go to profile
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
            // Step 3:Scroll to Status and click on "Virtual Goods" icon.
            madrid.ScrollDownTo(ProfileVars.virtual_goods_but);
            madrid.Tap(ProfileVars.virtual_goods_but);
            utils.Sleep(2);
            Assert.True(utils.existsElement(ProfileVars.virtual_goods_title), "No se muestra la ventana de bienes virtuales");
			madrid.ScrollDownTo(ProfileVars.virtual_goods_astosch_section);
            //utils.Go_To(ProfileVars.virtual_goods_image, ProfileVars.virtual_goods_sections_container, 5, "No se encuentra ninguna imagen de un bien virtual");
            madrid.ScrollDownTo(ProfileVars.virtual_goods_zapas_title);
           	madrid.ScrollDownTo(ProfileVars.virtual_goods_zapas_number);
            Assert.True(utils.existsElement(ProfileVars.virtual_goods_spinner), "No se muestra el spinner de secciones");
            madrid.Tap(ProfileVars.virtual_goods_spinner);
            madrid.ScrollDownTo(ProfileVars.virtual_goods_spinner_astosch);
            madrid.Tap(ProfileVars.virtual_goods_spinner_astosch);
            utils.Sleep(2);
            // Step 4:Click on a purchased "Virtual Good".
            madrid.Tap(ProfileVars.virtual_goods_zapas_title);
            utils.Sleep(2);
            Assert.True(utils.existsElement(ProfileVars.virtual_goods_details_title), "No se muestra el titulo de la pagina de detalles");
            Assert.True(utils.existsElement(ProfileVars.virtual_goods_details_image), "No se muestra la imagen en la pagina de detalles");
            Assert.True(utils.existsElement(ProfileVars.virtual_goods_details_name), "No se muestra el nombre del bien en la pagina de detalles");
            Assert.True(utils.existsElement(ProfileVars.virtual_goods_details_number), "No se muestra el numero del bien en la pagina de detalles");
            Assert.True(utils.existsElement(ProfileVars.virtual_goods_details_consiguelo_but), "No se muestra el boton del bien en la pagina de detalles");
            // Step 5: Tap on 'Back' button.
            madrid.Tap(MainMenuVars.menu_Main_but);
            utils.Sleep(2);
            Assert.True(utils.existsElement(ProfileVars.virtual_goods_title), "No se muestra la ventana de bienes virtuales");
        }*/

        [Test]
        public void Test_35699()
        {
            // Step 2:Go to profile
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
            // Step 3: Scroll to Status and click on "Medals" icon.
			madrid.ScrollDownTo(ProfileVars.badges_but);
            madrid.Tap(ProfileVars.badges_but);
            utils.Sleep(4);
            Assert.True(utils.existsElement(ProfileVars.badge_reto100_title), "No esta la medalla de reto 100 ");
            Assert.True(utils.existsElement(ProfileVars.badges_image), "No esta una imagen de medalla ");
            Assert.True(utils.existsElement(ProfileVars.badges_count), "No esta el contador de medallas ");
            Assert.True(utils.existsElement(ProfileVars.badges_coins), "No esta el contador de monedas ");
            Assert.True(utils.existsElement(ProfileVars.badges_points), "No esta el contador de puntos ");
            // Step 4: Click on an achievement.
            madrid.Tap(ProfileVars.badge_reto50_title);
            Assert.True(utils.existsElement(ProfileVars.badges_popup_title), "No esta el pop up de medallas ");
            Assert.True(utils.existsElement(ProfileVars.badges_popup_img), "No esta la imagen en pop up de medallas ");
            Assert.True(utils.existsElement(ProfileVars.badges_popup_coins), "No estan las monedas en el pop up de medallas ");
            Assert.True(utils.existsElement(ProfileVars.badges_popup_points), "No estan los puntos en el pop up de medallas ");
            Assert.True(utils.existsElement(ProfileVars.badges_popup_ok_but), "No esta el boton de ok en el pop up de medallas ");
        }

        [Test]
        public void Test_35702()
        {
            // Step 2:Go to profile
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
            // Step 3:Scroll to Status and click on "Coins" icon.
            madrid.ScrollDownTo(ProfileVars.monedas_but);
            madrid.Tap(ProfileVars.monedas_but);
            utils.Sleep(4);
            Assert.True(utils.existsElement(ProfileVars.coins_page_title), "No se ve el titulo de la pagina de monedas");
            madrid.ScrollDownTo(ProfileVars.coins_title);
			madrid.ScrollDownTo(ProfileVars.coins_description);
            Assert.True(utils.existsElement(ProfileVars.coins_page_icon), "No se ve el icono de las monedas");
            Assert.True(utils.existsElement(ProfileVars.coins_time), "No se ve el tiempo de las monedas");
            Assert.True(utils.existsElement(ProfileVars.coins_subtotal), "No se ve el subtotal de las monedas");
            // Step 4:Click on a "Coin record".
            madrid.Tap(ProfileVars.coins_description);
            //Assert.True(utils.existsElement(ProfileVars.coins_popup_title), "No se ve el titulo del popup de las monedas");
            Assert.True(utils.existsElement(ProfileVars.coins_popup_subtitle), "No se ve el subitulo del popup de las monedas");
            Assert.True(utils.existsElement(ProfileVars.coins_popup_image), "No se ve el icono de las monedas");
            Assert.True(utils.existsElement(ProfileVars.coins_popup_description), "No se ve la descripcion del popup de las monedas");
            Assert.True(utils.existsElement(ProfileVars.coins_popup_ok_but), "No se ve el boton ok del popup de las monedas");
        }

    }
}
