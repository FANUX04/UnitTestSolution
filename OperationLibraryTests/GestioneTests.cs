using Microsoft.VisualStudio.TestTools.UnitTesting;
using OperationLibrary;

namespace OperationTests
{
    [TestClass]
    public class GestioneTests
    {
        [TestMethod]
        public void SommaTestsPositivi()
        {
            int a = 3;
            int b = 4;
            int risultato_aspettato = 7;
            int risultato_effettivo = Gestione.Somma(a, b);
            Assert.AreEqual(risultato_aspettato, risultato_effettivo);
        }
        [TestMethod]
        public void SommaTestsNegativi()
        {
            int a = -3;
            int b = -2;
            int risultato_aspettato = -5;
            int risultato_effettivo = Gestione.Somma(a, b);
            Assert.AreEqual(risultato_aspettato, risultato_effettivo);
        }
        [TestMethod]
        public void SommaTestsNulli()
        {
            int a = 0;
            int b = 0;
            int risultato_aspettato = 0;
            int risultato_effettivo = Gestione.Somma(a, b);
            Assert.AreEqual(risultato_aspettato, risultato_effettivo);
        }
        [TestMethod]
        public void SommaTestsNullNeg()
        {
            int a = 0;
            int b = -4;
            int risultato_aspettato = -4;
            int risultato_effettivo = Gestione.Somma(a, b);
            Assert.AreEqual(risultato_aspettato, risultato_effettivo);
        }
        [TestMethod]
        public void SottrazioneTestsNullNeg()
        {
            int a = 0;
            int b = -4;
            int risultato_aspettato = 4;
            int risultato_effettivo = Gestione.Sottrzzione(a, b);
            Assert.AreEqual(risultato_aspettato, risultato_effettivo);
        }
        [TestMethod]
        public void SottrazzioneTestsNull()
        {
            int a = 0;
            int b = 0;
            int risultato_aspettato = 0;
            int risultato_effettivo = Gestione.Sottrzzione(a, b);
            Assert.AreEqual(risultato_aspettato, risultato_effettivo);
        }
        [TestMethod]
        public void SottrazzioneTestsNeg()
        {
            int a = -3;
            int b = -4;
            int risultato_aspettato = 1;
            int risultato_effettivo = Gestione.Sottrzzione(a, b);
            Assert.AreEqual(risultato_aspettato, risultato_effettivo);
        }
        [TestMethod]
        public void SottrazzioneTestsPos()
        {
            int a = 12;
            int b = 6;
            int risultato_aspettato = 6;
            int risultato_effettivo = Gestione.Sottrzzione(a, b);
            Assert.AreEqual(risultato_aspettato, risultato_effettivo);
        }
    
    }
}
