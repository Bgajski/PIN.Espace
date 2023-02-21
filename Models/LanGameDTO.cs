using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Models
{
    public class LanGameDTO
    {
        public int GameId { get; set; }
        [Required(ErrorMessage = "Potrebno je unijeti naziv igre")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Potrebno je unijeti žanr igre")]
        public string Genre { get; set; } = string.Empty;
        public ICollection<LanEventDTO> LanEvents { get; set; }
    }
}
