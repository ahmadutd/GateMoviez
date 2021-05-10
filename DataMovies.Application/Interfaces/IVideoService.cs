using GateMoviez.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GateMoviez.Application.Interface
{
    public interface IVideoService
    {

        IEnumerable<Video> GetVideos();
        int CreatVideo(Video video);
        int UpdateVideo(Video video);
        int DeleteVideo(int videoId);
         
    }
}
