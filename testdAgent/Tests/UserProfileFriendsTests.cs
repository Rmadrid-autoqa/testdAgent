using NUnit.Framework;
using RealMadrid_UITest.Variables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest;

namespace RealMadrid_UITest.Tests
{
    //[TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]

    public class UserProfileFriendsTests { 
     IApp madrid;
    Utilities utils;
    Platform platform;



    public UserProfileFriendsTests(Platform platform)
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
       
    }


    [TearDown]
    public void AfterEachTest()
    {
        //            utils.Enter_Home();
        //            utils.Sign_Off();
    }


        [Test]
		// Friends placeholder
        public void Test_35499()
        {
            // Step 1:Open Application and Login.
            utils.Login_data(Strings.LOGIN_USERNAME_FULL, Strings.LOGIN_PASSWORD_FULL);
            // Step 2:Go to profile
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
            // Step 3:Scroll down to "Friends" placeholder.
            //utils.Go_To(ProfileVars.friends_title_en, ProfileVars.personal_area_view, 5, "No se encuentra el placeholder de amigos");
            //utils.Go_To(ProfileVars.friends_view_all_but, ProfileVars.personal_area_view, 5, "No se encuentra el boton de ver todos en el placeholder de amigos");
            //utils.Go_To(ProfileVars.friends_first_friend_but, ProfileVars.personal_area_view, 5, "No se encuentra ningun amigo en el placeholder de amigos");
            
			madrid.ScrollDownTo(ProfileVars.friends_title);
			madrid.ScrollDownTo(ProfileVars.friends_view_all_but);
			utils.Sleep(2);
			madrid.ScrollDownTo(ProfileVars.friends_first_friend_but);

			// Step 4:Tap on a friend.
            madrid.Tap(ProfileVars.friends_first_friend_but);
            Assert.True(utils.existsElement(ProfileVars.friends_friend_page), "No se encuentra la pagina de un amigo en amigos");
            // Step 5:Tap on 'Back' button.
            madrid.Tap(SocialVars.profile_account_GoBack_but);
			madrid.WaitForElement(ProfileVars.friends_title);
            Assert.True(utils.existsElement(ProfileVars.friends_title), "No se encuentra el placeholder de amigos");
            // Step 6: Tap on the "View All" in the friends placeholder
            madrid.Tap(ProfileVars.friends_view_all_but);
            madrid.WaitForElement(SocialVars.friends_friend_page);
			Assert.True(utils.existsElement(SocialVars.friends_friend_page), "No se muestra la pagina de social al hacer click en un amigo en amigos");
            // Step 7:Tap on 'Back' button.
            madrid.Tap(SocialVars.profile_account_GoBack_but);
            madrid.WaitForElement(ProfileVars.friends_title);
			Assert.True(utils.existsElement(ProfileVars.friends_title), "No se encuentra el placeholder de amigos");
        }

        [Test]
		// Friends placeholder showes a message when user has no friends
        public void Test_35580()
        {
            // Step 1:Open Application and Login.
            utils.Login_data(Strings.LOGIN_USERNAME_NOTLINKED, Strings.LOGIN_PASSWORD_NOTLINKED);
            // Step 2:Go to profile
            madrid.Tap(NavigationBarVars.navbar_Profile_but);

            //utils.Go_To(ProfileVars.friends_title, ProfileVars.personal_area_view, 5, "No se encuentra el placeholder de amigos");
            //utils.Go_To(ProfileVars.friends_view_all_but, ProfileVars.personal_area_view, 5, "No se encuentra el boton de ver todos en el placeholder de amigos");
            //utils.Go_To(ProfileVars.friends_no_friend_msg, ProfileVars.personal_area_view, 5, "No se encuentra el mensaje de no amigos en el placeholder de amigos");

			madrid.ScrollDownTo(ProfileVars.friends_title);
			madrid.ScrollDownTo(ProfileVars.friends_view_all_but);
			utils.Sleep(2);
			madrid.ScrollDownTo(ProfileVars.friends_no_friend_msg);


        }

    }
}