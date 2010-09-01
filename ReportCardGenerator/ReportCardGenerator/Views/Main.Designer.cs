﻿namespace ReportCardGenerator.Views
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportCardGeneratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GrabeBookList = new System.Windows.Forms.ListBox();
            this.StudentList = new System.Windows.Forms.ListBox();
            this.Del_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Add_hoom_btn = new System.Windows.Forms.Button();
            this.Add_grade_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Desktop;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.reportCardToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(492, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // reportCardToolStripMenuItem
            // 
            this.reportCardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportCardGeneratorToolStripMenuItem});
            this.reportCardToolStripMenuItem.Name = "reportCardToolStripMenuItem";
            this.reportCardToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.reportCardToolStripMenuItem.Text = "Report &Card";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // reportCardGeneratorToolStripMenuItem
            // 
            this.reportCardGeneratorToolStripMenuItem.Name = "reportCardGeneratorToolStripMenuItem";
            this.reportCardGeneratorToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.reportCardGeneratorToolStripMenuItem.Text = "Report Card Generator";
            // 
            // GrabeBookList
            // 
            this.GrabeBookList.FormattingEnabled = true;
            this.GrabeBookList.Location = new System.Drawing.Point(74, 48);
            this.GrabeBookList.Name = "GrabeBookList";
            this.GrabeBookList.Size = new System.Drawing.Size(147, 134);
            this.GrabeBookList.TabIndex = 1;
            this.GrabeBookList.SelectedIndexChanged += new System.EventHandler(this.GrabeBookList_SelectedIndexChanged);
            // 
            // StudentList
            // 
            this.StudentList.FormattingEnabled = true;
            this.StudentList.Location = new System.Drawing.Point(96, 278);
            this.StudentList.Name = "StudentList";
            this.StudentList.Size = new System.Drawing.Size(260, 69);
            this.StudentList.TabIndex = 2;
            this.StudentList.SelectedIndexChanged += new System.EventHandler(this.StudentList_SelectedIndexChanged);
            // 
            // Del_btn
            // 
            this.Del_btn.Location = new System.Drawing.Point(165, 199);
            this.Del_btn.Name = "Del_btn";
            this.Del_btn.Size = new System.Drawing.Size(56, 23);
            this.Del_btn.TabIndex = 6;
            this.Del_btn.Text = "Delete";
            this.Del_btn.UseVisualStyleBackColor = true;
            this.Del_btn.Click += new System.EventHandler(this.Del_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Student (From XML)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "GradeBook";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Add_hoom_btn
            // 
            this.Add_hoom_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Add_hoom_btn.Location = new System.Drawing.Point(242, 68);
            this.Add_hoom_btn.Name = "Add_hoom_btn";
            this.Add_hoom_btn.Size = new System.Drawing.Size(26, 23);
            this.Add_hoom_btn.TabIndex = 9;
            this.Add_hoom_btn.UseVisualStyleBackColor = false;
            this.Add_hoom_btn.Click += new System.EventHandler(this.Add_hoom_btn_Click);
            // 
            // Add_grade_btn
            // 
            this.Add_grade_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Add_grade_btn.Location = new System.Drawing.Point(242, 112);
            this.Add_grade_btn.Name = "Add_grade_btn";
            this.Add_grade_btn.Size = new System.Drawing.Size(26, 23);
            this.Add_grade_btn.TabIndex = 10;
            this.Add_grade_btn.UseVisualStyleBackColor = false;
            this.Add_grade_btn.Click += new System.EventHandler(this.Add_grade_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Add Hoomroom XML Gradebook";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Add XML Gradebook";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 364);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Add_grade_btn);
            this.Controls.Add(this.Add_hoom_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Del_btn);
            this.Controls.Add(this.StudentList);
            this.Controls.Add(this.GrabeBookList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportCardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportCardGeneratorToolStripMenuItem;
        private System.Windows.Forms.ListBox GrabeBookList;
        private System.Windows.Forms.ListBox StudentList;
        private System.Windows.Forms.Button Del_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Add_hoom_btn;
        private System.Windows.Forms.Button Add_grade_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

    }
}

