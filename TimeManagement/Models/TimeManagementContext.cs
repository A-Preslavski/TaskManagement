using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TimeManagement.Models;

public partial class TimeManagementContext : DbContext
{
    public TimeManagementContext()
    {
    }

    public TimeManagementContext(DbContextOptions<TimeManagementContext> options)
        : base(options)
    {
    }

    // Entities
    public virtual DbSet<Task> Tasks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-MKVDAJJ\\SQLEXPRESS02;Database=TimeManagement;User Id=sa;Password=xyzzy2005;Trusted_Connection=False;Encrypt=false;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Task>(entity =>
        {
            entity.HasKey(e => e.TaskKey);

            entity.Property(e => e.TaskKey).ValueGeneratedNever();
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.EndTime).HasColumnType("datetime");
            entity.Property(e => e.StartTime).HasColumnType("datetime");
            entity.Property(e => e.TimeSpent).HasColumnType("datetime");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
