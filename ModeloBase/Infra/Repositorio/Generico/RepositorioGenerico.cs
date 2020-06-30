using Domain.Interfaces.Genericos;
using Infra.Configuracao;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infra.Repositorio.Generico
{
    public class RepositorioGenerico<T> : InterfaceGenerica<T>, IDisposable where T : class
    {

        private readonly DbContextOptions<Contexto> _OptionBuilder;

        public RepositorioGenerico()
        {
            _OptionBuilder = new DbContextOptions<Contexto>();
        }




        public void Adicionar(T Objetos)
        {
           using (var banco = new Contexto(_OptionBuilder))
            {
                banco.Set<T>().Add(Objetos);
                banco.SaveChangesAsync();

            }
        }

        public void Atualizar(T Objetos)
        {
            using (var banco = new Contexto(_OptionBuilder))
            {
                banco.Set<T>().Update(Objetos);
                banco.SaveChangesAsync();

            }
        }


        public void Excluir(T Objetos)
        {
            using (var banco = new Contexto(_OptionBuilder))
            {
                banco.Set<T>().Remove(Objetos);
                banco.SaveChangesAsync();

            }
        }

        public IList<T> Listar()
        {
            using (var banco = new Contexto(_OptionBuilder))
            {
                return banco.Set<T>().AsNoTracking().ToList();               

            }
        }

        public void  ObterId(int Id)
        {
            using (var banco = new Contexto(_OptionBuilder))
            {
                 banco.Set<T>().Find(Id);

            }
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
            GC.SuppressFinalize(true);
        }
    }
}
