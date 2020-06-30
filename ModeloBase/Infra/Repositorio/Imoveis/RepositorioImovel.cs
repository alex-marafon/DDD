using Domain.Entidades;
using Domain.Interfaces.Imoveis;
using Infra.Repositorio.Generico;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repositorio.Imoveis
{
    public class RepositorioImovel : RepositorioGenerico<Imovel>, InterfaceImovel
    {
    }
}
