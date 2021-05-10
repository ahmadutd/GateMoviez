using GateMoviez.Application.Interfaces;
using GateMoviez.Data.Interface;
using GateMoviez.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GateMoviez.Application
{
    public class ArtistTypeService : IArtistTypeService
    {
        private readonly IArtistTypeRepository _artistTypeRepository;
        public ArtistTypeService(IArtistTypeRepository artistTypeRepository)
        {
            _artistTypeRepository = artistTypeRepository;
        }
        public int CreatArtistType(ArtistType artistType)
        {
           return _artistTypeRepository.Add(artistType);
        }

        public int DeleteArtistType(int artistTypeId)
        {
            var artisttype = _artistTypeRepository.Get(x => x.Id == artistTypeId);
            return _artistTypeRepository.Delete(artisttype);
        }

        public IEnumerable<ArtistType> GetArtistType()
        {
            return _artistTypeRepository.GetAll();
        }

        public int UpdateArtistType(ArtistType artistType)
        {
            return _artistTypeRepository.Update(artistType);
        }
    }
}
