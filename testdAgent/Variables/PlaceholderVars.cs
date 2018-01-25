using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;



namespace RealMadrid_UITest
{


    public class PlaceholderVars
    {

        // Missed Match placeholder
        public static Func<AppQuery, AppQuery> MissedMatch_ph_title = a => a.Text("¿Te perdiste el partido?");
        public static Func<AppQuery, AppQuery> MissedMatch_ph_subtitle = (a => a.Text("El mejor resumen del partido con vídeos exclusivos e información estadística"));


        // Classification and Fixtures placeholder 
        public static Func<AppQuery, AppQuery> classification_tab_text = a => a.Marked("CLASIFICACIÓN");
        public static Func<AppQuery, AppQuery> calendar_tab_text = a => a.Marked("PARTIDOS");
        public static Func<AppQuery, AppQuery> matches_finder_tab_text = a => a.Marked("ENCUENTRA PARTIDO");

        // Classification placeholder tab
        public static Func<AppQuery, AppQuery> classification_ph_title = (a => a.Text("VER TODO").Sibling("UILabel"));

        public static Func<AppQuery, AppQuery> classification_view_all_but = (a => a.Text("VER TODO"));

        public static Func<AppQuery, AppQuery> classification_position_1 = (a => a.Marked("1"));
        public static Func<AppQuery, AppQuery> classification_position_2 = (a => a.Marked("2"));
        public static Func<AppQuery, AppQuery> classification_position_3 = (a => a.Marked("3"));
        public static Func<AppQuery, AppQuery> classification_position_4 = (a => a.Marked("4"));
        public static Func<AppQuery, AppQuery> classification_position_5 = (a => a.Marked("5"));
        public static Func<AppQuery, AppQuery> classification_position_6 = (a => a.Marked("6"));

        //Classification section
        public static Func<AppQuery, AppQuery> classification_title = (a => a.Id("CLASIFICACIÓN"));
        public static Func<AppQuery, AppQuery> classification_Liga_tab_text = (a => a.Text("La Liga"));
        public static Func<AppQuery, AppQuery> classification_Champions_tab_text = (a => a.Text("LIGA DE CAMPEONES"));
        public static Func<AppQuery, AppQuery> classification_current_status = (a => a.Class("UITableView").Sibling().Index(0));
        public static Func<AppQuery, AppQuery> classification_combobox = (a => a.Class("UITableView").Sibling().Index(0));
        public static Func<AppQuery, AppQuery> classification_combobox_champions_EighthFinals = (a => a.Marked("Octavos de final"));
        public static Func<AppQuery, AppQuery> classification_Napoli = (a => a.Marked("Monaco"));

        // Calendar tab
        public static Func<AppQuery, AppQuery> calendar_next_month = (a => a.Class("UICollectionView").Sibling("UIButton").Index(1));
        public static Func<AppQuery, AppQuery> calendar_previous_month = (a => a.Class("UICollectionView").Sibling("UIButton").Index(0));
        public static Func<AppQuery, AppQuery> calendar_fixture_home = (a => a.Class("RMCalendarMatchCollectionViewCell").Index(0));
        //public static Func<AppQuery, AppQuery> calendar_fixture_away = a => a.Id("fixture_away");
        public static Func<AppQuery, AppQuery> calendar_current_month = (a => a.Class("UICollectionView").Sibling("UILabel"));
        public static Func<AppQuery, AppQuery> calendar_February2017_month = (a => a.Text("FEBRERO 2017"));
        public static Func<AppQuery, AppQuery> calendar_month = (a => a.Class("UICollectionView").Sibling("UILabel"));
        public static Func<AppQuery, AppQuery> calendar_RM_NAPOLI_3 = (a => a.Marked("3 - 1"));
        public static Func<AppQuery, AppQuery> calendar_RM_FENERBAHCE_61 = (a => a.Marked("61 - 56"));
        
        // Match finder tab
        public static Func<AppQuery, AppQuery> MatchFinder_search = a => a.Text("Selecciona un equipo");
        public static Func<AppQuery, AppQuery> MatchFinder_entry_name = a => (a.Text("Sporting Lisbon"));
        public static Func<AppQuery, AppQuery> MatchFinder_MatchArea_but = a => a.Marked("Área Partido");


		// Missed Match info pop up
		//public static Func<AppQuery, AppQuery> calendar_matcharea_but = a => a.Text("Área Partido");
		public static Func<AppQuery, AppQuery> calendar_matcharea_but = a => a.Class("UILabel").Text("Área Partido").Index(1).Parent(0).Child("UIButton");  

        // List Generic content placeholder
        public static Func<AppQuery, AppQuery> List_generic_content_ph = (a => a.Class("UIButton").Index(0));

        // Match day placeholder
        public static Func<AppQuery, AppQuery> Match_day_ph = a => a.Marked("JUEGA CON NOSOTROS");

        // News placeholder
        public static Func<AppQuery, AppQuery> news_ph_title = a => (a.Marked("NOTICIAS"));
        public static Func<AppQuery, AppQuery> news_ph_viewAll_but = a=> (a.Marked("NOTICIAS").Sibling("UILabel"));
        public static Func<AppQuery, AppQuery> news_image_ph = (a => a.Id("facebook_icon").Parent().Index(3).Child().Index(0).Child("UIImageView"));


        // Next Games placeholder
        public static Func<AppQuery, AppQuery> Next_Games_pager_indicator = (a => a.Class("UIPageControl").Index(0));
        public static Func<AppQuery, AppQuery> Next_Games_ph_competition = (a => a.Text("Real Madrid").Parent().Index(0).Child("UILabel").Index(0));
        public static Func<AppQuery, AppQuery> Next_Games_ph_HomeTeam = (a => a.Text("Real Madrid").Sibling().Class("UIImageView").Index(0));
        public static Func<AppQuery, AppQuery> Next_Games_ph_AwayTeam = (a => a.Text("Real Madrid").Sibling().Class("UIImageView").Index(1));

        public static Func<AppQuery, AppQuery> Next_Games_ph_GameTime = (a => a.Text("Real Madrid").Parent().Index(0).Child().Index(7).Child().Index(0));
        public static Func<AppQuery, AppQuery> Next_Games_ph_GameDays = (a => a.Text("Real Madrid").Parent().Index(0).Child().Index(7).Child().Index(1).Child().Index(1));
        public static Func<AppQuery, AppQuery> Next_Games_ph_GameHours = (a => a.Text("Real Madrid").Parent().Index(0).Child().Index(7).Child().Index(2).Child().Index(1));
        public static Func<AppQuery, AppQuery> Next_Games_ph_GameMins = (a => a.Text("Real Madrid").Parent().Index(0).Child().Index(7).Child().Index(3).Child().Index(1));

        public static Func<AppQuery, AppQuery> Next_Games_ph_HomeName = (a => a.Text("Real Madrid").Parent().Index(0).Child("UILabel").Index(2).Text("Real Madrid"));
        public static Func<AppQuery, AppQuery> Next_Games_ph_Tickets_but = (a => a.Text("Real Madrid").Parent().Index(0).Child().Index(7).Child().Index(5));
        public static Func<AppQuery, AppQuery> Next_Games_ph_webView = a => a.Class("UIWebView");

		public static Func<AppQuery, AppQuery> NextGamer_Ph_RealMadrid = a => a.Text("Real Madrid").Index(0);

        // Purchase VirtualGood
        public static Func<AppQuery, AppQuery> Purchase_VG_thumb = (a => a.Marked("BIENES VIRTUALES").Sibling().Index(5).Child().Index(0).Child().Index(0));

        // Social placeholder
        public static Func<AppQuery, AppQuery> Social_ph_favorite_icon = a => a.Marked("favoriteOn");
        public static Func<AppQuery, AppQuery> Social_ph_retweet_icon = a => a.Marked("retweetOn");
        public static Func<AppQuery, AppQuery> Social_ph_share_icon = a => a.Marked("shareOn");
        public static Func<AppQuery, AppQuery> Social_ph_viewAll_but = (a => a.Marked("SOCIAL").Sibling().Text("VER TODO"));
        public static Func<AppQuery, AppQuery> Social_ph_tweet_content = (a => a.Text("@realmadrid").Sibling(3));
		public static Func<AppQuery, AppQuery> Social_ph_tweet_img = (a => a.Text("@realmadrid").Sibling(1));
		public static Func<AppQuery, AppQuery> Social_ph_tweet_account_img = (a => a.Text("@realmadrid").Sibling(2));
		public static Func<AppQuery, AppQuery> Social_ph_pager = (a => a.Marked("SOCIAL").Sibling().Class("UIPageControl").Index(0));
        public static Func<AppQuery, AppQuery> Social_ph_mainContent = (a => a.Marked("SOCIAL").Sibling().Class("UIScrollView").Index(0));

        public static Func<AppQuery, AppQuery> Social_twitter_title = (a => a.Marked("SOCIAL"));

        // Subscription single placeholder
        public static Func<AppQuery, AppQuery> Subscription_ph_mainImage = (a => a.Text("NUEVOS VÍDEOS").Sibling().Index(5).Child().Index(0).Child().Index(0));
        public static Func<AppQuery, AppQuery> Subscription_ph_sectionTitle = (a => a.Text("NUEVOS VÍDEOS"));
        public static Func<AppQuery, AppQuery> Subscription_ph_viewAll_but = (a => a.Text("NUEVOS VÍDEOS").Sibling().Text("VER TODO"));
        public static Func<AppQuery, AppQuery> Subscription_ph_price = (a => a.Text("NUEVOS VÍDEOS").Sibling().Index(5).Child().Index(0).Child().Index(2));


        // Video Multiple placeholder
        public static Func<AppQuery, AppQuery> Videos_ph_sectionTitle = (a => a.Text("VÍDEOS"));
        public static Func<AppQuery, AppQuery> Videos_ph_viewAll_but = (a => a.Text("VÍDEOS").Sibling().Text("VER TODO"));
        public static Func<AppQuery, AppQuery> Videos_ph_title = a => a.Text("VÍDEOS");
		public static Func<AppQuery, AppQuery> Videos_ph_share_left = (a => a.Text("VÍDEOS").Sibling().Index(5).Child().Index(0).Child().Index(0).Child(0).Child().Marked("Share Icon"));

        // Video Single placeholder
        public static Func<AppQuery, AppQuery> VideoSingle_ph_play = (a => a.Marked("Benzema firma su temporada más efectiva").Sibling().Index(2).Sibling().Index(0));
        public static Func<AppQuery, AppQuery> VideoSingle_ph_image = (a => a.Marked("Benzema firma su temporada más efectiva").Sibling().Index(2).Sibling().Index(0));
        public static Func<AppQuery, AppQuery> VideoSingle_ph_Title = (a => a.Marked("Benzema firma su temporada más efectiva"));



        // Subscription Purchasable placeholder
        //public static Func<AppQuery, AppQuery> SubscriptionPurchasable_ph = a => a.Id("home_purchasable_subscription");
        //public static Func<AppQuery, AppQuery> MatchAway_webview = a => a.Id("Match_AwayTeam_BadgeUrl");

        // Finish match popup

        public static Func<AppQuery, AppQuery> Finish_match_CompetitionChampions_popup = (a => a.Text("Real Madrid").Sibling().Index(0));
        public static Func<AppQuery, AppQuery> Finish_match_roundEighthFinals_popup = (a => a.Text("Real Madrid").Sibling().Index(0));
        public static Func<AppQuery, AppQuery> Finish_match_date_popup = (a => a.Text("Real Madrid").Sibling().Index(1));
        public static Func<AppQuery, AppQuery> Finish_match_status_popup = (a => a.Text("Real Madrid").Sibling().Index(1));
        public static Func<AppQuery, AppQuery> Finish_match_homeicon_popup = (a => a.Text("Real Madrid").Sibling().Index(2));
        public static Func<AppQuery, AppQuery> Finish_match_awayicon_popup = (a => a.Text("Real Madrid").Sibling().Index(4));
        public static Func<AppQuery, AppQuery> Finish_match_homescore_popup = (a => a.Text("Real Madrid").Sibling().Index(3));
        public static Func<AppQuery, AppQuery> Finish_match_awayscore_popup = (a => a.Text("Real Madrid").Sibling().Index(8));
        public static Func<AppQuery, AppQuery> Finish_match_homename_popup = (a => a.Text("Real Madrid").Sibling().Index(5));
        public static Func<AppQuery, AppQuery> Finish_match_awayname_popup = (a => a.Text("Área Partido").Sibling().Index(7));
        public static Func<AppQuery, AppQuery> Finish_match_matchArea_popup_but = (a => a.Text("Real Madrid").Sibling().Index(6));
        public static Func<AppQuery, AppQuery> Finish_match_ok_popup_but = a => a.Text("Cerrar");


        public static Func<AppQuery, AppQuery> Finish_match_CompetitionEuroleague_popup = (a => a.Text("Euroliga 2016-2017"));
        public static Func<AppQuery, AppQuery> Finish_match_roundFirstRound_popup = (a => a.Text("1ª Ronda"));

		// ///////////////////////// Ipad 

		// Missed Match info pop up
		public static Func<AppQuery, AppQuery> calendar_matcharea_but_Tablet = a => a.Id("linesPopUp.png").Parent(0).Child(0).Child(0).Child(0).Child(8);
    
		// Video Single placeholder
		public static Func<AppQuery, AppQuery> VideoSingle_ph_play_Tablet = (a => a.Marked("Pepe: \"Jugar en Turín es complicado pero soñamos con llegar a la final\""));
	}
}

