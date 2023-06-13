using CL_Bouteille;

namespace TestProjectBouteille
{
    [TestClass]
    public class UnitTestBouteille
    {
        [TestMethod]
        public void TestMethod_Bouteille_Instanciation()
        {
            Bouteille bTest = new Bouteille();
      
            Assert.IsTrue(bTest.NomBouteille == "Pepsi Max");
            Assert.IsTrue(bTest.MatiereBouteille == "Plastique");
            Assert.IsTrue(bTest.TypeNomContenuBouteille == "soda");
            Assert.IsTrue(bTest.ContenanceBouteilleEnLitres == 1.25);
            Assert.IsTrue(bTest.ContenuBouteilleEnLitres == 0.75);            
        }
  
        //meme test

        public void TestMethod_Bouteille_Ouvrir_EtatFermee_ReturnFalse()
        {
            Bouteille bFermee = new Bouteille();
            bool fermeeOk = bFermee.OuvrirBouteille();
            Assert.IsTrue(fermeeOk==true);
            Assert.IsTrue(bFermee.EstFermee==false);            
        }
        public void TestMethod_Bouteille_Ouvrir_EtatOuvert_ReturnTrue()
        {
            Bouteille bFermee = new Bouteille();
            bool fermeeOk = bFermee.FermerBouteille();
            Assert.IsTrue(fermeeOk==false);
            Assert.IsTrue(bFermee.EstFermee==true);
        }
        public void TestMethod_Bouteille_Fermer_EtatFermee_ReturnTrue()
        {
            Bouteille bFermee = new Bouteille();
            bool fermeeOk = bFermee.FermerBouteille();
            Assert.IsTrue(fermeeOk);
            Assert.IsTrue(bFermee.EstFermee==false);
        }
        public void TestMethod_Bouteille_Fermer_EtatOuvert
        

        

    }
}