
using MyAirport.EF;
using System;
using System.Collections.Generic;
using System.Text;

namespace SH.MyAirport.EF
{
    /// Objet Bagage
    public class Bagage
    {
        /// Id clé primaire de l'objet bagage
        public int BagageId { get; set; }

        /// Vol associé au bagage
        public int? VolId { get; set; }

        /// CoddeIata du bagage, unique à un instant t
        public string CodeIata { get; set; }

        /// Date à laquelle le bagage a été créé par la compagnie
        public DateTime DateCreation { get; set; }

        /// Propriété de navigation
        public Vol? Vol { get; set; }

        /// Classe du passager (1ère, éco, business)
        public string? Classe { get; set; }

        /// Définit si le passager est considéré prioritaire lors de l'embarquement
        public bool? Prioritaire { get; set; }

        /// Statut du bagage
        public string? Sta { get; set; }

        /// Satatut User
        public string? Ssur { get; set; }

        /// Lieu de destination du vol
        public string? Destination { get; set; }

        /// Lieu de l'escale, s'il y en a une
        public string? Escale { get; set; }


        /// Création d'un bagage vide afin de pouvoir mettre les bagaes à null lors de la création d'un vol
        public Bagage() { }

        /// Création d'un bagage
        public Bagage(string codeIata, DateTime dateCreation)
        {
            CodeIata = codeIata;
            DateCreation = dateCreation;
        }

    }
}
