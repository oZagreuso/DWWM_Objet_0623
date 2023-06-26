using CL_Voiture;
using CL_Voiture.ElementsVoiture;

namespace VoitureTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_Voiture_Instanciation()
        {
            Voiture vTest = new Voiture();
            Assert.IsTrue(vTest.MarqueVoiture == " Tesla ");
            Assert.IsTrue(vTest.SesQuatresRoues == new Roue[4] { new Roue(), new Roue(), new Roue(), new Roue() });
            Assert.IsTrue(vTest.SonMoteur == new Moteur());
        }
        [TestMethod]
        public void TestMethod_Voiture_Demarrer_Return_True()
        {
            Voiture vTestVoitureDemarrage = new Voiture();
            Assert.IsTrue(vTestVoitureDemarrage.Demarrer());
        }
        [TestMethod]
        public void TestMethod_Voiture_Eteindre_Return_True()
        {
            Voiture vTestVoitureEteindre = new Voiture();
            Assert.IsTrue(vTestVoitureEteindre.Eteindre());
        }
        [TestMethod]
        public void TestMethod_Voiture_Avancer_Return_True()
        {
            Voiture vTestVoitureAvancer = new Voiture();
            Assert.IsTrue(vTestVoitureAvancer.Avancer());
        }
    }
}