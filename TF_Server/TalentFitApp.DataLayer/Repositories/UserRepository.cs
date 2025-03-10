using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TalentFitApp.DataLayer.Context;
using TalentFitApp.DataLayer.Dtos;
using TalentFitApp.DataLayer.Interfaces;
using TalentFitApp.DataLayer.Models;
using TalentFitApp.DataLayer.Repositories.Base;

namespace TalentFitApp.DataLayer.Repositories;

public class UserRepository:BaseRepository<User>,IUserRepository
{
    protected readonly ApplicationDBContext _appDBContext;
    protected readonly ILogger _logger;
    public UserRepository(ApplicationDBContext appDBContext,ILogger logger):base(appDBContext,logger)
    {
        _appDBContext = appDBContext;
        _logger = logger;
    }
    public async Task<IEnumerable<User>> GetAllUserAsync()
    {
         return await GetAllAsync();
    }
    public async Task<User> GetUserByIdAsync(short userId)
    {
         return await GetByIdAsync(userId);
    }
    public async Task CreateUser(UserDto entity)
    {   
        User user = new User();
        user.UserName = entity.UserName;
        user.Email = entity.Email;
        user.PasswordHash = entity.PasswordHash;
        user.Active = entity.Active;
        user.Dc = entity.Dc;
        user.Dd = entity.Dd;
        user.Lu = entity.Lu;
        await CreateAsync(user);
    }
    public async Task UpdateUser(UserDto entity)
    {
        if(entity.UserId != null)
        {
            var user = await GetByIdAsync((short)entity.UserId);
            if(user == null){}
            user.UserName = entity.UserName;
            user.Email = entity.Email;
            user.PasswordHash = entity.PasswordHash;
            user.Active = entity.Active;
            user.Dc = entity.Dc;
            user.Dd = entity.Dd;
            user.Lu = entity.Lu;
            await CreateAsync(user);

        }
    }
}
