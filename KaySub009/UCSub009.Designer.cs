namespace KaySub009
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.car_yyyymm_tText = new System.Windows.Forms.MaskedTextBox();
            this.car_yyyymm_fText = new System.Windows.Forms.MaskedTextBox();
            this.car_reasonText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.car_deptText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.car_posText = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.car_regionText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.car_comText = new System.Windows.Forms.TextBox();
            this.car_empnoText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.RWUD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car_empno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car_com = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car_region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car_yyyymm_f = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car_yyyymm_t = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car_pos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car_dept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car_reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bas_empno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_dept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_pos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.empnoSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.nameSearch = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(908, 618);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(902, 572);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.dataGridView2, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(454, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 320F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(445, 566);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.car_yyyymm_tText);
            this.panel4.Controls.Add(this.car_yyyymm_fText);
            this.panel4.Controls.Add(this.car_reasonText);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.car_deptText);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.car_posText);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.car_regionText);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.car_comText);
            this.panel4.Controls.Add(this.car_empnoText);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 249);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(439, 314);
            this.panel4.TabIndex = 3;
            // 
            // car_yyyymm_tText
            // 
            this.car_yyyymm_tText.Location = new System.Drawing.Point(269, 54);
            this.car_yyyymm_tText.Mask = "0000-00";
            this.car_yyyymm_tText.Name = "car_yyyymm_tText";
            this.car_yyyymm_tText.Size = new System.Drawing.Size(100, 21);
            this.car_yyyymm_tText.TabIndex = 5;
            this.car_yyyymm_tText.ValidatingType = typeof(System.DateTime);
            // 
            // car_yyyymm_fText
            // 
            this.car_yyyymm_fText.Location = new System.Drawing.Point(92, 54);
            this.car_yyyymm_fText.Mask = "0000-00";
            this.car_yyyymm_fText.Name = "car_yyyymm_fText";
            this.car_yyyymm_fText.Size = new System.Drawing.Size(100, 21);
            this.car_yyyymm_fText.TabIndex = 4;
            this.car_yyyymm_fText.ValidatingType = typeof(System.DateTime);
            // 
            // car_reasonText
            // 
            this.car_reasonText.Location = new System.Drawing.Point(92, 126);
            this.car_reasonText.MaxLength = 30;
            this.car_reasonText.Name = "car_reasonText";
            this.car_reasonText.Size = new System.Drawing.Size(277, 21);
            this.car_reasonText.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 12);
            this.label8.TabIndex = 38;
            this.label8.Text = "퇴직/이직사유";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 313);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(439, 1);
            this.panel2.TabIndex = 0;
            // 
            // car_deptText
            // 
            this.car_deptText.Location = new System.Drawing.Point(92, 102);
            this.car_deptText.MaxLength = 30;
            this.car_deptText.Name = "car_deptText";
            this.car_deptText.Size = new System.Drawing.Size(277, 21);
            this.car_deptText.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 38;
            this.label6.Text = "담당부서";
            // 
            // car_posText
            // 
            this.car_posText.Location = new System.Drawing.Point(92, 78);
            this.car_posText.MaxLength = 20;
            this.car_posText.Name = "car_posText";
            this.car_posText.Size = new System.Drawing.Size(277, 21);
            this.car_posText.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 38;
            this.label11.Text = "최종직급";
            // 
            // car_regionText
            // 
            this.car_regionText.Location = new System.Drawing.Point(269, 30);
            this.car_regionText.MaxLength = 10;
            this.car_regionText.Name = "car_regionText";
            this.car_regionText.Size = new System.Drawing.Size(100, 21);
            this.car_regionText.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(222, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 36;
            this.label10.Text = "소재지";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(198, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 34;
            this.label9.Text = "근무종료월";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 30;
            this.label7.Text = "근무시작월";
            // 
            // car_comText
            // 
            this.car_comText.Location = new System.Drawing.Point(92, 30);
            this.car_comText.MaxLength = 30;
            this.car_comText.Name = "car_comText";
            this.car_comText.Size = new System.Drawing.Size(100, 21);
            this.car_comText.TabIndex = 2;
            // 
            // car_empnoText
            // 
            this.car_empnoText.Location = new System.Drawing.Point(92, 6);
            this.car_empnoText.MaxLength = 9;
            this.car_empnoText.Name = "car_empnoText";
            this.car_empnoText.Size = new System.Drawing.Size(100, 21);
            this.car_empnoText.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 25;
            this.label5.Text = "근무처명";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 24;
            this.label4.Text = "사원번호";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RWUD,
            this.car_empno,
            this.car_com,
            this.car_region,
            this.car_yyyymm_f,
            this.car_yyyymm_t,
            this.car_pos,
            this.car_dept,
            this.car_reason});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(439, 240);
            this.dataGridView2.TabIndex = 0;
            // 
            // RWUD
            // 
            this.RWUD.HeaderText = "상태";
            this.RWUD.Name = "RWUD";
            this.RWUD.Width = 54;
            // 
            // car_empno
            // 
            this.car_empno.DataPropertyName = "car_empno";
            this.car_empno.HeaderText = "사원번호";
            this.car_empno.Name = "car_empno";
            this.car_empno.ReadOnly = true;
            this.car_empno.Visible = false;
            this.car_empno.Width = 78;
            // 
            // car_com
            // 
            this.car_com.DataPropertyName = "car_com";
            this.car_com.HeaderText = "근무처명";
            this.car_com.Name = "car_com";
            this.car_com.ReadOnly = true;
            this.car_com.Width = 78;
            // 
            // car_region
            // 
            this.car_region.DataPropertyName = "car_region";
            this.car_region.HeaderText = "소재지";
            this.car_region.Name = "car_region";
            this.car_region.ReadOnly = true;
            this.car_region.Width = 66;
            // 
            // car_yyyymm_f
            // 
            this.car_yyyymm_f.DataPropertyName = "car_yyyymm_f";
            this.car_yyyymm_f.HeaderText = "근무시작일";
            this.car_yyyymm_f.Name = "car_yyyymm_f";
            this.car_yyyymm_f.ReadOnly = true;
            this.car_yyyymm_f.Width = 90;
            // 
            // car_yyyymm_t
            // 
            this.car_yyyymm_t.DataPropertyName = "car_yyyymm_t";
            this.car_yyyymm_t.HeaderText = "근무종료일";
            this.car_yyyymm_t.Name = "car_yyyymm_t";
            this.car_yyyymm_t.ReadOnly = true;
            this.car_yyyymm_t.Width = 90;
            // 
            // car_pos
            // 
            this.car_pos.DataPropertyName = "car_pos";
            this.car_pos.HeaderText = "최종직급";
            this.car_pos.Name = "car_pos";
            this.car_pos.ReadOnly = true;
            this.car_pos.Width = 78;
            // 
            // car_dept
            // 
            this.car_dept.DataPropertyName = "car_dept";
            this.car_dept.HeaderText = "담당부서";
            this.car_dept.Name = "car_dept";
            this.car_dept.ReadOnly = true;
            this.car_dept.Width = 78;
            // 
            // car_reason
            // 
            this.car_reason.DataPropertyName = "car_reason";
            this.car_reason.HeaderText = "퇴직/이직사유";
            this.car_reason.Name = "car_reason";
            this.car_reason.ReadOnly = true;
            this.car_reason.Width = 108;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bas_empno,
            this.bas_name,
            this.bas_dept,
            this.bas_pos});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(445, 566);
            this.dataGridView1.TabIndex = 1;
            // 
            // bas_empno
            // 
            this.bas_empno.DataPropertyName = "bas_empno";
            this.bas_empno.HeaderText = "사원번호";
            this.bas_empno.Name = "bas_empno";
            this.bas_empno.ReadOnly = true;
            this.bas_empno.Width = 78;
            // 
            // bas_name
            // 
            this.bas_name.DataPropertyName = "bas_name";
            this.bas_name.HeaderText = "성명";
            this.bas_name.Name = "bas_name";
            this.bas_name.ReadOnly = true;
            this.bas_name.Width = 54;
            // 
            // bas_dept
            // 
            this.bas_dept.DataPropertyName = "bas_dept";
            this.bas_dept.HeaderText = "부서";
            this.bas_dept.Name = "bas_dept";
            this.bas_dept.ReadOnly = true;
            this.bas_dept.Width = 54;
            // 
            // bas_pos
            // 
            this.bas_pos.DataPropertyName = "bas_pos";
            this.bas_pos.HeaderText = "직급";
            this.bas_pos.Name = "bas_pos";
            this.bas_pos.ReadOnly = true;
            this.bas_pos.Width = 54;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.empnoSearch);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.comboBox2);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.nameSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(902, 34);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 33);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(902, 1);
            this.panel5.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 51;
            this.label1.Text = "사원번호";
            // 
            // empnoSearch
            // 
            this.empnoSearch.Location = new System.Drawing.Point(62, 2);
            this.empnoSearch.Name = "empnoSearch";
            this.empnoSearch.Size = new System.Drawing.Size(100, 21);
            this.empnoSearch.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 45;
            this.label2.Text = "부서";
            this.label2.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(344, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 20);
            this.comboBox1.TabIndex = 48;
            this.comboBox1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 46;
            this.label3.Text = "직급";
            this.label3.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(485, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 20);
            this.comboBox2.TabIndex = 49;
            this.comboBox2.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(168, 6);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 47;
            this.label12.Text = "성명";
            // 
            // nameSearch
            // 
            this.nameSearch.Location = new System.Drawing.Point(203, 2);
            this.nameSearch.Name = "nameSearch";
            this.nameSearch.Size = new System.Drawing.Size(100, 21);
            this.nameSearch.TabIndex = 50;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(908, 618);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.MaskedTextBox car_yyyymm_tText;
        private System.Windows.Forms.MaskedTextBox car_yyyymm_fText;
        private System.Windows.Forms.TextBox car_reasonText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox car_deptText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox car_posText;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox car_regionText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox car_comText;
        private System.Windows.Forms.TextBox car_empnoText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn RWUD;
        private System.Windows.Forms.DataGridViewTextBoxColumn car_empno;
        private System.Windows.Forms.DataGridViewTextBoxColumn car_com;
        private System.Windows.Forms.DataGridViewTextBoxColumn car_region;
        private System.Windows.Forms.DataGridViewTextBoxColumn car_yyyymm_f;
        private System.Windows.Forms.DataGridViewTextBoxColumn car_yyyymm_t;
        private System.Windows.Forms.DataGridViewTextBoxColumn car_pos;
        private System.Windows.Forms.DataGridViewTextBoxColumn car_dept;
        private System.Windows.Forms.DataGridViewTextBoxColumn car_reason;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_empno;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_dept;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_pos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox empnoSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox nameSearch;
    }
}
