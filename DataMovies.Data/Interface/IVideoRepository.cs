using GateMoviez.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GateMoviez.Data.Interface
{
    public interface IVideoRepository:IRepository<Video>
    {
        IEnumerable<Video> GetTop10Videos();
    }
}
