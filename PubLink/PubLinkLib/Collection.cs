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

        public Lien Get(int indice)//Ajouter un test si oor
        {
            return _listeLiens.ElementAt(indice);
        }

        public void Ajouter(Lien unLien)
        {
            _listeLiens.Add(unLien);
        }
        public void Supprimer(int indice)
        {
            _listeLiens.Remove(this.Get(indice));
        }
    }
}
