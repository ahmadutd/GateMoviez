using GateMoviez.Data.Interface;
using GateMoviez.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GateMoviez.Data.Repositories
{
     public class ArtistRepository:Repository<Artist>,IArtistRepository
    {
        public ArtistRepository(GateMoviezDbContext context):base(context)
        {

        }

    }
}
