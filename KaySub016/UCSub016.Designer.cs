
namespace KaySub016
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panData = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.qt_eval_sdate = new System.Windows.Forms.DateTimePicker();
            this.qt_eval_edate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ct_eval_year = new System.Windows.Forms.TextBox();
            this.ct_eval_no = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ct_eval_period = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.eval_year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eval_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eval_period = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eval_sdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eval_edate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ct_eval_sdate = new System.Windows.Forms.MaskedTextBox();
            this.ct_eval_edate = new System.Windows.Forms.MaskedTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1073, 637);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.Controls.Add(this.panData, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1067, 591);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panData
            // 
            this.panData.Controls.Add(this.ct_eval_edate);
            this.panData.Controls.Add(this.ct_eval_sdate);
            this.panData.Controls.Add(this.ct_eval_period);
            this.panData.Controls.Add(this.label7);
            this.panData.Controls.Add(this.ct_eval_no);
            this.panData.Controls.Add(this.ct_eval_year);
            this.panData.Controls.Add(this.label5);
            this.panData.Controls.Add(this.label6);
            this.panData.Controls.Add(this.label4);
            this.panData.Controls.Add(this.label3);
            this.panData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panData.Location = new System.Drawing.Point(643, 3);
            this.panData.Name = "panData";
            this.panData.Size = new System.Drawing.Size(421, 585);
            this.panData.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eval_year,
            this.eval_no,
            this.eval_period,
            this.eval_sdate,
            this.eval_edate,
            this.status});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(634, 585);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.qt_eval_edate);
            this.panel2.Controls.Add(this.qt_eval_sdate);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1067, 34);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1067, 1);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "평가기간";
            // 
            // qt_eval_sdate
            // 
            this.qt_eval_sdate.CustomFormat = "yyyy-MM-dd";
            this.qt_eval_sdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.qt_eval_sdate.Location = new System.Drawing.Point(61, 5);
            this.qt_eval_sdate.Name = "qt_eval_sdate";
            this.qt_eval_sdate.Size = new System.Drawing.Size(94, 21);
            this.qt_eval_sdate.TabIndex = 2;
            // 
            // qt_eval_edate
            // 
            this.qt_eval_edate.CustomFormat = "yyyy-MM-dd";
            this.qt_eval_edate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.qt_eval_edate.Location = new System.Drawing.Point(178, 5);
            this.qt_eval_edate.Name = "qt_eval_edate";
            this.qt_eval_edate.Size = new System.Drawing.Size(94, 21);
            this.qt_eval_edate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "평가년도";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "평가차수";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "평가가능기간";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "평가대상기간";
            // 
            // ct_eval_year
            // 
            this.ct_eval_year.Location = new System.Drawing.Point(95, 11);
            this.ct_eval_year.Name = "ct_eval_year";
            this.ct_eval_year.Size = new System.Drawing.Size(218, 21);
            this.ct_eval_year.TabIndex = 1;
            // 
            // ct_eval_no
            // 
            this.ct_eval_no.Location = new System.Drawing.Point(95, 44);
            this.ct_eval_no.Name = "ct_eval_no";
            this.ct_eval_no.Size = new System.Drawing.Size(218, 21);
            this.ct_eval_no.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(197, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "~";
            // 
            // ct_eval_period
            // 
            this.ct_eval_period.Location = new System.Drawing.Point(95, 78);
            this.ct_eval_period.Mask = "0000.00.00-0000.00.00";
            this.ct_eval_period.Name = "ct_eval_period";
            this.ct_eval_period.Size = new System.Drawing.Size(218, 21);
            this.ct_eval_period.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // eval_year
            // 
            this.eval_year.DataPropertyName = "eval_year";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.eval_year.DefaultCellStyle = dataGridViewCellStyle6;
            this.eval_year.HeaderText = "평가년도";
            this.eval_year.Name = "eval_year";
            this.eval_year.Width = 78;
            // 
            // eval_no
            // 
            this.eval_no.DataPropertyName = "eval_no";
            this.eval_no.HeaderText = "평가차수";
            this.eval_no.Name = "eval_no";
            this.eval_no.Width = 78;
            // 
            // eval_period
            // 
            this.eval_period.DataPropertyName = "eval_period";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.eval_period.DefaultCellStyle = dataGridViewCellStyle7;
            this.eval_period.HeaderText = "평가대상기간";
            this.eval_period.Name = "eval_period";
            this.eval_period.Width = 102;
            // 
            // eval_sdate
            // 
            this.eval_sdate.DataPropertyName = "eval_sdate";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.eval_sdate.DefaultCellStyle = dataGridViewCellStyle8;
            this.eval_sdate.HeaderText = "평가가능기간(시작일)";
            this.eval_sdate.Name = "eval_sdate";
            this.eval_sdate.Width = 148;
            // 
            // eval_edate
            // 
            this.eval_edate.DataPropertyName = "eval_edate";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.eval_edate.DefaultCellStyle = dataGridViewCellStyle9;
            this.eval_edate.HeaderText = "평가가능기간(종료일)";
            this.eval_edate.Name = "eval_edate";
            this.eval_edate.Width = 148;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "상태";
            this.status.Name = "status";
            this.status.Visible = false;
            this.status.Width = 54;
            // 
            // ct_eval_sdate
            // 
            this.ct_eval_sdate.Location = new System.Drawing.Point(95, 110);
            this.ct_eval_sdate.Mask = "0000-00-00";
            this.ct_eval_sdate.Name = "ct_eval_sdate";
            this.ct_eval_sdate.Size = new System.Drawing.Size(100, 21);
            this.ct_eval_sdate.TabIndex = 4;
            this.ct_eval_sdate.ValidatingType = typeof(System.DateTime);
            // 
            // ct_eval_edate
            // 
            this.ct_eval_edate.Location = new System.Drawing.Point(213, 110);
            this.ct_eval_edate.Mask = "0000-00-00";
            this.ct_eval_edate.Name = "ct_eval_edate";
            this.ct_eval_edate.Size = new System.Drawing.Size(100, 21);
            this.ct_eval_edate.TabIndex = 5;
            this.ct_eval_edate.ValidatingType = typeof(System.DateTime);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1073, 637);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panData.ResumeLayout(false);
            this.panData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker qt_eval_edate;
        private System.Windows.Forms.DateTimePicker qt_eval_sdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ct_eval_no;
        private System.Windows.Forms.TextBox ct_eval_year;
        private System.Windows.Forms.MaskedTextBox ct_eval_period;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eval_year;
        private System.Windows.Forms.DataGridViewTextBoxColumn eval_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn eval_period;
        private System.Windows.Forms.DataGridViewTextBoxColumn eval_sdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn eval_edate;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.MaskedTextBox ct_eval_edate;
        private System.Windows.Forms.MaskedTextBox ct_eval_sdate;
    }
}
