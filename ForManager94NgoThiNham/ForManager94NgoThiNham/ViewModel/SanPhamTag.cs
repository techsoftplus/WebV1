namespace ForManager94NgoThiNham.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPhamTag")]
    public partial class SanPhamTag
    {
        public Guid Id { get; set; }

        public Guid SanPhamId { get; set; }

        public int TagId { get; set; }

        public int SapXep { get; set; }

        public virtual SanPham SanPham { get; set; }

        public virtual Tag Tag { get; set; }
    }
}
