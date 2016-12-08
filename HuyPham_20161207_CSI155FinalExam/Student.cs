using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuyPham_20161207_CSI155FinalExam
{
    public class Student : IComparable<Student>
    {
        public string First { get; set; }
        public string Last { get; set; }
        public List<int> Scores { get; set; }
        public int ID { get; set; }

        // Solution to Requirement #1
        public double GetAverageGrade()
        {
            return Scores.Average();
        }

        // Solution to Requirement #3
        public int CompareTo(Student otherStudent)
        {
            if (this.GetAverageGrade() > otherStudent.GetAverageGrade())
                return 1;
            if (this.GetAverageGrade() < otherStudent.GetAverageGrade())
                return -1;
            return 0;
        }
    }
}
