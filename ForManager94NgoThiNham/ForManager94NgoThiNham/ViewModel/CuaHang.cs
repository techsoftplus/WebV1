namespace ForManager94NgoThiNham.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CuaHang")]
    public partial class CuaHang
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Ma { get; set; }

        [StringLength(500)]
        public string Anh { get; set; }

        [Required]
        [StringLength(256)]
        public string Ten { get; set; }

        public int TinhId { get; set; }

        public int QuanHuyenId { get; set; }

        [Required]
        [StringLength(500)]
        public string DiaChi { get; set; }

        [StringLength(500)]
        public string GioMoCua { get; set; }

        [StringLength(500)]
        public string LienHe { get; set; }

        public int PhanLoai { get; set; }

        public bool HieuLuc { get; set; }

        [Required]
        [StringLength(128)]
        public string NguoiTaoId { get; set; }

        public DateTime NgayTao { get; set; }
    }
}
