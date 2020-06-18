using System;
using System.Collections.Generic;
using System.Linq;
using Poc.GraphQL.Api.Data.Entities;

namespace Poc.GraphQL.Api.Data
{
    public static class InitialData
    {
        public static void Seed(this IAGContext context)
        {
            if (!context.Airlines.Any())
            {
                context.Airlines.Add(new Airline
                {
                    Name = "Vueling",
                    LogoFileName = "vueling-logo.png",
                    Description = "Vueling ...",
                    NumberOfPlanes = 117,
                    Rating = 5,
                    CreatedAt = DateTimeOffset.Now.AddMonths(-1),
                    AirlineReviews = new List<AirlineReview>()
                    {
                        new AirlineReview()
                        {
                            Title = "Airbus A319",
                            Review = "Vueling's Airbus A319 seats 144 passengers in a single Economy class configuration."
                        },
                        new AirlineReview()
                        {
                            Title = "Airbus A320",
                            Review = "Vueling's Airbus A320 seats 180 passengers in a single Economy class configuration."
                        },
                        new AirlineReview()
                        {
                            Title = "Airbus A321",
                            Review = "Vueling's Airbus A321 seats 220 passengers in a single Economy class configuration."
                        }
                    }
                });

                context.Airlines.Add(new Airline
                {
                    Name = "Level",
                    LogoFileName = "level-logo.png",
                    Description = "Level ...",
                    NumberOfPlanes = 21,
                    Rating = 4,
                    CreatedAt = DateTimeOffset.Now.AddMonths(-1),
                    AirlineReviews = new List<AirlineReview>()
                    {
                        new AirlineReview()
                        {
                            Title = "Airbus A330-200",
                            Review = "The Airbus A330-300 aircraft of IAG subsidiary LEVEL are used on LEVEL's long-haul intercontinental flights."
                        },
                        new AirlineReview()
                        {
                            Title = "Airbus A321-200",
                            Review = "The Airbus A321-200 aircraft, of IAG subsidiary LEVEL, are primarily based at LEVEL's hub in Vienna, Austria and used on short-haul flights within Europe."
                        }
                    }
                });

                context.Airlines.Add(new Airline
                {
                    Name = "Iberia",
                    LogoFileName = "iberia-logo.png",
                    Description = "Iberia ...",
                    NumberOfPlanes = 100,
                    Rating = 2,
                    CreatedAt = DateTimeOffset.Now.AddMonths(-1),
                    AirlineReviews = new List<AirlineReview>()
                    {
                        new AirlineReview()
                        {
                            Title = "Airbus A330-200",
                            Review = "This aircraft operates on long-haul routes with 19 seats in Business Plus, and 269 seats in Economy Class, which Iberia refers to as Tourist Class."
                        },
                        new AirlineReview()
                        {
                            Title = "Bombardier CRJ-1000",
                            Review = "VueEconomy class offers an a la carte choice of food. This service is offered on all domestic."
                        }
                    }
                });

                context.Airlines.Add(new Airline
                {
                    Name = "British Airways",
                    LogoFileName = "british-airways-logo.png",
                    Description = "British Airways ...",
                    NumberOfPlanes = 80,
                    Rating = 3,
                    CreatedAt = DateTimeOffset.Now.AddMonths(-1),
                    AirlineReviews = new List<AirlineReview>()
                    {
                        new AirlineReview()
                        {
                            Title = "Boeing 747-400",
                            Review = "Currently, 31 of British Airways' 747-400s are configured with 52 Club World seats, as shown below."
                        }
                    }
                });

                context.Airlines.Add(new Airline
                {
                    Name = "Aer Lingus",
                    LogoFileName = "aer-lingus-logo.png",
                    Description = "Aer Lingus ...",
                    NumberOfPlanes = 8,
                    Rating = 1,
                    CreatedAt = DateTimeOffset.Now.AddMonths(-1),
                    AirlineReviews = new List<AirlineReview>()
                    {
                        new AirlineReview()
                        {
                            Title = "Boeing 757-200",
                            Review = "Aer Lingus' Boeing 752 features AVOD (Audio Video on Demand) in both classes."
                        }
                    }
                });

                context.SaveChanges();
            }
        }
    }
}
