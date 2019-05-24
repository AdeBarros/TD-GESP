using System;
using PubLinkLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PubLinkTest
{
    [TestClass]
    public class TestMotDePasse
    {
        [TestMethod]
        public void TestCreerMotDePasse()
        {
            MotDePasse mdp = new MotDePasse("coucou");

            Assert.AreEqual(8, mdp.Mot.Length);
            Assert.IsTrue(mdp.Verifie());
        }
    }
}
