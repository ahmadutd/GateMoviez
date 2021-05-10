using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GateMoviez.Application.Interface;
using GateMoviez.Data;
using GateMoviez.Data.Interface;
using GateMoviez.Domain;

namespace GateMoviez.Application
{
     public class VideoService:IVideoService
     {
        private readonly IVideoRepository _videorepo;
        public VideoService(IVideoRepository videorepo)
        {
            _videorepo = videorepo;
        }
        
        public IEnumerable<Video> GetVideos()
        {
            return _videorepo.GetAll();
        }

        public int CreatVideo(Video video)
        {
            return _videorepo.Add(video);
        }

        public int DeleteVideo(int videoId)
        {
            var video = _videorepo.Get(v => v.Id == videoId);
            int result = 0;
            if (video != null)
            {
                return _videorepo.Delete(video);

            }
            return result;
        }

       

        public int UpdateVideo(Video video)
        {
            return _videorepo.Update(video);
        }
    }
}
