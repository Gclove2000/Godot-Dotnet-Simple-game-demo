﻿using FreeSql.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gluttonous_Snake.DB
{
    public abstract class T_DataBase
    {

        [Column(IsPrimary = true, IsIdentity = true)]
        public long Id { get; set; }

        public DateTime CreateTime { get; set; }


    }
}
