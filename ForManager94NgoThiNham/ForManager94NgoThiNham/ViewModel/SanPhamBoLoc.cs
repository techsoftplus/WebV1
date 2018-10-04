namespace ForManager94NgoThiNham.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPhamBoLoc")]
    public partial class SanPhamBoLoc
    {
        public Guid Id { get; set; }

        public Guid SanPhamId { get; set; }

        public int BoLocId { get; set; }

        public DateTime NgayTao { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
