using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;



namespace RealMadrid_UITest
{


    public class HomeVars
    {

        public static Func<AppQuery, AppQuery> home_content = a => a.Class("UILayoutContainerView");
        public static Func<AppQuery, AppQuery> home_content_right_column = a => a.Class("UITableViewWrapperView").Index(1);
        public static Func<AppQuery, AppQuery> home_Change_Sport_but = a => a.Class("TTFadeSwitch");
        public static Func<AppQuery, AppQuery> home_Game_Week = (a => a.Text("Real Madrid").Sibling().Class("UILabel").Index(1));

        public static Func<AppQuery, AppQuery> home_Pager_Games_View = (a => a.Text("Real Madrid").Index(0).Parent(2).Child(1));
        public static Func<AppQuery, AppQuery> home_all_news = (a => a.Text("NOTICIAS").Sibling().Class("UILabel").Index(3));

        public static Func<AppQuery, AppQuery> header_logo = (a => a.Id("RMNavigationContainerView").Child().Index(1));
        public static Func<AppQuery, AppQuery> navigation_icon_back = (a => a.Id("RMNavigationContainerView").Child().Index(3));

        // Pop up share native
        public static Func<AppQuery, AppQuery> Share_Native_popup_title = (a => a.Text("Compartir Contenido"));
        public static Func<AppQuery, AppQuery> Share_NativeApps_view = (a => a.Class("UITransitionView").Child().Index(1));

        //public static Func<AppQuery, AppQuery> home_main_end = a => a.Id("home_purchasable_subscription");

        // Pop up share
        public static Func<AppQuery, AppQuery> Share_popup_title = a => a.Text("Compartir Contenido");
        public static Func<AppQuery, AppQuery> Facebook_but_popup = a => a.Id("facebook_icon");
        public static Func<AppQuery, AppQuery> twitter_but_popup = a => a.Id("twitter_icon");
        public static Func<AppQuery, AppQuery> whatsapp_but_popup = a => a.Id("Whatsapp_Icon");
        public static Func<AppQuery, AppQuery> mail_but = a => a.Id("Mail_Icon");
        public static Func<AppQuery, AppQuery> native_but = a => a.Id("option_Icon");
        public static Func<AppQuery, AppQuery> ok_but = a => a.Text("Cancelar");

        // Share options 
        public static Func<AppQuery, AppQuery> like_but = (a => a.Id("icnLikeOff").Index(0));
        public static Func<AppQuery, AppQuery> share_but = a => a.Marked("Share Icon");
        public static Func<AppQuery, AppQuery> whatsapp_but = a => a.Marked("Whatsapp Icon");
        public static Func<AppQuery, AppQuery> facebook_but = a => a.Marked("facebook icon");
        public static Func<AppQuery, AppQuery> twitter_but = a => a.Marked("twitter icon");

        // Video player 
        public static Func<AppQuery, AppQuery> Video_player = a => a.Class("AVPlayerView");

        //Next Games placeholder
        public static Func<AppQuery, AppQuery> home_match_area_but = (a => a.Class("UIButton").Marked("ÁREA PARTIDO"));
        public static Func<AppQuery, AppQuery> home_buy_ticket_but = (a => a.Class("UIButton").Marked("COMPRAR ENTRADA"));

        public static Func<AppQuery, AppQuery> home_game_home_icon = (a => a.Text("Real Madrid").Sibling().Class("UIImageView").Index(0));
        public static Func<AppQuery, AppQuery> home_game_away_icon = (a => a.Text("Real Madrid").Sibling().Class("UIImageView").Index(1));

        public static Func<AppQuery, AppQuery> home_home_score = (a => a.Text("Real Madrid").Sibling().Class("UILabel").Index(2));
        public static Func<AppQuery, AppQuery> home_away_score = (a => a.Text("Real Madrid").Sibling().Class("UILabel").Index(3));
        public static Func<AppQuery, AppQuery> home_game_time = (a => a.Text("Real Madrid").Sibling().Index(7));

        public static Func<AppQuery, AppQuery> home_game_home_name = (a => a.Text("Real Madrid").Sibling().Class("UILabel").Index(1));
        public static Func<AppQuery, AppQuery> home_game_away_name = (a => a.Text("Real Madrid").Sibling().Class("UILabel").Index(4));

        // Tokk
        public static Func<AppQuery, AppQuery> home_tok = a => a.Id("TOKtvSDK.bundle/TOKButton").Parent(0);
        public static Func<AppQuery, AppQuery> home_tok_RMStore = a => a.Text("RM Store").Parent(0);
    }
}