using NUnit.Framework;
using RealMadrid_UITest.Variables;
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
    

	public class DecimaTests {
        IApp madrid;
        Utilities utils;
        Platform platform;

        

		public DecimaTests(Platform platform) {
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
		//See La Enésima video
		public void Test_34430()
		{
			//Step 2 and 3: Click on menu and click on La Decima
			utils.Access_Tab_Main_Menu(MainMenuVars.menu_La_Decima_but);
			madrid.WaitForElement(DecimaVars.decima_header_title);
			Assert.True(utils.existsElement(DecimaVars.decima_header_title), "Decima page doesn't display");
			Assert.True(utils.existsElement(DecimaVars.decima_main_video), "Main video doesn't exist");
			Assert.True(utils.existsElement(DecimaVars.decima_video_list), "Videos list doesn't exist");

			//Step 4: Click on any video
			madrid.Tap(DecimaVars.decima_main_video);
			utils.Sleep(10);
			Assert.True(utils.existsElement(DecimaVars.video_player_icon), "Video doesn't play");

			//Step 5: Tap Back button to exit video.
			madrid.Tap(VideoVars.Video_GoBack);
			utils.Sleep(2);
			Assert.True(utils.existsElement(DecimaVars.decima_header_title), "Decima page doesn't display");
		}
    }
}
