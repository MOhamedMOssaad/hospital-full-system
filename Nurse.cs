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
    
    public partial class Nurse
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Nurse()
        {
            this.Patients = new HashSet<Patient>();
        }
    
        public int NurseId { get; set; }
        public string NurseTel { get; set; }
        public string NurseEmail { get; set; }
        public string NurseAddress { get; set; }
        public string NurseName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Patient> Patients { get; set; }
    }
}
