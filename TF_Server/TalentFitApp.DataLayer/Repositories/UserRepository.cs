using System;
using Microsoft.EntityFrameworkCore;
using TalentFitApp.DataLayer.Context;
using TalentFitApp.DataLayer.Interfaces;
using TalentFitApp.DataLayer.Models;
using TalentFitApp.DataLayer.Repositories.Base;

namespace TalentFitApp.DataLayer.Repositories;

public class UserRepository:BaseRepository<User>,IUserRepository
{
    protected readonly ApplicationDBContext _appDBContext;
    public UserRepository(ApplicationDBContext appDBContext):base(appDBContext)
    {
        appDBContext = appDBContext;
    }
    // public async Task<IQueryable<User>> GetUserAsync()
    // {
    //      return await GetAllAsync();
    // }
    public async Task<User> GetUserByIdAsync(int userId)
    {
         return await GetByIdAsync(userId);
    }
}
