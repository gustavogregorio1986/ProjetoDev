using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjetoDev.Dominio.Dominio
{
    public class Escola
    {
        [Key]
        public Guid Id { get; set; }

        public string? NomeEscola { get; set; }
    }
}
