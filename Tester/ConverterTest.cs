using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    [TestFixture]
    public class ConverterTest
    {
        public static IEnumerable<TestCaseData> Sources
        {
            get
            {
                List<TestCaseData> testCases = new List<TestCaseData>();
                for (int i = -10 ; i < 10; i++)
                {
                    testCases.Add(new TestCaseData(new object[] { i.ToString(),Convert.ToInt32(i.ToString()) }));
                }
                return testCases;
            }
        }

        //Dinamikus Teszt
        [TestCaseSource(nameof(Sources))]






        [TestCase("23",23)]
        [TestCase("0",0)]
        [TestCase("-5",-5)]
        public void ParseTest(string input,int expected)
        {
            int result = int.Parse(input);
            Assert.That(result, Is.EqualTo(expected));
        }


        /*
        [SetUp] -->Minden teszt előtt külön-külön lefut
        [TearDown] --> Minden teszteset után külön-külön lefut
        [OneTimeSetUp] --> Egyszer lefut minden előtt, aztán az összes teszt lefut
        [OneTimeTearDown] --> Miután lefuttot minden teszt, lefut egyszer
        [SetUpFixture] --> bruh.
         
        Tesztelés Alapelvek
            Gyorsak legyenek a tesztek --> ha lassúak, akkor nagyon fos a kód.
            Lehetőleg egymástól legyenek függetlenek
            Ránézésre olvasható legyen 
                Minden változó adja magát, hogy mit fog tesztelni
            Corner Case-eket teszteljük le elsősorban, nem szabad 
            MINDEN EGYES lehetőséget, gondold végig ha minden számmal akarnál tesztelni, lehetetlen
            Egyszerre egyetlen művelet, és egy osztály tesztelése
                mindig függetlenül az éles adattól, ami változtathat
                NEM SZABAD éles adatokkal tesztelni!, lehet elbasszuk az adatbázist
            
        Módszertanok
            
        Code-First
            Nehéz és nem hatékony
        Test-First
            Fejlesztő először teszteket ír meg
            Eközben tisztázódik sok követelménye a kódnak
        Test-Driver Developement (TDD)
            Először tesztek, mindegyik piros
            Kódolás közben teszteket futtatunk, egyre zöldebb lesz
            a kód így 100%-ban tesztelhető lesz
            
        Tesztlefedeettség
            Az alkalmazás hány %-át járták be az Unit tesztek?
            Minden elágazás lefutott?
            Végigment minden ciklus?
            Minden bool változó volt igaz és hamis is?
        akkor jó, ha legalább 80% a coverage, de felette igazából nem is a legjobb, szinte lehetetlen elérni 100%-ot
        vannak erre toolok
            dotCover <-- Féléves feladatban jó lenne használni
            NCover
            OpenCover

        Rétegzett alkalmazás tesztelése
            Mit kéne tesztelni??
                Repot? értelmetlen lenne.
                Entity FrameWorkot? --> rutinosabban tesztelték már.
                Console Appot? --> Sok Console.ReadLine függés miatt ez nem unit teszt lenne hanem UI teszt
                Logicot? 
                    Itt vannak hibakezelések, tesztelni kell
                    Lekérdezések --> tesztelni kell
                
        Mindig függetlenül az éles adattól
        
        logic tesztelése
            NUnit teszteli a metódusait
            elvárt eredményeket állít fel
            egy általa létrehozott ál-adatbáziból táplálja a logicot (FAKE)
            Logic nem tud róla, hogy tesztkörnyezetben van

        Fakek Létrehozása
            Készítünke egy FakeMovieRepot(Irepo<Movie>)
            Csak a ReadAll() metódusát implementáljuk
            ezt az implementációt a Unit test Projektben hozzuk létre
        Videóban vannak a kódok

        C:\Users\Wasman\Downloads\modul07.pdf-ban benne van a kód.

        Előnyök és Hátrányok
            E    
                Könnyű és gyors implementáció
                Egyszerű megértése
            H   
                Nagyon szennyezi a kódot

        MOCKOK LÉTREHOZÁSA
            Moq Framework kell hozzá
            


          

            

            
                
                    
       

            
            
         */
    }
}
