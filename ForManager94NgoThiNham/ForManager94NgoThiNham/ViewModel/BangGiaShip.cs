namespace ForManager94NgoThiNham.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BangGiaShip")]
    public partial class BangGiaShip
    {
        public Guid Id { get; set; }

        public int TinhId { get; set; }

        public int QuanHuyenId { get; set; }

        public int GiaShip { get; set; }
    }
}
