using System.ComponentModel.DataAnnotations;

namespace Test_3_Domain.Entities
{
    public class Movie
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(25)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(75)]
        public string Description { get; set; } = null!;

        [Required]
        [Range(0, 10)]
        public double Rating { get; set; }
        public double Rating2 { get; set; }
    }
}
