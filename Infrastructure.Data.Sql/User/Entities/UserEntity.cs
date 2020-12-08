﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Data.Sql.User.Entities
{
    public class UserEntity
    {
        [Key]
        public Guid openId { get; set; }

        public int? gender { get; set; }

        public string name { get; set; }

        public string majorIn { get; set; }

        public int? height { get; set; }

        public int? weight { get; set; }

        public string studyContent { get; set; }

        public string expectationAfterGraduation { get; set; }

        public ICollection<HobbyEntity> hobbies { get; set; }
    }
}
