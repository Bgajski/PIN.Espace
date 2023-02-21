using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Data
{
    public class LanEvent
    {
        [Key]
        public int EventId { get; set; }
        public string Name { get; set; }
        public int Reward { get; set; }
        public int Teams { get; set; }
        public DateTime Starting { get; set; }
        public DateTime Ending { get; set; }
        public int Price { get; set; }
        public int? LanGameId { get; set; }
        public LanGame LanGame { get; set; }
    }
}
