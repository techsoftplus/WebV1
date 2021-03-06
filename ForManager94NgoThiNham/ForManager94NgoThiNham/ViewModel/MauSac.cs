namespace ForManager94NgoThiNham.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MauSac")]
    public partial class MauSac
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MauSac()
        {
            DonHangItems = new HashSet<DonHangItem>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Ma { get; set; }

        [Required]
        [StringLength(256)]
        public string Ten { get; set; }

        public int SapXep { get; set; }

        public bool HieuLuc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonHangItem> DonHangItems { get; set; }
    }
}
