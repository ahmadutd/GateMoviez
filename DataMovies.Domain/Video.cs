using GateMoviez.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GateMoviez.Domain
{
    public class Video:BaseEntity<int>
    {
        public Video():base()
        {
            
            
        }

        [Display(Name ="عنوان")]
        public string Title { get; set; }

        [Display(Name = "عکس")]

        public string Image { get; set; }

        [Display(Name = "کارگردان")]

        public string Director { get; set; }

        [Display(Name = "بازیگر")]

        public string Actor { get; set; }

        [Display(Name = "ساخت کشور")]
        public string MadeIn { get; set; }

        [Display(Name = "زبان")]

        public string Language { get; set; }

        [Display(Name = "رتبه")]

        public double? ImdbRank { get; set; }

        [Display(Name = "تعداد لایک")]

        public int? ImdbLike { get; set; }

        [Display(Name = "داستان")]

        public string ShortStory { get; set; }

        [Display(Name = "حجم")]

        public double? Size { get; set; }



        // Below This Ef Navigation Virtual Prop
        public virtual ICollection<VideoTags> VideoTags { get; set; }

    }
}
