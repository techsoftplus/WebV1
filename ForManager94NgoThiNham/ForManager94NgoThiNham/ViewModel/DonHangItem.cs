namespace ForManager94NgoThiNham.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DonHangItem")]
    public partial class DonHangItem
    {
        public Guid Id { get; set; }

        public Guid DonHangId { get; set; }

        public Guid? KhoHangId { get; set; }

        public Guid SanPhamId { get; set; }

        public int MauSacId { get; set; }

        public int SoLuong { get; set; }

        public int DonGia { get; set; }

        public int ThanhTien { get; set; }

        public virtual DonHang DonHang { get; set; }

        public virtual MauSac MauSac { get; set; }
    }
}
