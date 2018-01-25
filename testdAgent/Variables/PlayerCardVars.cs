using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;



namespace RealMadrid_UITest
{
	public class PlayerCardVars
	{

		public static Func<AppQuery, AppQuery> ficha_Jugador_Select_Player_Title = (a => a.Text("Selecciona un jugador"));
		public static Func<AppQuery, AppQuery> ficha_Jugador_Players_Scroll = a => a.Class("UICollectionView");
		public static Func<AppQuery, AppQuery> ficha_Jugador_Player_Name = (a => a.Class("UIButtonLabel"));
		public static Func<AppQuery, AppQuery> ficha_Jugador_Other_Player_Img = (a => a.Class("UICollectionView").Class("RMCardCollectionViewCell").Class("UIView").Class("UIImageView").Index(18));
		public static Func<AppQuery, AppQuery> ficha_Jugador_Player_Title = (a => a.Class("UINavigationItemView"));
		public static Func<AppQuery, AppQuery> ficha_Jugador_Perfil_Tab = (a => a.Text("PERFIL"));
		public static Func<AppQuery, AppQuery> ficha_Jugador_Social_Tab = (a => a.Text("SOCIAL"));
		public static Func<AppQuery, AppQuery> ficha_Jugador_Player_Image = (a => a.Id("statsIcon.png").Parent(1).Child(4));
		public static Func<AppQuery, AppQuery> ficha_Jugador_Player_Position = (a => a.Id("statsIcon.png").Parent(1).Child("UIButton").Index(0));
		public static Func<AppQuery, AppQuery> ficha_Jugador_Player_Age = (a => a.Id("statsIcon.png").Parent(1).Child("UIButton").Index(1));
		public static Func<AppQuery, AppQuery> ficha_Jugador_Player_Height = (a => a.Id("statsIcon.png").Parent(1).Child("UIButton").Index(2));
		public static Func<AppQuery, AppQuery> ficha_Jugador_Player_Weight = (a => a.Id("statsIcon.png").Parent(1).Child("UIButton").Index(3));
		public static Func<AppQuery, AppQuery> ficha_Jugador_Stats_but = (a => a.Id("statsIcon.png"));
		public static Func<AppQuery, AppQuery> ficha_Jugador_Games_Played = (a => a.Text("Partidos jugados"));
		public static Func<AppQuery, AppQuery> ficha_Jugador_goals = (a => a.Text("Goles"));
		public static Func<AppQuery, AppQuery> ficha_Jugador_Yellow_Cards = (a => a.Text("Tarjetas amarillas"));
		public static Func<AppQuery, AppQuery> ficha_Jugador_Red_Cards = (a => a.Text("Tarjetas rojas"));

		public static Func<AppQuery, AppQuery> ficha_Jugador_Competition_Combo = (a => a.Class("UIButton").Marked("Liga BBVA"));
		public static Func<AppQuery, AppQuery> ficha_Jugador_Competition_Liga = (x => x.Text("Liga BBVA"));
		public static Func<AppQuery, AppQuery> ficha_Jugador_Competition_Copa = (x => x.Text("Copa del Rey"));
		public static Func<AppQuery, AppQuery> ficha_Jugador_Competition_Champions = (x => x.Text("Liga de Campeones"));
		public static Func<AppQuery, AppQuery> ficha_Jugador_Horizontal_Graph = (x => x.Text("+ VER MÁS").Parent(1));
		public static Func<AppQuery, AppQuery> ficha_Jugador_Twitter_Name = (a => a.Class("UITableViewCellContentView").Class("UILabel").Index(0));

		public static Func<AppQuery, AppQuery> ficha_Jugador_Basket_Points = (a => a.Text("Puntos"));
		public static Func<AppQuery, AppQuery> ficha_Jugador_Basket_Asist = (a => a.Text("Asistencias"));
		public static Func<AppQuery, AppQuery> ficha_Jugador_Basket_Rebot = (a => a.Text("Total rebotes"));
		public static Func<AppQuery, AppQuery> ficha_Jugador_Basket_Robos = (a => a.Text("Robos"));

		public static Func<AppQuery, AppQuery> ficha_jugador_Keylor_Navas = (a => a.Class("UICollectionView").Class("RMCardCollectionViewCell").Class("UIView").Text("Keylor Navas"));
		public static Func<AppQuery, AppQuery> ficha_jugador_img_but = (a => a.Class("UICollectionView").Class("RMCardCollectionViewCell").Class("UIView").Class("UIImageView").Index(0));

		public static Func<AppQuery, AppQuery> jugador_title_keylor = a => a.Class("UINavigationItemView").Marked("KEYLOR NAVAS");
		public static Func<AppQuery, AppQuery> jugador_ad_shirt = (a => a.Text("COMPRAR AHORA!").Parent(1));

		public static Func<AppQuery, AppQuery> Stats_page_GoBack = (a => a.Text("Estadísticas").Parent(1).Child(3));

		// Ipad

		public static Func<AppQuery, AppQuery> ficha_jugador_Keylor_Navas_Tablet = a => a.Class("UIScrollView").Child(0).Child(0);

	}
}
