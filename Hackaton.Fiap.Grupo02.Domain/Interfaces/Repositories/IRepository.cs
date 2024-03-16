using System.Linq.Expressions;

namespace Hackaton.Fiap.Grupo02.Domain.Interfaces.Repositories;

public interface IRepository<T>
{
    T? GetVideoById(int id);
    T? Upload(Expression<Func<T, bool>> predicate);
    void InsertVideo(T entity);
    void UpdateVideoRegistry(T entity);
    void DeleteVideoById(int id);
    IEnumerable<T> GetAllUploads();
    IEnumerable<T> ListarWhere(Expression<Func<T, bool>> predicate);
    int GetRegistryQuantity();
    int GetRegistryQuantityByCondition(Expression<Func<T, bool>> predicate);
    ICollection<T> Get(params Expression<Func<T, object>>[] includes);

}