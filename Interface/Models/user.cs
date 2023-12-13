using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class user
    {
        public int id { get; set; }
        public string projectName { get; set; }
        public string fromDate { get; set; }
        public string toDate { get; set; }
        public string leaderName { get; set; }
        public string projectStatus { get; set; }
        public string projectClient { get; set; }
    }
    public class clientList
    {
        public int id { get; set; }
        public string projectClient { get; set; }

    }
}
