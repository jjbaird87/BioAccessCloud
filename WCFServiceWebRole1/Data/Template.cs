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
    
    public partial class Template
    {
        public int Template_ID { get; set; }
        public Nullable<short> FingerNumber { get; set; }
        public byte[] Template1 { get; set; }
        public int TemplateType_ID { get; set; }
        public int Employee_ID { get; set; }
        public Nullable<System.Guid> BioAccess_ID { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual TemplateType TemplateType { get; set; }
    }
}
