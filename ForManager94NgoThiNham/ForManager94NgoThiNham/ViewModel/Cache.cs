namespace ForManager94NgoThiNham.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cache")]
    public partial class Cache
    {
        [Key]
        [StringLength(50)]
        public string Key { get; set; }

        [Required]
        public string Value { get; set; }

        public DateTime? ExpiryDate { get; set; }
    }
}
