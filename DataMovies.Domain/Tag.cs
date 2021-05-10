using GateMoviez.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GateMoviez.Domain
{
    public class Tag:BaseEntity<int>
    {
        [Display(Name="عنوان")]
        public string Name { get; set; }

        public virtual ICollection<VideoTags> VideoTags { get; set; }

    }
}
