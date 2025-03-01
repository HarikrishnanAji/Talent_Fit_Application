using System;
using System.ComponentModel.DataAnnotations;

namespace TalentFitApp.DataLayer.Models;

public class ResumeAnalysisResult
{
       public int ResumeAnalysisResultId { get; set; }
        [Required(ErrorMessage ="Please enter a candidate name")]
        public string CandidateName { get; set; } = string.Empty;
        [Required(ErrorMessage ="Please enter a email")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Please enter a phone")]
        public string Phone { get; set; }
        [Required(ErrorMessage ="Please enter skills")]
        public List<string> Skills { get; set; } = new();
        [Required(ErrorMessage ="Please enter your experience(in years)")]
        public float ExperienceYears { get; set; }
        public string Education { get; set; } = string.Empty;
        public double JobMatchScore { get; set; }
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
