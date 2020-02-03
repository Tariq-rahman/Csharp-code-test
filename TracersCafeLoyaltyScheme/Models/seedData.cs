using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TracersCafeLoyaltyScheme.Data;
using System;
using System.Linq;

namespace TracersCafeLoyaltyScheme.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TracersCafeLoyaltySchemeContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<TracersCafeLoyaltySchemeContext>>()))
            {
                // Look for any movies.
                if (context.Customer.Any())
                {
                    return;   // DB has been seeded
                }

                context.Customer.AddRange(
                    new Customer
                    {
                        Title = Title.Mr,
                        Firstname = "Bob",
                        Lastname = "Jones",
                        Adress1 = "123 yellow lane",
                        Adress2 = "kings heath",
                        Adress3 = "West Midlands",
                        Adress4 = "Birmingham",
                        Postcode = "B19 8MN",
                        Telephone = "12345678901",
                        Age = 49
                    },

                    new Customer
                    {
                        Title = Title.Mrs,
                        Firstname = "Mary",
                        Lastname = "Jones",
                        Adress1 = "123 yellow lane",
                        Adress2 = "kings heath",
                        Adress3 = "West Midlands",
                        Adress4 = "Birmingham",
                        Postcode = "B19 8MN",
                        Telephone = "12346678901",
                        Age = 46
                    },

                    new Customer
                    {
                        Title = Title.Mr,
                        Firstname = "Fred",
                        Lastname = "Flanders",
                        Adress1 = "123 brown lane",
                        Adress2 = "",
                        Adress3 = "",
                        Adress4 = "Springfield",
                        Postcode = "S19 8MN",
                        Telephone = "02345678901",
                        Age = 35
                    },

                    new Customer
                    {
                        Title = Title.Miss,
                        Firstname = "Jen",
                        Lastname = "Smith",
                        Adress1 = "321 Conventry road",
                        Adress2 = "Yardley",
                        Adress3 = "West Midlands",
                        Adress4 = "Birmingham",
                        Postcode = "B21 8MN",
                        Telephone = "12775678901",
                        Age = 25
                    }
                );
                context.SaveChanges();
            }
        }
    }
}