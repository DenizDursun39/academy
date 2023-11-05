﻿using Entities.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Category:IEntity //Bu bir veritabanı tablosudur
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }

        [ForeignKey("Id")]
        public virtual Course Course { get; set; }
    }
}
