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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panData = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.ct_cd_use = new System.Windows.Forms.ComboBox();
            this.btn_bas_univ = new System.Windows.Forms.Button();
            this.ct_cd_edate = new System.Windows.Forms.MaskedTextBox();
            this.ct_cd_sdate = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ct_cd_seq = new System.Windows.Forms.TextBox();
            this.ct_cd_code = new System.Windows.Forms.TextBox();
            this.ct_cd_upper = new System.Windows.Forms.TextBox();
            this.ct_cd_addinfo = new System.Windows.Forms.TextBox();
            this.ct_cd_codnm = new System.Windows.Forms.TextBox();
            this.ct_cd_codnms = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ct_cd_grpcd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.qt_cd_grpcd = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.qt_cd_use = new System.Windows.Forms.ComboBox();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.key1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panData.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.tableLayoutPanel2.Controls.Add(this.panData, 1, 0);
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
            this.status,
            this.key1,
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
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(770, 625);
            this.dataGridView1.TabIndex = 0;
            // 
            // panData
            // 
            this.panData.Controls.Add(this.label3);
            this.panData.Controls.Add(this.ct_cd_use);
            this.panData.Controls.Add(this.btn_bas_univ);
            this.panData.Controls.Add(this.ct_cd_edate);
            this.panData.Controls.Add(this.ct_cd_sdate);
            this.panData.Controls.Add(this.label11);
            this.panData.Controls.Add(this.ct_cd_seq);
            this.panData.Controls.Add(this.ct_cd_code);
            this.panData.Controls.Add(this.ct_cd_upper);
            this.panData.Controls.Add(this.ct_cd_addinfo);
            this.panData.Controls.Add(this.ct_cd_codnm);
            this.panData.Controls.Add(this.ct_cd_codnms);
            this.panData.Controls.Add(this.label12);
            this.panData.Controls.Add(this.ct_cd_grpcd);
            this.panData.Controls.Add(this.label10);
            this.panData.Controls.Add(this.label9);
            this.panData.Controls.Add(this.label7);
            this.panData.Controls.Add(this.label8);
            this.panData.Controls.Add(this.label6);
            this.panData.Controls.Add(this.label5);
            this.panData.Controls.Add(this.label4);
            this.panData.Controls.Add(this.panel3);
            this.panData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panData.Location = new System.Drawing.Point(779, 3);
            this.panData.Name = "panData";
            this.panData.Size = new System.Drawing.Size(264, 625);
            this.panData.TabIndex = 10;
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
            // ct_cd_use
            // 
            this.ct_cd_use.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ct_cd_use.FormattingEnabled = true;
            this.ct_cd_use.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.ct_cd_use.Location = new System.Drawing.Point(99, 171);
            this.ct_cd_use.Name = "ct_cd_use";
            this.ct_cd_use.Size = new System.Drawing.Size(152, 20);
            this.ct_cd_use.TabIndex = 77;
            this.ct_cd_use.Tag = "Codeuse";
            // 
            // btn_bas_univ
            // 
            this.btn_bas_univ.Image = ((System.Drawing.Image)(resources.GetObject("btn_bas_univ.Image")));
            this.btn_bas_univ.Location = new System.Drawing.Point(229, 3);
            this.btn_bas_univ.Name = "btn_bas_univ";
            this.btn_bas_univ.Size = new System.Drawing.Size(22, 22);
            this.btn_bas_univ.TabIndex = 86;
            this.btn_bas_univ.UseVisualStyleBackColor = true;
            // 
            // ct_cd_edate
            // 
            this.ct_cd_edate.Location = new System.Drawing.Point(99, 218);
            this.ct_cd_edate.Mask = "0000-00-00";
            this.ct_cd_edate.Name = "ct_cd_edate";
            this.ct_cd_edate.ReadOnly = true;
            this.ct_cd_edate.Size = new System.Drawing.Size(152, 21);
            this.ct_cd_edate.TabIndex = 79;
            this.ct_cd_edate.Tag = "CodeDate";
            this.ct_cd_edate.ValidatingType = typeof(System.DateTime);
            // 
            // ct_cd_sdate
            // 
            this.ct_cd_sdate.Location = new System.Drawing.Point(99, 194);
            this.ct_cd_sdate.Mask = "0000-00-00";
            this.ct_cd_sdate.Name = "ct_cd_sdate";
            this.ct_cd_sdate.Size = new System.Drawing.Size(152, 21);
            this.ct_cd_sdate.TabIndex = 78;
            this.ct_cd_sdate.Tag = "Codesdate";
            this.ct_cd_sdate.ValidatingType = typeof(System.DateTime);
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
            // ct_cd_seq
            // 
            this.ct_cd_seq.Location = new System.Drawing.Point(99, 52);
            this.ct_cd_seq.MaxLength = 3;
            this.ct_cd_seq.Name = "ct_cd_seq";
            this.ct_cd_seq.Size = new System.Drawing.Size(152, 21);
            this.ct_cd_seq.TabIndex = 72;
            this.ct_cd_seq.Tag = "Codeseq";
            // 
            // ct_cd_code
            // 
            this.ct_cd_code.Location = new System.Drawing.Point(99, 28);
            this.ct_cd_code.MaxLength = 10;
            this.ct_cd_code.Name = "ct_cd_code";
            this.ct_cd_code.Size = new System.Drawing.Size(152, 21);
            this.ct_cd_code.TabIndex = 71;
            this.ct_cd_code.Tag = "Codecode";
            // 
            // ct_cd_upper
            // 
            this.ct_cd_upper.Location = new System.Drawing.Point(99, 147);
            this.ct_cd_upper.MaxLength = 10;
            this.ct_cd_upper.Name = "ct_cd_upper";
            this.ct_cd_upper.Size = new System.Drawing.Size(152, 21);
            this.ct_cd_upper.TabIndex = 76;
            this.ct_cd_upper.Tag = "Codeupper";
            // 
            // ct_cd_addinfo
            // 
            this.ct_cd_addinfo.Location = new System.Drawing.Point(99, 123);
            this.ct_cd_addinfo.MaxLength = 10;
            this.ct_cd_addinfo.Name = "ct_cd_addinfo";
            this.ct_cd_addinfo.Size = new System.Drawing.Size(152, 21);
            this.ct_cd_addinfo.TabIndex = 75;
            this.ct_cd_addinfo.Tag = "Codeaddinfo";
            // 
            // ct_cd_codnm
            // 
            this.ct_cd_codnm.Location = new System.Drawing.Point(99, 99);
            this.ct_cd_codnm.MaxLength = 50;
            this.ct_cd_codnm.Name = "ct_cd_codnm";
            this.ct_cd_codnm.Size = new System.Drawing.Size(152, 21);
            this.ct_cd_codnm.TabIndex = 74;
            this.ct_cd_codnm.Tag = "Codenm";
            // 
            // ct_cd_codnms
            // 
            this.ct_cd_codnms.Location = new System.Drawing.Point(99, 75);
            this.ct_cd_codnms.MaxLength = 30;
            this.ct_cd_codnms.Name = "ct_cd_codnms";
            this.ct_cd_codnms.Size = new System.Drawing.Size(152, 21);
            this.ct_cd_codnms.TabIndex = 73;
            this.ct_cd_codnms.Tag = "Codecodnms";
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
            // ct_cd_grpcd
            // 
            this.ct_cd_grpcd.Location = new System.Drawing.Point(99, 4);
            this.ct_cd_grpcd.MaxLength = 3;
            this.ct_cd_grpcd.Name = "ct_cd_grpcd";
            this.ct_cd_grpcd.ReadOnly = true;
            this.ct_cd_grpcd.Size = new System.Drawing.Size(124, 21);
            this.ct_cd_grpcd.TabIndex = 68;
            this.ct_cd_grpcd.Tag = "Codegcode";
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
            this.panel4.Controls.Add(this.qt_cd_grpcd);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.qt_cd_use);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1046, 34);
            this.panel4.TabIndex = 1;
            // 
            // qt_cd_grpcd
            // 
            this.qt_cd_grpcd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.qt_cd_grpcd.FormattingEnabled = true;
            this.qt_cd_grpcd.Location = new System.Drawing.Point(62, 3);
            this.qt_cd_grpcd.Name = "qt_cd_grpcd";
            this.qt_cd_grpcd.Size = new System.Drawing.Size(100, 20);
            this.qt_cd_grpcd.TabIndex = 63;
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
            // qt_cd_use
            // 
            this.qt_cd_use.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.qt_cd_use.FormattingEnabled = true;
            this.qt_cd_use.Items.AddRange(new object[] {
            " ",
            "Y",
            "N"});
            this.qt_cd_use.Location = new System.Drawing.Point(227, 2);
            this.qt_cd_use.Name = "qt_cd_use";
            this.qt_cd_use.Size = new System.Drawing.Size(100, 20);
            this.qt_cd_use.TabIndex = 56;
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
            this.Size = new System.Drawing.Size(1052, 677);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panData.ResumeLayout(false);
            this.panData.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ct_cd_use;
        private System.Windows.Forms.Button btn_bas_univ;
        private System.Windows.Forms.MaskedTextBox ct_cd_edate;
        private System.Windows.Forms.MaskedTextBox ct_cd_sdate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ct_cd_seq;
        public System.Windows.Forms.TextBox ct_cd_code;
        private System.Windows.Forms.TextBox ct_cd_upper;
        private System.Windows.Forms.TextBox ct_cd_addinfo;
        public System.Windows.Forms.TextBox ct_cd_codnm;
        public System.Windows.Forms.TextBox ct_cd_codnms;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox ct_cd_grpcd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox qt_cd_grpcd;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox qt_cd_use;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn key1;
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
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
