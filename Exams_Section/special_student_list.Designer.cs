﻿namespace PRPJECT4NEW.Exams_Section
{
    partial class special_student_list
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Type_of_easements_comboBox = new System.Windows.Forms.ComboBox();
            this.Type_of_easements_label = new System.Windows.Forms.Label();
            this.Sview = new System.Windows.Forms.DataGridView();
            this.Refresh_Button = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.save_laptop_button = new System.Windows.Forms.Button();
            this.save_formulashetts_button = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.save_regular_stu_btn = new System.Windows.Forms.Button();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Sview)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Type_of_easements_comboBox
            // 
            this.Type_of_easements_comboBox.AccessibleName = "Type_of_easements_comboBox";
            this.Type_of_easements_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Type_of_easements_comboBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type_of_easements_comboBox.FormattingEnabled = true;
            this.Type_of_easements_comboBox.Location = new System.Drawing.Point(525, 63);
            this.Type_of_easements_comboBox.Margin = new System.Windows.Forms.Padding(14, 14, 14, 14);
            this.Type_of_easements_comboBox.Name = "Type_of_easements_comboBox";
            this.Type_of_easements_comboBox.Size = new System.Drawing.Size(216, 45);
            this.Type_of_easements_comboBox.TabIndex = 0;
            this.Type_of_easements_comboBox.SelectedIndexChanged += new System.EventHandler(this.Type_of_easements_comboBox_SelectedIndexChanged);
            // 
            // Type_of_easements_label
            // 
            this.Type_of_easements_label.AccessibleName = "Type_of_easements_label";
            this.Type_of_easements_label.AutoSize = true;
            this.Type_of_easements_label.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Type_of_easements_label.Location = new System.Drawing.Point(28, 63);
            this.Type_of_easements_label.Margin = new System.Windows.Forms.Padding(7, 0, 7, 4);
            this.Type_of_easements_label.Name = "Type_of_easements_label";
            this.Type_of_easements_label.Size = new System.Drawing.Size(416, 37);
            this.Type_of_easements_label.TabIndex = 1;
            this.Type_of_easements_label.Text = "Type of easements to show:";
            this.Type_of_easements_label.Click += new System.EventHandler(this.Type_of_easements_label_Click);
            // 
            // Sview
            // 
            this.Sview.AccessibleName = "Sview";
            this.Sview.AllowUserToAddRows = false;
            this.Sview.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Sview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Sview.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Sview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Sview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.Sview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Sview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Sview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Sview.DefaultCellStyle = dataGridViewCellStyle3;
            this.Sview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sview.Location = new System.Drawing.Point(0, 190);
            this.Sview.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Sview.Name = "Sview";
            this.Sview.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Sview.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Sview.RowHeadersVisible = false;
            this.Sview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.Sview.Size = new System.Drawing.Size(3338, 800);
            this.Sview.TabIndex = 2;
            this.Sview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Sview_CellContentClick);
            // 
            // Refresh_Button
            // 
            this.Refresh_Button.AutoSize = true;
            this.Refresh_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.Refresh_Button.FlatAppearance.BorderSize = 0;
            this.Refresh_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refresh_Button.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Refresh_Button.ForeColor = System.Drawing.Color.White;
            this.Refresh_Button.Location = new System.Drawing.Point(788, 16);
            this.Refresh_Button.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Refresh_Button.Name = "Refresh_Button";
            this.Refresh_Button.Size = new System.Drawing.Size(175, 136);
            this.Refresh_Button.TabIndex = 3;
            this.Refresh_Button.Text = "Refresh";
            this.Refresh_Button.UseVisualStyleBackColor = false;
            this.Refresh_Button.Click += new System.EventHandler(this.Refresh_Button_Click);
            // 
            // Save_button
            // 
            this.Save_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Save_button.AutoSize = true;
            this.Save_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.Save_button.FlatAppearance.BorderSize = 0;
            this.Save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_button.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Save_button.ForeColor = System.Drawing.Color.White;
            this.Save_button.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Save_button.Location = new System.Drawing.Point(35, 18);
            this.Save_button.Margin = new System.Windows.Forms.Padding(35, 18, 35, 36);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(560, 136);
            this.Save_button.TabIndex = 4;
            this.Save_button.Text = "Save Extra Time student list";
            this.Save_button.UseVisualStyleBackColor = false;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // save_laptop_button
            // 
            this.save_laptop_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.save_laptop_button.AutoSize = true;
            this.save_laptop_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.save_laptop_button.FlatAppearance.BorderSize = 0;
            this.save_laptop_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_laptop_button.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.save_laptop_button.ForeColor = System.Drawing.Color.White;
            this.save_laptop_button.Location = new System.Drawing.Point(665, 18);
            this.save_laptop_button.Margin = new System.Windows.Forms.Padding(35, 18, 35, 36);
            this.save_laptop_button.Name = "save_laptop_button";
            this.save_laptop_button.Size = new System.Drawing.Size(527, 136);
            this.save_laptop_button.TabIndex = 5;
            this.save_laptop_button.Text = "Save Laptop student list";
            this.save_laptop_button.UseVisualStyleBackColor = false;
            this.save_laptop_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // save_formulashetts_button
            // 
            this.save_formulashetts_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.save_formulashetts_button.AutoSize = true;
            this.save_formulashetts_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.save_formulashetts_button.FlatAppearance.BorderSize = 0;
            this.save_formulashetts_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_formulashetts_button.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.save_formulashetts_button.ForeColor = System.Drawing.Color.White;
            this.save_formulashetts_button.Location = new System.Drawing.Point(1262, 18);
            this.save_formulashetts_button.Margin = new System.Windows.Forms.Padding(35, 18, 35, 36);
            this.save_formulashetts_button.Name = "save_formulashetts_button";
            this.save_formulashetts_button.Size = new System.Drawing.Size(555, 136);
            this.save_formulashetts_button.TabIndex = 6;
            this.save_formulashetts_button.Text = "Save Formula Sheets student list";
            this.save_formulashetts_button.UseVisualStyleBackColor = false;
            this.save_formulashetts_button.Click += new System.EventHandler(this.save3_button_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = global::PRPJECT4NEW.Properties.Resources.bg_pattern2;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(3338, 190);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackgroundImage = global::PRPJECT4NEW.Properties.Resources.bg_pattern2;
            this.flowLayoutPanel2.Controls.Add(this.Save_button);
            this.flowLayoutPanel2.Controls.Add(this.save_laptop_button);
            this.flowLayoutPanel2.Controls.Add(this.save_formulashetts_button);
            this.flowLayoutPanel2.Controls.Add(this.save_regular_stu_btn);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 990);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(3338, 172);
            this.flowLayoutPanel2.TabIndex = 8;
            // 
            // save_regular_stu_btn
            // 
            this.save_regular_stu_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.save_regular_stu_btn.AutoSize = true;
            this.save_regular_stu_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.save_regular_stu_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_regular_stu_btn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_regular_stu_btn.ForeColor = System.Drawing.Color.White;
            this.save_regular_stu_btn.Location = new System.Drawing.Point(1887, 18);
            this.save_regular_stu_btn.Margin = new System.Windows.Forms.Padding(35, 18, 35, 36);
            this.save_regular_stu_btn.Name = "save_regular_stu_btn";
            this.save_regular_stu_btn.Size = new System.Drawing.Size(513, 136);
            this.save_regular_stu_btn.TabIndex = 7;
            this.save_regular_stu_btn.Text = "Save students without easment";
            this.save_regular_stu_btn.UseVisualStyleBackColor = false;
            this.save_regular_stu_btn.Click += new System.EventHandler(this.save_regular_stu_btn_Click);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(PRPJECT4NEW.student);
            // 
            // special_student_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3338, 1162);
            this.Controls.Add(this.Refresh_Button);
            this.Controls.Add(this.Sview);
            this.Controls.Add(this.Type_of_easements_label);
            this.Controls.Add(this.Type_of_easements_comboBox);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "special_student_list";
            this.Text = "special_student_list";
            this.Load += new System.EventHandler(this.special_student_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Sview)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.ComboBox Type_of_easements_comboBox;
        private System.Windows.Forms.Label Type_of_easements_label;
        private System.Windows.Forms.DataGridView Sview;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button save_laptop_button;
        private System.Windows.Forms.Button save_formulashetts_button;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button Refresh_Button;
        private System.Windows.Forms.Button save_regular_stu_btn;
    }
}