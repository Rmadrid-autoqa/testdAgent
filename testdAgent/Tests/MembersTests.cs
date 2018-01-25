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
    public class MembersTests
    {
        IApp madrid;
        Utilities utils;
        Platform platform;



        public MembersTests(Platform platform)
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
            //utils.Login();
        }


        [TearDown]
        public void AfterEachTest()
        {
            //            utils.Enter_Home();
            //            utils.Sign_Off();
        }

        /************************ MEMBERS > ACCESS TO THE STADIUM ************************/
        [Test]
        //Cannot see QR code if it is not match day
        public void Test_35102()
        {
            //Step 1: Open Application and Login
            utils.Login_data(Strings.LOGIN_USERNAME3, Strings.LOGIN_PASSWORD3);

            //Step 2: Go to member view
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Socios_but);

            //Step 3: Tap on ACCESS TO STADIUM button.
            //El boton ACCESS TO STADIUM no existe
        }

        [Test]
        //QR code button is disabled for non pay members
        public void Test_35107(){

            //Step 1: Open Application and Login
            utils.Login_data(Strings.LOGIN_USERNAME3, Strings.LOGIN_PASSWORD3);

            //Step 2: Go to main members view
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Socios_but);

            //Step 3: Tap on ACCESS TO STADIUM button.
            //EL boton ACCESS TO STADIUM no existe
        }

        /************************ MEMBERS > GIVE SEAT ************************/
        [Test]
        //Member non subscriber cannot give seats nor access stadium
        public void Test_35091()
        {
            //Step 1: Login
            //User without GIVE UP SEAT button
            utils.Login();

            //Step 2: Go to main members view
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Socios_but);

            //Step 3: Check butttons
            this.first_time_members_view();
            utils.Sleep(10);
            madrid.WaitForElement(MainMenuVars.socios_Title);
            Assert.True(utils.existsElement(MainMenuVars.socios_Title));
            //Boton de ACCESS STADIUM no existe
            Assert.True(utils.existsElement(MembersVars.members_card_but), "ID icon doesn't exist");
            Assert.False(utils.existsElement(MembersVars.members_giveUpSeat_but), "Seat icon doesn't exist");

            //Step 4: Click on "CEDER ASIENTO" / "GIVE UP SEAT" button.
      		// No aparece no se puede hacer Tap
        }

        [Test]
        //Link subscriber Member
        public void Test_35092()
        {
            //Step 1: Login
            //User with GIVE UP SEAT button
            utils.Login_data(Strings.LOGIN_USERNAME3, Strings.LOGIN_PASSWORD3);
            //Step 2 and 3: Link subscriber Member & Link Member from Account placeholder.
            //Ya hay una cuenta subscrita

            //Step 4: Go to Profile
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
            madrid.WaitForElement(NavigationBarVars.profile_Title);

            //Step 5: Select “Socio card”
            madrid.Tap(ProfileVars.link_madridista_but_linked);
            utils.Sleep(5);
            this.first_time_members_view();
            madrid.WaitForElement(MainMenuVars.socios_Title);

            //Step 6: Click on "CEDER ASIENTO" / "GIVE UP SEAT" button
            madrid.Tap(MembersVars.members_giveUpSeat_but);
            utils.Sleep(3);
            madrid.WaitForElement(MembersVars.members_giveupSeat_title);
            utils.Sleep(5);
            Assert.True(utils.existsElement(MembersVars.members_giveupSeat_title), "Title doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_giveupSeat_combobox), "Combobox doesn't exist");

            madrid.Tap(MembersVars.members_giveupSeat_combobox);
            utils.Sleep(5);
            Assert.True(utils.existsElement(MembersVars.members_combobox_nextGame), "Next Games doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_combobox_history), "History doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_combobox_notGiven), "Not Given doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_combobox_notSold), "Not Sold doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_combobox_Sold), "Sold doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_combobox_forSale), "For Sale doesn't exist");

			madrid.Tap(MembersVars.members_giveupSeat_combobox);
            Assert.True(utils.existsElement(MembersVars.members_giveupSeat_conditions), "Conditions doesn't exist");

            //Step 7: Click on "Conditions"
			madrid.Tap(MembersVars.members_giveupSeat_combobox);
            madrid.Tap(MembersVars.members_giveupSeat_conditions);
            madrid.WaitForElement(MembersVars.members_conditions_title);
            utils.Sleep(5);
            Assert.True(utils.existsElement(MembersVars.members_conditions_title), "Conditions doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_OK_but), "OK button doesn't exist");

        }

        /*
        [Test]
        //Give up seat for a future match
        public void Test_35093(){
            //Step 2: Open application and Login
            utils.Login_data(Strings.LOGIN_USERNAME3, Strings.LOGIN_PASSWORD3);

            //Step 3: go to main member view
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Socios_but);
            utils.Sleep(3);
            this.first_time_members_view();
            madrid.WaitForElement(MainMenuVars.socios_Title);

            //Step 4: Clicl on "GIVE UP SEAT"
            madrid.Tap(MembersVars.members_giveUpSeat_but);
            madrid.WaitForElement(MembersVars.members_giveupSeat_title);
            Assert.True(utils.existsElement(MembersVars.members_giveupSeat_title), "GIVE UP page doesn't displayed");

            //Step 5: Click on "GIVE UP SEAT" button
            //NO EXISTE EL BOTON

        }
        */

        /*
        [Test]
        //Retrieve not sold seat for a future match
        public void Test_35098() {
            //Step 1: Open application and Login
            //User with GIVE UP SEAT button
            utils.Login_data(Strings.LOGIN_USERNAME3, Strings.LOGIN_PASSWORD3);

            //Step 2: Link subscriber member
            //Member is subscriber

            //Step 3: Link Member from Account placeholder
            //Member is subscriber

            //Step 4: Go to Profile
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
            madrid.WaitForElement(NavigationBarVars.profile_Title);
            Assert.True(utils.existsElement(NavigationBarVars.profile_Title), "Profile page isn't displayed");

            //Step 5: Select Socio Card
            madrid.Tap(ProfileVars.link_madridista_but);
            utils.Sleep(3);
            this.first_time_members_view();
            madrid.WaitForElement(MainMenuVars.socios_Title);
            Assert.True(utils.existsElement(MainMenuVars.socios_Title), "Members page isn't displayed");

            //Step 6: Click on "CEDER ASIENTO" button
            madrid.Tap(MembersVars.members_giveUpSeat_but);
            

            //BLOQUEADO, NO EXISTE LA OPCION GIVE UP SEAT

        }
        */

        [Test]
        //See not given seat for past match
        public void Test_35101(){
            //Step 1: Set time and date for a match in DocumentDB
            //INCOMPLETO

            //Step 2: Open Application and Login
            utils.Login_data(Strings.LOGIN_USERNAME4, Strings.LOGIN_PASSWORD4);

            //Step 3: Go to main member view
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Socios_but);
            utils.Sleep(3);
            this.first_time_members_view();
            madrid.WaitForElement(MainMenuVars.socios_Title);

            //Step 4: Click on "CEDER ASIENTO" button
            madrid.Tap(MembersVars.members_giveUpSeat_but);
            utils.Sleep(3);
            madrid.WaitForElement(MembersVars.members_giveupSeat_title);
            utils.Sleep(5);
            Assert.True(utils.existsElement(MembersVars.members_giveupSeat_title), "Title doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_giveupSeat_combobox), "Combobox doesn't exist");

            madrid.Tap(MembersVars.members_giveupSeat_combobox);
            utils.Sleep(5);
            Assert.True(utils.existsElement(MembersVars.members_combobox_nextGame), "Next Games doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_combobox_history), "History doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_combobox_notGiven), "Not Given doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_combobox_notSold), "Not Sold doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_combobox_Sold), "Sold doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_combobox_forSale), "For Sale doesn't exist");

            Assert.True(utils.existsElement(MembersVars.members_giveupSeat_conditions), "Conditions doesn't exist");

            //Step 5: Click on Combobox and select "History"
            madrid.Tap(MembersVars.members_giveupSeat_combobox);
            madrid.Tap(MembersVars.members_giveupSeat_combobox);
            utils.Sleep(3);
            madrid.Tap(MembersVars.members_combobox_history);
            utils.Sleep(3);

            Assert.True(utils.existsElement(MembersVars.members_giveupSeat_competition), "League doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_giveupSeat_date), "Date doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_giveupSeat_home), "Home team doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_giveupSeat_away), "Away doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_giveupSeat_status), "Status doesn't exist");

            //Step 6: Scroll to team match -> STATUS = NOT GIVEN
            utils.Go_To(HomeVars.home_content, MembersVars.members_status_notGiven);

            //Step 7: Click on help button

            AppResult[] result_status = madrid.Query(MembersVars.members_giveupSeat_status);
            this.check_status_match(result_status, Strings.STATUS_NOTGIVEN);

        }

        [Test]
        //See not  sold for a future match
        public void Test_35103(){
            //Step 2: Open Application and Login
            utils.Login_data(Strings.LOGIN_USERNAME4, Strings.LOGIN_PASSWORD4);

            //Step 3: Go to main member view
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Socios_but);
            utils.Sleep(5);
            this.first_time_members_view();
            madrid.WaitForElement(MainMenuVars.socios_Title);

            //Step 4: Click on "GIVE UP SEAT" button
            madrid.Tap(MembersVars.members_giveUpSeat_but);
            madrid.WaitForElement(MembersVars.members_giveupSeat_title);
            utils.Sleep(3);

            Assert.True(utils.existsElement(MembersVars.members_giveupSeat_title), "Title doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_giveupSeat_combobox), "Combobox doesn't exist");

            madrid.Tap(MembersVars.members_giveupSeat_combobox);
            utils.Sleep(5);
            Assert.True(utils.existsElement(MembersVars.members_combobox_nextGame), "Next Games doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_combobox_history), "History doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_combobox_notGiven), "Not Given doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_combobox_notSold), "Not Sold doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_combobox_Sold), "Sold doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_combobox_forSale), "For Sale doesn't exist");

            Assert.True(utils.existsElement(MembersVars.members_giveupSeat_conditions), "Conditions doesn't exist");

            //Step 5: Scroll to team match
            madrid.Tap(MembersVars.members_combobox_notSold);
            utils.Sleep(3);

            Assert.True(utils.existsElement(MembersVars.members_giveupSeat_competition), "League doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_giveupSeat_date), "Date doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_giveupSeat_home), "Home team doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_giveupSeat_away), "Away doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_giveupSeat_status), "Status doesn't exist");

            //Step 6: Click on help button
            madrid.Tap(MembersVars.members_giveUpSeat_help);
            AppResult[] result_status = madrid.Query(MembersVars.members_giveupSeat_status);
            this.check_status_match(result_status, Strings.STATUS_NOTSOLD);

        }

        [Test]
        //See sold seat for a future match
        public void Test_35108() {
            //Step 1: Open Application and Login
            utils.Login_data(Strings.LOGIN_USERNAME4, Strings.LOGIN_PASSWORD4);

            //Step 2: Link subscriber Member
            //Member is subcriber

            //Step 3: Link member from Account placeholder
            //Member is linked

            //Step 4: Go to Profile
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
            madrid.WaitForElement(NavigationBarVars.profile_Title);
            Assert.True(utils.existsElement(NavigationBarVars.profile_Title), "Profile page isn't displayed");

            //Step 5: Select "Socio card"
            madrid.Tap(ProfileVars.link_madridista_but_linked);
            utils.Sleep(3);
            this.first_time_members_view();
            madrid.WaitForElement(MainMenuVars.socios_Title);
            Assert.True(utils.existsElement(MainMenuVars.socios_Title), "Members page isn't displayed");

            //Step 6: Click on "GIVE UP SEAT"
            madrid.Tap(MembersVars.members_giveUpSeat_but);
            madrid.WaitForElement(MembersVars.members_giveupSeat_title);
            Assert.True(utils.existsElement(MembersVars.members_giveupSeat_title), "Give up seat page doesn't displayed");


            //Step 7: Scroll Match with given seat sold in a match not played
            madrid.WaitForElement(MembersVars.members_giveupSeat_combobox);
			madrid.DoubleTap(MembersVars.members_giveupSeat_combobox);
            utils.Sleep(3);
            madrid.Tap(MembersVars.members_combobox_history);
            utils.Sleep(3);

            Assert.True(utils.existsElement(MembersVars.members_giveupSeat_title), "Title doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_giveupSeat_combobox), "Combobox doesn't exist");

            madrid.Tap(MembersVars.members_giveupSeat_combobox);
            utils.Sleep(5);
            Assert.True(utils.existsElement(MembersVars.members_combobox_nextGame), "Next Games doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_combobox_history), "History doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_combobox_notGiven), "Not Given doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_combobox_notSold), "Not Sold doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_combobox_Sold), "Sold doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_combobox_forSale), "For Sale doesn't exist");
            madrid.Tap(MembersVars.members_giveupSeat_combobox);
            Assert.True(utils.existsElement(MembersVars.members_giveupSeat_conditions), "Conditions doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_giveupSeat_competition), "League doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_giveupSeat_date), "Date doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_giveupSeat_home), "Home team doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_giveupSeat_away), "Away doesn't exist");
            madrid.WaitForElement(MembersVars.members_giveupSeat_status);
			Assert.True(utils.existsElement(MembersVars.members_giveupSeat_status), "Status doesn't exist");

            utils.Go_To(HomeVars.home_content, MembersVars.members_status_sold);

            //Step 8: Click on help button
            AppResult[] result_status = madrid.Query(MembersVars.members_giveupSeat_status);
            this.check_status_match(result_status, Strings.STATUS_SOLD);
        }

        [Test]
        //See not sold seat for a past match
        public void Test_35109(){
            //Step 1: Open Application and Login
            utils.Login_data(Strings.LOGIN_USERNAME4, Strings.LOGIN_PASSWORD4);

            //Step 2: Link subscriber Member
            //Member is subcriber

            //Step 3: Link member from Account placeholder
            //Member is linked

            //Step 4: Go to profile
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
            madrid.WaitForElement(NavigationBarVars.profile_Title);
            Assert.True(utils.existsElement(NavigationBarVars.profile_Title), "Profile page isn't displayed");

            //Step 5: Select "Socio card"
            madrid.Tap(ProfileVars.link_madridista_but_linked);
            utils.Sleep(3);
            this.first_time_members_view();
            madrid.WaitForElement(MainMenuVars.socios_Title);
            Assert.True(utils.existsElement(MainMenuVars.socios_Title), "Members page isn't displayed");

            //Step 6: Click on "GIVE UP SEAT" button
            madrid.Tap(MembersVars.members_giveUpSeat_but);
            utils.Sleep(3);
            madrid.WaitForElement(MembersVars.members_giveupSeat_title);
            utils.Sleep(5);
            Assert.True(utils.existsElement(MembersVars.members_giveupSeat_title), "Title doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_giveupSeat_combobox), "Combobox doesn't exist");

            madrid.Tap(MembersVars.members_giveupSeat_combobox);
            utils.Sleep(5);
            Assert.True(utils.existsElement(MembersVars.members_combobox_nextGame), "Next Games doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_combobox_history), "History doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_combobox_notGiven), "Not Given doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_combobox_notSold), "Not Sold doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_combobox_Sold), "Sold doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_combobox_forSale), "For Sale doesn't exist");
            madrid.Tap(MembersVars.members_giveupSeat_combobox);
            Assert.True(utils.existsElement(MembersVars.members_giveupSeat_conditions), "Conditions doesn't exist");

            //Step 7: Click on ComboBox and select "History"
            madrid.Tap(MembersVars.members_giveupSeat_combobox);
            utils.Sleep(3);
            madrid.Tap(MembersVars.members_combobox_history);
            utils.Sleep(3);

            Assert.True(utils.existsElement(MembersVars.members_giveupSeat_competition), "League doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_giveupSeat_date), "Date doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_giveupSeat_home), "Home team doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_giveupSeat_away), "Away doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_giveupSeat_status), "Status doesn't exist");

            //Step 8: Scroll to Match with giiven seat not sold in a match has been played. Click on help button
            utils.Go_To(HomeVars.home_content, MembersVars.members_status_notSold);
            AppResult[] result_status = madrid.Query(MembersVars.members_giveupSeat_status);
            this.check_status_match(result_status, Strings.STATUS_NOTSOLD);
        }

        [Test]
        //See sold seat for a past match
        public void Test_35110() {
            //Step 1: Open Application and Login
            utils.Login_data(Strings.LOGIN_USERNAME4, Strings.LOGIN_PASSWORD4);

            //Step 2: Go to main member view
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Socios_but);
            utils.Sleep(3);
            this.first_time_members_view();
            utils.Sleep(3);

            //Step 3: Click on "GIVE UP SEAT" button
            madrid.Tap(MembersVars.members_giveUpSeat_but);
            madrid.WaitForElement(MembersVars.members_giveupSeat_title);
            Assert.True(utils.existsElement(MembersVars.members_giveupSeat_title), "Give up seat page isn't displayed");

            //Step 4: Click on ComboBox and select "History"
            madrid.Tap(MembersVars.members_giveupSeat_combobox);
            madrid.Tap(MembersVars.members_combobox_history);

            //Step 5: Scroll to team Match with given seat sold in a match has been played
            utils.Sleep(3);

            Assert.True(utils.existsElement(MembersVars.members_giveupSeat_title), "Title doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_giveupSeat_combobox), "Combobox doesn't exist");

            madrid.Tap(MembersVars.members_giveupSeat_combobox);
            utils.Sleep(5);
            Assert.True(utils.existsElement(MembersVars.members_combobox_nextGame), "Next Games doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_combobox_history), "History doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_combobox_notGiven), "Not Given doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_combobox_notSold), "Not Sold doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_combobox_Sold), "Sold doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_combobox_forSale), "For Sale doesn't exist");
            madrid.Tap(MembersVars.members_giveupSeat_combobox);
			utils.Sleep(3);
            Assert.True(utils.existsElement(MembersVars.members_giveupSeat_conditions), "Conditions doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_giveupSeat_competition), "League doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_giveupSeat_date), "Date doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_giveupSeat_home), "Home team doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_giveupSeat_away), "Away doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_giveupSeat_status), "Status doesn't exist");

            utils.Go_To(HomeVars.home_content, MembersVars.members_status_sold);

            //Step 6: Click on help button
            AppResult[] result_status = madrid.Query(MembersVars.members_giveupSeat_status);
            this.check_status_match(result_status, Strings.STATUS_SOLD);

        }

        [Test]
        //Filter matches with combobox
        public void Test_35111() {
            //Step 1: Open Application and Login
            utils.Login_data(Strings.LOGIN_USERNAME4, Strings.LOGIN_PASSWORD4);

            //Step 2: Link subscriber Member -> Member is subcriber
            //Step 3: Link Member from Account placeholder -> Member is linked

            //Step 4: Go to Profile
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
            madrid.WaitForElement(NavigationBarVars.profile_Title);
            Assert.True(utils.existsElement(NavigationBarVars.profile_Title), "Profile page doesn't displayed");

            //Step 5: Select "Socio Card"
            madrid.Tap(ProfileVars.link_madridista_but_linked);
            utils.Sleep(3);
            this.first_time_members_view();
            madrid.WaitForElement(MainMenuVars.socios_Title);
            Assert.True(utils.existsElement(MainMenuVars.socios_Title), "Members page doesn't displayed");

            //Step 6: Click on "GIVE UP SEAT"
            madrid.Tap(MembersVars.members_giveUpSeat_but);
            madrid.WaitForElement(MembersVars.members_giveupSeat_title);

            utils.Sleep(3);
            Assert.True(utils.existsElement(MembersVars.members_giveupSeat_title), "Title doesn't exist");
            madrid.WaitForElement(MembersVars.members_giveupSeat_combobox);
			Assert.True(utils.existsElement(MembersVars.members_giveupSeat_combobox), "Combobox doesn't exist");

            madrid.Tap(MembersVars.members_giveupSeat_combobox);
            utils.Sleep(5);
            Assert.True(utils.existsElement(MembersVars.members_combobox_nextGame), "Next Games doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_combobox_history), "History doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_combobox_notGiven), "Not Given doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_combobox_notSold), "Not Sold doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_combobox_Sold), "Sold doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_combobox_forSale), "For Sale doesn't exist");
            madrid.Tap(MembersVars.members_giveupSeat_combobox);
			utils.Sleep(3);
            Assert.True(utils.existsElement(MembersVars.members_giveupSeat_conditions), "Conditions doesn't exist");

            //Step 7: Click on combobox and select "history"
            madrid.Tap(MembersVars.members_giveupSeat_combobox);
            utils.Sleep(3);
            madrid.Tap(MembersVars.members_combobox_history);
            Assert.True(utils.existsElement(MembersVars.members_giveupSeat_competition), "League doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_giveupSeat_date), "Date doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_giveupSeat_home), "Home team doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_giveupSeat_away), "Away doesn't exist");
            madrid.WaitForElement(MembersVars.members_giveupSeat_status);
			Assert.True(utils.existsElement(MembersVars.members_giveupSeat_status), "Status doesn't exist");

            //Step 8: Click on ComboBox and select "NOT SOLD"
            madrid.Tap(MembersVars.members_giveupSeat_combobox);
            utils.Sleep(3);
            madrid.Tap(MembersVars.members_combobox_notSold);
            utils.Sleep(3);
            Assert.True(utils.existsElement(MembersVars.members_status_notSold), "NOT SOLD status doesn't exist");

            //Step 9: Click on Combobox and select "NOT GIVEN"
            madrid.Tap(MembersVars.members_giveupSeat_combobox);
            utils.Sleep(3);
            madrid.Tap(MembersVars.members_combobox_notGiven);
            utils.Sleep(3);
            Assert.True(utils.existsElement(MembersVars.members_status_notGiven), "NOT GIVEN status doesn't exist");

            //Step 10: Click on Combobox and select "SOLD"
            madrid.Tap(MembersVars.members_giveupSeat_combobox);
            utils.Sleep(3);
            madrid.Tap(MembersVars.members_combobox_Sold);
            utils.Sleep(3);
            Assert.True(utils.existsElement(MembersVars.members_status_sold), "SOLD status doesn't exist");

            //Step 11: Click on Combobox and select "FOR SALE"
            madrid.Tap(MembersVars.members_giveupSeat_combobox);
            utils.Sleep(3);
            madrid.Tap(MembersVars.members_combobox_forSale);
            utils.Sleep(3);
            Assert.True(utils.existsElement(MembersVars.members_status_forSale), "FOR SALE status doesn't exist");


            //Step 12: Click on Combobox and select "NEXT GAMES"
            madrid.Tap(MembersVars.members_giveupSeat_combobox);
            utils.Sleep(3);
            madrid.Tap(MembersVars.members_combobox_nextGame);
            utils.Sleep(3);
            /*
            Assert.True(utils.existsElement(MembersVars.members_giveupSeat_competition), "League doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_giveupSeat_date), "Date doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_giveupSeat_home), "Home team doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_giveupSeat_away), "Away doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_giveupSeat_status), "Status doesn't exist");
            */
        }

        [Test]
        //See not given seat for a future match
        public void Test_35148() {
			if (utils._device == "Tablet")
			{

				//Step 1: Open Application and Login
				utils.Login_data(Strings.LOGIN_USERNAME4, Strings.LOGIN_PASSWORD4);

				//Step 2: Link subscriber Member -> Member is subcriber
				//Step 3: Link Member from Account placeholder -> Member is linked

				//Step 4: Go to Profile
				madrid.Tap(NavigationBarVars.navbar_Profile_but);
				madrid.WaitForElement(NavigationBarVars.profile_Title);
				Assert.True(utils.existsElement(NavigationBarVars.profile_Title), "Profile page doesn't displayed");

				//Step 5: Select "Socio Card"
				madrid.Tap(ProfileVars.link_madridista_but_linked);
				utils.Sleep(3);
				this.first_time_members_view();
				madrid.WaitForElement(MainMenuVars.socios_Title);
				Assert.True(utils.existsElement(MainMenuVars.socios_Title), "Members page doesn't displayed");

				//Step 6: Click on "CEDER ASIENTO" button
				madrid.Tap(MembersVars.members_giveUpSeat_but);
				utils.Sleep(3);
				madrid.WaitForElement(MembersVars.members_giveupSeat_title);
				Assert.True(utils.existsElement(MembersVars.members_giveupSeat_title), "Title doesn't exist");
				madrid.WaitForElement(MembersVars.members_giveupSeat_combobox);
				Assert.True(utils.existsElement(MembersVars.members_giveupSeat_combobox), "Combobox doesn't exist");

				madrid.Tap(MembersVars.members_giveupSeat_combobox);
				utils.Sleep(5);
				Assert.True(utils.existsElement(MembersVars.members_combobox_nextGame), "Next Games doesn't exist");
				Assert.True(utils.existsElement(MembersVars.members_combobox_history), "History doesn't exist");
				Assert.True(utils.existsElement(MembersVars.members_combobox_notGiven), "Not Given doesn't exist");
				Assert.True(utils.existsElement(MembersVars.members_combobox_notSold), "Not Sold doesn't exist");
				Assert.True(utils.existsElement(MembersVars.members_combobox_Sold), "Sold doesn't exist");
				Assert.True(utils.existsElement(MembersVars.members_combobox_forSale), "For Sale doesn't exist");

				madrid.Tap(MembersVars.members_giveupSeat_combobox);
				//Assert.True(utils.existsElement(MembersVars.members_giveupSeat_conditions), "Conditions doesn't exist");

				//Step 7: Select NOT GIVEN in the combobox
				madrid.Tap(MembersVars.members_giveupSeat_combobox);
				utils.Sleep(3);
				madrid.Tap(MembersVars.members_combobox_notGiven);
				utils.Sleep(3);

				Assert.True(utils.existsElement(MembersVars.members_giveupSeat_competition_Tablet), "League doesn't exist");
				Assert.True(utils.existsElement(MembersVars.members_giveupSeat_date_Tablet), "Date doesn't exist");
				Assert.True(utils.existsElement(MembersVars.members_giveupSeat_home_Tablet), "Home team doesn't exist");
				Assert.True(utils.existsElement(MembersVars.members_giveupSeat_away_Tablet), "Away doesn't exist");
				Assert.True(utils.existsElement(MembersVars.members_giveupSeat_status_Tablet), "Status doesn't exist");

				//Step 6: Click on help button
				madrid.Tap(MembersVars.members_giveUpSeat_help_Tablet);
				madrid.WaitForElement(MembersVars.members_statusPopup_body);
				Assert.True(utils.existsElement(MembersVars.members_statusPopup_notGiven), "Title doesn't exist");
				Assert.True(utils.existsElement(MembersVars.members_statusPopup_body), "Body doesn't exist");
				Assert.True(utils.existsElement(MembersVars.members_OK_but), "OK button doesn't exist");
			}
			else
			{ 
				//Step 1: Open Application and Login
	            utils.Login_data(Strings.LOGIN_USERNAME4, Strings.LOGIN_PASSWORD4);

	            //Step 2: Link subscriber Member -> Member is subcriber
	            //Step 3: Link Member from Account placeholder -> Member is linked

	            //Step 4: Go to Profile
	            madrid.Tap(NavigationBarVars.navbar_Profile_but);
	            madrid.WaitForElement(NavigationBarVars.profile_Title);
	            Assert.True(utils.existsElement(NavigationBarVars.profile_Title), "Profile page doesn't displayed");

	            //Step 5: Select "Socio Card"
	            madrid.Tap(ProfileVars.link_madridista_but_linked);
	            utils.Sleep(3);
	            this.first_time_members_view();
				madrid.WaitForElement(MainMenuVars.socios_Title);
				Assert.True(utils.existsElement(MainMenuVars.socios_Title), "Members page doesn't displayed");

				//Step 6: Click on "CEDER ASIENTO" button
				madrid.Tap(MembersVars.members_giveUpSeat_but);
				utils.Sleep(3);
				madrid.WaitForElement(MembersVars.members_giveupSeat_title);
				Assert.True(utils.existsElement(MembersVars.members_giveupSeat_title), "Title doesn't exist");
				madrid.WaitForElement(MembersVars.members_giveupSeat_combobox);
				Assert.True(utils.existsElement(MembersVars.members_giveupSeat_combobox), "Combobox doesn't exist");

				madrid.Tap(MembersVars.members_giveupSeat_combobox);
				utils.Sleep(5);
				Assert.True(utils.existsElement(MembersVars.members_combobox_nextGame), "Next Games doesn't exist");
				Assert.True(utils.existsElement(MembersVars.members_combobox_history), "History doesn't exist");
				Assert.True(utils.existsElement(MembersVars.members_combobox_notGiven), "Not Given doesn't exist");
				Assert.True(utils.existsElement(MembersVars.members_combobox_notSold), "Not Sold doesn't exist");
				Assert.True(utils.existsElement(MembersVars.members_combobox_Sold), "Sold doesn't exist");
				Assert.True(utils.existsElement(MembersVars.members_combobox_forSale), "For Sale doesn't exist");

				madrid.Tap(MembersVars.members_giveupSeat_combobox);
				Assert.True(utils.existsElement(MembersVars.members_giveupSeat_conditions), "Conditions doesn't exist");

				//Step 7: Select NOT GIVEN in the combobox
				madrid.Tap(MembersVars.members_giveupSeat_combobox);
				utils.Sleep(3);
				madrid.Tap(MembersVars.members_combobox_notGiven);
				utils.Sleep(3);

				Assert.True(utils.existsElement(MembersVars.members_giveupSeat_competition), "League doesn't exist");
				Assert.True(utils.existsElement(MembersVars.members_giveupSeat_date), "Date doesn't exist");
				Assert.True(utils.existsElement(MembersVars.members_giveupSeat_home), "Home team doesn't exist");
				Assert.True(utils.existsElement(MembersVars.members_giveupSeat_away), "Away doesn't exist");
				Assert.True(utils.existsElement(MembersVars.members_giveupSeat_status), "Status doesn't exist");

				//Step 6: Click on help button
				madrid.Tap(MembersVars.members_giveUpSeat_help);
				madrid.WaitForElement(MembersVars.members_statusPopup_body);
				Assert.True(utils.existsElement(MembersVars.members_statusPopup_notGiven), "Title doesn't exist");
				Assert.True(utils.existsElement(MembersVars.members_statusPopup_body), "Body doesn't exist");
				Assert.True(utils.existsElement(MembersVars.members_OK_but), "OK button doesn't exist");
			}
        }



        /************************ MEMBERS > LINK MEMBER ACCOUNT ************************/

        [Test]
        //See Socio linking screen through Main Menu
        public void Test_35065(){
            //Step 1: Open Application and Login
            utils.Login_data(Strings.LOGIN_USERNAME5, Strings.LOGIN_PASSWORD5);

            //Step 2: Click on Menu -> Menu is displayed
            //Step 3: Click on "Member" icon
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Socios_but);

            Assert.True(utils.existsElement(MainMenuVars.socios_Title), "Members title doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_view_title), "View title doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_memberID_label), "ID label doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_memberID_input), "ID input doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_pin_label_priv), "Pin label doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_pin_input_priv), "Pin input doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_link_but), "Link button doesn't exist");

            //Step 4: Select back button
            madrid.Tap(MembersVars.members_private_goBack);
			utils.Sleep(3);
            Assert.True(utils.seeingHome(), "Home page doesn't displayed");
        }

        [Test]
        //See Socio linking screen through Account placeholder
        public void Test_35066()
        {
            //Step 1: Open Application and Login
            utils.Login_data(Strings.LOGIN_USERNAME5, Strings.LOGIN_PASSWORD5);

            //Step 2: Go to Account placeholder
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
            utils.Sleep(3);
            madrid.WaitForElement(NavigationBarVars.profile_Title);

            //Step 3: Tap on "Carne de socio" icon
			madrid.WaitForElement(ProfileVars.link_madridista_but);
            madrid.Tap(ProfileVars.link_madridista_but);

            madrid.WaitForElement(MembersVars.members_private_title);

            Assert.True(utils.existsElement(MembersVars.members_private_title), "PRIVATE AREA page doesn't displayed");
            Assert.True(utils.existsElement(MembersVars.members_private_view), "View title doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_private_partner), "Member button doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_private_madridista), "Madridista button doesn't exist");

            //Step 4: Tap on Member button
            madrid.Tap(MembersVars.members_private_partner);
            madrid.WaitForElement(MainMenuVars.socios_Title);

            Assert.True(utils.existsElement(MainMenuVars.socios_Title), "Members page doesn't displayed");
            Assert.True(utils.existsElement(MembersVars.members_view_title), "View title doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_memberID_label), "ID label doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_memberID_input), "ID input doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_pin_label_priv), "Pin label doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_pin_input), "Pin input doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_link_but), "Link button doesn't exist");

            //Step 5: Select back button
            madrid.Tap(MembersVars.members_private_goBack);
            madrid.WaitForElement(NavigationBarVars.profile_Title);
            Assert.True(utils.existsElement(NavigationBarVars.profile_Title), "Profile page doesn't displayed");

        }

        [Test]
        //Link Socio with wrong credentials
        public void Test_35068(){
            //Step 1: Open Application and Login
            utils.Login_data(Strings.LOGIN_USERNAME5, Strings.LOGIN_PASSWORD5);

            //Step 2: Go to placeholder
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
            madrid.WaitForElement(NavigationBarVars.profile_Title);

            //Step 3: Tap on "Carne de socio" icon
            madrid.Tap(ProfileVars.link_madridista_but);
            madrid.WaitForElement(MembersVars.members_private_title);

            Assert.True(utils.existsElement(MembersVars.members_private_title), "PRIVATE AREA page doesn't displayed");
            Assert.True(utils.existsElement(MembersVars.members_private_view), "View title doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_private_partner), "Member button doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_private_madridista), "Madridista button doesn't exist");

            //Step 4: Select "Soy Socio" button
            madrid.Tap(MembersVars.members_private_partner);
            madrid.WaitForElement(MainMenuVars.socios_Title);

            Assert.True(utils.existsElement(MainMenuVars.socios_Title), "Members page doesn't displayed");
            Assert.True(utils.existsElement(MembersVars.members_view_title), "View title doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_memberID_label), "ID label doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_memberID_input), "ID input doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_pin_label_priv), "Pin label doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_pin_input), "Pin input doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_link_but), "Link button doesn't exist");

            //Step 5: Fill in "Número de Socio" with @id_socio and "PIN" with @pin and select "Vincular" button
            madrid.EnterText(MembersVars.members_memberID_input, Strings.ID_WRONG);
            madrid.EnterText(MembersVars.members_pin_input, Strings.PIN_WRONG);
            madrid.Tap(MembersVars.members_link_but);
            utils.Sleep(3);

            Assert.True(utils.existsElement(MembersVars.members_wrondID_title), "Error popup doesn't displayed");
            AppResult[] result = madrid.Query(MembersVars.members_wrondID_body);
            Assert.AreEqual(result[0].Text, Strings.MEMBER_WRONG_MESSAGE, "Description error doesn't exist");

        }

        [Test]
        //Provide PIN for a linked Socio
        public void Test_35071(){
            //Step 1: Open Application and Login
            utils.Login_data(Strings.LOGIN_USERNAME4, Strings.LOGIN_PASSWORD4);

            //Step 2: Link Member from Account placeholder -> Member is linked
            //Step 3: Close APP (kill app) -> No se puede
            //Step 4: Open application -> No se puede

            //Step 5: Go to Account placeholder
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
            madrid.WaitForElement(NavigationBarVars.profile_Title);

            //Step 6: Tap "Socio carnet" icon
            madrid.Tap(ProfileVars.link_madridista_but_linked);
            madrid.WaitForElement(MembersVars.members_popup_title);
            utils.Sleep(3);
            Assert.True(utils.existsElement(MembersVars.members_popup_title), "Popup doesn't displayed");
            Assert.True(utils.existsElement(MembersVars.members_popup_view), "Description doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_pin_input_linked), "Pin input doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_enter_but), "Enter button doesn't exist");

            //Step 7: Fill in Pin and select "Entrar" button
            this.first_time_members_view();
            madrid.WaitForElement(MainMenuVars.socios_Title);
            Assert.True(utils.existsElement(MainMenuVars.socios_Title), "Socios doesn't displayed");

            //Step 8: Go to Home
            madrid.Tap(NavigationBarVars.navbar_Home_but);
            utils.Sleep(5);
            Assert.True(utils.seeingHome(), "Home page doesn't displayed");

            //Step 9: Go to Profile and Select "Socio Carnet" icon
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
            madrid.Tap(ProfileVars.link_madridista_but_linked);
            utils.Sleep(3);
            Assert.False(utils.existsElement(MembersVars.members_popup_title), "Popup is displayed");
            Assert.False(utils.existsElement(MembersVars.members_popup_view), "Description exist");
            Assert.False(utils.existsElement(MembersVars.members_pin_input_linked), "Pin input exist");
            Assert.False(utils.existsElement(MembersVars.members_enter_but), "Enter button exist");

        }
		/*
        [Test]
        //Madridista links Socio account
        public void Test_35171(){
            //Step 1: Open Application and Login
            utils.Login_data(Strings.LOGIN_USERNAME4, Strings.LOGIN_PASSWORD4);

            //Step 2: Go to Account placeholder
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
            madrid.WaitForElement(NavigationBarVars.profile_Title);

            //Step 3: Link Madridista from Account placeholder -> Member is linked

            //Step 4: Check card
            Assert.True(utils.existsElement(ProfileVars.link_madridista_but), "Madridista card doesn't exist");

            //Step 5: Tap on EDIT PROFILE button
            madrid.Tap(ProfileVars.profile_edit_but);

            //Step 6: Tap on MORE INFO tab
            madrid.Tap(ProfileVars.moreInfo_but);
            madrid.WaitForElement(ProfileVars.moreinfo_name);
            utils.Sleep(3);
            Assert.True(utils.existsElement(ProfileVars.moreinfo_name), "Name info doesn't exist");
            Assert.True(utils.existsElement(ProfileVars.moreinfo_surname), "Surname info doesn't exist");
            Assert.True(utils.existsElement(ProfileVars.moreinfo_secondname), "SecondName info doesn't exist");

            //Step 7: Linker Member from Main menu -> member is linked
            madrid.Tap(NavigationBarVars.navbar_Home_but);
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Socios_but);
            madrid.WaitForElement(MembersVars.members_popup_title);
            utils.Sleep(3);
            this.first_time_members_view();
            utils.Sleep(3);
            madrid.WaitForElement(MainMenuVars.socios_Title);
            utils.Sleep(3);

            //Step 8: Tap on VER DATOS BUTTON
            madrid.Tap(MembersVars.members_info_but);
            utils.Sleep(3); Assert.True(utils.existsElement(ProfileVars.moreinfo_name), "Name info doesn't exist");
            Assert.True(utils.existsElement(ProfileVars.moreinfo_surname), "Surname info doesn't exist");
            Assert.True(utils.existsElement(ProfileVars.moreinfo_secondname), "SecondName info doesn't exist");

            //Step 9: Go to Account placeholder
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
            madrid.WaitForElement(NavigationBarVars.profile_Title);

            //Step 10: Check card
            Assert.True(utils.existsElement(ProfileVars.link_madridista_but), "Madridista card doesn't exist");

            //Step 11: Tap on member card
            madrid.Tap(ProfileVars.link_madridista_but);
            madrid.WaitForElement(MainMenuVars.socios_Title);
            Assert.True(utils.existsElement(MainMenuVars.socios_Title), "Member page doesn't displayed");
            Assert.True(utils.existsElement(MembersVars.members_partner_name), "Name doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_partner_surname), "Surname doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_partner_number), "Number doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_partner_season), "Season doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_partner_info), "Info doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_partner_photo), "Photo doesn't exist");

        }
		*/
        /************************ MEMBERS > MAIN MEMBER VIEW ************************/

        /*
        [Test]
        //See socio main screen after sending app to background
        public void Test_35077(){
            //Step 1: Open Application and Login
            utils.Login_data(Strings.LOGIN_USERNAME4, Strings.LOGIN_PASSWORD4);

            //Step 2: Link Member from Account placeholder -> Member is linked

            //Step 3: Open another app without killing Real Madrid app
            //NO PODEMOS


        }
        */

        [Test]
        //Main pay member view
        public void Test_35078(){
            //Step 1: Open Application and Login
            utils.Login_data(Strings.LOGIN_USERNAME4, Strings.LOGIN_PASSWORD4);

            //Step 2: New socio is pay member

            //Step 3: Link Member from Account placeholder -> Member is linked

            //Step 4: Go to profile
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
            madrid.WaitForElement(NavigationBarVars.profile_Title);
            Assert.True(utils.existsElement(NavigationBarVars.profile_Title), "Profile page doesn't displayed");

            //Step 5: Select "Socio card" icon
            madrid.Tap(ProfileVars.link_madridista_but_linked);
            utils.Sleep(3);
            this.first_time_members_view();
            utils.Sleep(3);

            madrid.WaitForElement(MainMenuVars.socios_Title);
            Assert.True(utils.existsElement(MainMenuVars.socios_Title), "Members page doesn't displayed");
            Assert.True(utils.existsElement(MembersVars.members_partner_photo), "Photo doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_updatePhoto), "Update Photo button doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_partner_name), "Partner name doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_partner_surname), "Partner surname doesn't exist");
            madrid.WaitForElement(MembersVars.members_partner_number);
			utils.Sleep(3);
			Assert.True(utils.existsElement(MembersVars.members_partner_number), "Partner number doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_partner_card ), "Card info doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_info_but), "SEE DATA link doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_card_but), "SEE CARD button doesn't exist");
            utils.Sleep(3);
			madrid.WaitForElement(MembersVars.members_giveUpSeat_but);
			Assert.True(utils.existsElement(MembersVars.members_giveUpSeat_but), "GIVE UP button doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_virtualOffice), "VIRTUAL OFFICE links doesn't exist");


        }

        [Test]
        //Main non pay member view
        public void Test_35079(){
            //Step 1: Open Application and Login
            utils.Login_data(Strings.LOGIN_USERNAME, Strings.LOGIN_PASSWORD);

            //Step 2: New socio is pay member

            //Step 3: Link Member from Account placeholder -> Member is linked

            //Step 4: Go to profile
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
            madrid.WaitForElement(NavigationBarVars.profile_Title);
            Assert.True(utils.existsElement(NavigationBarVars.profile_Title), "Profile page doesn't displayed");

            //Step 5: Select "Socio card" icon
            madrid.Tap(ProfileVars.link_madridista_but_linked);
            utils.Sleep(3);
            this.first_time_members_view();
            utils.Sleep(8);

            madrid.WaitForElement(MainMenuVars.socios_Title);
            Assert.True(utils.existsElement(MainMenuVars.socios_Title), "Members page doesn't displayed");
            Assert.True(utils.existsElement(MembersVars.members_partner_photo), "Photo doesn't exist");
            madrid.WaitForElement(MembersVars.members_updatePhoto);
			Assert.True(utils.existsElement(MembersVars.members_updatePhoto), "Update Photo button doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_partner_name), "Partner name doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_partner_surname), "Partner surname doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_partner_number), "Partner number doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_partner_withoutCard), "Card info doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_info_but), "SEE DATA link doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_card_but), "SEE CARD button doesn't exist");
            Assert.False(utils.existsElement(MembersVars.members_giveUpSeat_but), "GIVE UP button exist");
            Assert.True(utils.existsElement(MembersVars.members_virtualOffice), "VIRTUAL OFFICE links doesn't exist");
 
        }

        /************************ MEMBERS > MY DATA ************************/
        /*
		[Test]
        //Socio card not edit some fields in profile info
        public void Test_35080(){
            //Step 1: Open application and Login
            utils.Login_data(Strings.LOGIN_USERNAME4, Strings.LOGIN_PASSWORD4);

            //Step 2: Link Member from Account placeholder -> Member is linked

            //Step 3: Go to profile
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
            madrid.WaitForElement(NavigationBarVars.profile_Title);
            Assert.True(utils.existsElement(NavigationBarVars.profile_Title), "Profile page ins't displayed");

            //Step 4: Select "Edit Profile" button
            madrid.Tap(ProfileVars.profile_edit_but);
            utils.Sleep(3);
            Assert.True(utils.existsElement(ProfileVars.profile_avatar), "Edit profile page doesn't displayed");

            //Step 5: Go to more info
            madrid.Tap(ProfileVars.moreInfo_but);

            Assert.True(utils.existsElement(ProfileVars.moreinfo_name), "Name member doesn't exit");
            Assert.True(utils.existsElement(ProfileVars.moreinfo_surname), "Surname member doesn't exit");
            Assert.True(utils.existsElement(ProfileVars.moreinfo_secondname), "Second name member doesn't exit");
            this.assert_element(ProfileVars.moreinfo_doc_type_spinner);
            this.assert_element(ProfileVars.moreinfo_birthday);
            this.assert_element(ProfileVars.moreinfo_country);
            this.assert_element(ProfileVars.moreinfo_mobile_number);
            this.assert_element(ProfileVars.moreinfo_home_number);
            this.assert_element(ProfileVars.moreinfo_address);
            this.assert_element(ProfileVars.moreinfo_zip);
            this.assert_element(ProfileVars.moreinfo_city);
            this.assert_element(ProfileVars.moreinfo_mobile_number);
            this.assert_element(ProfileVars.moreinfo_nocommunicationstorm);
            this.assert_element(ProfileVars.moreinfo_noinfotothirds);

            utils.ScrollUp_To_Element(ProfileVars.moreinfo_member_but);
            utils.Go_To(HomeVars.home_content, ProfileVars.moreinfo_gender_spinner);
            madrid.Tap(ProfileVars.moreinfo_gender_spinner);
            Assert.True(utils.existsElement(ProfileVars.moreinfo_gender_Male) && utils.existsElement(ProfileVars.moreinfo_gender_Female),
                            "Gender options doesn't displayed");
            madrid.Back();
            utils.Go_To(HomeVars.home_content, ProfileVars.moreinfo_language);
            madrid.Tap(ProfileVars.moreinfo_language);
            Assert.True(madrid.Query(ProfileVars.moreinfo_generalOptions).Length > 1,
                            "Language options doesn't displayed");
            madrid.Back();
            utils.Go_To(HomeVars.home_content, ProfileVars.moreinfo_persontitle_spinner);
            madrid.Tap(ProfileVars.moreinfo_persontitle_spinner);
            Assert.True(utils.existsElement(ProfileVars.moreinfo_persontitle_Sr) && utils.existsElement(ProfileVars.moreinfo_persontitle_Sra),
                            "Person title options doesn't displayed");
            madrid.Back();
            utils.Go_To(HomeVars.home_content, ProfileVars.moreinfo_sport_spinner);
            madrid.Tap(ProfileVars.moreinfo_sport_spinner);
            Assert.True(utils.existsElement(ProfileVars.moreinfo_sport_Futbol) 
                        && utils.existsElement(ProfileVars.moreinfo_sport_Basket)
                        && utils.existsElement(ProfileVars.moreinfo_sport_Both),
                            "Sport options doesn't displayed");
            madrid.Back();
            Assert.True(utils.existsElement(ProfileVars.moreinfo_sendtostore), "Checkin box doesn't exist");

        }
		*/
        /************************ MEMBERS > UPDATE PHOTO ************************/

        [Test]
        //Update of photo page
        public void Test_35104(){
            //Step 1: Open application and Login
            utils.Login_data(Strings.LOGIN_USERNAME4, Strings.LOGIN_PASSWORD4);

            //Step 2: Link Member from Account placeholder -> member is linked

            //Step 3: Select "Update Photo"
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Socios_but);
            utils.Sleep(3);
            this.first_time_members_view();
            utils.Sleep(3);
            madrid.Tap(MembersVars.members_updatePhoto);
            madrid.WaitForElement(MembersVars.updatePhoto_title);

            Assert.True(utils.existsElement(MembersVars.updatePhoto_title), "Update photo page doesn't displayed");
            Assert.True(utils.existsElement(MembersVars.updatePhoto_header), "Header info doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_partner_photo), "Photo doesn't exist");
            Assert.True(utils.existsElement(MembersVars.updatePhoto_file), "SELECT FILE button doesn't exist");
            Assert.True(utils.existsElement(MembersVars.updatePhoto_info), "Info doesn't exist");
            Assert.True(utils.existsElement(MembersVars.updatePhoto_moreInfo), "More info link doesn't exist");
            Assert.True(utils.existsElement(MembersVars.updatePhoto_upload_but), "UPLOAD IMAGE button doesn't exist");
            Assert.True(utils.existsElement(MembersVars.updatePhoto_cancel), "CANCEL button doesn't exist");

        }

        /************************ MEMBERS > VIEW CARD ************************/

        [Test]
        //See card of Socio infantil
        public void Test_35088() {
            //Step 1: Open Application and Login
            utils.Login_data(Strings.LOGIN_USERNAME6, Strings.LOGIN_PASSWORD6);

            //Step 2: Go to Account placeholder
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
            madrid.WaitForElement(NavigationBarVars.profile_Title);

            //Step 3: Check member card
            Assert.True(utils.existsElement(ProfileVars.link_madridista_but_linked), "Member card doesn't exist");

            //Step 4: Tap on member card
            madrid.Tap(ProfileVars.link_madridista_but_linked);
            utils.Sleep(3);
            this.first_time_members_view();
            madrid.WaitForElement(MainMenuVars.socios_Title);
            utils.Sleep(3);
			//madrid.WaitForElement(MembersVars.members_partner_card);
            //Assert.True(utils.existsElement(MembersVars.members_partner_card), "'Abonado' member card doesn't exist");

            //Step 5: Tap on SEE CARD
            madrid.Tap(MembersVars.members_card_but);
            utils.Sleep(5);

            Assert.True(utils.existsElement(MembersVars.members_card_photo), "Photo member doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_card_name), "Name and surname member doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_card_number), "Number member doesn't exist");

            //Step 6: Tap on or swipe it on the member card
            madrid.Tap(MembersVars.members_card_front);
            utils.Sleep(5);

            Assert.True(utils.existsElement(MembersVars.members_card_QR), "QR code doesn't exist");

        }

        [Test]
        //See card Adulto
        public void Test_35114()
        {
            //Step 1: Open Application and Login
            utils.Login_data(Strings.LOGIN_USERNAME7, Strings.LOGIN_PASSWORD7);

            //Step 2: Go to main Member view
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Socios_but);
            utils.Sleep(3);
            this.first_time_members_view();
            utils.Sleep(3);

            //Step 3: Check member seat info
			//madrid.WaitForElement(MembersVars.members_partner_card);
            //Assert.True(utils.existsElement(MembersVars.members_partner_card), "'Abonado' member card doesn't exist");

            //Step 4: Tap on SEE CARD
            madrid.Tap(MembersVars.members_card_but);
            utils.Sleep(5);

            Assert.True(utils.existsElement(MembersVars.members_card_photo), "Photo member doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_card_name), "Name and surname member doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_card_number), "Number member doesn't exist");

            //Step 6: Tap on or swipe it on the member card
            madrid.Tap(MembersVars.members_card_front);
            utils.Sleep(5);

            Assert.True(utils.existsElement(MembersVars.members_card_QR), "QR code doesn't exist");

        }

        [Test]
        //See card Adulto Representante
        public void Test_35115() {

            //Step 1: Open Application and Login
            utils.Login_data(Strings.LOGIN_USERNAME8, Strings.LOGIN_PASSWORD8);

            //Step 2: Go to main Member view
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Socios_but);
            utils.Sleep(3);
            this.first_time_members_view();
            utils.Sleep(5);

            //Step 3: Check member seat info
			//madrid.WaitForElement(MembersVars.members_partner_card);
            //Assert.True(utils.existsElement(MembersVars.members_partner_card), "'Abonado' member card doesn't exist");

            //Step 4: Tap on SEE CARD
            madrid.Tap(MembersVars.members_card_but);
            utils.Sleep(5);

            Assert.True(utils.existsElement(MembersVars.members_card_photo), "Photo member doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_card_name), "Name and surname member doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_card_number), "Number member doesn't exist");

            //Step 6: Tap on or swipe it on the member card
            madrid.Tap(MembersVars.members_card_front);
            utils.Sleep(5);

            Assert.True(utils.existsElement(MembersVars.members_card_QR), "QR code doesn't exist");

        }


        [Test]
        //See card Member Plata
        public void Test_35116()
        {

            //Step 1: Open Application and Login
            utils.Login_data(Strings.LOGIN_USERNAME9, Strings.LOGIN_PASSWORD9);

            //Step 2: Go to main Member view
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Socios_but);
            utils.Sleep(3);
            this.first_time_members_view();
            utils.Sleep(5);

            //Step 3: Check member seat info
			//madrid.WaitForElement(MembersVars.members_partner_card);
            //Assert.True(utils.existsElement(MembersVars.members_partner_card), "'Abonado' member card doesn't exist");

            //Step 4: Tap on SEE CARD
            madrid.Tap(MembersVars.members_card_but);
            utils.Sleep(5);

			madrid.WaitForElement(MembersVars.members_card_photo);
            Assert.True(utils.existsElement(MembersVars.members_card_photo), "Photo member doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_card_name), "Name and surname member doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_card_number), "Number member doesn't exist");

            //Step 6: Tap on or swipe it on the member card
            madrid.Tap(MembersVars.members_card_front);
            utils.Sleep(5);

            Assert.True(utils.existsElement(MembersVars.members_card_QR), "QR code doesn't exist");

        }


        [Test]
        //See card Member Plata Representante
        public void Test_35117()
        {

            //Step 1: Open Application and Login
            utils.Login_data(Strings.LOGIN_USERNAME10, Strings.LOGIN_PASSWORD10);

            //Step 2: Go to main Member view
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Socios_but);
            utils.Sleep(3);
            this.first_time_members_view();
            utils.Sleep(5);

            //Step 3: Check member seat info
			//madrid.WaitForElement(MembersVars.members_partner_card);
            //Assert.True(utils.existsElement(MembersVars.members_partner_card), "'Abonado' member card doesn't exist");

            //Step 4: Tap on SEE CARD
            madrid.Tap(MembersVars.members_card_but);
            utils.Sleep(5);

			madrid.WaitForElement(MembersVars.members_card_photo);
            Assert.True(utils.existsElement(MembersVars.members_card_photo), "Photo member doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_card_name), "Name and surname member doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_card_number), "Number member doesn't exist");

            //Step 6: Tap on or swipe it on the member card
            madrid.Tap(MembersVars.members_card_front);
            utils.Sleep(5);

            Assert.True(utils.existsElement(MembersVars.members_card_QR), "QR code doesn't exist");

        }

        [Test]
        //See card Oro
        public void Test_35118()
        {

            //Step 1: Open Application and Login
            utils.Login_data(Strings.LOGIN_USERNAME11, Strings.LOGIN_PASSWORD11);

            //Step 2: Go to main Member view
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Socios_but);
            utils.Sleep(3);
            this.first_time_members_view();
            utils.Sleep(5);

            //Step 3: Check member seat info
			//madrid.WaitForElement(MembersVars.members_partner_card);
            //Assert.True(utils.existsElement(MembersVars.members_partner_card), "'Abonado' member card doesn't exist");

            //Step 4: Tap on SEE CARD
            madrid.Tap(MembersVars.members_card_but);
            utils.Sleep(5);

			madrid.WaitForElement(MembersVars.members_card_photo);
            Assert.True(utils.existsElement(MembersVars.members_card_photo), "Photo member doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_card_name), "Name and surname member doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_card_number), "Number member doesn't exist");

            //Step 6: Tap on or swipe it on the member card
            madrid.Tap(MembersVars.members_card_front);
            utils.Sleep(5);

            Assert.True(utils.existsElement(MembersVars.members_card_QR), "QR code doesn't exist");

        }

        [Test]
        //See card Oro Representante
        public void Test_35119()
        {

            //Step 1: Open Application and Login
            utils.Login_data(Strings.LOGIN_USERNAME12, Strings.LOGIN_PASSWORD12);

            //Step 2: Go to main Member view
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Socios_but);
            utils.Sleep(3);
            this.first_time_members_view();
            utils.Sleep(5);

            //Step 3: Check member seat info
			//madrid.WaitForElement(MembersVars.members_partner_card);
            //Assert.True(utils.existsElement(MembersVars.members_partner_card), "'Abonado' member card doesn't exist");

            //Step 4: Tap on SEE CARD
            madrid.Tap(MembersVars.members_card_but);
            utils.Sleep(5);

			madrid.WaitForElement(MembersVars.members_card_photo);
            Assert.True(utils.existsElement(MembersVars.members_card_photo), "Photo member doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_card_name), "Name and surname member doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_card_number), "Number member doesn't exist");

            //Step 6: Tap on or swipe it on the member card
            madrid.Tap(MembersVars.members_card_front);
            utils.Sleep(5);

            Assert.True(utils.existsElement(MembersVars.members_card_QR), "QR code doesn't exist");

        }


        [Test]
        //See card Diamante
        public void Test_35120()
        {

            //Step 1: Open Application and Login
            utils.Login_data(Strings.LOGIN_USERNAME13, Strings.LOGIN_PASSWORD13);

            //Step 2: Go to main Member view
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Socios_but);
            utils.Sleep(3);
            this.first_time_members_view();
            utils.Sleep(5);

            //Step 3: Check member seat info
			//madrid.WaitForElement(MembersVars.members_partner_card);
            //Assert.True(utils.existsElement(MembersVars.members_partner_card), "'Abonado' member card doesn't exist");

            //Step 4: Tap on SEE CARD
            madrid.Tap(MembersVars.members_card_but);
            utils.Sleep(5);

			madrid.WaitForElement(MembersVars.members_card_photo);
            Assert.True(utils.existsElement(MembersVars.members_card_photo), "Photo member doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_card_name), "Name and surname member doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_card_number), "Number member doesn't exist");

            //Step 6: Tap on or swipe it on the member card
            madrid.Tap(MembersVars.members_card_front);
            utils.Sleep(5);

            Assert.True(utils.existsElement(MembersVars.members_card_QR), "QR code doesn't exist");

        }

        [Test]
        //See card Member Diamante representante
        public void Test_35121()
        {

            //Step 1: Open Application and Login
            utils.Login_data(Strings.LOGIN_USERNAME14, Strings.LOGIN_PASSWORD14);

            //Step 2: Go to main Member view
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Socios_but);
            utils.Sleep(3);
            this.first_time_members_view();
            utils.Sleep(5);

            //Step 3: Check member seat info
			//madrid.WaitForElement(MembersVars.members_partner_card);
            //Assert.True(utils.existsElement(MembersVars.members_partner_card), "'Abonado' member card doesn't exist");

            //Step 4: Tap on SEE CARD
            madrid.Tap(MembersVars.members_card_but);
            utils.Sleep(5);

			madrid.WaitForElement(MembersVars.members_card_photo);
            Assert.True(utils.existsElement(MembersVars.members_card_photo), "Photo member doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_card_name), "Name and surname member doesn't exist");
            Assert.True(utils.existsElement(MembersVars.members_card_number), "Number member doesn't exist");

            //Step 6: Tap on or swipe it on the member card
            madrid.Tap(MembersVars.members_card_front);
            utils.Sleep(5);

            Assert.True(utils.existsElement(MembersVars.members_card_QR), "QR code doesn't exist");

        }

       

        //Auxiliary methods
        private void first_time_members_view() {
            if (utils.existsElement(MembersVars.members_popup_title)){
                madrid.Tap(MembersVars.members_pin_input_linked);
                madrid.EnterText(MembersVars.members_pin_input_linked, Strings.MEMBERS_PIN);
				madrid.DismissKeyboard();
				//madrid.PressEnter();
				madrid.Tap(MembersVars.members_enter_but);
            }
        }

        private void check_status_match (AppResult[] list, String status ){

            for (int i = 0; i < list.Length; i++){

                if (list[i].Text == status ){

                    madrid.Tap(a => a.Id("cede_info_icon").Index(i));
                    Assert.True(utils.existsElement(a => a.Id("tv_title").Text(status)), "Title doesn't exist");
                    Assert.True(utils.existsElement(MembersVars.members_statusPopup_body), "Text body doesn't exist");
                    Assert.True(utils.existsElement(MembersVars.members_OK_but), "Ok button doesn't exist");

                }
            }
        }
		/*
        private void assert_element(Func<AppQuery, AppQuery> element){
            while ((!utils.existsElement(element)) && (!utils.existsElement(ProfileVars.moreinfo_noinfotothirds)))
                madrid.ScrollDown(HomeVars.home_content, ScrollStrategy.Gesture, 0.20, 3000, true);

            Assert.True(utils.existsElement(element), element.ToString() + "doesn't exist");
        }
		*/
        
    }
}
