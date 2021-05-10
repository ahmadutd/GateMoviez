using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GateMoviez.Domain
{
    public class Janer
    {
        public int JanerId { get; set; }
        [Required(ErrorMessage ="وارد کردن این فیلد الزامی میباشد")]
        public string Name { get; set; }
        public string EnName { get; set; }

       

    }
}
