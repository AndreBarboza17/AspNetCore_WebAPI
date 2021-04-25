using DevIO.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Business.Interfaces
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        /// <summary>
        /// Retorna lista de produtos por fornecedor
        /// </summary>
        /// <param name="fornecedor"></param>
        /// <returns></returns>
        Task<IEnumerable<Produto>> ObterProdutosPorFornecedor(Guid fornecedorId);

        /// <summary>
        /// Lista de Produtos e Fornecedor do produto
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Produto>> ObterProdutoFornecedores();

        /// <summary>
        /// Retorna o Produto e o Fornecedor
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Produto> ObterProdutoFornecedor(Guid id);
    }
}
