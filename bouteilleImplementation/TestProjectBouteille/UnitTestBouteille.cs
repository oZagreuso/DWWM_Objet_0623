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
        [TestMethod]
        public void TestMethod_Bouteille_Ouvrir_EtatFermee_ReturnFalse()
        {
            Bouteille bFermee = new Bouteille();
            bool fermeeOk = bFermee.OuvrirBouteille();
            Assert.IsTrue(fermeeOk==true);//si la bouteille est fermée
            Assert.IsTrue(bFermee.EstFermee==false);//alors EstFermee est FAUX, on ne peut pas ouvrir la bouteille         
        }
        [TestMethod]
        public void TestMethod_Bouteille_Ouvrir_EtatOuvert_ReturnTrue()
        {
            Bouteille bFermee = new Bouteille();
            bool fermeeOk = bFermee.FermerBouteille();
            Assert.IsTrue(fermeeOk==false);//si la bouteille est ouverte
            Assert.IsTrue(bFermee.EstFermee==true);//alors EstFermee est VRAI, on peut ouvrir la bouteille
        }
        [TestMethod]
        public void TestMethod_Bouteille_Fermer_EtatFermee_ReturnFalse()
        {
            Bouteille bFermee = new Bouteille();
            bool fermeeOk = bFermee.FermerBouteille();
            Assert.IsTrue(fermeeOk);//si la bouteille est fermée
            Assert.IsTrue(bFermee.EstFermee==false);//alors EstFermee est FAUX, on ne peut pas fermer la bouteille
        }
        [TestMethod]
        public void TestMethod_Bouteille_Fermer_EtatOuvert_ReturnTrue()
        {
            Bouteille bFermee = new Bouteille();
            bool fermeeOk = bFermee.FermerBouteille();
            Assert.IsTrue(!fermeeOk);//si la bouteille est ouverte
            Assert.IsTrue(bFermee.EstFermee==true);//alors EstFermee est VRAI, on peut fermer la bouteille
        }
        [TestMethod]
        public void TestMethod_Bouteille_RemplirTout_EtatFermee_ReturnFalse()
        {
            Bouteille bFermee = new Bouteille();
            bool fermeeOk = bFermee.RemplirTout();
            Assert.IsTrue(!(fermeeOk));//si la bouteille est ouverte
            Assert.IsTrue(bFermee.EstFermee == false);
        }              
    }
}