using System;

namespace Models
{
    public class LanDisplayDTO
    {
        public int EventId { get; set; }
        public string Name { get; set; }
        public int GameId { get; set; }
        public string GameName { get; set; }
        public string GameGenre { get; set; }
        public int Teams { get; set; }
        public int Reward { get; set; }
        public DateTime Starting { get; set; }
        public DateTime Ending { get; set; }
        public int Price { get; set; }
    }
}
