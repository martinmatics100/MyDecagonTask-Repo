using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MyHomePage.Data;

public partial class HotelDataBaseContext : DbContext
{
    public HotelDataBaseContext()
    {
    }

    public HotelDataBaseContext(DbContextOptions<HotelDataBaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Hotel> Hotels { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=MARTINMATICS; Database=HotelDataBase; Trusted_Connection=True; TrustServerCertificate=True; MultipleActiveResultSets=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Hotel>(entity =>
        {
            entity.HasKey(e => e.HotelId).HasName("PK__Hotel__17ADC492D949564C");

            entity.ToTable("Hotel");

            entity.Property(e => e.HotelId).HasColumnName("hotelID");
            entity.Property(e => e.HotelDescription)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("hotelDescription");
            entity.Property(e => e.HotelImageUrl)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("hotelImageURL");
            entity.Property(e => e.HotelLocation)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("hotelLocation");
            entity.Property(e => e.HotelName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("hotelName");
            entity.Property(e => e.HotelPopularity)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("hotelPopularity");
            entity.Property(e => e.HotelPrice)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("hotelPrice");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC0759F9E17F");

            entity.ToTable("users");

            entity.Property(e => e.DateCreation)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.Email)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Pwd)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
