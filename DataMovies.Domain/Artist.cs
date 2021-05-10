using GateMoviez.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GateMoviez.Domain
{
    public class Artist:BaseEntity<int>
    {
        [Column(TypeName ="NVARCHAR(50)")]
        [Display(Name = "نام هنرمند")]

        public string FirstName { get; set; }

        [Column(TypeName = "NVARCHAR(100)")]
        

        public string LastName { get; set; }

        [Display(Name = " بیوگرافی")]


        public string Abaut { get; set; }


        public virtual ICollection<Artist_ArtistTypes> Artist_ArtistTypes { get; set; }


        //public int? ArtistTypeId { get; set; }
        //public virtual ArtistType ArtistType { get; set; } //realation 1/*

    }
}
