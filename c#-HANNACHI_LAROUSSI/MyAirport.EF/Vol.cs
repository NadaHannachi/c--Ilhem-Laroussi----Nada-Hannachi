using SH.MyAirport.EF;
using System;
using System.Collections.Generic;

namespace MyAirport.EF
{
    /// Objet vol
    public class Vol
    {
        /// Id du vol
        public int VolId { get; set; }

        /// Compagnie effectuant le vol
        public string Cie { get; set; } 

        /// Destination du vol
        public string? Des { get; set; }

        /// Date de départ du vol
        public DateTime Dhc { get; set; }

        /// Immatricul du vol
        public string? Imm { get; set; }

        /// Ligne du vol
        public string Lig { get; set; }

        /// 
        public string? Pkg { get; set; }

        /// Nombre de personnes sur le vol
        public int? Pax { get; set; }

        /// Référence à la classe bagage
        public IEnumerable<Bagage> Bagages { get; set; }

        /// Création d'un vol vide
        public Vol() { }


        /// Création d'un vol avec param compagnie, Ligne du vol et datetime
        /// <param name="cie"></param>
        /// <param name="lig"></param>
        /// <param name="dhc"></param>
        public Vol(string cie, string lig, DateTime dhc)
        {
            Cie = cie;
            Lig = lig;
            Dhc = dhc;
            Bagages = new List<Bagage>(); 
        }
    }
}
