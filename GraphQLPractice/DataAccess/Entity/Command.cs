﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GraphQLPractice.DataAccess.Entity
{
    public class Command
    {
       
        [Key]
        public int Id { get; set; }

        [Required]
        public string HowTo { get; set; }

        
        [Required]
        public string CommandLine { get; set; }
         [Required]
        public int PlatformId { get; set; }

        public Platform Platform { get; set; }
    }
}
