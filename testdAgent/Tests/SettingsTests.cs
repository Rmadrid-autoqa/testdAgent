using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace RealMadrid_UITest
{
    //[TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]


    public class SettingsTests
    {
        IApp madrid;
        Utilities utils;
        Platform platform;



        public SettingsTests(Platform platform)
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

		// Auxiliary methods
		private void Go_To_Slow(Func<AppQuery, AppQuery> view, Func<AppQuery, AppQuery> element)
		{
			while (madrid.Query(element).Length == 0)
			{
				madrid.ScrollDown(view, ScrollStrategy.Gesture, 0.20, 500, true);
			  }
		}


        // ----SOLO LOCAL----
        /*
        //[test]
        //english language
        public void test_34300(){
            //step 1: go to settings
            utils.access_tab_main_menu(mainmenuvars.menu_ajustes_but);

            //step 2: select english language on combobox
             utils.change_language(settingsvars.settings_english_usa);
            madrid.waitforelement(mainmenuvars.menu_main_but);
            utils.sleep(5);
            madrid.tap(mainmenuvars.menu_main_but);
            appresult []  result1 = madrid.query(mainmenuvars.menu_items_id);
            assert.true(utils.find_text(result1, strings.main_menu_news_en), "the app isn't displayed in english language");

            //step 3: restart application
            madrid.back();
            utils.sign_off();
            //utils.login();
            madrid.repl();
            madrid.waitforelement(mainmenuvars.menu_main_but);
            utils.sleep(5);
            madrid.tap(mainmenuvars.menu_main_but);
            appresult[] result2 = madrid.query(mainmenuvars.menu_items_id);
            assert.true(utils.find_text(result2, strings.main_menu_news_en), "the app isn't displayed in english language");

            //step 4: select spanish language
            madrid.back();
            utils.access_tab_main_menu(settingsvars.menu_settings_but_en);
            utils.change_language(settingsvars.settings_spanish_en);

        }
        */

        //----SOLO LOCAL----
        /*         
        [Test]
        //Spanish language
        public void Test_34301() {
            //Go to Settings
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Ajustes_but);
            //Select English language on Combobox

            utils.change_Language(SettingsVars.settings_spanish);

            utils.Sleep(20);
            madrid.Tap(MainMenuVars.menu_Main_but);
            madrid.ScrollUp();
            AppResult[] result1 = madrid.Query(MainMenuVars.menu_items_id);
            Assert.True(utils.Find_Text(result1, Strings.MAIN_MENU_NEWS));

            //Restart application
            madrid.Back();
            utils.Sign_Off();
            //utils.Login();
            madrid.Repl();

            madrid.Tap(MainMenuVars.menu_Main_but);
            AppResult[] result2 = madrid.Query(MainMenuVars.menu_items_id);
            Assert.True(utils.Find_Text(result2, Strings.MAIN_MENU_NEWS));

            madrid.Back();
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Ajustes_but);
            utils.change_Language(SettingsVars.settings_spanish);

        }
        */

        //----SOLO LOCAL----
        /*
        [Test]
        //Indonesian language 
        public void Test_34302() {
            //Step 1: Go to Settings
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Ajustes_but);

            //Step 2: Select Indoneasian language on Combobox
            utils.change_Language(SettingsVars.settings_indonesio);
            madrid.WaitForElement(MainMenuVars.menu_Main_but);
            madrid.Tap(MainMenuVars.menu_Main_but);
            AppResult[] result1 = madrid.Query(MainMenuVars.menu_items_id);
            Assert.True(utils.Find_Text(result1, Strings.MAIN_MENU_SHOP_IN), "The app isn't displayed in Indonesian language");

            //Step 3: Restart application
            madrid.Back();
            utils.Sign_Off();
            //utils.Login();
            madrid.Repl();
            madrid.Tap(MainMenuVars.menu_Main_but);
            AppResult[] result2 = madrid.Query(MainMenuVars.menu_items_id);
            Assert.True(utils.Find_Text(result2, Strings.MAIN_MENU_SHOP_IN), "The app isn't displayed in Indonesian language");

            //Step 4: Select Spanish language
            madrid.Back();
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_settings_but_IN);
            utils.change_Language(SettingsVars.settings_spanish_IN);

        }

        */

        //----SOLO LOCAL----
        /*
        [Test]
        //Arabian language
        public void Test_34303() {
            //Step 1: Go to Settings
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Ajustes_but);
            
            //Step 2: Select Arabian language on Combobox
            utils.change_Language(SettingsVars.settings_arab);
            madrid.WaitForElement(MainMenuVars.menu_Main_but);
            madrid.Tap(MainMenuVars.menu_Main_but);
            AppResult[] result1 = madrid.Query(MainMenuVars.menu_items_id);
            Assert.True(utils.Find_Text(result1, Strings.MAIN_MENU_SHOP_AR), "The app isn't displayed in Arabian language");

            //Step 3: Restart application
            madrid.Back();
            utils.Sign_Off();
            //utils.Login();
            madrid.Repl();
            madrid.Tap(MainMenuVars.menu_Main_but);
            AppResult[] result2 = madrid.Query(MainMenuVars.menu_items_id);
            Assert.True(utils.Find_Text(result2, Strings.MAIN_MENU_SHOP_AR), "The app isn't displayed in Arabian language");

            //Step 4: Select Spanish language
            madrid.Back();
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_settings_but_AR);
            utils.change_Language(SettingsVars.settings_spanish_AR);
        }
        -*/


        [Test]
        //Logout
        public void Test_34416()
        {
            //Step 1: Go to settings
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Ajustes_but);

            //Step 2: Click on LOGOUT button
			utils.Sleep(5);
            //madrid.ScrollDown();
            utils.Go_To(SettingsVars.settings_scrollview, SettingsVars.settings_logout_but);
            madrid.Tap(SettingsVars.settings_logout_but);
			utils.Sleep(2);
            Assert.True(utils.existsElement(SettingsVars.settings_logout_popup), "The confirmation pop up doesn't appear");

            //Step 4: Click on OK button
            madrid.Tap(SettingsVars.settings_logout_ok_but);
            //ASSERT: confirmation log in window
			madrid.WaitForElement(LoginVars.login_User_Input);
			Assert.True(utils.existsElement(LoginVars.login_User_Input), "The log in window doesn't open");
		
		}


		/*
        [Test]
        //Legal Warning & Data protection links
        public void Test_34423()
        {
            //Step 1: Go to settings
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Ajustes_but);

            //Step 2: Click on Data Protection link
            Go_To_Slow(SettingsVars.settings_scrollview, SettingsVars.settings_data_protection_link);
            madrid.Tap(SettingsVars.settings_data_protection_link);
            //Assert.True(utils.existsElement(SettingsVars.data_protection_legal_warning_view), "Web browser isn't launched with Data protection policies.");
            utils.Sleep(5);

            //Step 3: Go back. Confirm settings page is displayed
            madrid.Back();
            Assert.True(utils.existsElement(MainMenuVars.ajustes_Title), "Settings page isn't displayed and screen title is correct.");

            //Step 4: Click on Legal Warning
            Go_To_Slow(SettingsVars.settings_scrollview, SettingsVars.settings_legal_warning_link);
            madrid.Tap(SettingsVars.settings_legal_warning_link);
            utils.Sleep(5);
            //Assert.True(utils.existsElement(SettingsVars.data_protection_legal_warning_view), "Web browser isn't launched with legal warning policies.");

            //Step 5: Go back. Confirm settings page is displayed
            madrid.Back();
            Assert.True(utils.existsElement(MainMenuVars.ajustes_Title), "Settings page isn't displayed and screen title is correct.");
        }*/

    }
}