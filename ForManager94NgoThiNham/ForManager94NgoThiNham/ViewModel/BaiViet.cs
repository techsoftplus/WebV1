namespace ForManager94NgoThiNham.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaiViet")]
    public partial class BaiViet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BaiViet()
        {
            BaiVietTags = new HashSet<BaiVietTag>();
        }

        public Guid Id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BaiVietId { get; set; }

        public int ChuyenMucId { get; set; }

        [StringLength(50)]
        public string Ma { get; set; }

        [Required]
        [StringLength(256)]
        public string TieuDe { get; set; }

        [Required]
        [StringLength(500)]
        public string UrlAlias { get; set; }

        [StringLength(256)]
        public string UrlPhoto { get; set; }

        [Required]
        [StringLength(500)]
        public string MoTa { get; set; }

        [Required]
        public string NoiDung { get; set; }

        public string Breadcrumb { get; set; }

        public string SanPhams { get; set; }

        [StringLength(70)]
        public string TitleMeta { get; set; }

        [StringLength(160)]
        public string DescriptionMeta { get; set; }

        [StringLength(500)]
        public string KeywordMeta { get; set; }

        public string TuKhoa { get; set; }

        public DateTime NgayDang { get; set; }

        public DateTime? NgaySua { get; set; }

        [StringLength(128)]
        public string NguoiSuaId { get; set; }

        public DateTime NgayTao { get; set; }

        [Required]
        [StringLength(128)]
        public string NguoiTaoId { get; set; }

        public int TrangThai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BaiVietTag> BaiVietTags { get; set; }
    }
}
