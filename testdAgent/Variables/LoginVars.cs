using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;



namespace RealMadrid_UITest
{


    public class LoginVars
    {

       /* // Login by Credentials
        //public static Func<AppQuery, AppQuery> Login_Credentials_Title = a => a.Id("tvDescription");
        public static Func<AppQuery, AppQuery> login_User_Input = a => a.Id("etUsername");
        public static Func<AppQuery, AppQuery> login_Password_Input = a => a.Id("etPassword");
        public static Func<AppQuery, AppQuery> login_Next_but = a => a.Id("btLogin");*/
        public static Func<AppQuery, AppQuery> Credentials_exchange_but = a => a.Id("mailLetterIcon");

        //
        public static Func<AppQuery, AppQuery> recovery_password_link = a => a.Id("btForgotPassword");
        //public static Func<AppQuery, AppQuery> login_User_Input = (a => a.Class("SkyFloatingLabelTextField").Child(2));
        public static Func<AppQuery, AppQuery> login_User_Input = (a => a.Text(" E - mail"));
        public static Func<AppQuery, AppQuery> login_Password_Input = (a => a.Text(" E - mail").Parent(0).Sibling(2));
        //public static Func<AppQuery, AppQuery> login_Password_Input = (a => a.Text("Introduzca una contraseña").Parent(1).Child(3));
        //public static Func<AppQuery, AppQuery> login_Next_but = (a => a.Class("UIButtonLabel").Text("ENVIAR"));
        public static Func<AppQuery, AppQuery> login_Next_but = (a => a.Class("UIButton").Child(1));

        public static Func<AppQuery, AppWebQuery> google_exchange_but = (a => a.Class("webView").Css("BUTTON#GoogleExchange"));
        //public static Func<AppQuery, AppWebQuery> recovery_password_link = (a => a.Class("webView").Css("#forgotPasswordLink"));
        public static Func<AppQuery, AppWebQuery> recovery_email_input = (a => a.Css("INPUT#email"));
        public static Func<AppQuery, AppWebQuery> recovery_email_send = (a => a.Css("BUTTON#email_ver_but_send"));
        public static Func<AppQuery, AppWebQuery> recovery_code_input = (a => a.Css("INPUT#email_ver_input"));
        public static Func<AppQuery, AppWebQuery> recovery_verify_but = (a => a.Css("BUTTON#email_ver_but_verify"));
        public static Func<AppQuery, AppWebQuery> recovery_invalid_code = (a => a.Css("DIV#email_fail_retry"));
        public static Func<AppQuery, AppWebQuery> recovery_email_resend = (a => a.Css("BUTTON#email_ver_but_resend"));
        public static Func<AppQuery, AppWebQuery> google_User_Input = a => a.Css("INPUT#Email");
        public static Func<AppQuery, AppWebQuery> google_Password_Input = a => a.Css("INPUT#Passwd");
        public static Func<AppQuery, AppWebQuery> google_Next_but = a => a.Css("INPUT#next");
        public static Func<AppQuery, AppWebQuery> google_Login_but = x => x.Css("INPUT#signIn");
        public static Func<AppQuery, AppWebQuery> facebook_exchange_but = (a => a.Css("BUTTON#FacebookExchange"));
        public static Func<AppQuery, AppWebQuery> facebook_User_Input = a => a.Css("INPUT._56bg._4u9z._5ruq");
        //public static Func<AppQuery, AppWebQuery> facebook_User_Input = a => a.Css("INPUT#u_0_1");
        public static Func<AppQuery, AppWebQuery> facebook_Password_Input = a => a.Css("INPUT#u_0_2");
        public static Func<AppQuery, AppWebQuery> facebook_Login_but = a => a.Css("BUTTON#u_0_6");

        //public static Func<AppQuery, AppWebQuery> register_but = a => a.Class("WebView").Css("A#createAccount");
        public static Func<AppQuery, AppWebQuery> register_but = a => a.Css("A#createAccount");
        public static Func<AppQuery, AppWebQuery> register_email = a => a.Css("INPUT#email");
        public static Func<AppQuery, AppWebQuery> register_password = a => a.Css("INPUT#newPassword");
        public static Func<AppQuery, AppWebQuery> register_reenter_password = a => a.Css("INPUT#reenterPassword");

        public static Func<AppQuery, AppWebQuery> register_check = a => a.Css("INPUT#Conditions");
        public static Func<AppQuery, AppWebQuery> register_continue = a => a.Css("BUTTON#continue");
        public static Func<AppQuery, AppWebQuery> register_repeated_email = a => a.Css("DIV#claimVerificationServerError");
        public static Func<AppQuery, AppWebQuery> register_missing_field = a => a.Css("DIV#requiredFieldMissing");
        public static Func<AppQuery, AppWebQuery> register_wrong_field = a => a.Css("DIV#fieldIncorrect");
        public static Func<AppQuery, AppWebQuery> register_password_missmatc = a => a.Css("DIV#passwordEntryMismatch.error.pageLevel");
        public static Func<AppQuery, AppQuery> register_cancel_but = a => a.Text("Cancelar");

        public static Func<AppQuery, AppQuery> active_popup_title = a => a.Text("Gracias por registrarte en Real Madrid App.");
        public static Func<AppQuery, AppQuery> active_popup_description = a => a.Text("Te acabamos de enviar un email, comprueba el correo para acabar el proceso de registro.");
        public static Func<AppQuery, AppQuery> active_popup_retry = a => a.Text("REINTENTAR");
        public static Func<AppQuery, AppQuery> active_popup_ok_but = a => a.Text("REENVIAR EMAIL");
        public static Func<AppQuery, AppQuery> active_popup_cancel_but = a => a.Text("CERRAR SESIÓN");

        // login with token

        public static Func<AppQuery, AppQuery> Toke_Label = (a => a.Class("UITextFieldLabelddddd"));
        public static Func<AppQuery, AppQuery> Token_but = (a => a.Class("UIButton"));

    }
}
