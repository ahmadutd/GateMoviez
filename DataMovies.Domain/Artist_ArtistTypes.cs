using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GateMoviez.Domain
{
     public  class Artist_ArtistTypes
    {
        [Key]
        public int Id { get; set; }
        //many to many realstion
        public int ArtistId { get; set; }
        public virtual Artist Artist { get; set; }

        public int ArtistTypeId { get; set; }
        public virtual ArtistType ArtistType { get; set; }
    }
}
