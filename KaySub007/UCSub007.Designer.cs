namespace KaySub007
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
            this.panData = new System.Windows.Forms.Panel();
            this.ct_edu_gradate = new System.Windows.Forms.MaskedTextBox();
            this.ct_edu_entdate = new System.Windows.Forms.MaskedTextBox();
            this.ct_edu_gra = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ct_edu_grade = new System.Windows.Forms.TextBox();
            this.ct_edu_dept = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ct_edu_degree = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ct_edu_loe = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ct_edu_schnm = new System.Windows.Forms.TextBox();
            this.ct_edu_empno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.edu_empno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edu_loe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edu_entdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edu_gradate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edu_schnm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edu_dept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edu_degree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edu_grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edu_gra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edu_last = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Key1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Key2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Key3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bas_empno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.empnoSearch = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.nameSearch = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1098, 637);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 550F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1092, 591);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panData, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.dataGridView2, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(545, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 320F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(544, 585);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panData
            // 
            this.panData.Controls.Add(this.ct_edu_gradate);
            this.panData.Controls.Add(this.ct_edu_entdate);
            this.panData.Controls.Add(this.ct_edu_gra);
            this.panData.Controls.Add(this.label12);
            this.panData.Controls.Add(this.panel2);
            this.panData.Controls.Add(this.ct_edu_grade);
            this.panData.Controls.Add(this.ct_edu_dept);
            this.panData.Controls.Add(this.label10);
            this.panData.Controls.Add(this.label9);
            this.panData.Controls.Add(this.ct_edu_degree);
            this.panData.Controls.Add(this.label8);
            this.panData.Controls.Add(this.label7);
            this.panData.Controls.Add(this.label11);
            this.panData.Controls.Add(this.ct_edu_loe);
            this.panData.Controls.Add(this.label6);
            this.panData.Controls.Add(this.ct_edu_schnm);
            this.panData.Controls.Add(this.ct_edu_empno);
            this.panData.Controls.Add(this.label5);
            this.panData.Controls.Add(this.label4);
            this.panData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panData.Location = new System.Drawing.Point(3, 268);
            this.panData.Name = "panData";
            this.panData.Size = new System.Drawing.Size(538, 314);
            this.panData.TabIndex = 3;
            // 
            // ct_edu_gradate
            // 
            this.ct_edu_gradate.Location = new System.Drawing.Point(237, 96);
            this.ct_edu_gradate.Mask = "0000-00-00";
            this.ct_edu_gradate.Name = "ct_edu_gradate";
            this.ct_edu_gradate.Size = new System.Drawing.Size(100, 21);
            this.ct_edu_gradate.TabIndex = 9;
            this.ct_edu_gradate.ValidatingType = typeof(System.DateTime);
            // 
            // ct_edu_entdate
            // 
            this.ct_edu_entdate.Location = new System.Drawing.Point(62, 96);
            this.ct_edu_entdate.Mask = "0000-00-00";
            this.ct_edu_entdate.Name = "ct_edu_entdate";
            this.ct_edu_entdate.Size = new System.Drawing.Size(100, 21);
            this.ct_edu_entdate.TabIndex = 8;
            this.ct_edu_entdate.ValidatingType = typeof(System.DateTime);
            // 
            // ct_edu_gra
            // 
            this.ct_edu_gra.FormattingEnabled = true;
            this.ct_edu_gra.Items.AddRange(new object[] {
            "졸업",
            "수료",
            "재학"});
            this.ct_edu_gra.Location = new System.Drawing.Point(62, 73);
            this.ct_edu_gra.Name = "ct_edu_gra";
            this.ct_edu_gra.Size = new System.Drawing.Size(100, 20);
            this.ct_edu_gra.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 40;
            this.label12.Text = "졸업구분";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 313);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(538, 1);
            this.panel2.TabIndex = 0;
            // 
            // ct_edu_grade
            // 
            this.ct_edu_grade.Location = new System.Drawing.Point(237, 50);
            this.ct_edu_grade.MaxLength = 20;
            this.ct_edu_grade.Name = "ct_edu_grade";
            this.ct_edu_grade.Size = new System.Drawing.Size(100, 21);
            this.ct_edu_grade.TabIndex = 5;
            // 
            // ct_edu_dept
            // 
            this.ct_edu_dept.Location = new System.Drawing.Point(237, 26);
            this.ct_edu_dept.MaxLength = 20;
            this.ct_edu_dept.Name = "ct_edu_dept";
            this.ct_edu_dept.Size = new System.Drawing.Size(100, 21);
            this.ct_edu_dept.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(168, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 12);
            this.label10.TabIndex = 36;
            this.label10.Text = "학과(전공)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(178, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 34;
            this.label9.Text = "졸업일자";
            // 
            // ct_edu_degree
            // 
            this.ct_edu_degree.FormattingEnabled = true;
            this.ct_edu_degree.Items.AddRange(new object[] {
            "전문학사",
            "학사",
            "석사",
            "박사"});
            this.ct_edu_degree.Location = new System.Drawing.Point(62, 50);
            this.ct_edu_degree.Name = "ct_edu_degree";
            this.ct_edu_degree.Size = new System.Drawing.Size(100, 20);
            this.ct_edu_degree.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 32;
            this.label8.Text = "학위";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 30;
            this.label7.Text = "입학일자";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(202, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 28;
            this.label11.Text = "성적";
            // 
            // ct_edu_loe
            // 
            this.ct_edu_loe.FormattingEnabled = true;
            this.ct_edu_loe.Items.AddRange(new object[] {
            "고등학교",
            "전문대",
            "대학교",
            "대학원"});
            this.ct_edu_loe.Location = new System.Drawing.Point(237, 73);
            this.ct_edu_loe.Name = "ct_edu_loe";
            this.ct_edu_loe.Size = new System.Drawing.Size(100, 20);
            this.ct_edu_loe.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 28;
            this.label6.Text = "학력구분";
            // 
            // ct_edu_schnm
            // 
            this.ct_edu_schnm.Location = new System.Drawing.Point(62, 26);
            this.ct_edu_schnm.MaxLength = 20;
            this.ct_edu_schnm.Name = "ct_edu_schnm";
            this.ct_edu_schnm.Size = new System.Drawing.Size(100, 21);
            this.ct_edu_schnm.TabIndex = 2;
            // 
            // ct_edu_empno
            // 
            this.ct_edu_empno.Location = new System.Drawing.Point(62, 2);
            this.ct_edu_empno.MaxLength = 5;
            this.ct_edu_empno.Name = "ct_edu_empno";
            this.ct_edu_empno.ReadOnly = true;
            this.ct_edu_empno.Size = new System.Drawing.Size(100, 21);
            this.ct_edu_empno.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 25;
            this.label5.Text = "학교명";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 5);
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
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.edu_empno,
            this.edu_loe,
            this.edu_entdate,
            this.edu_gradate,
            this.edu_schnm,
            this.edu_dept,
            this.edu_degree,
            this.edu_grade,
            this.edu_gra,
            this.edu_last,
            this.status,
            this.Key1,
            this.Key2,
            this.Key3});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(538, 259);
            this.dataGridView2.TabIndex = 0;
            // 
            // edu_empno
            // 
            this.edu_empno.DataPropertyName = "edu_empno";
            this.edu_empno.HeaderText = "사원번호";
            this.edu_empno.Name = "edu_empno";
            this.edu_empno.Width = 78;
            // 
            // edu_loe
            // 
            this.edu_loe.DataPropertyName = "edu_loe";
            this.edu_loe.HeaderText = "학력구분";
            this.edu_loe.Name = "edu_loe";
            this.edu_loe.Width = 78;
            // 
            // edu_entdate
            // 
            this.edu_entdate.DataPropertyName = "edu_entdate";
            this.edu_entdate.HeaderText = "입학일자";
            this.edu_entdate.Name = "edu_entdate";
            this.edu_entdate.Width = 78;
            // 
            // edu_gradate
            // 
            this.edu_gradate.DataPropertyName = "edu_gradate";
            this.edu_gradate.HeaderText = "졸업일자";
            this.edu_gradate.Name = "edu_gradate";
            this.edu_gradate.Visible = false;
            this.edu_gradate.Width = 78;
            // 
            // edu_schnm
            // 
            this.edu_schnm.DataPropertyName = "edu_schnm";
            this.edu_schnm.HeaderText = "학교명";
            this.edu_schnm.Name = "edu_schnm";
            this.edu_schnm.Width = 66;
            // 
            // edu_dept
            // 
            this.edu_dept.DataPropertyName = "edu_dept";
            this.edu_dept.HeaderText = "학과(전공)";
            this.edu_dept.Name = "edu_dept";
            this.edu_dept.Width = 88;
            // 
            // edu_degree
            // 
            this.edu_degree.DataPropertyName = "edu_degree";
            this.edu_degree.HeaderText = "학위";
            this.edu_degree.Name = "edu_degree";
            this.edu_degree.Width = 54;
            // 
            // edu_grade
            // 
            this.edu_grade.DataPropertyName = "edu_grade";
            this.edu_grade.HeaderText = "성적";
            this.edu_grade.Name = "edu_grade";
            this.edu_grade.Width = 54;
            // 
            // edu_gra
            // 
            this.edu_gra.DataPropertyName = "edu_gra";
            this.edu_gra.HeaderText = "졸업구분";
            this.edu_gra.Name = "edu_gra";
            this.edu_gra.Width = 78;
            // 
            // edu_last
            // 
            this.edu_last.DataPropertyName = "edu_last";
            this.edu_last.HeaderText = "최종여부";
            this.edu_last.Name = "edu_last";
            this.edu_last.Visible = false;
            this.edu_last.Width = 78;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "상태";
            this.status.Name = "status";
            this.status.Visible = false;
            this.status.Width = 54;
            // 
            // Key1
            // 
            this.Key1.DataPropertyName = "Key1";
            this.Key1.HeaderText = "Key1";
            this.Key1.Name = "Key1";
            this.Key1.Visible = false;
            this.Key1.Width = 58;
            // 
            // Key2
            // 
            this.Key2.DataPropertyName = "Key2";
            this.Key2.HeaderText = "Key2";
            this.Key2.Name = "Key2";
            this.Key2.Visible = false;
            this.Key2.Width = 58;
            // 
            // Key3
            // 
            this.Key3.DataPropertyName = "Key3";
            this.Key3.HeaderText = "Key3";
            this.Key3.Name = "Key3";
            this.Key3.Visible = false;
            this.Key3.Width = 58;
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
            this.dept,
            this.pos});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(536, 585);
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
            // dept
            // 
            this.dept.DataPropertyName = "dept";
            this.dept.HeaderText = "부서";
            this.dept.Name = "dept";
            this.dept.ReadOnly = true;
            this.dept.Width = 54;
            // 
            // pos
            // 
            this.pos.DataPropertyName = "pos";
            this.pos.HeaderText = "직급";
            this.pos.Name = "pos";
            this.pos.ReadOnly = true;
            this.pos.Width = 54;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.empnoSearch);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.nameSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1092, 34);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 33);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1092, 1);
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(168, 6);
            this.label13.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 47;
            this.label13.Text = "성명";
            // 
            // nameSearch
            // 
            this.nameSearch.Location = new System.Drawing.Point(203, 2);
            this.nameSearch.Name = "nameSearch";
            this.nameSearch.Size = new System.Drawing.Size(100, 21);
            this.nameSearch.TabIndex = 50;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1098, 637);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panData.ResumeLayout(false);
            this.panData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panData;
        private System.Windows.Forms.MaskedTextBox ct_edu_gradate;
        private System.Windows.Forms.MaskedTextBox ct_edu_entdate;
        private System.Windows.Forms.ComboBox ct_edu_gra;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox ct_edu_grade;
        private System.Windows.Forms.TextBox ct_edu_dept;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox ct_edu_degree;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox ct_edu_loe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ct_edu_schnm;
        private System.Windows.Forms.TextBox ct_edu_empno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox empnoSearch;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox nameSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn edu_empno;
        private System.Windows.Forms.DataGridViewTextBoxColumn edu_loe;
        private System.Windows.Forms.DataGridViewTextBoxColumn edu_entdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn edu_gradate;
        private System.Windows.Forms.DataGridViewTextBoxColumn edu_schnm;
        private System.Windows.Forms.DataGridViewTextBoxColumn edu_dept;
        private System.Windows.Forms.DataGridViewTextBoxColumn edu_degree;
        private System.Windows.Forms.DataGridViewTextBoxColumn edu_grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn edu_gra;
        private System.Windows.Forms.DataGridViewTextBoxColumn edu_last;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Key1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Key2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Key3;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_empno;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dept;
        private System.Windows.Forms.DataGridViewTextBoxColumn pos;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
