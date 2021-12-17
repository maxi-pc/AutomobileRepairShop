namespace Automobile_Repair_Shop.EF_Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
         //   Services = new HashSet<Service>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }

        [StringLength(50)]
        public string EmployeeFName { get; set; }

        [StringLength(50)]
        public string EmployeeLName { get; set; }

        [StringLength(50)]
        public string EmployeePhone { get; set; }

        [Required]
        [StringLength(50)]
        public string EmployeeAddress { get; set; }

       // [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
      //  public virtual ICollection<Service> Services { get; set; }
    }
}
