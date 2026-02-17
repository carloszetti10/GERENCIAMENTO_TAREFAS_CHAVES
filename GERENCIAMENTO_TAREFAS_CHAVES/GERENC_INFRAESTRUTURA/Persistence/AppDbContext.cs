
using GERENC_DOMAIN.Entities;
using GERENC_DOMAIN.Entities.Curso;
using GERENC_DOMAIN.Entities.Pessoas;
using GERENC_DOMAIN.Entities.Sala;
using GERENC_DOMAIN.Entities.Usuario;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;


namespace GERENC_INFRAESTRUTURA.Persistence
{
    public class AppDbContext : DbContext
    {
        public DbSet<InstrutorModel> Instrutores { get; set; }
        public DbSet<AgenteModel> Agentes { get; set; }
        public DbSet<FuncionarioModel> Funcionarios { get; set; }
        public DbSet<PorteiroModel> Porteiros { get; set; }
        public DbSet<PessoaBaseModel> Pessoas { get; set; }
        public DbSet<CategoriaModel> Categorias { get; set; }
        public DbSet<UsuarioBaseModel> Usuarios { get; set; }
        public DbSet<Adm> Administradores { get; set; }
        public DbSet<SalaModel> Salas { get; set; }
        public DbSet<ChaveModel> Chaves { get; set; }
        public DbSet<CursoModel> Cursos { get; set; }
        public DbSet<PessoaCategoria> PessoaCategoria { get; set; }
        public DbSet<CursoCategoria> CursoCategoria{ get; set; }
        public DbSet<SalaCategoria> SalaCategoria { get; set; }


        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }




    }
}
