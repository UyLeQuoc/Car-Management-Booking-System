using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace BusinessObjects
{
    public partial class CarBookingManagementContext : DbContext
    {
        public CarBookingManagementContext()
        {
        }

        public CarBookingManagementContext(DbContextOptions<CarBookingManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblBooking> TblBookings { get; set; }
        public virtual DbSet<TblBookingDetail> TblBookingDetails { get; set; }
        public virtual DbSet<TblBrand> TblBrands { get; set; }
        public virtual DbSet<TblCar> TblCars { get; set; }
        public virtual DbSet<TblModel> TblModels { get; set; }
        public virtual DbSet<TblUser> TblUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            /*
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-8IFCV8RT\\UYLE;Database=CarBookingManagement;uid=sa;Pwd=12345");
            }
            */
            optionsBuilder.UseSqlServer(GetConnectionString());
        }

        public static string GetConnectionString()
        {
            IConfiguration builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true).Build();
            return builder["ConnectionStrings:DefaultConnectionString"];
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TblBooking>(entity =>
            {
                entity.HasKey(e => e.BookingId)
                    .HasName("PK__tblBooki__C6D03BEDA2587037");

                entity.ToTable("tblBookings");

                entity.Property(e => e.BookingId).HasColumnName("bookingID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdDate");

                entity.Property(e => e.TotalPrice)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("totalPrice");

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TblBookings)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKtblBooking558133");
            });

            modelBuilder.Entity<TblBookingDetail>(entity =>
            {
                entity.HasKey(e => new { e.CarId, e.BookingId })
                    .HasName("PK__tblBooki__D85BF32AAD38EAE9");

                entity.ToTable("tblBookingDetails");

                entity.Property(e => e.CarId).HasColumnName("carID");

                entity.Property(e => e.BookingId).HasColumnName("bookingID");

                entity.Property(e => e.BookingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("bookingDate");

                entity.Property(e => e.BookingExpired)
                    .HasColumnType("datetime")
                    .HasColumnName("bookingExpired");

                entity.Property(e => e.BookingPrice)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("bookingPrice");

                entity.Property(e => e.ReturnStatus).HasColumnName("returnStatus");

                entity.HasOne(d => d.Booking)
                    .WithMany(p => p.TblBookingDetails)
                    .HasForeignKey(d => d.BookingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKtblBooking505768");

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.TblBookingDetails)
                    .HasForeignKey(d => d.CarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKtblBooking382260");
            });

            modelBuilder.Entity<TblBrand>(entity =>
            {
                entity.HasKey(e => e.BrandId)
                    .HasName("PK__tblBrand__06B772B96DA2626E");

                entity.ToTable("tblBrands");

                entity.Property(e => e.BrandId)
                    .ValueGeneratedNever()
                    .HasColumnName("brandID");

                entity.Property(e => e.BrandName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("brandName");
            });

            modelBuilder.Entity<TblCar>(entity =>
            {
                entity.HasKey(e => e.CarId)
                    .HasName("PK__tblCars__1436F0945E419F99");

                entity.ToTable("tblCars");

                entity.HasIndex(e => e.CarPlate, "UQ__tblCars__F852FE3FF97B7E50")
                    .IsUnique();

                entity.Property(e => e.CarId).HasColumnName("carID");

                entity.Property(e => e.BrandId).HasColumnName("brandID");

                entity.Property(e => e.CarName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("carName");

                entity.Property(e => e.CarPlate)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("carPlate");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.ModelId).HasColumnName("modelID");

                entity.Property(e => e.PricePerHour)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("pricePerHour");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.TblCars)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FKtblCars513690");

                entity.HasOne(d => d.Model)
                    .WithMany(p => p.TblCars)
                    .HasForeignKey(d => d.ModelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKtblCars232816");
            });

            modelBuilder.Entity<TblModel>(entity =>
            {
                entity.HasKey(e => e.ModelId)
                    .HasName("PK__tblModel__0215CDB967CB3003");

                entity.ToTable("tblModels");

                entity.Property(e => e.ModelId)
                    .ValueGeneratedNever()
                    .HasColumnName("modelID");

                entity.Property(e => e.ModelName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("modelName");
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__tblUsers__CB9A1CDFFA10659D");

                entity.ToTable("tblUsers");

                entity.HasIndex(e => e.Email, "UQ__tblUsers__AB6E61642F8921D2")
                    .IsUnique();

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.FullName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("fullName");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.RoleId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("roleID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
