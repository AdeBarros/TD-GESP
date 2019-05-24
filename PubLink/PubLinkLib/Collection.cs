using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PubLinkLib
{
    // Représente une collection de liens web
    public class Collection
    {
        private List<Lien> _listeLiens;

        public Collection()
        {
            _listeLiens = new List<Lien>();
        }

        public int Compte
        {
            get { return _listeLiens.Count; }
        }

        public Lien Get(int indice)
        {
            return -1 < indice && indice < this.Compte ? _listeLiens.ElementAt(indice) : null;
        }

        public void Ajouter(Lien unLien)
        {
            _listeLiens.Add(unLien);
        }
        public void Supprimer(int indice)
        {
            var o = this.Get(indice);
            if (o != null)
                _listeLiens.Remove(o);
        }

        public override string ToString()
        {
            String r = "";
            
            if (this.Compte > 0)
            {
                for (int i = 0; i < this.Compte; i++)
                {
                    r += ((i + 1) + " : " + this.Get(i)) + "\n";
                }
            }
            else
            {
                r += "Aucun lien à afficher !\n";
            }

            return r;
        }
    }
}
