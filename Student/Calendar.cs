﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRPJECT4NEW.Student
{
    public partial class Calendar : Form
    {
        List<int> courseList = new List<int>();

        public Calendar()
        {
            InitializeComponent();
            CreateGridView();
            getData();
        }

        private void getData()
        {
            using (Entities context = new Entities())
            {
                //Select cources of a student without final grade for current year
                var selected =
                    from c in context.Student_Courses where c.stud_Id == Utility.User.ID.ToString() && c.final_grade == null
                    from i in context.Lecture_Course where i.Course_ID == c.course_id select i;

                //Place each Course into DataGridView
                foreach (var s in selected)
                {
                    cours course = context.courses.FirstOrDefault(c => c.Course_id == s.Course_ID);

                    if (!courseList.Contains(course.Course_id)) courseList.Add(course.Course_id);    //Add course id to list if necessary

                    for (int i = Convert.ToInt32(s.Start_time); i < Convert.ToInt32(s.End_time); i++)
                    {
                        this.calendarGridView.Rows[i - 8].Cells[s.Date.Trim()].Value = course.Course_name;
                        this.calendarGridView.Rows[i - 8].Cells[s.Date.Trim()].Style.BackColor = Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(172)))), ((int)(((byte)(228)))));
                        this.calendarGridView.Rows[i - 8].Cells[s.Date.Trim()].Style.ForeColor = Color.White;
                        this.calendarGridView.ColumnHeadersDefaultCellStyle.BackColor = Utility.HeaderBackColor;
                        this.calendarGridView.GridColor = Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));


                        this.calendarGridView.Rows[i - 8].Cells[s.Date.Trim()].Value = course.Course_name.Trim() + " Room:" + s.Class_number;   //Print data to cell
                        this.calendarGridView.Rows[i - 8].Cells[s.Date.Trim()].Style.BackColor = Utility.getColorByID(courseList.IndexOf(course.Course_id)); //Paint cell
                    }
                    
                }
            }
        } 

        private void CreateGridView()
        {
            //Create headers
            calendarGridView.Columns.Add("Time", "");
            calendarGridView.Columns.Add("Sunday", "Sunday");
            calendarGridView.Columns.Add("Monday", "Monday");
            calendarGridView.Columns.Add("Tuesday", "Tuesday");
            calendarGridView.Columns.Add("Wednesday", "Wednesday");
            calendarGridView.Columns.Add("Thursday", "Thursday");
            calendarGridView.Columns.Add("Friday", "Friday");
            for (int i = 8; i <= 23; i++){
                calendarGridView.Rows.Add(i + ":00");
            }

            //Preent Sorting
            foreach (DataGridViewColumn column in calendarGridView.Columns)
            {
                column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //Paint headers
            calendarGridView.Columns[0].DefaultCellStyle.BackColor = Utility.HeaderBackColor;
            calendarGridView.Columns[0].DefaultCellStyle.ForeColor = Color.White;
            calendarGridView.ColumnHeadersDefaultCellStyle.BackColor = Utility.HeaderBackColor;
            calendarGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            calendarGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            calendarGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            foreach (DataGridViewRow row in calendarGridView.Rows)
            {
                row.Height = 45;
            }


        }

        private void calendarGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            if (e.RowIndex < 1 || e.ColumnIndex < 0)
                return;
            if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
            {
                e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            }
            else
            {
                e.AdvancedBorderStyle.Top = calendarGridView.AdvancedCellBorderStyle.Top;
            }
        }

        bool IsTheSameCellValue(int column, int row)
        {
            DataGridViewCell cell1 = calendarGridView[column, row];
            DataGridViewCell cell2 = calendarGridView[column, row - 1];
            if (cell1.Value == null || cell2.Value == null)
            {
                return false;
            }
            return cell1.Value.ToString() == cell2.Value.ToString();
        }

        private void calendarGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == 0)
                return;
            if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
            {
                e.Value = "";
                e.FormattingApplied = true;
            }
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            calendarGridView.AutoGenerateColumns = false;
        }
    }
}
