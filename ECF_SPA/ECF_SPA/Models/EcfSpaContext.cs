﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ECF_SPA.Models;

public partial class EcfSpaContext : DbContext
{
    public EcfSpaContext()
    {
    }

    public EcfSpaContext(DbContextOptions<EcfSpaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Chat> Chats { get; set; }

    public virtual DbSet<Race> Races { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=CRM-UC-3617\\SQLEXPRESS2;User ID=sa;Password=!Nicolas01;Database=ECF_SPA;Trusted_Connection=False;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Chat>(entity =>
        {
            entity.HasKey(e => e.NumeroPuce).HasName("PK__CHATS__8100B327C837661B");

            entity.ToTable("CHATS");

            entity.Property(e => e.NumeroPuce)
                .ValueGeneratedNever()
                .HasColumnName("Numero_Puce");
            entity.Property(e => e.Nom)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Race).HasDefaultValueSql("((2))");

            entity.HasOne(d => d.RaceNavigation).WithMany(p => p.Chats)
                .HasForeignKey(d => d.Race)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RACES");
        });

        modelBuilder.Entity<Race>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RACES__3214EC27E69A9610");

            entity.ToTable("RACES");

            entity.HasIndex(e => e.Race1, "UQ__RACES__DF84295574CC656E").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Race1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Race");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
