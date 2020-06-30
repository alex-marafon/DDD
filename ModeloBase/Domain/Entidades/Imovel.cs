using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Entidades
{
   public class Imovel : Base
    {
        [Display(Name ="Endereço")]
        public string Endereco { get; set; }

        public decimal Valor { get; set; }

        [Display(Name ="Descrição")]
        public string Descricao { get; set; }

    }
}
