using GateMoviez.Data.Interface;
using GateMoviez.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace GateMoviez.Data.Repositories
{
    public class VideoRepository:Repository<Video>,IVideoRepository
    {
        public VideoRepository(GateMoviezDbContext context):base(context)
        {
           
        }

        public IEnumerable<Video> GetTop10Videos()
        {
            return GetAll().OrderByDescending(x => x.ImdbLike).Take(10).ToList();
        }
    }
}
