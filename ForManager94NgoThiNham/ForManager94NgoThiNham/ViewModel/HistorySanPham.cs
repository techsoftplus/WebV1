namespace ForManager94NgoThiNham.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HistorySanPham")]
    public partial class HistorySanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HistorySanPham()
        {
            MaVachSanPhams = new HashSet<MaVachSanPham>();
            MaVachSanPhams1 = new HashSet<MaVachSanPham>();
        }

        public Guid Id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HistorySanPhamId { get; set; }

        [Required]
        [StringLength(50)]
        public string Ma { get; set; }

        [Required]
        [StringLength(500)]
        public string TieuDe { get; set; }

        public int PhanLoai { get; set; }

        public int TrangThai { get; set; }

        public string ThongDiep { get; set; }

        [StringLength(128)]
        public string NguoiTaoId { get; set; }

        public DateTime NgayTao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaVachSanPham> MaVachSanPhams { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaVachSanPham> MaVachSanPhams1 { get; set; }
    }
}
