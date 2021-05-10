using GateMoviez.Application.Interfaces;
using GateMoviez.Data.Interface;
using GateMoviez.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GateMoviez.Application
{
    public class ArtistService : IArtistService
    {
        private readonly IUnitOfWork _unitofwork;
        public ArtistService(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }
        public int CreatArtist(Artist artist)
        {
            return _unitofwork.ArtistRepo.Add(artist);
        }

        public int DeleteArtist(int artistId)
        {
            var artist = _unitofwork.ArtistRepo.Get(x => x.Id == artistId);
            return _unitofwork.ArtistRepo.Delete(artist);
        }

        public List<Artist> GetArtist()
        {
            return _unitofwork.ArtistRepo.GetAll().ToList();

        }

        public int UpdateArtist(Artist artist)
        {
            return _unitofwork.ArtistRepo.Update(artist);

        }
    }
}
