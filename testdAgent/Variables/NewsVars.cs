using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest.Queries;

namespace RealMadrid_UITest.Tools
{
    class NewsVars{

        
        public static Func<AppQuery, AppQuery> news_Share_but         = a => a.Id("Share_Icon");
        public static Func<AppQuery, AppQuery> news_NativeApps_view   = a => a.Id("ActivityListView");

        public static Func<AppQuery, AppQuery> news_NativeApps_ok_but =  a => a.Text("Cancelar");
        //public static Func<AppQuery, AppQuery> news_img               = a => a.Id("img");
        public static Func<AppQuery, AppQuery> news_title             = a => a.Class("UINavigationItemView").Marked("NOTICIAS");
        public static Func<AppQuery, AppQuery> news_description       = a => a.Id("news_description");
        public static Func<AppQuery, AppQuery> news_carousel          = a => a.Id("news_image_strip");
        public static Func<AppQuery, AppQuery> news_main_img = (a => a.Marked("Share Icon").Index(0).Parent(1).Sibling("UIImageView"));
        public static Func<AppQuery, AppQuery> news_main_title = (a => a.Marked("Share Icon").Index(0).Parent(1).Sibling("UILabel"));
        public static Func<AppQuery, AppQuery> news_main_like_but = a => a.Id("icnLikeOff");
        public static Func<AppQuery, AppQuery> news_main_share_but = a => a.Id("Share_Icon");
        public static Func<AppQuery, AppQuery> news_main_whatsapp_but = a => a.Id("Whatsapp_Icon");
        public static Func<AppQuery, AppQuery> news_main_facebook_but = a => a.Id("facebook_icon");
        public static Func<AppQuery, AppQuery> news_main_twitter_but = a => a.Id("twitter_icon");
		public static Func<AppQuery, AppQuery> news_list_news		  = (a => a.Class("RMContainerTableViewCell"));     
        public static Func<AppQuery, AppQuery> news_list_fav_but      = a => a.Id("icnLikeOff");
        public static Func<AppQuery, AppQuery> news_list_share_but    = a => a.Id("Share_Icon");
		public static Func<AppQuery, AppQuery> news_list_time = a => (a.Class("UITableViewCellContentView").Index(2).Child(0).Child(0).Child(2));
        //public static Func<AppQuery, AppQuery> news_promotion_banner  = a => a.Id("promotion_banner_top");
        public static Func<AppQuery, AppQuery> news_newWithCarousel   = a => a.Marked("La Fundación Real Madrid y la Fundación Mapfre renuevan su colaboración");
        public static Func<AppQuery, AppQuery> news_video = (a => a.Marked("Share Icon").Parent(1).Child("UIButton"));
        public static Func<AppQuery, AppQuery> news_video_carousel = (a => a.Class("RMNewsAssetCollectionViewCell").Class("UIView").Class("UIButton").Index(0));
        public static Func<AppQuery, AppQuery> news_big_carousel_pager = a => a.Class("UIPageCrontol");
        public static Func<AppQuery, AppQuery> news_big_carousel_close_but = a => a.Marked("x");

        public static Func<AppQuery, AppQuery> news_new_example_ad = a => a.Text("Presentación del acuerdo de patrocinio entre el Real Madrid y Telefónica");
        public static Func<AppQuery, AppQuery> new_example_title = a => a.Text("Presentación del acuerdo de patrocinio entre el Real Madrid y Telefónica");
        //public static Func<AppQuery, AppQuery> new_example_ad = a => a.Id("lst_related_players_ads"); //No existe el anuncion en IOS
        public static Func<AppQuery, AppQuery> new_example_shirt_but = (a => a.Text("COMPRAR AHORA!").Parent(1).Child("UIImageView"));
        public static Func<AppQuery, AppQuery> news_new_img = (a => a.Class("UIImageView").Index(0));

        public static Func<AppQuery, AppQuery> menu_Noticias_but      = a => a.Text("Noticias");
        public static Func<AppQuery, AppQuery> home_pager_new_content = (a => a.Text("NOTICIAS").Sibling("UIPageControl"));
        public static Func<AppQuery, AppQuery> home_new_image = (a => a.Text("NOTICIAS").Sibling(4).Child(0).Child("UIImageView"));
        public static Func<AppQuery, AppQuery> home_new_title = (a => a.Text("NOTICIAS").Sibling(4).Child(0).Child("UILabel").Index(0));
        public static Func<AppQuery, AppQuery> home_new_like_but = (a => a.Text("NOTICIAS").Sibling(5).Child(0).Child("LikeButton"));
        public static Func<AppQuery, AppQuery> home_new_share         = a => a.Marked("Share Icon");
        public static Func<AppQuery, AppQuery> home_new_whatsapp_but  = a => a.Marked("Whatsapp Icon");
        public static Func<AppQuery, AppQuery> home_new_facebook_but  = a => a.Marked("facebook icon");
        public static Func<AppQuery, AppQuery> home_new_twitter_but   = a => a.Marked("twitter icon");
        public static Func<AppQuery, AppQuery> home_new_view_all      = a => a.Marked("NOTICIAS").Sibling().Marked("VER TODO");
        





    }
}
