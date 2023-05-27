using Microsoft.EntityFrameworkCore;

namespace BigAccessment1_HotelsAPI.Models
{
    public class MainDbContext:DbContext
    {
        public MainDbContext(DbContextOptions<MainDbContext> options) : base(options) { }
        
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Reservation> Reversations { get; set; }
        public DbSet<PriceRange> PriceRanges { get; set; }
        public DbSet<Information> Informations { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hotel>()
            .HasMany(h => h.Room)
            .WithOne(r => r.hotels)
            .HasForeignKey(r => r.Hotel_Id);

            modelBuilder.Entity<Hotel>()
            .HasOne(h => h.Location)
            .WithMany(l => l.Hotel)
            .HasForeignKey(h => h.Location_Id);

            modelBuilder.Entity<Hotel>()
            .HasOne(h => h.Pricerange)
            .WithMany(l => l.Hotel)
            .HasForeignKey(h => h.PriceRange_Id);

            modelBuilder.Entity<Hotel>()
            .HasOne(h => h.Information)
            .WithMany(l => l.Hotel)
            .HasForeignKey(h => h.Information_Id);

            modelBuilder.Entity<Reservation>()
            .HasOne(r => r.User)
            .WithMany()
            .HasForeignKey(r => r.User_Id);

            modelBuilder.Entity<Reservation>()
            .HasOne(r => r.Room)
            .WithMany(r => r.Reservations)
            .HasForeignKey(r => r.RoomId);

            modelBuilder.Entity<Room>()
            .HasIndex(r => r.Room_no)
            .IsUnique();
        }

    }

       

    }

   

