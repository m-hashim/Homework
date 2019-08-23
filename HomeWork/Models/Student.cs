﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string EnrollmentNo { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }

        public int BatchId { get; set; }
        public Batch Batch { get; set; }
    }
}
