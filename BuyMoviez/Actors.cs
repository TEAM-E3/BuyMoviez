//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BuyMoviez
{
    using System;
    using System.Collections.Generic;
    
    public partial class Actors
    {
        public int Id { get; set; }
        public string Actor1 { get; set; }
        public string Actor2 { get; set; }
        public string Actor3 { get; set; }
        public int MovieId { get; set; }
    
        public virtual Movie Movie { get; set; }
    }
}