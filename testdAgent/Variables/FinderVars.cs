using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;



namespace RealMadrid_UITest {


	public class FinderVars {

        /* * * * * * * * * *  *  *  *  *  Main Page  *  *  *  *  * * * * * * * * * */

        public static Func<AppQuery, AppQuery> main_title                           =       a => a.Class("UILabel").Marked("BUSCADOR");
        public static Func<AppQuery, AppQuery> content                              =       a => a.Class("RMRadialGradientView").Index(0);
        public static Func<AppQuery, AppQuery> filters_arrow                        =       a => a.Id("ic_arrow_right_white");
        public static Func<AppQuery, AppQuery> filters_bars                         =       a => a.Class("RMFinderFilterCollectionViewCell").Parent().Index(0);
        public static Func<AppQuery, AppQuery> filters_submenu                      =       a => a.Class("RMFinderFilterOptionCollectionViewCell").Parent().Index(0);
        public static Func<AppQuery, AppQuery> filters_submenu_options              =       a => a.Class("RMFinderFilterOptionCollectionViewCell");
		public static Func<AppQuery, AppQuery> filters_banner 						= 		a => a.Class("UICollectionView").Index(0);  
		public static Func<AppQuery, AppQuery> filters_results                      =       a => a.Class("RMRadialGradientView");
		public static Func<AppQuery, AppQuery> section_title                        =       a => a.Class("UILabel").Marked("Partidos destacados");
		//public static Func<AppQuery, AppQuery> section_title 						= 	(a => a.Class("RMFinderResultsCollectionViewCell").Child("UIView").Child("UILabel").Index(0));
		public static Func<AppQuery, AppQuery> Video_Section_Highlighted 			= 		a => a.Text("Destacados");
		public static Func<AppQuery, AppQuery> Video_Section_Recomended 			= 		a => a.Text("Recomendados");
		public static Func<AppQuery, AppQuery> Video_Section_viewed 				= 		a => a.Text("Más visualizados");
		public static Func<AppQuery, AppQuery> Video_Section_Searched 				= 		a => a.Text("Más buscados");
		public static Func<AppQuery, AppQuery> Video_Section_Valuable 				= 		a => a.Text("Más valorados");

		public static Func<AppQuery, AppQuery> section_content                      =       a => a.Class("RMFinderResultsCollectionViewCell");
		public static Func<AppQuery, AppQuery> section_video                        =       a => a.Class("RMFinderVideoCollectionViewCell").Index(0);
        public static Func<AppQuery, AppQuery> finder_tv_results                    =       a => a.Class("RMFinderHeaderCollectionReusableView").Child("UILabel");
        public static Func<AppQuery, AppQuery> finder_filter_matches_results        =       a => a.Class("UICollectionView").Index(1);
        public static Func<AppQuery, AppQuery> finder_filter_match_area             =       a => a.Class("UIButtonLabel").Marked("Área Partido");
        public static Func<AppQuery, AppQuery> finder_last_matches_view             =       a => a.Class("RMFinderMatchCollectionViewCell");
        public static Func<AppQuery, AppQuery> finder_highlighted_videos            =       a => a.Class("RMFinderResultsCollectionViewCell").Child().Child("UILabel").Marked("Vídeos destacados");
        public static Func<AppQuery, AppQuery> finder_highlighted_matches           =       a => a.Class("RMFinderResultsCollectionViewCell").Child().Child("UILabel").Marked("Partidos destacados");


        /* * * * * * * * * *  *  *  *  * Search bar *  *  *  *  * * * * * * * * * */

        public static Func<AppQuery, AppQuery> search_bar_layout                    =       a => a.Class("UISearchBarBackground");
        public static Func<AppQuery, AppQuery> search_input_bar                     =       a => a.Class("UISearchBarTextField");
        public static Func<AppQuery, AppQuery> search_input_icon                    =       a => a.Class("UISearchBarTextField").Child("UIImageView");
        public static Func<AppQuery, AppQuery> search_team_name                     =       a => a.Class("UITableViewCellContentView").Child("UILabel");


        /* * * * * * * * * *  *  *  *  Submenu Option   *  *  *  * * * * * * * * * */

        public static Func<AppQuery, AppQuery> finder_filter_single_container_0     =       a => a.Class("RMFinderFilterOptionCollectionViewCell").Index(0);
        public static Func<AppQuery, AppQuery> finder_filter_single_container_1     =       a => a.Class("RMFinderFilterOptionCollectionViewCell").Index(1);
        public static Func<AppQuery, AppQuery> option_content                       =       a => a.Class("RMFinderFilterOptionCollectionViewCell").Child("UIView").Child("UIView");
        public static Func<AppQuery, AppQuery> option_image                         =       a => a.Class("RMFinderFilterOptionCollectionViewCell").Child("UIView").Child("UIImageView");
        public static Func<AppQuery, AppQuery> option_title                         =       a => a.Class("RMFinderFilterOptionCollectionViewCell").Child("UIView").Child("UILabel");


        /* * * * * * * * * *  *  *  *  Match Section  *  *  *  *  * * * * * * * * * */

        public static Func<AppQuery, AppQuery> finder_match_date                    =       a => a.Class("RMFinderMatchCollectionViewCell").Index(0).Child().Child("UIView").Child("UILabel").Index(0);
        public static Func<AppQuery, AppQuery> finder_like_button                   =       a => a.Class("RMFinderMatchCollectionViewCell").Index(0).Child().Child("LikeButton");

            
        /* * * * * * * * * *  *  *  *  Section Video  *  *  *  *  * * * * * * * * * */

        public static Func<AppQuery, AppQuery> videos_title                         =       a => a.Class("UILabel").Marked("VÍDEOS");
        public static Func<AppQuery, AppQuery> video_image                          =       a => a.Class("RMFinderVideoCollectionViewCell").Child("UIView").Child("UIImageView");
        public static Func<AppQuery, AppQuery> video_title                          =       a => a.Class("RMFinderVideoCollectionViewCell").Child("UIView").Child("UIView").Child("UILabel").Index(0);
        public static Func<AppQuery, AppQuery> video_ratting_popup                  =       a => a.Class("RMStarRatingControl");
		public static Func<AppQuery, AppQuery> video_ratting 						=       a => a.Class("RMFinderVideoDetailCollectionViewCell").Child(0).Child(1).Child(2);       
        public static Func<AppQuery, AppQuery> video_add                            =       a => a.Class("RMFinderVideoCollectionViewCell").Child("UIView").Child("UIView").Child("UIButton").Index(1);
        public static Func<AppQuery, AppQuery> video_rating_popup                   =       a => a.Class("UITransitionView").Child("UIview").Child("UIView").Index(0);
       // public static Func<AppQuery, AppQuery> video_play_button                    =       a => a.Id("lockIcon.png").Index(0);
		public static Func<AppQuery, AppQuery> video_play_button					= 		a => a.Class("RMFinderVideoDetailCollectionViewCell").Child(0).Child(0).Child("UIButton");   
        public static Func<AppQuery, AppQuery> video_not_purchased_text             =       a => a.Class("UILabel").Marked("Debes comprar un pack que contenga el vídeo para poder reproducirlo");
        public static Func<AppQuery, AppQuery> video_ok_not_purchased               =       a => a.Class("UILabel").Marked("Guardar");
        public static Func<AppQuery, AppQuery> video_cancel_but                     =       a => a.Class("UIButton").Marked("Cancelar");
        public static Func<AppQuery, AppQuery> video_save_but                       =       a => a.Class("UIButton").Marked("Guardar");
        public static Func<AppQuery, AppQuery> video_subscription_pack              =       a => a.Class("RMTopPackCollectionViewCell").Child("UIView");
        public static Func<AppQuery, AppQuery> video_description                    =       a => a.Class("RMFinderVideoDetailCollectionViewCell").Child().Child("UIView").Index(1).Child("UILabel").Index(1);
        public static Func<AppQuery, AppQuery> video_detail_title                   =       a => a.Class("RMFinderVideoDetailCollectionViewCell").Child().Child("UIView").Index(1).Child("UILabel").Index(0);
        public static Func<AppQuery, AppQuery> video_detail_image                   =       a => a.Class("RMFinderVideoDetailCollectionViewCell").Child().Child("UIView").Index(0).Child("UIImageView");
        public static Func<AppQuery, AppQuery> video_detail_related                 =       a => a.Class("UILabel").Marked("Vídeos relacionados");
        public static Func<AppQuery, AppQuery> video_rating_popup_title             =       a => a.Class("UILabel").Marked("Valora este video");
        public static Func<AppQuery, AppQuery> video_alert_popup_title              =       a => a.Class("UILabel").Marked("No se ha podido reproducir el vídeo seleccionado");


        /* * * * * * * * * * *  *  *  *  Filters *  *  *  *  *  * * * * * * * * * * */

        public static Func<AppQuery, AppQuery> finder_filt_content_type             =       a => a.Class("UILabel").Marked("TIPO DE CONTENIDO");
        public static Func<AppQuery, AppQuery> finder_filt_content_competition      =       a => a.Class("UILabel").Marked("COMPETICIÓN");
        public static Func<AppQuery, AppQuery> finder_filt_content_seasson          =       a => a.Class("UILabel").Marked("TEMPORADA");
        public static Func<AppQuery, AppQuery> finder_filt_content_players          =       a => a.Class("UILabel").Marked("JUGADORES");
        public static Func<AppQuery, AppQuery> finder_filt_content_category         =       a => a.Class("UILabel").Marked("CATEGORÍA");
        public static Func<AppQuery, AppQuery> finder_filter_title_videos           =       a => a.Class("UILabel").Marked("Vídeos");
        public static Func<AppQuery, AppQuery> finder_filter_title_matches          =       a => a.Class("UILabel").Marked("Partidos");


        /* * * * * * * * * * *  *  *  *  Competitions  *  *  *  *  *  * * * * * * * */

        public static Func<AppQuery, AppQuery> finder_filter_title_sup_cop_esp      =       a => a.Class("UILabel").Marked("Supercopa de España");
        public static Func<AppQuery, AppQuery> finder_filter_title_sup_cop_eur      =       a => a.Class("UILabel").Marked("Supercopa de Europa");
        public static Func<AppQuery, AppQuery> finder_filter_title_the_league       =       a => a.Class("UILabel").Marked("La Liga");
        public static Func<AppQuery, AppQuery> finder_filter_title_cop_rey          =       a => a.Class("UILabel").Marked("Copa del Rey");
        public static Func<AppQuery, AppQuery> finder_filter_title_champions        =       a => a.Class("UILabel").Marked("LIGA DE CAMPEONES");


        /* * * * * * * * * * *  *  *  *  *  Seassons  *  *  *  *  *  * * * * * * * */

        public static Func<AppQuery, AppQuery> filter_seasson_1415                  =       a => a.Class("UILabel").Marked("T. 14/15");
        public static Func<AppQuery, AppQuery> filter_seasson_1516                  =       a => a.Class("UILabel").Marked("T. 15/16");
        public static Func<AppQuery, AppQuery> filter_seasson_1617                  =       a => a.Class("UILabel").Marked("T. 16/17");


        /* * * * * * * * * * *  *  *  *  *  Players  *  *  *  *  * * * * * * * * * */

        public static Func<AppQuery, AppQuery> filter_player_keylor                 =       a => a.Class("UILabel").Marked("Keylor Navas");
        public static Func<AppQuery, AppQuery> filter_player_raphael                =       a => a.Class("UILabel").Marked("Raphaël Varane");
        public static Func<AppQuery, AppQuery> filter_player_benzema                =       a => a.Class("UILabel").Marked("Karim Benzema");


        /* * * * * * * * * * *  *  *  *  *  Category  *  *  *  * * * * * * * * * * */

        public static Func<AppQuery, AppQuery> filter_category_regate               =       a => a.Class("UILabel").Marked("Regate");
        public static Func<AppQuery, AppQuery> filter_category_penalti              =       a => a.Class("UILabel").Marked("Penalti");
        public static Func<AppQuery, AppQuery> filter_category_gol                  =       a => a.Class("UILabel").Marked("Gol");


        /* * * * * * * *  *  *  *  *  *  Other Variables  *  *  *  *  *  * * * * * */

        public static Func<AppQuery, AppQuery> video_subscription_qa_test1_I        =       a => a.Class("UITableViewCellContentView").Child("UILabel");
        public static Func<AppQuery, AppQuery> filter_matches_example_date          =       a => a.Class("RMFinderMatchCollectionViewCell").Child().Child("UIView").Child("UILabel").Marked("15 abr. 2017 - Finalizado");
        public static Func<AppQuery, AppQuery> filter_videos_purchase_example       =       a => a.Class("RMFinderVideoCollectionViewCell").Child("UIView").Child("UIView").Child("UILabel").Marked("Video Publicidad Animales");
        public static Func<AppQuery, AppQuery> matches_section_most_rated           =       a => a.Class("UILabel").Marked("Más valorados");
        public static Func<AppQuery, AppQuery> matches_section_recommended          =       a => a.Class("UILabel").Marked("Recomendados");
        public static Func<AppQuery, AppQuery> section_video_1                      =       a => a.Class("RMFinderVideoCollectionViewCell").Index(1);
    }
}