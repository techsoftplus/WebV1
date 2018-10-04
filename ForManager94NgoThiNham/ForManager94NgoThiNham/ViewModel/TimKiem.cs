namespace ForManager94NgoThiNham.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TimKiem")]
    public partial class TimKiem
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(256)]
        public string TuKhoa { get; set; }

        public int PhanLoai { get; set; }

        public int SapXep { get; set; }

        public DateTime NgayTao { get; set; }
    }
}
