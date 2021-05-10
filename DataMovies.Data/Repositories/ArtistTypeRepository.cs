using GateMoviez.Data.Interface;
using GateMoviez.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GateMoviez.Data.Repositories
{
    public class ArtistTypeRepository:Repository<ArtistType>,IArtistTypeRepository
    {
        public ArtistTypeRepository(GateMoviezDbContext context):base(context)
        {

        }
    }
}
