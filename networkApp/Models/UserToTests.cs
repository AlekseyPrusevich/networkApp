using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace networkApp.Models
{
    public class UserToTests
    {
        public int UserToTestsId { get; set; }
        public List<GroupInfo> GroupsInfo { get; set; } //1
        public List<TestProp> Tests { get; set; }//2,4,5,8,10
    }
}
