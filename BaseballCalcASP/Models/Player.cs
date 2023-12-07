using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaseballCalcASP.Models
{
    public class Player
    {
        public int Id { get; set; }
        
        [DisplayName("Naam")]
        [Required]
        public string Name { get; set; }

        [DisplayName("Rugnummer")]
        [DisplayFormat(NullDisplayText = "N/A")]
        public int? Rugnummer { get; set; } = null;

        [DisplayName("Geboortedatum")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        public int? TeamId { get; set; } = null;

        [DisplayName("Ploeg")]
        public Team? Team { get; set; }
    }
}
