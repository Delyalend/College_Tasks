using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace LabWork
{

    public partial class Form1 : Form
    {
        private delegate void Sum(double a1, double a2);

        private List<Student> students = new List<Student>();


        public Form1()
        {
            InitializeComponent();
            Start();

            Information.Click += (s, e) => { PrintAllInformation(); };
            Task1.Click += (s, e) => { Task1Method(); };
            Task2.Click += (s, e) => { Task2Method(); };
            Task3.Click += (s, e) => { Task3Method(); };
            Task4.Click += (s, e) => { Task4Method(); };
            Task5.Click += (s, e) => { Task5Method(); };
            Task6.Click += (s, e) => { Task6Method(); };
            Task7.Click += (s, e) => { Task7Method(); };
            Task8.Click += (s, e) => { Task8Method(); };
            Task9.Click += (s, e) => { Task9Method(); };
            Task10.Click += (s, e) => { Task10MethodPart1(); };
            Task11.Click += (s, e) => { Task11Method(); };
            Task12.Click += (s, e) => { Task12Method(); };
        }

        public void Start()
        {
            Stream file = new FileStream("Students.txt", FileMode.Open, FileAccess.Read);

            //Проверка на сущ. файла
            if (File.Exists("Students.txt"))
            {
                StreamReader streamReader = new StreamReader(file, System.Text.Encoding.Default);

                string tmpLine = streamReader.ReadLine();

                while (!streamReader.EndOfStream)
                {

                    if (tmpLine != "")
                    {
                        Student student = new Student();
                        student.Name = tmpLine;
                        student.Surname = streamReader.ReadLine();
                        student.Lastname = streamReader.ReadLine();
                        student.Gender = streamReader.ReadLine();
                        student.Faculty = streamReader.ReadLine();
                        student.Course = streamReader.ReadLine();
                        student.Group = streamReader.ReadLine();
                        student.City = streamReader.ReadLine();
                        student.Math = streamReader.ReadLine();
                        student.Astronomy = streamReader.ReadLine();
                        student.Biology = streamReader.ReadLine();
                        student.Psychology = streamReader.ReadLine();
                        student.Literature = streamReader.ReadLine();
                        students.Add(student);
                        tmpLine = streamReader.ReadLine();
                    }
                    else if (tmpLine == "")
                    {
                        tmpLine = streamReader.ReadLine();
                    }
                }
            }
        }

        private void PrintAllInformation()
        {
            mainField.Clear();
            students.ForEach(student => mainField.AppendText("\n" + student.ToString() + "\n"));
        }

        private void Task1Method()
        {
            mainField.Clear();

            students.Sort((student1, student2) => student1.Name.CompareTo(student2.Name));

            List<Student> tmp1 = students.FindAll(student => student.GetAmountOfDebt() > 1);
            List<Student> tmp2 = tmp1.FindAll(student => student.Gender == "мужской");

            tmp2.ForEach(student => mainField.AppendText("\n" + student.Name + " " + student.Surname + "\nСред. балл: " + student.GetAverageGrades() + "\n"));
        }

        private void Task2Method()
        {
            mainField.Clear();

            students.Sort((student1, student2) => student1.Name.CompareTo(student2.Name));

            List<Student> tmp1 = students.FindAll(student => student.GetAmountOfDebt() > 2);
            List<Student> tmp2 = tmp1.FindAll(student => student.Gender == "мужской");

            tmp2.ForEach(student => mainField.AppendText("\n" + student.Name + " " + student.Surname + "\nСред.балл: " + student.GetAverageGrades() + "\n"));

        }

        private void Task3Method()
        {
            mainField.Clear();

            students.Sort((student1, student2) => student1.Name.CompareTo(student2.Name));

            List<Student> tmp1 = students.FindAll(student => student.Gender == "Женский");
            List<Student> tmp2 = tmp1.FindAll(student => student.GetAverageGrades() == 5);

            tmp2.ForEach(student => mainField.AppendText("\n" + student.Name + " " + student.Surname + "\nСред. балл:" + student.GetAverageGrades() + "\n"));

        }

        private void Task4Method()
        {
            mainField.Clear();

            students.Sort((student1, student2) => student1.Name.CompareTo(student2.Name));

            List<Student> tmp1 = students.FindAll(student => student.Gender == "Женский");
            List<Student> tmp2 = tmp1.FindAll(student => student.GetAverageGrades() == 5);
            List<Student> tmp3 = tmp2.FindAll(student => student.City == "Ачинск");

            tmp3.ForEach(student => mainField.AppendText("\n" + student.Name + " " + student.Surname + "\nГород: " + student.City + "\n"));

        }

        private void Task5Method()
        {
            mainField.Clear();

            students.Sort((student1, student2) => student1.City.CompareTo(student2.City));

            List<Student> tmp = students.FindAll(student => student.Gender == "мужской");

            tmp.ForEach(student => mainField.AppendText("\n" + student.Name + " " + student.Surname + "\nГород:" + student.City + "\n"));
        }

        private void Task6Method()
        {
            mainField.Clear();
            students.Sort((student1, student2) => student1.Name.CompareTo(student2.Name));

            List<Student> tmp1 = students.FindAll(student => student.GetAverageGrades() == 5);

            List<Student> tmp2 = tmp1.FindAll(student => student.City == "Москва");

            tmp2.ForEach(student => mainField.AppendText("\n" + student.Name + " " + student.Surname + "\nСред. балл: " + student.GetAverageGrades() + "\nГород: " + student.City + "\n"));
        }

        private void Task7Method()
        {
            mainField.Clear();

            students.Sort((student1, student2) => student2.GetAverageGrades().CompareTo(student1.GetAverageGrades()));

            List<Student> tmp = students.FindAll(student => student.Gender == "мужской");

            tmp.ForEach(student => mainField.AppendText("\n" + student.Name + " " + student.Surname + "\n" + " Ср.Бал: " + student.GetAverageGrades() + "\n"));
        }

        private void Task8Method()
        {
            mainField.Clear();

            List<Student> tmp1 = students.FindAll(student => student.Gender == "мужской");

            //<номер курса,количество отличников>
            Dictionary<string, int> numberStudentOnEachCourse = new Dictionary<string, int>();
            numberStudentOnEachCourse.Add("1", 0);
            numberStudentOnEachCourse.Add("2", 0);
            numberStudentOnEachCourse.Add("3", 0);
            numberStudentOnEachCourse.Add("4", 0);
            numberStudentOnEachCourse.Add("5", 0);

            Dictionary<string, int> numberAStudentOnEachCourse = new Dictionary<string, int>();
            numberAStudentOnEachCourse.Add("1", 0);
            numberAStudentOnEachCourse.Add("2", 0);
            numberAStudentOnEachCourse.Add("3", 0);
            numberAStudentOnEachCourse.Add("4", 0);
            numberAStudentOnEachCourse.Add("5", 0);

            Dictionary<string, double> procentAStudentOnEachCourse = new Dictionary<string, double>();
            procentAStudentOnEachCourse.Add("1", 0);
            procentAStudentOnEachCourse.Add("2", 0);
            procentAStudentOnEachCourse.Add("3", 0);
            procentAStudentOnEachCourse.Add("4", 0);
            procentAStudentOnEachCourse.Add("5", 0);

            //Посчитаем количество студентов на каждом курсе          
            tmp1.ForEach(student => numberStudentOnEachCourse[student.Course] += 1);

            //Посчитаем количество отличников на каждом курсе
            tmp1.ForEach(student =>
            {
                if (student.GetAverageGrades() == 5)
                {
                    numberAStudentOnEachCourse[student.Course] += 1;
                }
            });

            //Посчитаем процент отличников на каждом курсе
            for (int i = 1; i <= 5; i++)
            {
                //Если нет отличников...
                if (numberAStudentOnEachCourse.ContainsKey(i.ToString()))
                {
                    if (numberAStudentOnEachCourse[i.ToString()] == 0)
                    {
                        procentAStudentOnEachCourse[i.ToString()] = 0;
                    }
                    else if (numberAStudentOnEachCourse[i.ToString()] > 0)
                    {
                        procentAStudentOnEachCourse[i.ToString()] =
                            (numberAStudentOnEachCourse[i.ToString()] /
                            numberStudentOnEachCourse[i.ToString()]) * 100;
                    }
                }
            }

            //Ищем курс с наибольшим процентом отличников и выводим
            double max = procentAStudentOnEachCourse["1"];
            int numberCourse = 1;

            while (procentAStudentOnEachCourse.Count > 0)
            {
                for (int i = 1; i <= 5; i++)
                {
                    if (procentAStudentOnEachCourse.ContainsKey(i.ToString()))
                    {
                        if (max < procentAStudentOnEachCourse[i.ToString()])
                        {
                            max = procentAStudentOnEachCourse[i.ToString()];
                            numberCourse = i;
                        }
                    }
                }

                List<Student> tmp2 = tmp1.FindAll(student => student.Course == numberCourse.ToString());

                tmp2.ForEach(student => mainField.AppendText("\n" + student.Name + " " + student.Surname + "\n Оценка: " + student.GetAverageGrades() + "\nКурс: " + student.Course + "\n"));

                //Удалим курс, который уже напечтали
                procentAStudentOnEachCourse.Remove(numberCourse.ToString());


                //Найдем следующий доступный курс
                for (int k = 1; k <= 5; k++)
                {
                    if (procentAStudentOnEachCourse.ContainsKey(k.ToString()))
                    {
                        max = procentAStudentOnEachCourse[k.ToString()];
                        numberCourse = k;
                        break;
                    }
                }
            }
        }

        private void Task9Method()
        {
            mainField.Clear();

            List<Student> tmp1 = students.FindAll(student => student.Faculty == "ИВТ");

            //<группа, кол-во неусп студентов>
            Dictionary<string, int> numberUnsuccesfulStudents = new Dictionary<string, int>();



            List<string> listOfNameGroup = new List<string>();

            //Ищем кол-во неуспевающих студентов в каждой группе
            tmp1.ForEach(student =>
            {
                if (student.GetAverageGrades() < 3.5d)
                {
                    if (!numberUnsuccesfulStudents.ContainsKey(student.Group))
                    {
                        numberUnsuccesfulStudents.Add(student.Group, 0);
                    }
                    numberUnsuccesfulStudents[student.Group] += 1;
                    if (!listOfNameGroup.Contains(student.Group))
                    {
                        listOfNameGroup.Add(student.Group);
                    }
                }
                else
                {
                    if (!numberUnsuccesfulStudents.ContainsKey(student.Group))
                    {
                        numberUnsuccesfulStudents.Add(student.Group, 0);
                    }
                    if (!listOfNameGroup.Contains(student.Group))
                    {
                        listOfNameGroup.Add(student.Group);
                    }
                }
            });



            //Чем меньше в группе неуспевающих студентов, тем выше в списке они будут
            //Ищем группу с наименьшим количеством неуспевающих студентов
            //Выводим этих студентов
            int minNumberUnsuccesfulStudents = numberUnsuccesfulStudents[listOfNameGroup[0]];
            string nameGroup = listOfNameGroup[0];

            while (numberUnsuccesfulStudents.Count > 0)
            {
                for (int i = 0; i < listOfNameGroup.Count; i++)
                {
                    if (minNumberUnsuccesfulStudents > numberUnsuccesfulStudents[listOfNameGroup[i]])
                    {
                        minNumberUnsuccesfulStudents = numberUnsuccesfulStudents[listOfNameGroup[i]];
                        nameGroup = listOfNameGroup[i];
                    }
                }

                List<Student> tmp2 = tmp1.FindAll(student => student.Group == nameGroup);
                tmp2.ForEach(student => mainField.AppendText("\n" + student.Name + " " + student.Surname + "\nГруппа: " + student.Group + "\nФакультет: " + student.Faculty + "\nСред. балл:" + student.GetAverageGrades() + "\n"));

                numberUnsuccesfulStudents.Remove(nameGroup);
                listOfNameGroup.Remove(nameGroup);



                //Нужно найти следующую группу 
                for (int i = 0; i < listOfNameGroup.Count; i++)
                {
                    minNumberUnsuccesfulStudents = numberUnsuccesfulStudents[listOfNameGroup[i]];
                    nameGroup = listOfNameGroup[i];
                }

            }



        }

        private void Task10MethodPart1()
        {
            mainField.Clear();

            List<Student> tmp1 = students.FindAll(student => student.Gender == "мужской");
            List<Student> tmp2 = tmp1.FindAll(student => student.Faculty == "ИВТ");

            //<номер курса,количество отличников>
            Dictionary<string, int> numberStudentOnEachCourse = new Dictionary<string, int>();
            numberStudentOnEachCourse.Add("1", 0);
            numberStudentOnEachCourse.Add("2", 0);
            numberStudentOnEachCourse.Add("3", 0);
            numberStudentOnEachCourse.Add("4", 0);
            numberStudentOnEachCourse.Add("5", 0);

            Dictionary<string, int> numberAStudentOnEachCourse = new Dictionary<string, int>();
            numberAStudentOnEachCourse.Add("1", 0);
            numberAStudentOnEachCourse.Add("2", 0);
            numberAStudentOnEachCourse.Add("3", 0);
            numberAStudentOnEachCourse.Add("4", 0);
            numberAStudentOnEachCourse.Add("5", 0);

            Dictionary<string, double> procentAStudentOnEachCourse = new Dictionary<string, double>();
            procentAStudentOnEachCourse.Add("1", 0);
            procentAStudentOnEachCourse.Add("2", 0);
            procentAStudentOnEachCourse.Add("3", 0);
            procentAStudentOnEachCourse.Add("4", 0);
            procentAStudentOnEachCourse.Add("5", 0);

            //Посчитаем количество студентов на каждом курсе          
            tmp2.ForEach(student => numberStudentOnEachCourse[student.Course] += 1);

            //Посчитаем количество отличников на каждом курсе
            tmp2.ForEach(student =>
            {
                if (student.GetAverageGrades() == 5)
                {
                    numberAStudentOnEachCourse[student.Course] += 1;
                }
            });

            //Посчитаем процент отличников на каждом курсе
            for (int i = 1; i <= 5; i++)
            {

                if (numberAStudentOnEachCourse.ContainsKey(i.ToString()))
                {
                    if (numberAStudentOnEachCourse[i.ToString()] == 0)
                    {
                        procentAStudentOnEachCourse[i.ToString()] = 0;
                    }
                    else if (numberAStudentOnEachCourse[i.ToString()] > 0)
                    {
                        procentAStudentOnEachCourse[i.ToString()] =
                            (numberAStudentOnEachCourse[i.ToString()] /
                            numberStudentOnEachCourse[i.ToString()]) * 100;
                    }
                }
            }




            double max = procentAStudentOnEachCourse["1"];
            int numberCourse = 1;

            for (int i = 1; i <= 5; i++)
            {
                if (procentAStudentOnEachCourse.ContainsKey(i.ToString()))
                {
                    if (max < procentAStudentOnEachCourse[i.ToString()])
                    {
                        max = procentAStudentOnEachCourse[i.ToString()];
                        numberCourse = i;
                    }
                }
            }

            mainField.AppendText("\nНомер курса с наибольшим количеством отличников Факультета ИВТ: " + numberCourse + "\n");

            Task10MethodPart2();
        }

        private void Task10MethodPart2()
        {
            List<Student> tmp1 = students.FindAll(student => student.Gender == "мужской");
            List<Student> tmp2 = tmp1.FindAll(student => student.Faculty == "ИВТ");

            //<номер курса,количество отличников>
            Dictionary<string, int> numberStudentOnEachCourse = new Dictionary<string, int>();
            numberStudentOnEachCourse.Add("1", 0);
            numberStudentOnEachCourse.Add("2", 0);
            numberStudentOnEachCourse.Add("3", 0);
            numberStudentOnEachCourse.Add("4", 0);
            numberStudentOnEachCourse.Add("5", 0);

            Dictionary<string, int> numberAStudentOnEachCourse = new Dictionary<string, int>();
            numberAStudentOnEachCourse.Add("1", 0);
            numberAStudentOnEachCourse.Add("2", 0);
            numberAStudentOnEachCourse.Add("3", 0);
            numberAStudentOnEachCourse.Add("4", 0);
            numberAStudentOnEachCourse.Add("5", 0);

            Dictionary<string, double> procentAStudentOnEachCourse = new Dictionary<string, double>();
            procentAStudentOnEachCourse.Add("1", 0);
            procentAStudentOnEachCourse.Add("2", 0);
            procentAStudentOnEachCourse.Add("3", 0);
            procentAStudentOnEachCourse.Add("4", 0);
            procentAStudentOnEachCourse.Add("5", 0);

            //Посчитаем количество студентов на каждом курсе          
            tmp1.ForEach(student => numberStudentOnEachCourse[student.Course] += 1);

            //Посчитаем количество отличников на каждом курсе
            tmp1.ForEach(student =>
            {
                if (student.GetAverageGrades() == 5)
                {
                    numberAStudentOnEachCourse[student.Course] += 1;
                }
            });

            //Посчитаем процент отличников на каждом курсе
            for (int i = 1; i <= 5; i++)
            {
                //Если нет отличников...
                if (numberAStudentOnEachCourse.ContainsKey(i.ToString()))
                {
                    if (numberAStudentOnEachCourse[i.ToString()] == 0)
                    {
                        procentAStudentOnEachCourse[i.ToString()] = 0;
                    }
                    else if (numberAStudentOnEachCourse[i.ToString()] > 0)
                    {
                        procentAStudentOnEachCourse[i.ToString()] =
                            (numberAStudentOnEachCourse[i.ToString()] /
                            numberStudentOnEachCourse[i.ToString()]) * 100;
                    }
                }
            }

            //Ищем курс с наибольшим процентом отличников и выводим
            double max = procentAStudentOnEachCourse["1"];
            int numberCourse = 1;

            while (procentAStudentOnEachCourse.Count > 0)
            {

                for (int i = 1; i <= 5; i++)
                {
                    if (procentAStudentOnEachCourse.ContainsKey(i.ToString()))
                    {
                        if (max < procentAStudentOnEachCourse[i.ToString()])
                        {
                            max = procentAStudentOnEachCourse[i.ToString()];
                            numberCourse = i;
                        }
                    }
                }



                List<Student> tmp3 = tmp2.FindAll(student => student.Course == numberCourse.ToString());

                tmp3.ForEach(student => mainField.AppendText("\n" + student.Name + " " + student.Surname + "\n Оценка: " + student.GetAverageGrades() + "\nКурс: " + student.Course + "\nГруппа: " + student.Group + "\n"));

                //Удалим курс, который уже напечтали
                procentAStudentOnEachCourse.Remove(numberCourse.ToString());


                //Найдем следующий доступный курс
                for (int k = 1; k <= 5; k++)
                {
                    if (procentAStudentOnEachCourse.ContainsKey(k.ToString()))
                    {
                        max = procentAStudentOnEachCourse[k.ToString()];
                        numberCourse = k;
                        break;
                    }
                }
            }
        }

        private void Task11Method()
        {
            mainField.Clear();

            List<Student> tmp1 = students.FindAll(student => student.Gender == "мужской");

            //<фамилия, количество>
            Dictionary<string, int> numberSurnames = new Dictionary<string, int>();
            List<string> titlesSurnames = new List<string>();

            //Считаем фамилии
            tmp1.ForEach(student =>
            {
                if (!numberSurnames.ContainsKey(student.Surname))
                {
                    numberSurnames.Add(student.Surname, 0);
                }
                numberSurnames[student.Surname] += 1;
                if (!titlesSurnames.Contains(student.Surname))
                {
                    titlesSurnames.Add(student.Surname);
                }
            });

            //Находим наиболее популярную
            string titleSurname = titlesSurnames[0];
            int maxNumberSurnames = numberSurnames[titleSurname];
            string mostPopularSurname = titlesSurnames[0];

            for (int i = 0; i < numberSurnames.Count; i++)
            {
                titleSurname = titlesSurnames[i];
                if (maxNumberSurnames < numberSurnames[titleSurname])
                {
                    maxNumberSurnames = numberSurnames[titleSurname];
                    mostPopularSurname = titlesSurnames[i];
                }
            }

            //Выводим фамилию
            mainField.AppendText("\n Самая распрастраненная фамилия среди юношей: " + mostPopularSurname + "\n");

            // 2Часть задания
            titleSurname = titlesSurnames[0];
            maxNumberSurnames = numberSurnames[titleSurname];
            mostPopularSurname = titlesSurnames[0];
            while (numberSurnames.Count > 0)
            {
                for (int i = 0; i < numberSurnames.Count; i++)
                {

                    titleSurname = titlesSurnames[i];
                    if (numberSurnames.ContainsKey(titleSurname))
                    {
                        if (maxNumberSurnames < numberSurnames[titleSurname])
                        {
                            maxNumberSurnames = numberSurnames[titleSurname];
                            mostPopularSurname = titlesSurnames[i];
                        }
                    }
                }

                //Выводим студентов с наиболее поплуярной фамилией
                List<Student> tmp2 = tmp1.FindAll(student => student.Surname == mostPopularSurname);
                tmp2.ForEach(student => mainField.AppendText("\n" + student.Name + " " + student.Surname));

                //Удаляем выведенную ранее фамилию            
                numberSurnames.Remove(mostPopularSurname);
                titlesSurnames.Remove(mostPopularSurname);


                //Ищем следующую фамилию     
                if (titlesSurnames.Count > 0)
                {
                    titleSurname = titlesSurnames[0];
                    maxNumberSurnames = numberSurnames[titleSurname];
                    mostPopularSurname = titlesSurnames[0];
                }
            }


            //Фамилии юношей, одинаково распространенных, располагать по алфавиту

        }



        private void Task12Method()
        {
            mainField.Clear();

            List<Student> tmp1 = students.FindAll(student => student.Gender == "Женский");

            tmp1.Sort((student1, student2) => student2.GetAverageGrades().CompareTo(student1.GetAverageGrades()));

            tmp1.ForEach(student => mainField.AppendText("\n" + student.Name + " " + student.Surname + "\nСред. балл:" + student.GetAverageGrades() + "\n"));
        }

        private double GetProcentAStudentOnCourse(int numberCourse, List<Student> students)
        {
            List<Student> tmp1 = students.FindAll(student => student.Course == numberCourse.ToString());

            List<Student> tmp2 = students.FindAll(student => student.GetAverageGrades() == 5);
            if (tmp1.Count != 0)
            {
                //Отличников делим на общее количество
                return ((tmp2.Count / tmp1.Count) * 100);
            }
            else
            {
                return 0;
            }
        }
    }
}
