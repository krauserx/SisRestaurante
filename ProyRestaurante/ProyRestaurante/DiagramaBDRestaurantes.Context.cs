//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyRestaurante
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BDRestaurantesEntities : DbContext
    {
        public BDRestaurantesEntities()
            : base("name=BDRestaurantesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TBL_EMPLEADOS> TBL_EMPLEADOS { get; set; }
        public virtual DbSet<TBL_CLIENTES> TBL_CLIENTES { get; set; }
        public virtual DbSet<TBL_INVENTARIO> TBL_INVENTARIO { get; set; }
        public virtual DbSet<TBL_SUCURSALES> TBL_SUCURSALES { get; set; }
        public virtual DbSet<TBL_PROVEEDORES> TBL_PROVEEDORES { get; set; }
        public virtual DbSet<TBL_PRODUCTOS> TBL_PRODUCTOS { get; set; }
        public virtual DbSet<TBL_MESAS> TBL_MESAS { get; set; }
    }
}
