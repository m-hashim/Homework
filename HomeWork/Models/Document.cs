using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork.Models
{
    public class Document
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime LastSubmissionDate { get; set; }

        public int ClassId { get; set; }
        public Class Class { get; set; }
    }
}
