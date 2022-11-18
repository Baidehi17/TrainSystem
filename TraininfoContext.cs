using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TrainGR.Models;

public partial class TraininfoContext : DbContext
{
    public TraininfoContext()
    {
    }

    public TraininfoContext(DbContextOptions<TraininfoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Ticket> Tickets { get; set; }

    public virtual DbSet<Train> Trains { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=PUREBOOK-S14\\SQLEXPRESS; Database= Traininfo;Integrated Security=True;Encrypt=false;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ticket>(entity =>
        {
            entity.HasKey(e => e.PnrNumber).HasName("PK__ticket__F148D09FCCAAF077");

            entity.ToTable("ticket");

            entity.Property(e => e.PnrNumber).ValueGeneratedNever();
            entity.Property(e => e.Gender)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Pname)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("PName");
        });

        modelBuilder.Entity<Train>(entity =>
        {
            entity.HasKey(e => e.PnrNumber).HasName("PK__Train__F148D09FD95E6B4C");

            entity.ToTable("Train");

            entity.Property(e => e.PnrNumber).ValueGeneratedNever();
            entity.Property(e => e.ArrivalTime)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DepartureTime)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Destination)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RunDays)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Sources)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Tname)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("TName");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
