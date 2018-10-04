namespace ForManager94NgoThiNham.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MaVach")]
    public partial class MaVach
    {
        public Guid Id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaVachId { get; set; }

        [Required]
        [StringLength(50)]
        public string Ma { get; set; }

        public int TrangThai { get; set; }

        public DateTime NgayTao { get; set; }
    }
}
