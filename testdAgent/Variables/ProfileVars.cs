using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;



namespace RealMadrid_UITest {


        public class ProfileVars {

		public static Func<AppQuery, AppQuery> personal_area_view = a => a.Class("UITableViewWrapperView");
		public static Func<AppQuery, AppQuery> personal_area_menu_but = (a => a.Text("ÁREA PERSONAL").Parent(1).Child(2));
		//public static Func<AppQuery, AppQuery> profile_Container 			= 	a => a.Id("pager_profile");
        //public static Func<AppQuery, AppQuery> profile_Nickname_input 		= 	a => a.Id("profile_nickname");
        //public static Func<AppQuery, AppQuery> profile_Name_input 			= 	a => a.Id("profile_name");
        //public static Func<AppQuery, AppQuery> profile_Surname_input 		= 	a => a.Id("profile_surname");
        //public static Func<AppQuery, AppQuery> profile_Save_but 			= 	a => a.Id("profile_save");
        //public static Func<AppQuery, AppQuery> profile_Ok_but 				= 	a => a.Id("button1");
        //public static Func<AppQuery, AppQuery> profile_LogOut_but 			= 	a => a.Id("profile_close");
        public static Func<AppQuery, AppQuery> profile_favourites_but           = a => a.Marked("Mis me gusta");
        public static Func<AppQuery, AppQuery> profile_edit_but                 =   a => a.Text("EDITAR PERFIL");
        //public static Func<AppQuery, AppQuery> preferences_but              =   a => a.Id("NoResourceEntry-2"); /****Se bloquea al hacer tree***/
        //public static Func<AppQuery, AppQuery> moreInfo_but                 =   a => a.Id("NoResourceEntry-3"); /****Se bloquea al hacer tree***/
        //public static Func<AppQuery, AppQuery> profile_avatar             = a => a.Id("profile_avatar");  /****Se bloquea al hacer tree***/

        //Account placeholder
        public static Func<AppQuery, AppQuery> profile_account_avatar_but   =   a => a.Text("EDITAR AVATAR");
		//public static Func<AppQuery, AppQuery> profile_account_name         =   a => a.Id("name");
		//public static Func<AppQuery, AppQuery> link_social_but = a => a.Id("identity1");
		public static Func<AppQuery, AppQuery> link_madridista_but = (a => a.Text("Carné de socio ó madridista"));
		public static Func<AppQuery, AppQuery> link_madridista_but_linked = (a => a.Id("memberCard"));
        //public static Func<AppQuery, AppQuery> link_facebook_but = a => a.Id("dialog1");
        //public static Func<AppQuery, AppQuery> link_twitter_but = a => a.Id("dialog2");
        //public static Func<AppQuery, AppQuery> link_google_but = a => a.Id("dialog3");
        //public static Func<AppQuery, AppQuery> link_microsoft_but = a => a.Id("dialog4");

        public static Func<AppQuery, AppQuery> avatar_img                   = a => a.Id("avatarDefault.png");
        public static Func<AppQuery, AppQuery> edit_avatar_but              = a => a.Text("EDITAR AVATAR");
        public static Func<AppQuery, AppQuery> refresh_avatar_but           = a => a.Id("refreshIcon.png").Index(0);



        //Preferencias
        public static Func<AppQuery, AppQuery> prefs_football_but         =   a => a.Id("prefs_football_title");
        public static Func<AppQuery, AppQuery> prefs_basket_but           =   a => a.Id("prefs_basket");
        public static Func<AppQuery, AppQuery> prefs_football_share_but     =   a => a.Id("bt_share_footbal");
        public static Func<AppQuery, AppQuery> prefs_basket_share_but       =   a => a.Id("bt_share_basket");

        //Jugadores preferidos football
        public static Func<AppQuery, AppQuery> prefs_done_football_but = a => a.Text("OK");
        public static Func<AppQuery, AppQuery> prefs_skip_football_but = a => a.Text("ATRÁS");
        //public static Func<AppQuery, AppQuery> prefs_football_forwards_but = a => a.Id("preferred_forwards"); /* No esta enIOS */
        //public static Func<AppQuery, AppQuery> prefs_football_mid_offensive_but = a => a.Id("preferred_mid_offensive"); /* No esta enIOS */
        //public static Func<AppQuery, AppQuery> prefs_football_mid_defensive_but = a => a.Id("preferred_mid_defensive"); /* No esta enIOS */
        //public static Func<AppQuery, AppQuery> prefs_football_defenses_but = a => a.Id("preferred_defenses"); /* No esta enIOS */
        //public static Func<AppQuery, AppQuery> prefs_football_goalkeepers_but = a => a.Id("preferred_goalkeepers"); /* No esta enIOS */

        //Jugadores preferidos basket
        public static Func<AppQuery, AppQuery> prefs_done_basket_but = a => a.Text("OK");
        public static Func<AppQuery, AppQuery> prefs_skip_basket_but = a => a.Text("ATRÁS");
        //public static Func<AppQuery, AppQuery> prefs_basket_fourth = a => a.Id("preferred_fourth"); /* No esta enIOS */
        //public static Func<AppQuery, AppQuery> prefs_basket_third = a => a.Id("preferred_third"); /* No esta enIOS */
        //public static Func<AppQuery, AppQuery> prefs_basket_second = a => a.Id("preferred_second"); /* No esta enIOS */
        //public static Func<AppQuery, AppQuery> prefs_basket_first = a => a.Id("preferred_first"); /* No esta enIOS */

        //Numeros de jugadores preferidos
        public static Func<AppQuery, AppQuery> prefs_player_1 = a => a.Class("UILabel").Text("1");
        public static Func<AppQuery, AppQuery> prefs_player_2 = a => a.Class("UILabel").Text("2");
        public static Func<AppQuery, AppQuery> prefs_player_3 = a => a.Class("UILabel").Text("3");
        public static Func<AppQuery, AppQuery> prefs_player_4 = a => a.Class("UILabel").Text("4");
        public static Func<AppQuery, AppQuery> prefs_player_5 = a => a.Class("UILabel").Text("5");
        public static Func<AppQuery, AppQuery> prefs_player_6 = a => a.Class("UILabel").Text("6");
        public static Func<AppQuery, AppQuery> prefs_player_7 = a => a.Class("UILabel").Text("7");
        public static Func<AppQuery, AppQuery> prefs_player_8 = a => a.Class("UILabel").Text("8");
        public static Func<AppQuery, AppQuery> prefs_player_9 = a => a.Class("UILabel").Text("9");
        public static Func<AppQuery, AppQuery> prefs_player_11 = a => a.Class("UILabel").Text("11");
        public static Func<AppQuery, AppQuery> prefs_player_13 = a => a.Class("UILabel").Text("13");
        public static Func<AppQuery, AppQuery> prefs_player_14 = a => a.Class("UILabel").Text("14");
        public static Func<AppQuery, AppQuery> prefs_player_20 = a => a.Class("UILabel").Text("20");
        public static Func<AppQuery, AppQuery> prefs_player_23 = a => a.Class("UILabel").Text("23");
        public static Func<AppQuery, AppQuery> prefs_player_50 = a => a.Class("UILabel").Text("50");


        //public static Func<AppQuery, AppQuery> ok_but = a => a.Id("button1").Text("OK"); /* No existe en IOS */
        public static Func<AppQuery, AppQuery> prefs_football_tus_preferidos = a => a.Text("Jugadores Preferidos").Index(0);
        public static Func<AppQuery, AppQuery> prefs_basket_tus_preferidos = a => a.Text("Jugadores Preferidos").Index(1);
        //public static Func<AppQuery, AppQuery> jugadores_actualizados_msg = a => a.Id("message").Text("Jugadores favoritos actualizados"); /* No existe en IOS */


        // MIS ME GUSTA
        public static Func<AppQuery, AppQuery> profile_favourites_matches       =       a => a.Text("PARTIDOS"); /*repetido - profile_favourites_Partidos_text*/
        public static Func<AppQuery, AppQuery> profile_favourites_noticias_text = a => a.Text("NOTICIAS");
        public static Func<AppQuery, AppQuery> profile_favourites_videos_text = a => a.Text("VÍDEOS");
        public static Func<AppQuery, AppQuery> profile_favourites_Partidos_text = a => a.Text("PARTIDOS");
        public static Func<AppQuery, AppQuery> profile_favourites_Subscripciones_text = a => a.Text("SUBSCRIPCIONES");
        public static Func<AppQuery, AppQuery> profile_favourites_noticias_page = a => a.Id("rv_news");
        
                // Mis Me Gusta - Partidos
        public static Func<AppQuery, AppQuery> profile_fav_matches_content 	= 	a => a.Class("UITableViewWrapperView");

        /// /////////
        /// 
        /****Se bloquea al hacer tree***/
        /*         
                        //moreinfo

                        public static Func<AppQuery, AppQuery> more_info_view = a => a.Class("ScrollView");
                        public static Func<AppQuery, AppQuery> moreinfo_name = a => a.Id("moreinfo_name");
                        public static Func<AppQuery, AppQuery> moreinfo_surname = a => a.Id("moreinfo_surname");        
                        public static Func<AppQuery, AppQuery> moreinfo_secondname = a => a.Id("moreinfo_secondname");
                        public static Func<AppQuery, AppQuery> moreinfo_doc_type_spinner = a => a.Id("moreinfo_doc_type_spinner");
                        public static Func<AppQuery, AppQuery> moreinfo_doc_type_Nif = a => a.Id("text1").Text("Nif");
                        public static Func<AppQuery, AppQuery> moreinfo_doc_type_Passport = a => a.Id("text1").Text("Pasaporte");        
                        public static Func<AppQuery, AppQuery> moreinfo_doc_number = a => a.Id("moreinfo_doc_number");
                        public static Func<AppQuery, AppQuery> moreinfo_birthday = a => a.Id("moreinfo_birthday");
                        public static Func<AppQuery, AppQuery> pager_calendar_day_1 = a => a.Class("View").Text("1");
                        public static Func<AppQuery, AppQuery> moreinfo_birthday_Ok_but = a => a.Id("button1");        
                        public static Func<AppQuery, AppQuery> moreinfo_penya = a => a.Id("moreinfo_penya");
                        public static Func<AppQuery, AppQuery> moreinfo_gender_spinner = a => a.Id("moreinfo_gender_spinner");
                        public static Func<AppQuery, AppQuery> moreinfo_gender_Male = a => a.Id("text1").Text("Hombre");
                        public static Func<AppQuery, AppQuery> moreinfo_gender_Female = a => a.Id("text1").Text("Mujer");
                        public static Func<AppQuery, AppQuery> moreinfo_country = a => a.Id("moreinfo_country");
                        public static Func<AppQuery, AppQuery> moreinfo_country_view = a => a.Id("select_dialog_listview");
                        public static Func<AppQuery, AppQuery> moreinfo_country_random = a => a.Id("text1");
                        public static Func<AppQuery, AppQuery> moreinfo_country_spain = a => a.Id("text1").Text("España");
                        public static Func<AppQuery, AppQuery> moreinfo_language = a => a.Id("moreinfo_language");
                        public static Func<AppQuery, AppQuery> moreinfo_mobile_number = a => a.Id("moreinfo_mobile_number");
                        public static Func<AppQuery, AppQuery> moreinfo_home_number = a => a.Id("moreinfo_home_number");
                        public static Func<AppQuery, AppQuery> moreinfo_address = a => a.Id("moreinfo_address");
                        public static Func<AppQuery, AppQuery> moreinfo_zip = a => a.Id("moreinfo_zip");
                        public static Func<AppQuery, AppQuery> moreinfo_city = a => a.Id("moreinfo_city");
                        public static Func<AppQuery, AppQuery> moreinfo_state_spinner = a => a.Id("moreinfo_state_spinner");
                        public static Func<AppQuery, AppQuery> moreinfo_state_zamora = a => a.Id("text1").Text("ZAMORA");
                        public static Func<AppQuery, AppQuery> moreinfo_state_view = a => a.Class("ListView");
                        public static Func<AppQuery, AppQuery> moreinfo_persontitle_spinner = a => a.Id("moreinfo_persontitle_spinner");
                        public static Func<AppQuery, AppQuery> moreinfo_persontitle_Sr = a => a.Id("text1").Text("Sr");
                        public static Func<AppQuery, AppQuery> moreinfo_persontitle_Sra = a => a.Id("text1").Text("Sra");
                        public static Func<AppQuery, AppQuery> moreinfo_sport_spinner = a => a.Id("moreinfo_sport_spinner");
                        public static Func<AppQuery, AppQuery> moreinfo_sport_Futbol = a => a.Id("text1").Text("FÚTBOL");
                        public static Func<AppQuery, AppQuery> moreinfo_sport_Basket = a => a.Id("text1").Text("BALONCESTO");
                        public static Func<AppQuery, AppQuery> moreinfo_sport_Both = a => a.Id("text1").Text("Ambos");
                        public static Func<AppQuery, AppQuery> moreinfo_sendtostore = a => a.Id("moreinfo_sendtostore");
                        public static Func<AppQuery, AppQuery> moreinfo_nocommunicationstorm = a => a.Id("moreinfo_nocommunicationstorm");
                        public static Func<AppQuery, AppQuery> moreinfo_noinfotothirds = a => a.Id("moreinfo_noinfotothirds");
                        public static Func<AppQuery, AppQuery> moreinfo_generalOptions = a => a.Id("text1");   

                        public static Func<AppQuery, AppQuery> moreinfo_save = a => a.Id("moreinfo_save");
                        public static Func<AppQuery, AppQuery> datos_actualizados_msg = a => a.Id("message").Text("Datos de usuario actualizados");
                        public static Func<AppQuery, AppQuery> datos_actualizados_OK_but = a => a.Id("button1").Text("OK");

                        public static Func<AppQuery, AppQuery> codigo_postal_incrrecto_msg = a => a.Id("message").Text("El código postal no es correcto respecto a la provincia seleccionada.");

                        public static Func<AppQuery, AppQuery> personal_area_view = a => a.Class("ScrollView");

                        public static Func<AppQuery, AppQuery> moreinfo_member_but = a => a.Id("bt_partner");
        */
        /// ////////

        //Virtual Goods
        public static Func<AppQuery, AppQuery> virtual_goods_title = a => a.Text("BIENES VIRTUALES");
        public static Func<AppQuery, AppQuery> virtual_goods_sections_container = a => a.Class("UITableView");
        public static Func<AppQuery, AppQuery> virtual_goods_avatar_section = a => a.Text("Avatar VirtualGoods");
        public static Func<AppQuery, AppQuery> virtual_goods_astosch_section = a => a.Text("Astosch ES");
        public static Func<AppQuery, AppQuery> virtual_goods_image = a => a.Text("Astosch ES").Sibling("UICollectionView").Child(0).Child(0).Child(1).Child(0).Child(0);
        public static Func<AppQuery, AppQuery> virtual_goods_zapas_title = a => a.Text("Zapas ES");
        public static Func<AppQuery, AppQuery> virtual_goods_zapas_number = a => a.Text("Astosch ES").Sibling("UICollectionView").Child(1).Child(0).Child(1).Child(0).Child(2).Text("1");
        public static Func<AppQuery, AppQuery> virtual_goods_spinner = a => a.Class("UIButton").Index(0);
        public static Func<AppQuery, AppQuery> virtual_goods_spinner_container = a => a.Class("UITableViewWrapperView").Index(1);
        public static Func<AppQuery, AppQuery> virtual_goods_spinner_astosch = a => a.Class("UITableViewWrapperView").Index(1).Class("RMPopoverInfoSimpleTableViewCell").Class("UITableViewCellContentView").Child("UILabel").Text("Astosch ES");

        //Details virtual goods
        public static Func<AppQuery, AppQuery> virtual_goods_details_title = a => a.Text("DETALLE DEL BIEN VIRTUAL");
        public static Func<AppQuery, AppQuery> virtual_goods_details_image = a => a.Text("Zapas ES").Sibling("UIImageView");
        public static Func<AppQuery, AppQuery> virtual_goods_details_name = a => a.Text("Zapas ES");
        public static Func<AppQuery, AppQuery> virtual_goods_details_number = a => a.Text("Tiene una unidad de este bien virtual");
        public static Func<AppQuery, AppQuery> virtual_goods_details_consiguelo_but = a => a.Text("Zapas ES").Sibling("UIButton");

        //Virtual Store
        public static Func<AppQuery, AppQuery> virtual_store_but = a => a.Class("UIButton").Index(1);
        public static Func<AppQuery, AppQuery> content_virtual_goods_title = a => a.Text("Content");

        //Badges placeholder
        public static Func<AppQuery, AppQuery> badges_placeholder_title = a => a.Text("MEDALLAS");
        public static Func<AppQuery, AppQuery> badges_placeholder_view_all_but = a => a.Text("MEDALLAS").Sibling("UILabel").Text("VER TODO");
        public static Func<AppQuery, AppQuery> badges_placeholder_random_badge = a => a.Text("MEDALLAS").Parent(0).Child(5).Child(0).Child(0);


        //Badges page
        public static Func<AppQuery, AppQuery> badge_reto100_title = a => a.Text("Participar en El Reto 1 vez");
        public static Func<AppQuery, AppQuery> badge_reto50_title = a => a.Text("Participar en El Reto 1 vez");
		public static Func<AppQuery, AppQuery> badge_invite_title = a => a.Text("Check-in en el Estadio Santiago Bernabéu").Index(0);        
        public static Func<AppQuery, AppQuery> badge_scroll_view =a => a.Class("UITableView");
        public static Func<AppQuery, AppQuery> badges_spinner = a => a.Class("UIButtonLabel");
        public static Func<AppQuery, AppQuery> badges_spinner_view = a => a.Class("UITableViewWrapperView").Index(1);
        public static Func<AppQuery, AppQuery> badges_spinner_todos = a => a.Text("TODOS");
        public static Func<AppQuery, AppQuery> badges_spinner_challenges = a => a.Class("UITableViewWrapperView").Index(1).Class("RMPopoverInfoSimpleTableViewCell").Class("UITableViewCellContentView").Child("UILabel").Text("CHALLENGES");
        public static Func<AppQuery, AppQuery> badges_section_challenges = a => a.Text("CHALLENGES");
        public static Func<AppQuery, AppQuery> badges_spinner_checkin = a => a.Class("UITableViewWrapperView").Index(1).Class("RMPopoverInfoSimpleTableViewCell").Class("UITableViewCellContentView").Child("UILabel").Text("CHECKIN");
        public static Func<AppQuery, AppQuery> badges_section_checkin = a => a.Text("CHECKIN");
        public static Func<AppQuery, AppQuery> badges_spinner_fan = a => a.Class("UITableViewWrapperView").Index(1).Class("RMPopoverInfoSimpleTableViewCell").Class("UITableViewCellContentView").Child("UILabel").Text("FAN");
        public static Func<AppQuery, AppQuery> badges_section_fan = a => a.Text("FAN");
        public static Func<AppQuery, AppQuery> badges_spinner_social = a => a.Class("UITableViewWrapperView").Index(1).Class("RMPopoverInfoSimpleTableViewCell").Class("UITableViewCellContentView").Child("UILabel").Text("SOCIAL");
        public static Func<AppQuery, AppQuery> badges_section_social = a => a.Text("SOCIAL");
        public static Func<AppQuery, AppQuery> badges_count = a => a.Text("CHALLENGES").Sibling("UILabel");
        public static Func<AppQuery, AppQuery> badges_image = a => a.Class("UILabel").Index(1).Parent(1).Child(1);
        public static Func<AppQuery, AppQuery> badges_coins = a => a.Class("UILabel").Index(1).Sibling("UILabel");
        public static Func<AppQuery, AppQuery> badges_points = a => a.Class("UILabel").Index(1);

                //Badges popUp
        public static Func<AppQuery, AppQuery> badges_popup_title = a => a.Text("Has ganado esta medalla");
        public static Func<AppQuery, AppQuery> badges_popup_img = a => a.Id("radialEffect").Sibling("UIImageView").Index(0);
        public static Func<AppQuery, AppQuery> badges_popup_reto50_title = a => a.Text("El Reto 1x");
        public static Func<AppQuery, AppQuery> badges_popup_coins = a => a.Id("coinIcon.png").Sibling("UILabel").Index(0);
        public static Func<AppQuery, AppQuery> badges_popup_points = a => a.Id("coinIcon.png").Sibling("UILabel").Index(1);
        public static Func<AppQuery, AppQuery> badges_popup_ok_but = a => a.Text("OK");



        //Coins page
        public static Func<AppQuery, AppQuery> coins_page_view = a => a.Class("UICollectionView");        
        public static Func<AppQuery, AppQuery> coins_page_title = a => a.Text("MONEDAS");
        public static Func<AppQuery, AppQuery> coins_page_icon = a => a.Id("coinsAddIcon.png").Index(0);
        public static Func<AppQuery, AppQuery> coins_title = a => a.Text("Ganaste 1 Monedas").Index(0);
        public static Func<AppQuery, AppQuery> coins_description = a => a.Text("ABRIR LA APLICACIÓN DOS DÍAS");

        public static Func<AppQuery, AppQuery> coins_time = a => a.Id("coinsAddIcon.png").Index(0).Sibling("UILabel").Index(2);
        public static Func<AppQuery, AppQuery> coins_subtotal = a => a.Text("SUBTOTAL").Index(0);

        // Coins pop-up
        //public static Func<AppQuery, AppQuery> coins_popup_title = a => a.Id("tv_label_title").Text("¡Felicidades!"); /* No esta enIOS */
        public static Func<AppQuery, AppQuery> coins_popup_subtitle = a => a.Id("radialEffect").Sibling("UILabel").Text("Ganaste 1 Monedas");
        public static Func<AppQuery, AppQuery> coins_popup_image = a => a.Id("radialEffect").Sibling("UIImageView").Id("coinsAddIcon.png");
        public static Func<AppQuery, AppQuery> coins_popup_description = a => a.Id("radialEffect").Sibling("UILabel").Text("Abrir la aplicación dos días");
        public static Func<AppQuery, AppQuery> coins_popup_ok_but = a => a.Text("Cerrar");        

//



        //Groups
        public static Func<AppQuery, AppQuery> grupos_title = a => a.Text("GRUPOS");
        public static Func<AppQuery, AppQuery> groups_soon_text = a => a.Text("PRONTO");
                     
        //Play with us
        public static Func<AppQuery, AppQuery> shout_title = a => a.Text("Shout");
        //public static Func<AppQuery, AppQuery> shout_spinner = a => a.Id("shout_spinner");  /* No esta enIOS */


        //Status placeholder
        public static Func<AppQuery, AppQuery> status_title = a => a.Text("ESTADO");
        public static Func<AppQuery, AppQuery> experiencia_but = a => a.Marked("Experience");
        public static Func<AppQuery, AppQuery> monedas_but = a => a.Marked("Monedas");
        public static Func<AppQuery, AppQuery> my_channel_but = a => a.Marked("Mi Canal");
        public static Func<AppQuery, AppQuery> virtual_goods_but = a => a.Marked("Bienes Virtuales");
        public static Func<AppQuery, AppQuery> ranking_but = a => a.Marked("MEJOR RANKING");
        public static Func<AppQuery, AppQuery> checkin_but = a => a.Marked("Checkin");
        public static Func<AppQuery, AppQuery> badges_but = a => a.Marked("Medallas");
        public static Func<AppQuery, AppQuery> groups_but = a => a.Marked("GROUPS");
        public static Func<AppQuery, AppQuery> retos_but = a => a.Marked("RETOS");
        //public static Func<AppQuery, AppQuery> friends_but = a => a.Id("title").Text("Amigos"); /* No esta enIOS */
        public static Func<AppQuery, AppQuery> me_gusta_but = a => a.Marked("Mis me gusta");
        public static Func<AppQuery, AppQuery> Favorites_but = a => a.Marked("Mis me gusta");
        //public static Func<AppQuery, AppQuery> share_but = a=> a.Text("ESTADO").Sibling("UIButton").Child("UIImageView").Id("Share_Icon");
		public static Func<AppQuery, AppQuery> share_but = a => a.Id("Share_Icon");

        
        //Share Status popup
        public static Func<AppQuery, AppQuery> share_popup_title = a => a.Text("Compartir Contenido");
        public static Func<AppQuery, AppQuery> share_fb_but = a => a.Id("facebook_icon");
        public static Func<AppQuery, AppQuery> share_twitter_but = a => a.Id("twitter_icon");
        public static Func<AppQuery, AppQuery> share_whatsapp_but = a => a.Id("Whatsapp_Icon");
        public static Func<AppQuery, AppQuery> share_google_but = a => a.Id("GooglePlus_Icon");
        public static Func<AppQuery, AppQuery> share_mail_but = a => a.Id("Mail_Icon");
        public static Func<AppQuery, AppQuery> share_more_but = a => a.Id("option_Icon");
        public static Func<AppQuery, AppQuery> share_ok_but = a => a.Text("Cancelar");


        //Experience page
        public static Func<AppQuery, AppQuery> experience_page_title = a => a.Text("EXPERIENCIA");
        public static Func<AppQuery, AppQuery> experience_subtotal = a => a.Id("xPIcon").Index(0).Sibling("UILabel");
        public static Func<AppQuery, AppQuery> experience_coin = a =>a.Id("xPIcon").Index(0);
        public static Func<AppQuery, AppQuery> experience_time = a =>a.Class("RMExperienceCollectionViewCell").Index(0).Child().Child().Child("UILabel").Index(0);
        public static Func<AppQuery, AppQuery> experience_value = a =>a.Class("RMExperienceCollectionViewCell").Index(0).Child().Child().Child("UILabel").Index(1);
  
            //Mis me gusta
		public static Func<AppQuery, AppQuery> my_like_page_GoBack = (a => a.Text("MIS ME GUSTA").Parent(1).Child(3));
        public static Func<AppQuery, AppQuery> my_like_page_title = a => a.Text("MIS ME GUSTA");
        public static Func<AppQuery, AppQuery> my_like_noticias_tab = a => a.Text("NOTICIAS");
        public static Func<AppQuery, AppQuery> my_like_noticias_page = a => a.Class("RMFavoriteNewsTableViewCell").Index(0).Parent(0);
        public static Func<AppQuery, AppQuery> my_like_videos_tab = a => a.Text("VÍDEOS");
        public static Func<AppQuery, AppQuery> my_like_videos_page = a => a.Class("RMFavoriteVideosTableViewCell").Index(0).Parent(0);        
        public static Func<AppQuery, AppQuery> my_like_match_tab = a => a.Text("PARTIDOS");
        public static Func<AppQuery, AppQuery> my_like_match_page = a => a.Class("RMFavoriteMatchesTableViewCell").Index(0).Parent(0);
        public static Func<AppQuery, AppQuery> my_like_subscripciones_tab = a => a.Text("SUBSCRIPCIONES");
        public static Func<AppQuery, AppQuery> my_like_subs_page = a => a.Class("RMFavoriteSubscriptionCollectionViewCell").Index(0).Parent(0);
      
        public static Func<AppQuery, AppQuery> my_like_news_image = a => a.Id("icnLikeOn").Index(0).Parent(0).Sibling("UIImageView");
        public static Func<AppQuery, AppQuery> my_like_news_title = a => a.Id("icnLikeOn").Index(0).Parent(0).Sibling("UILabel").Index(0);
        public static Func<AppQuery, AppQuery> my_like_news_time = a => a.Id("icnLikeOn").Index(0).Parent(0).Sibling("UILabel").Index(1);
        public static Func<AppQuery, AppQuery> my_like_news_like = a => a.Id("icnLikeOn");

        public static Func<AppQuery, AppQuery> my_like_videos_image = a=> a.Id("icnLikeOn").Index(0).Parent(0).Sibling("UIImageView");
        public static Func<AppQuery, AppQuery> my_like_videos_play = a=> a.Id("icnLikeOn").Index(0).Parent(0).Sibling("UIButton");
        public static Func<AppQuery, AppQuery> my_like_videos_title = a=>a.Id("icnLikeOn").Index(0).Parent(0).Sibling("UILabel").Index(0);
        public static Func<AppQuery, AppQuery> my_like_videos_time = a=>a.Id("icnLikeOn").Index(0).Parent(0).Sibling("UILabel").Index(1);
        public static Func<AppQuery, AppQuery> my_like_videos_like = a => a.Marked("icnLikeOn");

        public static Func<AppQuery, AppQuery> my_like_subs_image = a=> a.Id("icnLikeOn").Index(0).Parent(0).Sibling("UIImageView").Index(0);
        public static Func<AppQuery, AppQuery> my_like_subs_videos = a => a.Id("icnLikeOn").Index(0).Parent(0).Sibling("UILabel").Index(0);
        public static Func<AppQuery, AppQuery> my_like_subs_title = a => a.Id("icnLikeOn").Index(0).Parent(0).Sibling("UILabel").Index(1);
        public static Func<AppQuery, AppQuery> my_like_subs_time = a => a.Id("icnLikeOn").Index(0).Parent(0).Sibling("UILabel").Index(2);
        public static Func<AppQuery, AppQuery> my_like_subs_like = a => a.Marked("icnLikeOn");

        public static Func<AppQuery, AppQuery> my_like_match_info = a => a.Id("icnLikeOn").Index(0).Parent(0).Sibling("UIView").Index(1).Child("UILabel").Index(0);
        public static Func<AppQuery, AppQuery> my_like_match_home_icon = a=> a.Id("icnLikeOn").Index(0).Parent(0).Sibling("UIView").Index(1).Child("UIImageView").Index(0);
        public static Func<AppQuery, AppQuery> my_like_match_away_icon = a=> a.Id("icnLikeOn").Index(0).Parent(0).Sibling("UIView").Index(1).Child("UIImageView").Index(1);
        public static Func<AppQuery, AppQuery> my_like_match_home_score = a => a.Id("icnLikeOn").Index(0).Parent(0).Sibling("UIView").Index(1).Child().Index(2);
        public static Func<AppQuery, AppQuery> my_like_match_away_score = a => a.Id("icnLikeOn").Index(0).Parent(0).Sibling("UIView").Index(1).Child().Index(4);
        public static Func<AppQuery, AppQuery> my_like_match_home_name = a=>a.Id("icnLikeOn").Index(0).Parent(0).Sibling("UIView").Index(1).Child("UILabel").Index(1);
        public static Func<AppQuery, AppQuery> my_like_match_away_name = a=>a.Id("icnLikeOn").Index(0).Parent(0).Sibling("UIView").Index(1).Child("UILabel").Index(2);
		public static Func<AppQuery, AppQuery> my_like_match_button = a => a.Marked("icnLikeOn").Index(0);
        public static Func<AppQuery, AppQuery> my_like_match_time = a => a.Id("icnLikeOn").Index(0).Parent(0).Sibling("UILabel");

        //Friends placeholer
        public static Func<AppQuery, AppQuery> friends_title_en = a => a.Text("Friends");
        public static Func<AppQuery, AppQuery> friends_title = a => a.Text("Amigos");        
        public static Func<AppQuery, AppQuery> friends_view_all_but = a => a.Text("Amigos").Sibling("UILabel").Text("VER TODO");
        public static Func<AppQuery, AppQuery> friends_first_friend_but = a => a.Text("Amigos").Sibling("UICollectionView").Child("RMGamificationFriendsCollectionViewCell").Index(0);
        public static Func<AppQuery, AppQuery> friends_friend_page = a=> a.Class("UITableViewWrapperView").Child(3);
        public static Func<AppQuery, AppQuery> friends_no_friend_msg = a => a.Text(Strings.FRIENDS_NO_MSG);

                //My chanel
        public static Func<AppQuery, AppQuery> my_channel_page_title = a => a.Text("MI CANAL");
        public static Func<AppQuery, AppQuery> my_channel_packs_tab = a => a.Text("PACKS");
        public static Func<AppQuery, AppQuery> my_channel_playlist_tab = a => a.Text("MIS LISTAS DE REPRODUCCIÓN");
		public static Func<AppQuery, AppQuery> playlist_new_but = a => a.Id("viewControllersScrollView").Child(0).Child(0).Child(1);
        public static Func<AppQuery, AppQuery> playlist_view = a => a.Id("viewControllersScrollView");
        public static Func<AppQuery, AppQuery> playlist_more_options_but = a => a.Id("viewControllersScrollView").Class("UIView").Child("UIButton").Index(2);
        public static Func<AppQuery, AppQuery> playlist_title_random = a=>a.Class("RMPlayListTableViewCell").Child().Index(0).Child().Child("UIButton").Index(0);

        public static Func<AppQuery, AppQuery> my_channel_page_number = a => a.Text("2 Packs");
        public static Func<AppQuery, AppQuery> my_channel_store_but = a => a.Text("IR A LA TIENDA");
        public static Func<AppQuery, AppQuery> my_channel_spinner = a => a.Class("UIButton").Index(3);
		public static Func<AppQuery, AppQuery> MyChannel_page_GoBack = (a => a.Text("MI CANAL").Parent(1).Child(3));


        //new list pop-up
        public static Func<AppQuery, AppQuery> playlist_new_popup = a=>a.Text("Nueva lista de reproducción").Index(0).Parent(0);
        public static Func<AppQuery, AppQuery> playlist_new_popup_title = a => a.Text("Nueva lista de reproducción");
        public static Func<AppQuery, AppQuery> playlist_new_popup_combo_title = a => a.Text("Título");
        public static Func<AppQuery, AppQuery> playlist_new_popup_combo = a => a.Class("UITextField");
        public static Func<AppQuery, AppQuery> playlist_new_popup_advice = a => a.Text("Para añadir videos a esta lista pulse en Guardar e ir al buscador");
        public static Func<AppQuery, AppQuery> playlist_new_popup_save_finder_but = a => a.Text("GUARDAR E IR AL BUSCADOR");
        public static Func<AppQuery, AppQuery> playlist_new_popup_advice2 = a => a.Text("También puede guardarla y añadirlos más adelante");
        public static Func<AppQuery, AppQuery> playlist_new_popup_save_but = a => a.Text("AÑADIR");
        public static Func<AppQuery, AppQuery> playlist_new_popup_cancel_but = a => a.Text("CANCELAR");
        
            //Repeated playlists pop-up
        public static Func<AppQuery, AppQuery> playlist_repited_popup_msg = a => a.Text("Ya existe una playlist con ese nombre");
        public static Func<AppQuery, AppQuery> playlist_repited_popup_save_but = a => a.Text("OK");

            //Edit playlists pop-up
        public static Func<AppQuery, AppQuery> playlist_edit_popup_title = a => a.Text("Editar lista de reproducción");
        public static Func<AppQuery, AppQuery> playlist_edit_popup_subtitle = a => a.Text("Título");
        public static Func<AppQuery, AppQuery> playlist_edit_popup_combo = a => a.Class("UITextField");
        public static Func<AppQuery, AppQuery> playlist_edit_popup_delete_but = a => a.Class("UIButton").Index(0);
        public static Func<AppQuery, AppQuery> playlist_edit_popup_save_but = a => a.Text("Guardar");
        public static Func<AppQuery, AppQuery> playlist_edit_popup_cancel_but = a => a.Text("Cancelar");

            //Delete playlists pop-up
        public static Func<AppQuery, AppQuery> playlist_delete_popup_msg = a => a.Text("¿Deseas eliminar esta lista de reproducción?");
        public static Func<AppQuery, AppQuery> playlist_delete_popup_save_but = a => a.Text("Borrar");
        public static Func<AppQuery, AppQuery> playlist_delete_popup_cancel_but = a => a.Text("Cancelar");

            //Select playlists pop-up
        public static Func<AppQuery, AppQuery> playlist_select_popup_title = a => a.Text("¿Qué lista de reproducción quieres usar para añadir el vídeo?");
        public static Func<AppQuery, AppQuery> playlist_select_popup_subtitle = a => a.Text("Selecciona la lista y pulsa añadir.");
        public static Func<AppQuery, AppQuery> playlist_select_popup_imput = a => a.Class("UITextField");
        public static Func<AppQuery, AppQuery> playlist_select_popup_save_but = a => a.Text("AÑADIR");
        public static Func<AppQuery, AppQuery> playlist_select_popup_cancel_but = a => a.Text("CANCELAR");
            //public static Func<AppQuery, AppQuery> playlist_select_popup_list_name = a => a.Class("tv_playlist_title"); /*  No se usa en el proyecoto */
        public static Func<AppQuery, AppQuery> playlist_select_popup_list_view = a => a.Class("UITableViewWrapperView");

            // Purchase video playlist pop-up
        public static Func<AppQuery, AppQuery> playlist_purchase_popup_title = a => a.Text("Vídeo no comprado");
        public static Func<AppQuery, AppQuery> playlist_purchase_popup_subtitle = a => a.Text("Este vídeo no se puede añadir, debe comprarlo previamente");
        public static Func<AppQuery, AppQuery> playlist_purchase_popup_save_but = a => a.Text("OK");


            //More options subscription in playlist
        public static Func<AppQuery, AppQuery> playlist_subscription_more_popup_play = a => a.Class("UIButton").Index(0);
        public static Func<AppQuery, AppQuery> playlist_subscription_more_popup_delete = a => a.Class("UIButton").Index(1);
        public static Func<AppQuery, AppQuery> playlist_subscription_more_popup_ok = a => a.Text("Cancelar");

            //Delete Video popup
        public static Func<AppQuery, AppQuery> playlist_delete_video_popup_msg = a => a.Text("¿Desea eliminar este vídeo de la lista de reproducción?");
        public static Func<AppQuery, AppQuery> playlist_delete_video_popup_save_but = a => a.Text("Borrar");
        public static Func<AppQuery, AppQuery> playlist_delete_video_popup_cancel_but = a => a.Text("Cancelar");


            //Playlist
        public static Func<AppQuery, AppQuery> playlist_video_subscription_I = a => a.Text(Strings.PLAYLIST_SUBSCRIPTION_QA_TEST1_I);
        public static Func<AppQuery, AppQuery> playlist_video_subscription_II = a => a.Text(Strings.PLAYLIST_SUBSCRIPTION_QA_TEST1_II);
        public static Func<AppQuery, AppQuery> playlist_video_subscription_more_but = a => a.Id("option_Icon");
        public static Func<AppQuery, AppQuery> playlist_video_order_grid_but = a => a.Text("Editar lista de reproducción").Sibling("UIButton").Index(1);
        public static Func<AppQuery, AppQuery> playlist_video_order_list_but = a => a.Text("Editar lista de reproducción").Sibling("UIButton").Index(2);
        public static Func<AppQuery, AppQuery> playlist_video_play_all_but = a => a.Text("Editar lista de reproducción").Parent(0).Sibling().Index(2);
        public static Func<AppQuery, AppQuery> playlist_video_list_play_but = a => a.Id("ic_playlist_play");
        public static Func<AppQuery, AppQuery> playlist_video_grid_image = a => a.Id("option_Icon").Index(0).Parent(0).Parent(0).Sibling("UIImageView");
        //public static Func<AppQuery, AppQuery> playlist_video_player_all = a => a.Id("videoView"); /* Reproducctior de TODOS los videos */
        //public static Func<AppQuery, AppQuery> playlist_video_player_one = a => a.Id("video_player"); * Reproducctior de un video */
        public static Func<AppQuery, AppQuery> playlist_elements_number = a=>a.Text("Editar lista de reproducción").Sibling("UILabel");
        public static Func<AppQuery, AppQuery> playlist_details_edit = a=>a.Text("Editar lista de reproducción");
      

            //Finder   ------Mover a finderVars --------

        public static Func<AppQuery, AppQuery> search_input_bar = a => a.Class("UISearchBarTextFieldLabel");
        public static Func<AppQuery, AppQuery> finder_add_video_but = a => a.Class("RMFinderVideoCollectionViewCell").Child("UIView").Child("UIView").Child("UIButton").Index(1);
        public static Func<AppQuery, AppQuery> finder_Videos_destacados = a => a.Text("Vídeos destacados");
        public static Func<AppQuery, AppQuery> video_title_test1 = a => a.Text(Strings.PLAYLIST_SUBSCRIPTION_QA_TEST1_I);
        public static Func<AppQuery, AppQuery> video_title_gol_lucas_vazquez = a => a.Text(Strings.PLAYLIST_NON_SUBSCRIPTION_GOL_LUCAS_VAZQUEZ);
        public static Func<AppQuery, AppQuery> finder_add_video_details_but = a => a.Text("+ Añadir vídeo a la lista de reproducción");
        public static Func<AppQuery, AppQuery> video_title_details_gol_lucas_vazquez = a => a.Text(Strings.PLAYLIST_NON_SUBSCRIPTION_GOL_LUCAS_VAZQUEZ);
        public static Func<AppQuery, AppQuery> finder_Videos_details_title = a => a.Text("VÍDEOS");

		// ///////////////////////////////// Ipad

		//Status placeholder

		public static Func<AppQuery, AppQuery> monedas_but_Tablet = a => a.Marked("MONEDAS");
		public static Func<AppQuery, AppQuery> ranking_but_Tablet = a => a.Marked("MEJOR");
		public static Func<AppQuery, AppQuery> checkin_but_Tablet = a => a.Marked("CHECK-INS(ES)");
		public static Func<AppQuery, AppQuery> groups_but_Tablet = a => a.Marked("GRUPOS");
                           
    }
}

