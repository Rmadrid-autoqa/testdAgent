using NUnit.Framework;
using RealMadrid_UITest.Variables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest;
using Xamarin.UITest.Queries;


namespace RealMadrid_UITest.Tests{
    //[TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]


    public class InBoxTests {
        IApp madrid;
        Utilities utils;
        Platform platform;



        public InBoxTests(Platform platform) {
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
                        utils.Sign_Off();
        }


        /********************* COMMUNICATIONS *********************/

        [Test]
		//Read Communication
        public void Test_34270() {
            // Step 2: Go to Inbox
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Inbox_but);
            // Step 3: Click on "Communications" tab
            madrid.Tap(InBoxVars.inBox_Comunication_Tab);
            Assert.False(utils.existsElement(InBoxVars.inBox_Notification_Delete), "Se muestra el boton de borrar notificaciones");
            Assert.True(utils.existsElement(InBoxVars.inBox_Message), "No se muestran mensajes");
            // Step 4: Click on a message
            madrid.Tap(InBoxVars.inBox_First_Message);
            Assert.True(utils.existsElement(InBoxVars.inBox_Message_Body), "No se muestra el cuerpo del mensaje");
            Assert.True(utils.existsElement(InBoxVars.inBox_Message_Date), "No se muestra el tiempo del mensaje");
            // Step 5: Click on @back button
            madrid.Tap(InBoxVars.inBox_Comunication_detail_back_but);
            Assert.False(utils.existsElement(InBoxVars.inBox_Notification_Delete), "Se muestra el boton de borrar notificaciones AL VOLVER ATRAS");
        }



        [Test]
		//See full App Inbox
        public void Test_34453() {
            // Step 2: Go to Inbox
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Inbox_but);
            // Step 3: Click on "Communications" tab
            madrid.Tap(InBoxVars.inBox_Comunication_Tab);
            Assert.False(utils.existsElement(InBoxVars.inBox_Notification_Delete), "Se muestra el boton de borrar notificaciones");
            Assert.True(utils.existsElement(InBoxVars.inBox_Message), "No se muestran mensajes");
            madrid.WaitForElement(InBoxVars.inBox_Message);
			AppResult[] result;
            result = madrid.Query(InBoxVars.inBox_Message);
            string msg = result[0].Text;
			madrid.ScrollDown(InBoxVars.inBox_Message_Container);
            result = madrid.Query(InBoxVars.inBox_Message);
            string newMsg = result[0].Text;
            Assert.False(msg.Equals(newMsg), "No cambian las notificaciones al hacer scroll");
        }

        /********************* USER INBOX *********************/
		/*
        [Test]
        //Read and delete notification
        public void Test_34269() {
            //Step 2: Go to Inbox
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Inbox_but);

			//Step 3: Click on @order message
			//madrid.Repl();
            AppResult[] message_text = madrid.Query(InBoxVars.inBox_First_Message);
            String text_result = message_text[0].Text;

			utils.Sleep(5);
			madrid.WaitForElement(InBoxVars.inBox_First_Message);
            madrid.DoubleTap(InBoxVars.inBox_First_Message);
			utils.Sleep(5);
            Assert.True(utils.existsElement(InBoxVars.inBox_Message_Body), "Text message doesn't exist");
            Assert.True(utils.existsElement(InBoxVars.inBox_Message_Date), "Number of the days of the message doesn't exist");
            Assert.True(utils.existsElement(InBoxVars.inBox_Notification_Delete), "Paper bin icon doesn't exist");

            //Step 4: Click on "Paper bin" icon
            madrid.Tap(InBoxVars.inBox_Notification_Delete);
            AppResult[] delete_result = madrid.Query(InBoxVars.inBox_Delete_Message_text);
            Assert.True(utils.Find_Text(delete_result, Strings.INBOX_DELETE_TEXT), "Popup doesn't have message");
            Assert.True(utils.existsElement(InBoxVars.inBox_Delete_OK_but), "OK button doesn't exist");
            Assert.True(utils.existsElement(InBoxVars.inBox_Delete_Cancel_but), "Cancel button doesn't exist");

            //Step 5: Click on "Yes" button
            madrid.Tap(InBoxVars.inBox_Delete_OK_but);

            //Step 6: Close application
            madrid.Tap(NavigationBarVars.navbar_Home_but);
            utils.Sign_Off();

            //Step 7: Open aplication and login
            utils.Login();

            //Step 8: Go to Inbox
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Inbox_but);

            AppResult[] message_text_new = madrid.Query(InBoxVars.inBox_First_Message);
            Assert.False(utils.Find_Text(message_text_new, text_result), "The message wasn`t deleted");
        }
		*/


        [Test]
        //Read notification
        public void Test_34447() {
            //Step 2: Go to Inbox
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Inbox_but);

            //Step 3: Click on message
            madrid.Tap(InBoxVars.inBox_Message);
            madrid.WaitForElement(InBoxVars.inBox_Message_Body);
            Assert.True(utils.existsElement(InBoxVars.inBox_Message_Body), "Text message doesn't exist");
            Assert.True(utils.existsElement(InBoxVars.inBox_Message_Date), "Number of the days of the message doesn't exist");
            Assert.True(utils.existsElement(InBoxVars.inBox_Notification_Delete), "Paper bin icon doesn't exist");

            //Step 4: Click on Back button
            madrid.Tap(InBoxVars.inBox_Notification_detail_back_but);
        }



        [Test]
        //Batch delete 1 notification
        public void Test_34449(){
            //Step 2: Go to Inbox
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Inbox_but);

            //Step 3: Select the @order message by clickin in the square to the left of it.
            AppResult[] message_text = madrid.Query(InBoxVars.inBox_First_Message);
            String text_result = message_text[0].Text;
            madrid.Tap(InBoxVars.inBox_Message_check);

            //Step 4: Click on "Paper bin" icon
            madrid.Tap(InBoxVars.inBox_Notification_Delete);
            AppResult[] delete_result = madrid.Query(InBoxVars.inBox_Delete_Message_text);
            Assert.True(utils.Find_Text(delete_result, Strings.INBOX_DELETE_TEXT), "Popup doesn't have message");
            Assert.True(utils.existsElement(InBoxVars.inBox_Delete_OK_but), "OK button doesn't exist");
            Assert.True(utils.existsElement(InBoxVars.inBox_Delete_Cancel_but), "Cancel button doesn't exist");

            //Step 5: Click on "Yes" button
            madrid.Tap(InBoxVars.inBox_Delete_OK_but);
			utils.Sleep(4);

            //Step 6: Close application.
            madrid.Tap(NavigationBarVars.navbar_Home_but);
            //utils.Sign_Off();

            //Step 7: Open application and login
            //utils.Login();

            //Step 8: Go to Inbox
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Inbox_but);

            AppResult[] message_text_new = madrid.Query(InBoxVars.inBox_First_Message);
            Assert.False(utils.Find_Text(message_text_new, text_result), "The message wasn't deleted");
        }



		[Test]
		//Cancel batch delete notifications
		public void Test_34451() {
			//Step 2: Go to Inbox
			utils.Access_Tab_Main_Menu(MainMenuVars.menu_Inbox_but);

			//Step 3: Select the any number of messages by clickin in the square to the left of them.
			AppResult[] result_messages_checks = madrid.Query(InBoxVars.inBox_Message_check);
			AppResult[] result_messages_text = madrid.Query(InBoxVars.inBox_Message);
			utils.Check_list(Strings.INBOX_MESSAGE_CHECK);
			madrid.Tap(InBoxVars.inBox_Message_check);
			madrid.Tap(InBoxVars.inBox_Message_check_1);
			//Step 4: Click on "Paper bin" icon
			madrid.Tap(InBoxVars.inBox_Notification_Delete);
			AppResult[] delete_result = madrid.Query(InBoxVars.inBox_Delete_Message_text);
			Assert.True(utils.Find_Text(delete_result, Strings.INBOX_DELETE_TEXT), "Popup doesn't have message");
			Assert.True(utils.existsElement(InBoxVars.inBox_Delete_OK_but), "OK button doesn't exist");
			Assert.True(utils.existsElement(InBoxVars.inBox_Delete_Cancel_but), "Cancel button doesn't exist");

			//Step 5: Click on @cancel button
			madrid.Tap(InBoxVars.inBox_Delete_Cancel_but);

			AppResult[] result_messages_text_new = madrid.Query(InBoxVars.inBox_Message);
			for (int i = 0; i < result_messages_text.Length; i++) {
				Assert.AreEqual(result_messages_text[i].Text, result_messages_text_new[i].Text);
			}
		}
    }
}
