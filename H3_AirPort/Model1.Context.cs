﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace H3_AirPort
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AirPortDbEntities : DbContext
    {
        public AirPortDbEntities()
            : base("name=AirPortDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Airline> Airline { get; set; }
        public virtual DbSet<AirportTerminal> AirportTerminal { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Flight> Flight { get; set; }
        public virtual DbSet<FlightRoute> FlightRoute { get; set; }
        public virtual DbSet<Operater> Operater { get; set; }
    }
}