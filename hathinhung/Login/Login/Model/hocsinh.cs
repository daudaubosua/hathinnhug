namespace Login.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("hocsinh")]
    public partial class hocsinh
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ma { get; set; }

        [StringLength(50)]
        public string hoten { get; set; }

        public DateTime? ngaysinh { get; set; }

        [StringLength(10)]
        public string gioitinh { get; set; }

        public int? lop { get; set; }

        [StringLength(20)]
        public string hocluc { get; set; }

        [StringLength(20)]
        public string hanhkiem { get; set; }

        [StringLength(50)]
        public string chucvu { get; set; }

        public int? giaovienchunhiem { get; set; }

        public string diachi { get; set; }

        public virtual giaovien giaovien { get; set; }

        public virtual lophoc lophoc { get; set; }
    }
}
