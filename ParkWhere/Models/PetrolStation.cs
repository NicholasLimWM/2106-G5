//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ParkWhere.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PetrolStation
    {
        public int Id { get; set; }
        public string petrolStationName { get; set; }
        public string address { get; set; }
        public Nullable<double> latitude { get; set; }
        public Nullable<double> longitude { get; set; }
    }
}
