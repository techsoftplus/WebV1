namespace ForManager94NgoThiNham.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AnhChuyenMuc")]
    public partial class AnhChuyenMuc
    {
        public Guid Id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AnhChuyenMucId { get; set; }

        public int ChuyenMucId { get; set; }

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

        public DateTime? NgayBatDau { get; set; }

        public DateTime? NgayKetThuc { get; set; }

        public int PhanLoai { get; set; }

        public int DisplayMode { get; set; }

        public int SapXep { get; set; }

        public bool HieuLuc { get; set; }

        public DateTime? NgayTao { get; set; }
    }
}
