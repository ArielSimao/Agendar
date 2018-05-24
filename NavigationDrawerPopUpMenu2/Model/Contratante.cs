namespace Agendar.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Contratante")]
    public partial class Contratante
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Contratante()
        {
            Status = new HashSet<Status>();
        }

        [Key]
        public int codigo { get; set; }

        [StringLength(50)]
        public string responsavel { get; set; }

        [StringLength(20)]
        public string email { get; set; }

        [StringLength(20)]
        public string cpf { get; set; }

        [StringLength(20)]
        public string rg { get; set; }

        [StringLength(20)]
        public string telefone { get; set; }

        [StringLength(20)]
        public string celular { get; set; }

        [StringLength(50)]
        public string titulo { get; set; }

        public DateTime? dataInicio { get; set; }

        public DateTime? horaInicio { get; set; }

        public DateTime? dataFim { get; set; }

        public DateTime? horaFim { get; set; }

        [StringLength(20)]
        public string sala { get; set; }

        public int? qtdPessoas { get; set; }

        public int? id_extra { get; set; }

        public int? id_cafe { get; set; }

        public virtual Cafe Cafe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Status> Status { get; set; }

        public virtual Extras Extras { get; set; }
    }
}
