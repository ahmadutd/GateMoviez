using GateMoviez.Domain.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GateMoviez.Domain
{
     public class ArtistType:BaseEntity<int>
    {
        [Display(Name ="نوع هنرمند")]
        [Required]
        public string ArtistTypeName { get; set; }

        public virtual ICollection<Artist_ArtistTypes> Artist_ArtistTypes { get; set; }

        //public virtual ICollection<Artist> Artists { get; set; }
    }
}