using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College
{
    public struct Teacher
    {
        private String _fio;
        private String _group;

        public Teacher(string fio, string group)
        {
            _fio = fio;
            _group = group;
        }

        public string Fio { get => _fio; set => _fio = value; }
        public string Group { get => _group; set => _group = value; }

        public int GetNumberGroup()
        {
            int result = 0;
            for (int i = 0; i < _group.Length; i++)
            {
                result += int.Parse(_group[i].ToString());
            }
            return result;
        }
    }
}
