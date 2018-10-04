namespace ForManager94NgoThiNham.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            AnhSanPhams = new HashSet<AnhSanPham>();
            KhoHangs = new HashSet<KhoHang>();
            MaVachSanPhams = new HashSet<MaVachSanPham>();
            SanPhamBoLocs = new HashSet<SanPhamBoLoc>();
            SanPhamChuyenMucs = new HashSet<SanPhamChuyenMuc>();
            SanPhamTags = new HashSet<SanPhamTag>();
        }

        public Guid Id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SanPhamId { get; set; }

        [Required]
        [StringLength(50)]
        public string Ma { get; set; }

        [Required]
        [StringLength(256)]
        public string TieuDe { get; set; }

        [Required]
        [StringLength(500)]
        public string UrlAlias { get; set; }

        [Required]
        [StringLength(256)]
        public string UrlPhoto { get; set; }

        public string DacDiem { get; set; }

        [Required]
        public string GioiThieu { get; set; }

        [Required]
        public string ThongSoKyThuat { get; set; }

        public string BaoHanh { get; set; }

        public int? ThoiHanBaoHanh { get; set; }

        public string Breadcrumb { get; set; }

        [Required]
        [StringLength(500)]
        public string ChuyenMucs { get; set; }

        [Required]
        [StringLength(500)]
        public string MauSacs { get; set; }

        [StringLength(500)]
        public string Tags { get; set; }

        public int? GiamTru { get; set; }

        public int? GiaCu { get; set; }

        public int GiaMoi { get; set; }

        [StringLength(256)]
        public string AnhVideo { get; set; }

        [StringLength(256)]
        public string UrlVideo { get; set; }

        [StringLength(500)]
        public string MotaVideo { get; set; }

        [StringLength(256)]
        public string TieuDeIn { get; set; }

        [StringLength(200)]
        public string NhaSanXuatIn { get; set; }

        [StringLength(200)]
        public string DiaChiSanXuatIn { get; set; }

        [StringLength(100)]
        public string XuatXuIn { get; set; }

        [StringLength(50)]
        public string NamSanXuatIn { get; set; }

        [StringLength(50)]
        public string DinhLuongIn { get; set; }

        [StringLength(200)]
        public string ThongSoKyThuatIn { get; set; }

        [StringLength(100)]
        public string ChatLieuIn { get; set; }

        [StringLength(100)]
        public string MauSacIn { get; set; }

        [StringLength(200)]
        public string HuongDanIn { get; set; }

        [StringLength(200)]
        public string CanhBaoIn { get; set; }

        [StringLength(200)]
        public string NhapKhauIn { get; set; }

        [StringLength(200)]
        public string DiaChiCongTyIn { get; set; }

        [StringLength(70)]
        public string TitleMeta { get; set; }

        [StringLength(160)]
        public string DescriptionMeta { get; set; }

        [StringLength(500)]
        public string KeywordMeta { get; set; }

        public string TuKhoa { get; set; }

        public DateTime? NgayDang { get; set; }

        public DateTime NgaySua { get; set; }

        [Required]
        [StringLength(128)]
        public string NguoiSuaId { get; set; }

        public DateTime NgayTao { get; set; }

        [Required]
        [StringLength(128)]
        public string NguoiTaoId { get; set; }

        public int TrangThai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AnhSanPham> AnhSanPhams { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KhoHang> KhoHangs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaVachSanPham> MaVachSanPhams { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SanPhamBoLoc> SanPhamBoLocs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SanPhamChuyenMuc> SanPhamChuyenMucs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SanPhamTag> SanPhamTags { get; set; }
    }
}
