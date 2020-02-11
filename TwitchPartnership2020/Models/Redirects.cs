using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwitchPartnership2020.Models
{
    public class Redirect
    {
        public int ID { get; set; }
        public DateTime RedirectTime { get; set; }
        public int Fingerprint { get; set; }

        public int ContentID { get; set; }
        public Content Content { get; set; }

        public int StreamID { get; set; }
        public Stream Stream { get; set; }
    }
}
