﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SocialWebApi.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SocialWebEntities : DbContext
    {
        public SocialWebEntities()
            : base("name=SocialWebEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ApplicationStatus> ApplicationStatus { get; set; }
        public virtual DbSet<Dialog> Dialog { get; set; }
        public virtual DbSet<DialogMessage> DialogMessage { get; set; }
        public virtual DbSet<DialogType> DialogType { get; set; }
        public virtual DbSet<DialogUsers> DialogUsers { get; set; }
        public virtual DbSet<Friends> Friends { get; set; }
        public virtual DbSet<Posts> Posts { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}
