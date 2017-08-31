using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyShow.Entities
{
    public class Movie
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<string> Languages { get; set; }

        public Genre Genre { get; set; }

        public int DurationInMinutes { get; set; }

        public string Summary { get; set; }

        public MovieCertificate Certificate { get; set; }

        public MovieCast Cast { get; set; }

        public MovieCrew Crew { get; set; }
    }

    public enum Genre
    {
        Comedy,
        Drama,
        Horror
    }

    public class MovieCertificate
    {

    }

    public class MovieCast
    {
        public List<Actor> Actors { get; set; }
    }

    public class MovieCrew
    {
        public List<Director> Directors { get; set; }

        public List<Producer> Producers { get; set; }
    }

    public class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }

    public class Director : Person
    {

    }

    public class Producer : Person
    {

    }

    public class Actor : Person
    {

    }

    public class Ticket
    {
        public int Id { get; set; }

        public int MovieId { get; set; }

        public Seat Seat { get; set; }

        public string ScreenNumber { get; set; }

        public DateTime ShowTime { get; set; }

        public string TheatreId { get; set; }

        public Money Price { get; set; }
    }

    public class Money
    {
        public decimal Amount { get; set; }

        public string Currency { get; set; }

    }

    public class Seat
    {
        public int Number { get; set; }

        public string Row { get; set; }

        public SeatClass Class { get; set; }
    }

    public enum SeatClass
    {
        Platinum,
        Gold,
        Silver
    }

    public class Auditorium
    {
        public int Id { get; set; }

        public int Capacity { get; set; }
        
        public SeatMap SeatMap { get; set; }

    }
    
    public class SeatMap
    {
        public List<AuditoriumRow> Rows { get; set; }

    }

    public class AuditoriumRow
    {
        public string Name { get; set; }

        public List<AuditoriumSpace> Space { get; set; }
        
    }

    public class SeatRow : AuditoriumRow
    {
        public SeatClass SeatClass { get; }
    }

    public class AuditoriumSpace
    {
        
    }

    public class SeatSpace : AuditoriumSpace
    {
        public SeatAvailabilityStatus Status { get; set; }
    }

    public enum SeatAvailabilityStatus
    {
        Available,
        Booked
    }

    public class ScreenSpace : AuditoriumSpace
    {

    }

    public class EmptySpace : AuditoriumSpace
    {

    }

    public class StairSpace : AuditoriumSpace
    {

    }

    public class Theatre
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string ChainCode { get; set; }

        public List<Auditorium> Auditoriums { get; set; }

        public List<Amenity> Amenities { get; set; }
    }

    public class Amenity
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }

    public class Show
    {
        public Duration Duration { get; set; }
        
        public int AuditoriumId { get; set; }

        public string TheatreId { get; set; }

        public Duration Interval { get; set; }

        public List<X> Rates { get; set; }

        public string Language { get; set; }
    }

    public class MovieShow : Show
    {
        public int MovieId { get; set; }
    }

    public class X
    {
        public Money Price { get; set; }

        public SeatClass SeatClass { get; set; }

    }

    public class Duration
    {
        public DateTime EndTime { get; set; }

        public DateTime StartTime { get; set; }
    }
}