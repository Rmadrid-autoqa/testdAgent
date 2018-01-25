using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.iOS;
using Xamarin.UITest.Queries;

namespace testdAgent
{
    [TestFixture]
    public class Tests
    {
        iOSApp app;

        [SetUp]
        public void BeforeEachTest()
        {
            // TODO: If the iOS app being tested is included in the solution then open
            // the Unit Tests window, right click Test Apps, select Add App Project
            // and select the app projects that should be tested.
            //
            // The iOS project should have the Xamarin.TestCloud.Agent NuGet package
            // installed. To start the Test Cloud Agent the following code should be
            // added to the FinishedLaunching method of the AppDelegate:
            //
            //    #if ENABLE_TEST_CLOUD
            //    Xamarin.Calabash.Start();
            //    #endif
                app = ConfigureApp
                .iOS
                //.InstalledApp("com.ust.calabashtest")
                .InstalledApp("com.realmadrid.realmadridapp.calabash")
                //.InstalledApp("com.realmadrid.realmadridapp.dev")
                //.InstalledApp("com.apple.test.DeviceAgent - Runner")
                //.InstalledApp("com.realmadrid.realmadridapp.")
                // TODO: Update this path to point to your iOS app and uncomment the
                // code if the app is not included in the solution.
                //.DeviceIdentifier("fa47aec8caba25b2d2f10d42b4310f4242")
                //.AppBundle ("/Users/ustglobaltcpsi/Desktop/BinOld/Apps iOS Real madrid Calabash/cal/RealMadridApp/Payload/RealMadridApp.app")
                //.DeviceIdentifier("8942237A-FD2A-4EA0-AD7E-136A1F755B61")
                .StartApp();
        }

        [Test]
        public void AppLaunches()
        {
            //app.Screenshot("First screen.");
            app.Tap(a=> a.Id("mailLetterIcon"));

            app.Repl();
        }


    }
}
