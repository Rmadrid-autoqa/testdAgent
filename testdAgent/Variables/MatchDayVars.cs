using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest.Queries;

namespace RealMadrid_UITest.Variables
{
    class MatchDayVars
    {
        /********* HOME PAGE *********/
        
        public static Func<AppQuery, AppQuery> matchDay_home_clasification  = a => a.Marked("CLASIFICACIÓN");
        public static Func<AppQuery, AppQuery> matchDay_home_match          = a => a.Marked("PARTIDOS");
        public static Func<AppQuery, AppQuery> matchDay_home_playwithus_but = a => a.Text("JUEGA CON NOSOTROS");

        public static Func<AppQuery, AppQuery> matchDay_home_calendar     = (a => a.Class("RMCalendarMatchCollectionViewCell").Index(0));
        public static Func<AppQuery, AppQuery> matchDay_calendar_day      = a => a.Class("RMCalendarMatchCollectionViewCell").Child(0);
        public static Func<AppQuery, AppQuery> matchDay_calendar_next_but = (a => a.Class("UIColectionView").Sibling("UIButton").Index(1));

        /********* MATCH POPUP *********/

        public static Func<AppQuery, AppQuery> matchDay_popup_match   = (a => a.Text("Real Madrid").Parent(3));   
        public static Func<AppQuery, AppQuery> matchDay_matchArea_but = (a => a.Text("Real Madrid").Sibling().Index(6));
        public static Func<AppQuery, AppQuery> matchDay_OK_but        = a => a.Text("Cerrar");
        public static Func<AppQuery, AppQuery> matchDay_competition   = (a => a.Text("Real Madrid").Sibling().Index(0));
        public static Func<AppQuery, AppQuery> matchDay_week          = (a => a.Text("Real Madrid").Sibling().Index(1));
        public static Func<AppQuery, AppQuery> matchDay_date          = (a => a.Text("Real Madrid").Sibling().Index(1));
        public static Func<AppQuery, AppQuery> matchDay_hour          = (a => a.Text("Real Madrid").Sibling().Index(1));
        public static Func<AppQuery, AppQuery> matchDay_homeTeam_icon = (a => a.Text("Real Madrid").Sibling().Index(2));
        public static Func<AppQuery, AppQuery> matchDay_awayTeam_icon = (a => a.Text("Real Madrid").Sibling().Index(4));
        public static Func<AppQuery, AppQuery> matchDay_homeTeam_name = (a => a.Text("Real Madrid").Sibling().Index(5));
        public static Func<AppQuery, AppQuery> matchDay_awayTeam_name = (a => a.Text("Área Partido").Sibling().Index(7));
        


        /********* MATCH AREA (NAVBAR) *********/

        public static Func<AppQuery, AppQuery> matchDay_matchArea_video = a => a.Text("VÍDEOS");
        public static Func<AppQuery, AppQuery> matchDay_matchArea_feeds      = a => a.Text("DIRECTO");
        public static Func<AppQuery, AppQuery> matchDay_matchArea_stats      = a => a.Text("ESTADÍSTICAS");
        public static Func<AppQuery, AppQuery> matchDay_matchArea_play       = a => a.Text("JUGAR");
        public static Func<AppQuery, AppQuery> matchDay_matchArea_home_img = a => a.Id("virtualTicketVerticalHeader.jpg").Sibling("UIImageView").Index(0);
        public static Func<AppQuery, AppQuery> matchDay_matchArea_home_name = a => a.Id("virtualTicketVerticalHeader.jpg").Sibling("UILabel").Index(0);
        public static Func<AppQuery, AppQuery> matchDay_matchArea_away_img   =a =>  a.Id("virtualTicketVerticalHeader.jpg").Sibling("UIImageView").Index(1);
        public static Func<AppQuery, AppQuery> matchDay_matchArea_away_name  = a => a.Id("virtualTicketVerticalHeader.jpg").Sibling("UILabel").Index(3);
        public static Func<AppQuery, AppQuery> matchDay_matchArea_home_score = a => a.Id("virtualTicketVerticalHeader.jpg").Sibling("UILabel").Index(1);
        public static Func<AppQuery, AppQuery> matchDay_matchArea_away_score = a => a.Id("virtualTicketVerticalHeader.jpg").Sibling("UILabel").Index(2);
        public static Func<AppQuery, AppQuery> matchDay_matchArea_error      = a => a.Id("virtualTicketVerticalHeader.jpg").Sibling("UILabel").Index(4);
        public static Func<AppQuery, AppQuery> matchDay_matchArea_timeline_finish = a => a.Id("virtualTicketVerticalHeader.jpg").Sibling("UILabel").Index(4);

        public static Func<AppQuery, AppQuery> matchDay_horizontally_home_img       = a => a.Class("UITransitionView").Child("UIView").Child("UIView").Child("UIImageView").Index(0);
        public static Func<AppQuery, AppQuery> matchDay_horizontally_home_name = a => a.Class("UITransitionView").Child("UIView").Child("UIView").Child("UILabel").Index(0);
        public static Func<AppQuery, AppQuery> matchDay_horizontally_away_img       = a => a.Class("UITransitionView").Child("UIView").Child("UIView").Child("UIImageView").Index(1);
        public static Func<AppQuery, AppQuery> matchDay_horizontally_away_name      = a => a.Class("UITransitionView").Child("UIView").Child("UIView").Child("UILabel").Index(3);
        public static Func<AppQuery, AppQuery> matchDay_horizontally_home_score     = a => a.Class("UITransitionView").Child("UIView").Child("UIView").Child("UILabel").Index(1);
        public static Func<AppQuery, AppQuery> matchDay_horizontally_away_score     = a => a.Class("UITransitionView").Child("UIView").Child("UIView").Child("UILabel").Index(2);
        public static Func<AppQuery, AppQuery> matchDay_horizontally_feeds_timeline = a => a.Class("UITransitionView").Child("UIView").Child("UIView").Child("UILabel").Index(4);
        //public static Func<AppQuery, AppQuery> matchDay_horizontally_feeds_summary  = a => a.Id("feeds_summary");
        public static Func<AppQuery, AppQuery> matchDay_horizontally_timeline_finish = a => a.Text("Finalizado");

        // Basketball verticall 
        public static Func<AppQuery, AppQuery> matchDay_matchArea_home_img_basket = a => a.Id("vtVerticalHeaderBasket").Sibling("UIImageView").Index(0);
        public static Func<AppQuery, AppQuery> matchDay_matchArea_home_name_basket = a => a.Id("vtVerticalHeaderBasket").Sibling("UILabel").Index(0);
        public static Func<AppQuery, AppQuery> matchDay_matchArea_away_img_basket = a => a.Id("vtVerticalHeaderBasket").Sibling("UIImageView").Index(1);
        public static Func<AppQuery, AppQuery> matchDay_matchArea_away_name_basket = a => a.Id("vtVerticalHeaderBasket").Sibling("UILabel").Index(3);
        public static Func<AppQuery, AppQuery> matchDay_matchArea_home_score_basket = a => a.Id("vtVerticalHeaderBasket").Sibling("UILabel").Index(1);
        public static Func<AppQuery, AppQuery> matchDay_matchArea_away_score_basket = a => a.Id("vtVerticalHeaderBasket").Sibling("UILabel").Index(2);
        public static Func<AppQuery, AppQuery> matchDay_matchArea_error_basket = a => a.Id("vtVerticalHeaderBasket").Sibling("UILabel").Index(4);
        public static Func<AppQuery, AppQuery> matchDay_matchArea_timeline_finish_basket = a => a.Id("vtVerticalHeaderBasket").Sibling("UILabel").Index(4);

        // Stats tab

        public static Func<AppQuery, AppQuery> matchDay_stats_home_img      = (a => a.Id("viewControllersScrollView").Child("UIView").Child("UIView").Sibling(0));
        public static Func<AppQuery, AppQuery> matchDay_stats_home_name     = (a => a.Id("viewControllersScrollView").Child("UIView").Child("UIView").Sibling(1));
        public static Func<AppQuery, AppQuery> matchDay_stats_away_img      = (a => a.Id("viewControllersScrollView").Child("UIView").Child("UIView").Sibling(5));
        public static Func<AppQuery, AppQuery> matchDay_stats_away_name     = (a => a.Id("viewControllersScrollView").Child("UIView").Child("UIView").Sibling(6));
        public static Func<AppQuery, AppQuery> matchDay_stats_home_but      = (a => a.Id("viewControllersScrollView").Child("UIView").Child(1).Sibling("UIButton").Index(0));
        public static Func<AppQuery, AppQuery> matchDay_stats_away_but      = (a => a.Id("viewControllersScrollView").Child("UIView").Child(1).Sibling("UIButton").Index(1));
        public static Func<AppQuery, AppQuery> matchDay_stats_players_list  = (a => a.Class("RMPopoverInfoSimpleTableViewCell"));
        public static Func<AppQuery, AppQuery> matchDay_stats_home_player   = (a => a.Class("RMPopoverInfoSimpleTableViewCell").Index(2));
        public static Func<AppQuery, AppQuery> matchDay_stats_home_graphics = (a => a.Text("REAL MADRID").Index(0).Parent(0).Child("UILabel").Index(0));
        public static Func<AppQuery, AppQuery> matchDay_stats_home_player2  = (a => a.Class("RMPopoverInfoSimpleTableViewCell").Index(3));
        

        // Basketball stats
        public static Func<AppQuery, AppQuery> matchDay_stats_list              = a => a.Class("UITableView");
        public static Func<AppQuery, AppQuery> matchDay_stats_points            = a => a.Text("PUNTOS");
        public static Func<AppQuery, AppQuery> matchDay_stats_free_shots        = a => a.Text("TIROS LIBRES");
        public static Func<AppQuery, AppQuery> matchDay_stats_free_scored       = a => a.Text("TIROS LIBRES ANOTADOS");
        public static Func<AppQuery, AppQuery> matchDay_stats_two_points        = a => a.Text("TIROS DE DOS PUNTOS");
        public static Func<AppQuery, AppQuery> matchDay_stats_two_scored        = a => a.Text("TIROS DE DOS ANOTADOS");
        public static Func<AppQuery, AppQuery> matchDay_stats_three_points      = a => a.Text("TIROS DE TRES PUNTOS");
        public static Func<AppQuery, AppQuery> matchDay_stats_three_scored      = a => a.Text("TIROS DE TRES PUNTOS ANOTADOS");
        public static Func<AppQuery, AppQuery> matchDay_stats_offensive_rebound = a => a.Text("REBOTES OFENSIVOS");
        public static Func<AppQuery, AppQuery> matchDay_stats_defensive_rebound = a => a.Text("REBOTES DEFENSIVOS");
        public static Func<AppQuery, AppQuery> matchDay_stats_total_rebound     = a => a.Text("TOTAL REBOTES");
        public static Func<AppQuery, AppQuery> matchDay_stats_assists           = a => a.Text("ASISTENCIAS");
        public static Func<AppQuery, AppQuery> matchDay_stats_turnovers         = a => a.Text("PÉRDIDAS DE BALÓN");
        public static Func<AppQuery, AppQuery> matchDay_stats_steals            = a => a.Text("ROBOS");
        public static Func<AppQuery, AppQuery> matchDay_stats_bloks             = a => a.Text("BLOQUEOS");
        public static Func<AppQuery, AppQuery> matchDay_stats_received_fouls    = a => a.Text("FALTAS RECIBIDAS");
        public static Func<AppQuery, AppQuery> matchDay_stats_fouls             = a => a.Text("FALTAS");
        public static Func<AppQuery, AppQuery> matchDay_stats_minutes           = a => a.Text("MINUTOS JUGADOS");
        public static Func<AppQuery, AppQuery> matchDay_stats_evaluation        = a => a.Text("EVALUACIÓN");

        //Football stats
        public static Func<AppQuery, AppQuery> matchDay_stats_general           = a => a.Text("GENERALES");
        public static Func<AppQuery, AppQuery> matchDay_stats_possession        = a => a.Text("POSESIÓN");
        public static Func<AppQuery, AppQuery> matchDay_stats_shots             = a => a.Text("DISPAROS");
        public static Func<AppQuery, AppQuery> matchDay_stats_corners           = a => a.Text("SAQUES DE ESQUINA");
        public static Func<AppQuery, AppQuery> matchDay_stats_offsides          = a => a.Text("FUERAS DE JUEGO");
        public static Func<AppQuery, AppQuery> matchDay_stats_defense           = a => a.Text("DEFENSA");
        public static Func<AppQuery, AppQuery> matchDay_stats_interceptions     = a => a.Text("INTERCEPCIONES");
        public static Func<AppQuery, AppQuery> matchDay_stats_clearances        = a => a.Text("DESPEJES");
        public static Func<AppQuery, AppQuery> matchDay_stats_tackles           = a => a.Text("ENTRADAS");
        public static Func<AppQuery, AppQuery> matchDay_stats_duels             = a => a.Text("DUELOS");
        public static Func<AppQuery, AppQuery> matchDay_stats_recoveries        = a => a.Text("RECUPERACIONES");
        public static Func<AppQuery, AppQuery> matchDay_stats_passing           = a => a.Text("PASES");
        public static Func<AppQuery, AppQuery> matchDay_stats_total             = a => a.Text("PASES");
        public static Func<AppQuery, AppQuery> matchDay_stats_completion        = a => a.Text("PASES COMPLETADOS");
        public static Func<AppQuery, AppQuery> matchDay_stats_opposition        = a => a.Text("PASES CAMPO CONTRARIO");
        public static Func<AppQuery, AppQuery> matchDay_stats_final             = a => a.Text("PASES ÚLTIMO TERCIO");
        public static Func<AppQuery, AppQuery> matchDay_stats_crosses           = a => a.Text("CORTES");
        public static Func<AppQuery, AppQuery> matchDay_stats_offense           = a => a.Text("ATAQUE");
        public static Func<AppQuery, AppQuery> matchDay_stats_precShots         = a => a.Text("Precisión de tiro");
        public static Func<AppQuery, AppQuery> matchDay_stats_shotsGoals        = a => a.Text("DISPAROS A PUERTA");
        public static Func<AppQuery, AppQuery> matchDay_stats_goalsVSshots      = a => a.Text("GOLES / DISPAROS");
        public static Func<AppQuery, AppQuery> matchDay_stats_chances           = a => a.Text("OPORTUNIDADES DE GOL");
        public static Func<AppQuery, AppQuery> matchDay_stats_totalAssists      = a => a.Text("ASISTENCIAS");

        
        // Feeds tab
        public static Func<AppQuery, AppQuery> matchDay_feeds_lineup                = a => a.Text("Alineación");
        public static Func<AppQuery, AppQuery> matchDay_feeds_team_name             = a => a.Text("EQUIPOS");
        public static Func<AppQuery, AppQuery> matchDay_feeds_playerHome_number     = (a => a.Text("EQUIPOS").Sibling(0).Child("UITableViewWrapperView").Child("RMPlayerInfoTableViewCell").Child(4).Child(0));
        public static Func<AppQuery, AppQuery> matchDay_feeds_playerHome_name       = (a => a.Text("EQUIPOS").Sibling(0).Child("UITableViewWrapperView").Child("RMPlayerInfoTableViewCell").Child(4).Child(1));
        public static Func<AppQuery, AppQuery> matchDay_feeds_playerAway_number     = (a => a.Text("EQUIPOS").Sibling(2).Child("UITableViewWrapperView").Child("RMPlayerInfoTableViewCell").Child(4).Child(0));
        public static Func<AppQuery, AppQuery> matchDay_feeds_playerAway_name       = (a => a.Text("EQUIPOS").Sibling(2).Child("UITableViewWrapperView").Child("RMPlayerInfoTableViewCell").Child(4).Child(1));
        public static Func<AppQuery, AppQuery> matchDay_feeds_feeds                 = a => a.Text("Directo");
        public static Func<AppQuery, AppQuery> matchDay_feeds_summary               = a => a.Text("Resumen");
        //public static Func<AppQuery, AppQuery> matchDay_feeds_summary_list      = a => a.Id("list_summary");
        public static Func<AppQuery, AppQuery> matchDay_feeds_summary_goals         = (a => a.Text("GOLES"));
        public static Func<AppQuery, AppQuery> matchDay_feeds_summary_cards         = (a => a.Text("TARJETAS"));
        public static Func<AppQuery, AppQuery> matchDay_feeds_summary_substitutions = (a => a.Text("SUSTITUCIONES"));
        public static Func<AppQuery, AppQuery> matchDay_feeds_timeline_description  = (a=> a.Class("RMMatchEventTableViewCell").Index(0).Child("UITableViewCellContentView").Child("UILabel").Index(1));
        public static Func<AppQuery, AppQuery> matchDay_feeds_timeline_minute       = (a=> a.Class("RMMatchEventTableViewCell").Index(0).Child("UITableViewCellContentView").Child("UILabel").Index(0));

        public static Func<AppQuery, AppQuery> matchDay_feeds_summary_quarters = (a => a.Text("CUARTOS"));
        public static Func<AppQuery, AppQuery> matchDay_feeds_summary_quarter1 = (a => a.Text("1er Cuarto"));
        public static Func<AppQuery, AppQuery> matchDay_feeds_summary_quarter2 = (a => a.Text("2º Cuarto"));
        public static Func<AppQuery, AppQuery> matchDay_feeds_summary_quarter3 = (a => a.Text("3er Cuarto"));
        public static Func<AppQuery, AppQuery> matchDay_feeds_summary_quarter4 = (a => a.Text("4º Cuarto"));
        

        // Video tab
        public static Func<AppQuery, AppQuery> matchDay_video_content       = a => a.Id("segmentedSelectorView");
        public static Func<AppQuery, AppQuery> matchDay_video_cameras       = a => a.Text("Cámaras del Bernabéu");
        public static Func<AppQuery, AppQuery> matchDay_video_liveTV        = a => a.Text("Live TV");
        public static Func<AppQuery, AppQuery> matchDay_video_RealMadridTV  = a => a.Text("Real Madrid TV");
        public static Func<AppQuery, AppQuery> matchDay_video_lineUp        = a => a.Text("Alineación");
        public static Func<AppQuery, AppQuery> matchDay_video_interviews    = a => a.Text("Entrevistas");
        public static Func<AppQuery, AppQuery> matchDay_video_fanArea       = a => a.Text("Fan Area");
        public static Func<AppQuery, AppQuery> matchDay_video_summary       = a => a.Text("Resumen");
        public static Func<AppQuery, AppQuery> matchDay_video_goals         = a => a.Text("Goles");
        public static Func<AppQuery, AppQuery> matchDay_video_full          = a => a.Text("Partido completo");
        public static Func<AppQuery, AppQuery> matchDay_video_player_class  = (a => a.Text("Real Madrid TV").Parent(4).Child(0));


        /********* LOCATION PANEL *********/

        public static Func<AppQuery, AppQuery> matchDay_location_title       = (a => a.Class("UILabel").Text("¡Es día de partido!"));   
        public static Func<AppQuery, AppQuery> matchDay_location_tv_but      = (a => a.Id("onTVIcon.png"));     
        public static Func<AppQuery, AppQuery> matchDay_location_app_but     = (a => a.Id("onAppIcon.png"));
        public static Func<AppQuery, AppQuery> matchDay_location_stadium_but = a => a.Id("onStadiumIcon.png");


        public static Func<AppQuery, AppQuery> matchDay_wifi_img        = a => a.Id("stadiumWifi.png"); 
        public static Func<AppQuery, AppQuery> matchDay_wifi_title      = a => a.Text("Wifi");
        //public static Func<AppQuery, AppQuery> matchDay_wifi_OK_but     = a => a.Id("generic_bt_ok");
        public static Func<AppQuery, AppQuery> matchDay_wifi_cancel_but = a => a.Class("UIButton");

        // Tok tv
        public static Func<AppQuery, AppQuery> matchDay_tok_but     = (a => a.Id("TOKtvSDK.bundle/TOKButton"));
        public static Func<AppQuery, AppQuery> matchDay_tokProfile  = (a => a.Marked("TOKCallAction").Parent(0));
        
        // ///////////////////////// Ipad

        // Feeds tab
        public static Func<AppQuery, AppQuery> matchDay_feeds_feeds_Tablet = a => a.Text("DIRECTO");

    }
}
