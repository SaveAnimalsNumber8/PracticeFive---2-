﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace PracticeFive.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SaveAnimalsEntities : DbContext
    {
        public SaveAnimalsEntities()
            : base("name=SaveAnimalsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tMember> tMember { get; set; }
        public virtual DbSet<tPosition> tPosition { get; set; }
        public virtual DbSet<tRescue> tRescue { get; set; }
        public virtual DbSet<tSpecies> tSpecies { get; set; }
        public virtual DbSet<tTransfer> tTransfer { get; set; }
        public virtual DbSet<tBlog> tBlog { get; set; }
        public virtual DbSet<tComment> tComment { get; set; }
        public virtual DbSet<FollowRescue> FollowRescue { get; set; }
        public virtual DbSet<FollowTransfer> FollowTransfer { get; set; }
    }
}
