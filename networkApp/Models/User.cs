using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace networkApp.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Group { get; set; }
        public List<Tests> Tests { get; set; } = new List<Tests>();
        public virtual int? GroupInfoId { get; set; }
        public virtual GroupInfo  GroupInfo { get; set; }


    }
}
