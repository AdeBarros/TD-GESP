using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PubLinkLib;

namespace PubLinkTest
{
    [TestClass]
    public class TestLien
    {
        [TestMethod]
        public void TestCreerLien()
        {
            string titre = "Wikipedia";
            string url = "http://wikipedia.org";

            Lien lien = new Lien(titre, url);

            Assert.AreEqual(titre, lien.Titre);
            Assert.AreEqual(url, lien.Url);
            Assert.AreEqual(titre + " " + url, lien.ToString());
        }

        [TestMethod]
        public void TestCreerLienSansProtocole()
        {
            string titre = "Wikipedia";
            string url = "wikipedia.org";

            Lien lien = new Lien(titre, url);

            Assert.AreEqual(titre, lien.Titre);
            Assert.AreEqual("http://" + url, lien.Url);
            Assert.AreEqual(titre + " http://" + url, lien.ToString());
        }
    }
}
