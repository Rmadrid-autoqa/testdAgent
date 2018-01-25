using NUnit.Framework;
using RealMadrid_UITest.Variables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace RealMadrid_UITest.Tests {
    //[TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]

    public class StatsTests
    {
        IApp madrid;
        Utilities utils;
        Platform platform;



        public StatsTests(Platform platform)
        {
            this.platform = platform;
        }



        [TestFixtureSetUp]
        public void BeforeAllTest()
        {

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

        [Test]
        //Check Player Stats
        public void Test_34474() {
            //Step 2: Go to Stats
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Estadísticas_but);
            //Step 3:  Click on PLAYERS tab
            madrid.Tap(StatsVars.jugadores_tab);
			madrid.WaitForElement(StatsVars.spinner_players);
			madrid.WaitForElement(StatsVars.cards_carrousel);
            Assert.True(utils.existsElement(StatsVars.spinner_players),"No se ve el ComboBox de LaLiga");
            Assert.True(utils.existsElement(StatsVars.cards_carrousel), "No se ve el Carrousel de jugadores");
            //Step 4:  Swipe and check all Player cards.
            //Este paso no se puede automatizar por que no se puede comprobar que el nombre es correcto
            //Step 5:  Click any player card
            //Este paso no se puede automatizar por que no se puede comprobar que la barra este remarcada y la informacion sea correcta
            //Step 6:  Click on VIEW MORE
            //Este paso no se puede automatizar por que no se puede comprobar que la informacion sea correcta
            //Step 7:  Click on combobox
            madrid.Tap(StatsVars.spinner_players);
            Assert.True(utils.existsElement(StatsVars.spinner_Liga), "No se ve en el ComboBox la Liga");
            Assert.True(utils.existsElement(StatsVars.spinner_Copa), "No se ve en el ComboBox la copa");
            Assert.True(utils.existsElement(StatsVars.spinner_Champions), "No se ve en el ComboBox la Champions");
            //Step 8:  Click on any competition
            //Este paso no se puede automatizar por que no se puede comprobar que la informacion sea correcta
        }

        private void Check_Stats(Func<AppQuery, AppQuery> lambda, String text)
        {
            int max = 0;
            while (!utils.existsElement(lambda) && max < 10)
            {
                madrid.ScrollDown(StatsVars.stats_container, ScrollStrategy.Gesture, 0.30, 500, true);
                max++;
            }
            Assert.True(utils.existsElement(lambda), text);
        }

        [Test]
        //Team stats statistics Football
        public void Test_34293()
        {
            //Step 2: Go to Stats
            utils.Access_Tab_Main_Menu(MainMenuVars.menu_Estadísticas_but);
            
            //Step 3:  Click on "Team stats"
            madrid.Tap(StatsVars.equipos_tab);
            Assert.True(utils.existsElement(StatsVars.estadísticas_Title), "No se muestra la pagina de Estadisticas");            
            Assert.True(utils.existsElement(StatsVars.spinner_team), "No se ve el ComboBox de LaLiga");
            Assert.True(utils.existsElement(StatsVars.spinner_Liga), "No se ve la liga seleccionada en el ComboBox");

            Check_Stats(StatsVars.defensa, "No se muestra DEFENSA");
            Check_Stats(StatsVars.intercepciones, "No se muestra INTERCEPCIONES");
            Check_Stats(StatsVars.despejes, "No se muestra DESPEJES");
            Check_Stats(StatsVars.entradas, "No se muestra ENTRADAS");
            Check_Stats(StatsVars.duelos, "No se muestra DUELOS");

            Check_Stats(StatsVars.pases, "No se muestra PASES");
            Check_Stats(StatsVars.pases_completados, "No se muestra PASES COMPLETADOS %");
            Check_Stats(StatsVars.pases_campo_propio, "No se muestra PASES CAMPO PROPIO");
            Check_Stats(StatsVars.pases_campo_contrario, "No se muestra PASES CAMPO CONTRARIO");
            Check_Stats(StatsVars.cortes, "No se muestra CORTES %");

            Check_Stats(StatsVars.ataque, "No se muestra ATAQUE");
            Check_Stats(StatsVars.oportunidades, "No se muestra OPORTUNIDADES DE GOL");
            Check_Stats(StatsVars.disparos, "No se muestra DISPAROS %");
            Check_Stats(StatsVars.goles_disparos, "No se muestra GOLES / DISPAROS %");

            //Step 4:  Click on combobox
            madrid.Tap(StatsVars.spinner_team);
            Assert.True(utils.existsElement(StatsVars.spinner_Liga), "No se ve en el ComboBox la Liga");
            Assert.True(utils.existsElement(StatsVars.spinner_Copa), "No se ve en el ComboBox la copa");
            Assert.True(utils.existsElement(StatsVars.spinner_Champions), "No se ve en el ComboBox la Champions");
            //Step 5:  Click on "Champions League".
            madrid.Tap(StatsVars.spinner_Champions);
            Assert.True(utils.existsElement(StatsVars.spinner_Champions), "No se ve la Champions seleccionada en el ComboBox");
            //Step 5:  Click on "+View more"
			utils.Sleep(3);
			madrid.WaitForElement(StatsVars.ver_mas_but);
            Assert.True(utils.existsElement(StatsVars.ver_mas_but),"No se ve + Ver Más de LaLiga");
			madrid.ScrollDownTo(StatsVars.ver_mas_but);
			madrid.Tap(StatsVars.ver_mas_but);
            Check_Stats(StatsVars.ver_menos_but, "no se ve el boton - VER MENOS");

        }


    }
}
