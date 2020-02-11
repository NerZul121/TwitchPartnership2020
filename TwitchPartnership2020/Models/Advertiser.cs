using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwitchPartnership2020.Models
{
    public class Advertiser
    {
        public int ID { get; set; }
        public string Contacts { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Content> Contents { get; set; }

        public int PurseID { get; set; }
        public Purse Purse { get; set; }

        public int AuthID { get; set; }
        public Auth Auth { get; set; }
    }
}
