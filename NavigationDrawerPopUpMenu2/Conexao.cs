namespace Agendar.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Conexao : DbContext
    {
        public Conexao()
            : base("name=Conexao")
        {
        }

        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Login>()
                .Property(e => e.mail)
                .IsUnicode(false);

            modelBuilder.Entity<Login>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.nome)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.tipo)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.endereco)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.bairro)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.estado)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.cidade)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.cpf)
                .HasPrecision(18, 0);

            modelBuilder.Entity<User>()
                .Property(e => e.telefone)
                .HasPrecision(18, 0);
        }
    }
}
