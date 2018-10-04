namespace ForManager94NgoThiNham.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MaVachSanPham")]
    public partial class MaVachSanPham
    {
        public Guid Id { get; set; }

        public Guid SanPhamId { get; set; }

        public Guid? HistoryPrintSanPhamId { get; set; }

        public Guid? HistoryActiveSanPhamId { get; set; }

        [Required]
        [StringLength(50)]
        public string Ma { get; set; }

        [StringLength(50)]
        public string Sdt { get; set; }

        public Guid? CuaHangId { get; set; }

        public Guid? NguoiKichHoatId { get; set; }

        public DateTime? NgayKichHoat { get; set; }

        public DateTime? NgayHetHan { get; set; }

        public Guid? NguoiDoiTraId { get; set; }

        public Guid? SanPhamDoiTraId { get; set; }

        public DateTime? NgayDoiTra { get; set; }

        [StringLength(200)]
        public string LyDoDoiTra { get; set; }

        public int TrangThai { get; set; }

        public virtual HistorySanPham HistorySanPham { get; set; }

        public virtual HistorySanPham HistorySanPham1 { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
