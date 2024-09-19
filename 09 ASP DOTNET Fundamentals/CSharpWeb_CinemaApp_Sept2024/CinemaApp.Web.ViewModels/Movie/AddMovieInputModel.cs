using System.ComponentModel.DataAnnotations;
using static CinemaApp.Common.EntityValidationConstants.Movie;

namespace CinemaApp.Web.ViewModels.Movie
{
    public class AddMovieInputModel
    {
        [Required]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(GenreMaxLength)]
        [MinLength(GenreMinLength)]
        public string Genre { get; set; } = null!;

        [Required]
        public string ReleaseDate { get; set; } = null!;

        [Required]
        [Range(DurationMinValue, DurationMaxValue)]
        public int Duration { get; set; }

        [Required]
        [MinLength(DirectorNameMinLength)]
        [MaxLength(DirectorNameMaxLength)]
        public string Director { get; set; } = null!;

        [Required]
        [MinLength(DescriptionMinLength)]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;
    }
}
