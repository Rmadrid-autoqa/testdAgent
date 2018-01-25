using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest;



namespace RealMadrid_UITest.Tests {
    //[TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]


    public class NavbarTests {
        IApp madrid;
        Utilities utils;
        Platform platform;



        public NavbarTests(Platform platform) {
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
            // utils.Enter_Home();
            // utils.Sign_Off();
        }



        [Test]
        //Navbar navigation
        public void Test_34336() {
            //Step 2: Click on profile navbar
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
            Assert.True(utils.existsElement(NavigationBarVars.profile_Title), "Profile page (navbar) isn't displayed");

            //Step 3: Scroll down
            madrid.ScrollDown();
            Assert.True(utils.existsElement(NavigationBarVars.navbar_container), "Navbar don't hide");

            //Step 4: Scroll up
            madrid.ScrollUp();
            Assert.True(utils.existsElement(NavigationBarVars.navbar_container), "Navbar don't show up");

            //Step 5: Click on EDIT button
            madrid.Tap(NavigationBarVars.profile_edit_but);
            Assert.True(utils.existsElement(NavigationBarVars.navbar_container), "Navbar isn't visible");

            //Step 6: Click on Home Navbar
            madrid.Tap(NavigationBarVars.navbar_Home_but);
            Assert.True(utils.seeingHome(), "Home page isn't displayed");

            //Step 7: Scroll Down
            madrid.ScrollDown();
            Assert.True(utils.existsElement(NavigationBarVars.navbar_container), "Navbar don't hide");

            //Step 8: Scroll Up
            madrid.ScrollUp();
            Assert.True(utils.existsElement(NavigationBarVars.navbar_container), "Navbar don't show up");

            //GAMES NAVBAR OPTION DOESN'T EXIST
            //Step 9: Click on Games Navbar
            //Step 10: Scroll Down
            //Step 11: Scroll Up

            //Step 12: Tap on Match area
            madrid.Tap(NavigationBarVars.navbar_Match_area_but);
            Assert.True(utils.existsElement(NavigationBarVars.match_area_Title), "Match Area page isn't displayed");
            Assert.False(utils.existsElement(NavigationBarVars.navbar_container), "navbar doesn't disappears");

			//GAMES OPTION DOESN'T EXIST
			//Step 11: Click Back and see Games page
			madrid.WaitForElement(MatchAreaVars.match_area_goBack);
			madrid.Tap(MatchAreaVars.match_area_goBack);


            //Step 12: Click on Virtual Store
            madrid.Tap(NavigationBarVars.navbar_Virtual_Store_but);
			Assert.True(utils.existsElement(MainMenuVars.virtual_store_title), "Virtual Store page isn't displayed");

            //Step 13: Scroll Down
            madrid.ScrollDown();
            Assert.True(utils.existsElement(NavigationBarVars.navbar_container), "Navbar doesn't hide");

            //Step 14: Scroll up
            madrid.ScrollUp();
            Assert.True(utils.existsElement(NavigationBarVars.navbar_container), "Navbar doesn't show up");

        }



        [Test]
        //Navbar navigation Virtual Store
        public void Test_34529() {
            //Step 2: Click on Virtual Store Navbar
            madrid.Tap(NavigationBarVars.navbar_Virtual_Store_but);
			Assert.True(utils.existsElement(MainMenuVars.virtual_store_title), "Virtual store page isn't displayed");

            //Step 3: Click on VIDEOS Tab
            madrid.Tap(NavigationBarVars.virtual_store_videos_but);
			utils.Sleep(2);
            madrid.WaitForElement(NavigationBarVars.virtual_store_view_all_but);
            Assert.True(utils.existsElement(NavigationBarVars.virtual_store_videos_content), "Virtual Store page isn't displayed");

            //Step 4: Click on Match Area, virtual ticket is displayed
            madrid.Tap(NavigationBarVars.navbar_Match_area_but);
			utils.Sleep(3);
            madrid.WaitForElement(NavigationBarVars.match_area_Title);
            //VIRTUAL TICKET DOESN'T EXIST

            //Step 5: Go Back to Videos on Virtual Store
            madrid.Tap(MatchAreaVars.match_area_goBack);
            Assert.True(utils.existsElement(MainMenuVars.virtual_store_title), "Virtual store page isn't displayed");
        }


		/*
        [Test]
        //Navigate through profile information
        public void Test_34555() {
            //Step 2: Click on Profile icon at Navbar
            madrid.WaitForElement(NavigationBarVars.navbar_container);
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
            Assert.True(utils.existsElement(NavigationBarVars.profile_Title), "Profile page isn't displayed"); 
            Assert.True(utils.existsElement(NavigationBarVars.navbar_container), "Navbar isn't visible");

            //Step 3: Click on EDIT link
            madrid.Tap(NavigationBarVars.profile_edit_but);
            Assert.True(utils.existsElement(NavigationBarVars.profile_edit_title), "Personal information edition screen isn't displayed"); 
            Assert.True(utils.existsElement(NavigationBarVars.navbar_container), "Navbar isn't visible");

            //Step 4: Swipe to Preferences tab
            madrid.Tap(NavigationBarVars.profile_edit_preferences_but);
            Assert.True(utils.existsElement(NavigationBarVars.profile_edit_preferences_basket) && utils.existsElement(NavigationBarVars.profile_edit_preferences_football), "Preferences screen isn't displayed");
            Assert.True(utils.existsElement(NavigationBarVars.navbar_container), "Navbar isn't visible"); 

            //Step 5: Go back
            madrid.Back();
            Assert.True(utils.existsElement(NavigationBarVars.profile_Title), "Profile page isn't displayed");
            Assert.True(utils.existsElement(NavigationBarVars.navbar_container), "Navbar isn't visible");
        }*/


        [Test]
        public void Test_38741()
        {
            //Menu inferior
            //Home
            madrid.Tap(NavigationBarVars.navbar_Home_but);
            Assert.True(utils.seeingHome(), "No se muestra la pagina Home desde el menu inferior");
        }

        [Test]
        public void Test_38742()
        {
            //Menu inferior
            //Area de partido
            madrid.Tap(NavigationBarVars.navbar_Match_area_but);
            if (madrid.Query(NavigationBarVars.match_area_SoloApp_but).Length > 0)
            {
                madrid.Tap(NavigationBarVars.match_area_SoloApp_but);
            }
            madrid.WaitForElement(NavigationBarVars.match_area_Title);
            Assert.True(madrid.Query(NavigationBarVars.match_area_Title).Length > 0, "No se muestra la pagina de area de partido");
        }
		
        [Test]
        public void Test_38743()
        {
            //Menu inferior
            //Tienda Virtual
            madrid.Tap(NavigationBarVars.navbar_Virtual_Store_but);
            Assert.True(madrid.Query(MainMenuVars.virtual_store_title).Length > 0, "No se muestra la pagina de Tienda Virtual dese el menu inferior");
        }

        [Test]
        public void Test_38744()
        {
            //Menu inferior
            //Social
            madrid.Tap(NavigationBarVars.navbar_Social_but);
            Assert.True(madrid.Query(MainMenuVars.social_Title).Length > 0, "No se muestra la pagina Social desde el menu inferior");
        }

        [Test]
        public void Test_38745()
        {
            //Menu inferior
            //Area Personal
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
            Assert.True(madrid.Query(NavigationBarVars.profile_Title).Length > 0, "No se muestra la pagina de Area Personal desde el menu inferior");
        }





    }
}