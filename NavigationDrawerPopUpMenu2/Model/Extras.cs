namespace Agendar.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Extras
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Extras()
        {
            Contratante = new HashSet<Contratante>();
        }

        [Key]
        public int codigo { get; set; }

        [StringLength(50)]
        public string sinc { get; set; }

        [StringLength(50)]
        public string dataShow { get; set; }

        [StringLength(50)]
        public string microfone { get; set; }

        [StringLength(50)]
        public string mesas { get; set; }

        [StringLength(50)]
        public string decoracao { get; set; }

        public int? quantidade { get; set; }

        [StringLength(20)]
        public string cor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contratante> Contratante { get; set; }
    }
}
