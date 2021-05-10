using GateMoviez.Data.Interface;
using GateMoviez.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GateMoviez.Data.Repositories
{
    public class VideoTagsRepository:Repository<VideoTags>,IVideoTagsRepository
    {
        public VideoTagsRepository(GateMoviezDbContext context):base(context)
        {

        }
    }
}
