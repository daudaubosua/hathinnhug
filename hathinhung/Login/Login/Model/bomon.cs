namespace Login.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("bomon")]
    public partial class bomon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public bomon()
        {
            giaoviens = new HashSet<giaovien>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ma { get; set; }

        [StringLength(50)]
        public string ten { get; set; }

        public string gioithieu { get; set; }

        [StringLength(20)]
        public string sodienthoai { get; set; }

        public string diachi { get; set; }

        [StringLength(20)]
        public string email { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<giaovien> giaoviens { get; set; }
    }
}
