using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwitchPartnership2020.Models
{
    public class Content
    {
        public int ID { get; set; }
        public string MediaContent { get; set; }
        public int CostPerView { get; set; }
        public int CostPerAuthView { get; set; }
        public int CostPerClick { get; set; }
        //public string Thematics { get; set; }
        //public ListStreamers
        //public bool IsStreamersBlocked { get; set; }
        //public ListPlatforms
        //public bool IsPlatformsBlocked
        public int Budget { get; set; }
        public int UsedBudget { get; set; }
        public string Status { get; set; }
        public Uri RedirectURL { get; set; }
        public int AdvertiserID { get; set; }
        public Advertiser Advertiser { get; set; }
    }
}
