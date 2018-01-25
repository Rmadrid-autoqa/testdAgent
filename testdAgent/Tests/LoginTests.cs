using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;


namespace RealMadrid_UITest.Tests {
    //[TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]


    public class LoginTests {
        IApp madrid;
        Utilities utils;
        Strings str;
        Platform platform;



        public LoginTests(Platform platform) {
            this.platform = platform;
        }



        /*

        [SetUp]
        public void BeforeEachTest()
        {
            madrid = AppInitializer.StartApp(platform);
            utils = new Utilities(madrid);
            login_vars = new LoginVars();
            utils.Login();
        }


        [TearDown]
        public void AfterEachTest()
        {
//            utils.Enter_Home();
//            utils.Sign_Off();
        }

    */


        [SetUp]
        public void BeforeEachTest() {
            madrid = AppInitializer.StartApp(platform);
            utils = new Utilities(madrid);
            str = new Strings();
            //utils.LogOff();
        }



        [TearDown]
        public void AfterEachTest() {
            			if (utils.seeingHome()) {
                           utils.Sign_Off();
                        }
        }



        [Test]
        //Login with correct parameters
        public void Test_34306() {
            utils.Login_data(Strings.LOGIN_USERNAME1, Strings.LOGIN_PASSWORD1);
            Assert.True(utils.seeingHome(), "No se ha hecho login");
            madrid.Repl();
            utils.LogOff();
            utils.Login_data(Strings.LOGIN_USERNAME, Strings.LOGIN_PASSWORD);
            Assert.True(utils.seeingHome(), "No se ha hecho login");
            utils.LogOff();
        }

		

        [Test]
        //Login with incorrect parameters
        public void Test_34307() {
            utils.Login_parameters(Strings.LOGIN_USERNAME_EMPTY, Strings.LOGIN_PASSWORD_EMPTY);
            Assert.False(utils.seeingHome());
            utils.Login_parameters(Strings.LOGIN_USERNAME_INCORRECT, Strings.LOGIN_PASSWORD1);
            Assert.False(utils.seeingHome());
        }


        [Test]
        //Fail message appears when wrong verification email
        public void Test_34314() {
            madrid.Tap(LoginVars.recovery_password_link);
			utils.Sleep(7);
			madrid.WaitForElement(LoginVars.recovery_email_input);
            madrid.EnterText(LoginVars.recovery_email_input, Strings.LOGIN_USERNAME);
            madrid.DismissKeyboard();
            madrid.Tap(LoginVars.recovery_email_send);
			utils.Sleep(3);
			madrid.WaitForElement(LoginVars.recovery_code_input);
            madrid.EnterText(LoginVars.recovery_code_input, Strings.LOGIN_PASSWORD);
            madrid.DismissKeyboard();
            madrid.Tap(LoginVars.recovery_verify_but);
            utils.Sleep(3);
            Assert.True(madrid.Query(LoginVars.recovery_invalid_code).Length > 0);
        }





        [Test]
        //Login with Google+
        public void Test_34310()
        {
            madrid.WaitForElement(LoginVars.google_exchange_but);
			madrid.Tap(LoginVars.google_exchange_but);
			madrid.Tap(LoginVars.google_exchange_but);
			madrid.WaitForElement(LoginVars.google_User_Input);
            madrid.EnterText(LoginVars.google_User_Input, Strings.LOGIN_GOOGLE);
            madrid.DismissKeyboard();
            madrid.Tap(LoginVars.google_Next_but);
            madrid.EnterText(LoginVars.google_Password_Input, Strings.PASSWORD_GOOGLE);
            madrid.DismissKeyboard();
            madrid.Tap(LoginVars.google_Login_but);
            utils.Sleep(10);
            Assert.True(utils.seeingHome(), "No se ha hecho login");
            //utils.LogOff();
        }
		
        [Test]
        //Login with Facebook
        public void Test_34309()
        {
			madrid.WaitForElement(LoginVars.facebook_exchange_but);
			madrid.Tap(LoginVars.facebook_exchange_but);
			madrid.Tap(LoginVars.facebook_exchange_but);
			utils.Sleep(10);
			//Assert.False(true);
			//madrid.WaitForElement(LoginVars.facebook_User_Input);
			//madrid.WaitForElement(LoginVars.facebook_Password_Input);
            madrid.EnterText(LoginVars.facebook_User_Input, Strings.LOGIN_FACEBOOK);
            madrid.DismissKeyboard();
            madrid.EnterText(LoginVars.facebook_Password_Input, Strings.PASSWORD_FACEBOOK);
            madrid.DismissKeyboard();
            madrid.Tap(LoginVars.facebook_Login_but);
            utils.Sleep(50);
			//madrid.WaitForElement(MainMenuVars.menu_Main_but);
            Assert.True(utils.seeingHome(), "No se ha hecho login");
            //utils.LogOff();

        }






        [Test]
        //Register registered email
        public void Test_34456()
        {
            madrid.Tap(LoginVars.register_but);
			madrid.Tap(LoginVars.register_but);
			utils.Sleep(2);
            madrid.EnterText(LoginVars.register_email, Strings.LOGIN_USERNAME);
            madrid.DismissKeyboard();
            madrid.EnterText(LoginVars.register_password, Strings.LOGIN_PASSWORD);
            madrid.DismissKeyboard();
            madrid.EnterText(LoginVars.register_reenter_password, Strings.LOGIN_PASSWORD);
            madrid.DismissKeyboard();
            madrid.Tap(LoginVars.register_check);
            madrid.ScrollDown();
            madrid.Tap(LoginVars.register_continue);
            madrid.ScrollUp();
            utils.Sleep(2);
            Assert.True(utils.existsElement(LoginVars.register_repeated_email), "No se ve el mensaje de email repetido");

        }

        private void register_incorrect_data(String user, String pass1, String pass2, Func<AppQuery, AppWebQuery> expected, String msg)
        {
            utils.Sleep(6);
			madrid.Tap(LoginVars.register_but);
			//madrid.Tap(LoginVars.register_but);
			utils.Sleep(3);
            madrid.EnterText(LoginVars.register_email, user);
            madrid.DismissKeyboard();
            madrid.EnterText(LoginVars.register_password, pass1);
            madrid.DismissKeyboard();
            madrid.EnterText(LoginVars.register_reenter_password, pass2);
            madrid.DismissKeyboard();
            madrid.Tap(LoginVars.register_check);
            madrid.ScrollDown();
            madrid.Tap(LoginVars.register_continue);
            utils.Sleep(2);
            madrid.ScrollUp();
            //  utils.Sleep(5);
            Assert.True(utils.existsElement(expected), msg);
        }

        [Test]
        //Register with incorrect data
        public void Test_36492()
        {
            register_incorrect_data("", "", "", LoginVars.register_missing_field, "No se muestra el mensaje de campo obligatorio");
			madrid.Tap(LoginVars.register_cancel_but);
            utils.Sleep(7);
            register_incorrect_data("wrong@.m", "aA123456", "aA123456", LoginVars.register_wrong_field, "No se muestra el mensaje de campo erroneo");
			madrid.Tap(LoginVars.register_cancel_but);
			utils.Sleep(7);
			//register_incorrect_data("invalid#$%&@gmail.com", "aA123456", "aA123456", LoginVars.register_wrong_field, "No se muestra el mensaje de campo erroneo");
			//madrid.Back();
			register_incorrect_data("any@email.com", "aA123456", "", LoginVars.register_password_missmatc, "No se muestra el mensaje de contraseña distinta");
			madrid.Tap(LoginVars.register_cancel_but);
			utils.Sleep(4);
			register_incorrect_data("any@email.com", "a1234567", "a1234567", LoginVars.register_wrong_field, "No se muestra el mensaje de campo erroneo");
			madrid.Tap(LoginVars.register_cancel_but);
			utils.Sleep(4);
			register_incorrect_data("any@email.com", "aA123456", "aA123457", LoginVars.register_password_missmatc, "No se muestra el mensaje de contraseña distinta");
			madrid.Tap(LoginVars.register_cancel_but);
			utils.Sleep(4);
        }




        [Test]
        //Login with an old user for the first time in email validation
        public void Test_36756()
        {
            utils.Login_data(Strings.LOGIN_USERNAME_OLD, Strings.LOGIN_PASSWORD_OLD);
        }

        [Test]
        //User has not validated email and tries to log in
        public void Test_36561()
        {
            //String user = DateTime.Now.ToOADate().ToString() + "@yopmail.com";
            String user = DateTime.Now.ToBinary() + "@yopmail.com";

            utils.Sleep(3);
			madrid.WaitForElement(LoginVars.register_but);
			madrid.Tap(LoginVars.register_but);
			//madrid.Tap(LoginVars.register_but);
			utils.Sleep(3);
            madrid.EnterText(LoginVars.register_email, user);
            madrid.DismissKeyboard();
            madrid.EnterText(LoginVars.register_password, Strings.LOGIN_PASSWORD_NOT_VALIDATED);
            madrid.DismissKeyboard();
            madrid.EnterText(LoginVars.register_reenter_password, Strings.LOGIN_PASSWORD_NOT_VALIDATED);
            madrid.DismissKeyboard();
            madrid.Tap(LoginVars.register_check);
            madrid.ScrollDown();
            madrid.Tap(LoginVars.register_continue);
            utils.Sleep(30);
            Assert.True(utils.existsElement(LoginVars.active_popup_title),"No se ve el titulo del popup de usuario no activo");
            Assert.True(utils.existsElement(LoginVars.active_popup_description), "No se ve la descripcion del popup de usuario no activo");
            Assert.True(utils.existsElement(LoginVars.active_popup_retry), "No se ve el boton de reintentar del popup de usuario no activo");
            Assert.True(utils.existsElement(LoginVars.active_popup_ok_but), "No se ve el boton de reenviar email del popup de usuario no activo");
            Assert.True(utils.existsElement(LoginVars.active_popup_cancel_but), "No se ve el boton de cancelar del popup de usuario no activo");
            madrid.Tap(LoginVars.active_popup_cancel_but);
            madrid = AppInitializer.StartApp(platform);
            utils.Login_parameters(user, Strings.LOGIN_PASSWORD_NOT_VALIDATED);
            utils.Sleep(10);
            Assert.True(utils.existsElement(LoginVars.active_popup_title), "No se ve el titulo del popup de usuario no activo");
            Assert.True(utils.existsElement(LoginVars.active_popup_description), "No se ve la descripcion del popup de usuario no activo");
            Assert.True(utils.existsElement(LoginVars.active_popup_retry), "No se ve el boton de reintentar del popup de usuario no activo");
            Assert.True(utils.existsElement(LoginVars.active_popup_ok_but), "No se ve el boton de reenviar email del popup de usuario no activo");
            Assert.True(utils.existsElement(LoginVars.active_popup_cancel_but), "No se ve el boton de cancelar del popup de usuario no activo");

        }





        /*
        [Test]
        public void Test_36572()
        {            
            madrid.Tap(LoginVars.register_but);
            madrid.Tap(x => x.Class("WebView").Css("SELECT#extension_Cpim_Language"));
            madrid.Tap(x => x.Text("Español"));
            madrid.Tap(x => x.Class("WebView").XPath("//A[text()=\"Política de Privacidad\"]"));            
            //AppWebResult[] result;
            //result = madrid.Query(x => x.Class("WebView").Css("H1#modalLabel"));
            //string name = result[0].TextContent;
            //Console.WriteLine(name);            
            //utils.existsElement(x => x.Class("WebView").Css("H1#modalLabel"));
            madrid.Tap(x => x.Class("WebView").XPath("//SPAN[text()=\"×\"]"));
            madrid.Tap(x => x.Class("WebView").XPath("//A[text()=\"Aviso Legal\"]"));
            //madrid.Tap(x => x.Class("WebView").Css("H1#modalLabel"));            
            //result = madrid.Query(x => x.Class("WebView").Css("H1#modalLabel"));
            //name = result[0].TextContent;
            //Console.WriteLine(name);            
            madrid.Tap(x => x.Class("WebView").XPath("//SPAN[text()=\"×\"]"));
            madrid.Back();

            madrid.Tap(LoginVars.register_but);
            madrid.Tap(x => x.Class("WebView").Css("SELECT#extension_Cpim_Language"));
            madrid.Tap(x => x.Text("Inglés (USA)"));
            madrid.Tap(x => x.Class("WebView").XPath("//A[text()=\"Privacy Policy\"]"));
            madrid.Tap(x => x.Class("WebView").XPath("//SPAN[text()=\"×\"]"));
            madrid.Tap(x => x.Class("WebView").XPath("//A[text()=\" Legal Advice\"]"));
            madrid.Tap(x => x.Class("WebView").XPath("//SPAN[text()=\"×\"]"));
            madrid.Back();

            madrid.Tap(LoginVars.register_but);
            madrid.Tap(x => x.Class("WebView").Css("SELECT#extension_Cpim_Language"));
            madrid.Tap(x => x.Text("Árabe (Arabia Saudí)")); //app.Tap(x => x.Id("text1"));
            madrid.Tap(x => x.Class("WebView").XPath("//A[text()=\"سياسة الخصوصية \"]"));
            madrid.Tap(x => x.Class("WebView").XPath("//SPAN[text()=\"×\"]"));
            madrid.Tap(x => x.Class("WebView").XPath("//A[text()=\"الإشعار القانوني\"]"));
            madrid.Tap(x => x.Class("WebView").XPath("//SPAN[text()=\"×\"]"));
            madrid.Back();

            madrid.Tap(LoginVars.register_but);
            madrid.Tap(x => x.Class("WebView").Css("SELECT#extension_Cpim_Language"));
            madrid.Tap(x => x.Text("Indonesio"));
            madrid.Tap(x => x.Class("WebView").XPath("//A[text()=\"Privacy Policy\"]"));
            madrid.Tap(x => x.Class("WebView").XPath("//SPAN[text()=\"×\"]"));
            madrid.Tap(x => x.Class("WebView").XPath("//A[text()=\"Legal Advice\"]"));
            madrid.Tap(x => x.Class("WebView").XPath("//SPAN[text()=\"×\"]"));
            madrid.Back();

            //madrid.Tap(LoginVars.register_but);
            //madrid.Tap(x => x.Class("WebView").Css("SELECT#extension_Cpim_Language"));
            //madrid.Tap(x => x.Text("Frances"));
            //madrid.Tap(x => x.Class("WebView").XPath("//A[text()=\"Politique de Confidentialité\"]"));
            //madrid.Tap(x => x.Class("WebView").XPath("//SPAN[text()=\"×\"]"));
            //madrid.Tap(x => x.Class("WebView").XPath("//A[text()=\" Mentions Légales\"]"));
            //madrid.Tap(x => x.Class("WebView").XPath("//SPAN[text()=\"×\"]"));
            //madrid.Back();

            madrid.Tap(LoginVars.register_but);
            madrid.Tap(x => x.Class("WebView").Css("SELECT#extension_Cpim_Language"));
            madrid.Tap(x => x.Text("Japonés"));
            madrid.Tap(x => x.Class("WebView").XPath("//A[text()=\"個人情報保護方針\"]"));
            madrid.Tap(x => x.Class("WebView").XPath("//SPAN[text()=\"×\"]"));
            madrid.Tap(x => x.Class("WebView").XPath("//A[text()=\" 法的通知\"]"));
            madrid.Tap(x => x.Class("WebView").XPath("//SPAN[text()=\"×\"]"));
            madrid.Back();

            madrid.Tap(LoginVars.register_but);
            madrid.Tap(x => x.Class("WebView").Css("SELECT#extension_Cpim_Language"));
            madrid.Tap(x => x.Text("Portugúes"));
            madrid.Tap(x => x.Class("WebView").XPath("//A[text()=\"Política de Privacidade\"]"));
            madrid.Tap(x => x.Class("WebView").XPath("//SPAN[text()=\"×\"]"));
            madrid.Tap(x => x.Class("WebView").XPath("//A[text()=\" Aviso Legal\"]"));
            madrid.Tap(x => x.Class("WebView").XPath("//SPAN[text()=\"×\"]"));
            madrid.Back();

            madrid.Tap(LoginVars.register_but);
            madrid.Tap(x => x.Class("WebView").Css("SELECT#extension_Cpim_Language"));
            madrid.Tap(x => x.Text("China"));
            madrid.Tap(x => x.Class("WebView").XPath("//A[text()=\"隐私条款\"]"));
            madrid.Tap(x => x.Class("WebView").XPath("//SPAN[text()=\"×\"]"));
            madrid.Tap(x => x.Class("WebView").XPath("//A[text()=\" 法律声明\"]"));
            madrid.Tap(x => x.Class("WebView").XPath("//SPAN[text()=\"×\"]"));
            madrid.Back();
          
        }
          */      

        
    }

}