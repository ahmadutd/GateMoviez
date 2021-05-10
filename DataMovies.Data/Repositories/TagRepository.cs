using GateMoviez.Data.Interface;
using GateMoviez.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GateMoviez.Data.Repositories
{
    public class TagRepository:Repository<Tag>,ITagRepository
    {
        public TagRepository(GateMoviezDbContext context):base(context)
        {

        }
    }
}
