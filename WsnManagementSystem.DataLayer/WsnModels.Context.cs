﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WsnManagementSystem.DataLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class WsnDbEntities : DbContext
    {
        public WsnDbEntities()
            : base("name=WsnDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Coordinator> Coordinators { get; set; }
        public virtual DbSet<County> Counties { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<DefinationOfSensorMeasurement> DefinationOfSensorMeasurements { get; set; }
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<Router> Routers { get; set; }
        public virtual DbSet<RouterSensor> RouterSensors { get; set; }
        public virtual DbSet<SensorMeasurement> SensorMeasurements { get; set; }
        public virtual DbSet<SensorMeasurementType> SensorMeasurementTypes { get; set; }
        public virtual DbSet<SensorNetwork> SensorNetworks { get; set; }
        public virtual DbSet<Sensor> Sensors { get; set; }
        public virtual DbSet<WsnDomain> WsnDomains { get; set; }
        public virtual DbSet<WsnStatu> WsnStatus { get; set; }
        public virtual DbSet<WsnCoordinator> WsnCoordinators { get; set; }
    }
}