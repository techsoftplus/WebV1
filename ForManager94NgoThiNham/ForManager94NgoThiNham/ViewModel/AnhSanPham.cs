namespace ForManager94NgoThiNham.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AnhSanPham")]
    public partial class AnhSanPham
    {
        public Guid Id { get; set; }

        public Guid SanPhamId { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AnhSanPhamId { get; set; }

        [Required]
        [StringLength(256)]
        public string UrlPhoto { get; set; }

        [Required]
        [StringLength(256)]
        public string TieuDe { get; set; }

        [StringLength(256)]
        public string MoTa { get; set; }

        public int PhanLoai { get; set; }

        public int SapXep { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
