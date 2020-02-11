using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TwitchPartnership2020.Data;

namespace TwitchPartnership2020.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider sp)
        {
            using (var context = new DataContext(
                sp.GetRequiredService<DbContextOptions<DataContext>>()))
            {
                context.Database.EnsureCreated();

                if (context.Advertisers.Any())
                    return;

                var adv = new Advertiser
                {
                    Contacts = "88005553535 proshe pozvonit chem sosat",
                    Name = "Jopa Jopnaya",
                    Description = "Zaem Deneg",

                    Purse = new Purse
                    {
                        CurrentBalance = 5000,
                        UnconfirmedBalance = 837,
                        Status = 0
                    },
                    
                    Auth = new Auth
                    {
                        Login = "Natasha",
                        Password = "123",
                        Email = "sosat@lezhat.da"
                    },

                };
                context.Advertisers.AddRange(adv);
                //context.Purses.AddRange(adv.Purse);
                //context.Auths.AddRange(adv.Auth);
                context.SaveChanges();
            }
        }
    }
}
