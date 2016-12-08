using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuyPham_20161207_CSI155FinalExam
{
    // Solution to Requirement #4
    class StudentLNameComparer : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return string.Compare(x.Last, y.Last);
        }
    }
}
