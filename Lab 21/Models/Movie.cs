using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Lab_21.Models
{
    public class Movie
    {
       //[Required]
       //[StringLength(2, MinimumLength = 1, ErrorMessage = "Sorry that's not correct, try again")]
        public int ID { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "That title is either two long or two short, try again.")]
        public string Title { get; set; }
        [Required]
        [StringLength(25, MinimumLength = 4, ErrorMessage = "That's not a genre we recognize, please try again")]
        public string Genre { get; set; }
        [Required]
        [Range(typeof(DateTime), "01/01/1880", "08/24/2020", ErrorMessage = "We're looking for something else, please try a new year please")]
        public DateTime Year { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "No diggity, please try again")]
        public string Actors { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Please try again")]
        public string Directors { get; set; }

    }
}
