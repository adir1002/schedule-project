﻿namespace PRPJECT4NEW.Teaching_Assistant
{
    partial class AddLabExercises
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CourseIDLabel = new System.Windows.Forms.Label();
            this.CourseIDButton = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StartTimeButton = new System.Windows.Forms.ComboBox();
            this.Day = new System.Windows.Forms.Label();
            this.DayButton = new System.Windows.Forms.ComboBox();
            this.Apply_Button = new System.Windows.Forms.Button();
            this.Semester = new System.Windows.Forms.Label();
            this.SemesterButton = new System.Windows.Forms.ComboBox();
            this.Class = new System.Windows.Forms.Label();
            this.ClassButton = new System.Windows.Forms.ComboBox();
            this.Lab_Exercise = new System.Windows.Forms.Label();
            this.LabExercise = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CourseIDLabel
            // 
            this.CourseIDLabel.AccessibleName = "CourseLabel";
            this.CourseIDLabel.AutoSize = true;
            this.CourseIDLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.CourseIDLabel.Location = new System.Drawing.Point(12, 9);
            this.CourseIDLabel.Name = "CourseIDLabel";
            this.CourseIDLabel.Size = new System.Drawing.Size(62, 16);
            this.CourseIDLabel.TabIndex = 0;
            this.CourseIDLabel.Text = "Course ID:";
            // 
            // CourseIDButton
            // 
            this.CourseIDButton.AccessibleName = "CourseID";
            this.CourseIDButton.FormattingEnabled = true;
            this.CourseIDButton.Items.AddRange(new object[] {
            "100",
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "200",
            "201",
            "202",
            "203",
            "204",
            "205",
            "206",
            "207",
            "208",
            "209",
            "300",
            "301",
            "302",
            "303",
            "304",
            "305",
            "306",
            "307",
            "400",
            "401",
            "402",
            "403",
            "404",
            "405",
            "406"});
            this.CourseIDButton.Location = new System.Drawing.Point(12, 25);
            this.CourseIDButton.Name = "CourseIDButton";
            this.CourseIDButton.Size = new System.Drawing.Size(80, 21);
            this.CourseIDButton.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AccessibleName = "StartTime";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.label1.Location = new System.Drawing.Point(95, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start Time:";
            // 
            // StartTimeButton
            // 
            this.StartTimeButton.AccessibleName = "StartTime";
            this.StartTimeButton.FormattingEnabled = true;
            this.StartTimeButton.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19"});
            this.StartTimeButton.Location = new System.Drawing.Point(98, 25);
            this.StartTimeButton.Name = "StartTimeButton";
            this.StartTimeButton.Size = new System.Drawing.Size(74, 21);
            this.StartTimeButton.TabIndex = 3;
            // 
            // Day
            // 
            this.Day.AccessibleName = "Day";
            this.Day.AutoSize = true;
            this.Day.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.Day.Location = new System.Drawing.Point(12, 57);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(33, 16);
            this.Day.TabIndex = 4;
            this.Day.Text = "Day:";
            // 
            // DayButton
            // 
            this.DayButton.AccessibleName = "DayButton";
            this.DayButton.FormattingEnabled = true;
            this.DayButton.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday"});
            this.DayButton.Location = new System.Drawing.Point(12, 73);
            this.DayButton.Name = "DayButton";
            this.DayButton.Size = new System.Drawing.Size(80, 21);
            this.DayButton.TabIndex = 5;
            // 
            // Apply_Button
            // 
            this.Apply_Button.AccessibleName = "Apply_Button";
            this.Apply_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.Apply_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Apply_Button.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.Apply_Button.ForeColor = System.Drawing.SystemColors.Window;
            this.Apply_Button.Location = new System.Drawing.Point(98, 159);
            this.Apply_Button.Name = "Apply_Button";
            this.Apply_Button.Size = new System.Drawing.Size(80, 25);
            this.Apply_Button.TabIndex = 4;
            this.Apply_Button.Text = "Apply";
            this.Apply_Button.UseVisualStyleBackColor = false;
            this.Apply_Button.Click += new System.EventHandler(this.Apply_Button_Click);
            // 
            // Semester
            // 
            this.Semester.AccessibleName = "Semester";
            this.Semester.AutoSize = true;
            this.Semester.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.Semester.Location = new System.Drawing.Point(99, 57);
            this.Semester.Name = "Semester";
            this.Semester.Size = new System.Drawing.Size(59, 16);
            this.Semester.TabIndex = 7;
            this.Semester.Text = "Semester:";
            // 
            // SemesterButton
            // 
            this.SemesterButton.AccessibleName = "SemesterButton";
            this.SemesterButton.FormattingEnabled = true;
            this.SemesterButton.Items.AddRange(new object[] {
            "a",
            "b"});
            this.SemesterButton.Location = new System.Drawing.Point(98, 73);
            this.SemesterButton.Name = "SemesterButton";
            this.SemesterButton.Size = new System.Drawing.Size(74, 21);
            this.SemesterButton.TabIndex = 8;
            // 
            // Class
            // 
            this.Class.AccessibleName = "Class";
            this.Class.AutoSize = true;
            this.Class.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.Class.Location = new System.Drawing.Point(12, 107);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(38, 16);
            this.Class.TabIndex = 9;
            this.Class.Text = "Class:";
            // 
            // ClassButton
            // 
            this.ClassButton.AccessibleName = "ClassID";
            this.ClassButton.FormattingEnabled = true;
            this.ClassButton.Items.AddRange(new object[] {
            "a101",
            "a102",
            "f101",
            "f102",
            "f103",
            "f104",
            "s101",
            "s102",
            "s103",
            "s104"});
            this.ClassButton.Location = new System.Drawing.Point(12, 123);
            this.ClassButton.Name = "ClassButton";
            this.ClassButton.Size = new System.Drawing.Size(80, 21);
            this.ClassButton.TabIndex = 10;
            // 
            // Lab_Exercise
            // 
            this.Lab_Exercise.AccessibleName = "Lab/Exercise";
            this.Lab_Exercise.AutoSize = true;
            this.Lab_Exercise.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.Lab_Exercise.Location = new System.Drawing.Point(99, 107);
            this.Lab_Exercise.Name = "Lab_Exercise";
            this.Lab_Exercise.Size = new System.Drawing.Size(79, 16);
            this.Lab_Exercise.TabIndex = 11;
            this.Lab_Exercise.Text = "Lab/Exercise:";
            // 
            // LabExercise
            // 
            this.LabExercise.AccessibleName = "LabExerciseButton";
            this.LabExercise.FormattingEnabled = true;
            this.LabExercise.Items.AddRange(new object[] {
            "Lab",
            "Exercise"});
            this.LabExercise.Location = new System.Drawing.Point(98, 123);
            this.LabExercise.Name = "LabExercise";
            this.LabExercise.Size = new System.Drawing.Size(74, 21);
            this.LabExercise.TabIndex = 12;
            // 
            // AddLabExercises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PRPJECT4NEW.Properties.Resources.bg_pattern2;
            this.ClientSize = new System.Drawing.Size(205, 196);
            this.Controls.Add(this.LabExercise);
            this.Controls.Add(this.Lab_Exercise);
            this.Controls.Add(this.ClassButton);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.SemesterButton);
            this.Controls.Add(this.Semester);
            this.Controls.Add(this.Apply_Button);
            this.Controls.Add(this.DayButton);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.StartTimeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CourseIDButton);
            this.Controls.Add(this.CourseIDLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddLabExercises";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddLabExercises";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CourseIDLabel;
        private System.Windows.Forms.ComboBox CourseIDButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox StartTimeButton;
        private System.Windows.Forms.Label Day;
        private System.Windows.Forms.ComboBox DayButton;
        private System.Windows.Forms.Button Apply_Button;
        private System.Windows.Forms.Label Semester;
        private System.Windows.Forms.ComboBox SemesterButton;
        private System.Windows.Forms.Label Class;
        private System.Windows.Forms.ComboBox ClassButton;
        private System.Windows.Forms.Label Lab_Exercise;
        private System.Windows.Forms.ComboBox LabExercise;
    }
}