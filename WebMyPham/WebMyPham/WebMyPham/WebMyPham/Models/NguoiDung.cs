namespace WebMyPham.Models
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NguoiDung")]
    public partial class NguoiDung
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
       

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string username { get; set; }

        [StringLength(50)]
        public string password { get; set; }

        public string quyen { get; set; }
        [StringLength(50)]
        public string hoten { get; set; }
        [StringLength(50)]
        public string email { get; set; }
        [StringLength(50)]
        public string diachi { get; set; }
       
        public int sdt  { get; set; }







    }
}