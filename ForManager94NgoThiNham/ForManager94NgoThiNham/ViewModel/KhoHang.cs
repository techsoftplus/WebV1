namespace ForManager94NgoThiNham.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhoHang")]
    public partial class KhoHang
    {
        public Guid Id { get; set; }

        public int TinhId { get; set; }

        public Guid SanPhamId { get; set; }

        public int SoLuong { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
