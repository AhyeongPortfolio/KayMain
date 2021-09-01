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
            this.Rwud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dept_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dept_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dept_names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dept_seq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dept_upp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dept_sdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dept_edate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dept_use = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datasys1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datasys2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datasys3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.grpYN = new System.Windows.Forms.ComboBox();
            this.edateBox = new System.Windows.Forms.MaskedTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.sdateBox = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.namesBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.codeBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.uppBox = new System.Windows.Forms.TextBox();
            this.seqBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cdgGrpcd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cdgUse = new System.Windows.Forms.ComboBox();
            this.label34 = new System.Windows.Forms.Label();
            this.cdgName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1016, 659);
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1010, 613);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rwud,
            this.dept_code,
            this.dept_name,
            this.dept_names,
            this.dept_seq,
            this.dept_upp,
            this.dept_sdate,
            this.dept_edate,
            this.dept_use,
            this.datasys1,
            this.datasys2,
            this.datasys3});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(734, 607);
            this.dataGridView1.TabIndex = 0;
            // 
            // Rwud
            // 
            this.Rwud.HeaderText = "상태";
            this.Rwud.Name = "Rwud";
            this.Rwud.Width = 54;
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
            this.panel1.Controls.Add(this.edateBox);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.sdateBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.namesBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.nameBox);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.codeBox);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.uppBox);
            this.panel1.Controls.Add(this.seqBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(743, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 607);
            this.panel1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 90;
            this.label3.Text = "사용여부";
            // 
            // grpYN
            // 
            this.grpYN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.grpYN.FormattingEnabled = true;
            this.grpYN.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.grpYN.Location = new System.Drawing.Point(99, 122);
            this.grpYN.Name = "grpYN";
            this.grpYN.Size = new System.Drawing.Size(152, 20);
            this.grpYN.TabIndex = 6;
            this.grpYN.Tag = "Codeuse";
            // 
            // edateBox
            // 
            this.edateBox.Location = new System.Drawing.Point(99, 169);
            this.edateBox.Mask = "00000000";
            this.edateBox.Name = "edateBox";
            this.edateBox.ReadOnly = true;
            this.edateBox.Size = new System.Drawing.Size(152, 21);
            this.edateBox.TabIndex = 8;
            this.edateBox.Tag = "CodeDate";
            this.edateBox.ValidatingType = typeof(System.DateTime);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 606);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(264, 1);
            this.panel4.TabIndex = 44;
            // 
            // sdateBox
            // 
            this.sdateBox.Location = new System.Drawing.Point(99, 145);
            this.sdateBox.Mask = "00000000";
            this.sdateBox.Name = "sdateBox";
            this.sdateBox.Size = new System.Drawing.Size(152, 21);
            this.sdateBox.TabIndex = 7;
            this.sdateBox.Tag = "Codesdate";
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
            this.label5.Location = new System.Drawing.Point(43, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 12);
            this.label5.TabIndex = 29;
            this.label5.Text = "부서seq";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 101);
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
            // namesBox
            // 
            this.namesBox.Location = new System.Drawing.Point(99, 51);
            this.namesBox.MaxLength = 30;
            this.namesBox.Name = "namesBox";
            this.namesBox.Size = new System.Drawing.Size(152, 21);
            this.namesBox.TabIndex = 3;
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
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(99, 27);
            this.nameBox.MaxLength = 50;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(152, 21);
            this.nameBox.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 30;
            this.label10.Text = "생성일자";
            // 
            // codeBox
            // 
            this.codeBox.Location = new System.Drawing.Point(99, 3);
            this.codeBox.MaxLength = 3;
            this.codeBox.Name = "codeBox";
            this.codeBox.Size = new System.Drawing.Size(152, 21);
            this.codeBox.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 172);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 30;
            this.label12.Text = "폐기일자";
            // 
            // uppBox
            // 
            this.uppBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.uppBox.Location = new System.Drawing.Point(99, 98);
            this.uppBox.MaxLength = 4;
            this.uppBox.Name = "uppBox";
            this.uppBox.Size = new System.Drawing.Size(152, 21);
            this.uppBox.TabIndex = 5;
            // 
            // seqBox
            // 
            this.seqBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.seqBox.Location = new System.Drawing.Point(99, 74);
            this.seqBox.MaxLength = 4;
            this.seqBox.Name = "seqBox";
            this.seqBox.Size = new System.Drawing.Size(152, 21);
            this.seqBox.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cdgGrpcd);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.cdgUse);
            this.panel3.Controls.Add(this.label34);
            this.panel3.Controls.Add(this.cdgName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1010, 34);
            this.panel3.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 33);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1010, 1);
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
            // cdgGrpcd
            // 
            this.cdgGrpcd.Location = new System.Drawing.Point(62, 2);
            this.cdgGrpcd.Name = "cdgGrpcd";
            this.cdgGrpcd.Size = new System.Drawing.Size(100, 21);
            this.cdgGrpcd.TabIndex = 60;
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
            // cdgUse
            // 
            this.cdgUse.FormattingEnabled = true;
            this.cdgUse.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.cdgUse.Location = new System.Drawing.Point(438, 2);
            this.cdgUse.Name = "cdgUse";
            this.cdgUse.Size = new System.Drawing.Size(100, 20);
            this.cdgUse.TabIndex = 56;
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
            // cdgName
            // 
            this.cdgName.Location = new System.Drawing.Point(273, 2);
            this.cdgName.Name = "cdgName";
            this.cdgName.Size = new System.Drawing.Size(100, 21);
            this.cdgName.TabIndex = 58;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1016, 659);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rwud;
        private System.Windows.Forms.DataGridViewTextBoxColumn dept_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn dept_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dept_names;
        private System.Windows.Forms.DataGridViewTextBoxColumn dept_seq;
        private System.Windows.Forms.DataGridViewTextBoxColumn dept_upp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dept_sdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dept_edate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dept_use;
        private System.Windows.Forms.DataGridViewTextBoxColumn datasys1;
        private System.Windows.Forms.DataGridViewTextBoxColumn datasys2;
        private System.Windows.Forms.DataGridViewTextBoxColumn datasys3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox grpYN;
        private System.Windows.Forms.MaskedTextBox edateBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.MaskedTextBox sdateBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox namesBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox codeBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox uppBox;
        private System.Windows.Forms.TextBox seqBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cdgGrpcd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cdgUse;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox cdgName;
    }
}
