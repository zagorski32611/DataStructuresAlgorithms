using System;
using System.Collections;

namespace DatastructuresandAlgorithms
{
    public struct Student
    {
        private string s_name;
        
        private int t_number;

        private double score;

        public Student(string student_name, double s_score, int test_number)
        {
            s_name = student_name;
            t_number = test_number;
            score = s_score;

        }

        public string studentName
        {
            get { return s_name; }
            set { s_name = studentName; }
        }

        public int testNumber
        {
            get { return t_number; }
            set { t_number = testNumber; }
        }

    }
}