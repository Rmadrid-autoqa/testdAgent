using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace RealMadrid_UITest
{
    public class CoinsVars
    {
        
        // General objects
        public static Func<AppQuery, AppQuery> BuyCoins_HeaderTitle = (a => a.Class("UINavigationItemView").Marked("COMPRAR MONEDAS"));
        public static Func<AppQuery, AppQuery> BuyCoins_totalCoins = (a => a.Text("TOTAL:").Sibling("UILabel").Index(0));
        
    }
}
