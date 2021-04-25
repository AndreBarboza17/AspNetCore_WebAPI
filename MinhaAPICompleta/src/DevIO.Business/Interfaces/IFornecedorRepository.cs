using DevIO.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Business.Interfaces
{
    public interface IFornecedorRepository : IRepository<Fornecedor>
    {
        /// <summary>
        /// Obtem o Fornecedor e o Endereco
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Fornecedor> ObterFornecedorEndereco(Guid id);

        /// <summary>
        /// Obtem o Fornecedor, Endereco e a lista de Produtos do Fornecedor
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid id);
    }
}
