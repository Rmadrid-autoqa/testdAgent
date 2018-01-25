using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest.Queries;

namespace RealMadrid_UITest.Variables
{
    public class StatsVars
    {
        
        //       public static Func<AppQuery, AppQuery> main_title       = a => a.Id("header_title").Text("BUSCADOR");
        //      public static Func<AppQuery, AppQuery> content          = a => a.Id("content").Index(1);


        public static Func<AppQuery, AppQuery> estadísticas_Title       = (a => a.Class("UINavigationItemView").Marked("ESTADÍSTICAS"));
        public static Func<AppQuery, AppQuery> jugadores_tab            = a => a.Text("JUGADORES");
        public static Func<AppQuery, AppQuery> equipos_tab              = a => a.Text("EQUIPO");
        //public static Func<AppQuery, AppQuery> stats_data               = a => a.Id("tablet_stats");
        
        public static Func<AppQuery, AppQuery> cards_carrousel          = a => a.Class("UICollectionView");
        public static Func<AppQuery, AppQuery> spinner_players          = (a => a.Class("UIButton").Marked("Liga BBVA"));
        public static Func<AppQuery, AppQuery> spinner_team           = (a => a.Class("UIButton").Marked("Liga BBVA"));

        public static Func<AppQuery, AppQuery> spinner_Liga             = a => a.Text("Liga BBVA");
        public static Func<AppQuery, AppQuery> spinner_Copa             = a => a.Text("Copa del Rey");
        public static Func<AppQuery, AppQuery> spinner_Champions        = a => a.Text("Liga de Campeones");

        public static Func<AppQuery, AppQuery> stats_container          = (a => a.Class("UITableView").Index(0));
        
        public static Func<AppQuery, AppQuery> defensa                  = a => a.Text("DEFENSA");
        public static Func<AppQuery, AppQuery> intercepciones           = a => a.Text("INTERCEPCIONES");
        public static Func<AppQuery, AppQuery> despejes                 = a => a.Text("DESPEJES");
        public static Func<AppQuery, AppQuery> entradas                 = a => a.Text("ENTRADAS");
        public static Func<AppQuery, AppQuery> duelos                   = a => a.Text("DUELOS");

        public static Func<AppQuery, AppQuery> pases                    = a => a.Text("PASES");
        public static Func<AppQuery, AppQuery> pases_completados        = a => a.Text("PASES COMPLETADOS %");
        public static Func<AppQuery, AppQuery> pases_campo_propio       = a => a.Text("PASES CAMPO PROPIO");
        public static Func<AppQuery, AppQuery> pases_campo_contrario    = a => a.Text("PASES CAMPO CONTRARIO");
        public static Func<AppQuery, AppQuery> cortes                   = a => a.Text("CORTES %");

        public static Func<AppQuery, AppQuery> ataque                   = a => a.Text("ATAQUE");
        public static Func<AppQuery, AppQuery> oportunidades            = a => a.Text("OPORTUNIDADES DE GOL");
        public static Func<AppQuery, AppQuery> disparos                 = a => a.Text("DISPAROS %");
        public static Func<AppQuery, AppQuery> goles_disparos           = a => a.Text("GOLES / DISPAROS %");

		public static Func<AppQuery, AppQuery> ver_mas_but              = a => a.Text("+ VER MÁS").Index(1);
		public static Func<AppQuery, AppQuery> ver_menos_but            = a => a.Text("- VER MENOS").Index(0); 
        
    }
}
