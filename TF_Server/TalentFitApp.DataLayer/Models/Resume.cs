using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TalentFitApp.DataLayer.Models;

public class Resume
{
    [Key]
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int? ResumeId { get; set; }
    [Required]
    public string FileName { get; set; }
    public string FilePath { get; set; }
    [Required]
    public int RV { get; set; }
    public bool? Active { get; set; }
    [Required]
    public DateTime Dc { get; set; }
    public DateTime? Dd { get; set; }
    [Required]
    public DateTime Lu { get; set; }
    [Required]
    public short UserId { get; set; }
    public User User { get; set; }
}
