using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwitchPartnership2020.Models
{
    public class Appeal
    {
        public int ID { get; set; }
        public int Type { get; set; }
        public int State { get; set; }

        public int ViewID { get; set; }
        public View View { get; set; }

        public int StreamID { get; set; }
        public Stream Stream { get; set; }

        public int ModeratorID { get; set; }
        public Moderator Moderator { get; set; }

        public DateTime Create_Date { get; set; }
        public DateTime Change_Date { get; set; }
    }
}
