namespace Agendar.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Login")]
    public partial class Login
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string mail { get; set; }

        [Required]
        [StringLength(50)]
        public string password { get; set; }
    }
}
