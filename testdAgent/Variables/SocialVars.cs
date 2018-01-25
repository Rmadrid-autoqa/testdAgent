using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace RealMadrid_UITest.Variables
{
    public class SocialVars
    {
        
        public static Func<AppQuery, AppQuery> friends_friend_page = a => a.Text("SOCIAL");
        public static Func<AppQuery, AppQuery> friends_tab_Amigos = a => a.Text("Amigos");
        public static Func<AppQuery, AppQuery> friends_tab_Conversaciones = a => a.Text("Conversaciones");
        public static Func<AppQuery, AppQuery> friends_tab_Feeds = a => a.Text("Feeds");

        //// Friends tab
        public static Func<AppQuery, AppQuery> Friends_tab_SearchBox = a => a.Class("UISearchBarTextField");
        public static Func<AppQuery, AppQuery> Friends_tab_PendingInvitation_icon = a => a.Id("groups");
        public static Func<AppQuery, AppQuery> Friends_tab_PendingInvitationAmount_icon = (a => a.Id("groups").Parent().Index(1).Child("UILabel"));
        public static Func<AppQuery, AppQuery> Friends_tab_InviteFacebookFriends = a => a.Text("Agrega a tus amigos de Facebook");
        public static Func<AppQuery, AppQuery> Friends_tab_FriendsAmount_icon = a => (a.Id("ic_view_list").Parent().Index(1).Child("UILabel"));
        public static Func<AppQuery, AppQuery> Friends_tab_friendsSquares_icon = a => a.Id("ic_view_grid");
        public static Func<AppQuery, AppQuery> Friends_tab_friendsList_icon = a => a.Id("ic_view_list");
        public static Func<AppQuery, AppQuery> Friends_tab_SearchFriends_label = (a => a.Text("Invita a un amigo a Real Madrid App"));
        public static Func<AppQuery, AppQuery> Friends_tab_SearchFriends_Facebook = a => a.Id("facebook_icon");
        public static Func<AppQuery, AppQuery> Friends_tab_SearchFriends_WhatsApp = a => a.Id("Whatsapp_Icon");
        public static Func<AppQuery, AppQuery> Friends_tab_SearchFriends_Twitter = a => a.Id("twitter_icon");
        public static Func<AppQuery, AppQuery> Friends_tab_SearchFriends_Email = a => a.Id("Mail_Icon");
        public static Func<AppQuery, AppQuery> Friends_tab_SearchFriends_NativeShare = a => a.Id("Share_Icon");
		public static Func<AppQuery, AppQuery> Friends_tab_AliasFriends = (a => a.Class("RMFriendSearchCollectionViewCell").Child().Index(0).Child().Index(1).Child("UILabel"));
		public static Func<AppQuery, AppQuery> Friends_tab_Friend_dots =  (a => a.Class("RMFriendSearchCollectionViewCell").Child().Index(0).Child().Index(0).Child("UIButton").Index(1));
        public static Func<AppQuery, AppQuery> Friends_tab_NofriendsMessage = a => a.Text("Esta sección está muy vacía, puedes utilizar el buscador para encontrar nuevos amigos");
       
        public static Func<AppQuery, AppQuery> Friends_tab_Reject_FriendRequest_but = a => a.Id("ic_gray_close");
        public static Func<AppQuery, AppQuery> Friends_tab_Accept_FriendRequest_but = a => a.Id("ic_checked");

        public static Func<AppQuery, AppQuery> Friends_tab_AliasFriends_qa = (a => a.Text("qa"));
        public static Func<AppQuery, AppQuery> Friends_tab_AliasFriends_qadev = (a => a.Text("qadev"));
        public static Func<AppQuery, AppQuery> Friends_tab_AliasFriends_Test01dev = (a => a.Text("Test01dev"));
        public static Func<AppQuery, AppQuery> Friends_tab_AliasFriends_qadevios4 = (a => a.Text("qadevios4"));
        public static Func<AppQuery, AppQuery> Friends_tab_AliasFriends_testautofriend = (a => a.Text("testautofriends"));
        public static Func<AppQuery, AppQuery> Friends_tab_FriendsAmountNofriends_icon = (a => a.Text("0 amigos"));
		public static Func<AppQuery, AppQuery> Friends_tab_AliasFriends_DiegoAlonso = (a => a.Text("DiegoAlonso"));
		public static Func<AppQuery, AppQuery> Friends_ImageShorcuts_DiegoAlonso = a => a.Class("UILabel").Text("DiegoAlonso").Index(1).Parent(1).Child(0).Child("UIImageView");         

        //// Shortcuts friend
        public static Func<AppQuery, AppQuery> Friends_tab_Shortcuts_chat_popup = a => a.Id("ic_chat_action");
        public static Func<AppQuery, AppQuery> Friends_tab_Shortcuts_gift_popup = a => a.Id("ic_gift_shape");
        public static Func<AppQuery, AppQuery> Friends_tab_Shortcuts_remove_popup = a => a.Id("red_trash");

        //// Send gift         
        public static Func<AppQuery, AppQuery> Gift_BlueCap_title = a => a.Text("Gorra  Azul");
        public static Func<AppQuery, AppQuery> Gift_BlackYellowBoots_title = a => a.Text("Botas Adidas Negras Amarillas");
        public static Func<AppQuery, AppQuery> Gift_Many = (a => a.Class("RMVirtualGoodsListCollectionViewCell").Index(0).Child().Index(0).Child().Index(1).Child().Index(0).Child().Index(2));
        public static Func<AppQuery, AppQuery> Gift_Many_1 = (a => a.Text("Gorra  Azul"));
        public static Func<AppQuery, AppQuery> Gift_SendGift_but = a => a.Text("Enviar Regalo"); 

        //// Conversations tab

        public static Func<AppQuery, AppQuery> Conversation_tab_friendsname = a => (a.Class("RMThreadsTableViewCell").Index(0).Child().Index(0).Child().Index(4));
        //public static Func<AppQuery, AppQuery> Conversation_tab_unread_chats_icon = a => (a.Id("unread_chats_icon"));
        public static Func<AppQuery, AppQuery> Conversation_tab_chat_info = a=> (a.Class("RMThreadsTableViewCell").Index(0).Child().Index(0).Child().Index(4));
        public static Func<AppQuery, AppQuery> Conversation_tab_qadevan3 = a => (a.Text("qadevan3"));
        public static Func<AppQuery, AppQuery> Conversation_tab_helenasocial6 = a => (a.Text("helenasocial6"));
        public static Func<AppQuery, AppQuery> Conversation_tab_olichat1a = a => (a.Text("olichat1a"));
        public static Func<AppQuery, AppQuery> Conversation_tab_view = a => (a.Class("UITableViewWrapperView"));


        //// Conversation detail

        public static Func<AppQuery, AppQuery> Conversation_detail_enterText = a => a.Class("UITextFieldLabel");
        public static Func<AppQuery, AppQuery> Conversation_detail_sendText = a => a.Class("UIButtonLabel");
        public static Func<AppQuery, AppQuery> Conversation_detail_TextMessage = (a => a.Class("UITableViewCellContentView").Index(0).Child().Index(0).Child().Index(0));
        public static Func<AppQuery, AppQuery> Conversation_detail_FriendHeader_title = a => a.Class("UINavigationItemView");
        public static Func<AppQuery, AppQuery> Conversation_detail_FriendHeader_title_qadevan3 = (a => a.Class("UINavigationItemView").Marked("qadevan3"));
        public static Func<AppQuery, AppQuery> Conversation_detail_view = a => a.Class("RMChatTableView");
        public static Func<AppQuery, AppQuery> Conversation_detail_time_qadevan3 = (a => a.Text("29/12/16 11:50"));
        public static Func<AppQuery, AppQuery> Conversation_detail_testautofriends_title = (a => a.Class("UINavigationItemView").Marked("testautofriends"));
        public static Func<AppQuery, AppQuery> Conversation_detail_GoBack = (a => a.Class("UINavigationBar").Child("UINavigationButton"));
        //public static Func<AppQuery, AppQuery> Conversation_detail_TotalCoins = a => a.Id("tv_user_coins");


        ////Gift sent
        public static Func<AppQuery, AppQuery> SentGift_Title = (a => a.Text("Regalo enviado"));
        public static Func<AppQuery, AppQuery> SentGift_Name = (a => a.Text("Regalo enviado"));
        public static Func<AppQuery, AppQuery> SendGift_To_Alias = (a => a.Class("UITransitionView").Class("UILabel").Index(3));
        public static Func<AppQuery, AppQuery> SentGift_Ok_but = (a => a.Text("OK"));

        //// Feed tab
        public static Func<AppQuery, AppQuery> Feeds_tab_TimeLine_list = a => a.Id("bgSocial"); 
public static Func<AppQuery, AppQuery> Feeds_tab_FriendImage = a => a.Text("ACTIVIDAD RECIENTE").Parent(1).Child(0).Child(6).Child(0).Child(0).Child(0).Child(0);
        //public static Func<AppQuery, AppQuery> Feeds_tab_FeedTitle = a => a.Id("user_alias_title"); // esta integrado con el texto del feed
        public static Func<AppQuery, AppQuery> Feeds_tab_FriendProfile_GoBack = (a => a.Class("UINavigationBar").Child("UINavigationButton"));
        public static Func<AppQuery, AppQuery> Feeds_tab_FriendProfileHeader_title = a => a.Class("UINavigationItemView");
		public static Func<AppQuery, AppQuery> Feeds_tab_actionDescription = (a => a.Text("ACTIVIDAD RECIENTE").Parent(1).Child(0).Child(6).Child(0).Child(0).Child(0).Child(1));
        //public static Func<AppQuery, AppQuery> Feeds_tab_Badge_img = a => a.Id("action_image_bg"); // Parecen ser todas UIImageView
        //public static Func<AppQuery, AppQuery> Feeds_tab_News_img = a => a.Id("action_image");
        //public static Func<AppQuery, AppQuery> Feeds_tab_play_img = a => a.Id("play");
        public static Func<AppQuery, AppQuery> Feeds_tab_SubscriptionDescription = (a => a.Text("Highlighted videos"));
        public static Func<AppQuery, AppQuery> Feeds_tab_NewsDescription = (a => a.Text("Cristiano Ronaldo ofreció su cuarto Balón de Oro al Bernabéu"));
        public static Func<AppQuery, AppQuery> Feeds_tab_CheckInDescription = (a => a.Text("MADRID_PLAZA_DE_CIBELES"));
        public static Func<AppQuery, AppQuery> Feeds_tab_VGDescription = (a => a.Text("Gorra  Azul con precio 25.0 Identificado /n en los medios de comunicación con el numerónimo CR7 /n ,n 1 es considerado el mejor y más completo futbolista y goleador del mundo —e incluso de la historia— por un elevado número de personas y prensa vinculadas al deporte,n 2 así como también una de las figuras más mediáticas de la actualidad.4 Es, con 380 goles, el máximo goleador de la historia del Real Madrid Club de Fútbol —tras haber superado sucesivamente a otros jugadores como Amancio Amaro,5 Emilio Butragueño,6 Pirri,7 Paco Gento,8 Hugo Sánchez,9 Ferenc Puskás,10 Santillana,11 Alfredo Di Stéfano12 y Raúl González Blanco—,13 14 /n consiguiéndolo en apenas siete temporadas en el club."));
        public static Func<AppQuery, AppQuery> Feeds_tab_FriendshipDescription = (a => a.Text("qadev2202"));
        public static Func<AppQuery, AppQuery> Feeds_tab_EvenWhen = (a => a.Class("RMFeedContainerCell").Index(0).Child().Index(0).Child().Index(0).Child().Index(0).Child().Index(0).Child().Index(1).Child().Index(1));
        //// Expected feeds 
        public static Func<AppQuery, AppQuery> Badges_title = (a => a.Class("UINavigationItemView").Text("MEDALLAS"));
        public static Func<AppQuery, AppQuery> Videos_subscriptionDetail_title = (a => a.Text("Highlighted videos"));
        public static Func<AppQuery, AppQuery> News_NewsDetail_title = (a => a.Text("Cristiano Ronaldo ofreció su cuarto Balón de Oro al Bernabéu"));
        public static Func<AppQuery, AppQuery> VirtualGoods_VGDetail_title = (a => a.Text("Gorra  Azul"));
		public static Func<AppQuery, AppQuery> Friendship_FriendProfileHeader_title = (a => a.Class("UINavigationItemView").Marked("qadev2202"));


        ////Profile   ------Mover a ProfileVars cuando Jorge suba todo ProfileVars a master--------
        //// Friend Profile

        public static Func<AppQuery, AppQuery> profile_account_delete_but = a => a.Id("ic_delete_friend");
        public static Func<AppQuery, AppQuery> profile_account_addNoFriend_but = a => a.Id("ic_add_friend");
        public static Func<AppQuery, AppQuery> profile_account_chat_but = a => a.Id("ic_chat_action");
        public static Func<AppQuery, AppQuery> profile_account_gift_but = a => a.Id("ic_gift_shape");
		public static Func<AppQuery, AppQuery> profile_account_GoBack_but = (a => a.Class("UINavigationButton").Index(0));   
        //// Invitation sent
        public static Func<AppQuery, AppQuery> FriendRequestSent_popup_title = (a => a.Text("Enviado"));
        public static Func<AppQuery, AppQuery> FriendRequestSent_popup_ok_but = (a => a.Text("Cerrar"));

        //// Profile
        public static Func<AppQuery, AppQuery> profile_account_alias = (a => a.Id("ic_delete_friend").Sibling().Parent(1).Child().Index(2));
        public static Func<AppQuery, AppQuery> profile_title = (a => a.Class("UINavigationItemView").Marked("ÁREA PERSONAL"));

        //// Recent activity
        public static Func<AppQuery, AppQuery> RecentActivity_SectionTitle = (a => a.Text("ACTIVIDAD RECIENTE"));

    }
}
