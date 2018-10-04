namespace ForManager94NgoThiNham.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaiVietTag")]
    public partial class BaiVietTag
    {
        public Guid Id { get; set; }

        public Guid BaiVietId { get; set; }

        public int TagId { get; set; }

        public int SapXep { get; set; }

        public virtual BaiViet BaiViet { get; set; }

        public virtual Tag Tag { get; set; }
    }
}
