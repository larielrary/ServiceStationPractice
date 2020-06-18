﻿using DataLayer;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer.Models
{
    public class OwnerDTO : IEntity
    {
        public int Id { get; set; }
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string MiddleName { get; set; }
        [Required]
        public string PhoneNum { get; set; }

        public override string ToString()
        {
            return $"{Id} {Firstname} {LastName} {MiddleName} {PhoneNum}";
        }
    }
}
