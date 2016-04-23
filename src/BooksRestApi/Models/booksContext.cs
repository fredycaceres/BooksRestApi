using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace BooksRestApi.Models
{
    public partial class booksContext : DbContext
    {    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Authors>(entity =>
            {
                entity.Property(e => e.country).HasMaxLength(100);

                entity.Property(e => e.created).HasColumnType("datetime");

                entity.Property(e => e.last_name)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.name)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<Books>(entity =>
            {
                entity.Property(e => e.country).HasMaxLength(255);

                entity.Property(e => e.created).HasColumnType("datetime");

                entity.Property(e => e.isbn)
                    .IsRequired()
                    .HasMaxLength(13);

                entity.Property(e => e.isbn10).HasMaxLength(10);

                entity.Property(e => e.language).HasMaxLength(30);

                entity.Property(e => e.original_language).HasMaxLength(30);

                entity.Property(e => e.title).IsRequired();

                entity.Property(e => e.translator).HasMaxLength(200);

                entity.Property(e => e.updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<Collections>(entity =>
            {
                entity.Property(e => e.created).HasColumnType("datetime");

                entity.Property(e => e.name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<Editorial>(entity =>
            {
                entity.Property(e => e.country).HasMaxLength(200);

                entity.Property(e => e.created).HasColumnType("datetime");

                entity.Property(e => e.name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.updated).HasColumnType("datetime");
            });
        }

        public virtual DbSet<Authors> Authors { get; set; }
        public virtual DbSet<Books> Books { get; set; }
        public virtual DbSet<Collections> Collections { get; set; }
        public virtual DbSet<Editorial> Editorial { get; set; }
    }
}