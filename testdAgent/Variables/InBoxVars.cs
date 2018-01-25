using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace RealMadrid_UITest.Variables
{
    public class InBoxVars
    {

		//        public static Func<AppQuery, AppQuery> menu_Main_but = a => a.Id("navigation_icon");
		public static Func<AppQuery, AppQuery> inBox_Comunication_Tab = a => a.Text("COMUNICADOS");
		public static Func<AppQuery, AppQuery> inBox_Comunication_detail_back_but = a => a.Class("UINavigationButton");
		public static Func<AppQuery, AppQuery> inBox_Notification_Delete = a => a.Id("deleteIcon.png");
        public static Func<AppQuery, AppQuery> inBox_Notification_DeleteOff = a => a.Id("deleteIconOff.png");
        public static Func<AppQuery, AppQuery> inBox_Message             = (a => a.Class("UITableViewCellContentView"));
		public static Func<AppQuery, AppQuery> inBox_First_Message       = (a => a.Class("UITableViewCellContentView").Index(1).Child("UILabel"));
        public static Func<AppQuery, AppQuery> inBox_Message_Body        = (a => a.Class("UIScrollView").Child(4));
        public static Func<AppQuery, AppQuery> inBox_Message_Date        = (a => a.Class("UIScrollView").Child(0));
        public static Func<AppQuery, AppQuery> inBox_Message_Container   = a => a.Id("viewControllerScrollView");
        public static Func<AppQuery, AppQuery> inBox_Message_check       = (a => a.Class("M13Checkbox").Index(0));
		public static Func<AppQuery, AppQuery> inBox_Message_check_1 = (a => a.Class("M13Checkbox").Index(1));
		public static Func<AppQuery, AppQuery> inBox_Notification_detail_back_but = a => a.Class("UINavigationButton");
		
        public static Func<AppQuery, AppQuery> inBox_Delete_Message_text = (a => a.Text("SI").Parent().Index(0).Sibling("UILabel"));
        public static Func<AppQuery, AppQuery> inBox_Delete_OK_but = a => a.Text("SI");
        public static Func<AppQuery, AppQuery> inBox_Delete_Cancel_but = a => a.Text("NO");

    }
}
