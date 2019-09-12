using System;

namespace QuickBuy.Dominio.Contratos
{
    public interface IBaseRepositorio<TEntity> : IDisposable where TEntity : class
    {
        void Adicionar(TEntity tentity);
        TEntity ObterPorId(int id);
        IEnumerable<TEntity> ObterTodos();
        void Atualizar(TEntity entity);
        void Remover(TEntity entity);






    }
}
