using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;



namespace RealMadrid_UITest
{


    public class MatchAreaVars
    {

        // Iphone
        public static Func<AppQuery, AppQuery> match_area_identifier = (a => a.Marked("Área de partido"));
        //public static Func<AppQuery, AppQuery> match_area_goBack = (a => a.Marked("Área de partido").Parent().Index(0).Child("UIButton"));
        public static Func<AppQuery, AppQuery> match_area_goBack = a => a.Class("UIButton").Index(0).Child("UIImageView");

        // Ipadd
        public static Func<AppQuery, AppQuery> match_area_goBack_Tablet = a => a.Class("UIButton").Index(0).Child("UIImageView");
    }
}
