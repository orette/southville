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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setSchoolDaysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GrabeBookList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StudGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.T3Tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.T2Tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.T1Tb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SYcb = new System.Windows.Forms.ComboBox();
            this.CrystalReportbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Add_grade_btn = new System.Windows.Forms.Button();
            this.Add_hoom_btn = new System.Windows.Forms.Button();
            this.Del_btn = new System.Windows.Forms.Button();
            this.addAttendBtn = new System.Windows.Forms.Button();
            this.addCommentBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(917, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.closeToolStripMenuItem.Text = "&Exit";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setSchoolDaysToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // setSchoolDaysToolStripMenuItem
            // 
            this.setSchoolDaysToolStripMenuItem.Name = "setSchoolDaysToolStripMenuItem";
            this.setSchoolDaysToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.setSchoolDaysToolStripMenuItem.Text = "Set School Days";
            this.setSchoolDaysToolStripMenuItem.Click += new System.EventHandler(this.setSchoolDaysToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authorToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // authorToolStripMenuItem
            // 
            this.authorToolStripMenuItem.Name = "authorToolStripMenuItem";
            this.authorToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.authorToolStripMenuItem.Text = "Author";
            this.authorToolStripMenuItem.Click += new System.EventHandler(this.authorToolStripMenuItem_Click);
            // 
            // GrabeBookList
            // 
            this.GrabeBookList.FormattingEnabled = true;
            this.GrabeBookList.HorizontalScrollbar = true;
            this.GrabeBookList.ItemHeight = 16;
            this.GrabeBookList.Location = new System.Drawing.Point(16, 59);
            this.GrabeBookList.Margin = new System.Windows.Forms.Padding(4);
            this.GrabeBookList.Name = "GrabeBookList";
            this.GrabeBookList.Size = new System.Drawing.Size(549, 164);
            this.GrabeBookList.TabIndex = 1;
            this.GrabeBookList.SelectedIndexChanged += new System.EventHandler(this.GrabeBookList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "GradeBook";
            // 
            // StudGridView
            // 
            this.StudGridView.AllowUserToAddRows = false;
            this.StudGridView.AllowUserToDeleteRows = false;
            this.StudGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.StudGridView.Location = new System.Drawing.Point(16, 428);
            this.StudGridView.Margin = new System.Windows.Forms.Padding(4);
            this.StudGridView.Name = "StudGridView";
            this.StudGridView.ReadOnly = true;
            this.StudGridView.Size = new System.Drawing.Size(55, 36);
            this.StudGridView.TabIndex = 14;
            this.StudGridView.Visible = false;
            this.StudGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudGridView_CellClick);
            this.StudGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudGridView_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "StudentId";
            this.Column1.HeaderText = "StudentID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "FirstName";
            this.Column2.HeaderText = "FirstName";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "LastName";
            this.Column3.HeaderText = "LastName";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveBtn);
            this.groupBox1.Controls.Add(this.T3Tb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.T2Tb);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.T1Tb);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.SYcb);
            this.groupBox1.Location = new System.Drawing.Point(573, 59);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(336, 165);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Number of School days and School Year";
            // 
            // saveBtn
            // 
            this.saveBtn.Image = global::ReportCardGenerator.Properties.Resources.confirm;
            this.saveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveBtn.Location = new System.Drawing.Point(137, 136);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(66, 23);
            this.saveBtn.TabIndex = 7;
            this.saveBtn.Text = "Save";
            this.saveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Visible = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // T3Tb
            // 
            this.T3Tb.Location = new System.Drawing.Point(259, 107);
            this.T3Tb.Margin = new System.Windows.Forms.Padding(4);
            this.T3Tb.Name = "T3Tb";
            this.T3Tb.ReadOnly = true;
            this.T3Tb.Size = new System.Drawing.Size(53, 22);
            this.T3Tb.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Term 3";
            // 
            // T2Tb
            // 
            this.T2Tb.Location = new System.Drawing.Point(144, 107);
            this.T2Tb.Margin = new System.Windows.Forms.Padding(4);
            this.T2Tb.Name = "T2Tb";
            this.T2Tb.ReadOnly = true;
            this.T2Tb.Size = new System.Drawing.Size(53, 22);
            this.T2Tb.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(145, 79);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Term 2";
            // 
            // T1Tb
            // 
            this.T1Tb.Location = new System.Drawing.Point(24, 107);
            this.T1Tb.Margin = new System.Windows.Forms.Padding(4);
            this.T1Tb.Name = "T1Tb";
            this.T1Tb.ReadOnly = true;
            this.T1Tb.Size = new System.Drawing.Size(53, 22);
            this.T1Tb.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 79);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Term 1";
            // 
            // SYcb
            // 
            this.SYcb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SYcb.FormattingEnabled = true;
            this.SYcb.Items.AddRange(new object[] {
            "2010-2011",
            "2011-2012",
            "2012-2013",
            "2013-2014",
            "2014-2015",
            "2015-2016",
            "2016-2017",
            "2017-2018",
            "2018-2019",
            "2019-2020"});
            this.SYcb.Location = new System.Drawing.Point(8, 30);
            this.SYcb.Margin = new System.Windows.Forms.Padding(4);
            this.SYcb.Name = "SYcb";
            this.SYcb.Size = new System.Drawing.Size(160, 24);
            this.SYcb.TabIndex = 0;
            // 
            // CrystalReportbtn
            // 
            this.CrystalReportbtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CrystalReportbtn.Image = global::ReportCardGenerator.Properties.Resources.report;
            this.CrystalReportbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CrystalReportbtn.Location = new System.Drawing.Point(780, 245);
            this.CrystalReportbtn.Margin = new System.Windows.Forms.Padding(4);
            this.CrystalReportbtn.Name = "CrystalReportbtn";
            this.CrystalReportbtn.Size = new System.Drawing.Size(128, 28);
            this.CrystalReportbtn.TabIndex = 16;
            this.CrystalReportbtn.Text = "Show Report";
            this.CrystalReportbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CrystalReportbtn.UseVisualStyleBackColor = false;
            this.CrystalReportbtn.Click += new System.EventHandler(this.CrystalReportbtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Image = global::ReportCardGenerator.Properties.Resources.open;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(15, 245);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 28);
            this.button1.TabIndex = 15;
            this.button1.Text = "Open";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Add_grade_btn
            // 
            this.Add_grade_btn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Add_grade_btn.Image = global::ReportCardGenerator.Properties.Resources.gradebook;
            this.Add_grade_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add_grade_btn.Location = new System.Drawing.Point(274, 245);
            this.Add_grade_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Add_grade_btn.Name = "Add_grade_btn";
            this.Add_grade_btn.Size = new System.Drawing.Size(111, 28);
            this.Add_grade_btn.TabIndex = 10;
            this.Add_grade_btn.Text = "Mastersheet";
            this.Add_grade_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Add_grade_btn.UseVisualStyleBackColor = false;
            this.Add_grade_btn.Click += new System.EventHandler(this.Add_grade_btn_Click);
            // 
            // Add_hoom_btn
            // 
            this.Add_hoom_btn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Add_hoom_btn.Image = global::ReportCardGenerator.Properties.Resources.homeroom;
            this.Add_hoom_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add_hoom_btn.Location = new System.Drawing.Point(393, 245);
            this.Add_hoom_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Add_hoom_btn.Name = "Add_hoom_btn";
            this.Add_hoom_btn.Size = new System.Drawing.Size(75, 28);
            this.Add_hoom_btn.TabIndex = 9;
            this.Add_hoom_btn.Text = "ESLRs";
            this.Add_hoom_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Add_hoom_btn.UseVisualStyleBackColor = false;
            this.Add_hoom_btn.Click += new System.EventHandler(this.Add_hoom_btn_Click);
            // 
            // Del_btn
            // 
            this.Del_btn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Del_btn.Image = global::ReportCardGenerator.Properties.Resources.cancel;
            this.Del_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Del_btn.Location = new System.Drawing.Point(102, 245);
            this.Del_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Del_btn.Name = "Del_btn";
            this.Del_btn.Size = new System.Drawing.Size(87, 28);
            this.Del_btn.TabIndex = 6;
            this.Del_btn.Text = "Delete";
            this.Del_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Del_btn.UseVisualStyleBackColor = false;
            this.Del_btn.Click += new System.EventHandler(this.Del_btn_Click);
            // 
            // addAttendBtn
            // 
            this.addAttendBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.addAttendBtn.Image = ((System.Drawing.Image)(resources.GetObject("addAttendBtn.Image")));
            this.addAttendBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addAttendBtn.Location = new System.Drawing.Point(476, 245);
            this.addAttendBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addAttendBtn.Name = "addAttendBtn";
            this.addAttendBtn.Size = new System.Drawing.Size(103, 28);
            this.addAttendBtn.TabIndex = 18;
            this.addAttendBtn.Text = "Attendance";
            this.addAttendBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addAttendBtn.UseVisualStyleBackColor = false;
            this.addAttendBtn.Click += new System.EventHandler(this.addAttendBtn_Click);
            // 
            // addCommentBtn
            // 
            this.addCommentBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.addCommentBtn.Image = ((System.Drawing.Image)(resources.GetObject("addCommentBtn.Image")));
            this.addCommentBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addCommentBtn.Location = new System.Drawing.Point(587, 245);
            this.addCommentBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addCommentBtn.Name = "addCommentBtn";
            this.addCommentBtn.Size = new System.Drawing.Size(91, 28);
            this.addCommentBtn.TabIndex = 19;
            this.addCommentBtn.Text = "Comment";
            this.addCommentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addCommentBtn.UseVisualStyleBackColor = false;
            this.addCommentBtn.Click += new System.EventHandler(this.addCommentBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 288);
            this.ControlBox = false;
            this.Controls.Add(this.addCommentBtn);
            this.Controls.Add(this.addAttendBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CrystalReportbtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StudGridView);
            this.Controls.Add(this.Add_grade_btn);
            this.Controls.Add(this.Add_hoom_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Del_btn);
            this.Controls.Add(this.GrabeBookList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportCardGenerator";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ListBox GrabeBookList;
        private System.Windows.Forms.Button Del_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Add_hoom_btn;
        private System.Windows.Forms.Button Add_grade_btn;
        private System.Windows.Forms.DataGridView StudGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CrystalReportbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox T3Tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox T2Tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox T1Tb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox SYcb;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setSchoolDaysToolStripMenuItem;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button addAttendBtn;
        private System.Windows.Forms.Button addCommentBtn;

    }
}

