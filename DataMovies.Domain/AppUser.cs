using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GateMoviez.Domain
{
    public class AppUser:IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        
       /* public virtual ICollection<Comment> Comments { get; set; }*/  //اشاره به اینکه هر یوزر میتواند هر تعداد  کامنت داشته باشد
        public virtual ICollection<Video> CreatedVideos { get; set; }
        public virtual ICollection<Video> UpdatedVideos { get; set; }
    }
}
