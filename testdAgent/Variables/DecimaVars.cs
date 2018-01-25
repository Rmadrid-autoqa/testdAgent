using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;



namespace RealMadrid_UITest
{


    public class DecimaVars
    {
        
        public static Func<AppQuery, AppQuery> decima_header_title = a => a.Id("UINavigationItemView").Marked("VÍDEOS");
        public static Func<AppQuery, AppQuery> decima_main_video = a => (a.Class("RMContainerTableViewCell").Child().Index(0).Child().Index(0).Child(0));
        public static Func<AppQuery, AppQuery> decima_video_list = (a => a.Id("icnLikeOff").Index(1).Parent(1));
        public static Func<AppQuery, AppQuery> video_player_icon = a => a.Marked("Vídeo"); 
        
    }
}
