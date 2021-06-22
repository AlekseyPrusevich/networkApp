using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace networkApp.Models
{
    public class UserToTests
    {
        public int UserToTestsId { get; set; }
        public int GroupsInfoId { get; set; }
        public GroupInfo GroupsInfo { get; set; } //1

        public int TestPropId { get; set; }//2,4,5,8,10
        public TestProp Tests { get; set; }//2,4,5,8,10
    }
}
