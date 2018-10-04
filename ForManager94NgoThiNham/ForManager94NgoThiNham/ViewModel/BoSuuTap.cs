namespace ForManager94NgoThiNham.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BoSuuTap")]
    public partial class BoSuuTap
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(256)]
        public string UrlPhoto { get; set; }

        [Required]
        [StringLength(256)]
        public string TieuDe { get; set; }

        [Required]
        [StringLength(256)]
        public string MoTa { get; set; }

        [StringLength(500)]
        public string Link { get; set; }

        public int PhanLoai { get; set; }

        public int DisplayMode { get; set; }

        public DateTime? NgayBatDau { get; set; }

        public DateTime? NgayKetThuc { get; set; }

        public int SapXep { get; set; }

        public bool HieuLuc { get; set; }

        public DateTime? NgayTao { get; set; }
    }
}
