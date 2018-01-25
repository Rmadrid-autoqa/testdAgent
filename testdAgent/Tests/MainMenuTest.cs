using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest;

namespace RealMadrid_UITest.Tests{
    //[TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]


    public class MainMenuTest {
        IApp madrid;
        Utilities utils;
        Platform platform;



        public MainMenuTest(Platform platform) {
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
//            utils.Enter_Home();
//            utils.Sign_Off();
        }
        
		/*[Test]
		public void MiTest()
		{
			madrid.Repl();
		}*/

        [Test]
        public void Test_34320() {
            madrid.Tap(MainMenuVars.menu_Main_but);
            Assert.True(madrid.Query(MainMenuVars.menu_Main_Container).Length > 0, "No se muestra Main Menu");
            madrid.SwipeRightToLeft();
        }



        [Test]
        public void Test_38723(){
            //noticias
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_items_id);
            Assert.True(madrid.Query(MainMenuVars.noticias_Title).Length > 0, "No se muestra la pagina de Noticias");
        }

        [Test]
        public void Test_38724()
        {
            //Tienda
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Tienda_but);
			utils.Sleep(3);
			madrid.WaitForElement(MainMenuVars.web_View);
            Assert.True(madrid.Query(MainMenuVars.web_View).Length > 0, "No se muestra la webView de tienda");
        }

		[Test]
		public void Test_38725()
		{
			//Tickets
			if (utils._device == "Tablet")
			{
                
				utils.Access_Tab_Main_Menu(MainMenuVars.menu_Tickets_but_Tablet);
				madrid.WaitForElement(MainMenuVars.web_View);
				Assert.True(madrid.Query(MainMenuVars.web_View).Length > 0, "No se muestra la webView de tickets");
			}

			else
			{
				utils.Access_Tab_Main_Menu(MainMenuVars.menu_Tickets_but);
                madrid.Repl();
                madrid.WaitForElement(MainMenuVars.web_View);
				Assert.True(madrid.Query(MainMenuVars.web_View).Length > 0, "No se muestra la webView de tickets");

			}
		}
		[Test]
		public void Test_38726()
		{
			//Bernaveu Virtual
			if (utils._device == "Tablet")
			{
				utils.Access_Tab_Main_Menu(MainMenuVars.menu_Bernaveu_Virtual_but_Tablet);
				madrid.WaitForElement(MainMenuVars.web_View);
				Assert.True(madrid.Query(MainMenuVars.web_View).Length > 0, "No se muestra la webView de Bernaveu Virtual");
			}
			else
			{
				utils.Access_Tab_Main_Menu(MainMenuVars.menu_Bernaveu_Virtual_but);
				madrid.WaitForElement(MainMenuVars.web_View);
				Assert.True(madrid.Query(MainMenuVars.web_View).Length > 0, "No se muestra la webView de Bernaveu Virtual");
			}
		}

        [Test]
        public void Test_38727()
        {
            //Ficha Jugador
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Ficha_Jugador_but);
			madrid.WaitForElement(MainMenuVars.ficha_Jugador_Title);
            Assert.True(madrid.Query(MainMenuVars.ficha_Jugador_Title).Length > 0, "No se muestra la pagina de fichas de jugaor");
        }

        [Test]
        public void Test_38728()
        {
            //La decima
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_La_Decima_but);
            Assert.True(madrid.Query(MainMenuVars.la_Decima_Title).Length > 0, "No se muestra la ventana La decima");
        }

        [Test]
        public void Test_38729()
        {
            //Real Madrid TV
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Real_Madrid_TV_but);
            Assert.True(madrid.Query(MainMenuVars.video_Player).Length > 0, "No se muestra un reproductor de video en Real Madrid TV");
        }

        [Test]
        public void Test_38730()
        {
            //Chekin
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Checkin_but);
            Assert.True(madrid.Query(MainMenuVars.Checkin_Title).Length > 0, "No se muestra la pagina de Check-in");
        }

        [Test]
        public void Test_38731()
        {
            //Estaisticas
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Estadísticas_but);
            Assert.True(madrid.Query(MainMenuVars.estadísticas_Title).Length > 0, "No se muestra la pagina de Estadisticas");
        }

        [Test]
        public void Test_38732()
        {
            //Inbox
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Inbox_but);
			madrid.WaitForElement(MainMenuVars.inbox_Title);
            Assert.True(madrid.Query(MainMenuVars.inbox_Title).Length > 0, "No se muestra la pagina de Inbox");
        }

		[Test]
		public void Test_38733()
		{
			//Maridistas
			if (utils._device == "Tablet")
			{
				utils.Access_Tab_Main_Menu(MainMenuVars.menu_Madridistas_but);
				Assert.True(madrid.Query(MainMenuVars.madridista_Title_Tablet).Length > 0, "No se muestra la página de Madridistas");
			}
			else
			{ 
				utils.Access_Tab_Main_Menu(MainMenuVars.menu_Madridistas_but);
				Assert.True(madrid.Query(MainMenuVars.madridista_Title).Length > 0, "No se muestra la página de Madridistas");
			}
			
		}

        [Test]
        public void Test_38734()
        {
            //Socios
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Socios_but);
            Assert.True(madrid.Query(MainMenuVars.socios_Title).Length > 0, "No se muestra la pagina de socios");
        }

        [Test]
        public void Test_38735()
        {
            //Tour Virtual
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Tour_Virtual_but);
            Assert.True(madrid.Query(MainMenuVars.video_Player).Length > 0, "No se muestra un reproductor de video en Tour Virtual");
        }

        [Test]
        public void Test_38736()
        {
            //Ajustes
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Ajustes_but);
            Assert.True(madrid.Query(MainMenuVars.ajustes_Title).Length > 0, "No se muestra la pagina de ajustes");
        }

        [Test]
        public void Test_38737()
        {
            //Virtual Store
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Virtual_Store_but);
            Assert.True(madrid.Query(MainMenuVars.virtual_store_title).Length > 0, "No se muestra la pagina de tienda virtual");
        }

        [Test]
        public void Test_38738()
        {
            //Profile
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Profile_but);
            Assert.True(madrid.Query(NavigationBarVars.profile_Title).Length > 0, "No se muestra la pagina de Area Personal");
        }

		[Test]
		public void Test_38739()
		{
			//Finder
			if (utils._device == "Tablet")
			{
				utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but_Tablet);
				Assert.True(madrid.Query(FinderVars.main_title).Length > 0, "No se muestra la pagina e finder");
			}
			else
			{ 
				utils.Access_Tab_Main_Menu(MainMenuVars.menu_Finder_but);
				Assert.True(madrid.Query(FinderVars.main_title).Length > 0, "No se muestra la pagina e finder");
			}
		}


        [Test]
        public void Test_38740()
        {
			//Social
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Social_but);
            Assert.True(madrid.Query(MainMenuVars.social_Title).Length > 0, "No se muestra la pagina de Social");
        }

     
        /*

        [Test]
        public void Test_34413() {
            utils.profile_fill_standard();
            madrid.Tap(MainMenuVars.menu_Main_but);
            Assert.True(madrid.Query(MainMenuVars.menu_alias).Length > 0, "No se muestra el alias en el menu");
            Assert.True(madrid.Query(MainMenuVars.menu_name).Length > 0, "No se muestra el nombre en el menu");
            Assert.True(madrid.Query(MainMenuVars.menu_img_exp).Length > 0, "No se muestra la imagen de la experiencia en el menu");
            Assert.True(madrid.Query(MainMenuVars.menu_tv_exp).Length > 0, "No se muestra el valor de la experiencia en el menu");
            Assert.True(madrid.Query(MainMenuVars.menu_img_coins).Length > 0, "No se muestra la imagen de las monedas en el menu");
            Assert.True(madrid.Query(MainMenuVars.menu_tv_coins).Length > 0, "No se muestra el valor de las monedas en el menu");
            Assert.True(madrid.Query(MainMenuVars.menu_Perfil_but).Length > 0, "No se muestra la imagen del avatar en el menu");
            Assert.True(madrid.Query(MainMenuVars.menu_image).Length > 0, "No se muestra la imagen del bernabeu de fondo");
            madrid.SwipeRightToLeft();
        }



        [Test]
        public void Test_34415() {
            utils.profile_clear();
            madrid.Tap(MainMenuVars.menu_Main_but);
            Assert.False(madrid.Query(MainMenuVars.menu_alias).Length > 0, "Se muestra el alias en el menu");
            Assert.False(madrid.Query(MainMenuVars.menu_name).Length > 0, "Se muestra el nombre en el menu");
            Assert.True(madrid.Query(MainMenuVars.menu_img_exp).Length > 0, "No se muestra la imagen de la experiencia en el menu");
            Assert.True(madrid.Query(MainMenuVars.menu_tv_exp).Length > 0, "No se muestra el valor de la experiencia en el menu");
            Assert.True(madrid.Query(MainMenuVars.menu_img_coins).Length > 0, "No se muestra la imagen de las monedas en el menu");
            Assert.True(madrid.Query(MainMenuVars.menu_tv_coins).Length > 0, "No se muestra el valor de las monedas en el menu");
            Assert.True(madrid.Query(MainMenuVars.menu_Perfil_but).Length > 0, "No se muestra la imagen del avatar en el menu");
            Assert.True(madrid.Query(MainMenuVars.menu_image).Length > 0, "No se muestra la imagen del bernabeu de fondo");
            madrid.SwipeRightToLeft();
        }

		*/

        [Test]
        public void Test_34417() {
            //perfil
            madrid.Repl();
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Perfil_but);
			Assert.True(madrid.Query(MainMenuVars.perfil_Title).Length > 0, "No se muestra la pagina de Perfil");
        }
        
    }
}
