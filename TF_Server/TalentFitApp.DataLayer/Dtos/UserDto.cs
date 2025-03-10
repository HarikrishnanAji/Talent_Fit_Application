using System;
using System.ComponentModel.DataAnnotations;
using TalentFitApp.DataLayer.Models;

namespace TalentFitApp.DataLayer.Dtos;

public class UserDto
{

    public short? UserId { get; set; }
    [Required(ErrorMessage ="Please enter a user name")]
    public string UserName { get; set; }
    [Required(ErrorMessage ="Please enter a email")]
    public string Email { get; set; }
    [Required(ErrorMessage ="Please enter a password")]
    public string PasswordHash { get; set; }
    [Required]
    public short RV { get; set; }
    [Required]
    public bool IsAdmin { get; set; }
    public bool? Active { get; set; }
    [Required]
    public DateTime Dc { get; set; }
    public DateTime? Dd { get; set; }
    [Required]
    public DateTime Lu { get; set; }
    public ICollection<Resume> Resumes { get; set; }
}
