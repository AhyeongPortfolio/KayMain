namespace KaySub002
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.check = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cd_grpcd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cd_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cd_seq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cd_codnms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cd_codnm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cd_addinfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cd_upper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cd_use = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cd_sdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cd_edate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datasys1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datasys2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datasys3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.grpYN = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.edateBox = new System.Windows.Forms.MaskedTextBox();
            this.sdateBox = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.seqBox = new System.Windows.Forms.TextBox();
            this.codeBox = new System.Windows.Forms.TextBox();
            this.upperBox = new System.Windows.Forms.TextBox();
            this.addinfoBox = new System.Windows.Forms.TextBox();
            this.codnmBox = new System.Windows.Forms.TextBox();
            this.codnmsBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.grpcdBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cdgGrpcd = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cdgUse = new System.Windows.Forms.ComboBox();
            this.label34 = new System.Windows.Forms.Label();
            this.cdgName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1052, 677);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 270F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 631F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1046, 631);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.check,
            this.cd_grpcd,
            this.cd_code,
            this.cd_seq,
            this.cd_codnms,
            this.cd_codnm,
            this.cd_addinfo,
            this.cd_upper,
            this.cd_use,
            this.cd_sdate,
            this.cd_edate,
            this.datasys1,
            this.datasys2,
            this.datasys3});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(770, 625);
            this.dataGridView1.TabIndex = 0;
            // 
            // check
            // 
            this.check.HeaderText = "상태";
            this.check.Name = "check";
            this.check.Width = 54;
            // 
            // cd_grpcd
            // 
            this.cd_grpcd.DataPropertyName = "cd_grpcd";
            this.cd_grpcd.HeaderText = "그룹코드";
            this.cd_grpcd.Name = "cd_grpcd";
            this.cd_grpcd.ReadOnly = true;
            this.cd_grpcd.Width = 78;
            // 
            // cd_code
            // 
            this.cd_code.DataPropertyName = "cd_code";
            this.cd_code.HeaderText = "코드";
            this.cd_code.Name = "cd_code";
            this.cd_code.ReadOnly = true;
            this.cd_code.Width = 54;
            // 
            // cd_seq
            // 
            this.cd_seq.DataPropertyName = "cd_seq";
            this.cd_seq.HeaderText = "코드seq";
            this.cd_seq.Name = "cd_seq";
            this.cd_seq.ReadOnly = true;
            this.cd_seq.Width = 75;
            // 
            // cd_codnms
            // 
            this.cd_codnms.DataPropertyName = "cd_codnms";
            this.cd_codnms.HeaderText = "코드명(축약)";
            this.cd_codnms.Name = "cd_codnms";
            this.cd_codnms.ReadOnly = true;
            // 
            // cd_codnm
            // 
            this.cd_codnm.DataPropertyName = "cd_codnm";
            this.cd_codnm.HeaderText = "코드명(원형)";
            this.cd_codnm.Name = "cd_codnm";
            this.cd_codnm.ReadOnly = true;
            // 
            // cd_addinfo
            // 
            this.cd_addinfo.DataPropertyName = "cd_addinfo";
            this.cd_addinfo.HeaderText = "추가정보";
            this.cd_addinfo.Name = "cd_addinfo";
            this.cd_addinfo.ReadOnly = true;
            this.cd_addinfo.Width = 78;
            // 
            // cd_upper
            // 
            this.cd_upper.DataPropertyName = "cd_upper";
            this.cd_upper.HeaderText = "상위분류";
            this.cd_upper.Name = "cd_upper";
            this.cd_upper.ReadOnly = true;
            this.cd_upper.Width = 78;
            // 
            // cd_use
            // 
            this.cd_use.DataPropertyName = "cd_use";
            this.cd_use.HeaderText = "사용여부";
            this.cd_use.Name = "cd_use";
            this.cd_use.ReadOnly = true;
            this.cd_use.Width = 78;
            // 
            // cd_sdate
            // 
            this.cd_sdate.DataPropertyName = "cd_sdate";
            this.cd_sdate.HeaderText = "생성일자";
            this.cd_sdate.Name = "cd_sdate";
            this.cd_sdate.ReadOnly = true;
            this.cd_sdate.Visible = false;
            this.cd_sdate.Width = 78;
            // 
            // cd_edate
            // 
            this.cd_edate.DataPropertyName = "cd_edate";
            this.cd_edate.HeaderText = "폐기일자";
            this.cd_edate.Name = "cd_edate";
            this.cd_edate.ReadOnly = true;
            this.cd_edate.Visible = false;
            this.cd_edate.Width = 78;
            // 
            // datasys1
            // 
            this.datasys1.DataPropertyName = "datasys1";
            this.datasys1.HeaderText = "자료처리일시";
            this.datasys1.Name = "datasys1";
            this.datasys1.Visible = false;
            this.datasys1.Width = 102;
            // 
            // datasys2
            // 
            this.datasys2.DataPropertyName = "datasys2";
            this.datasys2.HeaderText = "자료처리구분";
            this.datasys2.Name = "datasys2";
            this.datasys2.Visible = false;
            this.datasys2.Width = 102;
            // 
            // datasys3
            // 
            this.datasys3.DataPropertyName = "datasys3";
            this.datasys3.HeaderText = "자료처리자";
            this.datasys3.Name = "datasys3";
            this.datasys3.Visible = false;
            this.datasys3.Width = 90;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.grpYN);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.edateBox);
            this.panel1.Controls.Add(this.sdateBox);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.seqBox);
            this.panel1.Controls.Add(this.codeBox);
            this.panel1.Controls.Add(this.upperBox);
            this.panel1.Controls.Add(this.addinfoBox);
            this.panel1.Controls.Add(this.codnmBox);
            this.panel1.Controls.Add(this.codnmsBox);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.grpcdBox);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(779, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 625);
            this.panel1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 88;
            this.label3.Text = "사용여부";
            // 
            // grpYN
            // 
            this.grpYN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.grpYN.FormattingEnabled = true;
            this.grpYN.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.grpYN.Location = new System.Drawing.Point(99, 171);
            this.grpYN.Name = "grpYN";
            this.grpYN.Size = new System.Drawing.Size(152, 20);
            this.grpYN.TabIndex = 77;
            this.grpYN.Tag = "Codeuse";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(229, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 22);
            this.button1.TabIndex = 86;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // edateBox
            // 
            this.edateBox.Location = new System.Drawing.Point(99, 218);
            this.edateBox.Mask = "00000000";
            this.edateBox.Name = "edateBox";
            this.edateBox.ReadOnly = true;
            this.edateBox.Size = new System.Drawing.Size(152, 21);
            this.edateBox.TabIndex = 79;
            this.edateBox.Tag = "CodeDate";
            this.edateBox.ValidatingType = typeof(System.DateTime);
            // 
            // sdateBox
            // 
            this.sdateBox.Location = new System.Drawing.Point(99, 194);
            this.sdateBox.Mask = "00000000";
            this.sdateBox.Name = "sdateBox";
            this.sdateBox.Size = new System.Drawing.Size(152, 21);
            this.sdateBox.TabIndex = 78;
            this.sdateBox.Tag = "Codesdate";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 12);
            this.label11.TabIndex = 83;
            this.label11.Text = "코드seq";
            // 
            // seqBox
            // 
            this.seqBox.Location = new System.Drawing.Point(99, 52);
            this.seqBox.MaxLength = 3;
            this.seqBox.Name = "seqBox";
            this.seqBox.Size = new System.Drawing.Size(152, 21);
            this.seqBox.TabIndex = 72;
            this.seqBox.Tag = "Codeseq";
            // 
            // codeBox
            // 
            this.codeBox.Location = new System.Drawing.Point(99, 28);
            this.codeBox.MaxLength = 10;
            this.codeBox.Name = "codeBox";
            this.codeBox.Size = new System.Drawing.Size(152, 21);
            this.codeBox.TabIndex = 71;
            this.codeBox.Tag = "Codecode";
            // 
            // upperBox
            // 
            this.upperBox.Location = new System.Drawing.Point(99, 147);
            this.upperBox.MaxLength = 10;
            this.upperBox.Name = "upperBox";
            this.upperBox.Size = new System.Drawing.Size(152, 21);
            this.upperBox.TabIndex = 76;
            this.upperBox.Tag = "Codeupper";
            // 
            // addinfoBox
            // 
            this.addinfoBox.Location = new System.Drawing.Point(99, 123);
            this.addinfoBox.MaxLength = 10;
            this.addinfoBox.Name = "addinfoBox";
            this.addinfoBox.Size = new System.Drawing.Size(152, 21);
            this.addinfoBox.TabIndex = 75;
            this.addinfoBox.Tag = "Codeaddinfo";
            // 
            // codnmBox
            // 
            this.codnmBox.Location = new System.Drawing.Point(99, 99);
            this.codnmBox.MaxLength = 50;
            this.codnmBox.Name = "codnmBox";
            this.codnmBox.Size = new System.Drawing.Size(152, 21);
            this.codnmBox.TabIndex = 74;
            this.codnmBox.Tag = "Codenm";
            // 
            // codnmsBox
            // 
            this.codnmsBox.Location = new System.Drawing.Point(99, 75);
            this.codnmsBox.MaxLength = 30;
            this.codnmsBox.Name = "codnmsBox";
            this.codnmsBox.Size = new System.Drawing.Size(152, 21);
            this.codnmsBox.TabIndex = 73;
            this.codnmsBox.Tag = "Codecodnms";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 221);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 78;
            this.label12.Text = "폐기일자";
            // 
            // grpcdBox
            // 
            this.grpcdBox.Location = new System.Drawing.Point(99, 4);
            this.grpcdBox.MaxLength = 3;
            this.grpcdBox.Name = "grpcdBox";
            this.grpcdBox.ReadOnly = true;
            this.grpcdBox.Size = new System.Drawing.Size(124, 21);
            this.grpcdBox.TabIndex = 68;
            this.grpcdBox.Tag = "Codegcode";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 79;
            this.label10.Text = "생성일자";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 80;
            this.label9.Text = "상위분류";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 82;
            this.label7.Text = "코드";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 77;
            this.label8.Text = "추가정보";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 12);
            this.label6.TabIndex = 81;
            this.label6.Text = "코드명(원형)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 12);
            this.label5.TabIndex = 76;
            this.label5.Text = "코드명(축약)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 75;
            this.label4.Text = "그룹코드";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 624);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(264, 1);
            this.panel3.TabIndex = 41;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cdgGrpcd);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.cdgUse);
            this.panel4.Controls.Add(this.label34);
            this.panel4.Controls.Add(this.cdgName);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1046, 34);
            this.panel4.TabIndex = 1;
            // 
            // cdgGrpcd
            // 
            this.cdgGrpcd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdgGrpcd.FormattingEnabled = true;
            this.cdgGrpcd.Location = new System.Drawing.Point(62, 3);
            this.cdgGrpcd.Name = "cdgGrpcd";
            this.cdgGrpcd.Size = new System.Drawing.Size(100, 20);
            this.cdgGrpcd.TabIndex = 63;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 33);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1046, 1);
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
            this.label1.Text = "그룹코드";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 53;
            this.label2.Text = "사용여부";
            // 
            // cdgUse
            // 
            this.cdgUse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdgUse.FormattingEnabled = true;
            this.cdgUse.Items.AddRange(new object[] {
            " ",
            "Y",
            "N"});
            this.cdgUse.Location = new System.Drawing.Point(227, 2);
            this.cdgUse.Name = "cdgUse";
            this.cdgUse.Size = new System.Drawing.Size(100, 20);
            this.cdgUse.TabIndex = 56;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(333, 6);
            this.label34.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(65, 12);
            this.label34.TabIndex = 55;
            this.label34.Text = "그룹코드명";
            // 
            // cdgName
            // 
            this.cdgName.Location = new System.Drawing.Point(404, 2);
            this.cdgName.Name = "cdgName";
            this.cdgName.Size = new System.Drawing.Size(100, 21);
            this.cdgName.TabIndex = 58;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1052, 677);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn check;
        private System.Windows.Forms.DataGridViewTextBoxColumn cd_grpcd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cd_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn cd_seq;
        private System.Windows.Forms.DataGridViewTextBoxColumn cd_codnms;
        private System.Windows.Forms.DataGridViewTextBoxColumn cd_codnm;
        private System.Windows.Forms.DataGridViewTextBoxColumn cd_addinfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cd_upper;
        private System.Windows.Forms.DataGridViewTextBoxColumn cd_use;
        private System.Windows.Forms.DataGridViewTextBoxColumn cd_sdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cd_edate;
        private System.Windows.Forms.DataGridViewTextBoxColumn datasys1;
        private System.Windows.Forms.DataGridViewTextBoxColumn datasys2;
        private System.Windows.Forms.DataGridViewTextBoxColumn datasys3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox grpYN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox edateBox;
        private System.Windows.Forms.MaskedTextBox sdateBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox seqBox;
        public System.Windows.Forms.TextBox codeBox;
        private System.Windows.Forms.TextBox upperBox;
        private System.Windows.Forms.TextBox addinfoBox;
        public System.Windows.Forms.TextBox codnmBox;
        public System.Windows.Forms.TextBox codnmsBox;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox grpcdBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cdgGrpcd;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cdgUse;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox cdgName;
    }
}
