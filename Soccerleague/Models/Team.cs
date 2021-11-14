using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Soccerleague.Models
{
    public class Team
    {
        [Key]
        public int TeamId { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string TeamName { get; set; }
        [Required]
        public string TeamFounded { get; set; }
        public string TeamLogo { get; set; }
        [Required]
        [Display(Name = "League")]
        public int LeagueId { get; set; }
        public League League { get; set; }
        public ICollection<Player> Players { get; set; }
    }
}
