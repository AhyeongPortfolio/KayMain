namespace KaySub008
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.empnoSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.nameSearch = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panData = new System.Windows.Forms.Panel();
            this.ct_award_date = new System.Windows.Forms.MaskedTextBox();
            this.ct_award_organ = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ct_award_dept = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ct_award_pos = new System.Windows.Forms.ComboBox();
            this.ct_award_content = new System.Windows.Forms.TextBox();
            this.ct_award_kind = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ct_award_no = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ct_award_inout = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ct_award_empno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.award_empno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.award_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.award_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.award_kind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.award_organ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.award_content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.award_inout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.award_pos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.award_dept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Key1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Key2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Key3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bas_empno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1098, 637);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.empnoSearch);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.nameSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1092, 34);
            this.panel1.TabIndex = 0;
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
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(168, 6);
            this.label14.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 47;
            this.label14.Text = "성명";
            // 
            // nameSearch
            // 
            this.nameSearch.Location = new System.Drawing.Point(203, 2);
            this.nameSearch.Name = "nameSearch";
            this.nameSearch.Size = new System.Drawing.Size(100, 21);
            this.nameSearch.TabIndex = 50;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 550F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel6, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1092, 591);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.panData, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.dataGridView2, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(545, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 320F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(544, 585);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // panData
            // 
            this.panData.Controls.Add(this.ct_award_date);
            this.panData.Controls.Add(this.ct_award_organ);
            this.panData.Controls.Add(this.label13);
            this.panData.Controls.Add(this.panel3);
            this.panData.Controls.Add(this.ct_award_dept);
            this.panData.Controls.Add(this.label12);
            this.panData.Controls.Add(this.ct_award_pos);
            this.panData.Controls.Add(this.ct_award_content);
            this.panData.Controls.Add(this.ct_award_kind);
            this.panData.Controls.Add(this.label11);
            this.panData.Controls.Add(this.ct_award_no);
            this.panData.Controls.Add(this.label10);
            this.panData.Controls.Add(this.label9);
            this.panData.Controls.Add(this.label8);
            this.panData.Controls.Add(this.label7);
            this.panData.Controls.Add(this.ct_award_inout);
            this.panData.Controls.Add(this.label6);
            this.panData.Controls.Add(this.ct_award_empno);
            this.panData.Controls.Add(this.label4);
            this.panData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panData.Location = new System.Drawing.Point(3, 268);
            this.panData.Name = "panData";
            this.panData.Size = new System.Drawing.Size(538, 314);
            this.panData.TabIndex = 3;
            // 
            // ct_award_date
            // 
            this.ct_award_date.Location = new System.Drawing.Point(96, 27);
            this.ct_award_date.Mask = "0000-00-00";
            this.ct_award_date.Name = "ct_award_date";
            this.ct_award_date.Size = new System.Drawing.Size(100, 21);
            this.ct_award_date.TabIndex = 2;
            this.ct_award_date.ValidatingType = typeof(System.DateTime);
            // 
            // ct_award_organ
            // 
            this.ct_award_organ.Location = new System.Drawing.Point(96, 99);
            this.ct_award_organ.MaxLength = 50;
            this.ct_award_organ.Name = "ct_award_organ";
            this.ct_award_organ.Size = new System.Drawing.Size(204, 21);
            this.ct_award_organ.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(340, 102);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 48;
            this.label13.Text = "당시소속";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 313);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(538, 1);
            this.panel3.TabIndex = 0;
            // 
            // ct_award_dept
            // 
            this.ct_award_dept.FormattingEnabled = true;
            this.ct_award_dept.Location = new System.Drawing.Point(399, 98);
            this.ct_award_dept.Name = "ct_award_dept";
            this.ct_award_dept.Size = new System.Drawing.Size(100, 20);
            this.ct_award_dept.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(340, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 46;
            this.label12.Text = "당시직급";
            // 
            // ct_award_pos
            // 
            this.ct_award_pos.FormattingEnabled = true;
            this.ct_award_pos.Location = new System.Drawing.Point(399, 75);
            this.ct_award_pos.Name = "ct_award_pos";
            this.ct_award_pos.Size = new System.Drawing.Size(100, 20);
            this.ct_award_pos.TabIndex = 7;
            // 
            // ct_award_content
            // 
            this.ct_award_content.Location = new System.Drawing.Point(96, 123);
            this.ct_award_content.MaxLength = 100;
            this.ct_award_content.Multiline = true;
            this.ct_award_content.Name = "ct_award_content";
            this.ct_award_content.Size = new System.Drawing.Size(403, 42);
            this.ct_award_content.TabIndex = 9;
            // 
            // ct_award_kind
            // 
            this.ct_award_kind.Location = new System.Drawing.Point(96, 51);
            this.ct_award_kind.MaxLength = 50;
            this.ct_award_kind.Name = "ct_award_kind";
            this.ct_award_kind.Size = new System.Drawing.Size(204, 21);
            this.ct_award_kind.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 42;
            this.label11.Text = "수상종별";
            // 
            // ct_award_no
            // 
            this.ct_award_no.Location = new System.Drawing.Point(96, 75);
            this.ct_award_no.MaxLength = 30;
            this.ct_award_no.Name = "ct_award_no";
            this.ct_award_no.Size = new System.Drawing.Size(204, 21);
            this.ct_award_no.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 40;
            this.label10.Text = "수여번호";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 39;
            this.label9.Text = "수상내용";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 12);
            this.label8.TabIndex = 38;
            this.label8.Text = "수여자(시행처)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(340, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 36;
            this.label7.Text = "내외구분";
            // 
            // ct_award_inout
            // 
            this.ct_award_inout.FormattingEnabled = true;
            this.ct_award_inout.Items.AddRange(new object[] {
            "내부",
            "외부"});
            this.ct_award_inout.Location = new System.Drawing.Point(399, 51);
            this.ct_award_inout.Name = "ct_award_inout";
            this.ct_award_inout.Size = new System.Drawing.Size(100, 20);
            this.ct_award_inout.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 34;
            this.label6.Text = "수여일자";
            // 
            // ct_award_empno
            // 
            this.ct_award_empno.Location = new System.Drawing.Point(96, 3);
            this.ct_award_empno.MaxLength = 5;
            this.ct_award_empno.Name = "ct_award_empno";
            this.ct_award_empno.ReadOnly = true;
            this.ct_award_empno.Size = new System.Drawing.Size(100, 21);
            this.ct_award_empno.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 30;
            this.label4.Text = "사원번호";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.award_empno,
            this.award_date,
            this.award_no,
            this.award_kind,
            this.award_organ,
            this.award_content,
            this.award_inout,
            this.award_pos,
            this.award_dept,
            this.status,
            this.Key1,
            this.Key2,
            this.Key3});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(538, 259);
            this.dataGridView2.TabIndex = 0;
            // 
            // award_empno
            // 
            this.award_empno.DataPropertyName = "award_empno";
            this.award_empno.HeaderText = "사원번호";
            this.award_empno.Name = "award_empno";
            this.award_empno.ReadOnly = true;
            this.award_empno.Width = 78;
            // 
            // award_date
            // 
            this.award_date.DataPropertyName = "award_date";
            this.award_date.HeaderText = "수여일자";
            this.award_date.Name = "award_date";
            this.award_date.ReadOnly = true;
            this.award_date.Width = 78;
            // 
            // award_no
            // 
            this.award_no.DataPropertyName = "award_no";
            this.award_no.HeaderText = "수여번호";
            this.award_no.Name = "award_no";
            this.award_no.ReadOnly = true;
            this.award_no.Width = 78;
            // 
            // award_kind
            // 
            this.award_kind.DataPropertyName = "award_kind";
            this.award_kind.HeaderText = "수상종별";
            this.award_kind.Name = "award_kind";
            this.award_kind.ReadOnly = true;
            this.award_kind.Width = 78;
            // 
            // award_organ
            // 
            this.award_organ.DataPropertyName = "award_organ";
            this.award_organ.HeaderText = "수여자(시행처)";
            this.award_organ.Name = "award_organ";
            this.award_organ.ReadOnly = true;
            this.award_organ.Width = 112;
            // 
            // award_content
            // 
            this.award_content.DataPropertyName = "award_content";
            this.award_content.HeaderText = "수상내용";
            this.award_content.Name = "award_content";
            this.award_content.ReadOnly = true;
            this.award_content.Width = 78;
            // 
            // award_inout
            // 
            this.award_inout.DataPropertyName = "award_inout";
            this.award_inout.HeaderText = "내외구분";
            this.award_inout.Name = "award_inout";
            this.award_inout.ReadOnly = true;
            this.award_inout.Width = 78;
            // 
            // award_pos
            // 
            this.award_pos.DataPropertyName = "award_pos";
            this.award_pos.HeaderText = "당시직급";
            this.award_pos.Name = "award_pos";
            this.award_pos.ReadOnly = true;
            this.award_pos.Width = 78;
            // 
            // award_dept
            // 
            this.award_dept.DataPropertyName = "award_dept";
            this.award_dept.HeaderText = "당시소속";
            this.award_dept.Name = "award_dept";
            this.award_dept.ReadOnly = true;
            this.award_dept.Width = 78;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "상태";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Visible = false;
            this.status.Width = 54;
            // 
            // Key1
            // 
            this.Key1.DataPropertyName = "Key1";
            this.Key1.HeaderText = "Key1";
            this.Key1.Name = "Key1";
            this.Key1.ReadOnly = true;
            this.Key1.Visible = false;
            this.Key1.Width = 58;
            // 
            // Key2
            // 
            this.Key2.DataPropertyName = "Key2";
            this.Key2.HeaderText = "Key2";
            this.Key2.Name = "Key2";
            this.Key2.ReadOnly = true;
            this.Key2.Visible = false;
            this.Key2.Width = 58;
            // 
            // Key3
            // 
            this.Key3.DataPropertyName = "Key3";
            this.Key3.HeaderText = "Key3";
            this.Key3.Name = "Key3";
            this.Key3.ReadOnly = true;
            this.Key3.Visible = false;
            this.Key3.Width = 58;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dataGridView1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(536, 585);
            this.panel6.TabIndex = 3;
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(536, 585);
            this.dataGridView1.TabIndex = 2;
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
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panData.ResumeLayout(false);
            this.panData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox empnoSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox nameSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panData;
        private System.Windows.Forms.MaskedTextBox ct_award_date;
        private System.Windows.Forms.TextBox ct_award_organ;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox ct_award_dept;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox ct_award_pos;
        private System.Windows.Forms.TextBox ct_award_content;
        private System.Windows.Forms.TextBox ct_award_kind;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ct_award_no;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ct_award_inout;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ct_award_empno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_empno;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dept;
        private System.Windows.Forms.DataGridViewTextBoxColumn pos;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn award_empno;
        private System.Windows.Forms.DataGridViewTextBoxColumn award_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn award_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn award_kind;
        private System.Windows.Forms.DataGridViewTextBoxColumn award_organ;
        private System.Windows.Forms.DataGridViewTextBoxColumn award_content;
        private System.Windows.Forms.DataGridViewTextBoxColumn award_inout;
        private System.Windows.Forms.DataGridViewTextBoxColumn award_pos;
        private System.Windows.Forms.DataGridViewTextBoxColumn award_dept;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Key1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Key2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Key3;
    }
}
