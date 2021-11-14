using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Soccerleague.Models
{
    public class League
    {
        [Key]
        public int LeagueId { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string LeagueName { get; set; }
        [Required]
        [Display(Name = "League")]
        public string LeagueCountry { get; set; }
        public string LeagueLogo { get; set; }
        public ICollection<Team> Teams { get; set; }
    }
}
