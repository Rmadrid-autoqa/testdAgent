using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;



namespace RealMadrid_UITest
{


    public class CheckinVars
    {
        
        public static Func<AppQuery, AppQuery> checkin_popup_OK_but     = a => a.Id("button1");
        public static Func<AppQuery, AppQuery> checkin_popup_Cancel_but = a => a.Id("button2");
        public static Func<AppQuery, AppQuery> checkin_icon_list_img    = a => a.Id("icon");
        public static Func<AppQuery, AppQuery> checkin_title_list       = a => a.Id("title");
        public static Func<AppQuery, AppQuery> checkin_time_list        = a => a.Id("time");
        public static Func<AppQuery, AppQuery> checkin_casa_Ronaldo     = a => a.Id("value").Text("Casa Ronaldo");
        public static Func<AppQuery, AppQuery> checkin_popup            = a => a.Id("message");
        public static Func<AppQuery, AppQuery> checkin_list             = a => a.Id("checkins_list");
        
    }
}
