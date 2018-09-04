using Applicc.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Applicc.Models
{
    public class PessoaModel
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Nascimento { get; set; }
        [Required]
        public Sexo Sexo { get; set; }
    }
}