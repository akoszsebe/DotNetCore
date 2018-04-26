using System;
using System.ComponentModel.DataAnnotations;

namespace DotNetCore.Models
{
    public class Szallitmany
    {
        [Required]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        public DateTime date { get; set; }
    }
}