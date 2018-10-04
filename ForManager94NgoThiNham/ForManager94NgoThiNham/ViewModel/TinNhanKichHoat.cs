namespace ForManager94NgoThiNham.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TinNhanKichHoat")]
    public partial class TinNhanKichHoat
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Sdt { get; set; }

        [StringLength(50)]
        public string MaVach { get; set; }

        [Required]
        [StringLength(500)]
        public string TinNhan { get; set; }

        [Required]
        [StringLength(500)]
        public string ThongBao { get; set; }

        public int TrangThaiKichHoat { get; set; }

        public int TrangThaiGuiTin { get; set; }

        public DateTime NgayCapNhat { get; set; }

        public DateTime NgayTao { get; set; }
    }
}
