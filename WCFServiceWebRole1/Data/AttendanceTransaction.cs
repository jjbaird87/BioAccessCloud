//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFServiceWebRole1.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class AttendanceTransaction
    {
        public int AttendanceTransaction_ID { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int Employee_ID { get; set; }
        public string EMEI { get; set; }
        public short InOut { get; set; }
        public bool Downloaded { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}
