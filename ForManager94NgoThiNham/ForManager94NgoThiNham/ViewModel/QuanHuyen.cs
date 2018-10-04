namespace ForManager94NgoThiNham.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QuanHuyen")]
    public partial class QuanHuyen
    {
        public int Id { get; set; }

        public int TinhId { get; set; }

        [Required]
        [StringLength(50)]
        public string Ma { get; set; }

        [Required]
        [StringLength(256)]
        public string Ten { get; set; }

        public int SapXep { get; set; }

        public bool HieuLuc { get; set; }

        public virtual Tinh Tinh { get; set; }
    }
}
