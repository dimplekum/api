//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusinessObjects
{
    using System;
    using System.Collections.Generic;
    
    public partial class EMPLOYEE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EMPLOYEE()
        {
            this.EMPLOYEE_SALARY = new HashSet<EMPLOYEE_SALARY>();
        }
    
        public int ID { get; set; }
        public string FIRST_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string ADDRESS { get; set; }
        public string EMPLOYEE_ID { get; set; }
        public string CONTACT_NO { get; set; }
        public Nullable<bool> PERMANENT_EMPLOYEE { get; set; }
        public Nullable<int> DEPARTMENT_ID { get; set; }
        public Nullable<int> DESIGINATION_ID { get; set; }
    
        public virtual DEPARTMENT DEPARTMENT { get; set; }
        public virtual DESIGINATION DESIGINATION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPLOYEE_SALARY> EMPLOYEE_SALARY { get; set; }
    }
}
