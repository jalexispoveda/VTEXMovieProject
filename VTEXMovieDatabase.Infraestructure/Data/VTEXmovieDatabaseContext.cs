using Microsoft.EntityFrameworkCore;
using VTEXMovieDatabase.Core.Entities;

#nullable disable

namespace VTEXMovieDatabase.Infraestructure.Data
{
    public partial class VTEXmovieDatabaseContext : DbContext
    {
        public VTEXmovieDatabaseContext()
        {
        }

        public VTEXmovieDatabaseContext(DbContextOptions<VTEXmovieDatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Actor> Actors { get; set; }
        public virtual DbSet<ActorMovie> ActorMovies { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Actor>(entity =>
            {
                entity.HasKey(e => e.IdActor);

                entity.ToTable("Actor");

                entity.Property(e => e.ActorName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ActorMovie>(entity =>
            {
                entity.HasKey(e => e.IdActorMovie);

                entity.ToTable("ActorMovie");

                entity.HasOne(d => d.IdActorNavigation)
                    .WithMany(p => p.ActorMovies)
                    .HasForeignKey(d => d.IdActor)
                    .HasConstraintName("FK_ActorMovie_Actor");

                entity.HasOne(d => d.IdMovieNavigation)
                    .WithMany(p => p.ActorMovies)
                    .HasForeignKey(d => d.IdMovie)
                    .HasConstraintName("FK_ActorMovie_Movie");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.HasKey(e => e.IdCompany);

                entity.ToTable("Company");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Genre>(entity =>
            {
                entity.HasKey(e => e.IdGenre);

                entity.ToTable("Genre");

                entity.Property(e => e.Description)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Movie>(entity =>
            {
                entity.HasKey(e => e.IdMovie);

                entity.ToTable("Movie");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCompanyNavigation)
                    .WithMany(p => p.Movies)
                    .HasForeignKey(d => d.IdCompany)
                    .HasConstraintName("FK_Movie_Company");

                entity.HasOne(d => d.IdGenreNavigation)
                    .WithMany(p => p.Movies)
                    .HasForeignKey(d => d.IdGenre)
                    .HasConstraintName("FK_Movie_Genre");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
