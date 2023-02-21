using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Data
{
    public class LanGame
    {
        [Key]
        public int GameId { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public ICollection<LanEvent> LanEvents { get; set; }
    }
}
