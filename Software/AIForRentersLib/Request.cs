//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AIForRentersLib
{
    using System;
    using System.Collections.Generic;
    
    public partial class Request
    {
        public int RequestID { get; set; }
        public string Property { get; set; }
        public string Unit { get; set; }
        public System.DateTime FromDate { get; set; }
        public System.DateTime ToDate { get; set; }
        public double PriceUponRequest { get; set; }
        public bool Confirmed { get; set; }
        public bool Processed { get; set; }
        public bool Sent { get; set; }
        public int NumberOfPeople { get; set; }
        public string ResponseSubject { get; set; }
        public string ResponseBody { get; set; }
        public int ClientID { get; set; }
    
        public virtual Client Client { get; set; }
    }
}
