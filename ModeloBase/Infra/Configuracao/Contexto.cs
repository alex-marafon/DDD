using Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Configuracao
{
   public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options): base(options)
        {

        }



        public DbSet<Imovel> Imovels { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuild)
        {
            if (!optionsBuild.IsConfigured)
            {
                optionsBuild.UseSqlServer(GetStringConextionConfig());
                base.OnConfiguring(optionsBuild);
            }
        }

        private string GetStringConextionConfig()
        {
            string strCon = "Server=(local);Database=DB_DDD;Trusted_Connection=true;MultipleActiveResultSets=true;";
            return strCon;
        }
    }
}
