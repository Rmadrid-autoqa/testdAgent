using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;



namespace RealMadrid_UITest
{


    public class SettingsVars
    {

        public static Func<AppQuery, AppQuery> settings_data_protection_link = (a => a.Marked("Protección de datos"));

        public static Func<AppQuery, AppQuery> settings_language_but = (a => a.Class("UIButton").Index(0));
        public static Func<AppQuery, AppQuery> settings_english_usa = (a => a.Text("Inglés (USA)"));
        public static Func<AppQuery, AppQuery> settings_spanish = (a => a.Text("Español"));
        public static Func<AppQuery, AppQuery> settings_indonesio = (a => a.Text("Indonesio"));
        public static Func<AppQuery, AppQuery> settings_arab = (a => a.Text("Árabe (Arabia Saudí)"));
        public static Func<AppQuery, AppQuery> settings_logout_but = (a => a.Text("Cerrar sesión"));
        public static Func<AppQuery, AppQuery> settings_logout_popup = (a => a.Text("Cerrar sesión"));
        public static Func<AppQuery, AppQuery> settings_logout_ok_but = (a => a.Text("SI"));
        public static Func<AppQuery, AppQuery> settings_scrollview = (a => a.Class("UILayoutContainerView"));


        public static Func<AppQuery, AppQuery> settings_legal_warning_link = (a => a.Id("RMLegalDataTableViewCell").Index(1));

        //public static Func<AppQuery, AppQuery> data_protection_legal_warning_view = (a => a.Id("web_view"));

        public static Func<AppQuery, AppQuery> menu_settings_but_EN = (a => a.Text("Settings"));
        public static Func<AppQuery, AppQuery> settings_spanish_EN = (a => a.Text("Spanish"));

        public static Func<AppQuery, AppQuery> menu_settings_but_IN = (a => a.Text("Pengaturan"));
        public static Func<AppQuery, AppQuery> settings_spanish_IN = (a => a.Text("Spanyol"));

        public static Func<AppQuery, AppQuery> menu_settings_but_AR = (a => a.Text("الاعدادات"));
        public static Func<AppQuery, AppQuery> settings_spanish_AR = (a => a.Text("الإسبانية"));

    }
}
