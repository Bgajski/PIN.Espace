using System.Threading.Tasks;
using System.Collections.Generic;
using Models;

namespace Logic.Repository.IRepository
{
    public interface ILanGameRepository
    {
        public Task<LanGameDTO> CreateLanGame(LanGameDTO lanGameDTO);
        public Task<IEnumerable<LanGameDTO>> GetLanGames();
        public Task<LanGameDTO> GetLanGame(int gameId);
        public Task<int> DeleteLanGame(int gameId);
    }
}
