using System;
using System.Collections;
using Microsoft.EntityFrameworkCore;
using TalentFitApp.DataLayer.Context;
namespace TalentFitApp.DataLayer.Repositories.Base;

public class BaseRepository<T> where T : class
{
    protected readonly DbSet<T> _dbset;

    public ApplicationDBContext AppDBContext { get; }

    public BaseRepository(DbSet<T> dbset)
    {
        _dbset = dbset;
    }

    public BaseRepository(ApplicationDBContext appDBContext)
    {
        AppDBContext = appDBContext;
    }

    public IQueryable<T> GetAllAsync() => _dbset.AsQueryable();
    public async Task<T?> GetByIdAsync(int id) =>await _dbset.FindAsync(id);
    public async Task CreateAsync(T entity)=> await _dbset.AddAsync(entity);
    public async Task UpdateAsync(T entity)=> _dbset.Update(entity);
}
