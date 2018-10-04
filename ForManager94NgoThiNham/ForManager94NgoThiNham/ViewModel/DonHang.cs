namespace ForManager94NgoThiNham.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DonHang")]
    public partial class DonHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DonHang()
        {
            DonHangItems = new HashSet<DonHangItem>();
        }

        public Guid Id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DonHangId { get; set; }

        [Required]
        [StringLength(128)]
        public string KhachHangId { get; set; }

        public int TinhId { get; set; }

        public int QuanHuyenId { get; set; }

        [Required]
        [StringLength(256)]
        public string DiaChi { get; set; }

        public Guid? GiamGiaId { get; set; }

        public Guid? BangGiaShipId { get; set; }

        [Required]
        [StringLength(50)]
        public string MaDonHang { get; set; }

        [StringLength(50)]
        public string MaGiamGia { get; set; }

        public int SoTienGiam { get; set; }

        public int GiaShip { get; set; }

        public bool VAT { get; set; }

        public int TongThanhToan { get; set; }

        [StringLength(500)]
        public string GhiChuKhachHang { get; set; }

        [StringLength(500)]
        public string GhiChuNoiBo { get; set; }

        [StringLength(500)]
        public string GhiChuChamSoc { get; set; }

        public int? NguonMuaHang { get; set; }

        public int? CachThucGiao { get; set; }

        public int? DonViVanChuyen { get; set; }

        [StringLength(128)]
        public string NguoiTiepNhanId { get; set; }

        public DateTime? NgayTiepNhan { get; set; }

        [StringLength(128)]
        public string NguoiXuLyKhoId { get; set; }

        public DateTime? NgayXuLyKho { get; set; }

        [StringLength(128)]
        public string NguoiVanChuyenId { get; set; }

        public DateTime? NgayVanChuyen { get; set; }

        [StringLength(128)]
        public string NguoiChamSocId { get; set; }

        public DateTime? NgayChamSoc { get; set; }

        [StringLength(128)]
        public string NguoiHuyId { get; set; }

        public DateTime? NgayHuy { get; set; }

        [StringLength(500)]
        public string LyDoHuy { get; set; }

        public int TrangThaiId { get; set; }

        public DateTime NgayTao { get; set; }

        public virtual GiamGia GiamGia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonHangItem> DonHangItems { get; set; }
    }
}
