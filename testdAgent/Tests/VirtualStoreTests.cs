using NUnit.Framework;
using RealMadrid_UITest.Tools;
using RealMadrid_UITest.Variables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest;
using Xamarin.UITest.Queries;


namespace RealMadrid_UITest
{
    //[TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]


    public class VirtualStoreTests
    {
        IApp madrid;
        Utilities utils;
        Platform platform;



        public VirtualStoreTests(Platform platform)
        {
            this.platform = platform;
        }



        [SetUp]
        public void BeforeEachTest()
        {
            madrid = AppInitializer.StartApp(platform);
            utils = new Utilities(madrid);
            utils.Login();
        }



        [TearDown]
        public void AfterEachTest()
        {
            //            utils.Enter_Home();
            //            utils.Sign_Off();
        }

		// Auxiliary methods
		private void Go_To_Slow(Func<AppQuery, AppQuery> view, Func<AppQuery, AppQuery> element)
		{
			while (madrid.Query(element).Length == 0)
			{
				madrid.ScrollDown(view, ScrollStrategy.Gesture, 0.20, 500, true);
			}
		}

        [Test]
        //Buy subscriptions with not enough coins
        public void Test_34231()
        {
            utils.Login_data("autofriends1@yopmail.com", "P@ssword.1");

			//Step 2: Go to Virtual Store
			utils.Sleep(5);
            madrid.Tap(NavigationBarVars.navbar_Virtual_Store_but);
            Assert.True(utils.existsElement(VirtualStoreVars.VirtualStore_HeaderTitle), "Virtual Store title isn't displayed");
            //Step 3: Click on Videos tab
            madrid.Tap(VirtualStoreVars.VirtualStore_Videos_Tab);
            //Step 4: Click a category by ViewAll
            madrid.Tap(VirtualStoreVars.VirtualStore_Videos_ViewAll_but);
            //Step 5: Click a subscription
            madrid.WaitForElement(VirtualStoreVars.Videos_section_view_title);
            Assert.True(utils.existsElement(VirtualStoreVars.Videos_section_view_title), "Virtual Store section view title isn't displayed");
            //utils.Go_To(VirtualStoreVars.VirtualStore_Videos_subscriptions_view, VirtualStoreVars.VirtualStore_Videos_high_price);
            utils.Go_To(VirtualStoreVars.VirtualStore_Videos_high_price, VirtualStoreVars.VirtualStore_Videos_subscriptions_view, 5, "Element is not displayed");
            madrid.Tap(VirtualStoreVars.VirtualStore_Videos_high_price);
            //Step 6: Click on Get it buttom
            madrid.Tap(VirtualStoreVars.Videos_subscription_GetIt_but);
            madrid.WaitForElement(VirtualStoreVars.NotCoins_PopUp_title);
            Assert.True(utils.existsElement(VirtualStoreVars.NotCoins_PopUp_title), "PopUp Not coins title isn't displayed");
            Assert.True(utils.existsElement(VirtualStoreVars.NotCoins_PopUp_BuyCoins_but), "PopUp Buy coins button isn't displayed");
            Assert.True(utils.existsElement(VirtualStoreVars.NotCoins_PopUp_Ok_but), "PopUp Ok button isn't displayed");


        }

        [Test]
        //Buy virtual coins through Pop up
        public void Test_34252()
        {
            utils.Login_data("autofriends1@yopmail.com", "P@ssword.1");

            //Step 2: Click on Virtual Store icon
            madrid.Tap(NavigationBarVars.navbar_Virtual_Store_but);
            Assert.True(utils.existsElement(VirtualStoreVars.VirtualStore_HeaderTitle), "Virtual Store title isn't displayed");
            //Step 3: Click an Item (User without coins to buy it)
            madrid.Tap(VirtualStoreVars.VG_expensiveVG_Pogba);
            //Step 4: Click on Get it buttom
            madrid.Tap(VirtualStoreVars.VG_detail_GetIt_but);
            //Step 5: Click on Buy coins button
            madrid.WaitForElement(VirtualStoreVars.NotCoins_PopUp_title);
            Assert.True(utils.existsElement(VirtualStoreVars.NotCoins_PopUp_title), "PopUp Not coins title isn't displayed");
            madrid.Tap(VirtualStoreVars.NotCoins_PopUp_BuyCoins_but);
            madrid.WaitForElement(CoinsVars.BuyCoins_HeaderTitle);
            Assert.True(utils.existsElement(CoinsVars.BuyCoins_HeaderTitle), "Buy Coins title isn't displayed");

        }

        [Test]
        //Buy virtual good item not enough coins
        public void Test_34235()
        {
            utils.Login_data("autofriends1@yopmail.com", "P@ssword.1");

			//Step 2: Go to Virtual Store.
			utils.Sleep(5);
            madrid.Tap(NavigationBarVars.navbar_Virtual_Store_but);
            Assert.True(utils.existsElement(VirtualStoreVars.VirtualStore_HeaderTitle), "Virtual Store title isn't displayed");
            //Step 3: Click on Item
            madrid.Tap(VirtualStoreVars.VG_expensiveVG_Pogba);
			madrid.WaitForElement(VirtualStoreVars.VG_detail_HeaderTitle);
            Assert.True(utils.existsElement(VirtualStoreVars.VG_detail_HeaderTitle), " Virtual Good detail title isn't displayed");
            Assert.True(utils.existsElement(VirtualStoreVars.VG_detail_item_title), "Item title isn't displayed");
            Assert.True(utils.existsElement(VirtualStoreVars.VG_detail_item_image), "Item image isn't displayed");
            Assert.True(utils.existsElement(VirtualStoreVars.VG_detail_GetIt_but), "Get it detail button isn't displayed");
            //Step 4: Click on button "Get it"
            madrid.Tap(VirtualStoreVars.VG_detail_GetIt_but);
            madrid.WaitForElement(VirtualStoreVars.NotCoins_PopUp_title);
            Assert.True(utils.existsElement(VirtualStoreVars.NotCoins_PopUp_title), "PopUp Not coins title isn't displayed");
            Assert.True(utils.existsElement(VirtualStoreVars.NotCoins_PopUp_BuyCoins_but), "PopUp Buy coins button isn't displayed");
            Assert.True(utils.existsElement(VirtualStoreVars.NotCoins_PopUp_Ok_but), "PopUp Ok button isn't displayed");

        }
        
        [Test]
        //Buy Virtual good item
        public void Test_34232()
        {
            utils.Login_data(Strings.LOGIN_USERNAME_FRIENDS, Strings.LOGIN_PASSWORD_FRIENDS);
			//utils.Login_data("qadevios4@yopmail.com", "P@ssword.1");

			//Step 2: Go to Virtual Store
			utils.Sleep(5);
            madrid.Tap(NavigationBarVars.navbar_Virtual_Store_but);

            //Step 3: Click an item.
			Go_To_Slow(VirtualStoreVars.VG_view, VirtualStoreVars.VG_MaleShoe_boots_price);
			//madrid.ScrollDownTo(VirtualStoreVars.VG_MaleShoe_boots_price);
           	//madrid.SwipeRightToLeft(VirtualStoreVars.VG_MaleShoe_boots_price, 0.90, 5000, true);
            madrid.Tap(VirtualStoreVars.VG_MaleShoe_BlackYellow_boots_title);

            // Check total coins
            AppResult[] totalCoinsPrePurchase;
            madrid.WaitForElement(CoinsVars.BuyCoins_totalCoins);
            totalCoinsPrePurchase = madrid.Query(CoinsVars.BuyCoins_totalCoins);
            string TotalCoinsPreBuy = totalCoinsPrePurchase[0].Text;
            int TotalCoinsIntPreBuy = Convert.ToInt32(TotalCoinsPreBuy);

            // Check Item price
            AppResult[] ItemPrice;
            madrid.WaitForElement(VirtualStoreVars.VG_detail_item_price);
            ItemPrice = madrid.Query(VirtualStoreVars.VG_detail_item_price);
            string PriceItemDetail = ItemPrice[0].Text;
            int PriceItemDetailInteger = Convert.ToInt32(PriceItemDetail);

            //Step 4: Click on "Get it" button.
            madrid.WaitForElement(VirtualStoreVars.VG_detail_GetIt_but);
            madrid.Tap(VirtualStoreVars.VG_detail_GetIt_but);
            madrid.WaitForElement(VirtualStoreVars.Purchase_popup_title_ES);
            Assert.True(utils.existsElement(VirtualStoreVars.Purchase_popup_title_ES), "Successful purchase title isn't displayed");
            Assert.True(utils.existsElement(VirtualStoreVars.Purchase_popup_VG_img), "Successful purchase VG image isn't displayed");
            Assert.True(utils.existsElement(VirtualStoreVars.Purchase_popup_VG_information), "Successful purchase info isn't displayed");
            Assert.True(utils.existsElement(VirtualStoreVars.Purchase_popup_Ok_but), "Successful purchase ok button isn't displayed");

            //Step 5: Click CLOSE button.
            madrid.Tap(VirtualStoreVars.Purchase_popup_Ok_but);

            AppResult[] totalCoinsPostPurchase;
            madrid.WaitForElement(CoinsVars.BuyCoins_totalCoins);
            totalCoinsPostPurchase = madrid.Query(CoinsVars.BuyCoins_totalCoins);
            string TotalCoinsPostBuy = totalCoinsPostPurchase[0].Text;
            int TotalCoinsIntPostBuy = Convert.ToInt32(TotalCoinsPostBuy);           

            Assert.True(TotalCoinsIntPostBuy.Equals(TotalCoinsIntPreBuy - PriceItemDetailInteger), "Tota coins post buy item: "+TotalCoinsIntPostBuy+"total coins pre buy: "+TotalCoinsIntPreBuy+"item price: "+PriceItemDetailInteger);




        }


    }
}


      