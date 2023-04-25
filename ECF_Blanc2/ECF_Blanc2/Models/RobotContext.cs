using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ECF_Blanc2.Models;

public partial class RobotContext : DbContext
{
    public RobotContext()
    {
    }

    public RobotContext(DbContextOptions<RobotContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Position> Positions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=CRM-UC-3617\\SQLEXPRESS2;User ID=sa;Password=!Nicolas01;Database=Robot;Trusted_Connection=False;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Position>(entity =>
        {
            entity.HasKey(e => e.RobotId).HasName("PK__position__70B82E3FBC9723B2");

            entity.ToTable("position");

            entity.Property(e => e.RobotId).HasColumnName("robot_ID");
            entity.Property(e => e.X).HasColumnName("x");
            entity.Property(e => e.Y).HasColumnName("y");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
