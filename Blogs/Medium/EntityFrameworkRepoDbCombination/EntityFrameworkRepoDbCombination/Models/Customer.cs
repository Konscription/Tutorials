﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkRepoDbCombination.Models
{
    [Table("Customer")]
    public class Customer
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int Age { get; set; }
        public string ExtendedInfo { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDateUtc { get; set; }
    }
}
