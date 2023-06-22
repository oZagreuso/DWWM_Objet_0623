using CL_Voiture;
using CL_Voiture.ElementsVoiture;

namespace VoitureTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodVoitureInstanciation()
        {
            Voiture vTest = new Voiture();
            Assert.IsTrue(vTest.MarqueVoiture == " Tesla ");
            Assert.IsTrue(vTest.SesQuatresRoues == new Roue[4] { new Roue(), new Roue(), new Roue(), new Roue() });
            Assert.IsTrue(vTest.SonMoteur == new Moteur());
        }
    }
}