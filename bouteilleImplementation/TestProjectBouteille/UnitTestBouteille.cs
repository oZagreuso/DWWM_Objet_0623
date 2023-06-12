using CL_Bouteille;

namespace TestProjectBouteille
{
    [TestClass]
    public class UnitTestBouteille
    {
        [TestMethod]
        public void TestMethod_Bouteille_Instanciation()
        {
            Bouteille bNom = new Bouteille();
          
     
            Assert.AreEqual(bNom.NomBouteille(), "Pepsi Max", true);



        }
        public void TestMethod_Bouteille_get_matiereBouteille()
        {
            Bouteille bMatiere = new Bouteille();
            string matiereBouteille = bMatiere.GetMatiereBouteille();
            Assert.IsNotNull(matiereBouteille);
        }
        public void TestMethod_Bouteille_get_contenanceBouteilleEnLitres()
        {
            Bouteille bContenanceEnLitres = new Bouteille();
            double contenanceBouteilleEnLitres = bContenanceEnLitres.GetContenanceBouteilleEnLitres();
            Assert.IsNotNull(contenanceBouteilleEnLitres);
        }
        public void TestMethod_Bouteille_get_contenuBouteilleEnLitres()
        {
            Bouteille bContenuEnLitres = new Bouteille();
            double contenuBouteilleEnLitres = bContenuEnLitres.GetContenuBouteilleEnLitres();
            Assert.IsNotNull(contenuBouteilleEnLitres);
        }
        public void TestMethod_Bouteille_get_typeNomContenuBouteille()
        {
            Bouteille bNomContenu = new Bouteille();
            string typeNomContenuBouteille = bNomContenu.GetTypeNomContenuBouteille();
            Assert.IsNotNull(typeNomContenuBouteille);
        }

        //meme test

        public void TestMethod_Bouteille_Ouvrir_EtatFermee_ReturnTrue()
        {
            Bouteille bFermee = new Bouteille();

            bool f = bFermee.EstFermee;


            bool ok = bFermee.OuvrirBouteille();
            Assert.IsTrue(ok==true);
            Assert.IsTrue(bFermee.EstFermee==false);
        }
    }
}