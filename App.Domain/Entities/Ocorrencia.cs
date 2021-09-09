using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Entities
{
    public class Ocorrencia
    {
        [Key]
        public Guid Id { get; set; }
        public Guid PessoaId { get; set; }
        public DateTime Dataocorrencia { get; set; }
        public DateTime? DataBaixaOcorrencia { get; set; }
        public string Observacao { get; set; }
        public Pessoa Pessoa { get; set; }

    }
}
