using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestImmo.Modele
{
    class Logement
    {
        public byte[] Photo { get; set; }

        public string Nom { get; set; }

        public string Adresse { get; set; }

        public int Code_Postal { get; set; }

        public string Ville { get; set; }

        public string Taille { get; set; }

        public string Type_Logement { get; set; }

        public string Utilisation { get; set; }

        public int Annee_Construction { get; set; }

        public string Informations_Complementaires { get; set; }

        public string Regles_Fiscales { get; set; }

        public int Prix_Achat { get; set; }

        //Constructeur vide
        public Logement()
        {

        }

        //Constructeur complet
        public Logement(byte[] Photo, string Nom, string Adresse,
            int Code_Postal, string Ville, string Taille, string Type_Logement, 
            string Utilisation, int Annee_Construction, string Informations_Complementaires,
            string Regles_Fiscales, int Prix_Achat)
        {
            this.Photo = Photo;
            this.Nom = Nom;
            this.Adresse = Adresse;
            this.Code_Postal = Code_Postal;
            this.Ville = Ville;
            this.Taille = Taille;
            this.Type_Logement = Type_Logement;
            this.Utilisation = Utilisation;
            this.Annee_Construction = Annee_Construction;
            this.Informations_Complementaires = Informations_Complementaires;
            this.Regles_Fiscales = Regles_Fiscales;
            this.Prix_Achat = Prix_Achat;
        }

    }
}
