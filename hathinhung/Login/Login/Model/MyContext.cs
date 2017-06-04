namespace Login.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MyContext : DbContext
    {
        public MyContext()
            : base("name=MyContext")
        {
        }

        public virtual DbSet<bomon> bomons { get; set; }
        public virtual DbSet<giaovien> giaoviens { get; set; }
        public virtual DbSet<hocsinh> hocsinhs { get; set; }
        public virtual DbSet<LOGIN> LOGINs { get; set; }
        public virtual DbSet<lophoc> lophocs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<bomon>()
                .Property(e => e.sodienthoai)
                .IsUnicode(false);

            modelBuilder.Entity<giaovien>()
                .Property(e => e.gioitinh)
                .IsUnicode(false);

            modelBuilder.Entity<giaovien>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<giaovien>()
                .Property(e => e.luongcoban)
                .HasPrecision(18, 0);

            modelBuilder.Entity<giaovien>()
                .HasMany(e => e.hocsinhs)
                .WithOptional(e => e.giaovien)
                .HasForeignKey(e => e.giaovienchunhiem);

            modelBuilder.Entity<giaovien>()
                .HasMany(e => e.lophocs)
                .WithOptional(e => e.giaovien)
                .HasForeignKey(e => e.giaovienday);

            modelBuilder.Entity<hocsinh>()
                .Property(e => e.diachi)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN>()
                .Property(e => e.USERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN>()
                .Property(e => e.PASSWORD)
                .IsUnicode(false);

            modelBuilder.Entity<lophoc>()
                .HasMany(e => e.hocsinhs)
                .WithOptional(e => e.lophoc)
                .HasForeignKey(e => e.lop);
        }
    }
}
