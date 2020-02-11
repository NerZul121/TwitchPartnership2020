using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwitchPartnership2020.Models
{
    public class Banner
    {
        public int ID { get; set; }
        public string Token { get; set; }
        public bool IsContentsBlocked { get; set; }
        public int Delay { get; set; }
        public Streamer Streamer { get; set; }
        //public ICollection<Content> Contents { get; set; }
    }
}
