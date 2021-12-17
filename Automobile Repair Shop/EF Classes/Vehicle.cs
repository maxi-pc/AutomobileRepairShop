namespace Automobile_Repair_Shop.EF_Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Vehicle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vehicle()
        {
         //   Services = new HashSet<Service>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VehicleId { get; set; }

        [Required]
        [StringLength(50)]
        public string VehiclePlateNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string VehicleStatus { get; set; }

        [Required]
        [StringLength(50)]
        public string VehicleModel { get; set; }

        [Required]
        [StringLength(50)]
        public string VehicleMake { get; set; }

     //   [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
     //   public virtual ICollection<Service> Services { get; set; }
    }
}
