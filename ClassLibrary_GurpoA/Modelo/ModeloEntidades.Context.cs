//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary_GurpoA.Modelo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB_CustomerTestDBEntities : DbContext
    {
        public DB_CustomerTestDBEntities()
            : base("name=DB_CustomerTestDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Ctr_Customer> Ctr_Customer { get; set; }
        public virtual DbSet<Ctr_Persona> Ctr_Persona { get; set; }
        public virtual DbSet<Ctr_Rol> Ctr_Rol { get; set; }
        public virtual DbSet<Ctr_User> Ctr_User { get; set; }
    }
}
