using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace GateMoviez.Domain.Base
{
    public class BaseEntity<TKey>

    {
        public BaseEntity()
        {
            this.CreatedDate = this.UpdatedDate = DateTime.Now;
        }




        [Key]
        public TKey Id { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime CreatedDate { get; set; }

        [Display(Name = "تاریخ بروز رسانی")]
        public DateTime UpdatedDate { get; set; }
        //public DateTime DeletedDate { get; set; } //برای سیناریوهایی که حذف فیزیکی نداریم

        [Display(Name = "ایجاد توسط")]
        public int? CreatedBy { get; set; }

        [Display(Name = "بروز رسانی توسط")]
        public int? UpdatedBy { get; set; }
        //public int? DeletedBy { get; set; }

        public virtual AppUser CreatedUser { get; set; }
        public virtual AppUser UpdatedUser { get; set; }

    }
}
