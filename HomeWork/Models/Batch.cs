using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork.Models
{
    public class Batch
    {
        public int Id { get; set; }
        public Course Course { get; set; }
        public int StartingYear { get; set; }

        public int EndingYear { get; set; }
        public CourseType CourseType { get; set; }

        public StudyYear CurrentStudyYear { get; set; }
        public Semester CurrentSemester { get; set; }

        public IEnumerable<Student> Students { get; set; }
        public IEnumerable<Subject> CurrentSubjects { get; set; }


    }
}
