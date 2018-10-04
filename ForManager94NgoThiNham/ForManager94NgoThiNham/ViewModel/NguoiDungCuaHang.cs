namespace ForManager94NgoThiNham.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NguoiDungCuaHang")]
    public partial class NguoiDungCuaHang
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(128)]
        public string NguoiDungId { get; set; }

        public Guid CuaHangId { get; set; }
    }
}
