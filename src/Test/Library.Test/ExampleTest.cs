using NUnit.Framework;
using roleplay;

namespace Test.Library
{
[TestFixture]
    public class Tests
    {

        [Test]
        public void ElvesTest() // En este Test se verifica si la clase elfos funciona correctamente, se testea si puede atacar y curar correctamente (tanto a otros como a si mismo) y si puede recibir ataques
        {
            Game TestGame = new Game();
            Elves LegolasTest = new Elves("TesteoLegolas", 50, 100, "Flechazo Debug", 100);
            Dwarf EnanoTest = new Dwarf("GimliTest", 50, 100, "Mi hacha", 100);
            TestGame.Atack(LegolasTest, EnanoTest);
            int hpexpected =  50;
            
            Assert.AreEqual(hpexpected, EnanoTest.Hp);

            TestGame.Heal(LegolasTest,EnanoTest);
            hpexpected = 100;

            Assert.AreEqual(hpexpected, EnanoTest.Hp);

            TestGame.Atack(EnanoTest, LegolasTest);
            hpexpected =  50;
            
            Assert.AreEqual(hpexpected, LegolasTest.Hp);    

            TestGame.Heal(LegolasTest,LegolasTest);
            hpexpected = 100;

            Assert.AreEqual(hpexpected, LegolasTest.Hp);
            

            
            
        }
        public void pruebaenanos()
        {
            Game TestGame = new Game();
            Dwarf Panza = new Dwarf("Fuerteychiquito",100,150,"patadamagica",170);
            Dwarf Peleador = new Dwarf("Elvaliente",150,180,"volar",170);
            TestGame.Atack(Panza, Peleador);
            int hpexpected =  130;
            Assert.AreEqual(hpexpected, Peleador.Hp);
            TestGame.Atack(Peleador, Peleador);
            var hpvolar =  70;
            Assert.AreEqual(hpexpected, Panza.Hp);
            //testeo de la clase enanos, verificación de que pueden atacar y recibir ataques los personajes
        }
    }
}