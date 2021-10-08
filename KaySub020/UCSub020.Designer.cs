
namespace KaySub020
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panData = new System.Windows.Forms.Panel();
            this.qt_tor_name = new System.Windows.Forms.TextBox();
            this.qt_evalm_type = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.qt_evalm_year = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.qt_evalm_no = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.qt_evalm_tor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.evalm_year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evalm_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evalm_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evalm_period = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evalm_tor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tor_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evalm_dept_tor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evalm_pos_tor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evalm_dut_tor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tee_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tee_fincount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tee_yecount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evalm_findate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eval_edate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panData, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1098, 637);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panData
            // 
            this.panData.Controls.Add(this.qt_tor_name);
            this.panData.Controls.Add(this.qt_evalm_type);
            this.panData.Controls.Add(this.label12);
            this.panData.Controls.Add(this.qt_evalm_year);
            this.panData.Controls.Add(this.label10);
            this.panData.Controls.Add(this.qt_evalm_no);
            this.panData.Controls.Add(this.label7);
            this.panData.Controls.Add(this.qt_evalm_tor);
            this.panData.Controls.Add(this.label1);
            this.panData.Controls.Add(this.panel3);
            this.panData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panData.Location = new System.Drawing.Point(3, 3);
            this.panData.Name = "panData";
            this.panData.Size = new System.Drawing.Size(1092, 34);
            this.panData.TabIndex = 2;
            // 
            // qt_tor_name
            // 
            this.qt_tor_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.qt_tor_name.Location = new System.Drawing.Point(542, 7);
            this.qt_tor_name.Name = "qt_tor_name";
            this.qt_tor_name.Size = new System.Drawing.Size(56, 21);
            this.qt_tor_name.TabIndex = 5;
            // 
            // qt_evalm_type
            // 
            this.qt_evalm_type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.qt_evalm_type.FormattingEnabled = true;
            this.qt_evalm_type.Location = new System.Drawing.Point(391, 7);
            this.qt_evalm_type.Name = "qt_evalm_type";
            this.qt_evalm_type.Size = new System.Drawing.Size(100, 20);
            this.qt_evalm_type.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(332, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 1;
            this.label12.Text = "평가유형";
            // 
            // qt_evalm_year
            // 
            this.qt_evalm_year.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.qt_evalm_year.Location = new System.Drawing.Point(61, 7);
            this.qt_evalm_year.Name = "qt_evalm_year";
            this.qt_evalm_year.Size = new System.Drawing.Size(103, 21);
            this.qt_evalm_year.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(497, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 1;
            this.label10.Text = "평가자";
            // 
            // qt_evalm_no
            // 
            this.qt_evalm_no.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.qt_evalm_no.Location = new System.Drawing.Point(226, 7);
            this.qt_evalm_no.Name = "qt_evalm_no";
            this.qt_evalm_no.Size = new System.Drawing.Size(102, 21);
            this.qt_evalm_no.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(171, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "평가차수";
            // 
            // qt_evalm_tor
            // 
            this.qt_evalm_tor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.qt_evalm_tor.Location = new System.Drawing.Point(599, 7);
            this.qt_evalm_tor.Name = "qt_evalm_tor";
            this.qt_evalm_tor.ReadOnly = true;
            this.qt_evalm_tor.Size = new System.Drawing.Size(57, 21);
            this.qt_evalm_tor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "평가년도";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1092, 1);
            this.panel3.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.evalm_year,
            this.evalm_no,
            this.evalm_type,
            this.evalm_period,
            this.evalm_tor,
            this.tor_name,
            this.evalm_dept_tor,
            this.evalm_pos_tor,
            this.evalm_dut_tor,
            this.tee_count,
            this.tee_fincount,
            this.tee_yecount,
            this.evalm_findate,
            this.eval_edate});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 43);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1092, 591);
            this.dataGridView1.TabIndex = 1;
            // 
            // evalm_year
            // 
            this.evalm_year.DataPropertyName = "evalm_year";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.evalm_year.DefaultCellStyle = dataGridViewCellStyle1;
            this.evalm_year.HeaderText = "평가년도";
            this.evalm_year.Name = "evalm_year";
            this.evalm_year.Width = 80;
            // 
            // evalm_no
            // 
            this.evalm_no.DataPropertyName = "evalm_no";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.evalm_no.DefaultCellStyle = dataGridViewCellStyle2;
            this.evalm_no.HeaderText = "평가차수";
            this.evalm_no.Name = "evalm_no";
            this.evalm_no.Width = 80;
            // 
            // evalm_type
            // 
            this.evalm_type.DataPropertyName = "evalm_type";
            this.evalm_type.HeaderText = "평가표 유형";
            this.evalm_type.Name = "evalm_type";
            // 
            // evalm_period
            // 
            this.evalm_period.DataPropertyName = "evalm_period";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.evalm_period.DefaultCellStyle = dataGridViewCellStyle3;
            this.evalm_period.HeaderText = "평가대상기간";
            this.evalm_period.Name = "evalm_period";
            this.evalm_period.Width = 130;
            // 
            // evalm_tor
            // 
            this.evalm_tor.DataPropertyName = "evalm_tor";
            this.evalm_tor.HeaderText = "사번(평가자)";
            this.evalm_tor.Name = "evalm_tor";
            this.evalm_tor.Visible = false;
            // 
            // tor_name
            // 
            this.tor_name.DataPropertyName = "tor_name";
            this.tor_name.HeaderText = "이름(평가자)";
            this.tor_name.Name = "tor_name";
            this.tor_name.Width = 120;
            // 
            // evalm_dept_tor
            // 
            this.evalm_dept_tor.DataPropertyName = "evalm_dept_tor";
            this.evalm_dept_tor.HeaderText = "소속(평가자)";
            this.evalm_dept_tor.Name = "evalm_dept_tor";
            // 
            // evalm_pos_tor
            // 
            this.evalm_pos_tor.DataPropertyName = "evalm_pos_tor";
            this.evalm_pos_tor.HeaderText = "직급(평가자)";
            this.evalm_pos_tor.Name = "evalm_pos_tor";
            // 
            // evalm_dut_tor
            // 
            this.evalm_dut_tor.DataPropertyName = "evalm_dut_tor";
            this.evalm_dut_tor.HeaderText = "직책(평가자)";
            this.evalm_dut_tor.Name = "evalm_dut_tor";
            // 
            // tee_count
            // 
            this.tee_count.DataPropertyName = "tee_count";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tee_count.DefaultCellStyle = dataGridViewCellStyle4;
            this.tee_count.HeaderText = "평가인원";
            this.tee_count.Name = "tee_count";
            // 
            // tee_fincount
            // 
            this.tee_fincount.DataPropertyName = "tee_fincount";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tee_fincount.DefaultCellStyle = dataGridViewCellStyle5;
            this.tee_fincount.HeaderText = "평가완료인원";
            this.tee_fincount.Name = "tee_fincount";
            // 
            // tee_yecount
            // 
            this.tee_yecount.DataPropertyName = "tee_yecount";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tee_yecount.DefaultCellStyle = dataGridViewCellStyle6;
            this.tee_yecount.HeaderText = "남은인원";
            this.tee_yecount.Name = "tee_yecount";
            // 
            // evalm_findate
            // 
            this.evalm_findate.DataPropertyName = "evalm_findate";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.evalm_findate.DefaultCellStyle = dataGridViewCellStyle7;
            this.evalm_findate.HeaderText = "마지막평가일자";
            this.evalm_findate.Name = "evalm_findate";
            this.evalm_findate.Width = 130;
            // 
            // eval_edate
            // 
            this.eval_edate.DataPropertyName = "eval_edate";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.eval_edate.DefaultCellStyle = dataGridViewCellStyle8;
            this.eval_edate.HeaderText = "종료일자";
            this.eval_edate.Name = "eval_edate";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1098, 637);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panData.ResumeLayout(false);
            this.panData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panData;
        private System.Windows.Forms.TextBox qt_tor_name;
        private System.Windows.Forms.ComboBox qt_evalm_type;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox qt_evalm_year;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox qt_evalm_no;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox qt_evalm_tor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn evalm_year;
        private System.Windows.Forms.DataGridViewTextBoxColumn evalm_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn evalm_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn evalm_period;
        private System.Windows.Forms.DataGridViewTextBoxColumn evalm_tor;
        private System.Windows.Forms.DataGridViewTextBoxColumn tor_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn evalm_dept_tor;
        private System.Windows.Forms.DataGridViewTextBoxColumn evalm_pos_tor;
        private System.Windows.Forms.DataGridViewTextBoxColumn evalm_dut_tor;
        private System.Windows.Forms.DataGridViewTextBoxColumn tee_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn tee_fincount;
        private System.Windows.Forms.DataGridViewTextBoxColumn tee_yecount;
        private System.Windows.Forms.DataGridViewTextBoxColumn evalm_findate;
        private System.Windows.Forms.DataGridViewTextBoxColumn eval_edate;
    }
}
