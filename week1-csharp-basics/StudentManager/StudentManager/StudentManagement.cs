using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    internal class StudentManagement
    {
        private List<Student> _student = new List<Student>();

        public void AddStudent(Student student)
        {
            _student.Add(student);
        }

        public bool RemoveStudent(string name)
        {
            int removed = _student.RemoveAll(s => s.Name == name);
            return removed > 0;
        }

        public List<int> SearchScore(string name)
        {
            return _student.Where(s => s.Name == name)
                .Select(s => s.Score)
                .ToList();
        }

        public void PrintSumAndAvg()
        {
            if (!_student.Any())
            {
                Console.WriteLine("등록된 학생이 없습니다.");
                return;
            }

            Console.WriteLine($"합계: {_student.Sum(s => s.Score)}/ 평균: {_student.Average(s => s.Score):F1}");
        }

        public void SortingScore()
        {
            foreach(var student in _student.OrderByDescending(s => s.Score).ToList())
            {
                Console.WriteLine($"{student.Name}({student.Score})");
            }
        }
    }
}
