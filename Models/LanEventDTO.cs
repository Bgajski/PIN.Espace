using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class LanEventDTO
    {
        public int EventId { get; set; }
        [Required(ErrorMessage = "Potrebno je unijeti naziv turnira")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Potrebno je unijeti broj timova")]
        public int Teams { get; set; }
        [Required(ErrorMessage = "Potrebno je unijeti iznos nagradnog fonda u Eurima")]
        public int Reward { get; set; }
        [Required(ErrorMessage = "Potrebno je unijeti datum početka turnira")]
        public DateTime Starting { get; set; }
        [Required(ErrorMessage = "Potrebno je unijeti datum kraja turnira")]
        public DateTime Ending { get; set; }
        [Required(ErrorMessage = "Potrebno je unijeti cijenu registracije po timu")]
        public int Price { get; set; }
        public int? LanGameId { get; set; }
        public LanGameDTO LanGameDTO { get; set; }
    }
}
