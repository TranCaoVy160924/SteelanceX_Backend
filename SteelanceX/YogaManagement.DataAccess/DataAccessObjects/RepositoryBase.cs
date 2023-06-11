using Microsoft.EntityFrameworkCore;
using SteelanceX.Data.EF;

namespace SteelanceX.DataAccess.DataAccessObjects;

public abstract class RepositoryBase<T> where T : class
{
    private readonly SteelanceXDbContext _dbContext;
    public DbSet<T> Data;

    public RepositoryBase(SteelanceXDbContext dbContext)
    {
        _dbContext = dbContext;
        Data = _dbContext.Set<T>();
    }

    public IQueryable<T> QueryAll() => Data.AsQueryable();

    public async Task<T> Get(int id) => await Data.FindAsync(id);

    public async Task CreateAsync(T entity)
    {
        _dbContext.Add(entity);
        await _dbContext.SaveChangesAsync();
    }

    public async Task CreateBatchAsync(ICollection<T> entities)
    {
        _dbContext.AddRange(entities);
        await _dbContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(T entity)
    {
        var track = _dbContext.Attach(entity);
        track.State = EntityState.Modified;
        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(T entity)
    {
        _dbContext.Remove(entity);
        await _dbContext.SaveChangesAsync();
    }
}
