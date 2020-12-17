#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace samplebrowser.Models
{
    public partial class NORTHWNDContext : DbContext
    {
        public NORTHWNDContext(DbContextOptions<NORTHWNDContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Orders>(entity =>
            {
                entity.Property(e => e.OrderID).IsRequired();
            });

        }
        public virtual DbSet<Orders> Orders { get; set; }
    }
}
