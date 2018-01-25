using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest;

namespace RealMadrid_UITest.Tests {
	[TestFixture(Platform.Android)]
	//[TestFixture(Platform.iOS)]


	public class DemoTest {
		IApp madrid;
		Utilities utils;
		Platform platform;



		public DemoTest(Platform platform) {
			this.platform = platform;
		}



		[TestFixtureSetUp]
		public void BeforeAllTest() {
			madrid = AppInitializer.StartApp(platform);
			utils = new Utilities(madrid);
		}



		[SetUp]
		public void BeforeEachTest() {
			utils.Login();
		}



		[TearDown]
		public void AfterEachTest() {
			utils.Enter_Home();
			//utils.Sign_Off();
		}

        /*************SOLO DEMO ********************

		[Test]
		public void Test_1() {
			utils.Access_Tab_Main_Menu(MainMenuVars.menu_Ficha_Jugador_but);
			madrid.WaitForElement(a => a.Id("players_scroll"));
			madrid.SwipeRightToLeft(a => a.Id("players_scroll"), 0.99, 5000, true);
			madrid.Tap(a => a.Id("player_name").Text("Cristiano Ronaldo"));
			madrid.Tap(a => a.Id("pager_player_detail"));
			utils.Sleep(5);
			madrid.SwipeRightToLeft(a => a.Id("pager_player_profile"), 0.80, 4000, true);
			madrid.ScrollDown(a => a.Id("content"), ScrollStrategy.Gesture, 0.80, 3000, true);
			madrid.ScrollDown(a => a.Id("content"), ScrollStrategy.Gesture, 0.80, 3000, true);
		}



		[Test]
		public void Test_2() {
			madrid.Tap(a => a.Id("img").Index(1));
			madrid.Tap(a => a.Id("title").Text("Real Madrid TV"));
			madrid.Tap(a => a.Id("video_layout"));
			madrid.Tap(a => a.Id("full_screen"));
			utils.Sleep(5);
			madrid.Tap(a => a.Id("video_layout"));
			madrid.Tap(a => a.Id("pause"));
			utils.Sleep(3);
			madrid.Back();
			madrid.Back();
		}


            /*************SOLO DEMO ********************/




	}
}
 