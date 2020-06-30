using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces.Genericos
{
    public interface InterfaceGenerica<T> where T : class
    {
        void Adicionar(T Objetos);
        
        void Atualizar(T Objetos);
        
        void Excluir(T Objetos);
        
        void ObterId(int Id);

        IList<T> Listar();

    }
}
