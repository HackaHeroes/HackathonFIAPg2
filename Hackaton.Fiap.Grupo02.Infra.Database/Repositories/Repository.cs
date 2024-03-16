using Microsoft.EntityFrameworkCore;
using Hackaton.Fiap.Grupo02.Domain.Entities;
using Hackaton.Fiap.Grupo02.Domain.Interfaces.Repositories;
using System.Linq.Expressions;

namespace Hackaton.Fiap.Grupo02.Infra.Database.Repositories;

public class Repository<T> : IRepository<T> where T : BaseEntity
{
    protected SistemaDbContext Context;
    public Repository(SistemaDbContext context)
    {
        Context = context;
    }
    public void UpdateVideoRegistry(T entity)
    {
        Context.Set<T>().Update(entity);
        Context.SaveChanges();
    }

    public T? Carregar(Expression<Func<T, bool>> predicate)
    {
        return Context.Set<T>().FirstOrDefault(predicate);
    }

    public T? GetVideoById(int id) => Context.Set<T>().FirstOrDefault(m => m.Id == id);

    public void DEleteVideoRegistryById(int id)
    {
        var entity = Context.Set<T>().Find(id);
        if (entity != null)
        {
            Context.Set<T>().Remove(entity);
            Context.SaveChanges();
        }
    }

    public void InsertVideo(T entity)
    {
        Context.Set<T>().Add(entity);
        Context.SaveChanges();
    }

    public IEnumerable<T> GetAllSavedVideos()
    {
        try
        {
            var retorno = Context.Set<T>().ToList();
            return retorno;
        }
        catch (TaskCanceledException ex)
        {
            return null;
        }

    }

    public IEnumerable<T> ListarWhere(Expression<Func<T, bool>> predicate)
    {
        return Context.Set<T>().Where(predicate).ToList();
    }

    public int QuantidadeRegistros()
    {
        return Context.Set<T>().Count();
    }

    public int QuantidadeRegistrosWhre(Expression<Func<T, bool>> predicate)
    {
        return Context.Set<T>().Where(predicate).Count();
    }


    public ICollection<T> Get(params Expression<Func<T, object>>[] includes)
    {
        var retorno = includes
            .Aggregate(Context.Set<T>().AsQueryable(),
                (entity, property) => entity.Include(property))
            .ToList();
        return retorno;
    }
}