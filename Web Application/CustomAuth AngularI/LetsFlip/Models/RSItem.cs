//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LetsFlip.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class RSItem
    {
        public int ID { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }
        public Nullable<bool> isMember { get; set; }
        public Nullable<int> SellAverage { get; set; }
        public Nullable<int> BuyAverage { get; set; }
        public Nullable<int> OverAverage { get; set; }
        public Nullable<int> HighAlch { get; set; }
        public Nullable<int> LowAlch { get; set; }
        public Nullable<int> StorePrice { get; set; }
    }
}