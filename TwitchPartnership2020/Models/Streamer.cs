using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwitchPartnership2020.Models
{
    public class Streamer
    {
        public int ID { get; set; }
        public int BannerID { get; set; }
        public Banner Banner { get; set; }
        public string TwitchURL { get; set; }
        public int PurseID { get; set; }
        public Purse Purse { get; set; }
        public string Mail { get; set; }
        public int AuthID { get; set; }
        public Auth Auth { get; set; }
    }
}
