﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRPJECT4NEW.Dean_of_Faculty
{
    public partial class Stu_Request : Form
    {
        public Stu_Request()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Stu_Request_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Course_ID to", "Course_ID");
            dataGridView1.Columns.Add("Subject", "Subject");
            dataGridView1.Columns.Add("Message", "Message");
            dataGridView1.Columns.Add("Status", "Status");
            DataGridViewCheckBoxColumn column = new DataGridViewCheckBoxColumn();
            {
                column.HeaderText = "Check";
                column.Name = "check";
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                column.FlatStyle = FlatStyle.Standard;
                column.ThreeState = false;
                column.IndeterminateValue = false;
                column.CellTemplate = new DataGridViewCheckBoxCell();
            }
            dataGridView1.Columns.Insert(dataGridView1.Columns.Count, column);
            //Paint headers
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Utility.HeaderBackColor;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Utility.HeaderBackColor;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.AutoResizeColumns();
            dataGridView1.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            using (Entities db = new Entities())
            {
                foreach (student_request s in db.student_request)
                {
                    dataGridView1.Rows.Add(s.ID, s.Course_ID, s.Subject, s.Message, s.Status);
                }
            }

        }

        private void Approve_btn_Click(object sender, EventArgs e)
        {
            int counter = 0;
            List<string> student_request1 = new List<string>();//id
            List<string> student_request2 = new List<string>();//subject
            int checkBoxColumn = dataGridView1.Columns.Count - 1;

            //List marked scholarships
            foreach (DataGridViewRow rw in this.dataGridView1.Rows)
            {
                if (rw.Cells[checkBoxColumn].Value != null && Convert.ToBoolean(rw.Cells[checkBoxColumn].Value) == true)
                {
                    student_request1.Add(rw.Cells[0].Value.ToString());
                    student_request2.Add(rw.Cells[1].Value.ToString());
                    counter++;
                }

            }

            using (Entities context = new Entities())
            {
                // change status
                foreach (student_request s in context.student_request)
                {

                    for (int i =0; i < counter; i++)
                    {
                        if (student_request1[i].Equals(s.ID) && student_request2[i].Equals(s.Course_ID.ToString()))
                        {
                            s.Status = "Approved";
                        }
                    }
                }

                //Save changes and reload grid
                context.SaveChanges();
                reloadDataGridView(context);
            }
            dataGridView1.Refresh();
        }
        private void reloadDataGridView(Entities context)
        {
            dataGridView1.Rows.Clear();
            foreach (student_request s in context.student_request)
            {
                dataGridView1.Rows.Add(s.ID, s.Course_ID, s.Subject, s.Message, s.Status);
            }
            dataGridView1.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridView1.Refresh();
        }

        private void Reject_btn_Click(object sender, EventArgs e)
        {
            int counter = 0;
            List<string> student_request = new List<string>();//id
            List<string> student_request2 = new List<string>();//subject
            int checkBoxColumn = dataGridView1.Columns.Count - 1;

            //List marked scholarships
            foreach (DataGridViewRow rw in this.dataGridView1.Rows)
            {
                if (rw.Cells[checkBoxColumn].Value != null && Convert.ToBoolean(rw.Cells[checkBoxColumn].Value) == true)
                {
                    student_request.Add(rw.Cells[0].Value.ToString());
                    student_request2.Add(rw.Cells[1].Value.ToString());
                    counter++;
                }
            }

            using (Entities context = new Entities())
            {


                // change status
                foreach (student_request s in context.student_request)
                {
                    for (int i = 0; i < counter; i++)
                    {
                        if (student_request[i].Equals(s.ID) && student_request2[i].Equals(s.Course_ID.ToString()))
                        {
                            s.Status = "Denied";
                        }
                    }

                }

                //Save changes and reload grid
                context.SaveChanges();
                reloadDataGridView(context);
            }
            dataGridView1.Refresh();
        }

    }
}