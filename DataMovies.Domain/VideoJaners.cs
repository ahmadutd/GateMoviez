using System;
using System.Collections.Generic;
using System.Text;

namespace GateMoviez.Domain
{
     public class VideoJaners
    {
        public int VideoId { get; set; }
        public int JanerId { get; set; }

        public virtual Video Video { get; set; }
        public virtual Janer Janer { get; set; }
    }
}
