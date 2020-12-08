﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Data.Sql.User.Entities
{
    public class HobbyEntity
    {
        [Key]
        public Guid hobbyId { get; set; }

        public string name { get; set; }
    }
}
