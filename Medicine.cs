//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HospitalDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Medicine
    {
        public string MedName { get; set; }
        public int MedId { get; set; }
        public Nullable<int> MedPrice { get; set; }
        public Nullable<int> PatientId { get; set; }
    
        public virtual Patient Patient { get; set; }
    }
}
