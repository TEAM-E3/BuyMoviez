
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyMoviez
{

    public enum MovieType { Horror, Comedy, SciFi, Action, Documentaries }
    public class Movie
    {
        public string Name { get; set; }

        public string Image { get; set; }
        public string Director { get; set; }
        public DateTime MovieRelease { get; set; }
        public string Description { get; set; }
        private decimal _price;
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public static decimal TotalPrice;
        public MovieType MovieGenre { get; set; }

        //this is for testing program
        public decimal Wallet { get; set; }

        public void BuyMovie(decimal amount)
        {
            Wallet -= amount;
        }

        public void RefundMovie(decimal amount)
        {
            Wallet += amount;
        }




        public Movie(string name, DateTime movieRelease, string director, string description, decimal price, MovieType movieGenre)
        {
            Name = name;
            MovieRelease = movieRelease;
            Price = price;
            Director = director;
            Description = description;
            MovieGenre = movieGenre;

        }

        public Movie()
        {

        }

        public override string ToString()
        {
            return $"{Name} - {Director} / Release Date : {MovieRelease.ToShortDateString()} (PRICE) {Price.ToString("C") }";

        }


    }
}
