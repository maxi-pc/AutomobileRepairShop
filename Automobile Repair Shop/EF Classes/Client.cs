namespace Automobile_Repair_Shop.EF_Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]

        public Client()
        {
            
           // Services = new HashSet<Service>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClientId { get; set; }

        [StringLength(50)]
        public string ClientFName { get; set; }

        [StringLength(50)]
        public string ClientLName { get; set; }

        [StringLength(50)]
        public string ClientPhone { get; set; }

        [Required]
        [StringLength(50)]
        public string ClientAddress { get; set; }

    //    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
     //   public virtual ICollection<Service> Services { get; set; }
    }
}
