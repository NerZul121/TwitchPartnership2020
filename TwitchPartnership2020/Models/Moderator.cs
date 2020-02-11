using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwitchPartnership2020.Models
{
    public class Moderator
    {
        public int ID { get; set; }
        public string Info { get; set; }

        public int AuthID { get; set; }
        public Auth Auth { get; set; }

        public int PurseID { get; set; }
        public Purse Purse { get; set; }
    }
}
