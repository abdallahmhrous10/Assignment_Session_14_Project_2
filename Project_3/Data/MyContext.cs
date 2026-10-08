using Microsoft.EntityFrameworkCore;
using Project_3.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project_3.Data
{
    public class MyContext:DbContext
    {
        public DbSet<Patient> Patients { get; set; }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Server=LAPTOP-P51CPJRR\\SQLEXPRESS;Database=HealthCareDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void  OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Appointment>()
                .HasKey(x =>new { x.PatientId, x.DoctorId});
        }
    }
}
