namespace WebMyPham.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HangSX")]
    public partial class HangSX
    {
        [Key]
        [StringLength(10)]
        public string idhangsx { get; set; }

        [StringLength(50)]
        public string tenhang { get; set; }

        [StringLength(50)]
        public string website { get; set; }

        [StringLength(50)]
        public string lienhe { get; set; }

        [StringLength(50)]
        public string mota { get; set; }
    }
}
