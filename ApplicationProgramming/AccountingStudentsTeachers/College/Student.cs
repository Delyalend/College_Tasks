using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College
{
    public struct Student
    {
        private string _fio;
        private string _group;
        private string _marks;

        public Student(string fio, string group, string marks)
        {
            _fio = fio;
            _group = group;
            _marks = marks;
        }

        public string Fio { get => _fio; set => _fio = value; }
        public string Group { get => _group; set => _group = value; }
        public string Marks { get => _marks; set => _marks = value; }

       

        public int GetResultMark()
        {
            int result = 0;
            for(int i = 0; i < _marks.Length; i++)
            {
                result += int.Parse(_marks[i].ToString());
            }
            return result;
        }
    }
}
