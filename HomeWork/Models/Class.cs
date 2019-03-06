﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork.Models
{
    public class Class
    {
        public int Id { get; set; }

        public int SubjectId { get; set; }
        public Subject Subject { get; set; }

        public int BatchId { get; set; }
        public Batch Batch { get; set; }

        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        public IEnumerable<Document> Documents { get; set; }

    }
}
