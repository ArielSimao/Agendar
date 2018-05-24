namespace Agendar.Model {
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Banco : DbContext {
        public Banco()
            : base("name=Banco") {
        }

        public virtual DbSet<Cafe> Cafe { get; set; }
        public virtual DbSet<Contratante> Contratante { get; set; }
        public virtual DbSet<Extras> Extras { get; set; }
        public virtual DbSet<Sala1> Sala1 { get; set; }
        public virtual DbSet<Sala2> Sala2 { get; set; }
        public virtual DbSet<Sala3> Sala3 { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Entity<Cafe>()
                .Property(e => e.bolo)
                .IsUnicode(false);

            modelBuilder.Entity<Cafe>()
                .Property(e => e.torrada)
                .IsUnicode(false);

            modelBuilder.Entity<Cafe>()
                .Property(e => e.paoQueijo)
                .IsUnicode(false);

            modelBuilder.Entity<Cafe>()
                .Property(e => e.paoManteiga)
                .IsUnicode(false);

            modelBuilder.Entity<Cafe>()
                .Property(e => e.cafe1)
                .IsUnicode(false);

            modelBuilder.Entity<Cafe>()
                .Property(e => e.cha)
                .IsUnicode(false);

            modelBuilder.Entity<Cafe>()
                .Property(e => e.suco)
                .IsUnicode(false);

            modelBuilder.Entity<Cafe>()
                .Property(e => e.refrigerante)
                .IsUnicode(false);

            modelBuilder.Entity<Cafe>()
                .HasMany(e => e.Contratante)
                .WithOptional(e => e.Cafe)
                .HasForeignKey(e => e.id_cafe);

            modelBuilder.Entity<Contratante>()
                .Property(e => e.responsavel)
                .IsUnicode(false);

            modelBuilder.Entity<Contratante>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Contratante>()
                .Property(e => e.cpf)
                .IsUnicode(false);

            modelBuilder.Entity<Contratante>()
                .Property(e => e.rg)
                .IsUnicode(false);

            modelBuilder.Entity<Contratante>()
                .Property(e => e.telefone)
                .IsUnicode(false);

            modelBuilder.Entity<Contratante>()
                .Property(e => e.celular)
                .IsUnicode(false);

            modelBuilder.Entity<Contratante>()
                .Property(e => e.titulo)
                .IsUnicode(false);

            modelBuilder.Entity<Contratante>()
                .Property(e => e.sala)
                .IsUnicode(false);

            modelBuilder.Entity<Contratante>()
                .HasMany(e => e.Status)
                .WithOptional(e => e.Contratante)
                .HasForeignKey(e => e.id_contratante);

            modelBuilder.Entity<Extras>()
                .Property(e => e.sinc)
                .IsUnicode(false);

            modelBuilder.Entity<Extras>()
                .Property(e => e.dataShow)
                .IsUnicode(false);

            modelBuilder.Entity<Extras>()
                .Property(e => e.microfone)
                .IsUnicode(false);

            modelBuilder.Entity<Extras>()
                .Property(e => e.mesas)
                .IsUnicode(false);

            modelBuilder.Entity<Extras>()
                .Property(e => e.decoracao)
                .IsUnicode(false);

            modelBuilder.Entity<Extras>()
                .Property(e => e.cor)
                .IsUnicode(false);

            modelBuilder.Entity<Extras>()
                .HasMany(e => e.Contratante)
                .WithOptional(e => e.Extras)
                .HasForeignKey(e => e.id_extra);

            modelBuilder.Entity<Sala1>()
                .Property(e => e.dia)
                .IsUnicode(false);

            modelBuilder.Entity<Sala1>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<Sala2>()
                .Property(e => e.dia)
                .IsUnicode(false);

            modelBuilder.Entity<Sala2>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<Sala3>()
                .Property(e => e.dia)
                .IsUnicode(false);

            modelBuilder.Entity<Sala3>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<Status>()
                .Property(e => e.situacao)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.nome)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.senha)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.tipo)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.endereco)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.bairro)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.numero)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.estado)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.cidade)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.cpf)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.telefone)
                .IsUnicode(false);
        }
    }
}
