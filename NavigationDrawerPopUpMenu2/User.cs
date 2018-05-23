namespace Agendar.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [Key]
        public int codigo { get; set; }

        [Required]
        [StringLength(50)]
        public string nome { get; set; }

        [Required]
        [StringLength(50)]
        public string password { get; set; }

        public string tipo { get; set; }

        [StringLength(50)]
        public string endereco { get; set; }

        [StringLength(50)]
        public string bairro { get; set; }

        public int? numero { get; set; }

        [StringLength(50)]
        public string estado { get; set; }

        [StringLength(10)]
        public string cidade { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? cpf { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? telefone { get; set; }
    }
}
