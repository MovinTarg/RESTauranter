using System;
using System.ComponentModel.DataAnnotations;

namespace RESTauranter.Models
{
    public class Review : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Reviewer Name")]
        public string ReviewerName { get; set; }
        [Required]
        [Display(Name = "Restaurant Name")]
        public string RestaurantName { get; set; }
        [Required]
        [MinLength (10)]
        [Display(Name = "Review")]
        public string Comment { get; set; }
        [Required]
        [Display(Name = "Rating")]
        [Range(1,5, ErrorMessage="Rating must be between 1 and 5 stars")]
        public int Rating { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date Visited")]
        public DateTime Visited { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}