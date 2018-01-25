using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace RealMadrid_UITest
{
    public class VirtualStoreVars
    {
        
        // General objects
        public static Func<AppQuery, AppQuery> VirtualStore_HeaderTitle = (a => a.Class("UINavigationItemView").Marked("TIENDA VIRTUAL"));
        public static Func<AppQuery, AppQuery> VirtualStore_VirtualGoods_tab = a => a.Text("Bienes Virtuales");
        public static Func<AppQuery, AppQuery> VirtualStore_Videos_Tab = a => a.Text("VÍDEOS");
        public static Func<AppQuery, AppQuery> VirtualStore_Videos_subscriptions_view = a => a.Class("UIViewControllerWrapperView");
		public static Func<AppQuery, AppQuery> VirtualStore_page_GoBack = (a => a.Text("TIENDA VIRTUAL").Parent(1).Child(3));
        
		// Videos Tab
        public static Func<AppQuery, AppQuery> Videos_section_title = (a => a.Text("Los goles de los mejores jugadores del Real Madrid"));
        public static Func<AppQuery, AppQuery> VirtualStore_Videos_AllCategories_ComboBox = (a => a.Class("UIButtonLabel").Index(2));
        public static Func<AppQuery, AppQuery> VirtualStore_Videos_ViewAll_but = a => a.Text("VER TODO");
        public static Func<AppQuery, AppQuery> Videos_section_view_title = (a => a.Text("Los goles de los mejores jugadores del Real Madrid"));
        public static Func<AppQuery, AppQuery> VirtualStore_Videos_high_price = (a => a.Text("100000"));
        public static Func<AppQuery, AppQuery> Videos_subscription_GetIt_but = a => a.Text("¡CONSÍGUELO!");
		public static Func<AppQuery, AppQuery> VirtualStore_Videos_Goals_ComboBox = a => a.Text("GOALS");
        public static Func<AppQuery, AppQuery> VirtualStore_Videos_Higth_ComboBox = a => a.Text("HIGHLIGHTEDVIDEO");
        public static Func<AppQuery, AppQuery> VirtualStore_Videos_OportunidadesCR7 = a => a.Text("Oportunidades de Cristiano Ronaldo en Real Madrid – Deportivo del día 9/01 - ES");
        public static Func<AppQuery, AppQuery> VirtualStore_Videos_QATest1 = a => a.Text("QA test1_Subscription_Finder");
        public static Func<AppQuery, AppQuery> VirtualStore_Videos_Subscription = a => a.Class("UINavigationItemView").Marked("DETALLES DEL PACK");
        public static Func<AppQuery, AppQuery> VirtualStore_Videos_Subscription_likes = (a => a.Id("icnLikeOn").Sibling("UIButtonLabel"));
		public static Func<AppQuery, AppQuery> VirtualStore_Videos_Subscription_likes_Off = (a => a.Id("icnLikeOff").Sibling("UIButtonLabel"));
		public static Func<AppQuery, AppQuery> VirtualStore_Videos_Subscription_like = a => a.Id("icnLikeOn");
		public static Func<AppQuery, AppQuery> VirtualStore_Videos_Subscription_like_Off = a => a.Id("icnLikeOff");
		public static Func<AppQuery, AppQuery> VirtualStore_Videos_Subscription_play = (a => a.Id("UITableViewCellContentView").Child().Index(4));
        public static Func<AppQuery, AppQuery> VirtualStore_Videos_player = a => a.Class("UIActivityIndicatorView");
        
        // Virtual Goods tab
        public static Func<AppQuery, AppQuery> content_virtual_goods_title = a => a.Text("Content");
        public static Func<AppQuery, AppQuery> VG_expensiveVG_Pogba = (a => a.Text("Pogba al Madrid"));
        public static Func<AppQuery, AppQuery> VG_view = a => a.Class("UIViewControllerWrapperView");
        public static Func<AppQuery, AppQuery> VG_MaleHat_section_title = (a => a.Text("Male Hat"));
        public static Func<AppQuery, AppQuery> VG_viewAll_but = a => a.Text("VER TODO");
   
        // Virtual Good detail
        public static Func<AppQuery, AppQuery> VG_detail_GetIt_but = a => a.Text("¡CONSÍGUELO!");
        public static Func<AppQuery, AppQuery> VG_detail_HeaderTitle = (a => a.Marked("DETALLE DEL BIEN VIRTUAL"));
        public static Func<AppQuery, AppQuery> VG_detail_item_title = (a => a.Text("Pogba al Madrid"));
        public static Func<AppQuery, AppQuery> VG_detail_item_image = (a => a.Text("¡CONSÍGUELO!").Parent(0).Sibling("UIImageView"));
        public static Func<AppQuery, AppQuery> VG_detail_item_price = (a => a.Id("coinIcon.png").Sibling(1)); 

    
        // Virtual Goods Section
        public static Func<AppQuery, AppQuery> VG_MaleHat_BlueCap_title = (a => a.Text("Gorra  Azul"));
        public static Func<AppQuery, AppQuery> VG_MaleShoe_section_title = (a => a.Text("Male Shoe"));       
        public static Func<AppQuery, AppQuery> VG_MaleShoe_BlackYellow_boots_title = (a => a.Text("Botas Adidas Negras Amarillas"));
        public static Func<AppQuery, AppQuery> VG_MaleShoe_boots_price = (a => a.Text("50"));
        
        // Pop up not enough coins
        public static Func<AppQuery, AppQuery> NotCoins_PopUp_title = (a => a.Text("No tiene las monedas suficientes para comprar el producto"));
        public static Func<AppQuery, AppQuery> NotCoins_PopUp_BuyCoins_but = (a => a.Text("COMPRAR MONEDAS"));
        public static Func<AppQuery, AppQuery> NotCoins_PopUp_Ok_but = (a => a.Text("Cerrar"));

        // Pop successful purchase
        public static Func<AppQuery, AppQuery> Purchase_popup_title_ES = (a => a.Text("¡Has conseguido el siguiente artículo!"));
        public static Func<AppQuery, AppQuery> Purchase_popup_VG_img = a => a.Id("radialEffect.png");
        public static Func<AppQuery, AppQuery> Purchase_popup_VG_information = (a => a.Id("radialEffect.png").Sibling().Index(2));
        public static Func<AppQuery, AppQuery> Purchase_popup_Ok_but = a => a.Text("Cerrar");
        

    }
}
