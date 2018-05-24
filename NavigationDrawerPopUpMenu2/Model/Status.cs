namespace Agendar.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Status
    {
        [Key]
        public int codigo { get; set; }

        [StringLength(50)]
        public string situacao { get; set; }

        public int? id_contratante { get; set; }

        public virtual Contratante Contratante { get; set; }
    }
}
