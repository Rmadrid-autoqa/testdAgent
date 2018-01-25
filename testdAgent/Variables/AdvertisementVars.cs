using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest.Queries;

namespace RealMadrid_UITest.Variables
{
    class AdvertisementVars
    {
        
        public static Func<AppQuery, AppQuery> adver_all_videos_but        = a => a.Class("UILabel").Marked("VER TODO");
        public static Func<AppQuery, AppQuery> adver_pager_videos_carrusel = a => a.Text("VÍDEOS").Sibling().Index(5);
        public static Func<AppQuery, AppQuery> adver_video_left            = a => a.Text("VÍDEOS").Sibling().Index(5).Child().Index(0);
        public static Func<AppQuery, AppQuery> adver_video_middle          = a => a.Text("VÍDEOS").Sibling().Index(5).Child().Index(1);
        public static Func<AppQuery, AppQuery> adver_home_main             = a => a.Class("UIButtonLabel");
        public static Func<AppQuery, AppQuery> adver_view                  = a => a.Class("UINavigationTransitionView");

        public static Func<AppQuery, AppQuery> videos_ad_banner_top        = a => a.Class("UITableViewCellContentView").Child().Index(0).Child().Index(0);
        public static Func<AppQuery, AppQuery> videos_ad_banner_bottom     = a => a.Class("UITableViewCellContentView").Child().Index(0).Child().Index(4);

        public static Func<AppQuery, AppQuery> webview_ad_shirt = a => a.Class("UIWebView");
        
        public static Func<AppQuery, AppQuery> matchArea_horizontal_ad_left = a => a.Id("tokTvBackground.png").Sibling().Index(0);
        public static Func<AppQuery, AppQuery> matchArea_horizontal_ad_right = a => a.Id("tokTvBackground.png").Sibling().Index(1);
        
    }
}
