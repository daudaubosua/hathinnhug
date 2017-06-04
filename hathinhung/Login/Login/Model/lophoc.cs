namespace Login.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("lophoc")]
    public partial class lophoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lophoc()
        {
            hocsinhs = new HashSet<hocsinh>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ma { get; set; }

        [StringLength(50)]
        public string ten { get; set; }

        [StringLength(50)]
        public string cahoc { get; set; }

        public int? siso { get; set; }

        public int? giaovienday { get; set; }

        public virtual giaovien giaovien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hocsinh> hocsinhs { get; set; }
    }
}
