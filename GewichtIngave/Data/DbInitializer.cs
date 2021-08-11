using GewichtIngave.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GewichtIngave.Data
{
    public class DbInitializer
    {
        public static void Seed(GewichtDbContext context)
        {
            context.Database.EnsureCreated();
            DateTime date1 = new DateTime(2010, 8, 1, 16, 0, 0);
            DateTime date2 = new DateTime(2010, 8, 18, 16, 0, 0);

            if (context.Wegingen.Any())
            {
                return;
            }
            var GewichtLijst = new List<GewichtModel>()
            {
            new GewichtModel {Datum= date1, Gewicht=83, Comment="ok"},
            new GewichtModel {Datum= date2, Gewicht=87, Comment="niet ok"},
            };
            foreach (var gewicht in GewichtLijst)
            {
                context.Wegingen.Add(gewicht);
            }
            context.SaveChanges();
        }
    }
}
