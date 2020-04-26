using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MyAirport.EF;
using System;
using System.Collections.Generic;
using System.Text;


namespace SH.MyAirport.EF
{
    /// Classe appelant les différentes méthodes en lien avec l'aéroport
    public class MyAirportContext : DbContext
    {
        
        /// Référence à MyAirportContext
        public MyAirportContext(DbContextOptions<MyAirportContext> options) : base(options) { }

        /// Référence à la classe bagage
        public DbSet<Vol>? Vols { get; set; }

        /// Référence à la classe bagage
        public DbSet<Bagage>? Bagages { get; set; }

     

    }

}
