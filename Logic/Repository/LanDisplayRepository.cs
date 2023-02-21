using System.Threading.Tasks;
using System.Collections.Generic;
using Logic.Repository.IRepository;
using Models;
using System.Linq;

namespace Logic.Repository
{
    public class LanDisplayRepository : ILanDisplayRepository
    {
        private readonly ILanEventRepository _lanEventRepository;
        private readonly ILanGameRepository _lanGameRepository;
        public LanDisplayRepository(ILanEventRepository lanEvent, ILanGameRepository lanGame)
        {
            _lanEventRepository = lanEvent;
            _lanGameRepository = lanGame;
        }
        public async Task<IEnumerable<LanDisplayDTO>> GetLansDisplay()
        {
            var lanEvents = await _lanEventRepository.GetLanEvents();
            var lanGames = await _lanGameRepository.GetLanGames();

            var displayEvents = from le in lanEvents
                                join lg in lanGames on le.LanGameId equals lg.GameId
                                select new LanDisplayDTO
                                {
                                    EventId = le.EventId,
                                    Name = le.Name,
                                    GameId = (int)le.LanGameId,
                                    GameName = lg.Name,
                                    GameGenre = lg.Genre,
                                    Teams = le.Teams,
                                    Reward = le.Reward,
                                    Starting = le.Starting,
                                    Ending = le.Ending,
                                    Price = le.Price,
                                };

            return displayEvents;
        }
        public async Task<LanDisplayDTO> UpdateLanDisplay(int eventId, LanDisplayDTO lanDisplayDTO)
        {
            var lanEventDTO = new LanEventDTO
            {
                EventId = eventId,
                LanGameId = lanDisplayDTO.GameId,

            };
            await _lanEventRepository.UpdateLanEvent(eventId, lanEventDTO);
            return lanDisplayDTO;
        }
    }
}

