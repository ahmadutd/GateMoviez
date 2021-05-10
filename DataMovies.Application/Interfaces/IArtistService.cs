using GateMoviez.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GateMoviez.Application.Interfaces
{
    public interface IArtistService
    {
        IEnumerable<Artist> GetArtist();
        int CreatArtist(Artist artist);
        int UpdateArtist(Artist artist);
        int DeleteArtist(int artistId);
    }
}
