
namespace BuyMoviez
{
    using System;
    using System.Collections.Generic;

    public partial class Movies
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Release { get; set; }
        public string Director { get; set; }
        public string Producer { get; set; }
        public string Genre { get; set; }
        public int Sales { get; set; }

        public virtual Movie Movie { get; set; }
    }
}
