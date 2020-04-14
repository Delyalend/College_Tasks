using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace College
{
    public partial class Form1 : Form
    {
        public List<Student> students = new List<Student>();
        public List<Teacher> teachers = new List<Teacher>();


        public Form1()
        {
            InitializeComponent();
        }

        private void button_AddStudent_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" &&
               textBox2.Text != "" &&
               textBox3.Text != "")
            {
                Student student = new Student(textBox1.Text, textBox2.Text, textBox3.Text);
                students.Add(student);
                listBox1.Items.Add(student.Fio);
                listBox1.Visible = true;
                listBox2.Visible = false;
                comboBox1.Text = comboBox1.Items[1].ToString();
            }
        }

        private void button_AddTeacher_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != "" &&
               textBox6.Text != "")
            {
                Teacher teacher = new Teacher(textBox6.Text, textBox5.Text);
                teachers.Add(teacher);
                listBox2.Items.Add(teacher.Fio);
                listBox1.Visible = false;
                listBox2.Visible = true;
                comboBox1.Text = comboBox1.Items[0].ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).Text == "Студенты")
            {
                listBox1.Visible = true;
                listBox2.Visible = false;
                ClearTextBoxInfoTeacher();
            }
            else if ((sender as ComboBox).Text == "Преподаватели")
            {
                listBox1.Visible = false;
                listBox2.Visible = true;
                ClearTextBoxInfoStudent();
            }
        }

        public void ShowInfo(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Студенты")
            {
                if (listBox1.SelectedIndex < 0)
                {
                    listBox1.ClearSelected();
                    return;
                }
                Student student = students[listBox1.SelectedIndex];
                //if (student != null)
                // {
                label_InfoStudentFio.Text = student.Fio;
                label_InfoStudentGroup.Text = student.Group;
                label_InfoStudentMarks.Text = student.Marks;
                //}
            }
            else if (comboBox1.Text == "Преподаватели")
            {
                if (listBox2.SelectedIndex < 0)
                {
                    listBox2.ClearSelected();
                    return;
                }
                Teacher teacher = teachers[listBox2.SelectedIndex];
                //if (teacher != null)
                // {
                label_InfoTeacherFio.Text = teacher.Fio;
                label_InfoTeacherGroup.Text = teacher.Group;
                // }
            }
        }

        private void ClearTextBoxInfoTeacher()
        {
            label_InfoTeacherFio.Text = "-";
            label_InfoTeacherGroup.Text = "-";
        }

        private void ClearTextBoxInfoStudent()
        {
            label_InfoStudentFio.Text = "-";
            label_InfoStudentGroup.Text = "-";
            label_InfoStudentMarks.Text = "-";
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "Студенты")
                {
                    students.RemoveAt(listBox1.SelectedIndex);
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                    ClearTextBoxInfoStudent();
                }
                else if (comboBox1.Text == "Преподаватели")
                {
                    teachers.RemoveAt(listBox2.SelectedIndex);
                    listBox2.Items.RemoveAt(listBox2.SelectedIndex);
                    ClearTextBoxInfoTeacher();
                }
            }
            catch
            {
                Console.WriteLine("Элемент не выбран!");
            }
        }

        private void button_Sort_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Студенты")
            {
                Student tmpStudent;

                for (int i = 0; i < students.Count - 1; i++)
                {
                    if (students[i].GetResultMark() > students[i + 1].GetResultMark())
                    {
                        tmpStudent = students[i];
                        students[i] = students[i+1];
                        students[i+1] = tmpStudent;
                        i = -1;
                    }
                }
              
                listBox1.Items.Clear();
                for (int i = 0; i < students.Count; i++)
                {
                    listBox1.Items.Add(students[i].Fio);
                }
                
            }
            else if (comboBox1.Text == "Преподаватели")
            {
                Teacher tmpTeacher;
                for (int i = 0; i < teachers.Count - 1; i++)
                {
                    if (teachers[i].GetNumberGroup() > teachers[i + 1].GetNumberGroup())
                    {
                        tmpTeacher = teachers[i];
                        teachers[i] = teachers[i + 1];
                        teachers[i + 1] = tmpTeacher;
                        i = -1;
                    }
                }

                listBox2.Items.Clear();
                for (int i = 0; i < teachers.Count; i++)
                {
                    listBox2.Items.Add(teachers[i].Fio);
                }
            }
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "Студенты")
                {
                    if (textBox1.Text != "" &&
                        textBox2.Text != "" &&
                        textBox3.Text != "")
                    {
                        Student student = new Student(textBox1.Text, textBox2.Text, textBox3.Text);
                        students[listBox1.SelectedIndex] = student;
                        listBox1.Items[listBox1.SelectedIndex] = student.Fio;
                        ClearTextBoxInfoStudent();
                        listBox1.ClearSelected();
                    }
                }
                else if (comboBox1.Text == "Преподаватели")
                {
                    if (textBox6.Text != "" &&
                        textBox5.Text != "")
                    {
                        Teacher teacher = new Teacher(textBox6.Text, textBox5.Text);
                        teachers[listBox2.SelectedIndex] = teacher;
                        listBox2.Items[listBox2.SelectedIndex] = teacher.Fio;
                        ClearTextBoxInfoTeacher();
                        listBox2.ClearSelected();
                    }
                }
            }
            catch
            {
                Console.WriteLine("Элемент не выбран!");
            }

        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            listBox1.ClearSelected();
            listBox2.ClearSelected();
            ClearTextBoxInfoStudent();
            ClearTextBoxInfoTeacher();
        }
    }
}
