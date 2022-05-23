using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CvProject.Models.Entities
{
    public partial class Education
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Subtitle { get; set; }
        public string? Subtitle2 { get; set; }
        public string? Gpa { get; set; }
        public string? Date { get; set; }
    }
}
