namespace KaySub025
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panData = new System.Windows.Forms.Panel();
            this.ct_ceri_sau = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ct_ceri_lang = new System.Windows.Forms.ComboBox();
            this.ct_ceri_kind = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ct_ceri_cnt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ct_ceri_date = new System.Windows.Forms.MaskedTextBox();
            this.ct_ceri_num = new System.Windows.Forms.TextBox();
            this.ct_ceri_empno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.empnoSearch = new System.Windows.Forms.TextBox();
            this.nameSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ceri_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ceri_empno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ceri_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ceri_kind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ceri_sau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ceri_lang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ceri_cnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panData.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.Controls.Add(this.panData, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(997, 701);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panData
            // 
            this.panData.Controls.Add(this.ct_ceri_sau);
            this.panData.Controls.Add(this.label6);
            this.panData.Controls.Add(this.label3);
            this.panData.Controls.Add(this.panel7);
            this.panData.Controls.Add(this.panel6);
            this.panData.Controls.Add(this.panel2);
            this.panData.Controls.Add(this.panel4);
            this.panData.Controls.Add(this.ct_ceri_lang);
            this.panData.Controls.Add(this.ct_ceri_kind);
            this.panData.Controls.Add(this.label13);
            this.panData.Controls.Add(this.ct_ceri_cnt);
            this.panData.Controls.Add(this.label8);
            this.panData.Controls.Add(this.ct_ceri_date);
            this.panData.Controls.Add(this.ct_ceri_num);
            this.panData.Controls.Add(this.ct_ceri_empno);
            this.panData.Controls.Add(this.label5);
            this.panData.Controls.Add(this.label4);
            this.panData.Controls.Add(this.label10);
            this.panData.Controls.Add(this.label1);
            this.panData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panData.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panData.Location = new System.Drawing.Point(750, 3);
            this.panData.Name = "panData";
            this.panData.Size = new System.Drawing.Size(244, 675);
            this.panData.TabIndex = 6;
            // 
            // ct_ceri_sau
            // 
            this.ct_ceri_sau.Location = new System.Drawing.Point(73, 114);
            this.ct_ceri_sau.MaxLength = 50;
            this.ct_ceri_sau.Multiline = true;
            this.ct_ceri_sau.Name = "ct_ceri_sau";
            this.ct_ceri_sau.Size = new System.Drawing.Size(146, 33);
            this.ct_ceri_sau.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(14, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 47;
            this.label6.Text = "제출용도";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 12);
            this.label3.TabIndex = 43;
            this.label3.Text = "※ 증명서 발급을 위한 입력란입니다";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(243, 1);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1, 673);
            this.panel7.TabIndex = 46;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(1, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(243, 1);
            this.panel6.TabIndex = 45;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 674);
            this.panel2.TabIndex = 44;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 674);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(244, 1);
            this.panel4.TabIndex = 42;
            // 
            // ct_ceri_lang
            // 
            this.ct_ceri_lang.FormattingEnabled = true;
            this.ct_ceri_lang.Items.AddRange(new object[] {
            "국문",
            "영문"});
            this.ct_ceri_lang.Location = new System.Drawing.Point(73, 174);
            this.ct_ceri_lang.Name = "ct_ceri_lang";
            this.ct_ceri_lang.Size = new System.Drawing.Size(146, 20);
            this.ct_ceri_lang.TabIndex = 6;
            // 
            // ct_ceri_kind
            // 
            this.ct_ceri_kind.FormattingEnabled = true;
            this.ct_ceri_kind.Items.AddRange(new object[] {
            "재직",
            "경력"});
            this.ct_ceri_kind.Location = new System.Drawing.Point(73, 91);
            this.ct_ceri_kind.Name = "ct_ceri_kind";
            this.ct_ceri_kind.Size = new System.Drawing.Size(146, 20);
            this.ct_ceri_kind.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(14, 178);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 3;
            this.label13.Text = "발급언어";
            // 
            // ct_ceri_cnt
            // 
            this.ct_ceri_cnt.Location = new System.Drawing.Point(73, 198);
            this.ct_ceri_cnt.MaxLength = 1;
            this.ct_ceri_cnt.Multiline = true;
            this.ct_ceri_cnt.Name = "ct_ceri_cnt";
            this.ct_ceri_cnt.Size = new System.Drawing.Size(146, 21);
            this.ct_ceri_cnt.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(14, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 3;
            this.label8.Text = "발급부수";
            // 
            // ct_ceri_date
            // 
            this.ct_ceri_date.Location = new System.Drawing.Point(73, 150);
            this.ct_ceri_date.Mask = "0000-00-00";
            this.ct_ceri_date.Name = "ct_ceri_date";
            this.ct_ceri_date.Size = new System.Drawing.Size(146, 21);
            this.ct_ceri_date.TabIndex = 5;
            this.ct_ceri_date.ValidatingType = typeof(System.DateTime);
            // 
            // ct_ceri_num
            // 
            this.ct_ceri_num.Location = new System.Drawing.Point(73, 67);
            this.ct_ceri_num.MaxLength = 9;
            this.ct_ceri_num.Name = "ct_ceri_num";
            this.ct_ceri_num.ReadOnly = true;
            this.ct_ceri_num.Size = new System.Drawing.Size(146, 21);
            this.ct_ceri_num.TabIndex = 2;
            // 
            // ct_ceri_empno
            // 
            this.ct_ceri_empno.Location = new System.Drawing.Point(73, 43);
            this.ct_ceri_empno.MaxLength = 9;
            this.ct_ceri_empno.Name = "ct_ceri_empno";
            this.ct_ceri_empno.Size = new System.Drawing.Size(146, 21);
            this.ct_ceri_empno.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(14, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "발급번호";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(2, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "증명서종류";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(14, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "사원번호";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(14, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "발급일자";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(741, 675);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.empnoSearch);
            this.panel1.Controls.Add(this.nameSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 34);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(657, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 44;
            this.button1.Text = "재발급";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 33);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(735, 1);
            this.panel5.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(2, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "사원번호";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(167, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "이름";
            // 
            // empnoSearch
            // 
            this.empnoSearch.Location = new System.Drawing.Point(61, 2);
            this.empnoSearch.Name = "empnoSearch";
            this.empnoSearch.Size = new System.Drawing.Size(100, 21);
            this.empnoSearch.TabIndex = 1;
            // 
            // nameSearch
            // 
            this.nameSearch.Location = new System.Drawing.Point(202, 2);
            this.nameSearch.Name = "nameSearch";
            this.nameSearch.Size = new System.Drawing.Size(100, 21);
            this.nameSearch.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ceri_number,
            this.ceri_empno,
            this.bas_name,
            this.ceri_date,
            this.ceri_kind,
            this.ceri_sau,
            this.ceri_lang,
            this.ceri_cnt});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 43);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(735, 609);
            this.dataGridView1.TabIndex = 7;
            // 
            // ceri_number
            // 
            this.ceri_number.DataPropertyName = "ceri_num";
            this.ceri_number.HeaderText = "발급번호";
            this.ceri_number.Name = "ceri_number";
            this.ceri_number.ReadOnly = true;
            this.ceri_number.Width = 78;
            // 
            // ceri_empno
            // 
            this.ceri_empno.DataPropertyName = "ceri_empno";
            this.ceri_empno.HeaderText = "사원번호";
            this.ceri_empno.Name = "ceri_empno";
            this.ceri_empno.ReadOnly = true;
            this.ceri_empno.Width = 78;
            // 
            // bas_name
            // 
            this.bas_name.DataPropertyName = "bas_name";
            this.bas_name.HeaderText = "이름";
            this.bas_name.Name = "bas_name";
            this.bas_name.ReadOnly = true;
            this.bas_name.Width = 54;
            // 
            // ceri_date
            // 
            this.ceri_date.DataPropertyName = "ceri_date";
            this.ceri_date.HeaderText = "발급일자";
            this.ceri_date.Name = "ceri_date";
            this.ceri_date.ReadOnly = true;
            this.ceri_date.Width = 78;
            // 
            // ceri_kind
            // 
            this.ceri_kind.DataPropertyName = "ceri_kind";
            this.ceri_kind.HeaderText = "발급종류";
            this.ceri_kind.Name = "ceri_kind";
            this.ceri_kind.ReadOnly = true;
            this.ceri_kind.Width = 78;
            // 
            // ceri_sau
            // 
            this.ceri_sau.DataPropertyName = "ceri_sau";
            this.ceri_sau.HeaderText = "제출용도";
            this.ceri_sau.Name = "ceri_sau";
            this.ceri_sau.ReadOnly = true;
            this.ceri_sau.Width = 78;
            // 
            // ceri_lang
            // 
            this.ceri_lang.DataPropertyName = "ceri_lang";
            this.ceri_lang.HeaderText = "발급언어";
            this.ceri_lang.Name = "ceri_lang";
            this.ceri_lang.ReadOnly = true;
            this.ceri_lang.Width = 78;
            // 
            // ceri_cnt
            // 
            this.ceri_cnt.DataPropertyName = "ceri_cnt";
            this.ceri_cnt.HeaderText = "발급부수";
            this.ceri_cnt.Name = "ceri_cnt";
            this.ceri_cnt.Width = 78;
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
            this.Size = new System.Drawing.Size(997, 701);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panData.ResumeLayout(false);
            this.panData.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panData;
        private System.Windows.Forms.TextBox ct_ceri_sau;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox ct_ceri_lang;
        public System.Windows.Forms.ComboBox ct_ceri_kind;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox ct_ceri_cnt;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.MaskedTextBox ct_ceri_date;
        private System.Windows.Forms.TextBox ct_ceri_num;
        private System.Windows.Forms.TextBox ct_ceri_empno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox empnoSearch;
        private System.Windows.Forms.TextBox nameSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ceri_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn ceri_empno;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ceri_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn ceri_kind;
        private System.Windows.Forms.DataGridViewTextBoxColumn ceri_sau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ceri_lang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ceri_cnt;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
