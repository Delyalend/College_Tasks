namespace LabWork
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Task1 = new System.Windows.Forms.Button();
            this.Task2 = new System.Windows.Forms.Button();
            this.mainField = new System.Windows.Forms.RichTextBox();
            this.Information = new System.Windows.Forms.Button();
            this.Task3 = new System.Windows.Forms.Button();
            this.Task4 = new System.Windows.Forms.Button();
            this.Task5 = new System.Windows.Forms.Button();
            this.Task6 = new System.Windows.Forms.Button();
            this.Task7 = new System.Windows.Forms.Button();
            this.Task8 = new System.Windows.Forms.Button();
            this.Task9 = new System.Windows.Forms.Button();
            this.Task10 = new System.Windows.Forms.Button();
            this.Task12 = new System.Windows.Forms.Button();
            this.Task11 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Task1
            // 
            this.Task1.Location = new System.Drawing.Point(12, 12);
            this.Task1.Name = "Task1";
            this.Task1.Size = new System.Drawing.Size(257, 40);
            this.Task1.TabIndex = 0;
            this.Task1.Text = "1.Должники в алфавитном порядке ";
            this.Task1.UseVisualStyleBackColor = true;
            // 
            // Task2
            // 
            this.Task2.Location = new System.Drawing.Point(12, 58);
            this.Task2.Name = "Task2";
            this.Task2.Size = new System.Drawing.Size(257, 40);
            this.Task2.TabIndex = 1;
            this.Task2.Text = "2.Должники в алфавитном порядке, при этом долгов больше двух ";
            this.Task2.UseVisualStyleBackColor = true;
            // 
            // mainField
            // 
            this.mainField.Location = new System.Drawing.Point(600, 12);
            this.mainField.Name = "mainField";
            this.mainField.Size = new System.Drawing.Size(327, 338);
            this.mainField.TabIndex = 2;
            this.mainField.Text = "";
            // 
            // Information
            // 
            this.Information.Location = new System.Drawing.Point(647, 356);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(257, 40);
            this.Information.TabIndex = 3;
            this.Information.Text = "Вывести всех студентов";
            this.Information.UseVisualStyleBackColor = true;
            // 
            // Task3
            // 
            this.Task3.Location = new System.Drawing.Point(12, 104);
            this.Task3.Name = "Task3";
            this.Task3.Size = new System.Drawing.Size(257, 40);
            this.Task3.TabIndex = 4;
            this.Task3.Text = "3. Студентки-отличницы, в алфавитном порядке";
            this.Task3.UseVisualStyleBackColor = true;
            // 
            // Task4
            // 
            this.Task4.Location = new System.Drawing.Point(12, 150);
            this.Task4.Name = "Task4";
            this.Task4.Size = new System.Drawing.Size(257, 40);
            this.Task4.TabIndex = 5;
            this.Task4.Text = "4. Студентки-отличницы, живущие в Ачинске, в алфавитном порядке";
            this.Task4.UseVisualStyleBackColor = true;
            // 
            // Task5
            // 
            this.Task5.Location = new System.Drawing.Point(12, 196);
            this.Task5.Name = "Task5";
            this.Task5.Size = new System.Drawing.Size(257, 40);
            this.Task5.TabIndex = 6;
            this.Task5.Text = "5. Студенты по месту проживания в алфавитном порядке";
            this.Task5.UseVisualStyleBackColor = true;
            // 
            // Task6
            // 
            this.Task6.Location = new System.Drawing.Point(12, 242);
            this.Task6.Name = "Task6";
            this.Task6.Size = new System.Drawing.Size(257, 40);
            this.Task6.TabIndex = 7;
            this.Task6.Text = "6. Студенты отличники, живут в Москве, по алфавиту";
            this.Task6.UseVisualStyleBackColor = true;
            // 
            // Task7
            // 
            this.Task7.Location = new System.Drawing.Point(12, 288);
            this.Task7.Name = "Task7";
            this.Task7.Size = new System.Drawing.Size(257, 40);
            this.Task7.TabIndex = 8;
            this.Task7.Text = "7. Студенты по убыванию среднего бала";
            this.Task7.UseVisualStyleBackColor = true;
            // 
            // Task8
            // 
            this.Task8.Location = new System.Drawing.Point(12, 334);
            this.Task8.Name = "Task8";
            this.Task8.Size = new System.Drawing.Size(257, 62);
            this.Task8.TabIndex = 9;
            this.Task8.Text = "8. Студенты по курсам, по убыванию в зависимости от процентов отличников среди юн" +
    "ошей";
            this.Task8.UseVisualStyleBackColor = true;
            // 
            // Task9
            // 
            this.Task9.Location = new System.Drawing.Point(12, 398);
            this.Task9.Name = "Task9";
            this.Task9.Size = new System.Drawing.Size(257, 40);
            this.Task9.TabIndex = 10;
            this.Task9.Text = "9. Студенты факультета ИВТ,  сортировать группы по кол-ву неуспевающих студентов";
            this.Task9.UseVisualStyleBackColor = true;
            // 
            // Task10
            // 
            this.Task10.Location = new System.Drawing.Point(292, 12);
            this.Task10.Name = "Task10";
            this.Task10.Size = new System.Drawing.Size(257, 86);
            this.Task10.TabIndex = 11;
            this.Task10.Text = "10. Выдать номер курса фак-та ИВТ, где наибольший процент отличников. Выдать спис" +
    "ок студентов факультета ИВТ, отсортированные по группам с убыванием процента отл" +
    "ичников   ";
            this.Task10.UseVisualStyleBackColor = true;
            // 
            // Task12
            // 
            this.Task12.Location = new System.Drawing.Point(292, 196);
            this.Task12.Name = "Task12";
            this.Task12.Size = new System.Drawing.Size(257, 40);
            this.Task12.TabIndex = 12;
            this.Task12.Text = "12. Студентки по убыванию среднего балла";
            this.Task12.UseVisualStyleBackColor = true;
            // 
            // Task11
            // 
            this.Task11.Location = new System.Drawing.Point(292, 104);
            this.Task11.Name = "Task11";
            this.Task11.Size = new System.Drawing.Size(257, 86);
            this.Task11.TabIndex = 13;
            this.Task11.Text = "11. Выдать наиболее распространенную фамилию среди юношей.  Список студентов, сор" +
    "тировать по фамилиям  с уменьшением частоты фамилий,  фамилии юношей одинаково р" +
    "аспространнеых располагать по алфавиту";
            this.Task11.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 541);
            this.Controls.Add(this.Task11);
            this.Controls.Add(this.Task12);
            this.Controls.Add(this.Task10);
            this.Controls.Add(this.Task9);
            this.Controls.Add(this.Task8);
            this.Controls.Add(this.Task7);
            this.Controls.Add(this.Task6);
            this.Controls.Add(this.Task5);
            this.Controls.Add(this.Task4);
            this.Controls.Add(this.Task3);
            this.Controls.Add(this.Information);
            this.Controls.Add(this.mainField);
            this.Controls.Add(this.Task2);
            this.Controls.Add(this.Task1);
            this.Name = "Form1";
            this.Text = "Программа";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Task1;
        private System.Windows.Forms.Button Task2;
        private System.Windows.Forms.RichTextBox mainField;
        private System.Windows.Forms.Button Information;
        private System.Windows.Forms.Button Task3;
        private System.Windows.Forms.Button Task4;
        private System.Windows.Forms.Button Task5;
        private System.Windows.Forms.Button Task6;
        private System.Windows.Forms.Button Task7;
        private System.Windows.Forms.Button Task8;
        private System.Windows.Forms.Button Task9;
        private System.Windows.Forms.Button Task10;
        private System.Windows.Forms.Button Task12;
        private System.Windows.Forms.Button Task11;
    }
}

