﻿using System.ComponentModel;
using System.Text.Json.Serialization;

namespace backendProjesi.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? InserDate { get; set; }
    }
}
