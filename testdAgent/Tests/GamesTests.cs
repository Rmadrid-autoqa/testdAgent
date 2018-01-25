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


	public class GamesTests {
		IApp madrid;
		Utilities utils;
		Platform platform;



		public GamesTests(Platform platform) {
			this.platform = platform;
		}



		[TestFixtureSetUp]
		public void BeforeAllTest() {

		}



		[SetUp]
		public void BeforeEachTest() {
			madrid = AppInitializer.StartApp(platform);
			utils = new Utilities(madrid);
			//utils.Login();
		}


		[TearDown]
		public void AfterEachTest() {
			utils.Enter_Home();
			//            utils.Sign_Off();
		}


		//////////////////////////////////////////// GAMES ///////////////////////////////////////////////


	}
}