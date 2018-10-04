namespace ForManager94NgoThiNham.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LienHe")]
    public partial class LienHe
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(256)]
        public string HoVaTen { get; set; }

        [Required]
        [StringLength(50)]
        public string Sdt { get; set; }

        [Required]
        [StringLength(256)]
        public string Email { get; set; }

        [StringLength(500)]
        public string NoiDung { get; set; }

        public DateTime NgayTao { get; set; }
    }
}
