﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Samples.SqlServer.AdventureWorksService
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AdventureWorksEntities : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<vManufacturingInstructions> ManufacturingInstructions { get; set; }
        public virtual DbSet<vProductCatalog> ProductCatalog { get; set; }
        public virtual DbSet<vWorkOrderRouting> WorkOrderRouting { get; set; }
        public virtual DbSet<vCompanySales> CompanySales { get; set; }
        public virtual DbSet<vTerritorySalesDrilldown> TerritorySalesDrilldown { get; set; }
    }
}
