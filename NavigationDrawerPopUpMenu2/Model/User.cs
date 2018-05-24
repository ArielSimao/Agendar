namespace Agendar.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public class User
    {
        [Key]
        public int codigo { get; set; }

        [StringLength(50)]
        public string nome { get; set; }

        [StringLength(50)]
        public string senha { get; set; }

        [StringLength(50)]
        public string tipo { get; set; }

        [StringLength(50)]
        public string endereco { get; set; }

        [StringLength(50)]
        public string bairro { get; set; }

        [StringLength(50)]
        public string numero { get; set; }

        [StringLength(2)]
        public string estado { get; set; }

        [StringLength(50)]
        public string cidade { get; set; }

        [StringLength(15)]
        public string cpf { get; set; }

        [StringLength(20)]
        public string telefone { get; set; }
    }
}
