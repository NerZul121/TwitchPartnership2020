using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwitchPartnership2020.Models
{
    public enum StreamState
    {
        InProccess,
        Finished,
        Moderating
    }
    public class Stream
    {
        public int ID { get; set; }
        public int StreamerID { get; set; }
        public string ChannelsURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? Duration { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? ChangeDate { get; set; }
        //public ICollection<Thematics> Thematics { get; set; }
        public StreamState State { get; set; }
        public bool Confirmed { get; set; }

    }
}
