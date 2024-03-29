﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja_do_awizacji.Model
{
    public class Aplikacja_do_awizacjiDbContext : DbContext
    {
        public Aplikacja_do_awizacjiDbContext() : base()
        {
            OnConfiguring(new DbContextOptionsBuilder());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Program.ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Guest>()
                .HasOne(g => g.Worker)
                .WithMany(w => w.Guests)
                .HasForeignKey(g => g.WorkerId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Meeting>()
                .HasOne(m => m.Guest)
                .WithMany(g => g.Meetings)
                .HasForeignKey(m => m.GuestId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Meeting>()
                .HasOne(m => m.Worker)
                .WithMany(g => g.Meetings)
                .HasForeignKey(m => m.WorkerId)
                .OnDelete(DeleteBehavior.NoAction);
        }

        public DbSet<Guest> Guests { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
    }
}
