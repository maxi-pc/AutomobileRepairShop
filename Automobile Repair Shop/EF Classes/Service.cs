namespace Automobile_Repair_Shop.EF_Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Service")]
    public partial class Service
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ServiceId { get; set; }

        public int ClientId { get; set; }

        public int VehicleId { get; set; }

        public int EmployeeId { get; set; }

        public int PartId { get; set; }

        [Column(TypeName = "date")]
        public DateTime ServiceStartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ServiceEndDate { get; set; }

        public decimal ServiceCost { get; set; }

        public string ServiceLocation { get; set; }

        public virtual Client Client { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Inventory Inventory { get; set; }

        public virtual Vehicle Vehicle { get; set; }
    }
}
