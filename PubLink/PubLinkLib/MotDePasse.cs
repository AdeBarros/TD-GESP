using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PubLinkLib
{
    public class MotDePasse
    {
        private String _mot;

        public String Mot
        {
            get { return this._mot; }
            private set
            {
                this._mot = value;
                if (!this.Verifie())
                    this.Completer();
            }
        }

        public MotDePasse(String mot, int tailleMin = 8)
        {
            this.Mot = mot;
        }

        private void Completer(int taille = 8)
        {
            String r = this._mot;
            Random rng = new Random();

            for (int c = 1; (r += c == 0 ? rng.Next('A', 'Z' + 1) : rng.Next(0, 10)).Length < taille; c = rng.Next(2))
                ;
            
            this._mot = r;
        }

        public bool Verifie(int taille = 8)
        {
            return this._mot.Length == taille && this._mot.Any(char.IsDigit);
        }
    }
}
