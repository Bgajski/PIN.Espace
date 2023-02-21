using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using DataAccess.Data;
using Logic.Repository.IRepository;
using Models;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace Logic.Repository
{
    public class LanGameRepository : ILanGameRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public LanGameRepository(ApplicationDbContext db, IMapper mapper)
        {
            _mapper = mapper;
            _db = db;
        }
        public async Task<LanGameDTO> CreateLanGame(LanGameDTO lanGameDTO)
        {
            LanGame lanGame = _mapper.Map<LanGameDTO, LanGame>(lanGameDTO);
            var createdLanGame = await _db.LanGame.AddAsync(lanGame);
            await _db.SaveChangesAsync();
            return _mapper.Map<LanGame, LanGameDTO>(createdLanGame.Entity);
        }
        public async Task<IEnumerable<LanGameDTO>> GetLanGames()
        {
            try
            {
                IEnumerable<LanGameDTO> lanGameDTOs =
                    _mapper.Map<IEnumerable<LanGame>, IEnumerable<LanGameDTO>>(_db.LanGame);

                return lanGameDTOs;
            }

            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<LanGameDTO> GetLanGame(int gameId)
        {
            try
            {
                LanGameDTO lanGame = _mapper.Map<LanGame, LanGameDTO>(
                    await _db.LanGame.FirstOrDefaultAsync(x => x.GameId == gameId));

                return lanGame;
            }

            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<int> DeleteLanGame(int gameId)
        {
            var gameDelete = await _db.LanGame.FindAsync(gameId);
            if (gameDelete != null)
            {
                _db.LanGame.Remove(gameDelete);
                return await _db.SaveChangesAsync();
            }
            return 0;
        }
    }
}