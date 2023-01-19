using eMovieTickets.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace eMovieTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using(var serviceScope=applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                //Cinemas
                if(!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name="cinema 1",
                            CinemaLogo="http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description="This is the Description Of the First Cinema"
                        },
                         new Cinema()
                        {
                            Name="cinema 2",
                            CinemaLogo="http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description="This is the Description Of the Second Cinema"
                        },
                          new Cinema()
                        {
                            Name="cinema 3",
                            CinemaLogo="http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Description="This is the Description Of the Third Cinema"
                        }
                    });
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName="Actor 1",
                            ProfilePictureURL="http://dotnethow.net/images/actors/actor-1.jpeg",
                            Bio="This is the Bio Of First Actor"
                        },
                        new Actor()
                        {
                             FullName="Actor 2",
                            ProfilePictureURL="http://dotnethow.net/images/actors/actor-2.jpeg",
                            Bio="This is the Bio Of Second Actor"
                        },
                        new Actor()
                        {   
                            FullName = "Actor 3",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-3.jpeg", 
                            Bio = "This is the Bio Of Third Actor"}
                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                           
                            FullName="Producer 1",
                            ProfilePictureURL="http://dotnethow.net/images/producers/producer-1.jpeg",
                            Bio="This is the Bio Of First Producer"
                        },
                        new Producer()
                        {
                             FullName="Producer 2",
                            ProfilePictureURL="http://dotnethow.net/images/producers/producer-2.jpeg",
                            Bio="This is the Bio Of Second Producer"
                        },
                        new Producer()
                        {
                            FullName="Producer 3",
                            ProfilePictureURL="http://dotnethow.net/images/producers/producer-3.jpeg",
                            Bio="This is the Bio Of Third Producer"
                        }
                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {

                            Name="Scoob",
                            Description="This is the Scoob movie description",
                            Price=39.50,
                            ImageURL="http://dotnethow.net/images/movies/movie-7.jpeg",
                            StartDate=DateTime.Now.AddDays(-10),
                            EndDate=DateTime.Now.AddDays(-2),
                            CinemaId=1,
                            ProducerId=3,
                            MovieCategory=Enums.MovieCategory.Cartoon
                        },
                         new Movie()
                        {

                            Name="Cold Sales",
                            Description="This is the Cold Sales movie description",
                            Price=39.50,
                            ImageURL="http://dotnethow.net/images/movies/movie-8.jpeg",
                            StartDate=DateTime.Now.AddDays(3),
                            EndDate=DateTime.Now.AddDays(20),
                            CinemaId=1,
                            ProducerId=2,
                            MovieCategory=Enums.MovieCategory.Drama
                        },
                         new Movie()
                        {

                            Name="Ghost",
                            Description="This is the Ghost movie description",
                            Price=39.50,
                            ImageURL="http://dotnethow.net/images/movies/movie-4.jpeg",
                            StartDate=DateTime.Now,
                            EndDate=DateTime.Now.AddDays(7),
                            CinemaId=3,
                            ProducerId=1,
                            MovieCategory=Enums.MovieCategory.Horror
                        }
                    });
                    context.SaveChanges();
                }
                //Actors_Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId=1,
                            MovieId=4

                        },
                        new Actor_Movie()
                        {
                            ActorId=2,
                            MovieId=5

                        },
                        new Actor_Movie()
                        {
                            ActorId=3,
                            MovieId=6

                        },
                    });
                    context.SaveChanges();
                }

            }
        }
    }
}
