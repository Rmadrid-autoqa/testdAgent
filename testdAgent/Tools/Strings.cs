using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RealMadrid_UITest
{


    public class Strings
    {

        /*
        En esta clase vamos a guardar textos de los distintos elementos de la app 
        para favorecer su reusabilidad
        */
        public const String APKFILE = "RealMadridQA.apk";

        /*LOGIN*/

        // Token TestCloud
        //public const String LOGIN_USERNAME = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6Ilg1ZVhrNHh5b2pORnVtMWtsMll0djhkbE5QNC1jNTdkTzZRR1RWQndhTmsifQ.eyJpc3MiOiJodHRwczovL2xvZ2luLm1pY3Jvc29mdG9ubGluZS5jb20vYTc5ZDNlZTItMzBjMy00Y2VkLWI0NDUtYWJmYjA0MzdiMDRhLyIsImV4cCI6MTQ5OTMzMTYxOSwibmJmIjoxNDk5MjQ1MjE5LCJhdWQiOiJodHRwczovL3JtYWRkZXYub25taWNyb3NvZnQuY29tL3dlYmFwaSIsIm9pZCI6IjkzODBhM2VjLTQ5ZDItNDkxMi1hZjc1LTQ1ZGRkNGI4OTJhZiIsImV4dGVuc2lvbl9DcGltX0xhbmd1YWdlIjoiZXMtZXMiLCJzdWIiOiJOb3Qgc3VwcG9ydGVkIGN1cnJlbnRseS4gVXNlIG9pZCBjbGFpbS4iLCJub25jZSI6ImRlZmF1bHROb25jZSIsInZlciI6IjEuMCJ9.U4eaw8eRfurIHbB9pxtWgAbtG6qRtqzoVvtyLyRx1-AX1-JZHFSDomgdcOkkhVpdaWwdSM--DthdxabsnkIpJKohJLyz7pCm3xxrb9PfmxpkpTdaWxl7-8NyHJgo8rdkwHvy0J3XxFhMydZmg_Ayt0WunYPHeKrHUuQ2jLoNMlnZESVkfOx52od6pCzXN_p7zUxdeEauFww9TOiqwputUyjk4eOtrbr3bB2YhxtoDm0idjavhUeZqDMZH4WzoVML7h9zbyLFGhvt5YNAc_KcldOGvvBlQbpeip_qnafG8fxxggUZVBGX72Et3iF3-wDlX3WFnCSt1KijM2Q2lCvePA";
        public const String LOGIN_USERNAME = "ustapks@yopmail.com";
        public const String LOGIN_PASSWORD = "Ustapks1";

        // Token TestCloud
        //public const String LOGIN_USERNAME1 = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6Ilg1ZVhrNHh5b2pORnVtMWtsMll0djhkbE5QNC1jNTdkTzZRR1RWQndhTmsifQ.eyJpc3MiOiJodHRwczovL2xvZ2luLm1pY3Jvc29mdG9ubGluZS5jb20vYTc5ZDNlZTItMzBjMy00Y2VkLWI0NDUtYWJmYjA0MzdiMDRhLyIsImV4cCI6MTQ5OTMzNzQwNSwibmJmIjoxNDk5MjUxMDA1LCJhdWQiOiJodHRwczovL3JtYWRkZXYub25taWNyb3NvZnQuY29tL3dlYmFwaSIsIm9pZCI6IjQzYmE5OTA0LWI2ZjMtNDczNS1iOTM4LWY5ZGQwZDRiZTYxMiIsImV4dGVuc2lvbl9DcGltX0xhbmd1YWdlIjoiZXMtZXMiLCJzdWIiOiJOb3Qgc3VwcG9ydGVkIGN1cnJlbnRseS4gVXNlIG9pZCBjbGFpbS4iLCJub25jZSI6ImRlZmF1bHROb25jZSIsInZlciI6IjEuMCJ9.pQhcm_xins72MWymr2cSd2LRXxRtLD9-Jqe8wmiE_TKfdtkWughnsGXv_MZk5W7GVvDGqSFyZT1NCCSkuk_OQ-tbRSswWrTSSufoyNmbjCD4DV57eDzbuRamgyBQaoF7eXzMeb0xeeIb5h3hEyKknQqYRO1k1QJY7YJlgmPtWYhTb8iRIRPZ9RMoemTwceo5JS_lr0gQ5igeuO-RLp-wpopeY__3TJBAHRAShMdYpQzMI8L_FEleI_SCj_vbT-sXmLfrNfwxOOnf9UIIJOCestcnHZb4jQ01-aIxkFrjL7qL0QY-8RRBrveJt5leDSbjHjMFOTdyVTKAgGhoRr8JMw";
        public const String LOGIN_USERNAME1 = "a@yopmail.com";
        public const String LOGIN_PASSWORD1 = "aA012345";

        // Token TestCloud
        public const String LOGIN_USERNAME_FRIENDS = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6Ilg1ZVhrNHh5b2pORnVtMWtsMll0djhkbE5QNC1jNTdkTzZRR1RWQndhTmsifQ.eyJpc3MiOiJodHRwczovL2xvZ2luLm1pY3Jvc29mdG9ubGluZS5jb20vYTc5ZDNlZTItMzBjMy00Y2VkLWI0NDUtYWJmYjA0MzdiMDRhLyIsImV4cCI6MTQ5OTMzNzUxMywibmJmIjoxNDk5MjUxMTEzLCJhdWQiOiJodHRwczovL3JtYWRkZXYub25taWNyb3NvZnQuY29tL3dlYmFwaSIsIm9pZCI6IjhiYzM4OWUwLTU4YTUtNGM5MC04OWZkLWU3ZDhmZWVhMTUzYyIsImV4dGVuc2lvbl9DcGltX0xhbmd1YWdlIjoiZXMtZXMiLCJzdWIiOiJOb3Qgc3VwcG9ydGVkIGN1cnJlbnRseS4gVXNlIG9pZCBjbGFpbS4iLCJub25jZSI6ImRlZmF1bHROb25jZSIsInZlciI6IjEuMCJ9.LgIUicG7Rf40SFTlcUrTYbFSGcajfx3Cn5GjvQfv8bP7saD5lI7mKcI5FyI__Dn3yC0HqlzpwXiugpfFDMCdNNtcfESX21G_f1rewhfQY4mU8gxnCPjVsOSRHuPOZ1iRyeVKZPc5IZ8ue8pubQ_tPyFlUw6HyUZrJFJE_2n7H_kaaXmNWzSl0ooBfXErgee6ODWU8-PHwao95k7cNNgBE_SdTw2hP4-WDH3ZWF7-dQuU_nWabmV6UbdrpBeX_IXpYZGT0sIEF0h0Pjk4Mxlf4OL3Z73bWrfW12L0fgJRO5lHq7t0omBqtW-dNJopcZV8qoaoZaB_IwX2JxQ54QxA4A";
        //public const String LOGIN_USERNAME_FRIENDS = "qadevios4@yopmail.com";
        public const String LOGIN_PASSWORD_FRIENDS = "P@ssword.1";

        // Token TestCloud
        public const String LOGIN_USERNAME_NOTLINKED = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6Ilg1ZVhrNHh5b2pORnVtMWtsMll0djhkbE5QNC1jNTdkTzZRR1RWQndhTmsifQ.eyJpc3MiOiJodHRwczovL2xvZ2luLm1pY3Jvc29mdG9ubGluZS5jb20vYTc5ZDNlZTItMzBjMy00Y2VkLWI0NDUtYWJmYjA0MzdiMDRhLyIsImV4cCI6MTQ5OTMzNzY0NywibmJmIjoxNDk5MjUxMjQ3LCJhdWQiOiJodHRwczovL3JtYWRkZXYub25taWNyb3NvZnQuY29tL3dlYmFwaSIsIm9pZCI6IjQ5NzE1NTE1LTFkMjYtNDVjMi1hNGJiLWQ5OTRlZDJmNWFjOCIsImV4dGVuc2lvbl9DcGltX0xhbmd1YWdlIjoiZXMtZXMiLCJzdWIiOiJOb3Qgc3VwcG9ydGVkIGN1cnJlbnRseS4gVXNlIG9pZCBjbGFpbS4iLCJub25jZSI6ImRlZmF1bHROb25jZSIsInZlciI6IjEuMCJ9.X9q3l6YmKEPB-xTNnckD265H0TbbrTdioK9rtcRcJPBeAsPtEfj-USUq1le_JOKGDUV3JNagVk70C_yvo6KHLfwPufR1JxFMB8HakYruPVTI0689tnyt1-tT5eAW-Fv3UTG_lrfpXFfXtFZoiQNK2wSUNfcZCiTp4rlrnAen4HdIpXbKqOh6lcHVkrJHBEDIwqnR60F2Q24p2MG-a-aBNpCpwIFR9xEr8nvITmyRGcLHMbDFnFCif6KP8nEyQRefSg_LnnUm8x_T3_0Ycr0Dhz15C11Dq8hTCnXIX7UBJxiNVqkRqScDJNMlLLciy8zE7SyXj3YaqGRAdaz2237ZBg";
        //public const String LOGIN_USERNAME_NOTLINKED = "ustapks2@yopmail.com";
        public const String LOGIN_PASSWORD_NOTLINKED = "Ustapks2";

        // Token TestCloud
        public const String LOGIN_USERNAME_FULL = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6Ilg1ZVhrNHh5b2pORnVtMWtsMll0djhkbE5QNC1jNTdkTzZRR1RWQndhTmsifQ.eyJpc3MiOiJodHRwczovL2xvZ2luLm1pY3Jvc29mdG9ubGluZS5jb20vYTc5ZDNlZTItMzBjMy00Y2VkLWI0NDUtYWJmYjA0MzdiMDRhLyIsImV4cCI6MTQ5OTMzNzc4MSwibmJmIjoxNDk5MjUxMzgxLCJhdWQiOiJodHRwczovL3JtYWRkZXYub25taWNyb3NvZnQuY29tL3dlYmFwaSIsIm9pZCI6ImI2YzIwYWI5LWYyMzUtNDY0ZC05NzNjLTdiYTA1YjY5NWUwOSIsImV4dGVuc2lvbl9DcGltX0xhbmd1YWdlIjoiZXMtZXMiLCJzdWIiOiJOb3Qgc3VwcG9ydGVkIGN1cnJlbnRseS4gVXNlIG9pZCBjbGFpbS4iLCJub25jZSI6ImRlZmF1bHROb25jZSIsInZlciI6IjEuMCJ9.XDfmgm0gMfiFB132Aa9kx0ISrzENfUrKU9wVt8gTnIfTMcm2URDhuT6EoilWTN-tCDmX-kNnA4wo_U6ETeuFgeRBCx_SsjJ4W-08_Ig2tfEfd5o3UEmYtOaZeV-5rRYzvG3Mpzv1VHmlf5SqEbkiNwmXQR-uwg3lr5co0YaAsplh9j76GjAdkHipYBhGruIe-U_QEX-XUejM0UcMsaSyof1D0OlhYv8eRsx6903lv_OdeMRQF59pnTnOtcFhCuNrHrAGRF7v-90Av6EEzlEO-Hx1KpOS7BckmFLMRuUqI5FlnTP3mmWK05Jqduk2nfbWwel66X8ta6qmukSj0nULdw";
        //public const String LOGIN_USERNAME_FULL = "Test01dev@yopmail.com";
        public const String LOGIN_PASSWORD_FULL = "P@ssword.1";

        // Token TestCloud (Social tests only)
        public const String LOGIN_USERNAME_NOFRIENDS = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6Ilg1ZVhrNHh5b2pORnVtMWtsMll0djhkbE5QNC1jNTdkTzZRR1RWQndhTmsifQ.eyJpc3MiOiJodHRwczovL2xvZ2luLm1pY3Jvc29mdG9ubGluZS5jb20vYTc5ZDNlZTItMzBjMy00Y2VkLWI0NDUtYWJmYjA0MzdiMDRhLyIsImV4cCI6MTQ5OTMzNzg4OCwibmJmIjoxNDk5MjUxNDg4LCJhdWQiOiJodHRwczovL3JtYWRkZXYub25taWNyb3NvZnQuY29tL3dlYmFwaSIsIm9pZCI6ImQzNzIzZmY4LTYzZTMtNDc4MC1iYWRmLTJhN2JlNjA4ZjY2NCIsImV4dGVuc2lvbl9DcGltX0xhbmd1YWdlIjoiZXMtZXMiLCJzdWIiOiJOb3Qgc3VwcG9ydGVkIGN1cnJlbnRseS4gVXNlIG9pZCBjbGFpbS4iLCJub25jZSI6ImRlZmF1bHROb25jZSIsInZlciI6IjEuMCJ9.oQ8l7fA-rXJUI8Q25CgArh6H2_lwXWLYDe5foVDL8JpmTs21UaDEESJndkg7FlsEt3s12HMIdKxjEVzaKF-9jiON-qCFf_zSW_VT1grN1lxhaKRHe95Mlq2Kh--CZGbk8UBUr2oiq0HZvNX9wvlk1QMPsVLWzzkgDHAPBCdjWspTZncKrxHx1w2QOsAa2iPIhcDASMQnbqizO_Bl9We1DNc7_J-SEcWLzLDkK05RuY5DyJKzNub6FD0LgB2MqBGa3DB07VHhtFiHy5k-vSGF6ABskleSHOgvGYHWdlwZk1PZJ4TjSdh-kQV9ZGYwK-lHvgLQ378iODHVEkjdmny6jg";
        //public const String LOGIN_USERNAME_NOFRIENDS = "testautonofriends@yopmail.com";
        public const String LOGIN_PASSWORD_NOFRIENDS = "P@ssword.1";

        // Token TestCloud (Social tests only)
        public const String LOGIN_USERNAME_FRIENDS2 = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6Ilg1ZVhrNHh5b2pORnVtMWtsMll0djhkbE5QNC1jNTdkTzZRR1RWQndhTmsifQ.eyJpc3MiOiJodHRwczovL2xvZ2luLm1pY3Jvc29mdG9ubGluZS5jb20vYTc5ZDNlZTItMzBjMy00Y2VkLWI0NDUtYWJmYjA0MzdiMDRhLyIsImV4cCI6MTQ5OTMzNzk3OSwibmJmIjoxNDk5MjUxNTc5LCJhdWQiOiJodHRwczovL3JtYWRkZXYub25taWNyb3NvZnQuY29tL3dlYmFwaSIsIm9pZCI6IjI5NzgwOGIwLWJmZTctNDUwYy1hYWQ0LTVlOGQyNzgwM2M4MSIsImV4dGVuc2lvbl9DcGltX0xhbmd1YWdlIjoiZXMtZXMiLCJzdWIiOiJOb3Qgc3VwcG9ydGVkIGN1cnJlbnRseS4gVXNlIG9pZCBjbGFpbS4iLCJub25jZSI6ImRlZmF1bHROb25jZSIsInZlciI6IjEuMCJ9.LX_C6Rm6d-zH7XS58aMPlyMMnql8kqUCwY2MfW_nq_wjWQo0y0mFq-DukpP-3n6oJn3-twzMcrsenoLULQzODAai0RiUDDtjsTrpAAx0bGijsDwv7L28b-YUQ3QU-Xlfb3UhuW3B8X5jjDPMKO-dS3bixeuZ4FtJShPxU7nfOHe9s6pnjPyF_Ph8-DFfv2vmQ5G1sIV5iDPfDSQuBKNlwrhTC_ycdh9Ivt-NWoHOKa7Tv3342DgDYJykDJJWmQYDRu0uKMzqYDASESVxexItmZf2STtXhwgDMi7coiQdtKoHnFqEu8ncMj9KSYMNl5VGDjWY77raPrT5247hLMS7rw";
        //public const String LOGIN_USERNAME_FRIENDS2 = "autofriends2@yopmail.com";
        public const String LOGIN_PASSWORD_FRIENDS2 = "P@ssword.1";

        // Token TestCloud (Social tests only)
        public const String LOGIN_USERNAME_FRIENDS3 = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6Ilg1ZVhrNHh5b2pORnVtMWtsMll0djhkbE5QNC1jNTdkTzZRR1RWQndhTmsifQ.eyJpc3MiOiJodHRwczovL2xvZ2luLm1pY3Jvc29mdG9ubGluZS5jb20vYTc5ZDNlZTItMzBjMy00Y2VkLWI0NDUtYWJmYjA0MzdiMDRhLyIsImV4cCI6MTQ5OTMzODA2OSwibmJmIjoxNDk5MjUxNjY5LCJhdWQiOiJodHRwczovL3JtYWRkZXYub25taWNyb3NvZnQuY29tL3dlYmFwaSIsIm9pZCI6IjY5MWQxM2U5LTRhNWYtNGJjZi1hMWFiLWUwNTdiYzA4MGZiMCIsImV4dGVuc2lvbl9DcGltX0xhbmd1YWdlIjoiZXMtZXMiLCJzdWIiOiJOb3Qgc3VwcG9ydGVkIGN1cnJlbnRseS4gVXNlIG9pZCBjbGFpbS4iLCJub25jZSI6ImRlZmF1bHROb25jZSIsInZlciI6IjEuMCJ9.S-Ab7n1vE73YnWbYyKX3qxo-WeB45hvxgpPvKW6VxDbsJTnbVTOcHHBrPdNwrAGz0GoVnsCn81r6S0mVEMchZzO_U1LimY5mngRRtHQA3CuHnTyAG6JL5MBOMDZeVZFbNy5M0AAC2ilgyIxHGxFAhSkTgheAC88lGw__r31PpRLkzT4rT20ZHfASd6pFRW_x_no22ds-_0GOP7mjdAm4DmebXaWZi7WUzUtZTZFZdLBAwbSSEp6SmX0azRZioAjoSnwpVT2gfwTbUA9QGVBggpA-XzGfVEQ05qtGGznm5Fu0fk7KzL04F9_DPdbOytBJCzg96uUIrIrT_CGTFI1fTg";
        //public const String LOGIN_USERNAME_FRIENDS3 = "autofriends3@yopmail.com";
        public const String LOGIN_PASSWORD_FRIENDS3 = "P@ssword.1";

        public const String LOGIN_USERNAME2 = "longestemailaddress01234567890@gmail.com";
        public const String LOGIN_PASSWORD2 = "aA0$123456789012";
        public const String LOGIN_USERNAME_EMPTY = "";
        public const String LOGIN_PASSWORD_EMPTY = "";
        public const String LOGIN_USERNAME_INCORRECT = "incorrect@gmail.com";
        //public const String LOGIN_GOOGLE = "ustapks1";
        //public const String PASSWORD_GOOGLE = "ustTest1";
        public const String LOGIN_GOOGLE = "msrmqa01";
        public const String PASSWORD_GOOGLE = "P@ssword.1";
        public const String LOGIN_FACEBOOK = "ustapks1@gmail.com";
        public const String PASSWORD_FACEBOOK = "ustTest1";
        public const String LOGIN_USERNAME_OLD = "qadevios5@yopmail.com";
        public const String LOGIN_PASSWORD_OLD = "P@ssword.2";
        public const String LOGIN_PASSWORD_NOT_VALIDATED = "Ustapks1";



        /*MAIN MENU*/
        public const String MAIN_MENU_VIEW = "design_navigation_view";
        public const String MAIN_MENU_FINDER = "Finder (ES)";
        public const String MAIN_MENU_VIEW_AVATAR = "drawer";
        public const String MAIN_MENU_AVATAR = "avatar";
        public const String MAIN_MENU_NEWS = "Noticias";

        /*FINDER*/
        public const String FINDER_MENU_TITLE = "BUSCADOR";
        public const String FINDER_TEAMNAME_ID = "teamName";


        /*PROFILE*/
        public const String PROFILE_NICKNAME = "AutoTester";
        public const String PROFILE_NAME = "Qa";
        public const String PROFILE_SURNAME = "Test";

        /*PROFILE MORE INFO*/
        public const String PROFILE_RANDOM = "lkjhgñÇ23456ª!·$% &*¨{{¬apa`siuhfjùwhegfsdnm$/5667~€¬{{}*¨Ç*";
        public const String PROFILE_ZIP_ZAMORA = "49070";
        public const String PROFILE_ZIP_MADRID = "28000";
        public const String PROFILE_CITY_ZAMORA = "ZAMORA";

        /* SETTINGS */
        public const String MAIN_MENU_NEWS_EN = "News";
        public const String MAIN_MENU_SHOP_IN = "Toko";
        public const String MAIN_MENU_SHOP_AR = "المتجر";

        /* CHECKIN */
        public const String CHECKIN_POPUP_MESSAGE = "El dispositivo no ha podido determinar su ubicación actual. ¿Quieres ir a 'Ajustes de ubicación'?";

        /* INBOX */
        public const String INBOX_DELETE_TEXT = "¿Estás seguro de borrar este mensaje?";
        public const String INBOX_MESSAGE_CHECK = "check";

        /* FRIENDS */
        public const String FRIENDS_NO_MSG = "Esta sección está muy vacía, accede a la sección de amigos para añadir nuevos";

        /*PLAYLIST*/
        public const String PLAYLIST_SUBSCRIPTION_QA_TEST1_I = "Vídeo Subscription QA test1 (I)";
        public const String PLAYLIST_SUBSCRIPTION_QA_TEST1_II = "Video Subscription QA test1 (II)";
        public const String PLAYLIST_NON_SUBSCRIPTION_GOL_LUCAS_VAZQUEZ = "Video Prueba - Gol de Lucas Vazquez min 51)";


        /* MEMBER */
        public const String MEMBERS_PIN = "123456";
        public const String STATUS_NOTGIVEN = "NO CEDIDO";
        public const String STATUS_SOLD = "VENDIDO";
        public const String STATUS_NOTSOLD = "NO VENDIDO";

        //Usuario con carné madridista con acceso al botón "Ceder asiento"         
        public const String LOGIN_USERNAME3 = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6Ilg1ZVhrNHh5b2pORnVtMWtsMll0djhkbE5QNC1jNTdkTzZRR1RWQndhTmsifQ.eyJpc3MiOiJodHRwczovL2xvZ2luLm1pY3Jvc29mdG9ubGluZS5jb20vYTc5ZDNlZTItMzBjMy00Y2VkLWI0NDUtYWJmYjA0MzdiMDRhLyIsImV4cCI6MTQ5OTI0NTA4OCwibmJmIjoxNDk5MTU4Njg4LCJhdWQiOiJodHRwczovL3JtYWRkZXYub25taWNyb3NvZnQuY29tL3dlYmFwaSIsIm9pZCI6ImJjNTY0ZTQwLWNjZDAtNDcwOS1iMTQ3LWU1YTVjMmFlYTdlZSIsImV4dGVuc2lvbl9DcGltX0xhbmd1YWdlIjoiZXMtZXMiLCJzdWIiOiJOb3Qgc3VwcG9ydGVkIGN1cnJlbnRseS4gVXNlIG9pZCBjbGFpbS4iLCJub25jZSI6ImRlZmF1bHROb25jZSIsInZlciI6IjEuMCJ9.lSDexR9yN3jcLlO7X0CS-Hs3lsNx7bcQ3I9LYIzoq676QLY34jwpwKi0OyGk_9wEPl1zxA8NByNFb10PRvClo-fOmR2cmLd9uJ__O4ArIG6gsuWUZgcViDSLv7vUQubjfn7wwuEPVdWd1PY7igQ_BPk9z7VBM2TmoadbZQhNkPvh8dbQuAa8WRfBJ5mtPBZfzJpULpk78Mhj-Ww1F31V9mayf125v8n7U9vzdNWShwHFOhkB-K6A5GWPyLXEvZb8OtxPv_Kqhw3JyHjgoQ6KITeTEGBOU19XMLg6M2LOjj-A-c3WbfSLjQmw0YrG52KRsLdZzagMmiWU9ks4gQ0eeA";
        //public const String LOGIN_USERNAME3 = "qadevios8@yopmail.com";
        public const String LOGIN_PASSWORD3 = "P@ssword.1";

        //Usuario con carne madridista con boton "Cede asiento" e historial         
        public const String LOGIN_USERNAME4 = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6Ilg1ZVhrNHh5b2pORnVtMWtsMll0djhkbE5QNC1jNTdkTzZRR1RWQndhTmsifQ.eyJpc3MiOiJodHRwczovL2xvZ2luLm1pY3Jvc29mdG9ubGluZS5jb20vYTc5ZDNlZTItMzBjMy00Y2VkLWI0NDUtYWJmYjA0MzdiMDRhLyIsImV4cCI6MTQ5OTI0ODA0NCwibmJmIjoxNDk5MTYxNjQ0LCJhdWQiOiJodHRwczovL3JtYWRkZXYub25taWNyb3NvZnQuY29tL3dlYmFwaSIsIm9pZCI6IjJiNTkzNmJjLTgxYzgtNDg1Ni1iZDJmLTU3YmJlMzQwYjM0NCIsImV4dGVuc2lvbl9DcGltX0xhbmd1YWdlIjoiZXMtZXMiLCJzdWIiOiJOb3Qgc3VwcG9ydGVkIGN1cnJlbnRseS4gVXNlIG9pZCBjbGFpbS4iLCJub25jZSI6ImRlZmF1bHROb25jZSIsInZlciI6IjEuMCJ9.VODCJG-nFNPMaWAYem388vLldH0AWFeSNdumnmLVW1-r_4i17YqGR2qSqGlU3Df-QQ1a2bgRi7YDzVodPNXZbW4i2grSVVy7Pq2SNw64iNGtgV5KI7R8d9H8rnD6-xpJZZSkNJs2qZPPL-P__7slLNpDG0iDTC5LQ1l-FyZWWj9gDSXRVE6OLxIFO5AtXUBy0NrdXKnti14Jihw894TtZpsnrMRctJ7F-RNXqKZd0cWm0kLJvM5dIHp0YaUTHVtlhfYdppYaWzbDoHfKwzmi34xzm0HHRWJp7iRtKb0O5cfN5lLzqZiMFmNvf6YwcEZlJ6b2HJoE0M_JWjPw3pFUNQ";
        //public const String LOGIN_USERNAME4 = "rmappmember5003@yopmail.com";  
        public const String LOGIN_PASSWORD4 = "P@ssword.1";

        //Usuario sin carné linkado         
        public const String LOGIN_USERNAME5 = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6Ilg1ZVhrNHh5b2pORnVtMWtsMll0djhkbE5QNC1jNTdkTzZRR1RWQndhTmsifQ.eyJpc3MiOiJodHRwczovL2xvZ2luLm1pY3Jvc29mdG9ubGluZS5jb20vYTc5ZDNlZTItMzBjMy00Y2VkLWI0NDUtYWJmYjA0MzdiMDRhLyIsImV4cCI6MTQ5OTI0ODE3NSwibmJmIjoxNDk5MTYxNzc1LCJhdWQiOiJodHRwczovL3JtYWRkZXYub25taWNyb3NvZnQuY29tL3dlYmFwaSIsIm9pZCI6IjZmMTBlZTg3LWYyZmYtNDE0NS1hYWRjLTc2MjkxZWU5OGM0NyIsImV4dGVuc2lvbl9DcGltX0xhbmd1YWdlIjoiZXMtZXMiLCJzdWIiOiJOb3Qgc3VwcG9ydGVkIGN1cnJlbnRseS4gVXNlIG9pZCBjbGFpbS4iLCJub25jZSI6ImRlZmF1bHROb25jZSIsInZlciI6IjEuMCJ9.LM6rC9rbQG4yo0aOfztouwzBWpXnptTneJq6jLSuyRkKtYqHoGiBS1nQEMvJed5CWFZCATtozurSfwQhlTPiTIHUklaf-HiHLDSArSw6ChgzglqVlYfsY3mK1IBJ_hUl6GlNxmIufEbp4UnxsczVrpcSYetouEp7fk2dLLUzmZRRGU8WChvaapZdVV8qFlt4N7LpGdywlD2OyEbE5HVRfgIsM74dMb7FtU910t7Z3Xx_jhdV6QzskFiUBv5uSLqX1lNhK-0oawarKqlryAnQXIzyII3C151NAqX2BC78GOlWdP9O-L5m1mJlaVhsHdxQXAmdRPLVklyp5HnbZaMPRg";
        //public const String LOGIN_USERNAME5 = "rmappmember5011@yopmail.com";
        public const String LOGIN_PASSWORD5 = "P@ssword1.";

        //Usuario Socio infantil         
        public const String LOGIN_USERNAME6 = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6Ilg1ZVhrNHh5b2pORnVtMWtsMll0djhkbE5QNC1jNTdkTzZRR1RWQndhTmsifQ.eyJpc3MiOiJodHRwczovL2xvZ2luLm1pY3Jvc29mdG9ubGluZS5jb20vYTc5ZDNlZTItMzBjMy00Y2VkLWI0NDUtYWJmYjA0MzdiMDRhLyIsImV4cCI6MTQ5OTI0ODI5NSwibmJmIjoxNDk5MTYxODk1LCJhdWQiOiJodHRwczovL3JtYWRkZXYub25taWNyb3NvZnQuY29tL3dlYmFwaSIsIm9pZCI6IjJlM2Q0NThjLTkyNjYtNGYxMi1iMmJlLWI5N2VkOGJiYWY3YiIsImV4dGVuc2lvbl9DcGltX0xhbmd1YWdlIjoiZXMtZXMiLCJzdWIiOiJOb3Qgc3VwcG9ydGVkIGN1cnJlbnRseS4gVXNlIG9pZCBjbGFpbS4iLCJub25jZSI6ImRlZmF1bHROb25jZSIsInZlciI6IjEuMCJ9.SUBf5bbo7vJGt5yj0iZsT9oQyddpbykOIsR4Pmmt0rUhOiptFrXpNuJHRPZZDarM63p-pdAPewfJQL4LZCT7dCyHWkgt-DXtcvUlAl1XYD4YlteCwHK-49HDwQHxDgP07ciquwSctuvBaUZS6jR54w8l634diBTOf7F4B0-__e-IebycQigJXJl5gGz6CxM8Ql-ZFqbCDUyyeu9Nb5nSFNKNjld6RwKMpY48cR88mAq73CKNSZNG9MT11SUT5g8HXWMP7KIQGPtMU8yVpvUYS5dEnAseXfgPoEOW4PXZYWnatO6xiXBK45LHc0TEDodG4dW1-08XJW8DUIh3uhRYsg";
        //public const String LOGIN_USERNAME6 = "rmappmember59696@yopmail.com"; 
        public const String LOGIN_PASSWORD6 = "P@ssword.1";

        //Usuario Socio adulto  
        public const String LOGIN_USERNAME7 = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6Ilg1ZVhrNHh5b2pORnVtMWtsMll0djhkbE5QNC1jNTdkTzZRR1RWQndhTmsifQ.eyJpc3MiOiJodHRwczovL2xvZ2luLm1pY3Jvc29mdG9ubGluZS5jb20vYTc5ZDNlZTItMzBjMy00Y2VkLWI0NDUtYWJmYjA0MzdiMDRhLyIsImV4cCI6MTQ5OTI0ODU0MSwibmJmIjoxNDk5MTYyMTQxLCJhdWQiOiJodHRwczovL3JtYWRkZXYub25taWNyb3NvZnQuY29tL3dlYmFwaSIsIm9pZCI6IjUyYjRhY2VkLTc1NDctNDA1OS1hMDkxLWFmZTk0N2IyZTcyMyIsImV4dGVuc2lvbl9DcGltX0xhbmd1YWdlIjoiZXMtZXMiLCJzdWIiOiJOb3Qgc3VwcG9ydGVkIGN1cnJlbnRseS4gVXNlIG9pZCBjbGFpbS4iLCJub25jZSI6ImRlZmF1bHROb25jZSIsInZlciI6IjEuMCJ9.BgTdlRajrb6vW0DQyy73C_84DRrjL2QqWeQZpVuPT9pKrgc_d6rHR8nb68oOhU9tCMx-Jgg1bkW_K5w71ZTiZ3VD3Hw7ExgyU0BtPIIG8xAIosH3oYQ9wdqCSUtTrtMMHfSaT0pUR49VAl5x3XRAtFE9rLC9k3eFqapIJ7uAJYoqXRDfDZ1V23q4SjOiAQHtmIBCn18MbGtlw8hw9fvC1fU3LI4Gg88nRPuxeFNYFhAGKKfEQHnnWzCU8hu7YE8zfJruxaXyU2F0XIQldH5IxZNvTsEqFXMOMNSDbS8IGu7iqeInCTktuSm2HGSGqsDxITtkVtBTDUdkXGSh1Pb8gg";
        //public const String LOGIN_USERNAME7 = "rmappmember63983@yopmail.com";         
        public const String LOGIN_PASSWORD7 = "P@ssword.1";

        //Usuario Socio adulto representante  
        public const String LOGIN_USERNAME8 = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6Ilg1ZVhrNHh5b2pORnVtMWtsMll0djhkbE5QNC1jNTdkTzZRR1RWQndhTmsifQ.eyJpc3MiOiJodHRwczovL2xvZ2luLm1pY3Jvc29mdG9ubGluZS5jb20vYTc5ZDNlZTItMzBjMy00Y2VkLWI0NDUtYWJmYjA0MzdiMDRhLyIsImV4cCI6MTQ5OTI0ODY0MywibmJmIjoxNDk5MTYyMjQzLCJhdWQiOiJodHRwczovL3JtYWRkZXYub25taWNyb3NvZnQuY29tL3dlYmFwaSIsIm9pZCI6IjIzZDExMmExLTIwNjUtNGFiMi1hMTMxLTIwNzE0MmNmOTEyYSIsImV4dGVuc2lvbl9DcGltX0xhbmd1YWdlIjoiZXMtZXMiLCJzdWIiOiJOb3Qgc3VwcG9ydGVkIGN1cnJlbnRseS4gVXNlIG9pZCBjbGFpbS4iLCJub25jZSI6ImRlZmF1bHROb25jZSIsInZlciI6IjEuMCJ9.Vn9F0i3Dx5WR3b94GI8s4l_d-v3YWWdueZ8-U3f3_Z3OiB7o9HXIqWP4y7VataTE87V_Amaq3HzPYz3DWlAKvwZ86-ZnIQEhPqAnzv0U2ukHnjA9QJ7iMy0D6kqVcALGdtsYJZRykUy5A6wp3P9LGwiOsM21KYSQkHsuLG3VokwK2H3xCplQXb4U6BEPVqPYOcYEG2PF_zM2NhYkc-y1auhifzayfayR4HR76C_qbCzCii0q63Kamg51R8l_4uH1jk_5iHkohjBvFCbpbIaK_HrYkiIYFWhS9kKa8bXLK--QtxnQyZRTvUUeEXJR7wsQrHcDc4ecsMJIZdDMPfaZmg";
        //public const String LOGIN_USERNAME8 = "rmappmember53231@yopmail.com";        
        public const String LOGIN_PASSWORD8 = "P@ssword.1";

        //Usuario Socio de plata    
        public const String LOGIN_USERNAME9 = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6Ilg1ZVhrNHh5b2pORnVtMWtsMll0djhkbE5QNC1jNTdkTzZRR1RWQndhTmsifQ.eyJpc3MiOiJodHRwczovL2xvZ2luLm1pY3Jvc29mdG9ubGluZS5jb20vYTc5ZDNlZTItMzBjMy00Y2VkLWI0NDUtYWJmYjA0MzdiMDRhLyIsImV4cCI6MTQ5OTI0ODc1NywibmJmIjoxNDk5MTYyMzU3LCJhdWQiOiJodHRwczovL3JtYWRkZXYub25taWNyb3NvZnQuY29tL3dlYmFwaSIsIm9pZCI6IjgzZmU5NDU0LWM3MTUtNDFiZC1iOTkyLTYzY2Y4NWU4ZTNkMyIsImV4dGVuc2lvbl9DcGltX0xhbmd1YWdlIjoiZXMtZXMiLCJzdWIiOiJOb3Qgc3VwcG9ydGVkIGN1cnJlbnRseS4gVXNlIG9pZCBjbGFpbS4iLCJub25jZSI6ImRlZmF1bHROb25jZSIsInZlciI6IjEuMCJ9.RCja2_1xw4I6g5YeWgyL6fiMfsLnsYtHmc82DvnBEUCJJ2qWb3a6ucU3zbMT7hpnz-A4yAQx_BQyz9ia3iFtz-iYQC-6nqJCthsnrRabZ4UXW5FgUxsAXwmoNBVatD-8z50WiG99lKqV6rbJQL5ZafUauPGuNzRVzhoEIaDfO1rSPJbSXPGaBxMvHmsi9Xep3SVuGVAn7drqNUSqOIcKyOcVH4ghiM1iRRw2Qs990wvSuNj3mJN4hTVbiBrK69uD3hG6TvERJUZDwa1iCFPeDkc1XzDw0QjQNoWNW9DFQkqALrqH5A_DeULAOnVV6t56lNjv5DZcfobkNhGkVtxJow";
        //public const String LOGIN_USERNAME9 = "rmappmember21946@yopmail.com";         
        public const String LOGIN_PASSWORD9 = "P@ssword.1";

        //Usuario Socio de plata representante         
        public const String LOGIN_USERNAME10 = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6Ilg1ZVhrNHh5b2pORnVtMWtsMll0djhkbE5QNC1jNTdkTzZRR1RWQndhTmsifQ.eyJpc3MiOiJodHRwczovL2xvZ2luLm1pY3Jvc29mdG9ubGluZS5jb20vYTc5ZDNlZTItMzBjMy00Y2VkLWI0NDUtYWJmYjA0MzdiMDRhLyIsImV4cCI6MTQ5OTI0ODg5MywibmJmIjoxNDk5MTYyNDkzLCJhdWQiOiJodHRwczovL3JtYWRkZXYub25taWNyb3NvZnQuY29tL3dlYmFwaSIsIm9pZCI6ImJmNWVhNDZlLWNkN2MtNDgyYi05YjI1LTM1NTJiNjdlMmNhYiIsImV4dGVuc2lvbl9DcGltX0xhbmd1YWdlIjoiZXMtZXMiLCJzdWIiOiJOb3Qgc3VwcG9ydGVkIGN1cnJlbnRseS4gVXNlIG9pZCBjbGFpbS4iLCJub25jZSI6ImRlZmF1bHROb25jZSIsInZlciI6IjEuMCJ9.DlX1z-EY2ayW0U9qmkAAuCcpTcnZUig6YHMkPxPqWWh6EtRCqfdcv6KXT69eEgvMeVX5xdmb5BGzk_C8k1oWFLizMp5fyEgoC4BtT0fqp4A_oQKKE6IymI-k3Ik7YpleO_Eb2Nov_5Xl8f6_DGMqHeq2RPD3pc-lGRRYvYxZ8nWsg7kP0yxRpY0ecCbLXL-1HK02yrbmJJqqkHDi3S-Q_ZAlQLo82BfCHYaVFoyxc3hlzLnn4jDS065BzHTr3nlNcMyoqwQlUMOT1ZB3zBq4QM_ht-arLHVKZpzOxbzUhWffCfT6o8HAi2kNq9zbY2uriLdhR4cL6wgqOsgExrHXhA";
        //public const String LOGIN_USERNAME10 = "rmappmember21852@yopmail.com";
        public const String LOGIN_PASSWORD10 = "P@ssword.1";

        //Usuario Socio de oro     
        public const String LOGIN_USERNAME11 = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6Ilg1ZVhrNHh5b2pORnVtMWtsMll0djhkbE5QNC1jNTdkTzZRR1RWQndhTmsifQ.eyJpc3MiOiJodHRwczovL2xvZ2luLm1pY3Jvc29mdG9ubGluZS5jb20vYTc5ZDNlZTItMzBjMy00Y2VkLWI0NDUtYWJmYjA0MzdiMDRhLyIsImV4cCI6MTQ5OTI0OTAyNSwibmJmIjoxNDk5MTYyNjI1LCJhdWQiOiJodHRwczovL3JtYWRkZXYub25taWNyb3NvZnQuY29tL3dlYmFwaSIsIm9pZCI6Ijc4ZDYzYmJjLWVhNzAtNGUxMy05ZGJjLTk4NzQ0MjNmOTE5OSIsImV4dGVuc2lvbl9DcGltX0xhbmd1YWdlIjoiZXMtZXMiLCJzdWIiOiJOb3Qgc3VwcG9ydGVkIGN1cnJlbnRseS4gVXNlIG9pZCBjbGFpbS4iLCJub25jZSI6ImRlZmF1bHROb25jZSIsInZlciI6IjEuMCJ9.EJ9Y0qy9UAnPHx9vptYbjCoWRQz-vMDNxVceQFbG1rBt8kSCHS9FytkaQ1ovQsLPs3aw84igRFNCanm1Da2GKRdT7t-CVW4qcZ8eMKu97ILbP_VcWd16pCfeGwII0Jjqf-iIB0joo9xI1DlJHiZLQVuN5SkXQTDuGKvMHMds6N7BLZHy9QD546dbuO7l3Cw0Z6JqWOXZ3oLy-0WvqD8XsSaIs16Y7XHKa0uk2ewfgi5aPXGpCSCIO2r3aZV6pWENlduo6iE9XqS21SJqu1xsA4e7E_DBSeKR0eUUbacJ6rAtuci1alHF1mmPXalsYsNXyc2_2-6dHZJGzm8tr4Mh5g";
        //public const String LOGIN_USERNAME11 = "rmappmember3027@yopmail.com";         
        public const String LOGIN_PASSWORD11 = "P@ssword.1";

        //Usuario Socio de oro representante         
        public const String LOGIN_USERNAME12 = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6Ilg1ZVhrNHh5b2pORnVtMWtsMll0djhkbE5QNC1jNTdkTzZRR1RWQndhTmsifQ.eyJpc3MiOiJodHRwczovL2xvZ2luLm1pY3Jvc29mdG9ubGluZS5jb20vYTc5ZDNlZTItMzBjMy00Y2VkLWI0NDUtYWJmYjA0MzdiMDRhLyIsImV4cCI6MTQ5OTI0OTE2OSwibmJmIjoxNDk5MTYyNzY5LCJhdWQiOiJodHRwczovL3JtYWRkZXYub25taWNyb3NvZnQuY29tL3dlYmFwaSIsIm9pZCI6Ijg0MWUxYjFiLTg1ZmItNDBhOS1hMjkyLTE2NjM5MWE5NTljYyIsImV4dGVuc2lvbl9DcGltX0xhbmd1YWdlIjoiZXMtZXMiLCJzdWIiOiJOb3Qgc3VwcG9ydGVkIGN1cnJlbnRseS4gVXNlIG9pZCBjbGFpbS4iLCJub25jZSI6ImRlZmF1bHROb25jZSIsInZlciI6IjEuMCJ9.JUlvpcEmqqmQOP_Z0uo-6pPOqOKIo1fqdS-SwDt9Mz4aMp44iUZei3p7pWeErmUoOeY3xJiBSR1lZ5KNUgCE792auERZin6dpaD23L82FknhnZdX86na0wddUiF7OTqlqqyqsbXgUMaxQSBd6YKgO6N4_ZxRMmBzfMpEoyh_FIuqZ4FigPpjNwWAbyyf2yrpMfxONgvEcqHIuhq0B0ZrxaM_Pk-QnmC0GLpCQljb971TcixIDErjElayP82o--hwGxwJWuqj_kwkkvUdrraVIKIkRpVg2HZZ3uQzwRfg9lae5l7UapKvV_xGzS1rQZi4IcBVzPUhmfYYo2FqL6gvYw";
        //public const String LOGIN_USERNAME12 = "rmappmember3119@yopmail.com";
        public const String LOGIN_PASSWORD12 = "P@ssword.1";

        //Usuario Socio de diamante         
        public const String LOGIN_USERNAME13 = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6Ilg1ZVhrNHh5b2pORnVtMWtsMll0djhkbE5QNC1jNTdkTzZRR1RWQndhTmsifQ.eyJpc3MiOiJodHRwczovL2xvZ2luLm1pY3Jvc29mdG9ubGluZS5jb20vYTc5ZDNlZTItMzBjMy00Y2VkLWI0NDUtYWJmYjA0MzdiMDRhLyIsImV4cCI6MTQ5OTI0OTI3OCwibmJmIjoxNDk5MTYyODc4LCJhdWQiOiJodHRwczovL3JtYWRkZXYub25taWNyb3NvZnQuY29tL3dlYmFwaSIsIm9pZCI6ImNmYzFkOTBhLTc1YWQtNGQ3Yy04NTJhLTAwMDU4ZjVmYTczMiIsImV4dGVuc2lvbl9DcGltX0xhbmd1YWdlIjoiZXMtZXMiLCJzdWIiOiJOb3Qgc3VwcG9ydGVkIGN1cnJlbnRseS4gVXNlIG9pZCBjbGFpbS4iLCJub25jZSI6ImRlZmF1bHROb25jZSIsInZlciI6IjEuMCJ9.FlwEQTtEOxjQHkhqIVVDmkA-JNLkGOEmIOunx_qn56B8QxGNp0PVkpdoslzzeA8XmW3QMAw3CXK3uj_Zgp2iBrqEXLMgZyPzYisKEO8v1WFGOuxLaofDxY6tW5GRU-Pk7GOT9uZt5TNu9cAyHgnPJ9fbC1CdCviyl5pr0q1fxOCZnJLo8oTg7b-M_M7h4cNqkO3lznBxghbCyzI7iiCUT8mpTSfw0VTB2bSLr9OSN9ry-sGOjseI6Q9-WcPXdIV6xYecc65nNLPU0UHHz2yppYaAA5z1BElWEepT0vNCZJ-vGVgJwY__IoMB1bme2PqONw_LuotZyoHAyfBqhHHxFw";
        //public const String LOGIN_USERNAME13 = "rmappmember1645real@yopmail.com";  
        public const String LOGIN_PASSWORD13 = "P@ssword.1";

        //Usuario Socio de diamante representante         
        public const String LOGIN_USERNAME14 = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6Ilg1ZVhrNHh5b2pORnVtMWtsMll0djhkbE5QNC1jNTdkTzZRR1RWQndhTmsifQ.eyJpc3MiOiJodHRwczovL2xvZ2luLm1pY3Jvc29mdG9ubGluZS5jb20vYTc5ZDNlZTItMzBjMy00Y2VkLWI0NDUtYWJmYjA0MzdiMDRhLyIsImV4cCI6MTQ5OTI0OTQwOSwibmJmIjoxNDk5MTYzMDA5LCJhdWQiOiJodHRwczovL3JtYWRkZXYub25taWNyb3NvZnQuY29tL3dlYmFwaSIsIm9pZCI6ImExOGEzNTUzLTYxZDgtNDZiNi05YTM5LWEwZGE3MTM1ZjAzMSIsImV4dGVuc2lvbl9DcGltX0xhbmd1YWdlIjoiZXMtZXMiLCJzdWIiOiJOb3Qgc3VwcG9ydGVkIGN1cnJlbnRseS4gVXNlIG9pZCBjbGFpbS4iLCJub25jZSI6ImRlZmF1bHROb25jZSIsInZlciI6IjEuMCJ9.kLfRTG330hzmuQRBuDwA1x1io-ZS7gGNF2GetQunih9rXMt8RIJhTRH9SrmeMeZnPKttHce36advvO0Y4eSmEdMZ6tvaw3Xx0u-NTan66i-PWXK8Gbxk5L2l7RzXZpgue5030sX6mNXc5rGNr93KOehhH2lT2OD_L_D4lfzYa1m0BkIi0hfhWB_rIKhxKzgW8hVzPLX6yKGifngJqTwxi5xaqzVxhuK_FE77GFgmphQsNXvuKt7Ynyn-P0Yr3sc_e-1eW-1Z_zSRtlsR1aw5Z9vJY7KWYMdfwoYs0qGUylSOm0MUi8-L4U9mzLS2b4Rz4AaDnhYD6t3kbICemTp75Q";
        //public const String LOGIN_USERNAME14 = "rmappmember1609@yopmail.com";
        public const String LOGIN_PASSWORD14 = "P@ssword.1";

        //Numero de socio y pin erroneos         
        public const String ID_WRONG = "1234";
        public const String PIN_WRONG = "0000";
        public const String MEMBER_WRONG_MESSAGE = "Se ha producido un error al vincular su cuenta, inténtelo de nuevo más tarde.";

        /* COMPETITIONS */
        public const String LIGA_BBVA = "Liga BBVA";
        public const String CHAMPIONS = "Liga de Campeones";
        public const String INTERNATIONALCC = "Internacional Champions Cup";
    }

}
