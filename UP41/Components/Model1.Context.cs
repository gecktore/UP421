﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UP41.Components
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class UP421Entities : DbContext
    {
        public UP421Entities()
            : base("name=UP421Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Accessories> Accessories { get; set; }
        public virtual DbSet<AcessoriesImage> AcessoriesImage { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Document> Document { get; set; }
        public virtual DbSet<Equipment> Equipment { get; set; }
        public virtual DbSet<Material> Material { get; set; }
        public virtual DbSet<MaterialImage> MaterialImage { get; set; }
        public virtual DbSet<OperationSpecification> OperationSpecification { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<PerformTasks> PerformTasks { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductAccessories> ProductAccessories { get; set; }
        public virtual DbSet<ProductDetail> ProductDetail { get; set; }
        public virtual DbSet<ProductMaterial> ProductMaterial { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Size> Size { get; set; }
        public virtual DbSet<Standart> Standart { get; set; }
        public virtual DbSet<Storage> Storage { get; set; }
        public virtual DbSet<Street> Street { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TypeAccessories> TypeAccessories { get; set; }
        public virtual DbSet<TypeEquipment> TypeEquipment { get; set; }
        public virtual DbSet<TypeMaterial> TypeMaterial { get; set; }
        public virtual DbSet<Unit> Unit { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserImage> UserImage { get; set; }
        public virtual DbSet<UserTasks> UserTasks { get; set; }
    }
}
