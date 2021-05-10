using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GateMoviez.Domain
{
    public class VideoTags
    {
        [Key]
        public int Id { get; set; }
        public int VideoId { get; set; }
        public int TagId { get; set; }

        public virtual Video  Video { get; set; }
        public virtual Tag  Tag { get; set; }
    }
}
