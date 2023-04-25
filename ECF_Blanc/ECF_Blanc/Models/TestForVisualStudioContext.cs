using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ECF_Blanc.Models;

public partial class TestForVisualStudioContext : DbContext
{
    public TestForVisualStudioContext()
    {
    }

    public TestForVisualStudioContext(DbContextOptions<TestForVisualStudioContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Develloper> Devellopers { get; set; }

    public virtual DbSet<Game> Games { get; set; }

    public virtual DbSet<GameType> GameTypes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=CRM-UC-3617\\SQLEXPRESS2;User ID=sa;Password=!Nicolas01;Database=TestForVisualStudio;Trusted_Connection=False;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Develloper>(entity =>
        {
            entity.HasKey(e => e.DevId).HasName("PK__devellop__8AB61FA1668C80AD");

            entity.ToTable("develloper");

            entity.Property(e => e.DevId).HasColumnName("dev_ID");
            entity.Property(e => e.DevName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("dev_name");
        });

        modelBuilder.Entity<Game>(entity =>
        {
            entity.HasKey(e => e.GameId).HasName("PK__games__FFE0138783F25DA7");

            entity.ToTable("games");

            entity.Property(e => e.GameId).HasColumnName("game_ID");
            entity.Property(e => e.DevId).HasColumnName("dev_ID");
            entity.Property(e => e.GameName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("game_name");
            entity.Property(e => e.GameTypeId).HasColumnName("game_type_ID");

            entity.HasOne(d => d.Dev).WithMany(p => p.Games)
                .HasForeignKey(d => d.DevId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_game_dev");

            entity.HasOne(d => d.GameType).WithMany(p => p.Games)
                .HasForeignKey(d => d.GameTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_game_type");
        });

        modelBuilder.Entity<GameType>(entity =>
        {
            entity.HasKey(e => e.GameTypeId).HasName("PK__game_typ__32711962C63D547B");

            entity.ToTable("game_type");

            entity.Property(e => e.GameTypeId).HasColumnName("game_type_ID");
            entity.Property(e => e.GameTypeName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("game_type_name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
