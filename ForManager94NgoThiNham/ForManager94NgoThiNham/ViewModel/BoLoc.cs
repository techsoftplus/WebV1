namespace ForManager94NgoThiNham.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BoLoc")]
    public partial class BoLoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BoLoc()
        {
            BoLocExes = new HashSet<BoLocEx>();
        }

        public int Id { get; set; }

        public int NhomLocId { get; set; }

        public int ChuyenMucId { get; set; }

        [Required]
        [StringLength(50)]
        public string Ma { get; set; }

        [Required]
        [StringLength(256)]
        public string Ten { get; set; }

        [Required]
        [StringLength(256)]
        public string TenVietTat { get; set; }

        public bool DaChon { get; set; }

        public int SapXep { get; set; }

        public bool HieuLuc { get; set; }

        public virtual NhomLoc NhomLoc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BoLocEx> BoLocExes { get; set; }
    }
}
