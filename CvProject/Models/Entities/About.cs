﻿using System;
using System.Collections.Generic;

namespace CvProject.Models.Entities
{
    public partial class About
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Telephone { get; set; }
        public string? Email { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public string? Address { get; set; }
    }
}
