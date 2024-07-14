using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace ProjetoDev.Dominio.Dominio
{
    public class Aluno
    {
        [Key]
        public Guid Id { get; set; }

        public string? NomeAluno { get; set; }

        public string? Serie { get; set; }

        public string? Curso { get; set; }

        public string? Situacao { get; set; }

        public string? Ativo { get; set; }

        public Escola? Escola { get; set; }

        [ForeignKey("Escola")]
        public Guid Id_Escola { get; set; }
    }
}
