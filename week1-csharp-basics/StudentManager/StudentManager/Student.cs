using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    internal class Student
    {
        public string Name { get; }
        public int Score {  get; }

        public Student(string name, int score)
        {
            this.Name = name;
            this.Score = score;
        }
    }
}
