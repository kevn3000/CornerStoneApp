//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CornerStoneApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Child
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Child()
        {
            this.Tasks = new HashSet<Task>();
        }
    
        [Key]
        public int Child_Id { get; set; }
        public string Child_First_Name { get; set; }
        public string Child_Last_Name { get; set; }
        public int Diagn_Id { get; set; }
        public int Advo_Id { get; set; }
        
    
        public virtual Diagnosis Diagnosis { get; set; }
        public virtual Child Child1 { get; set; }
        public virtual Child Child2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
