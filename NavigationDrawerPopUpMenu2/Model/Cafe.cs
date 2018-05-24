namespace Agendar.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cafe")]
    public partial class Cafe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cafe()
        {
            Contratante = new HashSet<Contratante>();
        }

        [Key]
        public int codigo { get; set; }

        [StringLength(50)]
        public string bolo { get; set; }

        [StringLength(50)]
        public string torrada { get; set; }

        [StringLength(50)]
        public string paoQueijo { get; set; }

        [StringLength(50)]
        public string paoManteiga { get; set; }

        [Column("cafe")]
        [StringLength(50)]
        public string cafe1 { get; set; }

        [StringLength(50)]
        public string cha { get; set; }

        [StringLength(50)]
        public string suco { get; set; }

        [StringLength(50)]
        public string refrigerante { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contratante> Contratante { get; set; }
    }
}
