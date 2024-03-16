using System.Linq.Expressions;

namespace Hackaton.Fiap.Grupo02.Domain.Interfaces.Repositories;

public interface IRepository<T>
{
    T? GetVideoById(int id);
    T? Carregar(Expression<Func<T, bool>> predicate);
    void InsertVideo(T entity);
    void UpdateVideoRegistry(T entity);
    void DEleteVideoRegistryById(int id);
    IEnumerable<T> GetAllSavedVideos();
    IEnumerable<T> ListarWhere(Expression<Func<T, bool>> predicate);
    int QuantidadeRegistros();
    int QuantidadeRegistrosWhre(Expression<Func<T, bool>> predicate);
    ICollection<T> Get(params Expression<Func<T, object>>[] includes);

}