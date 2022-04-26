using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace FBOL.Mobile.Entityframework.Model
{
    public partial class FBOLMobileContext : DbContext
    {
        private readonly IConfiguration _config;
 
        public FBOLMobileContext(IConfiguration configuration)
        {
            _config = configuration;
        }

        public FBOLMobileContext(DbContextOptions<FBOLMobileContext> options, IConfiguration configuration)
            : base(options)
        {
            _config = configuration;
        }

        public virtual DbSet<AudioFile> AudioFiles { get; set; }
        public virtual DbSet<Session> Sessions { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                 optionsBuilder.UseSqlServer(_config.GetConnectionString("FBOLMobileConnection"));
            }
        }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AudioFile>(entity =>
            {
                entity.ToTable("AudioFile");

                entity.Property(e => e.CourseCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ModuleName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Session>(entity =>
            {
                entity.ToTable("Session");

                entity.Property(e => e.Key).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Sessions)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Session_User");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.ConfirmationCode).HasMaxLength(32);

                entity.Property(e => e.EmailAddress).HasMaxLength(1024);

                entity.Property(e => e.FirstName).HasMaxLength(128);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Key).HasDefaultValueSql("(newid())");

                entity.Property(e => e.LastName).HasMaxLength(128);

                entity.Property(e => e.PasswordHash)
                    .IsRequired()
                    .HasMaxLength(1024);

                entity.Property(e => e.PasswordSalt)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.PreferredFirstName).HasMaxLength(200);

                entity.Property(e => e.PreferredLastName).HasMaxLength(200);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(1024);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
