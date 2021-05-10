using GateMoviez.Data.Interface;
using GateMoviez.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GateMoviez.Data.Repositories
{
    public class ArtistArtistTypesRepository:Repository<Artist_ArtistTypes>,IArtistArtistTypesRepository
    {
        public ArtistArtistTypesRepository(GateMoviezDbContext context):base(context)
        {

        }
    }
}
