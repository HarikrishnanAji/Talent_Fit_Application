using System;
using TalentFitApp.DataLayer.Models;

namespace TalentFitApp.DataLayer.Interfaces;

public interface IUserRepository
{
    Task<IEnumerable<User>> GetAllUserAsync();
    Task<User> GetUserByIdAsync(short userId);
}
