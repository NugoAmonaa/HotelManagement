using HotelManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Diagnostics;

namespace HotelManagement.Context
{
    public class HotelContext : DbContext
    {
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB;Database=HotelManagement;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Guest>()
           .HasOne<Room>(s => s.Room)
           .WithOne(ad => ad.Guest)
           .HasForeignKey<Room>(ad => ad.GuestId);



            modelBuilder.Entity<Employee>()
            .HasOne<Hotel>(s => s.Hotel)
            .WithMany(g => g.Employees)
            .HasForeignKey(s => s.HotelId);



            modelBuilder.Entity<Room>()
           .HasOne<Hotel>(s => s.Hotel)
           .WithMany(g => g.Rooms)
           .HasForeignKey(s => s.HotelId);



            modelBuilder.Entity<Room>()
           .HasOne<Employee>(s => s.Employee)
           .WithMany(g => g.Rooms).OnDelete(DeleteBehavior.Restrict)
           .HasForeignKey(s => s.EmployeeId);

        }
    }
}
