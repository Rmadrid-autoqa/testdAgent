using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using System.Collections.Generic;
using NUnit.Framework;

namespace RealMadrid_UITest
{

    /* INSTRUCCIONES
     * - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
     * 
     * La clase Utilities contiene una librería personalizada para nuestro uso a la hora de implementar los test.
     * 
     * Podemos y deberíamos mantenerla actualizada, creando nuevos métodos útiles, adaptando las funcionalidades 
     * disponibles a las necesidades de los tests.
     * 
     * Conceptualmente, la utilidad de la librería es eliminar código redundante en la clase principal de tests que
     * estés implementando, por ejemplo, si en la implementación de test te percatas de que puedes ahorrarte líneas de 
     * código creando un método que englobe varios casos iguales, pero con distintos parámetros.
     * 
     * - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
     */


    public class Utilities
    {
        private IApp app;

        public string _device = "Tablet1";

        public Utilities(IApp a)
        {
            app = a;
        }



        public void Sleep(int seconds)
        {
            System.Threading.Thread.Sleep(seconds * 1000);
        }



        public void Login_parameters(String username, String password)
        {

            app.EnterText(LoginVars.login_User_Input, username);
            app.DismissKeyboard();
            app.WaitForElement(LoginVars.login_Password_Input);
            app.EnterText(LoginVars.login_Password_Input, password);
            app.DismissKeyboard();
            app.Tap(LoginVars.login_Next_but);
            Sleep(10);
        }

        public void GoTo_LoginCredential()
        {
            app.WaitForElement(LoginVars.Credentials_exchange_but);
            app.Tap(LoginVars.Credentials_exchange_but);
        }
    

        public void Login_data(string user, string password)
        {
            GoTo_LoginCredential();
            int counter = 0;

            if (existsElement(LoginVars.Toke_Label))
            {
                app.EnterText(LoginVars.Toke_Label, user);
                app.DismissKeyboard();
                app.Tap(LoginVars.Token_but);
                seeingHome();
                Sleep(9);
                /*if (existsElement(HomeVars.home_tok))
                    {
                        Tok_Control();
                        if (existsElement(HomeVars.home_tok_RMStore))
                        {
                            Tok_Control2();
                        }
                    }*/
            }
            else
            {
                while (!seeingHome() && counter < 10)
                {
                    Console.WriteLine("LOGIN -- No se ve Home");
                    Sleep(4);
                    // Solo para local
                    //app.Repl();
                    if (existsElement(LoginVars.login_User_Input))
                    {
                        Login_parameters(user, password);
                    }
                    else
                    {
                        Console.WriteLine("LOGIN -- No se ven los input de user/pass");
                        counter++;
                        Sleep(6);
                    }
                }
                if (counter == 10)
                {
                    Assert.True(false, "LOGIN -- FAILURE Demasiado tiempo de espera");
                }
                else
                {
                    Console.WriteLine("LOGIN -- SUCCESS Si se ve Home");
                    Sleep(10);
                    if (existsElement(HomeVars.home_tok))
                    {
                        //app.Tap(HomeVars.home_tok);
                        Tok_Control();
                        if (existsElement(HomeVars.home_tok_RMStore))
                        {
                            Tok_Control2();
                        }
                        /*else
                        {
                            Tok_Control();
                        }*/
                    }
                }
            }
        }

        public void Login()
        {
            Login_data(Strings.LOGIN_USERNAME, Strings.LOGIN_PASSWORD);
        }

        public void LogOff()
        {
            int counter = 0;
            while (!existsElement(LoginVars.login_User_Input) && counter < 10)
            {
                if (seeingHome())
                {
                    Sign_Off();
                }
                else
                {
                    counter++;
                    Sleep(4);
                }
            }
            if (counter == 10)
            {
                Assert.True(false, "LOGOUT -- FAILURE Demasiado tiempo de espera");
            }
            else
            {
                Console.WriteLine("LOGOUT -- SUCCESS");
            }
        }



        public void Sign_Off()
        {
            app.Tap(NavigationBarVars.navbar_Profile_but);
            app.Tap(NavigationBarVars.navbar_Home_but);
            Access_Tab_Main_Menu(MainMenuVars.menu_Ajustes_but);
            this.Sleep(5);
            this.Go_To(SettingsVars.settings_scrollview, SettingsVars.settings_logout_but);
            app.Tap(SettingsVars.settings_logout_but);
            this.Sleep(2);
            app.Tap(SettingsVars.settings_logout_ok_but);
        }



        public void Enter_Home()
        {
            app.Tap(NavigationBarVars.navbar_Home_but);
        }



        public void Change_Sport()
        {
            this.Enter_Home();
            app.Tap(HomeVars.home_Change_Sport_but);
        }

        public void Go_To_Up(Func<AppQuery, AppQuery> lambda, Func<AppQuery, AppQuery> view, int max, string errormsg)
        {
            int count = 0;
            while (!existsElement(lambda) && count < max)
            {
                app.ScrollUp(view, ScrollStrategy.Gesture, 0.50, 2000, true);
                count++;
            }
            if (count == max)
            {
                Assert.True(false, errormsg);
            }
        }

        public void Go_To(Func<AppQuery, AppQuery> lambda, Func<AppQuery, AppQuery> view, int max, string errormsg)
        {
            int count = 0;
            while (!existsElement(lambda) && count < max)
            {
                app.ScrollDown(view, ScrollStrategy.Gesture, 0.50, 2000, true);
                count++;
            }
            if (count == max)
            {
                Assert.True(false, errormsg);
            }
        }

        public void Go_To(Func<AppQuery, AppQuery> view, Func<AppQuery, AppQuery> element)
        {
            while (app.Query(element).Length == 0)
            {
                app.ScrollDown(view, ScrollStrategy.Gesture, 0.50, 3000, true);
            }
        }



        /*
               public void Go_To_Horizontal_Player_Card(String player)
               {
                   while (app.Query(a => a.Text(player)).Length == 0)
                   {
                       app.SwipeRightToLeft("players_scroll", 0.80, 2000, true);
                   }
                   app.Tap(a => a.Text(player));
                   app.Tap(a => a.Id("pager_player_detail"));
               }

       */


        // Utilizado en Inbox
        public void Swipe_To_Right(Func<AppQuery, AppQuery> content, Func<AppQuery, AppQuery> element)
        {
            while (!this.existsElement(element))
                app.SwipeRightToLeft(content, 0.2, 300, true);

        }

        public void Go_To_Up(String view, String element)
        {
            while (app.Query(a => a.Id(element)).Length == 0)
            {
                app.ScrollUp(view, ScrollStrategy.Gesture, 0.80, 2000, true);
            }
        }

        public void ScrollUp_To_Element(Func<AppQuery, AppQuery> element)
        {
            while (!this.existsElement(element))
                app.ScrollUp();
        }


        // Este metodo no se eberia usar, hay que cambiarlo a "existsElement"
        /*
        public bool existsId(String id)
        {
            return app.Query(a => a.Id(id)).Length > 0;
        }
        */



        public bool existsElement(Func<AppQuery, AppQuery> lambda)
        {
            return app.Query(lambda).Length > 0;
        }



        public bool existsElement(Func<AppQuery, AppWebQuery> lambda)
        {
            return app.Query(lambda).Length > 0;
        }



        public bool existsElementList(Func<AppQuery, AppQuery> view, Func<AppQuery, AppQuery> element, List<String> list)
        {
            List<String> aux = new List<String>();
            AppResult[] results;

            while (aux.Count < list.Count)
            {
                results = app.Query(element);

                if (aux.Count == 0)
                {
                    for (int i = 0; i < results.Length; i++)
                    {
                        aux.Add(results[i].Text);
                    }
                }
                else
                {
                    for (int i = 0; i < results.Length; i++)
                    {
                        if (!aux.Contains(results[i].Text))
                        {
                            aux.Add(results[i].Text);
                        }
                    }
                }

                app.ScrollDown(view, ScrollStrategy.Gesture, 0.30, 600, true);
            }

            for (int i = 0; i < list.Count; i++)
            {
                if (!list[i].Equals(aux[i]))
                {
                    return false;
                }
            }

            return true;
        }



        public bool seeingHome()
        {
            return existsElement(HomeVars.home_Change_Sport_but);
        }



        public bool seeingMatchArea()
        {
            return existsElement(MatchAreaVars.match_area_identifier);
        }



        public void Access_Tab_Main_Menu(Func<AppQuery, AppQuery> lambda)
        {
            Sleep(2);
            app.Tap(MainMenuVars.menu_Main_but);
            int max = 0;
            while (!existsElement(lambda) && max < 5)
            {
                app.ScrollDown(MainMenuVars.menu_Main_Container, ScrollStrategy.Gesture, 0.30, 500, true);
                max++;
            }
            if (max == 5)
            {
                Assert.True(false, "No se encuentra la opcion en el menu");
            }
            app.Tap(lambda);
            Sleep(6);
        }


        /*
        public void profile_clear() {
            Access_Tab_Main_Menu(MainMenuVars.menu_Perfil_but);
            app.ClearText(ProfileVars.profile_Nickname_input);
            app.DismissKeyboard();
            app.ClearText(ProfileVars.profile_Name_input);
            app.DismissKeyboard();
            app.ClearText(ProfileVars.profile_Surname_input);
            app.DismissKeyboard();
            Go_To(ProfileVars.profile_Container, ProfileVars.profile_Save_but);
            app.Tap(ProfileVars.profile_Save_but);
            Sleep(2);

            while (app.Query(ProfileVars.profile_Ok_but).Length > 0) {
                app.Tap(ProfileVars.profile_Ok_but);
            }
            app.Back();
        }



        public void profile_fill(String nickName, String Name, String Surname) {
            Access_Tab_Main_Menu(MainMenuVars.menu_Perfil_but);
            app.ClearText(ProfileVars.profile_Nickname_input);
            app.EnterText(ProfileVars.profile_Nickname_input, nickName);
            app.DismissKeyboard();
            app.ClearText(ProfileVars.profile_Namef_input);
            app.EnterText(ProfileVars.profile_Name_input, Name);
            app.DismissKeyboard();
            app.ClearText(ProfileVars.profile_Surname_input);
            app.EnterText(ProfileVars.profile_Surname_input, Surname);
            app.DismissKeyboard();
            Go_To(ProfileVars.profile_Container, ProfileVars.profile_Save_but);
            app.Tap(ProfileVars.profile_Save_but);
            Sleep(2);

            while (app.Query(ProfileVars.profile_Ok_but).Length > 0) {
                app.Tap(ProfileVars.profile_Ok_but);
            }
            app.Back();
        }
        */

        /*
        public void profile_fill_standard() {
            profile_fill(Strings.PROFILE_NICKNAME, Strings.PROFILE_NAME, Strings.PROFILE_SURNAME);
        }*/



        //Settings menu
        public void change_Language(Func<AppQuery, AppQuery> language)
        {
            app.Tap(SettingsVars.settings_language_but);
            this.Sleep(5);
            app.Tap(language);
        }



        public bool Find_Text(AppResult[] list, String text)
        {
            int aux = list.Length;
            for (int i = 0; i < aux; i++)
            {
                if (text == list[i].Text)
                    return true;
            }
            return false;
        }

        //Tok controller
        public void Tok_Control()
        {
            if (existsElement(HomeVars.home_tok))
            {
                app.Tap(HomeVars.home_tok);
            }

        }

        public void Tok_Control2()
        {
            app.Tap(HomeVars.home_tok);
            app.WaitForElement(HomeVars.home_tok_RMStore);
            app.Tap(HomeVars.home_tok_RMStore);
            Sleep(2);
            app.Tap(HomeVars.home_tok_RMStore);
            app.WaitForElement(HomeVars.home_tok);
            app.Tap(HomeVars.home_tok);

        }

        //Inbox

        public void Check_list(String element)
        {
            AppResult[] results = app.Query(a => a.Id(element));

            for (int i = 0; i < results.Length; i++)
            {
                app.Tap(a => a.Id(element).Index(i));
            }
        }
    }
}
