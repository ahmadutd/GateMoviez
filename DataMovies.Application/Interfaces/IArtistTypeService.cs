using GateMoviez.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GateMoviez.Application.Interfaces
{
    public interface IArtistTypeService
    {
        IEnumerable<ArtistType> GetArtistType();
        int CreatArtistType(ArtistType artistType);
        int UpdateArtistType(ArtistType artistType);
        int DeleteArtistType(int artistTypeId);
    }
}
