using System;
using System.Collections;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;
using TalentFitApp.DataLayer.Context;
namespace TalentFitApp.DataLayer.Repositories.Base;

public class BaseRepository<T> where T : class
{
    private readonly DbSet<T> _dbset;
    private readonly DbContext _dbContext;
    private readonly ILogger _logger;

    public BaseRepository(DbContext dbContext,ILogger logger)
    {
        _dbset = dbContext.Set<T>();
        _dbContext = dbContext;
        _logger = logger;
    }

    public async Task<IEnumerable<T>> GetAllAsync()=> await _dbset.ToListAsync();
    public async Task<T?> GetByIdAsync(short id) =>await _dbset.FindAsync(id);
    public async Task<T> CreateAsync(T entity)
    {
        try
        {
            await _dbContext.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }
        catch(Exception ex)
        {
            _logger.LogError(ex.Message);
        }
        return entity;
    }
    public async Task<T> UpdateAsync(T entity)
    {     
        try
        {
            _dbContext.Update(entity);
            await _dbContext.SaveChangesAsync();
        }
        catch(Exception ex)
        {
            _logger.LogError(ex.Message);
        }
        return entity;
    }

}
