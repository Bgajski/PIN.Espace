using System.Threading.Tasks;
using System.Collections.Generic;
using Models;

namespace Logic.Repository.IRepository
{
    public interface ILanEventRepository
    {
        public Task<LanEventDTO> CreateLanEvent(LanEventDTO lanEventDTO);
        public Task<IEnumerable<LanEventDTO>> GetLanEvents();
        public Task<LanEventDTO> GetLanEvent(int eventId);
        public Task<LanEventDTO> UpdateLanEvent(int eventId, LanEventDTO lanEventDTO);
        public Task<int> DeleteLanEvent(int eventId);
    }
}
