using System;
using System.IO;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;



namespace RealMadrid_UITest
{


    public class AppInitializer
    {

        public static IApp StartApp(Platform platform)
        {

            if (platform == Platform.Android)
            {
                return ConfigureApp
                    .Android
                    .ApkFile("RealMadridQA.apk")
                    //.DeviceSerial("09abf9e0029ae407")
                    .StartApp();
            }


            return ConfigureApp
                .iOS
                .InstalledApp("com.realmadrid.realmadridapp.calabash")
                //.DeviceIdentifier("D18FD58E-DE32-4FB9-849D-4F3C53F78AB4")
                //.AppBundle("/Users/ustglobaltcpsi/Projects/ipas/RealMadridApp/Payload/RealMadridApp.app")
                //.DeviceIdentifier("fa47aec8caba25b2d2f10d42b4310f424277d1a6") //iphone 7
                //.DeviceIdentifier("3c19a625654783dbe31b153d441337a1fc1c2c78")//Iphone
                //.DeviceIdentifier("ac891d5bc4e658525c5b67f3a57e289ffc4eb1e4")
                //.DeviceIdentifier("08fb3843185da0f1fe786a089a9c03b35c7dc3cd")//Ipad mini
                .StartApp();

        }
    }
}