namespace College
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_AddStudent = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_AddTeacher = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_InfoStudentMarks = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_InfoStudentGroup = new System.Windows.Forms.Label();
            this.label_InfoStudentFio = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label_InfoTeacherGroup = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label_InfoTeacherFio = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button_Sort = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button_Edit = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(69, 46);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(130, 22);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Группа";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(69, 74);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(130, 22);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Оценки";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox1.Controls.Add(this.button_AddStudent);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 148);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить студента";
            // 
            // button_AddStudent
            // 
            this.button_AddStudent.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button_AddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_AddStudent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_AddStudent.Location = new System.Drawing.Point(6, 102);
            this.button_AddStudent.Name = "button_AddStudent";
            this.button_AddStudent.Size = new System.Drawing.Size(193, 39);
            this.button_AddStudent.TabIndex = 12;
            this.button_AddStudent.Text = "Добавить";
            this.button_AddStudent.UseVisualStyleBackColor = false;
            this.button_AddStudent.Click += new System.EventHandler(this.button_AddStudent_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox2.Controls.Add(this.button_AddTeacher);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(223, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(205, 123);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Добавить преподавателя";
            // 
            // button_AddTeacher
            // 
            this.button_AddTeacher.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button_AddTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_AddTeacher.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_AddTeacher.Location = new System.Drawing.Point(6, 77);
            this.button_AddTeacher.Name = "button_AddTeacher";
            this.button_AddTeacher.Size = new System.Drawing.Size(193, 39);
            this.button_AddTeacher.TabIndex = 13;
            this.button_AddTeacher.Text = "Добавить";
            this.button_AddTeacher.UseVisualStyleBackColor = false;
            this.button_AddTeacher.Click += new System.EventHandler(this.button_AddTeacher_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "ФИО";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(69, 49);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(130, 22);
            this.textBox5.TabIndex = 3;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(69, 24);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(130, 22);
            this.textBox6.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Группа";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label_InfoStudentMarks);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label_InfoStudentGroup);
            this.groupBox3.Controls.Add(this.label_InfoStudentFio);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(12, 178);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(410, 106);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Информация";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Оценки";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "ФИО";
            // 
            // label_InfoStudentMarks
            // 
            this.label_InfoStudentMarks.AutoSize = true;
            this.label_InfoStudentMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_InfoStudentMarks.Location = new System.Drawing.Point(80, 74);
            this.label_InfoStudentMarks.Name = "label_InfoStudentMarks";
            this.label_InfoStudentMarks.Size = new System.Drawing.Size(14, 20);
            this.label_InfoStudentMarks.TabIndex = 15;
            this.label_InfoStudentMarks.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Группа";
            // 
            // label_InfoStudentGroup
            // 
            this.label_InfoStudentGroup.AutoSize = true;
            this.label_InfoStudentGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_InfoStudentGroup.Location = new System.Drawing.Point(80, 49);
            this.label_InfoStudentGroup.Name = "label_InfoStudentGroup";
            this.label_InfoStudentGroup.Size = new System.Drawing.Size(14, 20);
            this.label_InfoStudentGroup.TabIndex = 14;
            this.label_InfoStudentGroup.Text = "-";
            // 
            // label_InfoStudentFio
            // 
            this.label_InfoStudentFio.AutoSize = true;
            this.label_InfoStudentFio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_InfoStudentFio.Location = new System.Drawing.Point(80, 24);
            this.label_InfoStudentFio.Name = "label_InfoStudentFio";
            this.label_InfoStudentFio.Size = new System.Drawing.Size(14, 20);
            this.label_InfoStudentFio.TabIndex = 13;
            this.label_InfoStudentFio.Text = "-";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox4.Controls.Add(this.label_InfoTeacherGroup);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label_InfoTeacherFio);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Location = new System.Drawing.Point(12, 302);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(410, 77);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Информация";
            // 
            // label_InfoTeacherGroup
            // 
            this.label_InfoTeacherGroup.AutoSize = true;
            this.label_InfoTeacherGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_InfoTeacherGroup.Location = new System.Drawing.Point(69, 49);
            this.label_InfoTeacherGroup.Name = "label_InfoTeacherGroup";
            this.label_InfoTeacherGroup.Size = new System.Drawing.Size(14, 20);
            this.label_InfoTeacherGroup.TabIndex = 17;
            this.label_InfoTeacherGroup.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "ФИО";
            // 
            // label_InfoTeacherFio
            // 
            this.label_InfoTeacherFio.AutoSize = true;
            this.label_InfoTeacherFio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_InfoTeacherFio.Location = new System.Drawing.Point(69, 24);
            this.label_InfoTeacherFio.Name = "label_InfoTeacherFio";
            this.label_InfoTeacherFio.Size = new System.Drawing.Size(14, 20);
            this.label_InfoTeacherFio.TabIndex = 16;
            this.label_InfoTeacherFio.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "Группа";
            // 
            // comboBox1
            // 
            this.comboBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.comboBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Преподаватели",
            "Студенты"});
            this.comboBox1.Location = new System.Drawing.Point(482, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(416, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.EnabledChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(482, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(416, 272);
            this.listBox1.TabIndex = 9;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ShowInfo);
            // 
            // button_Sort
            // 
            this.button_Sort.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button_Sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Sort.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Sort.Location = new System.Drawing.Point(697, 318);
            this.button_Sort.Name = "button_Sort";
            this.button_Sort.Size = new System.Drawing.Size(201, 39);
            this.button_Sort.TabIndex = 10;
            this.button_Sort.Text = "Отсортировать";
            this.button_Sort.UseVisualStyleBackColor = false;
            this.button_Sort.Click += new System.EventHandler(this.button_Sort_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.Red;
            this.button_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Delete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Delete.Location = new System.Drawing.Point(482, 318);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(201, 39);
            this.button_Delete.TabIndex = 11;
            this.button_Delete.Text = "Удалить";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 18;
            this.listBox2.Location = new System.Drawing.Point(482, 40);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(416, 272);
            this.listBox2.TabIndex = 12;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.ShowInfo);
            // 
            // button_Edit
            // 
            this.button_Edit.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Edit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Edit.Location = new System.Drawing.Point(697, 363);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(201, 39);
            this.button_Edit.TabIndex = 13;
            this.button_Edit.Text = "Редактировать";
            this.button_Edit.UseVisualStyleBackColor = false;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // button_Reset
            // 
            this.button_Reset.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Reset.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Reset.Location = new System.Drawing.Point(482, 363);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(201, 39);
            this.button_Reset.TabIndex = 14;
            this.button_Reset.Text = "Сброс выбора";
            this.button_Reset.UseVisualStyleBackColor = false;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(910, 416);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Sort);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "Учёт студентов и преподавателей";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button_Sort;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_AddStudent;
        private System.Windows.Forms.Button button_AddTeacher;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label_InfoStudentFio;
        private System.Windows.Forms.Label label_InfoStudentGroup;
        private System.Windows.Forms.Label label_InfoStudentMarks;
        private System.Windows.Forms.Label label_InfoTeacherFio;
        private System.Windows.Forms.Label label_InfoTeacherGroup;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.Button button_Reset;
    }
}

