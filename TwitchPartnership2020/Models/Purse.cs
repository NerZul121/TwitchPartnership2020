using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwitchPartnership2020.Models
{
    public class Purse
    {
        public int ID { get; set; }
        public int CurrentBalance { get; set; }
        public int UnconfirmedBalance { get; set; }
        public int Status { get; set; }
    }
}
