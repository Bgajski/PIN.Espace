using System.Threading.Tasks;
using System.Collections.Generic;
using Models;

namespace Logic.Repository.IRepository
{
    public interface ILanDisplayRepository
    {
        public Task<IEnumerable<LanDisplayDTO>> GetLansDisplay();
        public Task<LanDisplayDTO> UpdateLanDisplay(int eventId, LanDisplayDTO lanDisplayDTO);
    }
}


