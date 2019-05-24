using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PubLinkLib;

namespace PubLinkTest
{
    [TestClass]
    public class TestCollection
    {
        [TestMethod]
        public void TestCreerCollection()
        {
            Collection collection = new Collection();
            Lien exempleLien = new Lien("Example", "example.com");
            collection.Ajouter(exempleLien);
            Assert.AreEqual(1, collection.Compte);
            Assert.AreEqual(exempleLien.ToString(), collection.Get(0).ToString());
        }

        [TestMethod]
        public void TestSupprimerLienCollection()
        {
            Collection collection = new Collection();
            Lien exempleLien = new Lien("Example", "example.com");
            collection.Ajouter(exempleLien);
            collection.Supprimer(0);
            Assert.AreEqual(0, collection.Compte);
        }
    }
}
