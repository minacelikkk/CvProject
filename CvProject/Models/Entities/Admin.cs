﻿using System;
using System.Collections.Generic;


namespace CvProject.Models.Entities
{
    public partial class Admin
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string Password { get; set; } = null!;
    }
}
