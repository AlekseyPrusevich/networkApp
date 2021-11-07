using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace networkApp.Models
{
    public class GroupToTestID
    {
        public int ID { get; set; }
        public int GroupsInfoId { get; set; }
        public GroupInfo GroupInfo { get; set; }
        public int TestPropId { get; set; }//2,4,5,8,10
        public TestProp TestProp { get; set; }//2,4,5,8,10
    }
}
