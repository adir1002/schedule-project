﻿namespace PRPJECT4NEW.Secretary
{
    partial class Course_And_Prev
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
            this.Link_courses = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Curr_Course = new System.Windows.Forms.ToolStripComboBox();
            this.prev_course = new System.Windows.Forms.ToolStripComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Link_courses
            // 
            this.Link_courses.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Link_courses.FlatAppearance.BorderSize = 0;
            this.Link_courses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Link_courses.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Link_courses.Location = new System.Drawing.Point(158, 118);
            this.Link_courses.Name = "Link_courses";
            this.Link_courses.Size = new System.Drawing.Size(208, 52);
            this.Link_courses.TabIndex = 2;
            this.Link_courses.Text = "Link";
            this.Link_courses.UseVisualStyleBackColor = false;
            this.Link_courses.Click += new System.EventHandler(this.Link_courses_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1,
            this.Curr_Course,
            this.prev_course});
            this.menuStrip1.Location = new System.Drawing.Point(48, 30);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(271, 39);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(12, 35);
            // 
            // Curr_Course
            // 
            this.Curr_Course.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Curr_Course.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Curr_Course.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Curr_Course.Items.AddRange(new object[] {
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
            "308",
            "400",
            "401",
            "402",
            "403",
            "404",
            "405",
            "406"});
            this.Curr_Course.Name = "Curr_Course";
            this.Curr_Course.Size = new System.Drawing.Size(119, 35);
            this.Curr_Course.Text = "Choose Course";
            // 
            // prev_course
            // 
            this.prev_course.BackColor = System.Drawing.SystemColors.HotTrack;
            this.prev_course.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prev_course.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.prev_course.Items.AddRange(new object[] {
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
            "308",
            "400",
            "401",
            "402",
            "403",
            "404",
            "405",
            "406"});
            this.prev_course.Name = "prev_course";
            this.prev_course.Size = new System.Drawing.Size(121, 35);
            this.prev_course.Text = "Previous Course";
            // 
            // Course_And_Prev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PRPJECT4NEW.Properties.Resources.bg_pattern2;
            this.ClientSize = new System.Drawing.Size(662, 391);
            this.Controls.Add(this.Link_courses);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Course_And_Prev";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Course_And_Prev_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Link_courses;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripComboBox1;
        private System.Windows.Forms.ToolStripComboBox Curr_Course;
        private System.Windows.Forms.ToolStripComboBox prev_course;
    }
}