﻿namespace WindowsFormsApplication1.View
{
    partial class thongkeview
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl5 = new MetroFramework.Controls.MetroTabControl();
            this.tabPage16 = new MetroFramework.Controls.MetroTabPage();
            this.pnnhanvienthem = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.button35 = new MetroFramework.Controls.MetroButton();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.lbngaysinh = new System.Windows.Forms.Label();
            this.lbrematkhau = new System.Windows.Forms.Label();
            this.tabPage17 = new MetroFramework.Controls.MetroTabPage();
            this.pndanhsachnv = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.thongkedoanhthu_viewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.thongkenxt_viewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabControl5.SuspendLayout();
            this.tabPage16.SuspendLayout();
            this.pnnhanvienthem.SuspendLayout();
            this.tabPage17.SuspendLayout();
            this.pndanhsachnv.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl5
            // 
            this.tabControl5.Controls.Add(this.tabPage16);
            this.tabControl5.Controls.Add(this.tabPage17);
            this.tabControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl5.Location = new System.Drawing.Point(0, 0);
            this.tabControl5.Name = "tabControl5";
            this.tabControl5.SelectedIndex = 1;
            this.tabControl5.Size = new System.Drawing.Size(783, 512);
            this.tabControl5.TabIndex = 16;
            // 
            // tabPage16
            // 
            this.tabPage16.BackColor = System.Drawing.Color.Transparent;
            this.tabPage16.Controls.Add(this.pnnhanvienthem);
            this.tabPage16.HorizontalScrollbarBarColor = true;
            this.tabPage16.Location = new System.Drawing.Point(4, 35);
            this.tabPage16.Name = "tabPage16";
            this.tabPage16.Size = new System.Drawing.Size(775, 473);
            this.tabPage16.TabIndex = 0;
            this.tabPage16.Text = "Thống kê Doanh thu";
            this.tabPage16.VerticalScrollbarBarColor = true;
            // 
            // pnnhanvienthem
            // 
            this.pnnhanvienthem.Controls.Add(this.thongkedoanhthu_viewer);
            this.pnnhanvienthem.Controls.Add(this.dateTimePicker2);
            this.pnnhanvienthem.Controls.Add(this.label8);
            this.pnnhanvienthem.Controls.Add(this.button35);
            this.pnnhanvienthem.Controls.Add(this.dateTimePicker5);
            this.pnnhanvienthem.Controls.Add(this.lbngaysinh);
            this.pnnhanvienthem.Controls.Add(this.lbrematkhau);
            this.pnnhanvienthem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnnhanvienthem.Location = new System.Drawing.Point(0, 0);
            this.pnnhanvienthem.Name = "pnnhanvienthem";
            this.pnnhanvienthem.Size = new System.Drawing.Size(775, 473);
            this.pnnhanvienthem.TabIndex = 15;
            this.pnnhanvienthem.Paint += new System.Windows.Forms.PaintEventHandler(this.pnnhanvienthem_Paint);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(349, 49);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(252, 20);
            this.dateTimePicker2.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(347, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Ngày kết thúc";
            // 
            // button35
            // 
            this.button35.Location = new System.Drawing.Point(624, 46);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(125, 23);
            this.button35.TabIndex = 15;
            this.button35.Text = "Thống kê";
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker5.Location = new System.Drawing.Point(53, 46);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.Size = new System.Drawing.Size(252, 20);
            this.dateTimePicker5.TabIndex = 7;
            // 
            // lbngaysinh
            // 
            this.lbngaysinh.AutoSize = true;
            this.lbngaysinh.Location = new System.Drawing.Point(50, 33);
            this.lbngaysinh.Name = "lbngaysinh";
            this.lbngaysinh.Size = new System.Drawing.Size(72, 13);
            this.lbngaysinh.TabIndex = 12;
            this.lbngaysinh.Text = "Ngày bắt đầu";
            // 
            // lbrematkhau
            // 
            this.lbrematkhau.AutoSize = true;
            this.lbrematkhau.Location = new System.Drawing.Point(86, 188);
            this.lbrematkhau.Name = "lbrematkhau";
            this.lbrematkhau.Size = new System.Drawing.Size(0, 13);
            this.lbrematkhau.TabIndex = 7;
            // 
            // tabPage17
            // 
            this.tabPage17.BackColor = System.Drawing.Color.Transparent;
            this.tabPage17.Controls.Add(this.pndanhsachnv);
            this.tabPage17.HorizontalScrollbarBarColor = true;
            this.tabPage17.Location = new System.Drawing.Point(4, 35);
            this.tabPage17.Name = "tabPage17";
            this.tabPage17.Size = new System.Drawing.Size(775, 473);
            this.tabPage17.TabIndex = 4;
            this.tabPage17.Text = "Thống kê nhập-xuất-tồn";
            this.tabPage17.VerticalScrollbarBarColor = true;
            // 
            // pndanhsachnv
            // 
            this.pndanhsachnv.Controls.Add(this.thongkenxt_viewer);
            this.pndanhsachnv.Controls.Add(this.dateTimePicker1);
            this.pndanhsachnv.Controls.Add(this.label1);
            this.pndanhsachnv.Controls.Add(this.metroButton1);
            this.pndanhsachnv.Controls.Add(this.dateTimePicker3);
            this.pndanhsachnv.Controls.Add(this.label2);
            this.pndanhsachnv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pndanhsachnv.Location = new System.Drawing.Point(0, 0);
            this.pndanhsachnv.Name = "pndanhsachnv";
            this.pndanhsachnv.Size = new System.Drawing.Size(775, 473);
            this.pndanhsachnv.TabIndex = 33;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(322, 31);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(252, 20);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ngày kết thúc";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(597, 28);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(125, 23);
            this.metroButton1.TabIndex = 20;
            this.metroButton1.Text = "Thống kê";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(26, 28);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(252, 20);
            this.dateTimePicker3.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ngày bắt đầu";
            // 
            // thongkedoanhthu_viewer
            // 
            this.thongkedoanhthu_viewer.Location = new System.Drawing.Point(30, 93);
            this.thongkedoanhthu_viewer.Name = "thongkedoanhthu_viewer";
            this.thongkedoanhthu_viewer.Size = new System.Drawing.Size(710, 340);
            this.thongkedoanhthu_viewer.TabIndex = 18;
            // 
            // thongkenxt_viewer
            // 
            this.thongkenxt_viewer.Location = new System.Drawing.Point(32, 66);
            this.thongkenxt_viewer.Name = "thongkenxt_viewer";
            this.thongkenxt_viewer.Size = new System.Drawing.Size(710, 340);
            this.thongkenxt_viewer.TabIndex = 23;
            // 
            // thongkeview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.tabControl5);
            this.Name = "thongkeview";
            this.Size = new System.Drawing.Size(783, 512);
            this.tabControl5.ResumeLayout(false);
            this.tabPage16.ResumeLayout(false);
            this.pnnhanvienthem.ResumeLayout(false);
            this.pnnhanvienthem.PerformLayout();
            this.tabPage17.ResumeLayout(false);
            this.pndanhsachnv.ResumeLayout(false);
            this.pndanhsachnv.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public MetroFramework.Controls.MetroTabControl tabControl5;
        private MetroFramework.Controls.MetroTabPage tabPage16;
        private System.Windows.Forms.Panel pnnhanvienthem;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label8;
        private MetroFramework.Controls.MetroButton button35;
        private System.Windows.Forms.DateTimePicker dateTimePicker5;
        private System.Windows.Forms.Label lbngaysinh;
        private System.Windows.Forms.Label lbrematkhau;
        private MetroFramework.Controls.MetroTabPage tabPage17;
        private System.Windows.Forms.Panel pndanhsachnv;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer thongkedoanhthu_viewer;
        private Microsoft.Reporting.WinForms.ReportViewer thongkenxt_viewer;
    }
}
