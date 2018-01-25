using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;



namespace RealMadrid_UITest
{


    public class NavigationBarVars
    {

        public static Func<AppQuery, AppQuery> navbar_container = a => a.Class("UITabBar");
        public static Func<AppQuery, AppQuery> navbar_Home_but = a => a.Class("UITabBarButton").Marked("Inicio");
        public static Func<AppQuery, AppQuery> navbar_Match_area_but = a => a.Class("UITabBarButton").Marked("Área de partido");
        public static Func<AppQuery, AppQuery> navbar_Match_area_Basket_but = a => a.Class("UITabBarButton").Marked("Área de Partido");
        public static Func<AppQuery, AppQuery> navbar_Social_but = a => a.Class("UITabBarButton").Marked("Social");
        public static Func<AppQuery, AppQuery> navbar_Profile_but = a => a.Class("UITabBarButton").Marked("Perfil");
        public static Func<AppQuery, AppQuery> navbar_Games_but = a => a.Class("UITabBarButton").Marked("Juegos");
        public static Func<AppQuery, AppQuery> navbar_Virtual_Store_but = a => a.Class("UITabBarButton").Marked("Tienda Virtual");

        public static Func<AppQuery, AppQuery> match_area_SoloApp_but = a => a.Text("Sólo en la App");
        public static Func<AppQuery, AppQuery> match_area_Title = a => a.Text("Área de partido");

        public static Func<AppQuery, AppQuery> virtual_store_view_all_but = a => a.Class("UIButton").Marked("VER TODO");
        public static Func<AppQuery, AppQuery> virtual_store_videos_but = a => a.Marked("VÍDEOS");
        public static Func<AppQuery, AppQuery> virtual_store_videos_content = a => a.Text("Los goles de los mejores jugadores del Real Madrid");

        public static Func<AppQuery, AppQuery> profile_Title = a => a.Text("ÁREA PERSONAL");
        public static Func<AppQuery, AppQuery> profile_edit_but = (a => a.Class("UIButton").Marked("EDITAR PERFIL"));
        public static Func<AppQuery, AppQuery> profile_edit_title = a => a.Marked("Tu Avatar");
        public static Func<AppQuery, AppQuery> profile_edit_preferences_but = a => a.Marked("PREFERENCIAS");
        public static Func<AppQuery, AppQuery> profile_edit_preferences_football = a => a.Marked("FÚTBOL");
        public static Func<AppQuery, AppQuery> profile_edit_preferences_basket = a => a.Marked("BALONCESTO");


    }
}
