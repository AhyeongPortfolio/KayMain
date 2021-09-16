namespace KaySub030
{
    partial class UserControl1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Notic = new System.Windows.Forms.Label();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radiMonth = new System.Windows.Forms.RadioButton();
            this.radiYear = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.qt_cal_date2 = new System.Windows.Forms.DateTimePicker();
            this.panel5 = new System.Windows.Forms.Panel();
            this.qt_cal_date1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1000, 610);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel5.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.cartesianChart1, 1, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(994, 564);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(325, 518);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.Notic);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(325, 34);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 33);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(325, 1);
            this.panel4.TabIndex = 45;
            // 
            // Notic
            // 
            this.Notic.AutoSize = true;
            this.Notic.Location = new System.Drawing.Point(2, 8);
            this.Notic.Name = "Notic";
            this.Notic.Size = new System.Drawing.Size(121, 12);
            this.Notic.TabIndex = 2;
            this.Notic.Text = "기간별 사직인원 추이";
            this.Notic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartesianChart1.Location = new System.Drawing.Point(334, 43);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(657, 518);
            this.cartesianChart1.TabIndex = 3;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radiMonth);
            this.panel2.Controls.Add(this.radiYear);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.qt_cal_date2);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.qt_cal_date1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(994, 34);
            this.panel2.TabIndex = 1;
            // 
            // radiMonth
            // 
            this.radiMonth.AutoSize = true;
            this.radiMonth.Checked = true;
            this.radiMonth.Dock = System.Windows.Forms.DockStyle.Right;
            this.radiMonth.Location = new System.Drawing.Point(888, 0);
            this.radiMonth.Name = "radiMonth";
            this.radiMonth.Size = new System.Drawing.Size(47, 33);
            this.radiMonth.TabIndex = 49;
            this.radiMonth.TabStop = true;
            this.radiMonth.Text = "월별";
            this.radiMonth.UseVisualStyleBackColor = true;
            // 
            // radiYear
            // 
            this.radiYear.AutoSize = true;
            this.radiYear.Dock = System.Windows.Forms.DockStyle.Right;
            this.radiYear.Location = new System.Drawing.Point(935, 0);
            this.radiYear.Name = "radiYear";
            this.radiYear.Size = new System.Drawing.Size(59, 33);
            this.radiYear.TabIndex = 48;
            this.radiYear.Text = "년도별";
            this.radiYear.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 47;
            this.label2.Text = "-";
            // 
            // qt_cal_date2
            // 
            this.qt_cal_date2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.qt_cal_date2.Location = new System.Drawing.Point(184, 2);
            this.qt_cal_date2.Name = "qt_cal_date2";
            this.qt_cal_date2.Size = new System.Drawing.Size(100, 21);
            this.qt_cal_date2.TabIndex = 46;
            this.qt_cal_date2.Value = new System.DateTime(2021, 8, 31, 0, 0, 0, 0);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 33);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(994, 1);
            this.panel5.TabIndex = 45;
            // 
            // qt_cal_date1
            // 
            this.qt_cal_date1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.qt_cal_date1.Location = new System.Drawing.Point(61, 2);
            this.qt_cal_date1.Name = "qt_cal_date1";
            this.qt_cal_date1.Size = new System.Drawing.Size(100, 21);
            this.qt_cal_date1.TabIndex = 1;
            this.qt_cal_date1.Value = new System.DateTime(2021, 8, 31, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "조회날짜";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1000, 610);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Notic;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radiMonth;
        private System.Windows.Forms.RadioButton radiYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker qt_cal_date2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DateTimePicker qt_cal_date1;
        private System.Windows.Forms.Label label1;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
    }
}
