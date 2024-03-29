namespace DotNetMidtermC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Hug
    {
        public int HugId { get; set; }

        [Required]
        [StringLength(100)]
        public string Hugee { get; set; }
        [Display(Name = "Type")]
        public int HugTypeId { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "Hug Date")]
        public DateTime HugDate { get; set; }

        public virtual HugType HugType { get; set; }
    }
}
