using System;
using Microsoft.EntityFrameworkCore;
using TalentFitApp.DataLayer.Models;

namespace TalentFitApp.DataLayer.Context;

public class ApplicationDBContext:DbContext
{
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options){}

    public DbSet<User> Users { get; set; }
    public DbSet<Resume> Resumes { get; set; }
    public DbSet<ResumeAnalysisResult> ResumeAnalysisResults { get; set; }
}
