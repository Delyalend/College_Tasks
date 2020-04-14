using System.Collections.Generic;

namespace LabWork
{
    public struct Student
    {


        public string Name { get; set; }
        public string Surname { get; set; }
        public string Lastname { get; set; }
        public string Gender { get; set; }
        public string Faculty { get; set; }
        public string Course { get; set; }
        public string Group { get; set; }
        public string City { get; set; }

        public string Math { get; set; }
        public string Astronomy { get; set; }
        public string Biology { get; set; }
        public string Psychology { get; set; }
        public string Literature { get; set; }


        public int GetAmountOfDebt()
        {
            int result = 0;          

            if(GetAvarageGradeInTheSubject(Subject.Math) < 3.5d)
            {
                result++;
            }
            if (GetAvarageGradeInTheSubject(Subject.Psychology) < 3.5d)
            {
                result++;
            }
            if (GetAvarageGradeInTheSubject(Subject.Literature) < 3.5d)
            {
                result++;
            }
            if (GetAvarageGradeInTheSubject(Subject.Biology) < 3.5d)
            {
                result++;
            }
            if (GetAvarageGradeInTheSubject(Subject.Astronomy) < 3.5d)
            {
                result++;
            }
            return result;
        }

        //Получить среднее значение всех оценок
        public double GetAverageGrades()
        {
            double result = GetAvarageGradeInTheSubject(Subject.Astronomy) +
                            GetAvarageGradeInTheSubject(Subject.Biology) +
                            GetAvarageGradeInTheSubject(Subject.Literature) +
                            GetAvarageGradeInTheSubject(Subject.Math) +
                            GetAvarageGradeInTheSubject(Subject.Psychology);
            return (result / 5);
        }

        //Получить среднюю оценку по предмету
        public double GetAvarageGradeInTheSubject(Subject subject)
        {
            if (subject == Subject.Math)
            {
                return GetAverageValue(Math);
            }
            if (subject == Subject.Astronomy)
            {
                return GetAverageValue(Astronomy);
            }
            if (subject == Subject.Psychology)
            {
                return GetAverageValue(Psychology);
            }
            if (subject == Subject.Biology)
            {
                return GetAverageValue(Biology);
            }
            if (subject == Subject.Literature)
            {
                return GetAverageValue(Literature);
            }
            return 0d;
        }

        private double GetAverageValue(string str)
        {
            List<int> marks = new List<int>();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    int number =  int.Parse(str[i].ToString());
                    marks.Add(number);
                }
            }
            double average = 0;
            for (int i = 0; i < marks.Count; i++)
            {
                average += marks[i];
            }
            average /= marks.Count;
            return average;
        }

        public override string ToString()
        {
            return string.Format("Имя:" + Name + "\nФамилия:" + Surname + "\nОтчество:" + Lastname
                + "\nПол:" + Gender + "\nФакультет:" + Faculty + "\nКурс:" + Course + "\nГруппа:" + Group +
                "\nГород:" + City + "\nМатематика:" + Math + "\nАстрономия:" + Astronomy + "\nБиология:"
                + Biology + "\nПсихология:" + Psychology + "\nЛитература:" + Literature);
        }
    }
}
