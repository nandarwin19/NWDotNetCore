﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTrainingBatch3.ConsoleApp.Models
{
    [Table("Table_1")]
    public class BlogModel
    {
        [Key]
       
        public int BlogId { get; set; }

        public string BlogTitle { get; set; }
        public string BlogAuthor { get; set; }

        public string BlogContent { get; set; }
    }
}
