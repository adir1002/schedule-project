﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PRPJECT4NEW.Exams_Section
{
    public partial class Special_Test : Form
    {
        public Special_Test()
        {
            InitializeComponent();
            using (Entities context = new Entities())
            {
                var allRowes = context.students.ToList();

                foreach (var s in context.courses)
                    Combo_Course_name.Items.Add(s.Course_name);

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        //protected void RefreshTB(Entities context)
        //{
        //    //dataGridView1.Rows.Clear();
        //    foreach (var s in context.Student_special_Exam)
        //    {
        //        dataGridView1.Rows.Add(s.ID,s.Course_Serial,s.Date,s.Status);
        //    }
        //    dataGridView1.Refresh();
        //}

        private void button1_Click(object sender, EventArgs e)
        {

        }
        // shoe just the students with approved request of special exam
        private void Special_Test_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("ID", "Student ID");
            dataGridView1.Columns.Add("Course_ID", "Course ID");
            dataGridView1.Columns.Add("Course_Name", "Course_Name");

            //Paint headers
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Utility.HeaderBackColor;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Utility.HeaderBackColor;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.AutoResizeColumns();

            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            using (Entities context = new Entities())
            {
                int i = 0;
                foreach (var s in context.student_request)
                {
                    if (s.Status == "Approved" && s.Course_ID!=0)
                    {
                        studentspecialExamBindingSource.DataSource = s;

                        foreach (var v in context.courses)
                        {
                            if (s.Course_ID.ToString().Contains(v.Course_id.ToString()))
                            {
                                dataGridView1.Rows.Add(s.ID, s.Course_ID, v.Course_name);
                            }
                        }
                        i++;
                    }
                }
                dataGridView1.Refresh();
            }
        }

        private void Combo_Course_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            using (Entities context = new Entities())
            {
                foreach (var s in context.student_request)
                {
                    if (Combo_Course_name.Text == null)
                    {
                        if (s.Status == "Approved")
                        {
                            studentspecialExamBindingSource.DataSource = s;
                        }
                    }
                    else
                    {
                        dataGridView1.Rows.Clear();
                        foreach (var v in context.courses)
                        {
                            if (v.Course_name.Contains(Combo_Course_name.Text) && v.Course_id==s.Course_ID)
                            {
                                
                                dataGridView1.Rows.Add(s.ID, s.Course_ID, v.Course_name);                                
                            }
                        }
                    }
                }
                dataGridView1.Refresh();
            }
        }

        //private bool  check_Course_combo(int courseSerial)
        //{
        //    Entities context = new Entities();
        //    Lecture_Course ss = context.Lecture_Course.FirstOrDefault(s => s.Course_Serial== courseSerial);
        //    if (ss != null)
        //        return true;
        //    return false;
        //}
    }
}

