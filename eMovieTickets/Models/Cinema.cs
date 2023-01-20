using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eMovieTickets.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        [Display(Name="Cinema Logo")]
        public string CinemaLogo { get; set; }
		[Display(Name ="Cinema")]
		public string Name { get; set; }
		[Display(Name ="Description")]
		public string Description { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
