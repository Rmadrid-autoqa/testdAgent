using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
namespace RealMadrid_UITest {
    public class MembersVars {

        ////POPUP         
        public static Func<AppQuery, AppQuery> members_popup_title = a => a.Class("UILabel").Marked("BIENVENIDO A SU ÁREA PRIVADA");         
		public static Func<AppQuery, AppQuery> members_pin_input   = a => (a.Class("UITextField").Index(1));         
		public static Func<AppQuery, AppQuery> members_pin_input_linked = a => (a.Class("UITextField").Index(0));  
		public static Func<AppQuery, AppQuery> members_enter_but   = a => a.Class("UIButton").Marked("ENTRAR");         
        public static Func<AppQuery, AppQuery> members_popup_view  = a => a.Class("UILabel").Marked("Por temas de seguridad, para realizar gestiones en su apartado de socio, debe introducir su número pin.");         
        
        //PRIVATE AREA         
        public static Func<AppQuery, AppQuery> members_private_title      = a => a.Text("ÁREA PRIVADA");         
        public static Func<AppQuery, AppQuery> members_private_view       = a => a.Text("¿Tienes carné de socio o Madridista?");         
        public static Func<AppQuery, AppQuery> members_private_partner    = a => a.Id("buttonSOCIOS");         
        public static Func<AppQuery, AppQuery> members_private_madridista = a => a.Id("buttonMADRIDISTAS");
		public static Func<AppQuery, AppQuery> members_private_goBack = (a => a.Marked("SOCIOS").Sibling("UINavigationButton"));  
         //MEMBER VIEW         
        public static Func<AppQuery, AppQuery> members_view_title          = a => a.Text("ACCESO A SU ÁREA PRIVADA");         
        public static Func<AppQuery, AppQuery> members_memberID_label      = a => a.Id("BgLogin").Sibling().Index(1);         
        public static Func<AppQuery, AppQuery> members_memberID_input      = a => a.Id("BgLogin").Sibling().Index(2);         
        public static Func<AppQuery, AppQuery> members_pin_label_priv           = a => a.Id("BgLogin").Sibling().Index(3);
        public static Func<AppQuery, AppQuery> members_pin_input_priv           = a => a.Id("BgLogin").Sibling().Index(4);
        public static Func<AppQuery, AppQuery> members_link_but            = a => a.Id("BgLogin").Sibling().Index(5);         
        public static Func<AppQuery, AppQuery> members_card_but              = a => a.Id("identity");         
        public static Func<AppQuery, AppQuery> members_giveUpSeat_but        = a => a.Id("Socios_Seat_Icon");         
        public static Func<AppQuery, AppQuery> members_OK_but              = a => a.Class("UIButton").Marked("OK");         
        public static Func<AppQuery, AppQuery> members_wrondID_title       = a => a.Text("¡Su cuenta no ha sido vinculada correctamente!");         
        public static Func<AppQuery, AppQuery> members_wrondID_body        = a => a.Text("Se ha producido un error al vincular su cuenta, inténtelo de nuevo más tarde.");         
        public static Func<AppQuery, AppQuery> members_info_but            = a => a.Class("UIButton").Marked("VER DATOS");         
        public static Func<AppQuery, AppQuery> members_partner_name        = a => a.Id("Eye").Sibling().Index(4);         
        public static Func<AppQuery, AppQuery> members_partner_surname     = a => a.Id("Eye").Sibling().Index(4);          
        public static Func<AppQuery, AppQuery> members_partner_number      = a => a.Id("Eye").Sibling().Index(9);          
        public static Func<AppQuery, AppQuery> members_partner_season      = a => a.Id("Eye").Sibling().Index(6);         
        public static Func<AppQuery, AppQuery> members_partner_info        = a => a.Id("Eye").Sibling().Index(7);
        public static Func<AppQuery, AppQuery> members_partner_card        = a => a.Text("SOCIO CON ABONO");         
        public static Func<AppQuery, AppQuery> members_partner_withoutCard = a => a.Text("SOCIO SIN ABONO");         
        public static Func<AppQuery, AppQuery> members_partner_photo       = a => a.Id("Eye").Sibling().Index(1);
        public static Func<AppQuery, AppQuery> members_updatePhoto         = a => a.Id("Eye").Sibling().Index(8);
		public static Func<AppQuery, AppQuery> members_virtualOffice 	   = a => (a.Class("UIButton").Marked("OFICINA ONLINE ≻"));        
        
        ////SEE CARD         
        public static Func<AppQuery, AppQuery> members_card_photo = a => a.Class("UILabel").Marked("Nombre y Apellidos").Sibling().Index(0);         
        public static Func<AppQuery, AppQuery> members_card_name = a => a.Class("UILabel").Marked("Nombre y Apellidos").Sibling().Index(1);         
        public static Func<AppQuery, AppQuery> members_card_number = a => a.Class("UILabel").Marked("Nombre y Apellidos").Sibling().Index(3);         
        public static Func<AppQuery, AppQuery> members_card_front = a => a.Class("UIImageView").Index(0);         
        public static Func<AppQuery, AppQuery> members_card_QR = a => a.Class("UIView");         
        
        //GIVE UP SEAT         
        public static Func<AppQuery, AppQuery> members_giveupSeat_title        = a => a.Text("CESIÓN DE ASIENTO");         
		public static Func<AppQuery, AppQuery> members_giveupSeat_back_but 	   = (a => a.Class("UIButton").Index(1)); 
		public static Func<AppQuery, AppQuery> members_giveupSeat_date         = a => a.Class("RMSeatTableViewCell").Child().Index(0).Child().Index(2);         
        public static Func<AppQuery, AppQuery> members_giveupSeat_competition  = a => a.Class("RMSeatTableViewCell").Child().Index(0).Child().Index(1);
        public static Func<AppQuery, AppQuery> members_giveupSeat_home         = a => a.Class("RMSeatTableViewCell").Child().Index(0).Child().Index(4);         
        public static Func<AppQuery, AppQuery> members_giveupSeat_away         = a => a.Class("RMSeatTableViewCell").Child().Index(0).Child().Index(3);         
		public static Func<AppQuery, AppQuery> members_giveupSeat_combobox     = (a => a.Class("UIView").Class("UIButtonLabel").Index(0));         
        public static Func<AppQuery, AppQuery> members_combobox_nextGame       = a => a.Text("PRÓXIMOS PARTIDOS");         
        public static Func<AppQuery, AppQuery> members_combobox_history        = a => a.Text("HISTÓRICO");         
        public static Func<AppQuery, AppQuery> members_combobox_notSold        = a => a.Text("NO VENDIDO");         
        public static Func<AppQuery, AppQuery> members_combobox_notGiven       = a => a.Text("NO CEDIDO");         
        public static Func<AppQuery, AppQuery> members_combobox_Sold           = a => a.Text("VENDIDO");         
        public static Func<AppQuery, AppQuery> members_combobox_forSale        = a => a.Text("EN VENTA");         
        public static Func<AppQuery, AppQuery> members_giveupSeat_conditions   = a => a.Text("Consulte las condiciones aquí");         
        public static Func<AppQuery, AppQuery> members_conditions_title        = a => a.Text("¿QUÉ VENTAJAS TENGO SI CEDO MI ASIENTO? CONSULTE LAS CONDICIONES");         
        public static Func<AppQuery, AppQuery> members_giveupSeat_status       = a => a.Class("RMSeatTableViewCell").Child().Index(0).Child().Index(6);        
        public static Func<AppQuery, AppQuery> members_status_notGiven         = a => a.Text("NO CEDIDO");         
        public static Func<AppQuery, AppQuery> members_status_sold             = a => a.Text("VENDIDO");         
        public static Func<AppQuery, AppQuery> members_status_notSold          = a => a.Text("NO VENDIDO");        
        public static Func<AppQuery, AppQuery> members_status_forSale          = a => a.Text("EN VENTA");         
        public static Func<AppQuery, AppQuery> members_giveUpSeat_help         = a => a.Class("RMSeatTableViewCell").Child().Index(0).Child().Index(9);          
        public static Func<AppQuery, AppQuery> members_statusPopup_notGiven    = a => a.Text("NO CEDIDO");         
        public static Func<AppQuery, AppQuery> members_statusPopup_body        = a => a.Text("No ha solicitado ceder la localidad para este partido, por lo tanto, no se aplicará ningún descuento.");         
        
        //UPDATE PHOTO         
        public static Func<AppQuery, AppQuery> updatePhoto_title = a => a.Text("ACTUALIZAR FOTO");         
        public static Func<AppQuery, AppQuery> updatePhoto_header = a => a.Id("BgLoginMadridistas").Sibling().Index(2);         
        public static Func<AppQuery, AppQuery> updatePhoto_file = a => a.Id("BgLoginMadridistas").Sibling().Index(3);         
        public static Func<AppQuery, AppQuery> updatePhoto_info = a => a.Class("UIButton").Marked("MÁS INFO").Sibling().Index(0);         
        public static Func<AppQuery, AppQuery> updatePhoto_moreInfo = a => a.Class("UIButton").Marked("MÁS INFO");         
        public static Func<AppQuery, AppQuery> updatePhoto_upload_but = a => a.Class("UIButton").Marked("SUBIR IMAGEN");         
        public static Func<AppQuery, AppQuery> updatePhoto_cancel = a => a.Class("UIButton").Marked("Cancelar");     
        
		// //////////////////////////////////// Ipad

		//GIVE UP SEAT         

		public static Func<AppQuery, AppQuery> members_giveupSeat_date_Tablet        = a => a.Class("RMSeatCollectionViewCell").Child().Index(0).Child().Index(2);
		public static Func<AppQuery, AppQuery> members_giveupSeat_competition_Tablet = a => a.Class("RMSeatCollectionViewCell").Child().Index(0).Child().Index(1);
		public static Func<AppQuery, AppQuery> members_giveupSeat_home_Tablet        = a => a.Class("RMSeatCollectionViewCell").Child().Index(0).Child().Index(4);
		public static Func<AppQuery, AppQuery> members_giveupSeat_away_Tablet        = a => a.Class("RMSeatCollectionViewCell").Child().Index(0).Child().Index(3);   
		public static Func<AppQuery, AppQuery> members_giveupSeat_status_Tablet      = a => a.Class("RMSeatCollectionViewCell").Child().Index(0).Child().Index(6);  
public static Func<AppQuery, AppQuery> members_giveUpSeat_help_Tablet                = (a => a.Class("RMSeatCollectionViewCell").Child().Index(0).Child().Index(8).Sibling(9)); 
       
		} 
    }