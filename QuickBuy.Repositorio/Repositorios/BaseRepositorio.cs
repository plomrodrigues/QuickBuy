using System.Collections.Generic;
using System.Linq;
using QuickBuy.Dominio.Contratos;
using QuickBuy.Repositorio.Contexto;

namespace QuickBuy.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        private readonly QuickBuyContexto _quickBuyContexto;

        public BaseRepositorio(QuickBuyContexto quickBuyContexto)
        {
            _quickBuyContexto = quickBuyContexto;
        }

        public void Adicionar(TEntity entity)
        {
            _quickBuyContexto.Set<TEntity>().Add(entity);
        }

        public void Atualizar(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public TEntity ObterPorId(int id)
        {
            return _quickBuyContexto.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return _quickBuyContexto.Set<TEntity>().ToList();
        }

        public void Remover(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}
