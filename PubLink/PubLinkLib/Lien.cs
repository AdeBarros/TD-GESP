using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PubLinkLib
{
    // Représente un lien web
    public class Lien
    {
        public string Titre { get; private set; }
        public string Url { get; private set; }

        public Lien(string unTitre, string unUrl)
        {
            Titre = unTitre;
            if (!(unUrl.StartsWith("http://") || unUrl.StartsWith("https://")))
            {
                Url = "http://" + unUrl;
            }
            else
            {
                Url = unUrl;
            }
        }

        public override string ToString()
        {
            return Titre + " " + Url;
        }
    }
}
