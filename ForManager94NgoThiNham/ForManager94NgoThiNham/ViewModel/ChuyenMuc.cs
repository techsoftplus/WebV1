namespace ForManager94NgoThiNham.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChuyenMuc")]
    public partial class ChuyenMuc
    {
        public int Id { get; set; }

        public int? ChuyenMucChaId { get; set; }

        [Required]
        [StringLength(50)]
        public string Ma { get; set; }

        [Required]
        [StringLength(256)]
        public string Ten { get; set; }

        [Required]
        [StringLength(256)]
        public string UrlAlias { get; set; }

        [StringLength(500)]
        public string MoTa { get; set; }

        [StringLength(256)]
        public string UrlPhoto { get; set; }

        [StringLength(500)]
        public string ChuyenMucCon { get; set; }

        public string Breadcrumb { get; set; }

        public int PhanLoai { get; set; }

        public int SapXep { get; set; }

        public bool HieuLuc { get; set; }
    }
}
