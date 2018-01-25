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

    public class PlayerCardsTests {
        IApp madrid;
        Utilities utils;
        Platform platform;



        public PlayerCardsTests(Platform platform) {
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



		[Test]
		public void Test_34291()
		{
			if (utils._device == "Tablet")
			{
				utils.Sleep(5);
				utils.Access_Tab_Main_Menu(MainMenuVars.menu_Ficha_Jugador_but);
				Assert.True(madrid.Query(MainMenuVars.ficha_Jugador_Title).Length > 0, "No se muestra la pagina de fichas de jugaor");
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Select_Player_Title).Length > 0, "No se muestra el titulo e selecciona un jugador");
				//Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Players_Scroll).Length > 0, "No se muestra el carrusel de jugadores");
				utils.Sleep(3);
				madrid.WaitForElement(PlayerCardVars.ficha_Jugador_Player_Name);
				AppResult[] result;
				result = madrid.Query(PlayerCardVars.ficha_Jugador_Player_Name);
				string name = result[0].Text;
				madrid.SwipeRightToLeft(0.67, 5000, true);
				utils.Sleep(4);
				result = madrid.Query(PlayerCardVars.ficha_Jugador_Player_Name);
				string newName = result[0].Text;
				Assert.False(name.Equals(newName), "No cambia el nombre del jugador al hacer swipe");
				/*name = newName;
				//madrid.Tap(PlayerCardVars.ficha_Jugador_Other_Player_Img);
				utils.Sleep(4);
				result = madrid.Query(PlayerCardVars.ficha_Jugador_Player_Name);
				newName = result[0].Text;
				Assert.False(name.Equals(newName), "No cambia el nombre del jugador al hacer click en otro jugador el carrouse"+"Primer nombre "+name+"Segundo nombre "+newName);*/

				string newName2 = newName.ToUpper();

				madrid.Tap(PlayerCardVars.ficha_Jugador_Player_Name);
				madrid.WaitForElement(PlayerCardVars.ficha_Jugador_Player_Title);
				//result = madrid.Query(PlayerCardVars.ficha_Jugador_Player_Title);

				//string NameTitle = (result[0].Text);
				Assert.True(utils.existsElement(a => a.Marked(newName2)));

				utils.Sleep(4);
				madrid.WaitForElement(PlayerCardVars.ficha_Jugador_Perfil_Tab);
				//Assert.True(newName2.Equals(NameTitle), "El titulo no corresponde con el nombre del jugador");
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Perfil_Tab).Length > 0, "No se muestra la pestaña de perfil");
				//Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Social_Tab).Length > 0, "No se muestra la pestaña de social");
				madrid.WaitForElement(PlayerCardVars.ficha_Jugador_Player_Image);
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Player_Image).Length > 0, "No se muestra la imagen el jugador");
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Player_Position).Length > 0, "No se muestra la posicion del jugador");
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Player_Age).Length > 0, "No se muestra la edad del jugador");
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Player_Height).Length > 0, "No se muestra la altura del jugador");
				madrid.WaitForElement(PlayerCardVars.ficha_Jugador_Player_Weight);
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Player_Weight).Length > 0, "No se muestra el peso del jugador");
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Stats_but).Length > 0, "No se muestra el boton de estado del jugador");
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Games_Played).Length > 0, "No se muestran los partidos");
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_goals).Length > 0, "No se muestran los goles");
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Yellow_Cards).Length > 0, "No se muestran las tarjetas amarillas");
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Red_Cards).Length > 0, "No se muestran las tarjetas rojas");

				madrid.Tap(PlayerCardVars.ficha_Jugador_Stats_but);
				madrid.WaitForElement(PlayerCardVars.ficha_Jugador_Competition_Combo);
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Competition_Combo).Length > 0, "No se muestra el combo de competiciones");
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Competition_Liga).Length > 0, "No se muestra la liga seleccionada en el combo de competiciones");
				madrid.WaitForElement(PlayerCardVars.ficha_Jugador_Horizontal_Graph);
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Horizontal_Graph).Length > 0, "No se muestran los graficos");
				madrid.Tap(PlayerCardVars.ficha_Jugador_Competition_Combo);
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Competition_Liga).Length > 0, "No se muestra la liga en el combo de competiciones abierto");
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Competition_Copa).Length > 0, "No se muestra la copa en el combo de competiciones abierto");
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Competition_Champions).Length > 0, "No se muestra la champions en el combo de competiciones abierto");
				madrid.Tap(PlayerCardVars.ficha_Jugador_Competition_Champions);
				madrid.WaitForElement(PlayerCardVars.ficha_Jugador_Horizontal_Graph);
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Competition_Champions).Length > 0, "No se muestra la champions seleccionada en el combo de competiciones abierto");
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Horizontal_Graph).Length > 0, "No se muestran los graficos");
				madrid.Tap(PlayerCardVars.Stats_page_GoBack);
				madrid.WaitForElement(PlayerCardVars.ficha_Jugador_Player_Title);
				result = madrid.Query(PlayerCardVars.ficha_Jugador_Player_Title);
				//Assert.True(newName.Equals(result[0].Text), "El titulo no corresponde con el nombre del jugador");
				Assert.True(utils.existsElement(a => a.Marked(newName2)));
				madrid.Tap(PlayerCardVars.ficha_Jugador_Social_Tab);
				//Assert.True(newName.Equals(result[0].Text), "El titulo no corresponde con el nombre del jugador");
				Assert.True(utils.existsElement(a => a.Marked(newName2)));
				madrid.WaitForElement(PlayerCardVars.ficha_Jugador_Twitter_Name);
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Twitter_Name).Length > 0, "No se muestra la cuenta e Twitter del jugador");
			}
			else
			{
				utils.Access_Tab_Main_Menu(MainMenuVars.menu_Ficha_Jugador_but);
				Assert.True(madrid.Query(MainMenuVars.ficha_Jugador_Title).Length > 0, "No se muestra la pagina de fichas de jugaor");
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Select_Player_Title).Length > 0, "No se muestra el titulo e selecciona un jugador");
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Players_Scroll).Length > 0, "No se muestra el carrusel de jugadores");
				utils.Sleep(3);
				madrid.WaitForElement(PlayerCardVars.ficha_Jugador_Player_Name);
				AppResult[] result;
				result = madrid.Query(PlayerCardVars.ficha_Jugador_Player_Name);
				string name = result[0].Text;
				madrid.SwipeRightToLeft(0.67, 5000, true);
				utils.Sleep(4);
				result = madrid.Query(PlayerCardVars.ficha_Jugador_Player_Name);
				string newName = result[0].Text;
				Assert.False(name.Equals(newName), "No cambia el nombre del jugador al hacer swipe");
				name = newName;
				madrid.Tap(PlayerCardVars.ficha_Jugador_Other_Player_Img);
				utils.Sleep(4);
				result = madrid.Query(PlayerCardVars.ficha_Jugador_Player_Name);
				newName = result[0].Text;
				Assert.False(name.Equals(newName), "No cambia el nombre del jugaor al hacer click en otro jugador el carrousel");

				string newName2 = newName.ToUpper();

				madrid.Tap(PlayerCardVars.ficha_Jugador_Player_Name);
				madrid.WaitForElement(PlayerCardVars.ficha_Jugador_Player_Title);
				//result = madrid.Query(PlayerCardVars.ficha_Jugador_Player_Title);

				//string NameTitle = (result[0].Text);
				Assert.True(utils.existsElement(a => a.Marked(newName2)));


				//Assert.True(newName2.Equals(NameTitle), "El titulo no corresponde con el nombre del jugador");
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Perfil_Tab).Length > 0, "No se muestra la pestaña de perfil");
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Social_Tab).Length > 0, "No se muestra la pestaña de social");
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Player_Image).Length > 0, "No se muestra la imagen el jugador");
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Player_Position).Length > 0, "No se muestra la posicion del jugador");
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Player_Age).Length > 0, "No se muestra la edad del jugador");
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Player_Height).Length > 0, "No se muestra la altura del jugador");
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Player_Weight).Length > 0, "No se muestra el peso del jugador");
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Stats_but).Length > 0, "No se muestra el boton de estado del jugador");
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Games_Played).Length > 0, "No se muestran los partidos");
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_goals).Length > 0, "No se muestran los goles");
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Yellow_Cards).Length > 0, "No se muestran las tarjetas amarillas");
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Red_Cards).Length > 0, "No se muestran las tarjetas rojas");

				madrid.Tap(PlayerCardVars.ficha_Jugador_Stats_but);
				madrid.WaitForElement(PlayerCardVars.ficha_Jugador_Competition_Combo);
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Competition_Combo).Length > 0, "No se muestra el combo de competiciones");
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Competition_Liga).Length > 0, "No se muestra la liga seleccionada en el combo de competiciones");
				madrid.WaitForElement(PlayerCardVars.ficha_Jugador_Horizontal_Graph);
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Horizontal_Graph).Length > 0, "No se muestran los graficos");
				madrid.Tap(PlayerCardVars.ficha_Jugador_Competition_Combo);
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Competition_Liga).Length > 0, "No se muestra la liga en el combo de competiciones abierto");
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Competition_Copa).Length > 0, "No se muestra la copa en el combo de competiciones abierto");
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Competition_Champions).Length > 0, "No se muestra la champions en el combo de competiciones abierto");
				madrid.Tap(PlayerCardVars.ficha_Jugador_Competition_Champions);
				madrid.WaitForElement(PlayerCardVars.ficha_Jugador_Horizontal_Graph);
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Competition_Champions).Length > 0, "No se muestra la champions seleccionada en el combo de competiciones abierto");
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Horizontal_Graph).Length > 0, "No se muestran los graficos");
				madrid.Tap(PlayerCardVars.Stats_page_GoBack);
				madrid.WaitForElement(PlayerCardVars.ficha_Jugador_Player_Title);
				result = madrid.Query(PlayerCardVars.ficha_Jugador_Player_Title);
				//Assert.True(newName.Equals(result[0].Text), "El titulo no corresponde con el nombre del jugador");
				Assert.True(utils.existsElement(a => a.Marked(newName2)));
				madrid.Tap(PlayerCardVars.ficha_Jugador_Social_Tab);
				//Assert.True(newName.Equals(result[0].Text), "El titulo no corresponde con el nombre del jugador");
				Assert.True(utils.existsElement(a => a.Marked(newName2)));
				madrid.WaitForElement(PlayerCardVars.ficha_Jugador_Twitter_Name);
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Twitter_Name).Length > 0, "No se muestra la cuenta e Twitter del jugador");
			}
		}



		[Test]
		public void Test_34298()
		{
			if (utils._device == "Tablet")
			{
				utils.Change_Sport();
				utils.Access_Tab_Main_Menu(MainMenuVars.menu_Ficha_Jugador_but);
				Assert.True(madrid.Query(MainMenuVars.ficha_Jugador_Title).Length > 0, "No se muestra la pagina de fichas de jugaor");
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Select_Player_Title).Length > 0, "No se muestra el titulo e selecciona un jugador");
				//Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Players_Scroll).Length > 0, "No se muestra el carrusel de jugadores");
				madrid.WaitForElement(PlayerCardVars.ficha_Jugador_Player_Name);
				AppResult[] result;
				result = madrid.Query(PlayerCardVars.ficha_Jugador_Player_Name);
				string name = result[0].Text;
				madrid.SwipeRightToLeft(0.67, 5000, true);
				utils.Sleep(3);
				result = madrid.Query(PlayerCardVars.ficha_Jugador_Player_Name);
				string newName = result[0].Text;
				Assert.False(name.Equals(newName), "No cambia el nombre del jugador al hacer swipe"+ " Primer jugador: "+name+" Segundo nombre: "+newName);
				/*name = newName;
				madrid.Tap(PlayerCardVars.ficha_Jugador_Other_Player_Img);
				utils.Sleep(4);
				result = madrid.Query(PlayerCardVars.ficha_Jugador_Player_Name);
				newName = result[0].Text;
				Assert.False(name.Equals(newName), "No cambia el nombre el jugador al hacer click en otro jugador el carrousel");*/
				string newName2 = newName.ToUpper();
				madrid.Tap(PlayerCardVars.ficha_Jugador_Player_Name);
				madrid.WaitForElement(PlayerCardVars.ficha_Jugador_Player_Title);
				//result = madrid.Query(PlayerCardVars.ficha_Jugador_Player_Title);
				//Assert.True(newName.Equals(result[0].Text), "El titulo no corresponde con el nombre del jugador");
				Assert.True(utils.existsElement(a => a.Marked(newName2)));
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Perfil_Tab).Length > 0, "No se muestra la pestaña de perfil");
				//Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Social_Tab).Length > 0, "No se muestra la pestaña de social");
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Player_Image).Length > 0, "No se muestra la imagen el jugador");
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Player_Position).Length > 0, "No se muestra la posicion del jugador");
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Player_Age).Length > 0, "No se muestra la edad del jugador");
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Player_Height).Length > 0, "No se muestra la altura del jugador");
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Player_Weight).Length > 0, "No se muestra el peso del jugador");
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Stats_but).Length > 0, "No se muestra el boton de estado del jugador");
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Basket_Points).Length > 0, "No se muestran los puntos");
				madrid.WaitForElement(PlayerCardVars.ficha_Jugador_Basket_Asist);
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Basket_Asist).Length > 0, "No se muestran las asistencias");
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Basket_Rebot).Length > 0, "No se muestran los rebotes");
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Basket_Robos).Length > 0, "No se muestran los robos");
				utils.Enter_Home();
				madrid.Tap(HomeVars.home_Change_Sport_but);
			}
			else
			{
				utils.Change_Sport();
				utils.Access_Tab_Main_Menu(MainMenuVars.menu_Ficha_Jugador_but);
				Assert.True(madrid.Query(MainMenuVars.ficha_Jugador_Title).Length > 0, "No se muestra la pagina de fichas de jugaor");
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Select_Player_Title).Length > 0, "No se muestra el titulo e selecciona un jugador");
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Players_Scroll).Length > 0, "No se muestra el carrusel de jugadores");
				madrid.WaitForElement(PlayerCardVars.ficha_Jugador_Player_Name);
				AppResult[] result;
				result = madrid.Query(PlayerCardVars.ficha_Jugador_Player_Name);
				string name = result[0].Text; madrid.SwipeRightToLeft();
				result = madrid.Query(PlayerCardVars.ficha_Jugador_Player_Name);
				string newName = result[0].Text;
				Assert.False(name.Equals(newName), "No cambia el nombre del jugador al hacer swipe");
				name = newName;
				madrid.Tap(PlayerCardVars.ficha_Jugador_Other_Player_Img);
				utils.Sleep(4);
				result = madrid.Query(PlayerCardVars.ficha_Jugador_Player_Name);
				newName = result[0].Text;
				Assert.False(name.Equals(newName), "No cambia el nombre el jugador al hacer click en otro jugador el carrousel");
				string newName2 = newName.ToUpper();
				madrid.Tap(PlayerCardVars.ficha_Jugador_Player_Name);
				madrid.WaitForElement(PlayerCardVars.ficha_Jugador_Player_Title);
				//result = madrid.Query(PlayerCardVars.ficha_Jugador_Player_Title);
				//Assert.True(newName.Equals(result[0].Text), "El titulo no corresponde con el nombre del jugador");
				Assert.True(utils.existsElement(a => a.Marked(newName2)));
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Perfil_Tab).Length > 0, "No se muestra la pestaña de perfil");
				//Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Social_Tab).Length > 0, "No se muestra la pestaña de social");
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Player_Image).Length > 0, "No se muestra la imagen el jugador");
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Player_Position).Length > 0, "No se muestra la posicion del jugador");
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Player_Age).Length > 0, "No se muestra la edad del jugador");
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Player_Height).Length > 0, "No se muestra la altura del jugador");
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Player_Weight).Length > 0, "No se muestra el peso del jugador");
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Stats_but).Length > 0, "No se muestra el boton de estado del jugador");
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Basket_Points).Length > 0, "No se muestran los puntos");
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Basket_Asist).Length > 0, "No se muestran las asistencias");
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Basket_Rebot).Length > 0, "No se muestran los rebotes");
				Assert.True(madrid.Query(PlayerCardVars.ficha_Jugador_Basket_Robos).Length > 0, "No se muestran los robos");
				utils.Enter_Home();
				madrid.Tap(HomeVars.home_Change_Sport_but);
			}
		}
    }
}
