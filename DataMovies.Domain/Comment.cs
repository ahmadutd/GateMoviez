using GateMoviez.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GateMoviez.Domain
{
    public class Comment:BaseEntity<int>
    {
        [Display(Name = "متن کامنت")]
        public string CommnetText { get; set; }
    }
}
