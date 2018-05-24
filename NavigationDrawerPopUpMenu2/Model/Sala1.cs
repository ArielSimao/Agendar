namespace Agendar.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sala1
    {
        [Key]
        public int codigo { get; set; }

        public DateTime? horaInicio { get; set; }

        public DateTime? horaFim { get; set; }

        [StringLength(50)]
        public string dia { get; set; }

        [StringLength(50)]
        public string status { get; set; }
    }
}
