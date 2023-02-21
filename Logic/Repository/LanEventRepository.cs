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
    public class LanEventRepository : ILanEventRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public LanEventRepository(ApplicationDbContext db, IMapper mapper)
        {
            _mapper = mapper;
            _db = db;
        }
        public async Task<LanEventDTO> CreateLanEvent(LanEventDTO lanEventDTO)
        {
            LanEvent lanEvent = _mapper.Map<LanEventDTO, LanEvent>(lanEventDTO);
            var createdLanEvent = await _db.LanEvent.AddAsync(lanEvent);
            await _db.SaveChangesAsync();
            return _mapper.Map<LanEvent, LanEventDTO>(createdLanEvent.Entity);
        }
        public async Task<IEnumerable<LanEventDTO>> GetLanEvents()
        {
            try
            {
                IEnumerable<LanEventDTO> lanEventDTOs =
                    _mapper.Map<IEnumerable<LanEvent>, IEnumerable<LanEventDTO>>(_db.LanEvent);

                return lanEventDTOs;
            }

            catch(Exception ex)
            {
                return null;
            }  
        }
        public async Task<LanEventDTO> GetLanEvent(int eventId) 
        { 
            try
            {
                LanEventDTO lanEvent = _mapper.Map<LanEvent, LanEventDTO>(
                    await _db.LanEvent.FirstOrDefaultAsync(x => x.EventId == eventId));

                return lanEvent;
            }

            catch(Exception ex)
            {
                return null;
            }
        }
        public async Task<LanEventDTO> UpdateLanEvent(int eventId, LanEventDTO lanEventDTO)
        {
            try 
            {  
                if (eventId == lanEventDTO.EventId)
                {
                    LanEvent lanEventDetails = await _db.LanEvent.FindAsync(eventId);
                    LanEvent singleEvent = _mapper.Map<LanEventDTO, LanEvent>(lanEventDTO, lanEventDetails);
                    var updatedEvent = _db.LanEvent.Update(singleEvent);
                    await _db.SaveChangesAsync();
                    return _mapper.Map<LanEvent, LanEventDTO>(updatedEvent.Entity);
                }
                else
                {
                    return null;
                }
            }
            catch(Exception ex) 
                {
                    return null;
                } 
        }
        public async Task<int> DeleteLanEvent(int eventId)
        {
            var eventDelete = await _db.LanEvent.FindAsync(eventId);
            if (eventDelete != null)
            {
                _db.LanEvent.Remove(eventDelete);
                return await _db.SaveChangesAsync();
            }
            return 0;
        }
    }
}
