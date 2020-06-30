using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Entidades
{
    public class Base
    {
        public Base()
        {
            Id= Guid.NewGuid();
        }

        [Display(Name ="Codigo")]
        public Guid Id { get;  set; }

        [Display(Name ="Nome")]
        public string Nome { get;  set; }

    }
}
