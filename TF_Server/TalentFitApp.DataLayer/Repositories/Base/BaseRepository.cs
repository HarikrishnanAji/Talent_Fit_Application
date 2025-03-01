using System;
using System.Collections;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using TalentFitApp.DataLayer.Interfaces.Base;

namespace TalentFitApp.DataLayer.Repositories.Base;

public class BaseRepository<T> : IBaseRepository<T> where T : class
{
    protected readonly DbSet<T> _dbset;
    public BaseRepository(DbSet<T> dbset)
    {
        _dbset = dbset;
    }
    public IQueryable<T> GetAll() => _dbset.AsQueryable();
}
