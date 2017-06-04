namespace Login.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("giaovien")]
    public partial class giaovien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public giaovien()
        {
            hocsinhs = new HashSet<hocsinh>();
            lophocs = new HashSet<lophoc>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ma { get; set; }

        [StringLength(50)]
        public string ten { get; set; }

        public DateTime? ngaysinh { get; set; }

        [StringLength(10)]
        public string gioitinh { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        public int? dienthoai { get; set; }

        public int? giangday { get; set; }

        public int? bomonma { get; set; }

        public int? chunhiemlop { get; set; }

        public decimal? luongcoban { get; set; }

        public virtual bomon bomon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hocsinh> hocsinhs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lophoc> lophocs { get; set; }
    }
}
