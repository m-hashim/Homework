using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork.Models
{
    public enum Course
    {
        MTech_CSE,
        MTech_IT,
        MTech_ECE,
        MCA,
        BTech_CSE,
        BTech_IT,
        BTech_ECE,
        BTech_BioTech,
        BTech_Chemical,
    }

    public enum CourseType
    {
        BTech,
        MTech,
        BTechMTech,
        MCA
    }
    public enum StudyYear
    {
        First=1,
        Second,
        Third,
        Fourth,
        Fifth,
        Sixth
    }

    public enum Semester
    {
        First=1,
        Second,
        Third,
        Fourth,
        Fifth,
        Sixth,
        Seventh,
        Eigth,
        Nineth,
        Tenth
    }

    public class GlobalDef
    {
    }
}
