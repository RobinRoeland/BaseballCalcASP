using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BaseballCalcASP.Models
{
    public class Team
    {
        public int Id { get; set; }

        [DisplayName("Ploegnaam")]
        [DisplayFormat(NullDisplayText = "FA")]
        [Required]
        public string Name { get; set; }

        [DisplayName("Aantal Spelers")]
        public int TotalPlayers { get; set; } = 0;

        public bool Deleted { get; set; } = false;
    }
}
