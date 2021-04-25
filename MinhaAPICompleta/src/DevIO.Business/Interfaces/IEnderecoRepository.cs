using DevIO.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Business.Interfaces
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        /// <summary>
        /// Obtem o Endereco pelo ID do Fornecedor
        /// </summary>
        /// <param name="fornecedorId"></param>
        /// <returns></returns>
        Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId);
    }
}
