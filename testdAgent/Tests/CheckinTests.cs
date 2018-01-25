using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using RealMadrid_UITest.Variables;

namespace RealMadrid_UITest.Tests
{
    [TestFixture(Platform.Android)]
    //[TestFixture(Platform.iOS)]

    public class CheckinTests
    {
        IApp madrid;
        Utilities utils;
        Platform platform;



        public CheckinTests(Platform platform)
        {
            this.platform = platform;
        }



        [SetUp]
        public void BeforeEachTest()
        {
            madrid = AppInitializer.StartApp(platform);
            utils = new Utilities(madrid);
            utils.Login();
        }



        [TearDown]
        public void AfterEachTest()
        {
            //            utils.Enter_Home();
            //            utils.Sign_Off();
        }

        [Test]
        //Checkin
        //PRE: Check that localization is enabled on device settings
        public void Test_34436() {
            
            //Step 2: Click on Menu and click on "Checkin" icon
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Checkin_but);
            if (utils.existsElement(CheckinVars.checkin_popup_OK_but))
                madrid.Tap(CheckinVars.checkin_popup_OK_but);

            /* 
             * Combobox "checkins_spinner" doesn't work
             * App can't sort by proximity and recent
             */

            madrid.WaitForElement(CheckinVars.checkin_list);
            Assert.True(utils.existsElement(CheckinVars.checkin_icon_list_img), "Imagen list doesn't exist");
            Assert.True(utils.existsElement(CheckinVars.checkin_title_list), "Title list doesn't exist"); 
            Assert.True(utils.existsElement(CheckinVars.checkin_time_list), "Time list doesn't exist"); 
            //Experience icon at the right side doesn't exist

            //Step 3: Click on "Casa Ronaldo". (Only in QA environment).
            //madrid.Repl();
            utils.Go_To(HomeVars.home_content, CheckinVars.checkin_casa_Ronaldo);
            //Click on "Casa Ronaldo" doesn't work.

            //Step 4: Tap on OK button.
            //OK button doesn't exist

        }

        /*
        [Test]
        //Checkin with location disabled in device
        //PRE: Disable localization on device settings
        public void Test_34437()
        {
            //Step 2: Click on Menu and click on "Checkin" icon
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Checkin_but);

            AppResult[] result = madrid.Query(CheckinVars.checkin_popup);
            Assert.True(utils.Find_Text(result, Strings.CHECKIN_POPUP_MESSAGE));

            //Step 3: Click on Cancel
            madrid.Tap(CheckinVars.checkin_popup_Cancel_but);

            Assert.False(utils.existsElement(CheckinVars.checkin_icon_list_img));
            Assert.False(utils.existsElement(CheckinVars.checkin_title_list));
            Assert.False(utils.existsElement(CheckinVars.checkin_time_list));

            //Step 4: Click on Menu
            madrid.Tap(NavigationBarVars.navbar_Home_but);

            //Step 5: Click on Checkin
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Checkin_but);
            AppResult[] result2 = madrid.Query(CheckinVars.checkin_popup);
            Assert.True(utils.Find_Text(result2, Strings.CHECKIN_POPUP_MESSAGE));

            //Step 6:Click on Settings
            madrid.Tap(CheckinVars.checkin_popup_OK_but);


        }
        */

    }
}
