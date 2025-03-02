using System;
using TalentFitApp.DataLayer.Models;

namespace TalentFitApp.DataLayer.Interfaces;

public interface IUserRepository
{
    Task<User> GetUserByIdAsync(int userId);
}
