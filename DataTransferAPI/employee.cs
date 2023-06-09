//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataTransferAPI
{
    using System;
    using System.Collections.Generic;
    
    public partial class employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public employee()
        {
            this.absences = new HashSet<absence>();
            this.working_period = new HashSet<working_period>();
        }
    
        public System.Guid guid { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public System.Guid gender_guid { get; set; }
        public System.DateTime date_of_birth { get; set; }
        public System.DateTime date_in_service { get; set; }
        public System.DateTime date_out_service { get; set; }
        public System.Guid department_guid { get; set; }
        public long wage_per_day { get; set; }
        public string address { get; set; }
        public string telephone_fix_number { get; set; }
        public string mobile_number { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<absence> absences { get; set; }
        public virtual department department { get; set; }
        public virtual gender gender { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<working_period> working_period { get; set; }
    }
}
