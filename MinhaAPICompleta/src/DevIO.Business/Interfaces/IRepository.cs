using DevIO.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Business.Interfaces
{
    /// <summary>
    /// Repositório genérico para persistir dados
    /// IDisposable - Obriga que o diretorio faça o disposable
    /// where obriga que todas as classes que implementem essa interface sejam filhas de Entity
    /// </summary>    
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {
        Task Adicionar(TEntity entity);

        Task<TEntity> ObtertPorId(Guid id);
        
        Task<List<TEntity>> ObterTodos();

        Task Atualizar(TEntity entity);

        Task Remover(Guid id);

        Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate);

        Task<int> SaveChanges();
    }
}
