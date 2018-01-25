using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;



namespace RealMadrid_UITest
{


    public class MainMenuVars
    {

        // iphone
        //public static Func<AppQuery, AppQuery> menu_Main_but = a => a.Id("RMNavigationContainerView").Child("UIButton").Index(0);
        public static Func<AppQuery, AppQuery> menu_Main_but = a => a.Class("UINavigationBar").Child(1).Child(0);
        //public static Func<AppQuery, AppQuery> menu_Main_Container = a => a.Id("bgProfileMenu_1.jpg").Parent(1).Child("UICollectionView");
        public static Func<AppQuery, AppQuery> menu_Main_Container = a => a.Id("bgProfileMenu_1.jpg").Parent(1).Child("UIView");

        public static Func<AppQuery, AppQuery> menu_alias = a => a.Text("AutoTester");
        public static Func<AppQuery, AppQuery> menu_name = a => a.Text("Qa Test");
        public static Func<AppQuery, AppQuery> menu_img_exp = a => a.Id("xPIcon.png");
        public static Func<AppQuery, AppQuery> menu_tv_exp = a => a.Id("xPIcon.png").Sibling("UILabel").Index(2);
        public static Func<AppQuery, AppQuery> menu_img_coins = a => a.Id("coinIcon.png");
        public static Func<AppQuery, AppQuery> menu_tv_coins = a => a.Id("xPIcon.png").Sibling("UILabel").Index(3);
        public static Func<AppQuery, AppQuery> menu_Perfil_but = a => a.Id("defaultAvatar.png");
        public static Func<AppQuery, AppQuery> perfil_Title = a => a.Text("PERFIL DE USUARIO");
        public static Func<AppQuery, AppQuery> menu_image = a => a.Id("bgProfileMenu_1.jpg");

        public static Func<AppQuery, AppQuery> menu_items_id = a => a.Text("Noticias");
        public static Func<AppQuery, AppQuery> menu_Noticias_but = a => a.Text("Noticias");
        public static Func<AppQuery, AppQuery> noticias_Title = a => a.Text("NOTICIAS");
        public static Func<AppQuery, AppQuery> menu_Tienda_but = a => a.Text("Tienda");
        public static Func<AppQuery, AppQuery> menu_Tickets_but = a => a.Text("Entradas");
        public static Func<AppQuery, AppQuery> menu_Bernaveu_Virtual_but = a => a.Text("Bernabeu virtual");
        public static Func<AppQuery, AppQuery> menu_Ficha_Jugador_but = a => a.Text("Ficha Jugador");
        public static Func<AppQuery, AppQuery> ficha_Jugador_Title = a => a.Text("Cromos de jugadores");
        public static Func<AppQuery, AppQuery> menu_La_Decima_but = a => a.Text("La Champions");
        public static Func<AppQuery, AppQuery> la_Decima_Title = a => a.Text("VÍDEOS");
        public static Func<AppQuery, AppQuery> menu_Real_Madrid_TV_but = a => a.Text("Real Madrid TV");
        public static Func<AppQuery, AppQuery> menu_Checkin_but = a => a.Text("Checkin");
        public static Func<AppQuery, AppQuery> Checkin_Title = a => a.Text("CHECK-INS");
        public static Func<AppQuery, AppQuery> menu_Estadísticas_but = a => a.Text("Estadísticas");
        public static Func<AppQuery, AppQuery> estadísticas_Title = a => a.Text("ESTADÍSTICAS");
        public static Func<AppQuery, AppQuery> menu_Inbox_but = a => a.Text("Buzón");
        public static Func<AppQuery, AppQuery> inbox_Title = a => a.Text("INBOX");
        public static Func<AppQuery, AppQuery> menu_Madridistas_but = a => a.Text("Madridistas");
        public static Func<AppQuery, AppQuery> madridista_Title = a => a.Text("MADRIDISTA");
        public static Func<AppQuery, AppQuery> menu_Socios_but = a => a.Text("Socios");
        public static Func<AppQuery, AppQuery> socios_Title = a => a.Text("BIENVENIDO A SU ÁREA PRIVADA");
        public static Func<AppQuery, AppQuery> menu_Tour_Virtual_but = a => a.Text("Tour Virtual");
        public static Func<AppQuery, AppQuery> menu_Ajustes_but = a => a.Text("Ajustes");
        public static Func<AppQuery, AppQuery> ajustes_Title = a => a.Text("AJUSTES");
        public static Func<AppQuery, AppQuery> menu_Virtual_Store_but = a => a.Text("Virtual Store");
        public static Func<AppQuery, AppQuery> virtual_store_title = a => a.Text("TIENDA VIRTUAL");
        public static Func<AppQuery, AppQuery> menu_Profile_but = a => a.Text("Mi perfil");
        public static Func<AppQuery, AppQuery> menu_Finder_but = a => a.Text("Buscador");
        public static Func<AppQuery, AppQuery> menu_Social_but = a => a.Text("Social");
        public static Func<AppQuery, AppQuery> social_Title = a => a.Text("SOCIAL");
        public static Func<AppQuery, AppQuery> video_Player = a => a.Marked("Vídeo");
        public static Func<AppQuery, AppQuery> web_View = a => a.Class("UIWebView");

        //ipad
        public static Func<AppQuery, AppQuery> menu_Tickets_but_Tablet = a => a.Text("Tickets");
        public static Func<AppQuery, AppQuery> menu_Bernaveu_Virtual_but_Tablet = a => a.Text("Bernabeu Virtual");
        public static Func<AppQuery, AppQuery> menu_Inbox_but_Tablet = a => a.Text("Inbox");
        public static Func<AppQuery, AppQuery> madridista_Title_Tablet = a => a.Text("MADRIDISTAS");
        public static Func<AppQuery, AppQuery> menu_Finder_but_Tablet = a => a.Text("Buscador");
    }
}
