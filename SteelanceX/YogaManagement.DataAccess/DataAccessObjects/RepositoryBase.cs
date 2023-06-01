using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using SteelanceX.Data.EF;
using YogaManagement.DataAccess.Helpers;
using static YogaManagement.DataAccess.Helpers.RecordKeyGenerator;

namespace SteelanceX.DataAccess.DataAccessObjects;

public abstract class RepositoryBase<T> where T : class
{
    private readonly SteelanceXDbContext _dbContext;
    private readonly IDistributedCache _cache;
    public DbSet<T> Data;

    public RepositoryBase(SteelanceXDbContext dbContext, IDistributedCache cache)
    {
        _dbContext = dbContext;
        _cache = cache;
        Data = _dbContext.Set<T>();
    }

    public async Task<IQueryable<T>> QueryAllAsync()
    {
        string recordKey = GenerateRecordKey<T>();
        List<T> cacheData = await _cache.GetRecordAsync<List<T>>(recordKey);
        var query = Data.AsQueryable();

        if (cacheData != null)
        {
            query = cacheData.AsQueryable();
        }
        else
        {
            await _cache.SetRecordAsync(recordKey, await query.ToListAsync());
        }

        return query;
    }

    public async Task CreateAsync(T entity)
    {
        _dbContext.Add(entity);
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
