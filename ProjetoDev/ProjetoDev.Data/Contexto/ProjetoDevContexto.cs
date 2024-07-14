using Microsoft.EntityFrameworkCore;
using ProjetoDev.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDev.Data.Contexto
{
    public class ProjetoDevContexto : DbContext
    {
        public ProjetoDevContexto(DbContextOptions options)
            :base(options) 
        {
            
        }

        public DbSet<Aluno> Alunos { get; set; }

        public DbSet<Escola> Escolas { get; set; }
    }
}
