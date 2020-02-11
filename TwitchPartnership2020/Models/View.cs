using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwitchPartnership2020.Models
{
    public class View
    {
        public int ID { get; set; }
        public int BannerID { get; set; }
        public int StreamID { get; set; }
        public int Viewers { get; set; }
        public int AuthViewers { get; set; }
        public int Duration { get; set; }
        public string Platform { get; set; }
        public DateTime Date { get; set; }
        public int State { get; set; }
        public DateTime ChangeDate { get; set; }
    }
}
