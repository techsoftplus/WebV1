namespace ForManager94NgoThiNham.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tag")]
    public partial class Tag
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tag()
        {
            BaiVietTags = new HashSet<BaiVietTag>();
            KhuyenMais = new HashSet<KhuyenMai>();
            SanPhamTags = new HashSet<SanPhamTag>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Ma { get; set; }

        [Required]
        [StringLength(256)]
        public string Ten { get; set; }

        [Required]
        [StringLength(256)]
        public string UrlAlias { get; set; }

        public int Loai { get; set; }

        public bool HieuLuc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BaiVietTag> BaiVietTags { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KhuyenMai> KhuyenMais { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SanPhamTag> SanPhamTags { get; set; }
    }
}
