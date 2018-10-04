namespace ForManager94NgoThiNham.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhuyenMai")]
    public partial class KhuyenMai
    {
        public Guid Id { get; set; }

        public int TagId { get; set; }

        public DateTime TuNgay { get; set; }

        public DateTime DenNgay { get; set; }

        public DateTime TuGio { get; set; }

        public DateTime DenGio { get; set; }

        public bool HieuLuc { get; set; }

        public virtual Tag Tag { get; set; }
    }
}
