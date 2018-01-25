using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace RealMadrid_UITest
{
    class VideoVars
    {
        
        public static Func<AppQuery, AppQuery> Video_HeaderTitle = (a => a.Class("UINavigationItemView").Marked("VÍDEOS"));

        // Main video
        public static Func<AppQuery, AppQuery> Main_video_title = (a => a.Class("UITableViewCellContentView").Index(0).Child().Index(0).Child("UILabel"));
        
        // Video list
        public static Func<AppQuery, AppQuery> Video_share_but = a => a.Id("Share_Icon");
		public static Func<AppQuery, AppQuery> Video_favorite_but = (a => a.Class("UITableViewCellContentView").Index(0).Child().Index(0).Child(1).Child("LikeButton"));
        public static Func<AppQuery, AppQuery> Video_title = (a => a.Id("icnLikeOff").Index(1).Parent().Index(1).Child("UILabel"));
        public static Func<AppQuery, AppQuery> Video_play = (a => a.Id("icnLikeOff").Index(1).Parent().Index(1).Child("UIButton").Index(1));
		public static Func<AppQuery, AppQuery> Video_GoBack = (a => a.Text("OK"));
		public static Func<AppQuery, AppQuery> Video_page_GoBack = (a => a.Text("VÍDEOS").Parent(1).Child(3));

		// Ipad

		public static Func<AppQuery, AppQuery> Video_play_Tablet = a => a.Id("facebook_icon").Parent(2).Child(1);   
    }
}
