using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.models
{
    public class Serveur
    {
        int chiffreAffaire;
        int commande;

        public int ChiffreAffaire { get => chiffreAffaire; set => chiffreAffaire = value; }
        public int Commande { get => commande; set => commande = value; }
    }
}
