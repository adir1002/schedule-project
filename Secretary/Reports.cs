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
using System.IO;


namespace PRPJECT4NEW.Secretary
{
    public partial class Reports : Form
    {
        private string connetionString = null;
        private SqlConnection sqlcon;
        public Reports()
        {
            InitializeComponent();
        }

        private void Load_table_Click(object sender, EventArgs e)
        {
        }

        private void StudentReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Load_table_Click_1(object sender, EventArgs e)
        {

            this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            this.sqlcon = new SqlConnection(connetionString);
            SqlCommand cmd = new SqlCommand("select ID,F_name,L_name,Telephone,Email from person where Permission='" + "Student"+"'", sqlcon);

            try
            {
 
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = dbdataset;
                StudentReport.DataSource = bsource;
                sda.Update(dbdataset);
                //Paint headers
                StudentReport.EnableHeadersVisualStyles = false;
                StudentReport.GridColor = Utility.HeaderBackColor;
                StudentReport.ColumnHeadersDefaultCellStyle.BackColor = Utility.HeaderBackColor;
                StudentReport.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                StudentReport.AutoResizeColumns();
                StudentReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                StudentReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            this.sqlcon = new SqlConnection(connetionString);

            SqlCommand cmd = new SqlCommand("select ID,F_name,L_name,Telephone,Email from person where Permission='Teaching_Assistant' OR Permission='Lecturer' ", sqlcon);


            try
            {
                
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();
                //Paint headers
                StudentReport.EnableHeadersVisualStyles = false;
                StudentReport.GridColor = Utility.HeaderBackColor;
                StudentReport.ColumnHeadersDefaultCellStyle.BackColor = Utility.HeaderBackColor;
                StudentReport.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                StudentReport.AutoResizeColumns();
                StudentReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                StudentReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;


                bsource.DataSource = dbdataset;
                StudentReport.DataSource = bsource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            this.sqlcon = new SqlConnection(connetionString);
            try
            {
                SqlCommand cmd = new SqlCommand("select stud_Id, final_grade from Student_Courses where final_grade <= 56 and course_id='" + CourseID.Text + "'", sqlcon);
                StudentReport.Visible = true;
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();

                //Paint headers
                StudentReport.EnableHeadersVisualStyles = false;
                StudentReport.GridColor = Utility.HeaderBackColor;
                StudentReport.ColumnHeadersDefaultCellStyle.BackColor = Utility.HeaderBackColor;
                StudentReport.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                StudentReport.AutoResizeColumns();
                StudentReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                StudentReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;


                bsource.DataSource = dbdataset;
                StudentReport.DataSource = bsource;
                sda.Update(dbdataset);
            }
            catch (SqlException ex)
            {
                CourseID.Text = "";
                MessageBox.Show("Error selecting course id, try again!!\n" + ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Reports_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void SM1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void sM1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sEMESTERToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Class_ID_1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Print_Click(object sender, EventArgs e)
        {
            string str = "Course Detailes";
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path = path.Replace(@"\", @"\\");
            path += "\\";

            try
            {
                this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
               
                StreamWriter myFile = new StreamWriter(@"" + path + "'" + str + "'.xls");

                using (SqlConnection connection = new SqlConnection(connetionString))
                {
                    string query = "select * from courses ";

                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    try
                    {
                        myFile.WriteLine(String.Format("Course_id\tCourse_name\tNakaz\tYear\tSemester\tBlocking_Course\n"));
                        while (reader.Read())
                        {
                            myFile.WriteLine(String.Format("{0}\t {1}\t {2}\t {3}\t {4}\t {5}\t ",
                            reader["Course_id"], reader["Course_name"], reader["Nakaz"], reader["Year"], reader["Semester"], reader["Blocking_Cource"]));
                        }
                        MessageBox.Show("The file created");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        //Dts.TaskResult = (int)ScriptResults.Failure;
                    }
                    finally
                    {

                        reader.Close();
                        myFile.Close();
                    }

                }
                
                FileInfo fi = new FileInfo(@"" + path + "'" + str + "'.xls");
                if (fi.Exists)
                {
                    System.Diagnostics.Process.Start(@"" + path + "'" + str + "'.xls");

                }
                else
                {
                    MessageBox.Show("File not exsits");
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            double sum_avg = 0;
            int counter = 0;
            try
            {
                this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
                this.sqlcon = new SqlConnection(connetionString);
                this.sqlcon.Open();
                if (CourseID.Text != "")
                {
                    SqlCommand cmd = new SqlCommand("select final_grade from Student_Courses where course_id  ='" + CourseID.Text + "' and Type = 1", sqlcon);
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        if (dr[0] != DBNull.Value)
                        {
                            sum_avg += Convert.ToInt32(dr[0].ToString());
                            counter++;
                        }
                    }

                    MessageBox.Show("The AVG Grades of all students in Course \n" + CourseID.Text + ":\n" + sum_avg / counter);
                    dr.Close();

                    this.sqlcon.Close();
                }
                else
                {

                } 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CourseID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Failing_Students_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

