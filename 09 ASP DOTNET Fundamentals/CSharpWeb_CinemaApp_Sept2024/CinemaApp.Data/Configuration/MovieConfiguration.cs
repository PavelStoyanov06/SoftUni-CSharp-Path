using CinemaApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static CinemaApp.Common.EntityValidationConstants.Movie;

namespace CinemaApp.Data.Configuration
{
    public class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasKey(m => m.Id);

            builder
                .Property(m => m.Title)
                .IsRequired()
                .HasMaxLength(TitleMaxLength);

            builder
                .Property(m => m.Genre)
                .IsRequired()
                .HasMaxLength(GenreMaxLength);

            builder
                .Property(m => m.Director)
                .IsRequired()
                .HasMaxLength(DirectorNameMaxLength);

            builder
                .Property(m => m.Description)
                .IsRequired()
                .HasMaxLength(DescriptionMaxLength);

            builder.HasData(this.SeedMovies());
        }

        private List<Movie> SeedMovies()
        {
            List<Movie> movies = new List<Movie>()
            {
                new Movie
                {
                    Title = "Harry Potter and The Goblet of Fire",
                    Genre = "Fantasy",
                    ReleaseDate = new DateTime(2005, 11, 01),
                    Director = "Mike Newel",
                    Duration = 157,
                    Description = "In his fourth year at Hogwarts, Harry must reluctantly compete in an ancient wizard tournament after someone mysteriously selects his name, while the Dark Lord secretly conspires something sinister."
                },
                new Movie
                {
                    Title = "Lord of The Rings The Fellowship of the Ring",
                    Genre = "Fantasy",
                    ReleaseDate = new DateTime(2002, 3, 22),
                    Director = "Peter Jackson",
                    Duration = 178,
                    Description = "A ring with mysterious powers lands in the hands of a young hobbit, Frodo. Under the guidance of Gandalf, a wizard, he and his three friends set out on a journey and land in the Elvish kingdom."
                }
            };
            return movies;
        } 
    }
}
