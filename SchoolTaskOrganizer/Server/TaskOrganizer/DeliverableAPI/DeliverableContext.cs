﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SchoolTaskOrganizer.Shared.Models;

namespace SchoolTaskOrganizer.Server.TaskOrganizer.DeliverableAPI
{
    public partial class DeliverableContext : DbContext
    {
        public DeliverableContext()
        {
        }

        public DeliverableContext(DbContextOptions<DeliverableContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Deliverable> _deliverable { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(local);Initial Catalog=TaskOrganizer;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Deliverable>(entity =>
            {
                entity.HasKey(e => e.CourseCode)
                    .HasName("PK__Table__FC00E001DDAA8808");

                entity.ToTable("deliverable");

                entity.Property(e => e.CourseCode).HasMaxLength(50);

                entity.Property(e => e.AdditionalNotes).HasMaxLength(50);

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.Task).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}