namespace KaySub003
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dept_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dept_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dept_names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dept_name_eng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dept_seq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dept_upp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dept_sdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dept_edate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dept_use = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.key1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panData = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.ct_dept_name_eng = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ct_dept_use = new System.Windows.Forms.ComboBox();
            this.ct_dept_edate = new System.Windows.Forms.MaskedTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ct_dept_sdate = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ct_dept_names = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ct_dept_name = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ct_dept_code = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ct_dept_upp = new System.Windows.Forms.TextBox();
            this.ct_dept_seq = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.qt_dept_code = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.qt_dept_use = new System.Windows.Forms.ComboBox();
            this.label34 = new System.Windows.Forms.Label();
            this.qt_dept_name = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panData.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1098, 637);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 270F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panData, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1092, 591);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dept_code,
            this.dept_name,
            this.dept_names,
            this.dept_name_eng,
            this.dept_seq,
            this.dept_upp,
            this.dept_sdate,
            this.dept_edate,
            this.dept_use,
            this.status,
            this.key1});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(816, 585);
            this.dataGridView1.TabIndex = 0;
            // 
            // dept_code
            // 
            this.dept_code.DataPropertyName = "dept_code";
            this.dept_code.HeaderText = "부서코드";
            this.dept_code.Name = "dept_code";
            this.dept_code.ReadOnly = true;
            this.dept_code.Width = 78;
            // 
            // dept_name
            // 
            this.dept_name.DataPropertyName = "dept_name";
            this.dept_name.HeaderText = "부서명칭(원형)";
            this.dept_name.Name = "dept_name";
            this.dept_name.ReadOnly = true;
            this.dept_name.Width = 112;
            // 
            // dept_names
            // 
            this.dept_names.DataPropertyName = "dept_names";
            this.dept_names.HeaderText = "부서명칭(축약)";
            this.dept_names.Name = "dept_names";
            this.dept_names.ReadOnly = true;
            this.dept_names.Width = 112;
            // 
            // dept_name_eng
            // 
            this.dept_name_eng.DataPropertyName = "dept_name_eng";
            this.dept_name_eng.HeaderText = "영문부서명";
            this.dept_name_eng.Name = "dept_name_eng";
            this.dept_name_eng.Width = 90;
            // 
            // dept_seq
            // 
            this.dept_seq.DataPropertyName = "dept_seq";
            this.dept_seq.HeaderText = "부서seq";
            this.dept_seq.Name = "dept_seq";
            this.dept_seq.ReadOnly = true;
            this.dept_seq.Width = 75;
            // 
            // dept_upp
            // 
            this.dept_upp.DataPropertyName = "dept_upp";
            this.dept_upp.HeaderText = "상위부서코드";
            this.dept_upp.Name = "dept_upp";
            this.dept_upp.ReadOnly = true;
            this.dept_upp.Width = 102;
            // 
            // dept_sdate
            // 
            this.dept_sdate.DataPropertyName = "dept_sdate";
            this.dept_sdate.HeaderText = "생성일자";
            this.dept_sdate.Name = "dept_sdate";
            this.dept_sdate.ReadOnly = true;
            this.dept_sdate.Width = 78;
            // 
            // dept_edate
            // 
            this.dept_edate.DataPropertyName = "dept_edate";
            this.dept_edate.HeaderText = "폐기일자";
            this.dept_edate.Name = "dept_edate";
            this.dept_edate.ReadOnly = true;
            this.dept_edate.Width = 78;
            // 
            // dept_use
            // 
            this.dept_use.DataPropertyName = "dept_use";
            this.dept_use.HeaderText = "사용여부";
            this.dept_use.Name = "dept_use";
            this.dept_use.ReadOnly = true;
            this.dept_use.Width = 78;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "상태";
            this.status.Name = "status";
            this.status.Visible = false;
            this.status.Width = 54;
            // 
            // key1
            // 
            this.key1.DataPropertyName = "key1";
            this.key1.HeaderText = "key1";
            this.key1.Name = "key1";
            this.key1.Visible = false;
            this.key1.Width = 56;
            // 
            // panData
            // 
            this.panData.Controls.Add(this.label8);
            this.panData.Controls.Add(this.ct_dept_name_eng);
            this.panData.Controls.Add(this.label3);
            this.panData.Controls.Add(this.ct_dept_use);
            this.panData.Controls.Add(this.ct_dept_edate);
            this.panData.Controls.Add(this.panel4);
            this.panData.Controls.Add(this.ct_dept_sdate);
            this.panData.Controls.Add(this.label4);
            this.panData.Controls.Add(this.label5);
            this.panData.Controls.Add(this.label6);
            this.panData.Controls.Add(this.label11);
            this.panData.Controls.Add(this.ct_dept_names);
            this.panData.Controls.Add(this.label7);
            this.panData.Controls.Add(this.ct_dept_name);
            this.panData.Controls.Add(this.label10);
            this.panData.Controls.Add(this.ct_dept_code);
            this.panData.Controls.Add(this.label12);
            this.panData.Controls.Add(this.ct_dept_upp);
            this.panData.Controls.Add(this.ct_dept_seq);
            this.panData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panData.Location = new System.Drawing.Point(825, 3);
            this.panData.Name = "panData";
            this.panData.Size = new System.Drawing.Size(264, 585);
            this.panData.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 92;
            this.label8.Text = "영문부서명칭";
            // 
            // ct_dept_name_eng
            // 
            this.ct_dept_name_eng.Location = new System.Drawing.Point(99, 75);
            this.ct_dept_name_eng.MaxLength = 30;
            this.ct_dept_name_eng.Name = "ct_dept_name_eng";
            this.ct_dept_name_eng.Size = new System.Drawing.Size(152, 21);
            this.ct_dept_name_eng.TabIndex = 91;
            this.ct_dept_name_eng.Tag = "dept_names";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 90;
            this.label3.Text = "사용여부";
            // 
            // ct_dept_use
            // 
            this.ct_dept_use.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ct_dept_use.FormattingEnabled = true;
            this.ct_dept_use.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.ct_dept_use.Location = new System.Drawing.Point(99, 147);
            this.ct_dept_use.Name = "ct_dept_use";
            this.ct_dept_use.Size = new System.Drawing.Size(152, 20);
            this.ct_dept_use.TabIndex = 6;
            this.ct_dept_use.Tag = "dept_use";
            // 
            // ct_dept_edate
            // 
            this.ct_dept_edate.Location = new System.Drawing.Point(99, 194);
            this.ct_dept_edate.Mask = "0000-00-00";
            this.ct_dept_edate.Name = "ct_dept_edate";
            this.ct_dept_edate.ReadOnly = true;
            this.ct_dept_edate.Size = new System.Drawing.Size(152, 21);
            this.ct_dept_edate.TabIndex = 8;
            this.ct_dept_edate.Tag = "dept_edate";
            this.ct_dept_edate.ValidatingType = typeof(System.DateTime);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 584);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(264, 1);
            this.panel4.TabIndex = 44;
            // 
            // ct_dept_sdate
            // 
            this.ct_dept_sdate.Location = new System.Drawing.Point(99, 170);
            this.ct_dept_sdate.Mask = "0000-00-00";
            this.ct_dept_sdate.Name = "ct_dept_sdate";
            this.ct_dept_sdate.Size = new System.Drawing.Size(152, 21);
            this.ct_dept_sdate.TabIndex = 7;
            this.ct_dept_sdate.Tag = "dept_sdate";
            this.ct_dept_sdate.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 28;
            this.label4.Text = "부서코드";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 12);
            this.label5.TabIndex = 29;
            this.label5.Text = "부서seq";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 30;
            this.label6.Text = "상위부서코드";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 12);
            this.label11.TabIndex = 40;
            this.label11.Text = "부서명칭(축약)";
            // 
            // ct_dept_names
            // 
            this.ct_dept_names.Location = new System.Drawing.Point(99, 51);
            this.ct_dept_names.MaxLength = 30;
            this.ct_dept_names.Name = "ct_dept_names";
            this.ct_dept_names.Size = new System.Drawing.Size(152, 21);
            this.ct_dept_names.TabIndex = 3;
            this.ct_dept_names.Tag = "dept_names";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 12);
            this.label7.TabIndex = 31;
            this.label7.Text = "부서명칭(원형)";
            // 
            // ct_dept_name
            // 
            this.ct_dept_name.Location = new System.Drawing.Point(99, 27);
            this.ct_dept_name.MaxLength = 50;
            this.ct_dept_name.Name = "ct_dept_name";
            this.ct_dept_name.Size = new System.Drawing.Size(152, 21);
            this.ct_dept_name.TabIndex = 2;
            this.ct_dept_name.Tag = "dept_name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 30;
            this.label10.Text = "생성일자";
            // 
            // ct_dept_code
            // 
            this.ct_dept_code.Location = new System.Drawing.Point(99, 3);
            this.ct_dept_code.MaxLength = 3;
            this.ct_dept_code.Name = "ct_dept_code";
            this.ct_dept_code.Size = new System.Drawing.Size(152, 21);
            this.ct_dept_code.TabIndex = 1;
            this.ct_dept_code.Tag = "dept_code";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 197);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 30;
            this.label12.Text = "폐기일자";
            // 
            // ct_dept_upp
            // 
            this.ct_dept_upp.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ct_dept_upp.Location = new System.Drawing.Point(99, 123);
            this.ct_dept_upp.MaxLength = 4;
            this.ct_dept_upp.Name = "ct_dept_upp";
            this.ct_dept_upp.Size = new System.Drawing.Size(152, 21);
            this.ct_dept_upp.TabIndex = 5;
            this.ct_dept_upp.Tag = "dept_upp";
            // 
            // ct_dept_seq
            // 
            this.ct_dept_seq.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ct_dept_seq.Location = new System.Drawing.Point(99, 99);
            this.ct_dept_seq.MaxLength = 4;
            this.ct_dept_seq.Name = "ct_dept_seq";
            this.ct_dept_seq.Size = new System.Drawing.Size(152, 21);
            this.ct_dept_seq.TabIndex = 4;
            this.ct_dept_seq.Tag = "dept_seq";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.qt_dept_code);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.qt_dept_use);
            this.panel3.Controls.Add(this.label34);
            this.panel3.Controls.Add(this.qt_dept_name);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1092, 34);
            this.panel3.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 33);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1092, 1);
            this.panel5.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 59;
            this.label1.Text = "부서코드";
            // 
            // qt_dept_code
            // 
            this.qt_dept_code.Location = new System.Drawing.Point(62, 2);
            this.qt_dept_code.Name = "qt_dept_code";
            this.qt_dept_code.Size = new System.Drawing.Size(100, 21);
            this.qt_dept_code.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 53;
            this.label2.Text = "사용여부";
            // 
            // qt_dept_use
            // 
            this.qt_dept_use.FormattingEnabled = true;
            this.qt_dept_use.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.qt_dept_use.Location = new System.Drawing.Point(438, 2);
            this.qt_dept_use.Name = "qt_dept_use";
            this.qt_dept_use.Size = new System.Drawing.Size(100, 20);
            this.qt_dept_use.TabIndex = 56;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(168, 6);
            this.label34.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(99, 12);
            this.label34.TabIndex = 55;
            this.label34.Text = "부서코드명(원형)";
            // 
            // qt_dept_name
            // 
            this.qt_dept_name.Location = new System.Drawing.Point(273, 2);
            this.qt_dept_name.Name = "qt_dept_name";
            this.qt_dept_name.Size = new System.Drawing.Size(100, 21);
            this.qt_dept_name.TabIndex = 58;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1098, 637);
            this.Tag = "UCSub003";
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panData.ResumeLayout(false);
            this.panData.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ct_dept_use;
        private System.Windows.Forms.MaskedTextBox ct_dept_edate;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.MaskedTextBox ct_dept_sdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ct_dept_names;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ct_dept_name;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ct_dept_code;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ct_dept_upp;
        private System.Windows.Forms.TextBox ct_dept_seq;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox qt_dept_code;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox qt_dept_use;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox qt_dept_name;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ct_dept_name_eng;
        private System.Windows.Forms.DataGridViewTextBoxColumn dept_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn dept_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dept_names;
        private System.Windows.Forms.DataGridViewTextBoxColumn dept_name_eng;
        private System.Windows.Forms.DataGridViewTextBoxColumn dept_seq;
        private System.Windows.Forms.DataGridViewTextBoxColumn dept_upp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dept_sdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dept_edate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dept_use;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn key1;
    }
}
