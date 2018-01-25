using NUnit.Framework;
using RealMadrid_UITest.Tools;
using RealMadrid_UITest.Variables;
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


    public class SocialTest
    {
        IApp madrid;
        Utilities utils;
        Platform platform;



        public SocialTest(Platform platform)
        {
            this.platform = platform;
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
                        //utils.Enter_Home();
                        //utils.Sign_Off();
        }

        // Auxiliary methods

        private void Go_To_up(Func<AppQuery, AppQuery> view, Func<AppQuery, AppQuery> element)
        {
            while (madrid.Query(element).Length == 0)
            {
                madrid.ScrollUp(view, ScrollStrategy.Gesture, 0.80, 3000, true);
            }
        }

        private void Go_To_slow(Func<AppQuery, AppQuery> view, Func<AppQuery, AppQuery> element)
        {
            while (madrid.Query(element).Length == 0)
            {
                madrid.ScrollDown(view, ScrollStrategy.Gesture, 0.30, 600, true);
            }
        }

		//Agregar a un amigo

		private void sendInvitationFriend()

		{

			utils.Sleep(2);
			madrid.Tap(NavigationBarVars.navbar_Social_but);
			utils.Sleep(2);
			madrid.WaitForElement(SocialVars.friends_tab_Amigos);
			madrid.Tap(SocialVars.friends_tab_Amigos);
			madrid.WaitForElement(SocialVars.Friends_tab_SearchBox);
			utils.Sleep(6);
			madrid.EnterText(SocialVars.Friends_tab_SearchBox, "DiegoAlonso");
			//madrid.DismissKeyboard();
			utils.Sleep(3);
			madrid.PressEnter();
			utils.Sleep(3);
			madrid.WaitForElement(SocialVars.Friends_ImageShorcuts_DiegoAlonso);
			madrid.Tap(SocialVars.Friends_ImageShorcuts_DiegoAlonso);
			//madrid.Tap(SocialVars.Friends_tab_AliasFriends_DiegoAlonso);
			madrid.WaitForElement(SocialVars.profile_account_addNoFriend_but);
			madrid.Tap(SocialVars.profile_account_addNoFriend_but);
			utils.Sleep(6);
			madrid.WaitForElement(SocialVars.FriendRequestSent_popup_ok_but);
			madrid.Tap(SocialVars.FriendRequestSent_popup_ok_but);

		}

		//Aceptar invitacion de amistad

		private void acceptInvitationFriend()

		{

		madrid.Tap(NavigationBarVars.navbar_Social_but);
		madrid.WaitForElement(SocialVars.Friends_tab_PendingInvitationAmount_icon);
		madrid.Tap(SocialVars.Friends_tab_PendingInvitationAmount_icon);
		madrid.WaitForElement(SocialVars.Friends_tab_Accept_FriendRequest_but);
		madrid.Tap(SocialVars.Friends_tab_Accept_FriendRequest_but);
		madrid.WaitForElement(SocialVars.FriendRequestSent_popup_ok_but);
		madrid.Tap(SocialVars.FriendRequestSent_popup_ok_but);

		}

		//Denegar invitacion de amistad

		private void removeInvitationFriend()

		{

		madrid.Tap(NavigationBarVars.navbar_Social_but);
		madrid.WaitForElement(SocialVars.Friends_tab_PendingInvitationAmount_icon);
		madrid.DoubleTap(SocialVars.Friends_tab_PendingInvitationAmount_icon);
		madrid.WaitForElement(SocialVars.Friends_tab_Reject_FriendRequest_but);
		madrid.Tap(SocialVars.Friends_tab_Reject_FriendRequest_but);

		}


		//Eliminar un amigo

		private void removeFriend()

		{

			madrid.Tap(NavigationBarVars.navbar_Social_but);
			madrid.WaitForElement(SocialVars.friends_tab_Amigos);
			madrid.Tap(SocialVars.friends_tab_Amigos);
			this.Go_To_slow(HomeVars.home_content,SocialVars.Friends_tab_AliasFriends_DiegoAlonso);
			madrid.Tap(SocialVars.Friends_ImageShorcuts_DiegoAlonso);
			madrid.WaitForElement(SocialVars.profile_account_delete_but);
			madrid.Tap(SocialVars.profile_account_delete_but);
			madrid.WaitForElement(SocialVars.FriendRequestSent_popup_ok_but);
			madrid.Tap(SocialVars.FriendRequestSent_popup_ok_but);

		}
        /******************************************** SOCIAL / Chat ************************************************/

        [Test]
        //Send a message
        public void Test_35920()
        {
			utils.Login_data(Strings.LOGIN_USERNAME_FRIENDS, Strings.LOGIN_PASSWORD_FRIENDS);
            //Step 2: Go to social through the navbar
            madrid.Tap(NavigationBarVars.navbar_Social_but);
            Assert.True(utils.existsElement(SocialVars.friends_friend_page), "Social title isn't displayed");
            //Step 3: Tap on chat tab
            madrid.WaitForElement(SocialVars.friends_tab_Conversaciones);
            madrid.Tap(SocialVars.friends_tab_Conversaciones);

			madrid.WaitForElement(SocialVars.Conversation_tab_friendsname);
            AppResult[] FriendsName;
            FriendsName = madrid.Query(SocialVars.Conversation_tab_friendsname);
            string FriendsName1 = FriendsName[0].Text;


            //Step 4: Select one person
            madrid.Tap(SocialVars.Conversation_tab_chat_info);

			Assert.True(utils.existsElement(b=> b.Marked(FriendsName1)));
            //Assert.True(utils.existsElement(a=> a.Marked(FriendsName1)));
			//madrid.WaitForElement(SocialVars.Conversation_detail_FriendHeader_title);
			//AppResult[] FriendNameDetail;
            //FriendNameDetail = madrid.Query(SocialVars.Conversation_detail_FriendHeader_title);
            //string FriendNameDetail1 = FriendNameDetail[0].Text;

            //Assert.True(FriendNameDetail1.Equals(FriendsName1),"Name Friend conversations list is not the same as conversation detail");

            //Step 5: Send a message
            madrid.WaitForElement(SocialVars.Conversation_detail_enterText);
            string TextToSend = DateTime.Now.ToString();
            madrid.EnterText(SocialVars.Conversation_detail_enterText, TextToSend);
            madrid.Tap(SocialVars.Conversation_detail_sendText);
            utils.Sleep(5);
			Assert.True(utils.existsElement(b=> b.Text(TextToSend)));
            /*AppResult[] textsent;
            textsent = madrid.Query(SocialVars.Conversation_detail_TextMessage);
            bool a = false;
            for (int i =0; i< textsent.Length; i++)
            {
                if (textsent[i].Text.Equals(TextToSend))
                {
                    i = textsent.Length;
                    a = true;
                        }
            }
            Assert.True((a), "Text sent isn't displayed");  */
        }

        [Test]
        //Send a message with multiple lines
        public void Test_35922()
        {
            utils.Login_data(Strings.LOGIN_USERNAME_FRIENDS, Strings.LOGIN_PASSWORD_FRIENDS);
			//utils.Login_data("qadevios4@yopmail.com", "P@ssword.1");
            //Step 2: Go to social through the navbar.
            madrid.Tap(NavigationBarVars.navbar_Social_but);
            Assert.True(utils.existsElement(SocialVars.friends_friend_page), "Social title isn't displayed");
            //Step 3: Tap on chat tab.
            madrid.WaitForElement(SocialVars.friends_tab_Conversaciones);
            madrid.Tap(SocialVars.friends_tab_Conversaciones);

			madrid.WaitForElement(SocialVars.Conversation_tab_friendsname);
            AppResult[] FriendsName;
            FriendsName = madrid.Query(SocialVars.Conversation_tab_friendsname);
            string FriendsName1 = FriendsName[0].Text;


            //Step 4: Select one person.
            madrid.Tap(SocialVars.Conversation_tab_chat_info);

			Assert.True(utils.existsElement(b=> b.Marked(FriendsName1)));
            /*AppResult[] FriendNameDetail;
            FriendNameDetail = madrid.Query(SocialVars.Conversation_detail_FriendHeader_title);
            string FriendNameDetail1 = FriendNameDetail[0].Text;

            Assert.True(FriendNameDetail1.Equals(FriendsName1), "Name Friend conversations list is not the same as conversation detail");
			*/

            //Step 5: Send @number lines in message.
            //@number = 2 lines

            madrid.WaitForElement(SocialVars.Conversation_detail_enterText);
            string TextToSend = "Test 3922: El Real Madrid Club de Fútbol, mejor conocido como Real Madrid, es una entidad polideportiva con sede en Madrid, España. Fue declarada oficialmente registrada por sus socios el 6 de marzo de 1902 con el único objeto de la práctica del fútbol " + DateTime.Now.ToString();
            string TextToSend2 = "Test 3922: El Real Madrid Club de Fútbol, mejor conocido como Real Madrid, es una entidad polideportiva con sede en Madrid, España. Fue declarada oficialmente registrada por sus socios el 6 de marzo de 1902 con el único objeto de la práctica del fútbol Abocado desde sus inicios al desarrollo del fútbol, práctica para la que fue fundado, pronto adquirió un carácter multideportivo que le llevó a desarrollar varias disciplinas dentro del seno de la entidad." + DateTime.Now.ToString();
            madrid.EnterText(SocialVars.Conversation_detail_enterText, TextToSend);
            madrid.WaitForElement(SocialVars.Conversation_detail_sendText);
            madrid.Tap(SocialVars.Conversation_detail_sendText);

            utils.Sleep(5);

			Assert.True(utils.existsElement(b=> b.Text(TextToSend)));

            /*AppResult[] textsent;
            textsent = madrid.Query(SocialVars.Conversation_detail_TextMessage);
            bool a = false;
            for (int i = 0; i < textsent.Length; i++)
            {
                if (textsent[i].Text.Equals(TextToSend))
                {
                    i = textsent.Length;
                    a = true;
                }
            }
            Assert.True((a), "Text sent 2 lines isn't displayed");*/

            //@number = 10 lines
            madrid.EnterText(SocialVars.Conversation_detail_enterText, TextToSend2);
            madrid.WaitForElement(SocialVars.Conversation_detail_sendText);
            madrid.Tap(SocialVars.Conversation_detail_sendText);

            utils.Sleep(5);

			Assert.True(utils.existsElement(b=> b.Text(TextToSend2)));

            /*AppResult[] textsent2;
            textsent2 = madrid.Query(SocialVars.Conversation_detail_TextMessage);
            bool b = false;
            for (int i = 0; i < textsent2.Length; i++)
            {
                if (textsent2[i].Text.Equals(TextToSend2))
                {
                    i = textsent2.Length;
                    b = true;
                }
            }
            Assert.True((b), "Text 10 lines sent isn't displayed");*/
        }

		/*
        [Test]
        //Open a conversation through the chat tab in social page
        public void Test_35928()
        {
			utils.Login_data(Strings.LOGIN_USERNAME_FRIENDS, Strings.LOGIN_PASSWORD_FRIENDS);
			//utils.Login_data("qadevios4@yopmail.com", "P@ssword.1");
            //Step 2: Go to social through the navbar.
            madrid.Tap(NavigationBarVars.navbar_Social_but);
            Assert.True(utils.existsElement(SocialVars.friends_friend_page), "Social title isn't displayed");
            //Step 3: Tap on chat tab.
            madrid.WaitForElement(SocialVars.friends_tab_Conversaciones);
            madrid.Tap(SocialVars.friends_tab_Conversaciones);

            AppResult[] FriendsName;
            FriendsName = madrid.Query(SocialVars.Conversation_tab_friendsname);
            string FriendsName1 = FriendsName[0].Text;


            AppResult[] Unread;
            Unread = madrid.Query(SocialVars.Conversation_tab_unread_chats_icon);
            int UnreadCount = Unread.Length;

            //Step 4: Click on highlighted conversation
            madrid.Tap(SocialVars.Conversation_tab_unread_chats_icon);

            AppResult[] FriendNameDetail;
            FriendNameDetail = madrid.Query(SocialVars.Conversation_detail_FriendHeader_title);
            string FriendNameDetail1 = FriendNameDetail[0].Text;

            Assert.True(FriendNameDetail1.Equals(FriendsName1), "Name Friend conversations list is not the same as conversation detail");

            //Step 5: Tab on back button and check the conversation is not highlighted.
            madrid.Back();

            AppResult[] Unread2;
            Unread2 = madrid.Query(SocialVars.Conversation_tab_unread_chats_icon);
            int UnreadCount2 = Unread2.Length;

            Assert.True((UnreadCount2<UnreadCount), "Highlight button unread is displayed"+ " After chat openned " +UnreadCount2 +"  Before chat openned " + UnreadCount);
        }*/
		
        [Test]
        //See chat history
        public void Test_35940()
        {
            utils.Login_data(Strings.LOGIN_USERNAME_FRIENDS, Strings.LOGIN_PASSWORD_FRIENDS);
			//utils.Login_data("qadevios4@yopmail.com", "P@ssword.1");
            //Step 3: Go to social through the navbar.
            madrid.Tap(NavigationBarVars.navbar_Social_but);
            Assert.True(utils.existsElement(SocialVars.friends_friend_page), "Social title isn't displayed");

            //Step 4: Tap on chat tab.
            madrid.WaitForElement(SocialVars.friends_tab_Conversaciones);
            madrid.Tap(SocialVars.friends_tab_Conversaciones);

            //Step 5: Tap on a chat with a long history.
            madrid.ScrollDownTo(SocialVars.Conversation_tab_qadevan3);
            madrid.WaitForElement(SocialVars.Conversation_tab_qadevan3);
            madrid.Tap(SocialVars.Conversation_tab_qadevan3);

            Assert.True(utils.existsElement(SocialVars.Conversation_detail_FriendHeader_title_qadevan3), "Qadevan3 isn't displayed");

            //Step 6: Scroll up to the beginning of the conversation.
            //utils.Go_To_Up(SocialVars.Conversation_detail_view, SocialVars.Conversation_detail_time_qadevan3);
            Go_To_up(SocialVars.Conversation_detail_view, SocialVars.Conversation_detail_time_qadevan3);

        }

        [Test]
        //All the friends who the user speaks one time at least appears in the list
        public void Test_35941()
        {
            utils.Login_data(Strings.LOGIN_USERNAME_FRIENDS, Strings.LOGIN_PASSWORD_FRIENDS);
			//utils.Login_data("qadevios4@yopmail.com", "P@ssword.1");
            //Step 3: Go to social through the navbar.
            madrid.Tap(NavigationBarVars.navbar_Social_but);
            Assert.True(utils.existsElement(SocialVars.friends_friend_page), "Social title isn't displayed");

            //Step 4: Tap on chat tab.
            madrid.WaitForElement(SocialVars.friends_tab_Conversaciones);
            madrid.Tap(SocialVars.friends_tab_Conversaciones);
			madrid.WaitForElement(SocialVars.Conversation_tab_qadevan3);
            Assert.True(utils.existsElement(SocialVars.Conversation_tab_qadevan3), "Qadevan3 isn't displayed");
            Assert.True(utils.existsElement(SocialVars.Conversation_tab_helenasocial6), "Helenasocial6 isn't displayed");
            Assert.True(utils.existsElement(SocialVars.Conversation_tab_olichat1a), "Olichat1a isn't displayed");


        }

        /******************************************** SOCIAL /  Feeds ************************************************/

        /*
        [Test]
        //Tap on Username & profile image in a friend recent activity
        public void Test_35521()
        {
			utils.Login_data(Strings.LOGIN_USERNAME_FRIENDS, Strings.LOGIN_PASSWORD_FRIENDS);
			//utils.Login_data("qadevios4@yopmail.com", "P@ssword.1");
            //Step 2: Go to social through the navbar.
            madrid.Tap(NavigationBarVars.navbar_Social_but);
            Assert.True(utils.existsElement(SocialVars.friends_friend_page), "Social title isn't displayed");
            //Step 3: Tap on 'Feed' tab
            madrid.WaitForElement(SocialVars.friends_tab_Feeds);
            madrid.Tap(SocialVars.friends_tab_Feeds);

            AppResult[] FeedText;
            FeedText = madrid.Query(SocialVars.Feeds_tab_FeedTitle);
            string FriendsName1 = FeedText[0].Text;

            //Step 4: Tap on a profile image of an activity.
            madrid.WaitForElement(SocialVars.Feeds_tab_FriendImage);
            madrid.Tap(SocialVars.Feeds_tab_FriendImage);

            AppResult[] FriendNamePofile;
            FriendNamePofile = madrid.Query(SocialVars.Feeds_tab_FriendProfileHeader_title);
            string FriendNameProfile1 = FriendNamePofile[0].Text;

            Assert.True(FriendsName1.Contains(FriendNameProfile1), "Name Friend feed is not the same as Header Friend profile ");

            //Step 5: Tap on 'Back' button.
            madrid.WaitForElement(SocialVars.Feeds_tab_FriendProfile_GoBack);
            madrid.Tap(SocialVars.Feeds_tab_FriendProfile_GoBack);

            //Step 6: Tap on a UserName of an activity.
            madrid.WaitForElement(SocialVars.Feeds_tab_FeedTitle);
            madrid.Tap(SocialVars.Feeds_tab_FeedTitle);

            AppResult[] FriendNamePofile_header;
            FriendNamePofile_header = madrid.Query(SocialVars.Feeds_tab_FriendProfileHeader_title);
            string FriendNameProfile3 = FriendNamePofile_header[0].Text;

            Assert.True(FriendsName1.Contains(FriendNameProfile3), "Name Friend feed is not the same as Header Friend profile ");

            //Step 7: Tap on 'Back' button.
            madrid.Tap(SocialVars.Feeds_tab_FriendProfile_GoBack);


        }
		*/
        [Test]
        //Tap on a 'Checkin' recent activity
        public void Test_35525()
        {
            utils.Login_data(Strings.LOGIN_USERNAME_FRIENDS, Strings.LOGIN_PASSWORD_FRIENDS);
			//utils.Login_data("qadevios4@yopmail.com", "P@ssword.1");
            //Step 2: Go to social through the navbar.
            madrid.Tap(NavigationBarVars.navbar_Social_but);
            Assert.True(utils.existsElement(SocialVars.friends_friend_page), "Social title isn't displayed");

            //Step 3: Tap on 'Feed' tab
            madrid.WaitForElement(SocialVars.friends_tab_Feeds);
            madrid.Tap(SocialVars.friends_tab_Feeds);

            //Step 4: Tap on a 'Checkin' recent activity
            Go_To_slow(SocialVars.Feeds_tab_TimeLine_list, SocialVars.Feeds_tab_CheckInDescription);

            madrid.Tap(SocialVars.Feeds_tab_CheckInDescription);
            madrid.Tap(SocialVars.Feeds_tab_CheckInDescription);
            madrid.Tap(SocialVars.Feeds_tab_CheckInDescription);
            Assert.True(utils.existsElement(SocialVars.Feeds_tab_CheckInDescription), "CheckIn description isn't displayed");

        }

		/*
        [Test]
        //Tap on a 'Achievement' recent activity
        public void Test_35526()
        {
			utils.Login_data(Strings.LOGIN_USERNAME_FRIENDS, Strings.LOGIN_PASSWORD_FRIENDS);
			//utils.Login_data("qadevios4@yopmail.com", "P@ssword.1");
            //Step 2: Go to social through the navbar.
            madrid.Tap(NavigationBarVars.navbar_Social_but);
            Assert.True(utils.existsElement(SocialVars.friends_friend_page), "Social title isn't displayed");

            //Step 3: Tap on 'Feed' tab
            madrid.WaitForElement(SocialVars.friends_tab_Feeds);
            madrid.Tap(SocialVars.friends_tab_Feeds);

            //Step 4: Tap on a 'Achievement' recent activity.
            utils.Go_To(SocialVars.Feeds_tab_TimeLine_list, SocialVars.Feeds_tab_Badge_img);
            madrid.Tap(SocialVars.Feeds_tab_Badge_img);
            Assert.True(utils.existsElement(SocialVars.Badges_title), "Badges title isn't displayed");

        }*/

        [Test]
        //Tap on a 'News' recent activity
        public void Test_35527()
        {
            utils.Login_data(Strings.LOGIN_USERNAME_FRIENDS, Strings.LOGIN_PASSWORD_FRIENDS);
			//utils.Login_data("qadevios4@yopmail.com", "P@ssword.1");
            //Step 2: Go to social through the navbar.
            madrid.Tap(NavigationBarVars.navbar_Social_but);
            Assert.True(utils.existsElement(SocialVars.friends_friend_page), "Social title isn't displayed");

            //Step 3: Tap on 'Feed' tab
            madrid.WaitForElement(SocialVars.friends_tab_Feeds);
            madrid.Tap(SocialVars.friends_tab_Feeds);

            //Step 4: Tap on a 'News' recent activity.
            Go_To_slow(SocialVars.Feeds_tab_TimeLine_list, SocialVars.Feeds_tab_NewsDescription);

            madrid.Tap(SocialVars.Feeds_tab_NewsDescription);
            madrid.WaitForElement(SocialVars.News_NewsDetail_title);
            Assert.True(utils.existsElement(SocialVars.News_NewsDetail_title), "News title isn't displayed");

        }
		/*
        [Test]
        //Tap on a 'Videos' recent activity
        public void Test_35528()
        {
			utils.Login_data(Strings.LOGIN_USERNAME_FRIENDS, Strings.LOGIN_PASSWORD_FRIENDS);
			//utils.Login_data(Strings.LOGIN_USERNAME_FRIENDS, Strings.LOGIN_PASSWORD_FRIENDS);
			//utils.Login_data("qadevios4@yopmail.com", "P@ssword.1");
            //Step 2: Go to social through the navbar.
            madrid.Tap(NavigationBarVars.navbar_Social_but);
            Assert.True(utils.existsElement(SocialVars.friends_friend_page), "Social title isn't displayed");

            //Step 3: Tap on 'Feed' tab
            madrid.WaitForElement(SocialVars.friends_tab_Feeds);
            madrid.Tap(SocialVars.friends_tab_Feeds);

            //Step 4: Tap on a 'News' recent activity.
            utils.Go_To(SocialVars.Feeds_tab_TimeLine_list, SocialVars.Feeds_tab_play_img);
            madrid.Tap(SocialVars.Feeds_tab_play_img);
            madrid.WaitForElement(HomeVars.Video_player);
            Assert.True(utils.existsElement(HomeVars.Video_player), "Video player isn't displayed");

        }*/

        [Test]
        //Tap on a 'Subscription' recent activity
        public void Test_35532()
        {
            utils.Login_data(Strings.LOGIN_USERNAME_FRIENDS, Strings.LOGIN_PASSWORD_FRIENDS);
			//utils.Login_data("qadevios4@yopmail.com", "P@ssword.1");
            //Step 2: Go to social through the navbar.
            madrid.Tap(NavigationBarVars.navbar_Social_but);
            Assert.True(utils.existsElement(SocialVars.friends_friend_page), "Social title isn't displayed");

            //Step 3: Tap on 'Feed' tab
            madrid.WaitForElement(SocialVars.friends_tab_Feeds);
            madrid.Tap(SocialVars.friends_tab_Feeds);

            //Step 4: Tap on a 'Subscription' recent activity.
            Go_To_slow(SocialVars.Feeds_tab_TimeLine_list, SocialVars.Feeds_tab_SubscriptionDescription);
            madrid.Tap(SocialVars.Feeds_tab_SubscriptionDescription);
            madrid.WaitForElement(SocialVars.Videos_subscriptionDetail_title);
            Assert.True(utils.existsElement(SocialVars.Videos_subscriptionDetail_title), "Subscription title isn't displayed");


        }

        [Test]
        //Tap on a 'Virtual Good' recent activity
        public void Test_35533()
        {
            utils.Login_data(Strings.LOGIN_USERNAME_FRIENDS, Strings.LOGIN_PASSWORD_FRIENDS);
			//utils.Login_data("qadevios4@yopmail.com", "P@ssword.1");
            //Step 2: Go to social through the navbar.
            madrid.Tap(NavigationBarVars.navbar_Social_but);
            Assert.True(utils.existsElement(SocialVars.friends_friend_page), "Social title isn't displayed");

            //Step 3: Tap on 'Feed' tab
            madrid.WaitForElement(SocialVars.friends_tab_Feeds);
            madrid.Tap(SocialVars.friends_tab_Feeds);

            //Step 4: Tap on a 'News' recent activity.
            Go_To_slow(SocialVars.Feeds_tab_TimeLine_list, SocialVars.Feeds_tab_VGDescription);

            madrid.Tap(SocialVars.Feeds_tab_VGDescription);
            madrid.WaitForElement(SocialVars.VirtualGoods_VGDetail_title);
            Assert.True(utils.existsElement(SocialVars.VirtualGoods_VGDetail_title), "Virtual good detail title isn't displayed");

        }

        [Test]
        //Tap on a 'Friendship' recent activity
        public void Test_35534()
        {
            utils.Login_data(Strings.LOGIN_USERNAME_FRIENDS, Strings.LOGIN_PASSWORD_FRIENDS);
			//utils.Login_data("qadevios4@yopmail.com", "P@ssword.1");
            //Step 2: Go to social through the navbar.
            madrid.Tap(NavigationBarVars.navbar_Social_but);
            Assert.True(utils.existsElement(SocialVars.friends_friend_page), "Social title isn't displayed");

            //Step 3: Tap on 'Feed' tab
            madrid.WaitForElement(SocialVars.friends_tab_Feeds);
            madrid.Tap(SocialVars.friends_tab_Feeds);

            //Step 4: Tap on a 'News' recent activity.
            Go_To_slow(SocialVars.Feeds_tab_TimeLine_list, SocialVars.Feeds_tab_FriendshipDescription);

            madrid.Tap(SocialVars.Feeds_tab_FriendshipDescription);
            madrid.WaitForElement(SocialVars.Friendship_FriendProfileHeader_title);
            Assert.True(utils.existsElement(SocialVars.Friendship_FriendProfileHeader_title), "Friend profile header isn't displayed");

        }

        /******************************************** SOCIAL / Friends ************************************************/


        [Test]
        //Friends page with friends
        public void Test_35615()
        {
            utils.Login_data(Strings.LOGIN_USERNAME_FRIENDS, Strings.LOGIN_PASSWORD_FRIENDS);
			//utils.Login_data("qadevios4@yopmail.com", "P@ssword.1");
            //Step 2: Go to social through the navbar.
            madrid.Tap(NavigationBarVars.navbar_Social_but);
            Assert.True(utils.existsElement(SocialVars.friends_friend_page), "Social title isn't displayed");

            //Step 3: Friends tab presents the following appearance
            madrid.WaitForElement(SocialVars.Friends_tab_SearchBox);
            Assert.True(utils.existsElement(SocialVars.Friends_tab_SearchBox), "SearchBox isn't displayed");

            madrid.WaitForElement(SocialVars.Friends_tab_PendingInvitation_icon);
            Assert.True(utils.existsElement(SocialVars.Friends_tab_PendingInvitation_icon), "Pending Invitation icon isn't displayed");

            //madrid.WaitForElement(SocialVars.Friends_tab_PendingInvitationAmount_icon);
            //Assert.True(utils.existsElement(SocialVars.Friends_tab_PendingInvitationAmount_icon), "Pending Invitation Amount icon isn't displayed");

            madrid.WaitForElement(SocialVars.Friends_tab_InviteFacebookFriends);
            Assert.True(utils.existsElement(SocialVars.Friends_tab_InviteFacebookFriends), "Invite Facebook Friends isn't displayed");

            madrid.WaitForElement(SocialVars.Friends_tab_FriendsAmount_icon);
            Assert.True(utils.existsElement(SocialVars.Friends_tab_FriendsAmount_icon), "Friends Amount isn't displayed");

            madrid.WaitForElement(SocialVars.Friends_tab_friendsSquares_icon);
            Assert.True(utils.existsElement(SocialVars.Friends_tab_friendsSquares_icon), "Friends Squares icon isn't displayed");

            madrid.WaitForElement(SocialVars.Friends_tab_friendsList_icon);
            Assert.True(utils.existsElement(SocialVars.Friends_tab_friendsList_icon), "Friends List icon isn't displayed");

            madrid.WaitForElement(SocialVars.Friends_tab_SearchFriends_label);
            Assert.True(utils.existsElement(SocialVars.Friends_tab_SearchFriends_label), "SearchFriends label isn't displayed");

            madrid.WaitForElement(SocialVars.Friends_tab_SearchFriends_Facebook);
            Assert.True(utils.existsElement(SocialVars.Friends_tab_SearchFriends_Facebook), "Search Friends Facebook isn't displayed");

            //madrid.WaitForElement(SocialVars.Friends_tab_SearchFriends_WhatsApp);
            //Assert.True(utils.existsElement(SocialVars.Friends_tab_SearchFriends_WhatsApp), "Search Friends WhatsApp isn't displayed");

            madrid.WaitForElement(SocialVars.Friends_tab_SearchFriends_Twitter);
            Assert.True(utils.existsElement(SocialVars.Friends_tab_SearchFriends_Twitter), "Search Friends Twitter isn't displayed");

            madrid.WaitForElement(SocialVars.Friends_tab_SearchFriends_Email);
            Assert.True(utils.existsElement(SocialVars.Friends_tab_SearchFriends_Email), "Search Friends Email isn't displayed");

            madrid.WaitForElement(SocialVars.Friends_tab_SearchFriends_NativeShare);
            Assert.True(utils.existsElement(SocialVars.Friends_tab_SearchFriends_NativeShare), "Search Friends NativeShare isn't displayed");

        }


        [Test]
        //Find a friend using the search box
        public void Test_35581()
        {
            utils.Login_data(Strings.LOGIN_USERNAME_FRIENDS, Strings.LOGIN_PASSWORD_FRIENDS);
			//utils.Login_data("qadevios4@yopmail.com", "P@ssword.1");
            //Step 2: Go to social through the navbar.
            madrid.Tap(NavigationBarVars.navbar_Social_but);
			madrid.WaitForElement(SocialVars.friends_friend_page);
            Assert.True(utils.existsElement(SocialVars.friends_friend_page), "Social title isn't displayed");
            //Step 3: Tap on the search box.
            madrid.WaitForElement(SocialVars.Friends_tab_SearchBox);
            madrid.Tap(SocialVars.Friends_tab_SearchBox);
            //Step 4: Type @nick
            //@nick "qa"
            //madrid.EnterText(SocialVars.Friends_tab_SearchBox, "\"qa\"");
            madrid.EnterText(SocialVars.Friends_tab_SearchBox, "qa");
			madrid.PressEnter();
            madrid.WaitForElement(SocialVars.Friends_tab_AliasFriends_qa);
            Assert.True(utils.existsElement(SocialVars.Friends_tab_AliasFriends_qa), "qa alias isn't displayed");
            madrid.ClearText(SocialVars.Friends_tab_SearchBox);

            //@nick "qadev"
            //madrid.EnterText(SocialVars.Friends_tab_SearchBox, "\"qadev\"");
			madrid.EnterText(SocialVars.Friends_tab_SearchBox, "qadev");
            madrid.PressEnter();
            madrid.WaitForElement(SocialVars.Friends_tab_AliasFriends);
			utils.Sleep(3);

            AppResult[] FriendNamePofile;
            FriendNamePofile = madrid.Query(SocialVars.Friends_tab_AliasFriends);
            string FriendsName = FriendNamePofile[0].Text;
            bool stopfor = false;
            string alias = "qadev";

            for (int i = 0; i < FriendNamePofile.Length; i++)
            {
                if (FriendNamePofile[i].Text.Contains(alias))
                {
                    i = FriendNamePofile.Length;
                    stopfor = true;
                }
            }

            Assert.True((stopfor), alias + " Alias not found ");
            madrid.ClearText(SocialVars.Friends_tab_SearchBox);

            //@nick "test01dev"
            madrid.EnterText(SocialVars.Friends_tab_SearchBox, "Test01dev");
            madrid.PressEnter();
            madrid.WaitForElement(SocialVars.Friends_tab_AliasFriends_Test01dev);
            Assert.True(utils.existsElement(SocialVars.Friends_tab_AliasFriends_Test01dev), "test01dev alias isn't displayed");
            madrid.ClearText(SocialVars.Friends_tab_SearchBox);

            //@nick "Test01dev"
            madrid.EnterText(SocialVars.Friends_tab_SearchBox, "Test01dev");
            madrid.PressEnter();
            madrid.WaitForElement(SocialVars.Friends_tab_AliasFriends_Test01dev);
            Assert.True(utils.existsElement(SocialVars.Friends_tab_AliasFriends_Test01dev), "Test01dev alias isn't displayed");
            madrid.ClearText(SocialVars.Friends_tab_SearchBox);

            //@nick "TEST01DEV"
            madrid.EnterText(SocialVars.Friends_tab_SearchBox, "TEST01DEV");
            madrid.PressEnter();
            madrid.WaitForElement(SocialVars.Friends_tab_AliasFriends_Test01dev);
            Assert.True(utils.existsElement(SocialVars.Friends_tab_AliasFriends_Test01dev), "TEST01DEV alias isn't displayed");
            madrid.ClearText(SocialVars.Friends_tab_SearchBox);

            //@nick "qadevios4"
            madrid.EnterText(SocialVars.Friends_tab_SearchBox, "qadevios45");
            madrid.PressEnter();
            Assert.False(utils.existsElement(SocialVars.Friends_tab_AliasFriends_qadevios4), "qadevios4 alias is displayed");


        }

        [Test]
        //Start Chat from friends tab in social
        public void Test_35582()
        {
            utils.Login_data(Strings.LOGIN_USERNAME_FRIENDS, Strings.LOGIN_PASSWORD_FRIENDS);
			//utils.Login_data("qadevios4@yopmail.com", "P@ssword.1");
            //Step 2: Go to social through the navbar.
            madrid.Tap(NavigationBarVars.navbar_Social_but);
            Assert.True(utils.existsElement(SocialVars.friends_friend_page), "Social title isn't displayed");
            madrid.WaitForElement(SocialVars.Friends_tab_SearchBox);
            madrid.Tap(SocialVars.Friends_tab_SearchBox);
            madrid.EnterText(SocialVars.Friends_tab_SearchBox, "testautofriends");
            madrid.PressEnter();
            madrid.WaitForElement(SocialVars.Friends_tab_AliasFriends_testautofriend);
            Assert.True(utils.existsElement(SocialVars.Friends_tab_AliasFriends_testautofriend), "testautofriend alias isn't displayed");
			//madrid.Tap(SocialVars.Conversation_detail_GoBack);

            //Step 3: Tap on the three dots of a friend with who you do not have a chat already.
            madrid.DoubleTap(SocialVars.Friends_tab_Friend_dots);
            madrid.WaitForElement(SocialVars.Friends_tab_Shortcuts_chat_popup);
            Assert.True(utils.existsElement(SocialVars.Friends_tab_Shortcuts_chat_popup), "Shortcuts chat isn't displayed");
            Assert.True(utils.existsElement(SocialVars.Friends_tab_Shortcuts_gift_popup), "Shortcuts gift isn't displayed");
            Assert.True(utils.existsElement(SocialVars.Friends_tab_Shortcuts_remove_popup), "Shortcuts remove isn't displayed");

            //Step 4: Tap on Chat
            madrid.Tap(SocialVars.Friends_tab_Shortcuts_chat_popup);
            madrid.WaitForElement(SocialVars.Conversation_detail_testautofriends_title);
            Assert.True(utils.existsElement(SocialVars.Conversation_detail_testautofriends_title), "Friend name header isn't displayed");
            Assert.False(utils.existsElement(SocialVars.Conversation_detail_TextMessage), "Chat history not clean");
            Assert.True(utils.existsElement(SocialVars.Conversation_detail_GoBack), "Go back button isn't displayed");
            //Assert.True(utils.existsElement(SocialVars.Conversation_detail_TotalCoins), "Total coins isn't displayed");
            Assert.True(utils.existsElement(SocialVars.Conversation_detail_sendText), "Send text button isn't displayed");

        }

        [Test]
        //Friends page without friends
        public void Test_35610()
        {
			utils.Login_data(Strings.LOGIN_USERNAME_NOFRIENDS, Strings.LOGIN_PASSWORD_NOFRIENDS);
			//utils.Login_data("testautonofriends@yopmail.com", "P@ssword.1");
            //Step 2: Go to social through the navbar.
            madrid.Tap(NavigationBarVars.navbar_Social_but);
            Assert.True(utils.existsElement(SocialVars.friends_friend_page), "Social title isn't displayed");

            //Step 3: Friends tab presents the following appearance

            madrid.WaitForElement(SocialVars.Friends_tab_SearchBox);
            Assert.True(utils.existsElement(SocialVars.Friends_tab_SearchBox), "SearchBox isn't displayed");

            madrid.WaitForElement(SocialVars.Friends_tab_PendingInvitation_icon);
            Assert.True(utils.existsElement(SocialVars.Friends_tab_PendingInvitation_icon), "Pending Invitation icon isn't displayed");

            //madrid.WaitForElement(SocialVars.Friends_tab_PendingInvitationAmount_icon);
            //Assert.True(utils.existsElement(SocialVars.Friends_tab_PendingInvitationAmount_icon), "Pending Invitation Amount icon isn't displayed");

            madrid.WaitForElement(SocialVars.Friends_tab_InviteFacebookFriends);
            Assert.True(utils.existsElement(SocialVars.Friends_tab_InviteFacebookFriends), "Invite Facebook Friends isn't displayed");

            madrid.WaitForElement(SocialVars.Friends_tab_FriendsAmountNofriends_icon);
            Assert.True(utils.existsElement(SocialVars.Friends_tab_FriendsAmountNofriends_icon), "Friends Amount isn't displayed");

            madrid.WaitForElement(SocialVars.Friends_tab_friendsSquares_icon);
            Assert.True(utils.existsElement(SocialVars.Friends_tab_friendsSquares_icon), "Friends Squares icon isn't displayed");

            madrid.WaitForElement(SocialVars.Friends_tab_friendsList_icon);
            Assert.True(utils.existsElement(SocialVars.Friends_tab_friendsList_icon), "Friends List icon isn't displayed");

            madrid.WaitForElement(SocialVars.Friends_tab_NofriendsMessage);
            Assert.True(utils.existsElement(SocialVars.Friends_tab_NofriendsMessage), "No friends Message isn't displayed");

            madrid.WaitForElement(SocialVars.Friends_tab_SearchFriends_label);
            Assert.True(utils.existsElement(SocialVars.Friends_tab_SearchFriends_label), "SearchFriends label isn't displayed");

            madrid.WaitForElement(SocialVars.Friends_tab_SearchFriends_Facebook);
            Assert.True(utils.existsElement(SocialVars.Friends_tab_SearchFriends_Facebook), "Search Friends Facebook isn't displayed");

            //madrid.WaitForElement(SocialVars.Friends_tab_SearchFriends_WhatsApp);
            //Assert.True(utils.existsElement(SocialVars.Friends_tab_SearchFriends_WhatsApp), "Search Friends WhatsApp isn't displayed");

            madrid.WaitForElement(SocialVars.Friends_tab_SearchFriends_Twitter);
            Assert.True(utils.existsElement(SocialVars.Friends_tab_SearchFriends_Twitter), "Search Friends Twitter isn't displayed");

            madrid.WaitForElement(SocialVars.Friends_tab_SearchFriends_Email);
            Assert.True(utils.existsElement(SocialVars.Friends_tab_SearchFriends_Email), "Search Friends Email isn't displayed");

            madrid.WaitForElement(SocialVars.Friends_tab_SearchFriends_NativeShare);
            Assert.True(utils.existsElement(SocialVars.Friends_tab_SearchFriends_NativeShare), "Search Friends NativeShare isn't displayed");

        }

        [Test]
        //Friend profile
        public void Test_35494()
        {
            utils.Login_data(Strings.LOGIN_USERNAME_FRIENDS, Strings.LOGIN_PASSWORD_FRIENDS);
			//utils.Login_data("qadevios4@yopmail.com", "P@ssword.1");
			//Step 2: Go to profile
			utils.Sleep(5);
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
			madrid.WaitForElement(SocialVars.profile_title);
            Assert.True(utils.existsElement(SocialVars.profile_title), "Profile title isn't displayed");

            //Step 3: Scroll down to "Friends"
            //utils.Go_To(HomeVars.home_content, ProfileVars.friends_first_friend_but);
			madrid.ScrollDown();
			madrid.ScrollDownTo(ProfileVars.friends_first_friend_but);

			//Step 4: Tap on a friend profile image
            madrid.Tap(ProfileVars.friends_first_friend_but);

            //Assert.True(utils.existsElement(ProfileVars.profile_account_name), "Profile name isn't displayed");
			madrid.WaitForElement(ProfileVars.avatar_img);
			Assert.False(utils.existsElement(ProfileVars.profile_account_avatar_but), "Avatar isn't displayed");
            Assert.True(utils.existsElement(ProfileVars.avatar_img), "Avatar image isn't displayed");
            //Assert.True(utils.existsElement(ProfileVars.link_madridista_but), "Link madridista button isn't displayed");
            Assert.True(utils.existsElement(SocialVars.profile_account_alias), "Alias isn't displayed");
            Assert.True(utils.existsElement(SocialVars.profile_account_delete_but), "Delete friend button isn't displayed");
            Assert.True(utils.existsElement(SocialVars.profile_account_chat_but), "Chat button isn't displayed");
            Assert.True(utils.existsElement(SocialVars.profile_account_gift_but), "Gift button isn't displayed");

            madrid.ScrollDownTo(ProfileVars.status_title);
			//Go_To_slow(HomeVars.home_content, ProfileVars.status_title);
            Assert.True(utils.existsElement(ProfileVars.status_title), "Status isn't displayed");

			madrid.ScrollDownTo(ProfileVars.virtual_goods_but);
            //Go_To_slow(HomeVars.home_content, ProfileVars.experiencia_but);
            madrid.Tap(ProfileVars.experiencia_but);
            Assert.True(utils.existsElement(ProfileVars.experiencia_but), "Experience button isn't displayed");

            madrid.ScrollDownTo(ProfileVars.virtual_goods_but);
			//Go_To_slow(HomeVars.home_content, ProfileVars.virtual_goods_but);
            madrid.Tap(ProfileVars.virtual_goods_but);
            Assert.True(utils.existsElement(ProfileVars.virtual_goods_but), "VG button isn't displayed");

            madrid.ScrollDownTo(ProfileVars.ranking_but);
			//Go_To_slow(HomeVars.home_content, ProfileVars.ranking_but);
            madrid.Tap(ProfileVars.ranking_but);
            Assert.True(utils.existsElement(ProfileVars.ranking_but), "Ranking button isn't displayed");

            madrid.ScrollDownTo(ProfileVars.checkin_but);
			//Go_To_slow(HomeVars.home_content, ProfileVars.checkin_but);
            madrid.Tap(ProfileVars.checkin_but);
            Assert.True(utils.existsElement(ProfileVars.checkin_but), "Checkin button isn't displayed");

            madrid.ScrollDownTo(ProfileVars.badges_but);
			//Go_To_slow(HomeVars.home_content, ProfileVars.badges_but);
            madrid.Tap(ProfileVars.badges_but);
            Assert.True(utils.existsElement(ProfileVars.badges_but), "Badges button isn't displayed");


			madrid.ScrollDownTo(ProfileVars.friends_title);
            //Go_To_slow(HomeVars.home_content, ProfileVars.friends_title);
            Assert.True(utils.existsElement(ProfileVars.friends_title), "Friends section isn't displayed");

			madrid.ScrollDownTo(SocialVars.RecentActivity_SectionTitle);
            //Go_To_slow(HomeVars.home_content, SocialVars.RecentActivity_SectionTitle);
            Assert.True(utils.existsElement(SocialVars.RecentActivity_SectionTitle), "Recent Activity section isn't displayed");

			madrid.ScrollDownTo(SocialVars.Feeds_tab_FriendImage);
			//Go_To_slow(HomeVars.home_content, SocialVars.Feeds_tab_FriendImage);
            Assert.True(utils.existsElement(SocialVars.Feeds_tab_FriendImage), "Recent Activity friend image isn't displayed");
            //Assert.True(utils.existsElement(SocialVars.Feeds_tab_FeedTitle), "Recent Activity title isn't displayed");

			madrid.ScrollDownTo(SocialVars.Feeds_tab_actionDescription);
			//Go_To_slow(HomeVars.home_content, SocialVars.Feeds_tab_actionDescription);
            Assert.True(utils.existsElement(SocialVars.Feeds_tab_actionDescription), "Recent Activity description isn't displayed");

            madrid.Tap(ProfileVars.friends_first_friend_but);
            //Assert.True(utils.existsElement(ProfileVars.profile_account_name), "Profile name isn't displayed");

            //Step 5: Tap on 'Back' button.
            madrid.Tap(SocialVars.profile_account_GoBack_but);
			madrid.WaitForElement(ProfileVars.friends_first_friend_but);
            Assert.True(utils.existsElement(ProfileVars.friends_first_friend_but), "Friend images isn't displayed");
        }

        [Test]
        //Start Chat from friend profile
        public void Test_35604()
        {
            utils.Login_data(Strings.LOGIN_USERNAME_FRIENDS, Strings.LOGIN_PASSWORD_FRIENDS);
			//utils.Login_data("qadevios4@yopmail.com", "P@ssword.1");

			//Step 2: Go to Social through navbar
			utils.Sleep(5);
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
			madrid.WaitForElement(SocialVars.profile_title);
            Assert.True(utils.existsElement(SocialVars.profile_title), "Profile title isn't displayed");

			//madrid.ScrollDown();
			//madrid.ScrollDownTo(ProfileVars.friends_first_friend_but);

            //Step 3: Tap on a friend
            madrid.Tap(ProfileVars.friends_first_friend_but);

			madrid.WaitForElement(ProfileVars.avatar_img);
            //Assert.True(utils.existsElement(ProfileVars.profile_account_name), "Profile name isn't displayed");
            Assert.False(utils.existsElement(ProfileVars.profile_account_avatar_but), "Avatar isn't displayed");
            Assert.True(utils.existsElement(ProfileVars.avatar_img), "Avatar image isn't displayed");
            //Assert.True(utils.existsElement(ProfileVars.link_madridista_but), "Link madridista button isn't displayed");
            Assert.True(utils.existsElement(SocialVars.profile_account_alias), "Alias isn't displayed");
            Assert.True(utils.existsElement(SocialVars.profile_account_delete_but), "Delete friend button isn't displayed");
            Assert.True(utils.existsElement(SocialVars.profile_account_chat_but), "Chat button isn't displayed");
            Assert.True(utils.existsElement(SocialVars.profile_account_gift_but), "Gift button isn't displayed");

			madrid.ScrollDownTo(ProfileVars.status_title);
			//Go_To_slow(HomeVars.home_content, ProfileVars.status_title);
            Assert.True(utils.existsElement(ProfileVars.status_title), "Status isn't displayed");

			madrid.ScrollDownTo(ProfileVars.virtual_goods_but);
            //Go_To_slow(HomeVars.home_content, ProfileVars.experiencia_but);
            madrid.Tap(ProfileVars.experiencia_but);
            Assert.True(utils.existsElement(ProfileVars.experiencia_but), "Experience button isn't displayed");

            madrid.ScrollDownTo(ProfileVars.virtual_goods_but);
			//Go_To_slow(HomeVars.home_content, ProfileVars.virtual_goods_but);
            madrid.Tap(ProfileVars.virtual_goods_but);
            Assert.True(utils.existsElement(ProfileVars.virtual_goods_but), "VG button isn't displayed");

            madrid.ScrollDownTo(ProfileVars.ranking_but);
			//Go_To_slow(HomeVars.home_content, ProfileVars.ranking_but);
            madrid.Tap(ProfileVars.ranking_but);
            Assert.True(utils.existsElement(ProfileVars.ranking_but), "Ranking button isn't displayed");

            madrid.ScrollDownTo(ProfileVars.checkin_but);
			//Go_To_slow(HomeVars.home_content, ProfileVars.checkin_but);
            madrid.Tap(ProfileVars.checkin_but);
            Assert.True(utils.existsElement(ProfileVars.checkin_but), "Checkin button isn't displayed");

            madrid.ScrollDownTo(ProfileVars.badges_but);
			//Go_To_slow(HomeVars.home_content, ProfileVars.badges_but);
            madrid.Tap(ProfileVars.badges_but);
            Assert.True(utils.existsElement(ProfileVars.badges_but), "Badges button isn't displayed");


			/*madrid.ScrollDownTo(ProfileVars.friends_title);
            //Go_To_slow(HomeVars.home_content, ProfileVars.friends_title);
            Assert.True(utils.existsElement(ProfileVars.friends_title), "Friends section isn't displayed");
			*/
			madrid.ScrollDownTo(SocialVars.RecentActivity_SectionTitle);
            //Go_To_slow(HomeVars.home_content, SocialVars.RecentActivity_SectionTitle);
            Assert.True(utils.existsElement(SocialVars.RecentActivity_SectionTitle), "Recent Activity section isn't displayed");

			madrid.ScrollDownTo(SocialVars.Feeds_tab_FriendImage);
			//Go_To_slow(HomeVars.home_content, SocialVars.Feeds_tab_FriendImage);
            Assert.True(utils.existsElement(SocialVars.Feeds_tab_FriendImage), "Recent Activity friend image isn't displayed");
            //Assert.True(utils.existsElement(SocialVars.Feeds_tab_FeedTitle), "Recent Activity title isn't displayed");

			madrid.ScrollDownTo(SocialVars.Feeds_tab_actionDescription);
			//Go_To_slow(HomeVars.home_content, SocialVars.Feeds_tab_actionDescription);
            Assert.True(utils.existsElement(SocialVars.Feeds_tab_actionDescription), "Recent Activity description isn't displayed");

            /*Go_To_slow(HomeVars.home_content, ProfileVars.status_title);
            Assert.True(utils.existsElement(ProfileVars.status_title), "Status isn't displayed");

            Go_To_slow(HomeVars.home_content, ProfileVars.experiencia_but);
            madrid.Tap(ProfileVars.experiencia_but);
            Assert.True(utils.existsElement(ProfileVars.experiencia_but), "Experience button isn't displayed");

            Go_To_slow(HomeVars.home_content, ProfileVars.virtual_goods_but);
            madrid.Tap(ProfileVars.virtual_goods_but);
            Assert.True(utils.existsElement(ProfileVars.virtual_goods_but), "VG button isn't displayed");

            Go_To_slow(HomeVars.home_content, ProfileVars.ranking_but);
            madrid.Tap(ProfileVars.ranking_but);
            Assert.True(utils.existsElement(ProfileVars.ranking_but), "Ranking button isn't displayed");

            Go_To_slow(HomeVars.home_content, ProfileVars.checkin_but);
            madrid.Tap(ProfileVars.checkin_but);
            Assert.True(utils.existsElement(ProfileVars.checkin_but), "Checkin button isn't displayed");

            Go_To_slow(HomeVars.home_content, ProfileVars.badges_but);
            madrid.Tap(ProfileVars.badges_but);
            Assert.True(utils.existsElement(ProfileVars.badges_but), "Badges button isn't displayed");

            Go_To_slow(HomeVars.home_content, SocialVars.RecentActivity_SectionTitle);
            Assert.True(utils.existsElement(SocialVars.RecentActivity_SectionTitle), "Recent Activity section isn't displayed");
            Go_To_slow(HomeVars.home_content, SocialVars.Feeds_tab_FriendImage);
            Assert.True(utils.existsElement(SocialVars.Feeds_tab_FriendImage), "Recent Activity friend image isn't displayed");
            //Assert.True(utils.existsElement(SocialVars.Feeds_tab_FeedTitle), "Recent Activity title isn't displayed");
            Go_To_slow(HomeVars.home_content, SocialVars.Feeds_tab_actionDescription);
            Assert.True(utils.existsElement(SocialVars.Feeds_tab_actionDescription), "Recent Activity description isn't displayed");
			*/
            //Step 4: Tap on "Start Chat"
            madrid.ScrollUpTo(SocialVars.profile_account_chat_but);
            madrid.Tap(SocialVars.profile_account_chat_but);
            madrid.WaitForElement(SocialVars.Conversation_detail_FriendHeader_title);
            Assert.True(utils.existsElement(SocialVars.Conversation_detail_FriendHeader_title), "Header friend name isn't displayed");
            //Assert.True(utils.existsElement(SocialVars.Conversation_detail_TotalCoins), "Total coins isn't displayed");
            Assert.True(utils.existsElement(SocialVars.Conversation_detail_sendText), "Send text button isn't displayed");
            Assert.True(utils.existsElement(SocialVars.Conversation_detail_GoBack), "Go back button isn't displayed");

            //Step 5: Tap on "Back" button
            madrid.Tap(SocialVars.Conversation_detail_GoBack);
            madrid.WaitForElement(SocialVars.profile_account_chat_but);
			Assert.True(utils.existsElement(SocialVars.profile_account_chat_but), "Chat button isn't displayed, profile isn't displayed");

        }

        /******************************************** SOCIAL /  Gifts ************************************************/


        [Test]
        //Send last virtual good as a gift to a friend
        public void Test_35583()
        {
            utils.Login_data(Strings.LOGIN_USERNAME_FRIENDS, Strings.LOGIN_PASSWORD_FRIENDS);
			//utils.Login_data("qadevios4@yopmail.com", "P@ssword.1");
			//Step 2: Go to social through the navbar.
			utils.Sleep(5);
            madrid.Tap(NavigationBarVars.navbar_Social_but);
            Assert.True(utils.existsElement(SocialVars.friends_friend_page), "Social title isn't displayed");

            //Step 3: Tap on the three dots of the friend who you want to send a gift to.
            madrid.Tap(SocialVars.Friends_tab_Friend_dots);

            //Step 4: Tap on Send gift button.
            madrid.Tap(SocialVars.Friends_tab_Shortcuts_gift_popup);

            //Step 5: Choose one virtual good of which you have only one unit.
            Assert.True(utils.existsElement(SocialVars.Gift_SendGift_but), "Send gift button displayed early");
            utils.Sleep(5);
            madrid.WaitForElement(SocialVars.Gift_BlueCap_title);
            madrid.Tap(SocialVars.Gift_BlueCap_title);
            madrid.WaitForElement(SocialVars.Gift_SendGift_but);
            Assert.True(utils.existsElement(SocialVars.Gift_SendGift_but), "Send gift button isn't displayed");

            //Step 6: Tap on send gift.
            madrid.Tap(SocialVars.Gift_SendGift_but);

            //Step 7: Tap on OK button.
            madrid.WaitForElement(SocialVars.SentGift_Ok_but);
            madrid.Tap(SocialVars.SentGift_Ok_but);
			utils.Sleep(3);
            Assert.False(utils.existsElement(SocialVars.Gift_BlueCap_title), "Blue cap is displayed");

            // Buy blue cup for next TC
            madrid.Tap(NavigationBarVars.navbar_Virtual_Store_but);
            utils.Go_To(VirtualStoreVars.VG_view, VirtualStoreVars.VG_MaleHat_BlueCap_title);
            madrid.WaitForElement(VirtualStoreVars.VG_viewAll_but);
            madrid.Tap(VirtualStoreVars.VG_MaleHat_BlueCap_title);
            madrid.WaitForElement(VirtualStoreVars.VG_detail_GetIt_but);
            madrid.Tap(VirtualStoreVars.VG_detail_GetIt_but);

        }

        [Test]
        //Send gift from friend profile
        public void Test_35605()
        {
            utils.Login_data(Strings.LOGIN_USERNAME_FRIENDS, Strings.LOGIN_PASSWORD_FRIENDS);
			//utils.Login_data("qadevios4@yopmail.com", "P@ssword.1");
			//Step 2: Go to social through the navbar.
			utils.Sleep(5);
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
            Assert.True(utils.existsElement(SocialVars.profile_title), "Profile title isn't displayed");

			//Step 3: Tap on a friend
			madrid.ScrollDownTo(ProfileVars.friends_first_friend_but);
			//utils.Go_To(HomeVars.home_content, ProfileVars.friends_first_friend_but);
            madrid.Tap(ProfileVars.friends_first_friend_but);

            //Assert.True(utils.existsElement(ProfileVars.profile_account_name), "Profile name isn't displayed");
            //Assert.True(utils.existsElement(ProfileVars.profile_account_avatar_but), "Avatar isn't displayed");
            //Assert.True(utils.existsElement(ProfileVars.avatar_img), "Avatar image isn't displayed");
            //Assert.True(utils.existsElement(ProfileVars.link_madridista_but), "link madridista isn't displayed");
            Assert.True(utils.existsElement(SocialVars.profile_account_alias), "Alias isn't displayed");
            Assert.True(utils.existsElement(SocialVars.profile_account_delete_but), "Delete friend button isn't displayed");
			madrid.ScrollDownTo(SocialVars.profile_account_chat_but);
			Assert.True(utils.existsElement(SocialVars.profile_account_chat_but), "Chat button isn't displayed");
            Assert.True(utils.existsElement(SocialVars.profile_account_gift_but), "Gift button isn't displayed");

            Go_To_slow(HomeVars.home_content, ProfileVars.status_title);
            Assert.True(utils.existsElement(ProfileVars.status_title), "Status isn't displayed");

            Go_To_slow(HomeVars.home_content, ProfileVars.badges_but);
			madrid.Tap(ProfileVars.badges_but);
            Assert.True(utils.existsElement(ProfileVars.badges_but), "Badges button isn't displayed");

			Go_To_slow(HomeVars.home_content, ProfileVars.experiencia_but);
            madrid.Tap(ProfileVars.experiencia_but);
            Assert.True(utils.existsElement(ProfileVars.experiencia_but), "Experience button isn't displayed");

            Go_To_slow(HomeVars.home_content, ProfileVars.virtual_goods_but);
            madrid.Tap(ProfileVars.virtual_goods_but);
            Assert.True(utils.existsElement(ProfileVars.virtual_goods_but), "VG button isn't displayed");

            Go_To_slow(HomeVars.home_content, ProfileVars.ranking_but);
            madrid.Tap(ProfileVars.ranking_but);
            Assert.True(utils.existsElement(ProfileVars.ranking_but), "Ranking button isn't displayed");

            Go_To_slow(HomeVars.home_content, ProfileVars.checkin_but);
            madrid.Tap(ProfileVars.checkin_but);
            Assert.True(utils.existsElement(ProfileVars.checkin_but), "Checkin button isn't displayed");

            //Step 4: Tap on "Send gift".
            Go_To_up(HomeVars.home_content, SocialVars.profile_account_gift_but);
            madrid.Tap(SocialVars.profile_account_gift_but);

            //Step 5: Choose one virtual good
			Assert.True(utils.existsElement(SocialVars.Gift_SendGift_but), "Send gift button displayed early");
            utils.Sleep(5);
            madrid.WaitForElement(SocialVars.Gift_BlueCap_title);
            madrid.Tap(SocialVars.Gift_BlueCap_title);
            madrid.WaitForElement(SocialVars.Gift_SendGift_but);
            Assert.True(utils.existsElement(SocialVars.Gift_SendGift_but), "Send gift button isn't displayed");

            //Step 6: Tap on send gift
            madrid.Tap(SocialVars.Gift_SendGift_but);
			utils.Sleep(3);
            madrid.WaitForElement(SocialVars.SentGift_Title);
            Assert.True(utils.existsElement(SocialVars.SentGift_Title), "Send gift title isn't displayed");
            //Assert.True(utils.existsElement(SocialVars.SendGift_To_Alias), "Send gift to Alias friend isn't displayed");
            madrid.WaitForElement(SocialVars.SentGift_Ok_but);
            madrid.Tap(SocialVars.SentGift_Ok_but);
			utils.Sleep(3);

            // Buy blue cup for next TC
            madrid.Tap(NavigationBarVars.navbar_Virtual_Store_but);
            utils.Go_To(VirtualStoreVars.VG_view, VirtualStoreVars.VG_MaleHat_BlueCap_title);
            madrid.WaitForElement(VirtualStoreVars.VG_viewAll_but);
            madrid.Tap(VirtualStoreVars.VG_MaleHat_BlueCap_title);
            madrid.WaitForElement(VirtualStoreVars.VG_detail_GetIt_but);
            madrid.Tap(VirtualStoreVars.VG_detail_GetIt_but);

        }

        [Test]
        //Send virtual good as a gift to a friend
        public void Test_36041()
        {
            utils.Login_data(Strings.LOGIN_USERNAME_FRIENDS, Strings.LOGIN_PASSWORD_FRIENDS);
			//utils.Login_data("qadevios4@yopmail.com", "P@ssword.1");
            //Step 2: Go to social through the navbar.
            madrid.Tap(NavigationBarVars.navbar_Social_but);
            Assert.True(utils.existsElement(SocialVars.friends_friend_page), "Social title isn't displayed");

            //Step 3: Tap on the three dots of the friend who you want to send a gift to.
            madrid.Tap(SocialVars.Friends_tab_Friend_dots);

            //Step 4: Tap on Send gift button.
            madrid.Tap(SocialVars.Friends_tab_Shortcuts_gift_popup);

            //Step 5: Choose one virtual good of which you have more than one unit.

            AppResult[] ManyVG_toSend;
            madrid.WaitForElement(SocialVars.Gift_Many);
            ManyVG_toSend = madrid.Query(SocialVars.Gift_Many);

            int numVG;
            int totalVG_Before = 0;
            int subtotal = 0;

            for (int i = 0; i < ManyVG_toSend.Length; i++)
            {
                string many = ManyVG_toSend[i].Text;
                //i = ManyVG_toSend.Length;
                numVG = Convert.ToInt32(many);
                totalVG_Before = subtotal + numVG;
                subtotal = numVG;
            }

			Assert.True(utils.existsElement(SocialVars.Gift_SendGift_but), "Send gift button displayed early");
            utils.Sleep(5);
            madrid.WaitForElement(SocialVars.Gift_BlackYellowBoots_title);
            madrid.Tap(SocialVars.Gift_BlackYellowBoots_title);
            madrid.WaitForElement(SocialVars.Gift_SendGift_but);
            Assert.True(utils.existsElement(SocialVars.Gift_SendGift_but), "Send gift button isn't displayed");

            //Step 6: Tap on send gift.
            madrid.Tap(SocialVars.Gift_SendGift_but);

            //Step 7: Tap on OK button.
            madrid.WaitForElement(SocialVars.SentGift_Ok_but);
            madrid.Tap(SocialVars.SentGift_Ok_but);
			utils.Sleep(3);

            AppResult[] ManyVG_toSend2;
            madrid.WaitForElement(SocialVars.Gift_Many);
            ManyVG_toSend2 = madrid.Query(SocialVars.Gift_Many);

            int totalVG_After = 0;
			int numVG1;
			//int totalVG_Before = 0;
			int subtotal1 = 0;

            for (int i = 0; i < ManyVG_toSend2.Length; i++)
            {
                string many = ManyVG_toSend2[i].Text;
                numVG1 = Convert.ToInt32(many);
                totalVG_After = subtotal1 + numVG1;
                subtotal1 = numVG1;
            }

            int TotalVG_Expected = totalVG_Before - 1;

            Assert.True(TotalVG_Expected.Equals(totalVG_After), " VG available before send gift: " + totalVG_Before + " is not the same as VG after sent gift: " + totalVG_After );

            // Buy yellow black boots for next TC
            madrid.Tap(NavigationBarVars.navbar_Virtual_Store_but);
			Go_To_slow(VirtualStoreVars.VG_view, VirtualStoreVars.VG_MaleShoe_boots_price);
            //madrid.SwipeRightToLeft(VirtualStoreVars.VG_MaleShoe_boots_price, 0.90, 5000, true);
            madrid.WaitForElement(VirtualStoreVars.VG_MaleShoe_BlackYellow_boots_title);
			madrid.Tap(VirtualStoreVars.VG_MaleShoe_BlackYellow_boots_title);
            madrid.WaitForElement(VirtualStoreVars.VG_detail_GetIt_but);
            madrid.Tap(VirtualStoreVars.VG_detail_GetIt_but);

        }



        [Test]
        //No friend profile
        public void Test_35560()
        {
            utils.Login_data(Strings.LOGIN_USERNAME_FRIENDS2, Strings.LOGIN_PASSWORD_FRIENDS2);
			//utils.Login_data("autofriends2@yopmail.com", "P@ssword.1");
            //Step 2: Go to profile
            madrid.Tap(NavigationBarVars.navbar_Profile_but);
            Assert.True(utils.existsElement(SocialVars.profile_title), "Profile title isn't displayed");

            //Step 3: Scroll down to "Friends"
            Go_To_slow(HomeVars.home_content, ProfileVars.friends_first_friend_but);

            //Step 4: Tap on a friend profile image
            madrid.Tap(ProfileVars.friends_first_friend_but);
            //Assert.True(utils.existsElement(ProfileVars.profile_account_name), "Profile name isn't displayed");


            //Step 5: Tap one of his friends. This friend is not your friend.

            Go_To_slow(HomeVars.home_content, ProfileVars.friends_first_friend_but);
            madrid.Tap(ProfileVars.friends_first_friend_but);

            //Assert.True(utils.existsElement(ProfileVars.profile_account_avatar_but), "Avatar isn't displayed");
            //Assert.True(utils.existsElement(ProfileVars.avatar_img), "Avatar image isn't displayed");
            //Assert.True(utils.existsElement(ProfileVars.link_madridista_but), "Link madridista button isn't displayed");
            //Assert.True(utils.existsElement(SocialVars.profile_account_alias), "Alias isn't displayed");
            Assert.True(utils.existsElement(SocialVars.profile_account_addNoFriend_but), "Delete/Add friend button is displayed");
            Assert.False(utils.existsElement(SocialVars.profile_account_chat_but), "Chat button is displayed");
            Assert.False(utils.existsElement(SocialVars.profile_account_gift_but), "Gift button is displayed");

            Go_To_slow(HomeVars.home_content, ProfileVars.status_title);
            Assert.True(utils.existsElement(ProfileVars.status_title), "Status isn't displayed");

            Go_To_slow(HomeVars.home_content, ProfileVars.badges_but);
			//madrid.Tap(ProfileVars.badges_but);
            Assert.True(utils.existsElement(ProfileVars.badges_but), "Badges button isn't displayed");

			Go_To_slow(HomeVars.home_content, ProfileVars.experiencia_but);
            madrid.Tap(ProfileVars.experiencia_but);
            Assert.True(utils.existsElement(ProfileVars.experiencia_but), "Experience button isn't displayed");

            Go_To_slow(HomeVars.home_content, ProfileVars.ranking_but);
            madrid.Tap(ProfileVars.ranking_but);
            Assert.True(utils.existsElement(ProfileVars.ranking_but), "Ranking button isn't displayed");

            Go_To_slow(HomeVars.home_content, SocialVars.RecentActivity_SectionTitle);
            Assert.True(utils.existsElement(SocialVars.RecentActivity_SectionTitle), "Recent Activity section isn't displayed");

            madrid.ScrollUpTo(SocialVars.profile_account_addNoFriend_but);
            madrid.Tap(SocialVars.profile_account_addNoFriend_but);
            madrid.WaitForElement(SocialVars.FriendRequestSent_popup_title);
            Assert.True(utils.existsElement(SocialVars.FriendRequestSent_popup_title), "Friend request sent confirmation isn't displayed");
            Assert.True(utils.existsElement(SocialVars.FriendRequestSent_popup_ok_but), "Friend request sent ok button isn't displayed");
            madrid.Tap(SocialVars.FriendRequestSent_popup_ok_but);
            utils.Enter_Home();
            utils.Sign_Off();
			utils.Sleep(3);
			utils.Login_data(Strings.LOGIN_USERNAME_FRIENDS3, Strings.LOGIN_PASSWORD_FRIENDS3);
            //utils.Login_data("autofriends3@yopmail.com", "P@ssword.1");
            madrid.Tap(NavigationBarVars.navbar_Social_but);
            Assert.True(utils.existsElement(SocialVars.friends_friend_page), "Social title isn't displayed");
			utils.Sleep(3);
            madrid.WaitForElement(SocialVars.Friends_tab_Reject_FriendRequest_but);
			madrid.Tap(SocialVars.Friends_tab_PendingInvitation_icon);
            madrid.WaitForElement(SocialVars.Friends_tab_Reject_FriendRequest_but);
            madrid.Tap(SocialVars.Friends_tab_Reject_FriendRequest_but);
        }

		[Test]
		//Reject a friends invitation pending to resolve
		public void Test_35886()
		{
			//Send a invitation
			utils.Login_data(Strings.LOGIN_USERNAME_FRIENDS, Strings.LOGIN_PASSWORD_FRIENDS);
			//utils.Login_data("qadevios4@yopmail.com", "P@ssword.1");
			utils.seeingHome();
			utils.Sleep(5);
			this.sendInvitationFriend();
			madrid.Tap(NavigationBarVars.navbar_Home_but);
			utils.LogOff();

			//Step 2: Go to Social through the navbar
			utils.Login();
			utils.seeingHome();

			//Step 3: Tap on the pending invitations icon
			//Step 4: Reject the invitation
			this.removeInvitationFriend();
		}

		[Test]
		//Remove a friend from your friends list
		public void Test_35552()
		{
			//Agregar un amigo y que este acepte la solicitud
			utils.Login_data(Strings.LOGIN_USERNAME_FRIENDS, Strings.LOGIN_PASSWORD_FRIENDS);
			//utils.Login_data("qadevios4@yopmail.com", "P@ssword.1");
			this.sendInvitationFriend();
			madrid.Tap(NavigationBarVars.navbar_Home_but);
			utils.LogOff();

			utils.Login();
			this.acceptInvitationFriend();
			madrid.Tap(NavigationBarVars.navbar_Home_but);
			utils.LogOff();

			//Step 2: Go to Social through the navbar
			utils.Login_data(Strings.LOGIN_USERNAME_FRIENDS, Strings.LOGIN_PASSWORD_FRIENDS);
			//utils.Login_data("qadevios4@yopmail.com", "P@ssword.1");
			utils.seeingHome();
			madrid.Tap(NavigationBarVars.navbar_Social_but);

			//Step 3: Tap on the three dots of a friend card
			madrid.WaitForElement(SocialVars.Friends_tab_Friend_dots);
			utils.Go_To(HomeVars.home_content, SocialVars.Friends_ImageShorcuts_DiegoAlonso);
			madrid.Tap(SocialVars.Friends_ImageShorcuts_DiegoAlonso);

			//Step 4: Choose remove friend
			madrid.WaitForElement(SocialVars.profile_account_delete_but);
			madrid.Tap(SocialVars.profile_account_delete_but);

			//Step 5: Accept remove the friend
			madrid.WaitForElement(SocialVars.FriendRequestSent_popup_ok_but);
			madrid.Tap(SocialVars.FriendRequestSent_popup_ok_but);

		}

    }
    }